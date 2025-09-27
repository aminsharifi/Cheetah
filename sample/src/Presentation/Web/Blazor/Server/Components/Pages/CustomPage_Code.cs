using Cheetah.Core.Aggregates.AIAggregate.Facts;
using Cheetah.Sample.Presentation.Web.Blazor.Server.AI;
using Cheetah.Sample.Presentation.Web.Blazor.Server.Components.Shared;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.SemanticKernel.Embeddings;

namespace Cheetah.Sample.Presentation.Web.Blazor.Server.Components.Pages;

public class CustomPage_Code : SharedPage
{
    public MudMessageBox mbox { get; set; }
    public F_PageTable pageTable { get; set; }
    public List<UserGuideItem>? items = new();
    public UserGuideItem currentItem = new();
    public bool isDialogOpen = false;
    public string previousName = string.Empty;
    public List<String> headers = new();
    public async Task<byte[]> TextEmbedding(string Text)
    {
#pragma warning disable SKEXP0001
        var _embedingText = _kernel.GetRequiredService<ITextEmbeddingGenerationService>();

        IList<ReadOnlyMemory<float>> embeddings =
            await _embedingText.GenerateEmbeddingsAsync(
                [
                    Text
                ]);

        var array = embeddings[0].ToArray();
        byte[] byteArray = new byte[array.Length * sizeof(float)];
        Buffer.BlockCopy(array, 0, byteArray, 0, byteArray.Length);

        return byteArray;
    }
 
    protected async override Task OnParametersSetAsync()
    {
        if (previousName != Name)
        {
            previousName = Name;
            await GetAllHeaders();
        }

        items = await GetAllItems();

        IsLoading = false;
    }

    public async Task AddNewItem()
    {
        var _userGuide_Edit = await ShowDialog();
        if (_userGuide_Edit.Canceled)
        {
            currentItem = new();
            return;
        }
        
        var _addedItem = currentItem.Adapt<F_UserGuide>();
        _addedItem.SetPageTableId(pageTable.Id);
        IsLoading = true;
        StateHasChanged();
        _addedItem.VectorBody = await TextEmbedding(_addedItem.JsonData);
        IsLoading = false;
        await _db.F_UserGuides.AddAsync(_addedItem);
        await _db.SaveChangesAsync();
        currentItem = new();
        items = await GetAllItems();        
        StateHasChanged();
    }
    public async Task EditItem(UserGuideItem item)
    {
        currentItem = item;
        var _userGuide_Edit = await ShowDialog();
        if (_userGuide_Edit.Canceled)
        {
            currentItem = new();
            return;
        }

        var _userGuide = await _db.F_UserGuides.FindAsync(item.Id);
        _userGuide.SetBody(((UserGuideItem)_userGuide_Edit.Data).Body);
        _userGuide.SetJsonData(((UserGuideItem)_userGuide_Edit.Data).JsonData);
        _userGuide.VectorBody = await TextEmbedding(_userGuide.JsonData);

        _db.Update(_userGuide);
        var _result = await _db.SaveChangesAsync();

        // var _result = await httpClient.PutAsJsonAsync("AI/Commands/UpdateUserGuide",
        // (UserGuideItem)_userGuide_Edit.Data);

        currentItem = new();
        items = await GetAllItems();
        StateHasChanged();
    }
    public async Task DeleteItem(long id)
    {
        var result = await mbox.ShowAsync();
        if (result is not null)
        {
            // var _response = await httpClient.DeleteAsync("AI/Commands/DeleteUserGuide/" + id);

            var _userGuide = await _db.F_UserGuides.FindAsync(id);
            _db.F_UserGuides.Remove(_userGuide);
            var _response = await _db.SaveChangesAsync();

            await GetAllItems();
        }

        StateHasChanged();
    }
    public async Task<DialogResult?> ShowDialog()
    {
        var options = new DialogOptions
        {
            MaxWidth = MaxWidth.Medium
        };

        var parameters = new DialogParameters<CustomPage_Edit>();

        parameters.Add(x => x.currentItem, currentItem);
        parameters.Add(x => x.pageTable, pageTable);

        var dialogresult = await DialogService.ShowAsync<CustomPage_Edit>("دستورالعمل", parameters, options);

        var result = await dialogresult.Result;

        return result;
    }
    public async Task GetAllHeaders()
    {
        pageTable = await _db.F_PageTables.Where(x => x.Name == Name).AsNoTracking().FirstAsync();
        // jsonData
        using JsonDocument _headerjsonDoc = JsonDocument.Parse(pageTable.JsonData);
        var _headerroot = _headerjsonDoc.RootElement;
        var _headers = _headerroot.EnumerateObject().Select(p => p.Name).ToList();
        headers.Clear();
        headers.AddRange(_headers);
    }
    public async Task<List<UserGuideItem>?> GetAllItems()
    {
        items = await _db.F_UserGuides
        .Where(x => x.PageTableId == pageTable.Id)
        .Select(x => x.Adapt<UserGuideItem>())
        .AsNoTracking()
        .ToListAsync();


        foreach (var item in items)
        {
            // jsonData
            using JsonDocument jsonDoc = JsonDocument.Parse(item.JsonData);
            var root = jsonDoc.RootElement;

            var _values = root.EnumerateObject().ToList();
            item.columns = headers;

            // Populate the data
            Dictionary<string, string> _jsonValues = new();

            foreach (var header in headers)
            {
                var _item = string.Empty;
                if (_values.Where(x => x.Name == header).Any())
                {
                    _item = _values.Where(x => x.Name == header).First().Value.ToString();
                }
                item.JsonValues.Add(header, _item);
            }
        }
        return items;
    }
}

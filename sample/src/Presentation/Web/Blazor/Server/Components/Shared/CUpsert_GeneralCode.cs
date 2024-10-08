﻿using BlazorServerResource = Cheetah.Presentation.Web.Blazor.Server.Resx.Localization;
namespace Cheetah.Sample.Presentation.Web.Blazor.Server.Components.Shared;
public class CUpsert_GeneralCode : SharedPage
{
    #region Methodes

    protected async Task LoadDTO()
    {
        try
        {
            Record = await simpleClassRepository.GetAsync(Name, Id);

            await ExtendedLoadDTO();

        }
        catch (Exception ex)
        {
            Snackbar.Add(ex?.InnerException?.Message ?? ex?.Message, Severity.Error);
            //await _JsRuntime.ToastrError(ex?.InnerException?.Message ?? ex?.Message);
        }
    }

    public async virtual Task ExtendedLoadDTO()
    {

    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (LoadData)
        {
            string rowAdd = globalization.GetValue(nameof(BlazorServerResource.BlazorServer_Add));
            string rowSave = globalization.GetValue(nameof(BlazorServerResource.BlazorServer_Save));

            Title = Id > 0 ? rowSave : rowAdd;
            await LoadDTO();
            if (!IsInline)
            {
                reference = _CNavigation.LoadNavigation(Address: $"Dimentions/{(Id > 0 ? "Edit" : "Create")}/{Name}/{(Id > 0 ? Id : string.Empty)}",
                RowDescription: Record.DisplayName,
                RowId: Record.Id, Reference: reference);
            }
            LoadData = false;
            StateHasChanged();
        }
        if (IsLoading)
        {
            IsLoading = false;
            StateHasChanged();
        }
        //_JsRuntime.InvokeVoidAsync("CreateToolTip");
    }

    protected async Task UpsertTask()
    {
        try
        {
            var IsNew = Record.Id == 0;

            //await _JsRuntime.InvokeVoidAsync("CreateToolTip", "Destroy");

            //Record.SetNaming();

            if (IsNew)
            {
                Record = await simpleClassRepository.CreateAsync(Record);
                LinkRecords.FixedId = Record.Id;
            }
            else
            {
                Record = await simpleClassRepository.UpdateAsync(Record);
            }

            if (LinkRecords.Sd_Status != null)
            {
                await UpdateLink();
            }

            if (IsNew)
            {
                string rowAdded = globalization.GetValue(nameof(BlazorServerResource.BlazorServer_RowAdded), new string[] { });
                Snackbar.Add(rowAdded, Severity.Success);
            }
            else
            {
                string rowSaved = globalization.GetValue(nameof(BlazorServerResource.BlazorServer_RowSaved), new string[] { Record.DisplayName });
                Snackbar.Add(rowSaved, Severity.Success);
            }

            if (!IsInline)
            {
                _CNavigation.BackNavigation(_NavigationManager);
            }
            else
            {
                await ParentCallback.InvokeAsync();
                LoadData = true;
                StateHasChanged();
            }
        }
        catch (Exception ex)
        {
            Snackbar.Add(ex?.InnerException?.Message ?? ex?.Message, Severity.Error);
            //await _JsRuntime.ToastrError(ex?.InnerException?.Message ?? ex?.Message);
        }
    }

    public async Task UpdateLink()
    {
        await simpleClassRepository.UpdateLinkAsync(LinkRecords);
    }
    #endregion
}

using Cheetah.Core.Aggregates.ProcessAggregate.Dimentions;
using Cheetah.Core.Aggregates.ProcessAggregate.Facts;
using Cheetah.Core.Aggregates.ProcessAggregate.Links;
using BlazorServerResource = Cheetah.Presentation.Web.Blazor.Server.Resx.Localization;
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
                if (Record is F_Scenario)
                {
                    #region Create Scenario
                    Record = await simpleClassRepository.CreateAsync(Record);
                    Record = Record
                        .SetERPCode(-(Record.Id))
                        .SetSortIndex(Record.Id);
                    Record = await simpleClassRepository.UpdateAsync(Record);
                    #endregion

                    #region Create Process
                    D_Process _process = new();
                    _process = (D_Process)_process
                        .SetName(Record.Name)
                        .SetDisplayName(Record.DisplayName)
                        .SetDescription(Record.Description)
                        .SetSortIndex(Record.SortIndex)
                        .SetEnableRecord(Record.EnableRecord);
                    _process = (D_Process)await simpleClassRepository.CreateAsync(_process);
                    _process.SetERPCode(-(_process.Id));
                    _process = (D_Process)await simpleClassRepository.UpdateAsync(_process);
                    #endregion

                    #region Process Scenario
                    L_ProcessScenario _processScenario = new();

                    _processScenario = (L_ProcessScenario)_processScenario
                        .SetFirstId(_process.Id)
                        .SetSecondId(Record.Id)
                        .SetSortIndex(Record.SortIndex)
                        .SetName(Record.Name)
                        .SetDisplayName(Record.DisplayName)
                        .SetDescription(Record.Description);

                    _processScenario = (L_ProcessScenario)await simpleClassRepository.CreateAsync(_processScenario);
                    _processScenario.SetERPCode(-(_processScenario.Id));
                    _processScenario = (L_ProcessScenario)await simpleClassRepository.UpdateAsync(_processScenario);
                    #endregion

                }
                else
                {
                    Record = await simpleClassRepository.CreateAsync(Record);
                }
                LinkRecords.FixedId = Record.Id;
                string rowAdded = globalization.GetValue(nameof(BlazorServerResource.BlazorServer_RowAdded), new string[] { });
                Snackbar.Add(rowAdded, Severity.Success);
            }
            else
            {
                Record = await simpleClassRepository.UpdateAsync(Record);
                string rowSaved = globalization.GetValue(nameof(BlazorServerResource.BlazorServer_RowSaved), new string[] { Record.DisplayName });
                Snackbar.Add(rowSaved, Severity.Success);
            }

            //if (LinkRecords.Sd_Status != null)
            //{
            //    await UpdateLink();
            //}

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

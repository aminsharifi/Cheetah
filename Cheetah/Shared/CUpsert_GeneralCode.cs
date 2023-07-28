using Cheetah.Helper;
using Microsoft.JSInterop;
using MudBlazor;

namespace Cheetah.Shared
{
    public class CUpsert_GeneralCode : SharedPage
    {
        #region Methodes

        protected async Task LoadDTO()
        {
            try
            {
                Record = await simpleClassRepository.Get(Name, Id);

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
                Title = (Id > 0) ? "ذخیره" : "ایجاد";
                await LoadDTO();
                if (!IsInline)
                {
                    reference = _CNavigation.LoadNavigation(Address: $"Dimentions/{((Id > 0) ? "Edit" : "Create")}/{Name}/{((Id > 0) ? Id : String.Empty)}",
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
                var IsNew = (Record.Id == 0 || Record.Id is null);

                //await _JsRuntime.InvokeVoidAsync("CreateToolTip", "Destroy");

                Record.SetName();

                if (IsNew)
                {
                    Record = await simpleClassRepository.Create(Record);
                    LinkRecords.fixedId = Record.Id;
                }
                else
                {
                    Record = await simpleClassRepository.Update(Record);
                }

                if (LinkRecords.sd_Status != null)
                {
                    await UpdateLink();
                }

                if (IsNew)
                {
                    Snackbar.Add("ردیف با موفقیت ایجاد شد", Severity.Success);
                }
                else
                {
                    Snackbar.Add($"ردیف {Record.DisplayName} با موفقیت ذخیره شد", Severity.Success);
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
            await simpleClassRepository.UpdateLink(LinkRecords);
        }
        #endregion
    }
}

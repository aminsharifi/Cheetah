using Cheetah.Helper;
using Microsoft.JSInterop;

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
                await _JsRuntime.ToastrError(ex?.InnerException?.Message ?? ex?.Message);
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
                    RowDescription: Record.PDisplayName,
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
                var IsNew = (Record.Id == 0);

                await _JsRuntime.InvokeVoidAsync("CreateToolTip", "Destroy");

                Record.SetName();

                if (IsNew)
                {
                    Record = await simpleClassRepository.Create(Record);
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
                    await _JsRuntime.ToastrSuccess("ردیف با موفقیت ایجاد شد");
                else
                    await _JsRuntime.ToastrSuccess($"ردیف {Record.PDisplayName} با موفقیت ذخیره شد");

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
                await _JsRuntime.ToastrError(ex?.InnerException?.Message ?? ex?.Message);
            }
        }

        public async Task UpdateLink()
        {
            await simpleClassRepository.UpdateLink(LinkRecords);
        }
        #endregion
    }
}

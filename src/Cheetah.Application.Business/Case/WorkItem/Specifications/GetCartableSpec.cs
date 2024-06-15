namespace Cheetah.Application.Business.WorkItem.Specifications;

public class GetCartableSpec : Specification<F_WorkItem>
{
    public GetCartableSpec(CartableDTO cartableDTO, CartableProperty? cartableProperty)
    {
        if (cartableProperty == CartableProperty.Inbox)
        {
            Query
                .Where(x =>
                x.WorkItemStateId == D_WorkItemState.Inbox.Id);
        }
        else if (cartableProperty == CartableProperty.Outbox)
        {
            Query
                .Where(x =>
                x.WorkItemStateId == D_WorkItemState.Sent.Id);
        }

        Query
            .Where(x =>
            x.Case.EnableRecord &&
            x.EnableRecord);

        if (cartableDTO.User is not null)
        {
            var UserID = cartableDTO.User.Id;

            Query.Where(x => x.UserId == UserID);
        }
        if (cartableDTO.Process is not null)
        {
            var ProcessId = cartableDTO.Process.Id;

            Query.Where(x => x.Case.ProcessId == ProcessId);
        }
        if (cartableDTO.CaseState is not null)
        {
            var CaseStateId = cartableDTO.CaseState.Id;

            Query.Where(x => x.Case.CaseStateId == CaseStateId);
        }
        if (cartableDTO.CaseStateList is not null)
        {
            var _caseStateIds = cartableDTO.CaseStateList.Select(x => x.Id).ToList();

            Query.Where(x => x.Case.CaseStateId.HasValue && _caseStateIds.Contains(x.Case.CaseStateId.Value));
        }
        if (cartableDTO.Case is not null)
        {
            var CaseId = cartableDTO.Case.Id;
            Query.Where(x => x.CaseId == CaseId);
        }

        if (cartableDTO.WorkItem is not null)
        {
            var workItemId = cartableDTO.WorkItem.Id;
            Query.Where(x => x.Id == workItemId);
        }
        long _PageSize = 0;

        long _PageNumber = 0;

        if (cartableDTO.PageSize is not null)
        {
            _PageSize = cartableDTO.PageSize.Value;
            _PageNumber = cartableDTO.PageNumber.Value;
            Query
                .Skip(Convert.ToInt32(_PageSize * (_PageNumber - 1)))
                .Take(Convert.ToInt32(_PageSize));
        }
    }
}
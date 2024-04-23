namespace Cheetah.Application.Business.Services;

public class Cartable(ISender iSender) : ICartable
{  

    public async Task<Result<IEnumerable<F_Case>>> GetCaseAsync(F_Case Case, D_Process Process)
    {
        var _GetDetailCases = await iSender.Send(new GetDetailCasesQuery(Case));

        return _GetDetailCases;
    }

    public async Task<Result<IEnumerable<CartableDTO>>> InboxAsync(CartableDTO cartableDTO)
    {
        var _GetCartableQuery = await iSender.Send(new GetCartableQuery(cartableDTO, CartableProperty.Inbox));
        return _GetCartableQuery;
    }
    public async Task<Result<IEnumerable<CartableDTO>>> OutboxAsync(CartableDTO cartableDTO)
    {
        var _GetCartableQuery = await iSender.Send(new GetCartableQuery(cartableDTO, CartableProperty.Outbox));
        return _GetCartableQuery;
    }
}

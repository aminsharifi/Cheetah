﻿using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Enums;

namespace Cheetah.Application.Business.Services;

public class Cartable(ISender iSender, IMemoryCache _cache, IRepository<D_Process> processRepository) : ICartable
{

    public async Task<Result<IEnumerable<F_Case>>> GetCaseAsync(SimpleClassDTO Case, SimpleClassDTO Process)
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

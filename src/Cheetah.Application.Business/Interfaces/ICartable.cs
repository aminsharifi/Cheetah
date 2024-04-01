﻿namespace Cheetah.Application.Business.Interfaces;
public interface ICartable
{
    public Task<Result<IEnumerable<CartableDTO>>> InboxAsync(CartableDTO cartableDTO);
    public Task<Result<IEnumerable<CartableDTO>>> OutboxAsync(CartableDTO cartableDTO);
    public Task<Result<IEnumerable<F_Case>>> GetCaseAsync(F_Case request);
}
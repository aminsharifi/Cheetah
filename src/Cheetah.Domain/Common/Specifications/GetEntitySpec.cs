using Cheetah.Domain.Common.DTOs;

namespace Cheetah.Domain.Common.Specifications;

/// <summary>
/// Get Entity with its id or other related properties
/// </summary>
/// <typeparam name="T">Entity type</typeparam>
public class GetEntitySpec<T> : Specification<T> where T : BaseEntity
{
    /// <summary>
    /// Get entity with its id
    /// </summary>
    /// <param name="Id">id of entity</param>
    public GetEntitySpec(long Id)
    {
        Query.Where(x => x.Id == Id);
        Query.EnableCache(nameof(GetEntitySpec<T>), Id);
        Query.AsNoTracking();
    }

    /// <summary>
    /// Get entity with its related properties
    /// </summary>
    /// <param name="input">Related properties</param>
    /// <param name="EnableTrack">Set track of entity</param>
    public GetEntitySpec(SimpleClassDTO input, bool? EnableTrack = false)
    {
        var Find = false;

        Query.EnableCache(nameof(GetEntitySpec<T>), input);

        if (EnableTrack == false)
        {
            Query.AsNoTracking();
        }
        if (input.Id != 0)
        {
            Find = true;
            Query.Where(x => x.Id == input.Id);
        }

        if (!string.IsNullOrEmpty(input.Name))
        {
            Find = true;
            Query.Where(x => x.Name.ToLower() == input.Name.ToLower());
        }

        if (input.ERPCode is not null && input.ERPCode != 0)
        {
            Find = true;
            Query.Where(x => x.ERPCode == input.ERPCode);
        }
    }
}
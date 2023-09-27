using Cheetah.Domain.Dimentions;
using Cheetah.Domain.Links;

namespace Cheetah.Application.Business.Repository;
public interface ISync
{
    public Task<D_User> GetUser(D_User d_User);
    public Task<D_Position> GetPosition(D_Position d_Position);
    public Task<D_Location> GetLocation(D_Location d_Location);
    public Task<Boolean> SyncUser(IEnumerable<D_User> Users);
    public Task<Boolean> SyncPosition(IEnumerable<D_Position> v_UserPositions);
    public Task<Boolean> SyncLocation(IEnumerable<D_Location> v_Locations);
    public Task<Boolean> Sync_UserPosition(IEnumerable<L_UserPosition> v_UserPositions);
    public Task<Boolean> Sync_UserLocation(IEnumerable<L_UserLocation> v_UserLocations);
}
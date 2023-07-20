using Cheetah_Business.Dimentions;

namespace Cheetah_Business.Repository
{
    public interface ISync
    {
        public Task<int> Syncing(String TableName);
        public Task<D_User> GetUser(String PName);
        public Task<Boolean> SyncUser();
        public Task<D_Position> GetPosition(String PName);
        public Task<Boolean> SyncPosition();
        public Task<D_Location> GetLocation(String PName);
        public Task<Boolean> SyncLocation();
        public Task<Boolean> Sync_UserPosition();
        public Task<Boolean> Sync_UserLocation();
    }
}

namespace Cheetah_Business.Repository.IRepository.General
{
    using Cheetah_DataAccess.Masters;
    using System;


    public interface IProcessRepository
    {
        public Task<M_RequestInformation> CreateProcess(String Input);
        public Task<M_RequestInformation> GetProcess(long id);
    }
}

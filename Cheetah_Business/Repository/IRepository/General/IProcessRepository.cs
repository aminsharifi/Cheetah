namespace Cheetah_Business.Repository.IRepository.General
{
    using Cheetah_DataAccess.Facts;
    using System;


    public interface IProcessRepository
    {
        public Task<F_RequestInformation> CreateProcess(String Input);
        public Task<F_RequestInformation> GetProcess(long id);
    }
}

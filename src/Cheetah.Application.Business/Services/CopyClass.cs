using Ardalis.SharedKernel;
using Cheetah.Application.Business.Interfaces;

namespace Cheetah.Application.Business.Services;
public class CopyClass(IRepository<BaseEntity> _repository) : ICopyClass
{
    public Task<ICollection<F_Condition>> CopyCondition(IEnumerable<F_Condition> Conditions)
    {
        throw new NotImplementedException();
    }

    public Task<F_Case> DeepCopy(F_Case obj)
    {
        throw new NotImplementedException();
    }

    public Task<F_WorkItem> DeepCopy(F_WorkItem obj)
    {
        throw new NotImplementedException();
    }

    public Task<L_CaseTaskUser> DeepCopy(L_CaseTaskUser obj)
    {
        throw new NotImplementedException();
    }

    public SimpleClassDTO GetSimpleClass(BaseEntity simpleClass)
    {
        throw new NotImplementedException();
    }

    public async Task<Int64?> GetSimpleClassId(IQueryable<BaseEntity> Q_input, BaseEntity input)
    {
        var Find = false;

        if (input.Id > 0)
        {
            Find = true;
            return input.Id;
        }

        //Q_input = Q_input.AsNoTracking();


        if (!String.IsNullOrEmpty(input.Name))
        {
            Find = true;
            Q_input = Q_input.Where(x => x.Name == input.Name);
        }

        if (input.ERPCode is not null and > 0)
        {
            Find = true;
            Q_input = Q_input.Where(x => x.ERPCode == input.ERPCode);
        }

        if (!Find)
        {
            return null;
        }


        //return await Q_input.Select(x => x.Id).SingleAsync();
        return 1;
    }
}
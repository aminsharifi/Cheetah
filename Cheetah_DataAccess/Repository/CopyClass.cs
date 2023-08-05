using AutoMapper;
using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Facts;
using Cheetah_Business.Repository;
using Cheetah_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Cheetah_DataAccess.Repository
{
    public class CopyClass : ICopyClass
    {
        protected ApplicationDbContext _db;
        protected IMapper _mapper;
        protected ISync _iSync;
        protected ITableCRUD _itableCRUD;
        public CopyClass(ApplicationDbContext db, IMapper mapper, ISync iSync, ITableCRUD itableCRUD)
        {
            _db = db;
            _iSync = iSync;
            _itableCRUD = itableCRUD;
        }

        public async Task<Int64?> GetSimpleClassId(IQueryable<SimpleClass> Q_input, SimpleClass input)
        {
            if (!String.IsNullOrEmpty(input.Name))
            {
                Q_input = Q_input.Where(x => x.Name == input.Name);
            }

            if (input.ERPCode is not null && input.ERPCode > 0)
            {
                Q_input = Q_input.Where(x => x.ERPCode == input.ERPCode);
            }

            return await Q_input.AsNoTracking()
                    .Select(x => x.Id)
                    .SingleAsync();
        }

        public async Task<F_Case> DeepCopy(F_Case obj)
        {
            var Return_Case = new F_Case();

            Return_Case.ERPCode = obj.ERPCode;

            if (obj.Conditions is not null
                   && obj.Conditions.Count > 0)
            {
                foreach (var item in obj.Conditions)
                {
                    var _condition = new F_Condition();
                    _condition.Value = item.Value;
                    _condition.TagId = await GetSimpleClassId(_db.D_Tags, item);
                    Return_Case.Conditions.Add(_condition);
                }
            }

            if (obj.CreatorId is null || obj.CreatorId == 0)
            {
                Return_Case.CreatorId = await GetSimpleClassId(_db.D_Users, obj.Creator);                
            }
            if (obj.RequestorId is null || obj.RequestorId == 0)
            {
                Return_Case.RequestorId = await GetSimpleClassId(_db.D_Users, obj.Requestor);
            }
            if (obj.ProcessId is null || obj.ProcessId == 0)
            {
                Return_Case.ProcessId = await GetSimpleClassId(_db.D_Processes, obj.Process);
            }

            Return_Case.CreateTimeRecord = DateTime.Now;   

            return Return_Case;
        }
    }
}

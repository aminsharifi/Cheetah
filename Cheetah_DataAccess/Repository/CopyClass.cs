using AutoMapper;
using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Facts;
using Cheetah_Business.Repository;
using Cheetah_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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
            var Find = false;

            if (input.Id is not null && input.Id > 0)
            {
                Find = true;
                return input.Id.Value;
            }
            Q_input = Q_input.AsNoTracking();

            if (!String.IsNullOrEmpty(input.Name))
            {
                Find = true;
                Q_input = Q_input.Where(x => x.Name == input.Name);
            }

            if (input.ERPCode is not null && input.ERPCode > 0)
            {
                Find = true;
                Q_input = Q_input.Where(x => x.ERPCode == input.ERPCode);
            }

            if (!Find)
            {
                return null;
            }

            return await Q_input.Select(x => x.Id.Value).SingleAsync();
        }

        public async Task<List<F_Condition>> CopyCondition(IEnumerable<F_Condition> Conditions)
        {
            List<F_Condition> list_condition = new List<F_Condition>();

            if (Conditions is not null
                 && Conditions.Count() > 0)
            {
                foreach (var item in Conditions)
                {
                    var _condition = new F_Condition();

                    if (item.Tag is not null)
                    {
                        _condition.TagId = await GetSimpleClassId(_db.D_Tags, item.Tag);
                    }
                    if (item.Operand is not null)
                    {
                        _condition.OperandId = await GetSimpleClassId(_db.D_Operands, item.Operand);
                    }
                    if (item.Value is not null)
                    {
                        _condition.Value = item.Value;
                    }
                    //if (item.User is not null)
                    //{
                    //    _condition.UserId = await GetSimpleClassId(_db.D_Users, item.User);
                    //}
                    list_condition.Add(_condition);
                }
            }
            return list_condition;
        }

        public async Task<F_Case> DeepCopy(F_Case obj)
        {
            var Return_Case = new F_Case();

            Return_Case.ERPCode = obj.ERPCode;

            Return_Case.Conditions = await CopyCondition(obj.Conditions);

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

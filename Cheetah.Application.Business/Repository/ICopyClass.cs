﻿using Cheetah.Domain.Data;
using Cheetah.Domain.Facts;

namespace Cheetah.Application.Business.Repository;
public interface ICopyClass
{
    public Task<F_Case> DeepCopy(F_Case obj);
    public Task<List<F_Condition>> CopyCondition(IEnumerable<F_Condition> Conditions);
    public Task<Int64?> GetSimpleClassId(IQueryable<SimpleClass> Q_input, SimpleClass input);
    public SimpleClassDTO GetSimpleClass(SimpleClass simpleClass);
}
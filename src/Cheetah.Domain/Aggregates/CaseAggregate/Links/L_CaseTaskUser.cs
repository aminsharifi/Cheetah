using Cheetah.Domain.Common;
using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Domain.Aggregates.CaseAggregate.Links;

public partial class L_CaseTaskUser : BaseLink
{
    public L_CaseTaskUser()
    {

    }
    public L_CaseTaskUser(F_Case CaseEntity, F_Task TaskEntity, D_User UserEntity)
    {
        SetTask(TaskEntity)
            .SetUser(UserEntity)
            .SetCase(CaseEntity);
    }

    public virtual F_Case? Case { get; private set; }

    public virtual F_Task? Task { get; private set; }

    public virtual D_User? User { get; private set; }

    public L_CaseTaskUser SetCase(F_Case caseEntity)
    {
        Case = Guard.Against.Null(caseEntity, nameof(caseEntity));
        SetFirstId(caseEntity?.Id);
        return this;
    }

    public L_CaseTaskUser SetTask(F_Task taskEntity)
    {
        Task = Guard.Against.Null(taskEntity, nameof(taskEntity));
        SetSecondId(taskEntity.Id);
        return this;
    }

    public L_CaseTaskUser SetUser(D_User userEntity)
    {
        User = Guard.Against.Null(userEntity, nameof(userEntity));
        SetThirdId(userEntity?.Id);
        return this;
    }

    public L_CaseTaskUser ShallowCopy()
    {
        return (L_CaseTaskUser)MemberwiseClone();
    }

}
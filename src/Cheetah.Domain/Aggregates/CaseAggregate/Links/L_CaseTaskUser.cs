namespace Cheetah.Domain.Entities.Links;

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
        this.Case = Guard.Against.Null(caseEntity, nameof(caseEntity));
        this.SetFirstId(caseEntity?.Id);
        return this;
    }

    public L_CaseTaskUser SetTask(F_Task taskEntity)
    {
        this.Task = Guard.Against.Null(taskEntity, nameof(taskEntity));
        this.SetSecondId(taskEntity.Id);
        return this;
    }

    public L_CaseTaskUser SetUser(D_User userEntity)
    {
        this.User = Guard.Against.Null(userEntity, nameof(userEntity));
        this.SetThirdId(userEntity?.Id);
        return this;
    }

    public L_CaseTaskUser ShallowCopy()
    {
        return (L_CaseTaskUser)MemberwiseClone();
    }

}
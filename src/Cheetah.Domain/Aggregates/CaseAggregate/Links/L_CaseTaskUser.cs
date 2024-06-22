namespace Cheetah.Domain.Entities.Links;

public partial class L_CaseTaskUser : BaseLink
{
    public L_CaseTaskUser()
    {

    }

    public virtual F_Case? Case { get; private set; }

    public virtual F_Task? Task { get; private set; }

    public virtual D_User? User { get; private set; }

    public L_CaseTaskUser SetCase(F_Case caseEntity)
    {
        this.Case = caseEntity;
        return this;
    }

    public L_CaseTaskUser SetTask(F_Task taskEntity)
    {
        this.Task = taskEntity;
        return this;
    }

    public L_CaseTaskUser SetUser(D_User userEntity)
    {
        this.User = userEntity;
        return this;
    }

    public L_CaseTaskUser ShallowCopy()
    {
        return (L_CaseTaskUser)MemberwiseClone();
    }

}
namespace Cheetah.Domain.Entities.Links;

public partial class L_TaskItemTask : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual F_TaskItem? TaskItem { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Task? Task { get; set; }

    public L_TaskItemTask ShallowCopy()
    {
        return (L_TaskItemTask)MemberwiseClone();
    }
}
namespace Cheetah.Domain.Dimentions;

//[Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
public partial class D_Entity : SimpleClass
{
    public bool? Display { get; set; }
}
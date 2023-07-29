using Cheetah_Business.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Dimentions;

[Table(nameof(D_CaseState), Schema = nameof(TableType.Dimentions))]
[Index(nameof(Name), IsUnique = true, AllDescending = true)]
[Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(ERPCode), IsUnique = false, AllDescending = true)]
[Index(nameof(EnableRecord), IsUnique = false, AllDescending = true)]
//[Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
public partial class D_CaseState : SimpleClass
{
    #region Relations

    #endregion


}
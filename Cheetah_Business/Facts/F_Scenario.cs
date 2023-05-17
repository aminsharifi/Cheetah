﻿using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Links;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cheetah_Business.Facts
{
    [Table(nameof(F_Scenario), Schema = nameof(TableType.Facts))]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class F_Scenario : BaseClass<F_Scenario>
    {

        #region Relations

        [UseSorting]
        [UseFiltering]
        public virtual ICollection<F_Condition>? EP_Conditions { get; set; } = new HashSet<F_Condition>();

        [UseSorting]
        [UseFiltering]
        public virtual ICollection<F_Endorsement>? EP_Endorsements { get; set; } = new HashSet<F_Endorsement>();

        [UseSorting]
        [UseFiltering]
        public virtual ICollection<L_ProcessScenario>? EP_ProcessScenarios { get; set; } = new HashSet<L_ProcessScenario>();

        #endregion

        public override void SetName()
        {
            foreach (var item in EP_Conditions)
            {
                item.SetName();
            }
            foreach (var item in EP_Endorsements)
            {
                item.SetName();
            }
        }
    }
}
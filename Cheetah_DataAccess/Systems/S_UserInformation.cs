namespace Cheetah_DataAccess.Systems
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Masters;
    using Cheetah_DataAccess.Parameters;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("S_UserInformation", Schema = "Systems")]
    public partial class S_UserInformation : BasePSClass
    {
        [StringLength(50)]
        public string? UI_FirstName { get; set; }

        [StringLength(50)]
        public string? UI_LastName { get; set; }
        public bool? UI_NotifByEmail { get; set; }
        public bool? UI_NotifByMessenger { get; set; }
        public bool? UI_NotifByCell { get; set; }

        [StringLength(100)]
        public string? UI_ContactEmail { get; set; }

        [StringLength(100)]
        public string? UI_ContactMessenger { get; set; }

        [StringLength(20)]
        public string? UI_ContactCell { get; set; }
        public byte[]? UI_UserPicture { get; set; }
        [StringLength(20)]
        public string? UI_NationalCode { get; set; }
        public DateTime? UI_Birthdate { get; set; }

        [StringLength(50)]
        public string? UI_InternalPhone { get; set; }
        [StringLength(512)]
        public String? UI_Address { get; set; }
        [StringLength(215)]
        public String? UI_RegistrationNumber { get; set; }
    }
}
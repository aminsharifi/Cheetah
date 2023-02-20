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
        [Column(Order = 100)]
        public string? UI_FirstName { get; set; }

        [StringLength(50)]
        [Column(Order = 101)]
        public string? UI_LastName { get; set; }
        [Column(Order = 102)]
        public bool? UI_NotifByEmail { get; set; }
        [Column(Order = 103)]
        public bool? UI_NotifByMessenger { get; set; }
        [Column(Order = 104)]
        public bool? UI_NotifByCell { get; set; }

        [StringLength(100)]
        [Column(Order = 105)]
        public string? UI_ContactEmail { get; set; }

        [StringLength(100)]
        [Column(Order = 106)]
        public string? UI_ContactMessenger { get; set; }

        [StringLength(20)]
        [Column(Order = 107)]
        public string? UI_ContactCell { get; set; }
        [Column(Order = 108)]
        public byte[]? UI_UserPicture { get; set; }
        [StringLength(20)]
        [Column(Order = 109)]
        public string? UI_NationalCode { get; set; }
        [Column(Order = 110)]
        public DateTime? UI_Birthdate { get; set; }

        [StringLength(50)]
        [Column(Order = 111)]
        public string? UI_InternalPhone { get; set; }
        [StringLength(512)]
        [Column(Order = 112)]
        public String? UI_Address { get; set; }
        [StringLength(215)]
        [Column(Order = 113)]
        public String? UI_RegistrationNumber { get; set; }
    }
}
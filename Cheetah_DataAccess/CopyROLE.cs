namespace CheetahClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

  
    public partial class CopyROLE
    {      
        public CopyROLE()
        {
        }

        [Key]
        public int idRole { get; set; }

        [Required]
        [StringLength(26)]
        public string roleName { get; set; }

        public Guid guidRole { get; set; }
    }
}

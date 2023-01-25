namespace CheetahClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class SubRequestTitle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idSubRequestTitles { get; set; }

        public int? finalEnt { get; set; }

        public Guid guidSubRequestTitles { get; set; }

        public bool dsblSubRequestTitles { get; set; }

        public byte dplySubRequestTitles { get; set; }

        public int? SRT_Code { get; set; }

        [StringLength(200)]
        public string SRT_Name { get; set; }

        public long? RequestTitles { get; set; }

        public virtual RequestTitle RequestTitle { get; set; }
    }
}

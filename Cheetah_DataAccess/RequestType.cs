namespace CheetahClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RequestType")]
    public partial class RequestType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idRequestType { get; set; }

        public int? finalEnt { get; set; }

        public Guid guidRequestType { get; set; }

        public bool dsblRequestType { get; set; }

        public byte dplyRequestType { get; set; }

        public int? RequestType_Code { get; set; }

        [StringLength(50)]
        public string RequestType_Name { get; set; }
    }
}

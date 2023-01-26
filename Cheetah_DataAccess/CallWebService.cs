namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CallWebService")]
    public partial class CallWebService
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idCallWebService { get; set; }

        public int finalEnt { get; set; }

        public long baCreatedTime { get; set; }

        public Guid baGuid { get; set; }

        [StringLength(500)]
        public string URL { get; set; }

        [Column(TypeName = "ntext")]
        public string JsonInputBody { get; set; }

        public long? Status { get; set; }

        public bool? WSResult { get; set; }

        public int? WSResult_Code { get; set; }

        [StringLength(2500)]
        public string WSResult_Desc { get; set; }

        public long? RequestInformation { get; set; }

        public virtual RequestInformation RequestInformation1 { get; set; }
    }
}

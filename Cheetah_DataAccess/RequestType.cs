namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RequestType")]
    public partial class RequestType
    {

        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idRequestType { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Simple Prob
        public int? RequestType_Code { get; set; }

        [StringLength(50)]
        public string RequestType_Name { get; set; } 
        #endregion
    }
}

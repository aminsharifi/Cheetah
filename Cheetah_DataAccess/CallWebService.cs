namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CallWebService")]
    public partial class CallWebService
    {
        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idCallWebService { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Basic Prop
        [StringLength(500)]
        public string URL { get; set; }

        [Column(TypeName = "ntext")]
        public string JsonInputBody { get; set; }

        public bool? WSResult { get; set; }

        public int? WSResult_Code { get; set; }

        [StringLength(2500)]
        public string WSResult_Desc { get; set; }
        #endregion

        #region Relations        
        public virtual ParameterList? ParameterListStatus { get; set; }        
        public virtual RequestInformation? RequestInformation { get; set; } 
        #endregion
    }
}

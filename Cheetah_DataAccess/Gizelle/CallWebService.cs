namespace Cheetah_DataAccess.Gizelle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CallWebService
    {
        //Passed
        #region Common Prop
        [Key]
        public long IdRecord { get; set; }
        public long TimeRecord { get; set; } = DateTime.Now.Ticks;
        public Guid GuidRecord { get; set; } = Guid.NewGuid();
        public bool DsblRecord { get; set; } = false;
        #endregion

        #region Basic Prop
        [StringLength(500)]
        public string? CWS_URL { get; set; }

        [Column(TypeName = "ntext")]
        public string? CWS_JsonInputBody { get; set; }

        public bool? CWS_WSResult { get; set; }

        public int? CWS_WSResult_Code { get; set; }

        [StringLength(2500)]
        public string? CWS_WSResult_Desc { get; set; }
        #endregion

        #region Relations        
        public long CWS_idParameterList { get; set; }
        [ForeignKey("CWS_idParameterList")]
        public virtual ParameterList? CWS_ParameterList { get; set; }
        public long CWS_idRequestInformation { get; set; }
        [ForeignKey("CWS_idRequestInformation")]
        public virtual RequestInformation? CWS_RequestInformation { get; set; }
        #endregion
    }
}

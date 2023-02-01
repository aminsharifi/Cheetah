namespace Cheetah_DataAccess.Masters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("M_CallWebService")]
    public partial class M_CallWebService : BaseClass
    {
        //Passed

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
        
        #region ParameterList
        public virtual P_ParameterList? CWS_ParameterList { get; set; } 
        #endregion

        #region RequestInformation
        public virtual M_RequestInformation? CWS_RequestInformation { get; set; } 
        #endregion

        #endregion
    }
}

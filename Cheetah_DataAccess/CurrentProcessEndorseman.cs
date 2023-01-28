namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CurrentProcessEndorseman
    {
        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idCurrentProcessEndorsemen { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Simple Prop
        public bool? CU_Active { get; set; } 
        #endregion

        #region Collection
        public long? RequestGoods { get; set; }
        public long? CU_ProcessEndorsements { get; set; }

        public long? RequestInformation { get; set; }

        public long? CU_UserAction { get; set; }

        public long? UserActionsProcess { get; set; }

        public int? CU_User { get; set; }

        public long? MeetingManagement { get; set; }

        public virtual ProcessEndorsement ProcessEndorsement { get; set; }

        public virtual UserAction UserAction { get; set; }

        public virtual UserActionsProcess UserActionsProcess1 { get; set; }

        public virtual WFUSER WFUSER { get; set; }

        public virtual RequestInformation RequestInformation1 { get; set; } 
        #endregion
    }
}

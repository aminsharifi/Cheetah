namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Approve
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idApproves { get; set; }

        public int? finalEnt { get; set; }

        public DateTime? Approves_TaskRecieveDate { get; set; }

        public DateTime? Approves_TaskSentDate { get; set; }

        public int? Approves_UserInCharge { get; set; }

        public long? Approves_UserAction { get; set; }

        [StringLength(1024)]
        public string Approves_UserDescription { get; set; }

        public long? RequestInformation { get; set; }

        [StringLength(50)]
        public string Approves_Subject { get; set; }

        [StringLength(50)]
        public string Approves_Number { get; set; }

        public byte? Approves_Attachment { get; set; }

        public long? Knowledge { get; set; }

        public long baCreatedTime { get; set; }

        public Guid baGuid { get; set; }

        public virtual RequestInformation RequestInformation1 { get; set; }

        public virtual UserAction UserAction { get; set; }

        public virtual WFUSER WFUSER { get; set; }
    }
}

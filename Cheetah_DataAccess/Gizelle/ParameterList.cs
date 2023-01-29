namespace Cheetah_DataAccess.Gizelle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ParameterList")]
    public partial class ParameterList
    {

        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idParameterList { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Basic Prop

        [StringLength(500)]
        [Description("نام")]
        public string Name { get; set; }

        [Description("کد")]
        public int? Code { get; set; }

        [StringLength(50)]
        public string CodeStr { get; set; }

        [Description("ترتیب")]
        public int? Ordering { get; set; }
        public long? PValue { get; set; }

        [Column(TypeName = "ntext")]
        [Description("توضیحات")]
        public string Dsc { get; set; }
        #endregion

        #region Relation

        #region Entity
        public virtual ParameterType parameterType { get; set; }
        #endregion

        #region Collection

        #endregion

        #endregion
    }
}

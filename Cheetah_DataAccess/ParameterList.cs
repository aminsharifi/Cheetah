namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
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
        public string Name { get; set; }

        public int? Code { get; set; }

        [StringLength(50)]
        public string CodeStr { get; set; }

        public int? Ordering { get; set; }

        [Column(TypeName = "ntext")]
        public string Dsc { get; set; }
        #endregion

        #region Relation
        
        #region Entity
        public long? ParameterType { get; set; }
        public long? PValue { get; set; }
        #endregion
        
        #region Collection
        public virtual ParameterType ParameterType1 { get; set; }  
        #endregion

        #endregion
    }
}

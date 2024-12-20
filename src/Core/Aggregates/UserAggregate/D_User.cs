﻿using Cheetah.Core.Aggregates.UserAggregate.Links;
using Cheetah.Core.Common;

namespace Cheetah.Core.Aggregates.UserAggregate.Dimentions;
public partial class D_User : BaseEntity<D_User>, IAggregateRoot
{
    public D_User()
    {

    }

    #region Common Prop
    #endregion

    #region Simple Prob    
    public string? Domain { get; private set; }
    public bool? EnabledForAssignation { get; private set; }
    public bool? DelegateEnabled { get; private set; }
    public bool? CreatedCasesSkipAssigRules { get; private set; }
    public string? IDPersonel { get; private set; }
    public string? LDAPDescription { get; private set; }

    #endregion

    #region Relations

    #region Entity   

    #region S_User

    public long? DelegateId { get; private set; }
    public virtual D_User? Delegate { get; private set; }

    public long? ManagerId { get; private set; }
    public virtual D_User? Manager { get; private set; }

    public long? UserInformationId { get; private set; }
    public virtual D_UserInformation? UserInformation { get; private set; }
    #endregion

    #endregion

    #region Collection
    public virtual ICollection<L_UserCondition>? UserConditions { get; private set; } = new HashSet<L_UserCondition>();
    #endregion

    #endregion

    public D_User ShallowCopy()
    {
        return (D_User)MemberwiseClone();
    }

}
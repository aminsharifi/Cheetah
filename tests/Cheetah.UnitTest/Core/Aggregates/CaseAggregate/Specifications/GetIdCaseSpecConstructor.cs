using Cheetah.Core.Aggregates.CaseAggregate.Specifications;
using Cheetah.Core.Entities.Dimentions;
using Cheetah.Core.Entities.Facts;

namespace Cheetah.UnitTest.Core.Aggregates.CaseAggregate.Specifications;

public class GetIdCaseSpecConstructor
{
    [Fact]
    public void FilterCollectionToOnlyReturnCaseIdWithIsOngoingOrEditing()
    {
        #region Arrange
        long _processId = 1;
        long _eRPCode = 1;
        long _id = 1;

        F_Case _item1 = (F_Case)new F_Case()
            .SetProcessId(_processId)
            .SetCaseStateId(D_CaseState.Ongoing.Id)
            .SetERPCode(_eRPCode)
            .SetId(_id);

        F_Case _item2 = (F_Case)new F_Case()
            .SetProcessId(2)
            .SetCaseStateId(D_CaseState.Ongoing.Id)
            .SetERPCode(2)
            .SetId(2);

        F_Case _item3 = (F_Case)new F_Case()
            .SetProcessId(3)
            .SetCaseStateId(D_CaseState.Editing.Id)
            .SetERPCode(3)
            .SetId(3);

        var items = new List<F_Case>() { _item1, _item2, _item3 };
        #endregion

        #region Act
        var _spec = new GetIdCaseSpec(processId: _processId, eRPCode: _eRPCode);
        var filteredList = _spec.Evaluate(items);
        #endregion

        #region Assert
        Assert.Contains(_item1.Id, filteredList);
        Assert.DoesNotContain(_item2.Id, filteredList);
        Assert.DoesNotContain(_item3.Id, filteredList);
        #endregion
    }
}

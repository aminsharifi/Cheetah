using Cheetah.Application.Business.Case.Specifications;
using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.UnitTest.Core.Aggregates.CaseAggregate.Specifications;

public class GetDetailCasesSpecConstructor
{
    [Fact]
    public void GetDetailCasesWithERPCode()
    {
        #region Arrange        
        long _eRPCode = 1;

        SimpleClassDTO _inputItem = new SimpleClassDTO() { ERPCode = _eRPCode };

        F_Case _item1 = (F_Case)new F_Case()
            .SetERPCode(_eRPCode);

        F_Case _item2 = (F_Case)new F_Case()
            .SetERPCode(2);

        F_Case _item3 = (F_Case)new F_Case()
            .SetERPCode(3);

        var items = new List<F_Case>() { _item1, _item2, _item3 };
        #endregion

        #region Act
        var _spec = new GetDetailCasesSpec(request: _inputItem);
        var filteredList = _spec.Evaluate(items);
        #endregion

        #region Assert
        Assert.Contains(_item1, filteredList);
        Assert.DoesNotContain(_item2, filteredList);
        Assert.DoesNotContain(_item3, filteredList);
        #endregion
    }
}

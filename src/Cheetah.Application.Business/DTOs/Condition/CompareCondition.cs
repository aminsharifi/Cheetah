namespace Cheetah.Application.Business.DTOs.Condition;

public static class CompareConditionClass
{
    public static bool Handle(IEnumerable<F_Condition> Actual_Conditions, IEnumerable<F_Condition> Expected_Conditions)
    {
        var _notSame = Expected_Conditions.Where(x => !Actual_Conditions.Select(y => y.Id).Contains(x.Id)).Any();

        if (!_notSame)
        {
            return true;
        }

        var cnt_con = Expected_Conditions.Count();

        var ConditionOccur = 0;

        Parallel.ForEach(Expected_Conditions, _expected_Condition =>
        {
            var Operand_Name = _expected_Condition.Operand.Name;

            switch (Operand_Name)
            {
                case string Equals when Actual_Conditions
                .Where(x => x.TagId == _expected_Condition.TagId)
                .Where(x => x.Value == _expected_Condition.Value)
                .Any() && Equals == D_Operand.Equals.Name:

                case string NotEquals when Actual_Conditions
                .Where(x => x.TagId == _expected_Condition.TagId)
                .Where(x => x.Value != _expected_Condition.Value)
                .Any() && NotEquals == D_Operand.NotEquals.Name:
                    ConditionOccur++;
                    break;
            }
        });

        var _isTheSame = ConditionOccur == cnt_con;

        return _isTheSame;
    }
}

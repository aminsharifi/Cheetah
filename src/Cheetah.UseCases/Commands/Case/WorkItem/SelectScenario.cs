using Cheetah.Core.DTOs.Condition;
using Cheetah.Core.Entities.Facts;
using Cheetah.UseCases.Queries.Condition.List;
using Cheetah.UseCases.Queries.Process.ProcessScenario.List;

namespace Cheetah.UseCases.Commands.Case.WorkItem;

public static class SelectScenario
{
    public static async Task<F_Case> Handle(ISender iSender, F_Case f_Case)
    {
        var pc_ProcessScenarios = (await iSender.Send(new ListProcessScenarioQuery(f_Case.ProcessId.Value))).Value;

        if (pc_ProcessScenarios.Count() == 1)
        {
            f_Case.SetSelectedScenario(pc_ProcessScenarios.First().SecondId);
        }
        else
        {
            var Actual_ConditionsIds = f_Case.CaseConditions.Select(x => x.SecondId.Value);

            var Actual_Conditions = (await iSender.Send(new ListIncludedConditionsQuery(Actual_ConditionsIds))).Value;

            foreach (var ProcessScenario in pc_ProcessScenarios)
            {
                var ConditionOccures = false;

                var Expected_ConditionsIds = ProcessScenario
                    .Scenario.ScenarioConditions.Select(x => x.SecondId);

                var Expected_Conditions = (await iSender.Send(new ListIncludedConditionsQuery(Actual_ConditionsIds))).Value;

                ConditionOccures = CompareConditionClass.Handle(Actual_Conditions, Expected_Conditions);

                if (ConditionOccures)
                {
                    f_Case.SetSelectedScenario(ProcessScenario.Scenario.Id);
                    break;
                }
            }
        }
        return f_Case;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheetah.Application.Business.CaseTaskUser.Get;

public record GetByCaseAndTaskQuery(long caseId, long taskId) : IQuery<Result<L_CaseTaskUser?>>;

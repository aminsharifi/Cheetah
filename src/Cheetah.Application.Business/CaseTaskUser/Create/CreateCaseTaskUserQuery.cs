using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheetah.Application.Business.CaseTaskUser.Create;

public record CreateCaseTaskUserQuery(L_CaseTaskUser input) : IQuery<Result<L_CaseTaskUser>>;

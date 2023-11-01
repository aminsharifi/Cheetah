using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheetah.Application.Business.Repository;
public interface IGlobalization
{
    public String GetValue(String Key, object[]? arg0);
}

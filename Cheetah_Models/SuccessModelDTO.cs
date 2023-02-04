using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheetah_Models
{
    public class SuccessModelDTO
    {
        public Int32? StatusCode { get; set; }
        public String? ErorrMessage { get; set; }
        public object Data { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheetah_Business.Exceptions
{
    public class ErrorResult
    {
        public List<string> Messages { get; set; } = new();
        public string? Source { get; set; }
        public string? Exception { get; set; }
        public string? ErrorId { get; set; }
        public string? SupportMessage { get; set; }
        public int StatusCode { get; set; }
    }
}

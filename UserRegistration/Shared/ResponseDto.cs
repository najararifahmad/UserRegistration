using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration.Shared
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object? Data { get; set; }
        public int? TotalItems { get; set; }
    }
}

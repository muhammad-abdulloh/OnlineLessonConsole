using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLessonConsole.BaseResponseModels
{
    public class BaseResponse
    {
        public string? ErrorMessage { get; set; }
        public object? Value { get; set; }
    }
}

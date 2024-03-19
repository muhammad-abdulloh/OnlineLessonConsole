using OnlineLessonConsole.BaseResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLessonConsole.Exceptions
{
    public class BaseException
    {
        public Exception? Exception { get; set; }

        public BaseException(DivideByZeroException? ex)
        {
            Exception = ex;
        }

        public BaseResponse EqualToZeroException()
        {
            return new BaseResponse
            {
                ErrorMessage = Exception.Message,
            };
        }
        
    }
}

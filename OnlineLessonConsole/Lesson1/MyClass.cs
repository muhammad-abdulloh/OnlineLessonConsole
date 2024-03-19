using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OnlineLessonConsole.Lesson1
{

    public  class Parent : IMyInterface
    {
        public string Add()
        {
            throw new NotImplementedException();
        }

        public string Add1()
        {
            throw new NotImplementedException();
        }

        public string Add2()
        {
            throw new NotImplementedException();
        }


    }



    public class Corners
    {
        public Corners(params string[] letters) 
        {
           
        }
    }

    public class SecondClass
    {
        public SecondClass()
        {
            
        }
    }
}

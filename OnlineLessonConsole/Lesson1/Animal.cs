using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLessonConsole.Lesson1
{
    // logicani yashirish
    public  class Animal
    {
        public Animal()
        {
            
        }
        public Animal(int num)
        {
            Number = num;
        }

        public Animal(int a, int b)
        {
            Number = a + b;
        }

        public int Number { get; set; }
    }

}

using OnlineLessonConsole.Lesson1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLessonConsole.Models
{
    public class Triangle : Shape
    {
        public int Perimeter()
        {
          
            return MyProperty;
        }
    }

    public class Rectangle : Animal
    {
        public override string Eat()
        {
            throw new NotImplementedException();
        }

        public override string EyesColor()
        {
            throw new NotImplementedException();
        }

        public override int LegsCount()
        {
            throw new NotImplementedException();
        }

        public override string Name()
        {
            throw new NotImplementedException();
        }

        public int Perimeter()
        {
            Shape shape = new Shape();

            shape.MyProperty = 23432;

            return shape.MyProperty;
        }
    }
}

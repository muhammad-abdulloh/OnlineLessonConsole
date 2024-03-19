
using OnlineLessonConsole.Exceptions;
using OnlineLessonConsole.Lesson1;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace OnlineLessonConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            
            List<string> list = new List<string>(); 


        }

        public static int Sum(params Parent[] numbers)
        {
            var sum = 0;
            foreach (Parent number in numbers)
            {
                //sum += number.Age;
            }
            return sum;
        }


        // procedure
        public static void Max(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("a katta b dan");
            }
        }

        public double Area(double x, double y)
        {
            var z = x * y / 2;

            return z;
        }
            
    }
}

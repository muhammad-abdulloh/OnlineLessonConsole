using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLessonConsole.Lesson1
{
    // interfacedan object obomedi
    // class vs interface
    // multiple inheritance
    // SOLID => I => Interface Segregation Prinsple => bo'lib tasha va boshqar
    public interface IMyInterface : IMyInterface12, IMyInterface11
    {
        public string Add();

        public string Add1();
        public string Add2();
    }

    public interface IMyInterface12
    {
        public string Add()
        {
            return "";
        }

        public string Add1();
        public string Add2();
    }

    public interface IMyInterface11
    {
        public string Add()
        {
            return "";
        }

        public string Add1();
        public string Add2();
    }
}

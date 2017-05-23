using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student:Person
    {

        public new void WriteInfo()
        {
            Console.WriteLine("我是学生");
        }
        public override void Task()
        {
            Console.WriteLine("我要学习");
        }
    }
}

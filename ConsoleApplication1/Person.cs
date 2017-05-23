using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person
    {
        public void WriteInfo()
        {
            Console.WriteLine("我是人类");
        }
        public virtual void Task()
        {
            Console.WriteLine("我要工作");
        }
    }
}

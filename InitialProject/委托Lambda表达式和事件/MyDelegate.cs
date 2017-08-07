using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托Lambda表达式和事件
{
    public delegate void Geeeting(string name);
    /// <summary>
    /// 委托，解耦
    /// </summary>
    public class MyDelegate
    {
        public void GreetingChina(string name)
        {
            Console.WriteLine("{0},早上好",name);
        }
        public void GreetingEngliht(string name)
        {
            Console.WriteLine("{0},Hello", name);
        }

        public void GreetingHandel(string name,Geeeting geeting)
        {
            geeting.Invoke(name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //++x和x++的区别，++x在计算之前值已经加起来了，x++是计算之后才出来的，所以第一个条件为true,第二个条件为false
            int x = 5;
            if (++x == 6) Console.WriteLine("++x");
            if (x++ == 7) Console.WriteLine("x++");

            //as
            object number = 3;
            string bumber1 = number as string;
            
            Console.ReadLine();
        }
    }
}

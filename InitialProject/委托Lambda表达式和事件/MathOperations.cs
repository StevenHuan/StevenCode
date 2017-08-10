using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托Lambda表达式和事件
{
    public class MathOperations
    {
        public double MultipyByTwo(double value)
        {
            return value * 2;
        }

        public double Squary(double value)
        {
            return value * value;
        }

        public string GetQuery(double value)
        {
            return "Hello" + value;
        }
    }
}

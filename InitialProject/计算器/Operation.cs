using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器
{
    public class Operation
    {
        public double NumberA { get; set; }

        public double NumberB { get; set; }

        public virtual Double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    public class OperationAdd : Operation
    {
        public OperationAdd(Double numberA,double numberB)
        {
            this.NumberA = numberA;
            this.NumberB = numberB;
        }
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }

    public class OperationSub: Operation
    {
        public OperationSub(Double numberA, double numberB)
        {
            this.NumberA = numberA;
            this.NumberB = numberB;
        }
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }

    public class OperationRide : Operation
    {
        public OperationRide(Double numberA, double numberB)
        {
            this.NumberA = numberA;
            this.NumberB = numberB;
        }
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }

    public class OperationGet : Operation
    {
        public OperationGet(Double numberA, double numberB)
        {
            this.NumberA = numberA;
            this.NumberB = numberB;
        }
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)  
            {
                Console.WriteLine("除数不能为零"); 
            }
            else
            {
                result = NumberA / NumberB;
            }
            return result;
        }
    }
}

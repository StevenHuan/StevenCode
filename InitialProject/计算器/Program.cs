using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用封装、继承、多态实现计算器
            Operation operation = new Operation();
            Console.Write("第一个数:");
            operation.NumberA = Convert.ToDouble(Console.ReadLine());
            Console.Write("运算符号:");
            string Comoute = Console.ReadLine();
            Console.Write("第二个数:");
            operation.NumberB = Convert.ToDouble(Console.ReadLine());
            operation = OperationQuery(Comoute,operation);
            Console.Write("结果:{0}",operation.GetResult());
            Console.ReadKey();
        }

        public static Operation OperationQuery(string compute,Operation operation)
        {
            switch (compute)
            {
                case "+":
                    operation = new OperationAdd(operation.NumberA,operation.NumberB);
                    break;
                case "-":
                    operation =  new OperationSub(operation.NumberA, operation.NumberB);
                    break;
                case "*":
                    operation = new OperationRide(operation.NumberA, operation.NumberB);
                    break;
                case "/":
                    operation = new OperationGet(operation.NumberA, operation.NumberB);
                    break;
                default:
                    Console.WriteLine("不支持该操作符号");
                    break;
            }
            return operation;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托Lambda表达式和事件
{
    class Program
    {
        //1、定义委托
        private delegate string GetAString();

        /// <summary>
        /// MathOperations的委托
        /// </summary>
        /// <returns></returns>
        public delegate double DoubleOp(double operation);

        static void Main(string[] args)
        {
            //委托：就是将方法当做参数传递给另一个方法，委托是一种特殊类型的对象，他的特殊在于我们之前定义的所有对象都包含数据，而委托包含的只是一个或多个方法的地址
            //使用委托的步骤：1、定义委托 2、创建委托的一个或多个实例
            //注意：他的每个实例都可以包含一个方法的引用，并且该方法返回类型和参数都必须和委托一致
            //创建委托语法public delegate string IntMethidInvoker(int x);
            //委托常见的访问修饰符:public 、private、protected
            //委托实现为派生类System.MulticasDelegate，派生类又继承了System.Delegate
            //委托可以理解为一个类，方法是他的字段，这个类有一个参数的构造函数，他具有类的大部分功能

            //2、实例化委托1
            //委托实际相当于一个创建构造函数，不过他有点特殊，他是只接受一个参数的构造函数，并且这个参数的返回值可以通过这个实例化调用
            GetAString getAstring = new GetAString(FirstStringMethod);
            //注意：使用实例化的委托时加上括号
            Console.WriteLine("使用委托得出来的值:{0}", getAstring.Invoke());
            ////或者这样写
            //GetAString getAString = FirstStringMethod;
            //Console.WriteLine("{0}",getAString());

            Console.WriteLine("*******常见的委托*******");
            MathOperations mathOperation = new MathOperations();
            //实例化两个委托
            DoubleOp[] operations = {  mathOperation.MultipyByTwo,
                                        mathOperation.Squary
                                    };

            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine("******{0}******", i);
                //将委托传入方法
                ProcessAndDisplayNumber(operations[i], 2.0);
                ProcessAndDisplayNumber(operations[i], 7.0);
                ProcessAndDisplayNumber(operations[i], 1.414);
            }

            //泛型委托
            //Action<T>表示引用一个void返回类型的方法，他可以传递至多16种不同的参数类型Action<int T1,int T8>
            //Func<T>允许调用带返回类型的方法，Func<int T,out TResult>
            //Func<T>,参数是double,返回值是double
            Console.WriteLine("*******泛型委托参数是double,返回值是double*********");
            Func<double, double>[] operationFunc = {  
                                    mathOperation.MultipyByTwo,
                                    mathOperation.Squary
                                    };
            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine("******{0}******", i);
                //将委托传入方法
                ProcessAndDisplayNumber(operations[i], 2.0);
                ProcessAndDisplayNumber(operations[i], 7.0);
                ProcessAndDisplayNumber(operations[i], 1.414);
            }

            Console.WriteLine("***********泛型委托参数是double,返回值是string*************");
            //Func<T>参数是double,返回值是string
            Func<double, string>[] operationString = { 
                                               mathOperation.GetQuery
                                                   };
            Console.WriteLine("Value {0},result {1}", 10.0, operationString[0](10.0));

            List<int> aaaa = new List<int> { 0, 5, 6, 2, 1 };
            List<int> bbb = BubbleSorter.Sort(aaaa);
            foreach (int item in bbb)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public static string FirstStringMethod()
        {
            return "Hello";
        }

        public static void ProcessAndDisplayNumber(DoubleOp action, double value)
        {
            double result = action(value);
            Console.WriteLine("Value is {0}, result of operation is {1}", value, result);
        }

        public static void ProcessAndDisplayNumber(Func<double, double> action, double value)
        {
            double result = action(value);
            Console.WriteLine("Value is {0}, result of operation is {1}", value, result);
        }
    }
}

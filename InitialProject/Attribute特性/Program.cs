#define Buged //C#宏必须出想在所有C#代码之前
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Attribute特性
{
    class Program
    {
        static void Main(string[] args)
        {
            //Attribute(特性):他是一种可由用户自由定义的修饰符(Modifier),可以用来修饰各种需要被修饰的目标
            //作用：添加元数据，元数据可以被工具支持，比如：编译器用元数据来辅助编译，调试器用元数据来调试程序
            //Attribute与注释的区别
            //注释是对程序源代码的一种说明，主要目的是给人看的，在程序编译时会被编译器所丢弃，因此，他丝毫不会影响到程序的执行。
            //而Attribute是程序代码的一部分，不但不会被编译器丢弃，而且还会被编译器编译进程序集的元数据(metadata)里,在程序运行的时候，你随时可以从元数据里提取这些附加信息来决策程序的运行
            //Attribute本质上是一个类，他在所附着的目标对象上最终实例化
            FunA();
            FunB();

            Console.Read();
        }

        [ConditionalAttribute("特性1")]
        //该特性指定只让Buged有效
        [ConditionalAttribute("Buged")]
        public static void FunA()
        {
            Console.WriteLine("方法前的特性");
        }

        [Conditional("dddd")]
        [Conditional("Bug")]
        public static void FunB()
        {
            Console.WriteLine("Bug");
        }
    }
}

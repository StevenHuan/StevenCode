using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托Lambda表达式和事件
{
    class Program
    {
        //声明一个委托类型
        public delegate int DoubleOp(string message);

        static void Main(string[] args)
        {
            //委托：作用是将方法和变量一样作为参数传递，委托的典型应用是控件的事件处理方法
            //定义委托基本是定义一个新类，所以可以再定义类的任何相同地方定义委托，常见的修饰符:public\private\protected
            //委托实现为派生自基类System.MulticastDelegate的类
            //在C#中，委托在语法上总是接受一个参数的构造函数，这个参数就是委托引用的方法

            //注意：委托定义的是什么，你传入的方法就应该怎么定义，
            //委托的作用：没有委托就没有异步，异步是基于委托来的
            //例如：定义一个返回值为int传入参数为string的委托DoubleOp，传入的参数MultSchool方法，返回值就应该是int，传入的参数应该是string
            DoubleOp doubleOp = new DoubleOp(MultSchool);
            //调用
            doubleOp.Invoke("Hello");
            //异步调用
            doubleOp.BeginInvoke("World",null,null);

            //解耦
            MyDelegate mydelegate = new MyDelegate();
            Geeeting gee = new Geeeting(mydelegate.GreetingChina);
            mydelegate.GreetingHandel("老刘",gee);
            Console.ReadLine();
        }

        public static int MultSchool(string Message)
        {
            Console.WriteLine("使用委托{0}",Message);
            return 1;
        }
    }
}

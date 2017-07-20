using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类和对象
{
    class Program
    {
        static void Main(string[] args)
        {
            //类成员的访问性public、protected、internal protected、private、internal
            //数据成员是包含类的数据、字段、常量和时间的成员
            //函数成员提供了类中数据的某些功能，包括方法、属性、构造函数和终结器、运算符以及索引器
            //终接器主要用于C#.NET中的非托管代码清理单中，通常同时实现终结器和Dispose方式，这样细心的使用者直接显示调用Dispose方法会提高垃圾回收的性能，对于粗心的使用者虽然忘记调用Dispose方法，不至于使得非托管资源得不到释放
            //ref和out的区别：ref传进去什么值里面就是什么值，out传进去后会将该值清空，就是说传进去的值是无用的

            //readonly只读字段，var匿名类型

            //在应用程序代码内实例化一个类或结构时，只要有代码引用他，就会形成强引用,就意味着垃圾回收器不会清理他的内存

            //System.Object()方法：ToString(),获取字符串，GetHashCode()，

            //ref参数结果
            int i=10;
            string Name = SomeFunction(ref i);
            Console.WriteLine("返回值{0},ref参数返回{1}",Name,i);

            //out参数
            string Usern = UserName(out i);
            Console.WriteLine("返回值{0},out参数返回{1}",Usern,i);
            
            //方法重载（即方法名相同，参数类型或个数不同）

            Console.ReadLine();
        }
        //ref
        public static string SomeFunction( ref int i)
        {
            int b = 20;
            i = i + b;
            return "好的";
        }

        //out参数
        public static string UserName(out int i) {
            int b = 20;
            i = 0;
            i = i + b;
            return "Hello";
        }

        //方法
        public void aa()
        {
            Console.WriteLine("dddd");
        }
        //方法的重载
        public void aa(string name) {
            Console.WriteLine(name);
        }

        //类
        public class User
        {
            //无参构造函数
            public User()
            {
        
            }
            //字段
            private string UserName;
            //属性
            public string UserName1
            {
                //读
                get { return UserName; }
                //写
                set { UserName = value; }
            }

            public string PassWord { get; set; }
        }
        
        //终结器(一般放在类中主要用于释放内存)
        public class MyResourceRelease : IDisposable
        { 
            ~MyResourceRelease()
            {
                Dispose(false);
            }

            ///保证资源只用释放一次
            private bool _arreadyDisposed = false;

            //用来判断释放资源的类别(托管和非托管) virtual表示虚拟方法，override重写
            protected virtual void Dispose(bool isDisposing) {
                if (_arreadyDisposed)
                {
                    return;
                }
                if (isDisposing)
                { 
                    //释放托管资源
                }
                //释放非托管资源
                _arreadyDisposed = true;
            }

            public void Dispose()
            {
                Dispose(true);
                //阻止GC把该对象放入终结器队列
                GC.SuppressFinalize(this);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Program
    {
        static void Main(string[] args)
        {
            

      
            Program pr = new Program();
            //抽象方法abstract使用override重写
            b b = new 继承.b();
            b.run();
            b.sun();
            c c = new 继承.c();
            c.run();

            Nevermore60Customer custmore = new Nevermore60Customer("鬼吹灯");
            //new

            Console.WriteLine();
            Console.ReadLine();
        }

       

        #region 继承，接口，释放内存
        //继承UserDispson(属于实现继承),多重继承(C#不允许，但允许实现多重接口继承)，UserDispson继承了IDisposable(属于接口继承)
        //
        public class User : UserDispson, IUser, IUserName
        {
            public string UserNam { get; set; }

            public string PassWord { get; set; }

            public void UserList()
            {

            }

            public string UserNameList()
            {
                return "哈哈哈哈";
            }
        }
        //接口
        public interface IUser
        {
            void UserList();
        }

        public interface IUserName
        {
            string UserNameList();
        }

        public class UserDispson : IDisposable
        {
            ~UserDispson()
            {
                Dispose(false);
            }


            ///保证资源只用释放一次
            private bool _arreadyDisposed = false;

            //用来判断释放资源的类别(托管和非托管) virtual表示虚拟方法，override重写
            protected virtual void Dispose(bool isDisposing)
            {
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
                GC.SuppressFinalize(this);
            }
        } 
        #endregion
    }

    #region 抽象 abstract,虚方法virtual,override重写
    //abstract:这个修饰符可以用于类、方法、属性、索引器和事件
    //抽象类：
    //抽象类只能是基类
    //抽象类不能实例化
    //抽象类的派生类必须实现所有的抽象方法
    //抽象类中的抽象方法是没有方法体的

    //抽象方法：
    //抽象方法是隐式的虚方法
    //抽象方法所在的类一定是抽象类，但在抽象类中的方法不一定是抽象方法
    //抽象方法在抽象类中没有实体
    //抽象方法声明时：不能使用static或者virtual修饰

    //声明一个基类函数为virtual后可以在任意派生类中重写该函数

    //注意：接口和抽象类的异同
    //从表象上来说：接口是对类局部行为的抽象，接口是对类整体(字段、属性、方法)的抽象，如果行为跨越不同类的对象，那么使用接口，对于一些相似的类对象，用继承抽象类
    //从设计角度来讲：抽象类是从子类中发现公共的东西，提取出来变成父类，然后子类继承父类，而接口是根本不知道子类的存在，方法如何实现还不确认，只是预先定义
    //抽象类往往是通过重构得来的，虚方法倾向于代码的复用
    //抽象方法在派生类中必须要重写，而虚方法不需要
    public abstract class A
    {
        public abstract void run();

        public virtual void sun()
        {
            Console.WriteLine("抽象类中的虚拟方法");
        }
    }

    public class b : A
    {
        public override void run()
        {
            Console.WriteLine("使用abstrace声明抽象类和抽象方法，子类继承抽象类后使用override重写抽象方法");
        }

        public override void sun()
        {
            Console.WriteLine("使用override重写，abstract中的virtual");
        }
     }
    #endregion

    #region base和this关键字
    //base用于在派生类中实现对基类共有或者受保护成员的访问，但是只局限在构造函数、示例方法和示例属性访问器中
    //base具体功能：调用基类上已被其他方法重写的方法；指定创建派生类实例时应调用的基类构造函数

    //this关键字，用于引用类的当前实例，也包括继承而来的方法，
    //this具体功能：
    //限定被相似的名称隐藏的成员
    //将对象作为参数传递到其他烦烦烦
    //声明索引器
    #endregion

    #region 密封类和密封方法 关键字sealed
    //使用sealed关键字表示该类或该方法不能被重写
    //应用情形：商业原因防止被人重写

    public class c : A
    {
        public sealed override void run()
        {
            Console.WriteLine("使用密封方法重写抽象方法");
        }
    }

    //报错不能重写
    //public class d : c
    //{
    //    public override void run()
    //    { 
    //         Console.WriteLine("能重写吗？");
    //    }
    //}
    #endregion

    #region 派生类 base和this
    //base表示派生类中实现对基类公有或者受保护成员的访问，但是只局限在构造函数、实例方法和示例属性访问器中
    //作用:调用基类上已被其他方法重写的方法
    //指定创建派生类实例时应调用的基类构造函数

    //this关键字：用于引用类的当前实例，也包括继承而来的方法
    //作用：限定被相似的名称影藏的成员
    //将对象作为参数传递到其他方法
    //声明索引器
    public abstract class GenericCustomer
    {
        private string name;
        public GenericCustomer(string name) {
            this.name = name;
        }
    }

    public class Nevermore60Customer : GenericCustomer
    {
        private uint highCostMinutesUsed;
        public Nevermore60Customer(string name)
            : base(name)
        { 
            
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person()
        { 
        
        }

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age)
            : this(name)
        {
            this.Age = age;
        }
    }
    #endregion

    #region 接口
    public interface ISomeClass
    {
        //类
        bool ShowName();

        //字段
        decimal Balance { get; }
    }

    public class SomeN : ISomeClass
    {
        //实现类
        public bool ShowName() {
            return true;
        }

        //实现字段
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
        }
    }


    #endregion
}

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
            //虚方法输出
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


}

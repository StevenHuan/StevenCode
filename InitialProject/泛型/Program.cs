using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    public class Program
    {
        static void Main(string[] args)
        {
            //泛型：通过参数化类型来实现在同一份代码上操作做种数据类型，利用"参数化"将类型抽象化，从而实现灵活的复用
            //情况：为了实现某一个功能我们一开始将方法写好，后来发现同样的功能我们需要再写一次但是这次方法的参数类型和上次不一样，有些人可能会想到使用重载，但是里面的东西还是一样的这就造成了代码冗余，按照敏捷软件开发的思想，不要过早的进行抽象和因对变化，当变化第一次出现时，使用最快的方法解决他，但变化出现第二次时：在进行更好的架构设计，这样的目的是为了避免过渡设计，因为有可能第二次变化永远也不会出现
            //Object类不是类型安全的
            //泛型类使用泛型类型，并可以根据需要使用特性的类型替换泛型类型，这样可以保证类型的安全性
            //泛型的优缺点：

            //使用这个需要进行装箱拆箱的操作，对性能有影响

            //泛型委托、泛型类、泛型方法、泛型返回可见Common.cs
            //泛型约束可见GenericConstraint.cs

           
            User user = new User();
            

            var list = new ArrayList();

            list.Add(44);
            list.Add("mystring");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            int a = 1;
            string b = "哇哈哈";
            const string CustId = "01006089358";
             user = new User { 
                UserName="毒枭",
                Pwd="duxiao"
            };

            UserLogin userLogin=new UserLogin
            {
                UserName="毒枭",
                Pwd="duxiao",
                Age=25
            };

            //泛型T,一个参数,指定数据类型
             Common.ShowGet<int>(a);
             Common.ShowGet<string>(b);
             Common.ShowGet<User>(user);
            //不指定参数类型
             Common.ShowGet(DateTime.Now);

            //多个参数
             Common.ShowGeAll<string,int,DateTime>(user.UserName,25,DateTime.Now,user.Pwd);


            //泛型约束
            //作用：传进去的泛型类型必须满足约束
            GenericConstraint.Get<User>(user);

            //约束他类型必须是User类型或他的派生类
            GenericConstraint.SayHi<User>(user);
            GenericConstraint.SayHi<UserLogin>(userLogin);

            GenericConstraint.Get2(user,a);
            Console.WriteLine("****** 泛型返回 ******");
            School school = new School();
            Schoolssss schoolsss = school.GetAllT<Schoolssss>("李四",20);
            Console.WriteLine("姓名:{0},年龄:{1}",schoolsss.Name,schoolsss.Age);
            Console.WriteLine("*****泛型参数*****");
            Schoolssss schoolsss1 = school.GetAllTByT<Schoolssss,string,int>("张三",10);
            Console.WriteLine("姓名:{0},年龄:{1}", schoolsss1.Name, schoolsss1.Age);

            //协变和逆变主要用在泛型的接口和委托上
            //协变和逆变指的是对参数和返回值的类型进行转换；在.NET中参数类型是协变，返回值是抗变
            //在.NET中协变和逆变语序数组类型，委托类型和泛型类型参数进行隐式引用转换，协变保留分配兼容性，逆变与之相反，关键字out,通过协变可以使用与泛型参数指定的派生类型相比，派生成更大的类型，通过逆变可以使用与泛型参数指定的派生类型相比，派生更小的类型，
            Console.ReadLine();
        }
    }

    public class User
    {
        public string UserName { get; set; }

        public string Pwd { get; set; }
    }

    public class UserLogin:User
    {
        public int Age { get; set; }
    }
}

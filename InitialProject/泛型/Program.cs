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

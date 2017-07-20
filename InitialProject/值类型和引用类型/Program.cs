using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型和引用类型
{
    class Program
    {
        //堆和栈的区别：栈是编译期间分配好的内存空间，堆是程序运行期间动态分布的内存空间
        static void Main(string[] args)
        {
            //值类型直接存储其值，引用类型存储対值的引用
            //值类型存储在栈中，引用类型存储在托管堆上
            //C#中基本数据类型都是值类型，大多数复杂的数据类型包括类都是引用类型
            //值类型：整数int,浮点:folat,double,高精度浮点decimal,布尔bool,字符char,结构struct,枚举emun
            //char类型可以隐式转换为ushort,int,uint,long,ulong,float,double,decimal,但是不存在从其他类型到char类型的隐式转换

            int a = 1;
            float b = 0.13f;
            double c=12.3333;
            decimal d=13.28374M;
            bool e=true;
            char j='f';
            //public enum User
            //{
                //f=1,
                //g=2
            //}


            //引用类型：对象Object,字符串string,类class,接口interface,委托delegate,数组int[]
            object User = new User();
            string h = "heelo word";
            int[] i=new int[4];
        }

        public class User
        {
            public string UserName { get; set; }

            public string PassWord { get; set; }
        }

        public interface IUser
        {
            bool UserLogin ( String UserName,String PassWord);
        }

        public delegate void UserList();
    }
}

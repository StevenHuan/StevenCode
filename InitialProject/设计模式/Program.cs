using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 设计模式.简单工厂模式;

namespace 设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //简单工厂模式他的原则是：封装改变
            //优点：解决了客户端直接依赖于具体对象的问题，简单工厂实现了对责任的分割,,实现了代码复用

            //实例：
            FoodSimpleFactory foodSimpleFactory=new FoodSimpleFactory();
            Food food1 = foodSimpleFactory.CreateFood("土豆肉丝");
            food1.Print();

            Food food2 = foodSimpleFactory.CreateFood("西红柿炒鸡蛋");
            food2.Print();

            //策略模式


            Console.Read();
        }
    }
}

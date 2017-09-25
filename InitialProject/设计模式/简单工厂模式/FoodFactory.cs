using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式.简单工厂模式
{
    /// <summary>
    /// 菜的抽象类
    /// </summary>
    public abstract class Food
    {
        public abstract void Print();
    }

    /// <summary>
    /// 西红柿炒蛋
    /// </summary>
    public class TomatoScrambledEgga : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份西红柿炒蛋");
        }
    }
    /// <summary>
    /// 土豆肉丝
    /// </summary>
    public class ShreddedPorkWithPotatoes : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份土豆肉丝");
        }
    }

    /// <summary>
    /// 简单工厂类
    /// </summary>
    public class FoodSimpleFactory
    {
        public Food CreateFood(string type)
        {
            Food food = null;
            if (type.Equals("土豆肉丝"))
            {
                food = new ShreddedPorkWithPotatoes();
            }
            else if (type.Equals("西红柿炒鸡蛋"))
            {
                food = new TomatoScrambledEgga();
            }
            return food;
        }
    }
}

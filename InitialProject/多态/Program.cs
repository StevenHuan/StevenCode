using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Program
    {
        static void Main(string[] args)
        {
            ///多态的实现依赖于虚方法，具有相同特征的对象对同一个动作会做出不同的处理，这是多态
            Cat cat = new Cat();
            cat.Shout();
            Dog dog = new Dog();
            dog.Shout();
            Console.ReadLine();
        }
    }

    public class Polymorphism
    {
        //声明虚方法
        public virtual void Shout()
        {
            Console.WriteLine("动物叫");
        }
    }


    public class Cat:Polymorphism
    {
        public override void Shout()
        {
            Console.WriteLine("猫在叫");
        }
    }

    public class Dog : Polymorphism
    {
        public override void Shout()
        {
            Console.WriteLine("狗在叫");
        }
    }
}

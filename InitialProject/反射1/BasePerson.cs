using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Collections;//要实现Ienumerable接口则必须制定该命名空间

namespace 反射1
{
    /// <summary>
    /// 假定一个基类，定义了一个公共方法和一个私有方法
    /// </summary>
    public  class BasePerson
    {
        public void BasePublic()
        { 
        
        }

        private void BasePrivate()
        { 
        
        }
    }

    //Person类实现了接口IEnumerable,使得类中定义的Array数组能够使用foreach枚举
    public class Person : BasePerson, IEnumerable
    {
        //姓名
        private string name = "林田惠";
        //年龄
        private int age = 20;
        //子女数组
        Array children = null;

        public Person()
        { 
        
        }

        public Person(string name, int age)
        { 
            
        }

        public string Name
        {
            get { return name; }
            set { }
        }

        public int Age
        {
            get { return age; }
            set { }
        }

        /// <summary>
        /// 年龄自增的方法
        /// </summary>
        public void AddAge()
        {
            Age += 1;
        }

        /// <summary>
        /// 定义委托
        /// </summary>
        /// <param name="x"></param>
        public delegate void PersonNameHandler(string x);

        /// <summary>
        /// 定义一个事件
        /// </summary>
        public event PersonNameHandler OnChangeName;

        /// <summary>
        /// 改名的方法
        /// </summary>
        /// <param name="nam"></param>
        public void ChangeName(string nam)
        {
            Name = nam;
        }
        //具有两个参数的方法，用来显示反射具体方法的详细信息
        public void ChangeNameAndAddAge(string name, int age)
        {
            this.Name = name;
            this.Age += age;
        }

        //实现接口
        public IEnumerator GetEnumerator()
        {
            return children.GetEnumerator();
        }
    }
}

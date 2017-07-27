using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    public class GenericConstraint
    {
        /// <summary>
        /// 泛型约束，where后面表示泛型的约束，class表示是一个引用类型
        /// 作用：表示进来的参数T必须满足这个约束
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static T Get<T>(T t) where T:class,new()
        {
            T aa = new T();
            return default(T);
        }

        /// <summary>
        /// 泛型约束，where后面表示泛型的约束，class表示是一个值类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static T GetStruct<T>(T t) where T : struct
        {
            return default(T);
        }

        /// <summary>
        /// 约束这个T的类型必须是User类型或User类型的派生类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public static void SayHi<T>(T t) where T:User
        {
            Console.WriteLine("姓名：{0},密码:{1}",t.UserName,t.Pwd);
        }

        /// <summary>
        /// 传多个参数，对每个参数都进行约束
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="S"></typeparam>
        /// <param name="t"></param>
        /// <param name="s"></param>
        public static void Get2<T, S>(T t, S s) where T:User where S:struct
        {
            Console.WriteLine("————————对多个参数进行约束————————");
            Console.WriteLine("姓名：{0},密码:{1}", t.UserName, t.Pwd);
            Console.WriteLine("年龄:{0}", s);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    public class Common
    {
        public static void ShowGet<T>(T param) {
            Console.WriteLine("值:{0}，类型：{1}",param,param.GetType());
        }

        public static void ShowGeAll<T,S,W>(T name,S age,W datetime,string pwd)
        {
            Console.WriteLine("名字叫:{0},年龄:{1},时间为:{2},密码:{3}",name,age,datetime,pwd);
        }

        /// <summary>
        /// 泛型返回
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static T Get<T>(int id, T t)
        {
            //return t;
            return default(T);
            //他会根据T的类型产生一个默认值
        }

        /// <summary>
        /// 泛型类
        /// </summary>
        /// <typeparam name="W"></typeparam>
        /// <typeparam name="S"></typeparam>
        /// <typeparam name="T"></typeparam>
        public class SomGener<W, S, T>
        { 
        
        }

        /// <summary>
        /// 泛型接口
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="S"></typeparam>
        public interface IGenericInterface<T, S>
        { 
        
        }

        /// <summary>
        /// 泛型委托
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public delegate T GetDelegate<T>();
    }
}

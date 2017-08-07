using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    /// <summary>
    /// 接口
    /// </summary>
    public interface ISchool
    {
        /// <summary>
        /// 泛型返回
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetAllT<T>(string name,int age);

        T GetAllTByT<T, S, U>(S s,U u);
    }
}

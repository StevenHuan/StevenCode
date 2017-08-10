using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    public class DBHelper:IDBHelper
    {
        public void Query()
        {
            Console.WriteLine("这里是{0}的Query",this.GetType().FullName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = WeChatUserAdapter.Instance.GetWeChatUserByNameAndPwd("13790086497");
            Console.WriteLine(result);
            Console.Read();
        }

    }
}

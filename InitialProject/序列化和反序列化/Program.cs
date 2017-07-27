using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [Serializable]
    public class User
    {
        public string Login { get; set; }

        public string Pwd { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    public class SQLDBHelper
    {
        public static string DB = ConfigurationManager.ConnectionStrings["aa"].ConnectionString;
    }
}

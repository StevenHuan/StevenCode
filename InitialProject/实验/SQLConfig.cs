using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验
{
    public class SQLConfig
    {
        //登陆用户表
        public static string MobilePlatformYuanXin = ConfigurationManager.ConnectionStrings["MobilePlatformYuanXin"].ConnectionString;

        //业务表
        public static string MobilePartner = ConfigurationManager.ConnectionStrings["MobilePartner"].ConnectionString;
    }
}

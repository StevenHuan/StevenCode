using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验
{
    public class WeChatUserAdapter:SQLConfig
    {
        public readonly static WeChatUserAdapter Instance = new WeChatUserAdapter();

        public WeChatUserAdapter()
        {

        }

        public static string GetConnSting()
        {
            return MobilePlatformYuanXin;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool GetWeChatUserByNameAndPwd(string username)
        {
            string str = string.Format(@"SELECT COUNT(*) FROM Common.WeChatUser WHERE Username='{0}'  AND ValidStatus=1",username);
            //SqlParameter[] parm = { new SqlParameter("@username",username)};
            int result = MSDNSqlHelper.ExecuteNonQuery(GetConnSting(),CommandType.Text,str,null);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

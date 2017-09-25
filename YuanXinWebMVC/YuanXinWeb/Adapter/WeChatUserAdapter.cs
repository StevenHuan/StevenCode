using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace YuanXinWeb
{
    public class WeChatUserAdapter
    {
        public readonly static WeChatUserAdapter Instance = new WeChatUserAdapter();

        public WeChatUserAdapter()
        { 
        
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool GetWeChatUserByNameAndPwd(string username,string password)
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(@"SELECT COUNT(*) FROM Common.WeChatUser WHERE Username=@username AND Password=@password AND ValidStatus=1");
            SqlParameter[] parm = { 
                      new SqlParameter("@username",username),
                      new SqlParameter("@password",password)
                                  };

        }
    }
}
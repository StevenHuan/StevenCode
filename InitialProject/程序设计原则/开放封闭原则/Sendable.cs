using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 程序设计原则
{
    public class EmailMessage:ISendable
    {
        /// <summary>
        /// 邮件发送信息
        /// </summary>
        /// <param name="strMsg"></param>
        public void SendMessage(string strMsg)
        {
            Console.WriteLine("{0}Email的节日问候", strMsg);
        }
    }

    /// <summary>
    /// 手机短信发送信息
    /// </summary>
    public class PhoneMessage : ISendable
    {
        public void SendMessage(string strMsg)
        {
            Console.WriteLine("{0}手机发送的节日问候", strMsg);
        }
    }

    /// <summary>
    /// 微信发送信息
    /// </summary>
    public class WeiXinMessage : ISendable
    {
        public void SendMessage(string strMsg)
        {
            Console.WriteLine("{0}微信发送节日问候", strMsg);
        }
    }
}

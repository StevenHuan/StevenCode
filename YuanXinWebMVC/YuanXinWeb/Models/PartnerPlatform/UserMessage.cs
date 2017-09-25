using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinWeb
{
    public class UserMessage:PartnerCommonalty
    {
        public string PartnerUserCode { get; set; }

        public int MsgType { get; set; }

        public bool MsgState { get; set; }

        public bool IsRead { get; set; }

        public string Title { get; set; }

        public string Conent { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi
{
    public class Protocol:PartnerCommonalty
    {
        public string ProtocolVersionCode { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
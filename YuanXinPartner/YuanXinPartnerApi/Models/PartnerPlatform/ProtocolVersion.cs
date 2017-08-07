using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi.Models.PartnerPlatform
{
    public class ProtocolVersion:PartnerCommonalty
    {
        public int ProtocolType { get; set; }

        public string Version { get; set; }

        public bool IsPublish { get; set; }
    }
}
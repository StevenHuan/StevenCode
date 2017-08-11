using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi
{
    public class ProjectPartnership:PartnerCommonalty
    {
        public string PartnerProjectCode { get; set; }

        public string PartnerUserCode { get; set; }

        public int UserType { get; set; }

        public string ParentCode { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi.Models.PartnerPlatform
{
    /// <summary>
    /// sc.CommissionRuleVersion
    /// </summary>
    public class CommissionRuleVersion : PartnerCommonalty
    {
        public string Version { get; set; }

        public bool IsPublish { get; set; }
    }
}
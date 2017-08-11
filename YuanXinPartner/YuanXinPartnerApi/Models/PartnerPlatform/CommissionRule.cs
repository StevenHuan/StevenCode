using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi
{
    /// <summary>
    /// sc.CommissionRule
    /// </summary>
    public class CommissionRule : PartnerCommonalty
    {
        public string PartnerProjectCode { get; set; }

        public string CommissionRuleVersionCode { get; set; }

        public string AgentRule { get; set; }

        public string IntermediaryRule { get; set; }

        public string StoreRule { get; set; }

        public string PartnerRule { get; set; }

    }
}
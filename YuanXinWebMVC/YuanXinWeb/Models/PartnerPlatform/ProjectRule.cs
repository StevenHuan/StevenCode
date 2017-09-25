using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinWeb
{
    public class ProjectRule:PartnerCommonalty
    {
        public string PartnerProjectCode { get; set; }

        public string ProjectRuleGroupName { get; set; }

        public int RuleState { get; set; }

        public DateTime BeginTime { get; set; }

        public DateTime EndTime { get; set; }

        public bool IsJumpCommission { get; set; }

        public string CommissionDescroibe { get; set; }
    }
}
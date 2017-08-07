using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi.Models.PartnerPlatform
{
    /// <summary>
    /// dbo.CapitalProjectInfo
    /// </summary>
    public class CapitalProjectInfo : PartnerCommonalty
    {
        public string InvestorsChannelCode { get; set; }

        public string CnName { get; set; }

        public string Position { get; set; }

        public string CellPhone { get; set; }

        public string InverstProjectName { get; set; }

        public string InverstProjectTypeCode { get; set; }

        public string InverstProjectSourceCode { get; set; }

        public string InverstProjectFinancingWay { get; set; }

        public string GetUserArea { get; set; }

        public string DetailedAddress { get; set; }

        public string InverstProjectPrincipal { get; set; }

        public decimal FinancingAmount { get; set; }

        public string FinancingCost { get; set; }

        public DateTime FundsUseTime { get; set; }

        public string FundsUseDeadline { get; set; }

        public string Collateral { get; set; }

        public string RepayingSource { get; set; }

        public string PrjectBrief { get; set; }

        public string Attachment { get; set; }
    }
}
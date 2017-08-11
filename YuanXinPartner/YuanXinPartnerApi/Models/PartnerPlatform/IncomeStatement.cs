using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi
{
    /// <summary>
    /// sc.IncomeStatement
    /// </summary>
    public class IncomeStatement:PartnerCommonalty
    {
        public string RecommendUserCode { get; set; }

        public string PartnerUserCode { get; set; }

        public int UserType { get; set; }

        public string PartnerProjectCode { get; set; }

        public string Buyer { get; set; }

        public string RoomNo { get; set; }

        public bool CommissionState { get; set; }

        public string ProjectRuleCode { get; set; }

        public string PropertyTypeName { get; set; }

        public decimal TotalMoney { get; set; }

        public string PayMethods { get; set; }

        public decimal CommissionRate { get; set; }

        public decimal TotalCommission { get; set; }

        public decimal JunctionCommissionRatio { get; set; }

        public decimal JunctionCommissionMoney { get; set; }

        public decimal TaxRate { get; set; }

        public decimal Taxation { get; set; }

        public string HouseTypeCode { get; set; }

        public bool IsUpdate { get; set; }
    }
}
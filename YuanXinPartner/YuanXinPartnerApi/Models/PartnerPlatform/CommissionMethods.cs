using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi.Models.PartnerPlatform
{
    /// <summary>
    /// sc.CommissionMethods
    /// </summary>
    public class CommissionMethods
    {
        public decimal Commission { get; set; }

        public float CommissionRate { get; set; }

        public decimal TotalCommission { get; set; }

        public string ProjectRuleCode { get; set; }

        public string HouseTypeCode { get; set; }

        public int BeginHouseCount { get; set; }

        public int EndHouseCount { get; set; }
    }
}
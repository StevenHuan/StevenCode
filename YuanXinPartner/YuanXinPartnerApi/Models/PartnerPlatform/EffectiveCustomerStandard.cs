using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi.Models.PartnerPlatform
{
    /// <summary>
    /// sc.EffectiveCustomerStandard
    /// </summary>
    public class EffectiveCustomerStandard
    {
        public string PartnerProjectCode { get; set; }

        public int TJTime { get; set; }

        public int TJTimeType { get; set; }

        public int DFBeginTime { get; set; }

        public int DFBeginTimeType { get; set; }

        public int DFEndTime { get; set; }

        public int DFEndTimeType { get; set; }

        public int CJTime { get; set; }

        public int CJTimeType { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi.Models.PartnerPlatform
{
    public class PriceList:PartnerCommonalty
    {
        public string PartnerProjectCode { get; set; }

        public string Name { get; set; }

        public decimal Numerical { get; set; }
    }
}
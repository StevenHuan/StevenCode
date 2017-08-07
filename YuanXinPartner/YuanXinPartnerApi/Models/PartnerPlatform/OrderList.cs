using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi.Models.PartnerPlatform
{
    public class OrderList:PartnerCommonalty
    {
        public string PartnerUserCode { get; set; }

        public string PartnerProjectCode { get; set; }

        public string PriceListCode { get; set; }

        public int OrderState { get; set; }

        public string OrderInfo { get; set; }

        public decimal TotalMoney { get; set; }
    }
}
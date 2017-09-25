using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinWeb
{
    public class RecommendUser:PartnerCommonalty
    {
        public string PartnerProjectCode { get; set; }

        public string UserName { get; set; }

        public string Phone { get; set; }

        public string PartnerUserCode { get; set; }

        public string ChannelCode { get; set; }

        public string SaleCode { get; set; }

        public string HomeConsultantCode { get; set; }

        public string AgentCompanyCode { get; set; }

        public string ConduitCompanyCode { get; set; }

        public string StoreCode { get; set; }

        public int ResommendState { get; set; }

        public string ErrorMsg { get; set; }

        public int WherePlatForm { get; set; }
    }
}
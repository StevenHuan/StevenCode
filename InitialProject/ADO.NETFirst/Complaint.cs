using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi.Models.PartnerPlatform
{
    /// <summary>
    /// sc.Complaint
    /// </summary>
    public class Complaint:PartnerCommonalty
    {
        public string RecommendUserCode { get; set; }

        public string PartnerProjectCode { get; set; }

        public string HomeConsultantCode { get; set; }

        public string Content { get; set; }

        public bool IsOk { get; set; }

        public string AuditUserCode { get; set; }

        public string AudiResule { get; set; }
    }
}
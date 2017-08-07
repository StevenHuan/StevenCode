using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi.Models.PartnerPlatform
{
    public class PartnerUser:PartnerCommonalty
    {
        public string CompanyInfoCode { get; set; }

        public string WeChatUserCode { get; set; }

        public int UserType { get; set; }

        public string RalName { get; set; }

        public string MyInvitationCode { get; set; }

        public string RegisterInvitationCode { get; set; }

        public string CommpanyMark { get; set; }

        public int AuditState { get; set; }

        public string AuditUser { get; set; }

        public DateTime AuditTime { get; set; }

        public string AuditResult { get; set; }

        public string PartnerCode { get; set; }

        public int Orgin { get; set; }

        public int Automatic { get; set; }

        public string TelePhoneForPartnerUser { get; set; }
    }
}
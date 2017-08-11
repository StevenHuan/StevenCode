using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi
{
    /// <summary>
    /// sc.CompanyInfo
    /// </summary>
    public class CompanyInfo:PartnerCommonalty
    {
        public string LegalUserName { get; set; }

        public string CompanyName { get; set; }

        public string MembershipName { get; set; }

        public string BusinessLicense { get; set; }

        public string BusinessLiesePic { get; set; }

        public string OrganizationCode { get; set; }

        public string OrginizationPic { get; set; }

        
    }
}
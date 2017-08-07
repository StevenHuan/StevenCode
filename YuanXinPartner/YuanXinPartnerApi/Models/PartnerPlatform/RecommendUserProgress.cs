using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi.Models.PartnerPlatform
{
    public class RecommendUserProgress: PartnerCommonalty
    {
        public string RecommendUserCode { get; set; }

        public int ProgressType { get; set; }
    }
}
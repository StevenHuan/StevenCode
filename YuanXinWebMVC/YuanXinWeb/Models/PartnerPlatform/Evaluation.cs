using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinWeb
{
    /// <summary>
    /// sc.Evaluation
    /// </summary>
    public class Evaluation:PartnerCommonalty
    {
        public string RecommendUserCode { get; set; }

        public string PartnerProjectCode { get; set; }

        public string HomeConsultantCode { get; set; }

        public string HomeConsultantAtti { get; set; }

        public string DescriptionState { get; set; }

        public string Content { get; set; }


    }
}
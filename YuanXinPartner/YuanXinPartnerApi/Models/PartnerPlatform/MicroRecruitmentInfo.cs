using Systemg;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;

namespace YuanXinPartnerApi.Models.PartnerPlatform
{
    /// <summary>
    /// dbo.MicroRecruitmentInfo
    /// </summary>
    public class MicroRecruitmentInfo:PartnerCommonalty
    {
        public string PostName { get; set; }

        public string Department { get; set; }

        public string WorkPlace { get; set; }

        public string JobResponsibility { get; set; }

        public string Qualification { get; set; }

        public bool IsPublish { get; set; }

        public DateTime PublishTime { get; set; }
    }
}
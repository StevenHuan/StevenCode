using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi
{
    public class News :PartnerCommonalty
    {
        public string PartnerProjectCode { get; set; }

        public string Title { get; set; }

        public string SmallPic { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public int Sort { get; set; }

        public bool State { get; set; }

        public int BrowseCount { get; set; }

        public bool IsTop { get; set; }

        public int AuditState { get; set; }

        public string AuditUser { get; set; }

        public DateTime AuditTime { get; set; }

        public string AuditResult { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi
{
    /// <summary>
    /// sc.Articles
    /// </summary>
    public class Articles:PartnerCommonalty
    {
        public int ArticleType { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public bool State { get; set; }

        public int Sort { get; set; }

    }
}
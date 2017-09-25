using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinWeb
{
    public class PropertyType:PartnerCommonalty
    {
        public string FatherCode { get; set; }

        public string CnName { get; set; }

        public string EnName { get; set; }

        public int SortNo { get; set; }

        public int VersionNo { get; set; }
    }
}
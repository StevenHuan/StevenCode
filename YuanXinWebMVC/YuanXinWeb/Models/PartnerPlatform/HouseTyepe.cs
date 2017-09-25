using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinWeb
{
    /// <summary>
    /// sc.HouseTyepe
    /// </summary>
    public class HouseTyepe:PartnerCommonalty
    {
        public string PartnerProjectCode { get; set; }

        public string CnName { get; set; }

        public string EnName { get; set; }

        public int SortNo { get; set; }

        public int VersionNo { get; set; }
    }
}
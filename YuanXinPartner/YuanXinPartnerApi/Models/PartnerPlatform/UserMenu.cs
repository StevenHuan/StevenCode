using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi
{
    public class UserMenu:PartnerCommonalty
    {
        public int MenuType { get; set; }

        public string FatherUmCode { get; set; }

        public string MenuName { get; set; }

        public bool State { get; set; }

        public int MenuOrder { get; set; }

        public string MenuMark { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinWeb
{
    /// <summary>
    /// sc.BankCardList
    /// </summary>
    public class BankCardList:PartnerCommonalty
    {
        public string PartnerUserCode { get; set; }

        public string Bank { get; set; }

        public string SuBranch { get; set; }

        public int AccountNature { get; set; }

        public string AccountName { get; set; }

        public string CardNumber { get; set; }

        public string ReservedPhone { get; set; }

       
    }
}
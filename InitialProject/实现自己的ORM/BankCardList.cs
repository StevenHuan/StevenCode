using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实现自己的ORM
{
    [Serializable]
    [ORTableMapping("SC.BankCardList")]
    public class BankCardList
    {
        [ORFieldMapping("Code")]
        public string Code { get; set; }

        [ORFieldMapping("PartnerUserCode")]
        public string PartnerUserCode { get; set; }

        [ORFieldMapping("Bank")]
        public string Bank { get; set; }

        [ORFieldMapping("SuBranch")]
        public string SuBranch { get; set; }

        [ORFieldMapping("AccountNature")]
        public int AccountNature { get; set; }

        [ORFieldMapping("AccountName")]
        public string AccountName { get; set; }

        [ORFieldMapping("CardNumber")]
        public string CardNumber { get; set; }

        [ORFieldMapping("ValidStatus")]
        public bool ValidStatus { get; set; }

        [ORFieldMapping("Creator")]
        public string Creator { get; set; }

        [ORFieldMapping("CreateTime")]
        public DateTime CreateTime { get; set; }

        [ORFieldMapping("Modifier")]
        public string Modifier { get; set; }

        [ORFieldMapping("ModifyTime")]
        public DateTime ModifyTime { get; set; }
    }

   
}

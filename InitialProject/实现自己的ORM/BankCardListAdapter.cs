using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实现自己的ORM
{
    public class BankCardListAdapter:BankCardList
    {
        public readonly static BankCardListAdapter bankCardListAdapter = new BankCardListAdapter();

        public BankCardListAdapter()
        { 
        
        }
    }
}

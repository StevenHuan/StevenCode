using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace YuanXinPartnerApi
{
    public class BankCardListController : ApiController
    {
        [HttpGet]
        public List<BankCardList> GetBankCardListAll()
        {
            string str = "SELECT * FROM SC.BankCardList where Code=@Code";
            string Code="";
            SqlParameter[] parm = { 
                                  new SqlParameter("@Code",Code)
                                  };
            SqlDataReader Reader = SqlHelper.GetDataReader(str,System.Data.CommandType.Text,null);
            List<BankCardList> list = new List<BankCardList>();
            while(Reader.Read())
            {
                BankCardList bankCardList = new BankCardList();
                bankCardList.AccountName = Reader["AccountName"].ToString();
                list.Add(bankCardList);
            }
            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
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
            string str = "SELECT * FROM SC.BankCardList where Code=@code";
            string Code = "ef31387a-f0a1-826b-4ae3-0e3ee1209a3a";
            SqlParameter[] parm = { 
                                  new SqlParameter("@code",Code)
                                  };
            //SqlDataReader Reader = SqlHelper.GetDataReader(str,System.Data.CommandType.Text,parm);
            SqlDataReader Reader = MSDNSqlHelper.ExecuteReader(MSDNSqlHelper.GetConnSting(), System.Data.CommandType.Text, str, parm);
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

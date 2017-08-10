using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


using System.Data.SqlClient;namespace ADO.NETFirst
{
    public class SqlDBHelper
    {
        public readonly static string MobilePartnerPlatform = ConfigurationManager.ConnectionStrings["MobilePartnerPlatform"].ToString();

        
        
     
    }
}

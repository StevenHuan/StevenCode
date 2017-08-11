using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi
{
    /// <summary>
    /// 访问数据库帮助类，定义他不能被继承
    /// </summary>
    public sealed class SqlHelper
    {
        public static readonly string MobilePartnerPlatform = ConfigurationManager.ConnectionStrings["MobilePartnerPlatform"].ConnectionString;

        private static SqlConnection conn;

        public static SqlConnection Conn
        {
            get {
                if (conn == null || conn.ConnectionString == string.Empty)
                {
                    conn = new SqlConnection(MobilePartnerPlatform);
                    conn.Open();
                }
                else if (Conn.State == ConnectionState.Broken)
                {
                    conn.Close();
                    conn.Open();
                }
                else if (Conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                return conn;
            }
            set { SqlHelper.conn = value; }
        }

        /// <summary>
        /// 查询返回结果的第一行第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static object GetExecuteScalar(string sql,CommandType cmdType,params SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = cmdType;
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            object result = cmd.ExecuteScalar();
            return result;
        }

        /// <summary>
        /// 返回受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static int GetExecuteNonQuery(string sql,CommandType cmdType,params SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = cmdType;
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            int result = cmd.ExecuteNonQuery();
            return result;
        }

        /// <summary>
        /// 返回DataSet结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql,CommandType cmdType,params SqlParameter[] param)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Conn);
            adapter.SelectCommand.CommandType = cmdType;
            if (param != null)
            {
                adapter.SelectCommand.Parameters.AddRange(param);
            }
            adapter.Fill(ds);
            return ds;
        }

        /// <summary>
        /// 读取操作
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static SqlDataReader GetDataReader(string sql,CommandType cmdType,params SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand(sql,Conn);
            cmd.CommandType = cmdType;
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            SqlDataReader result = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return result;
        }
    }
}
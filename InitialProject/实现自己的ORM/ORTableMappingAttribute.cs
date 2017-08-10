using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实现自己的ORM
{
    /// <summary>
    /// 加载类定义之前，用于表示表名的Attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field,AllowMultiple=false,Inherited=false)]
    public class ORTableMappingAttribute:Attribute
    {
        private string tableName = string.Empty;

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="tblName"></param>
        public ORTableMappingAttribute(string tblName)
        {
            this.tableName = tblName;
        }

        /// <summary>
        /// 表名
        /// </summary>
        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }
    }
}

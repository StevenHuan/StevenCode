using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实现自己的ORM
{
    //注意：自定义特性一定要继承Attribute
    public class DataFieldAttribute:Attribute
    {
        private string fieldName=string.Empty;

        private string fieldType=string.Empty;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="fieldType"></param>
        public DataFieldAttribute(string fieldName, string fieldType)
        {
            this.FieldName = fieldName;
            this.FieldType = fieldType;
        }

        public string FieldName
        {
            get { return fieldName; }
            set { fieldName = value; }
        }

        public string FieldType
        {
            get { return fieldType; }
            set { fieldType = value; }
        }
    }
}

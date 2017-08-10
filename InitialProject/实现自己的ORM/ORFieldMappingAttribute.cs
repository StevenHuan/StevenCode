using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实现自己的ORM
{
    /// <summary>
    /// ORM映射属性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class ORFieldMappingAttribute : Attribute
    {
        private string dataFieldName = string.Empty;
        private string format = string.Empty;
        private bool isIdenttity = false;
        private bool primaryKey = false;
        private int length = 0;
        private bool isNullable = true;

        /// <summary>
        /// 构造函数
        /// </summary>
        protected ORFieldMappingAttribute()
        {

        }

        /// <summary>
        /// 取字段对应值
        /// </summary>
        /// <param name="fieldName">字段</param>
        public ORFieldMappingAttribute(string fieldName)
        {
            this.dataFieldName = fieldName;
        }

        /// <summary>
        /// 去字段对应值
        /// </summary>
        /// <param name="fieldName">字段</param>
        /// <param name="nullable">是否为空</param>
        public ORFieldMappingAttribute(string fieldName, bool nullable)
            : this(fieldName)
        {
            this.isNullable = nullable;
        }


        /// <summary>
        /// 字段是否为空
        /// </summary>
        public bool IsNullable
        {
            get { return isNullable; }
            set { isNullable = value; }
        }

        /// <summary>
        /// 长度
        /// </summary>
        public int Length
        {
            get { return length; }
            set { length = value; }
        }


        /// <summary>
        /// 是否是主键
        /// 是返回true,否返回false
        /// </summary>
        public bool PrimaryKey
        {
            get { return primaryKey; }
            set { primaryKey = value; }
        }

        /// <summary>
        /// 是否是标识列
        /// 是返回true,否返回flase
        /// </summary>
        public bool IsIdenttity
        {
            get { return isIdenttity; }
            set { isIdenttity = value; }
        }

        /// <summary>
        /// 生成SQL Value的格式化字符串
        /// </summary>
        public string Format
        {
            get { return format; }
            set { format = value; }
        }


        /// <summary>
        /// 字段名
        /// </summary>
        public string DataFieldName
        {
            get { return dataFieldName; }
            set { dataFieldName = value; }
        }
    }

    /// <summary>
    /// 进行Mapping时忽略的属性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class NoMappingAttribute : Attribute
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinWeb
{
    /// <summary>
    /// 公共类
    /// </summary>
    public class PartnerCommonalty
    {
        /// <summary>
        /// 主键，编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string Creator { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string Modifier { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyTime { get; set; }

        /// <summary>
        /// 有效性
        /// </summary>
        public bool ValidStatus { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi.Models.PartnerPlatform
{
    /// <summary>
    /// sc.KnotCommission
    /// </summary>
    public class KnotCommission:PartnerCommonalty
    {
        public string PartnerProjectCode { get; set; }

        public string PropertyTypeCode { get; set; }

        public int EmployeeCommissionType { get; set; }

        public float EmployeeCommissionPoint { get; set; }

        public float EmployeePoint { get; set; }

        public int OwnerCommissionType { get; set; }

        public float OwnerCommissionPoint { get; set; }

        public float OwnerPoint { get; set; }

        public int GoodFaithCommissionType { get; set; }

        public float GoodFaithCommissionPoint { get; set; }

        public float GoodFaithPoint { get; set; }


    }
}
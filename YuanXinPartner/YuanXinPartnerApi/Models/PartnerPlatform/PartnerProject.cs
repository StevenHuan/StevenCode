using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinPartnerApi.Models.PartnerPlatform
{
    public class PartnerProject:PartnerCommonalty
    {
        public string ProjectCode { get; set; }

        public string CompanyInfo { get; set; }

        public string MarkName { get; set; }

        public string Name { get; set; }

        public string AdminCode { get; set; }

        public string CHannelCode { get; set; }

        public int BrowseCount { get; set; }

        public string ProviceCode { get; set; }

        public string ProviceName { get; set; }

        public string CityCode { get; set; }

        public string CityName { get; set; }

        public string CountyCode { get; set; }

        public string CountyName { get; set; }

        public string DetailAddress { get; set; }

        public string Longitude { get; set; }

        public string Latitude { get; set; }

        public decimal CommissionRate { get; set; }

        public string SurveyTel { get; set; }

        public decimal SurueyAvgMoney { get; set; }

        public int TotalPriceRange { get; set; }

        public string SurveyActivity { get; set; }

        public string SurveyExplain { get; set; }

        public string SurveyIntroduction { get; set; }

        public string LocationTitle { get; set; }

        public string LocationExplain { get; set; }

        public string FeatureIntroduction { get; set; }

        public int BuildingType { get; set; }

        public string BuildingAddress { get; set; }

        public DateTime OpenTime { get; set; }

        public DateTime CheckTime { get; set; }

        public int PropertyType { get; set; }

        public int PropertyYear { get; set; }

        public string OpenInfo { get; set; }

        public string Route { get; set; }

        public string BusTiips { get; set; }

        public int TelePhoneInterview { get; set; }

        public int Visit { get; set; }

        public int RomRange { get; set; }

        public string AreaRrangeStart { get; set; }

        public string AreaRrangeEnd{get;set;}

        public bool DisplayStart { get; set; }

        public int AuditState { get; set; }

        public string AuditUser { get; set; }

        public DateTime AuditTime { get; set; }

        public string AuditResult { get; set; }

        public bool IsAgreeProjectNotice { get; set; }

        public DateTime VersionStartTime { get; set; }

        public DateTime VersionEndTime { get; set; }

        public decimal LDXCommissionRate { get; set; }

        public bool IsUseing { get; set; }

        public bool IsUseingLDX { get; set; }

        public int DueTime { get; set; }
    }
}
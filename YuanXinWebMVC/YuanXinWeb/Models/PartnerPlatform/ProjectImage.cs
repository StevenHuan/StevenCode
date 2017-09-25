using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuanXinWeb
{
    public class ProjectImage:PartnerCommonalty
    {
        public string PartnerProjectCode { get; set; }

        public string Name { get; set; }

        public int PicType { get; set; }

        public string FilePath { get; set; }

        public string PicIntroduct { get; set; }
    }
}
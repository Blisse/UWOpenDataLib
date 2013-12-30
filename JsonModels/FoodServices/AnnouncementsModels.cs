using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.FoodServices
{
    public class FoodServicesAnnouncementsRoot : Root
    {
        public override Meta meta { get; set; }
        public List<AnnouncementsData> data { get; set; }
    }

    public class AnnouncementsData
    {
        public string date { get; set; }
        public string ad_text { get; set; }
    }
}

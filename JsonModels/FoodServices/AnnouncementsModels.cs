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
        public List<FoodServicesAnnouncementsData> data { get; set; }
    }

    public class FoodServicesAnnouncementsData
    {
        public string date { get; set; }
        public string ad_text { get; set; }
    }
}

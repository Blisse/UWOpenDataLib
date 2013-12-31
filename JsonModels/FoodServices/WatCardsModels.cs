using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.FoodServices
{
    public class FoodServicesWatCardRoot : Root
    {
        public List<FoodServicesWatCardData> data { get; set; }
    }
    public class FoodServicesWatCardData
    {
        public int vendor_id { get; set; }
        public string vendor_name { get; set; }
    }
}

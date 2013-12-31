using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.FoodServices
{
    public class FoodServicesOutletsRoot : Root
    {
        public List<OutletsData> data { get; set; }
    }

    public class OutletsData
    {
        public int outlet_id { get; set; }
        public string outlet_name { get; set; }
        public int has_breakfast { get; set; }
        public int has_lunch { get; set; }
        public int has_dinner { get; set; }
    }
}

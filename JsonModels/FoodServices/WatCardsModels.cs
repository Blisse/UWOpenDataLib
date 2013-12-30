using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.FoodServices
{
    public class FoodServicesWatCardsRoot
    {
        public Meta meta { get; set; }
        public List<WatCardsData> data { get; set; }
    }
    public class WatCardsData
    {
        public int vendor_id { get; set; }
        public string vendor_name { get; set; }
    }
}

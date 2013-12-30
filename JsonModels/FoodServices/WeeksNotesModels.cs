using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.FoodServices
{

    public class FoodServicesWeeksNotesRoot
    {
        public Meta meta { get; set; }
        public List<WeeksNotesData> data { get; set; }
    }

    public class WeeksNotesData
    {
        public string date { get; set; }
        public string outlet_name { get; set; }
        public int outlet_id { get; set; }
        public string note { get; set; }
    }
}

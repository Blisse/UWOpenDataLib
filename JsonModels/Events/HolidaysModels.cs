using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.Events
{

    public class EventsHolidaysRoot :  Root
    {
        public List<HolidaysData> data { get; set; }
    }

    public class HolidaysData
    {
        public string name { get; set; }
        public string date { get; set; }
    }

}

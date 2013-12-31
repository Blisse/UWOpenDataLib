using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.FoodServices
{

    public class FoodServicesLocationsRoot: Root
    {
        public List<FoodServicesLocationsData> data { get; set; }
    }

    public class FoodServicesLocationsData
    {
        public int? outlet_id { get; set; }
        public string outlet_name { get; set; }
        public string building { get; set; }
        public string logo { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string description { get; set; }
        public string notice { get; set; }
        public bool is_open_now { get; set; }
        public Opening_Hours opening_hours { get; set; }
        public List<Special_Hours> special_hours { get; set; }
        public List<object> dates_closed { get; set; }
    }

    public class Opening_Hours
    {
        public Sunday sunday { get; set; }
        public Monday monday { get; set; }
        public Tuesday tuesday { get; set; }
        public Wednesday wednesday { get; set; }
        public Thursday thursday { get; set; }
        public Friday friday { get; set; }
        public Saturday saturday { get; set; }
    }

    public class Day
    {
        public string opening_hour { get; set; }
        public string closing_hour { get; set; }
        public bool is_closed { get; set; }
    }

    public class Sunday : Day
    {
    }

    public class Monday : Day
    {
    }

    public class Tuesday : Day
    {
    }

    public class Wednesday : Day
    {
    }

    public class Thursday : Day
    {
    }

    public class Friday : Day
    {
    }

    public class Saturday : Day
    {
    }

    public class Special_Hours
    {
        public string date { get; set; }
        public string opening_hour { get; set; }
        public string closing_hour { get; set; }
    }

}

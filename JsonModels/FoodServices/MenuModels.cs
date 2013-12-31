using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.FoodServices
{
    public class FoodServicesMenuRoot : Root
    {
        public FoodServicesMenuData data { get; set; }
    }

    public class FoodServicesMenuData
    {
        public Date date { get; set; }
        public List<Outlet> outlets { get; set; }
    }

    public class Date
    {
        public int week { get; set; }
        public int year { get; set; }
        public string start { get; set; }
        public string end { get; set; }
    }

    public class Outlet
    {
        public string outlet_name { get; set; }
        public int outlet_id { get; set; }
        public List<Menu> menu { get; set; }
    }

    public class Menu
    {
        public string date { get; set; }
        public string day { get; set; }
        public Meals meals { get; set; }
        public string notes { get; set; }
    }

    public class Meals
    {
        public List<Lunch> lunch { get; set; }
        public List<Dinner> dinner { get; set; }
    }

    public class Lunch
    {
        public string product_name { get; set; }
        public int? product_id { get; set; }
        public string diet_type { get; set; }
    }

    public class Dinner
    {
        public string product_name { get; set; }
        public int? product_id { get; set; }
        public string diet_type { get; set; }
    }
}

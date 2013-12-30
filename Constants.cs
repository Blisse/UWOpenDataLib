using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWOpenDataLib
{
    public class Constants
    {
        private const String ApiKey = "bf4ebcb2717418c1e1be8454f6935ad9";
        public static readonly String BaseUrl = String.Format("https://api.uwaterloo.ca/v2/{1}?key={0}", ApiKey);

        public static readonly String FoodServicesMenuUrl = String.Format(BaseUrl, "foodservices/{0}/{1}/menu.json");
        public static readonly String FoodServicesNotesUrl = String.Format(BaseUrl, "foodservices/notes.json");
        public static readonly String FoodServicesOutletsUrl = String.Format(BaseUrl, "foodservices/outlets.json");
        public static readonly String FoodServicesLocationsUrl = String.Format(BaseUrl, "foodservices/locations.json");
        public static readonly String FoodServicesAnnouncementsUrl = String.Format(BaseUrl, "foodservices/announcements.json");
        public static readonly String FoodServicesWatCardUrl = String.Format(BaseUrl, "foodservices/watcard.json");
        public static readonly String FoodServicesProductsUrl = String.Format(BaseUrl,"foodservices/products/{0}.json");
        public static readonly String CoursesBaseUrl = String.Format(BaseUrl,"courses/{0}");
        public static readonly String EventsBaseUrl = String.Format(BaseUrl, "events/holidays");
        public static readonly String WeatherBaseUrl = String.Format(BaseUrl, "weather/current");
        public static readonly String ApiBaseUrl = String.Format(BaseUrl,"api/{0}");
    }
}

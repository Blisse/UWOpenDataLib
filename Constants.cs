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
        public static String BaseUrl
        {
            get
            {
                return "https://api.uwaterloo.ca/v2/{0}?key=" + ApiKey;
            }
        }

        public static readonly String FoodServicesMenuUrl = String.Format(BaseUrl, "foodservices/{0}/{1}/menu.json");
        public static readonly String FoodServicesNotesUrl = String.Format(BaseUrl, "foodservices/{0}/{1}/notes.json");
        public static readonly String FoodServicesDietsUrl = String.Format(BaseUrl, "foodservices/diets.json");
        public static readonly String FoodServicesOutletsUrl = String.Format(BaseUrl, "foodservices/outlets.json");
        public static readonly String FoodServicesLocationsUrl = String.Format(BaseUrl, "foodservices/locations.json");
        public static readonly String FoodServicesWatCardUrl = String.Format(BaseUrl, "foodservices/watcard.json");
        public static readonly String FoodServicesAnnouncementsUrl = String.Format(BaseUrl, "foodservices/{0}/{1}/announcements.json");
        public static readonly String FoodServicesProductsUrl = String.Format(BaseUrl, "foodservices/products/{0}.json");

        public static readonly String CoursesBaseUrl = String.Format(BaseUrl, "courses/{0}.json");
        public static readonly String CoursesInfoUrl = String.Format(BaseUrl, "courses/{0}/{1}.json");
        public static readonly String CoursesScheduleUrl = String.Format(BaseUrl, "courses/{0}/{1}/schedule.json");
        public static readonly String CoursesScheduleByClassNumberUrl = String.Format(BaseUrl, "courses/{0}/schedule.json");
        public static readonly String CoursesPrerequisitesUrl = String.Format(BaseUrl, "courses/{0}/{1}/prerequisites.json");
        public static readonly String CoursesExamScheduleUrl = String.Format(BaseUrl, "courses/{0}/{1}/examschedule.json");

        public static readonly String EventsHolidaysUrl = String.Format(BaseUrl, "events/holidays.json");
        public static readonly String WeatherUrl = String.Format(BaseUrl, "weather/current.json");

        public static readonly String TermsListUrl = String.Format(BaseUrl, "terms/list.json");
        public static readonly String TermsExamScheduleUrl = String.Format(BaseUrl, "terms/{0}/examschedule.json");
        public static readonly String TermsSubjectScheduleUrl = String.Format(BaseUrl, "terms/{0}/{1}/schedule.json");
        public static readonly String TermsCourseScheduleUrl = String.Format(BaseUrl, "terms/{0}/{1}/{2}/schedule.json");

        public static readonly String ApiMethodsUrl = String.Format(BaseUrl, "api/methods.json");
        public static readonly String ApiServicesUrl = String.Format(BaseUrl, "api/services.json");
    }
}

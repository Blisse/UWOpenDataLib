using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWOpenDataLib.JsonModels.Courses
{
    public class CourseData
    {
        public string course_id { get; set; }
        public string subject { get; set; }
        public string catalog_number { get; set; }
        public string title { get; set; }
        public float units { get; set; }
        public string description { get; set; }
        public List<string> instructions { get; set; }
        public string prerequisites { get; set; }
        public string antirequisites { get; set; }
        public string corequisites { get; set; }
        public string crosslistings { get; set; }
        public List<String> terms_offered { get; set; }
        public string notes { get; set; }
        public Offerings offerings { get; set; }
        public bool needs_department_consent { get; set; }
        public bool needs_instructor_consent { get; set; }
        public List<Object> extra { get; set; }
        public string calendar_year { get; set; }
        public string url { get; set; }
        public string academic_level { get; set; }
    }


    public class Offerings
    {
        public bool online { get; set; }
        public bool online_only { get; set; }
        public bool st_jerome { get; set; }
        public bool st_jerome_only { get; set; }
        public bool renison { get; set; }
        public bool renison_only { get; set; }
        public bool conrad_grebel { get; set; }
        public bool conrad_grebel_only { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.Courses
{

    public class CoursesScheduleRoot : Root
    {
        public List<ScheduleData> data { get; set; }
    }

    public class ScheduleData
    {
        public string subject { get; set; }
        public string catalog_number { get; set; }
        public float units { get; set; }
        public string title { get; set; }
        public String note { get; set; }
        public int class_number { get; set; }
        public string section { get; set; }
        public string campus { get; set; }
        public int associated_class { get; set; }
        public String related_component_1 { get; set; }
        public String related_component_2 { get; set; }
        public int enrollment_capacity { get; set; }
        public int enrollment_total { get; set; }
        public int waiting_capacity { get; set; }
        public int waiting_total { get; set; }
        public String topic { get; set; }
        public List<Reserves> reserves { get; set; }
        public List<Classes> classes { get; set; }
        public List<String> held_with { get; set; }
        public int term { get; set; }
        public string academic_level { get; set; }
        public DateTime last_updated { get; set; }
    }

    public class Reserves
    {
        public string reserve_group { get; set; }
        public int enrollment_capacity { get; set; }
        public int enrollment_total { get; set; }
    }

    public class Classes
    {
        public Dates dates { get; set; }
        public Location location { get; set; }
        public List<String> instructors { get; set; }
    }

    public class Dates
    {
        public string start_time { get; set; }
        public string end_time { get; set; }
        public string weekdays { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public bool is_tba { get; set; }
        public bool is_cancelled { get; set; }
        public bool is_closed { get; set; }
    }

    public class Location
    {
        public string building { get; set; }
        public string room { get; set; }
    }

}

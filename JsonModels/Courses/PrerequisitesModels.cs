using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.Courses
{
    public class CoursesPrerequisitesRoot:Root
    {
        public CoursesPrerequisitesData data { get; set; }
    }

    public class CoursesPrerequisitesData
    {
        public string subject { get; set; }
        public string catalog_number { get; set; }
        public string title { get; set; }
        public string prerequisites { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.Courses
{

    public class CoursesSubjectRoot : Root
    {
        public List<CourseData> data { get; set; }
    }

}

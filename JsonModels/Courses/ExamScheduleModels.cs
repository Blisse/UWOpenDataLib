using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.Courses
{

    public class ExamScheduleRoot : Root
    {
        public ExamScheduleData data { get; set; }
    }

    public class ExamScheduleData
    {
        public string course { get; set; }
        public List<Section> sections { get; set; }
    }

    public class Section
    {
        public string section { get; set; }
        public string day { get; set; }
        public string date { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        public string location { get; set; }
        public string notes { get; set; }
    }

}

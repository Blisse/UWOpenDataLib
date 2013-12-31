using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;
using UWOpenDataLib.JsonModels.Courses;

namespace UWOpenDataLib.JsonModels.Terms
{
    public class TermsExamScheduleRoot : Root
    {
        public List<TermExamScheduleData> data { get; set; } 
    }

    public class TermExamScheduleData
    {
        public string course { get; set; } 
        public List<Section> sections { get; set; }
    }
}

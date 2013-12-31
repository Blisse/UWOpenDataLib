using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;
using UWOpenDataLib.JsonModels.Courses;

namespace UWOpenDataLib.JsonModels.Terms
{
    public class TermsSubjectScheduleRoot : Root
    {
        public List<ScheduleData> data { get; set; }
    }
}

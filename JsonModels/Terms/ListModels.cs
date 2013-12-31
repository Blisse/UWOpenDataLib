using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.Terms
{

    public class TermsListRoot : Root
    {
        public TermsListData data { get; set; }
    }

    public class TermsListData
    {
        public int current_term { get; set; }
        public int previous_term { get; set; }
        public int next_term { get; set; }
        public Dictionary<String, List<TermInfo>> listings { get; set; }
    }

    public class TermInfo
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}

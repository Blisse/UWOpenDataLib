using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.APIs
{
    public class APIsMethodsRoot
    {
        public Meta meta { get; set; }
        public List<APIsMethodsData> data { get; set; }
    }

    public class APIsMethodsData
    {
        public int method_id { get; set; }
        public string method_url { get; set; }
        public int service_id { get; set; }
        public string service_name { get; set; }
        public List<string> parameters { get; set; }
        
    }
}

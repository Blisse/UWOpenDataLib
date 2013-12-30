using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.APIs
{
    public class APIsServicesRoot
    {
        public Meta meta { get; set; }
        public List<APIsServicesData> data { get; set; }
    }

    public class APIsServicesData
    {
        public string service_url { get; set; }
        public int service_id { get; set; }
        public string service_name { get; set; }
        public List<APIsServicesDataMethods> methods { get; set; }
    }

    public class APIsServicesDataMethods
    {
        public string method_id { get; set; }
        public string method_url { get; set; }
    }
}

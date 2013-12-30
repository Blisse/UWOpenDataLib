using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWOpenDataLib.JsonModels.Common
{
    public class Root
    {
        public virtual Meta meta { get; set; }
    }

    public class Meta
    {
        public int requests { get; set; }
        public int timestamp { get; set; }
        public int status { get; set; }
        public string message { get; set; }
        public int method_id { get; set; }
        public float version { get; set; }
        public Method method { get; set; }
    }

    public class Method
    {

    }
}

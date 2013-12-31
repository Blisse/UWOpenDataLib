﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.FoodServices
{
    public class FoodServicesDietRoot : Root
    {
        public List<DietData> data { get; set; }
    }

    public class DietData
    {
        public int diet_id { get; set; }
        public string diet_type { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.FoodServices
{

    public class FoodServicesProductDetailsRoot : Root
    {
        public FoodServicesProductDetailsData data { get; set; }
    }

    public class FoodServicesProductDetailsData
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string ingredients { get; set; }
        public string serving_size { get; set; }
        public int serving_size_ml { get; set; }
        public int serving_size_g { get; set; }
        public int calories { get; set; }
        public int total_fat_g { get; set; }
        public int total_fat_percent { get; set; }
        public int fat_saturated_g { get; set; }
        public int fat_saturated_percent { get; set; }
        public int fat_trans_g { get; set; }
        public int fat_trans_percent { get; set; }
        public int cholesterol_mg { get; set; }
        public int sodium_mg { get; set; }
        public int sodium_percent { get; set; }
        public int carbo_g { get; set; }
        public int carbo_percent { get; set; }
        public int carbo_fibre_g { get; set; }
        public int carbo_fibre_percent { get; set; }
        public int carbo_sugars_g { get; set; }
        public int protein_g { get; set; }
        public int vitamin_a_percent { get; set; }
        public int vitamin_c_percent { get; set; }
        public int calcium_percent { get; set; }
        public int iron_percent { get; set; }
        public string micro_nutrients { get; set; }
        public string tips { get; set; }
        public int diet_id { get; set; }
        public string diet_type { get; set; }
    }

}

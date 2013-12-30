using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;

namespace UWOpenDataLib.JsonModels.Weather
{
    public class WeatherRoot
    {
        public Meta meta { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float elevation_m { get; set; }
        public DateTime observation_time { get; set; }
        public float temperature_current_c { get; set; }
        public float humidex_c { get; set; }
        public float windchill_c { get; set; }
        public float temperature_24hr_max_c { get; set; }
        public float temperature_24hr_min_c { get; set; }
        public object precipitation_15min_mm { get; set; }
        public float precipitation_1hr_mm { get; set; }
        public float precipitation_24hr_mm { get; set; }
        public float relative_humidity_percent { get; set; }
        public float dew_point_c { get; set; }
        public float wind_speed_kph { get; set; }
        public float wind_direction_degrees { get; set; }
        public float pressure_kpa { get; set; }
        public string pressure_trend { get; set; }
        public float incoming_shortwave_radiation_wm2 { get; set; }
    }
}

using System.Collections.Generic;

namespace WeatherApp
{
    public class DisplayLocation
    {
        public string city { get; set; }
        public string state_name { get; set; }
        public string zip { get; set; }
    }

    public class CurrentObservation
    {
        public DisplayLocation display_location { get; set; }
        public string weather { get; set; }
        public string temperature_string { get; set; }
        public string relative_humidity { get; set; }
        public string wind_string { get; set; }
        public string windchill_string { get; set; }
        public string feelslike_string { get; set; }
        public string precip_today_string { get; set; }
    }

    public class RootObject
    {
        public CurrentObservation current_observation { get; set; }
    }

    public class Forecastday
    {
        public int period { get; set; }
        public string title { get; set; }
        public string fcttext { get; set; }
    }

    public class TxtForecast
    {
        public List<Forecastday> forecastday { get; set; }
    }

    public class Forecast
    {
        public TxtForecast txt_forecast { get; set; }
    }

    public class Forcast10day
    {
        public Forecast forecast { get; set; }
    }
}
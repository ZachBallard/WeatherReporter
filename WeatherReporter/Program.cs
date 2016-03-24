using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using WeatherReporter;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var userInput = "72120";
            var userInput = "Little Rock, AR";

            var mgr = new WeatherManger();
            var conditions = mgr.GetConditions(userInput);
            var forecast = mgr.GetForecast(userInput);
            var hurricanes = mgr.GetHurricanes();

            //display Conditions
            Console.WriteLine("\n===Current Conditions===");
            Console.WriteLine();

            foreach (var c in conditions)
            {
                Console.WriteLine($"{ c.current_observation.display_location.city}, " +
                                  $"{c.current_observation.display_location.state_name} {c.current_observation.display_location.zip}");
                Console.WriteLine($"\nOverall: {c.current_observation.weather}");
                Console.WriteLine($"\nTemp: {c.current_observation.temperature_string} " +
                                  $"Feels Like: {c.current_observation.feelslike_string}");
                Console.WriteLine($"\nPrecipitaion Today: {c.current_observation.precip_today_string} " +
                                  $"Humidity: {c.current_observation.relative_humidity}");
                Console.WriteLine($"\nWind: {c.current_observation.wind_string} Wind Chill: {c.current_observation.windchill_string}");
            }

            //display forecast
            Console.WriteLine("\n===10 Day Forecast===");
            foreach (var f in forecast)
            {
                for (int i = 0; i < f.forecast.txt_forecast.forecastday.Count; i++)
                {
                    Console.WriteLine($"\n{f.forecast.txt_forecast.forecastday[i].title}");
                    Console.WriteLine($"    {f.forecast.txt_forecast.forecastday[i].fcttext}");
                }
            }

            //display hurricanes
            Console.WriteLine("\n===Hurricanes===");

            if (hurricanes != null)
            {
                foreach (var h in hurricanes)
                {
                    Console.WriteLine($"    {h.currenthurricane.storminfo.stormName}");
                }
            }
            else
            {
               Console.WriteLine("     There are no hurricanes at this time");
            }

            Console.ReadLine();
        }
    }
}
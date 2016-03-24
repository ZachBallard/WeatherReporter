using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var userInput = "72120";
            //var userInput = "Little Rock, AR";

            var mgr = new WeatherManger();
            WeatherInfo weather = mgr.GetWeather(userInput);

            Console.WriteLine(weather.Temp);
            Console.WriteLine(weather.UV);
            Console.WriteLine(weather.Humidity);
            Console.WriteLine(weather.City);
            Console.WriteLine(weather.State);
        }
    }
}
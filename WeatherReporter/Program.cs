using System;
using System.Collections.Generic;
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

            var userInput = "72120";
            //var userInput = "Little Rock, AR";

            var mgr = new WeatherManger();
            var conditions = mgr.GetConditions(userInput);
            var forecast = mgr.GetForecast(userInput);

            //display Conditions
            //display forecast
            //display hurricanes
        }
    }
}
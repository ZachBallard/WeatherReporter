using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WeatherApp
{
    public class WeatherManger
    {
        public void GetWeather(string userInput)
        {
            //determine which lookup to use
            var isZip = FigureOutLookupType(userInput);


            ILookup lookup = new WUGLookup();
            var result = new List<RootObject>();
            var result2 = new List<Forcast10day>();

            if (isZip)
            {
                result = lookup.GetByZipConditions(userInput);
                result2 = lookup.GetByZipForcast();
            }
            else
            {
                result = lookup.GetByCityStateConditions(userInput);
                result2 = lookup.GetByCityStateForcast();
            }
        }

        private bool FigureOutLookupType(string userInput)
        {
            //do regex check for zip here.
            Regex rx = new Regex(@"^\d{5}(?:[-\s]\d{4})?$", RegexOptions.IgnoreCase);

            MatchCollection possibleZip = rx.Matches(userInput);

            if (possibleZip.Count != 0)
            {
                return true;
            }
            return false;
        }
    }
}
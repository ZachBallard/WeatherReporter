using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WeatherReporter
{
    public class WeatherManger
    {
        //Add hurricane getter

        public List<Forcast10day> GetForcast(string userInput)
        {
            //determine which lookup to use
            var isZip = FigureOutLookupType(userInput);


            ILookup lookup = new WUGLookup();
            var result = new List<Forcast10day>();

            return isZip ? lookup.GetByZipForcast(userInput) : lookup.GetByCityStateForcast(userInput);
        }

        public List<RootObject> GetConditions(string userInput)
        {
            //determine which lookup to use
            var isZip = FigureOutLookupType(userInput);


            ILookup lookup = new WUGLookup();
            var result = new List<RootObject>();

            return isZip ? lookup.GetByZipConditions(userInput) : lookup.GetByCityStateConditions(userInput);
        }

        public bool FigureOutLookupType(string userInput)
        {
            Regex rx = new Regex(@"^\d{5}(?:[-\s]\d{4})?$", RegexOptions.IgnoreCase);

            MatchCollection possibleZip = rx.Matches(userInput);

            return possibleZip.Count != 0;
        }
    }
}
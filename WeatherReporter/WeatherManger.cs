﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WeatherReporter
{
    public class WeatherManger
    {
        //Add hurricane getter

        public List<Forecast10day> GetForecast(string userInput)
        {
            //determine which lookup to use
            var isZip = FigureOutLookupType(userInput);


            ILookup lookup = new WUGLookup();
            var result = new List<Forecast10day>();

            return isZip ? lookup.GetByZipForecast(userInput) : lookup.GetByCityStateForecast(userInput);
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
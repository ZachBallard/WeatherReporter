using System;
using System.Collections.Generic;
using System.Xml;
using RestSharp;

namespace WeatherReporter
{
    public interface ILookup
    {
        List<RootObject> GetByCityStateConditions(string citystate);
        List<RootObject> GetByZipConditions(string zip);
        List<Forecast10day> GetByZipForecast(string zip);
        List<Forecast10day> GetByCityStateForecast(string citystate);
    }

    public class WUGLookup : ILookup
    {
        public List<RootObject> GetByCityStateConditions(string citystate)
        {
            //Today's conditions
            var client = new RestClient("http://api.wunderground.com/api/3936351a6e594384/conditions/q/");

            var request = new RestRequest($"{citystate}.json", Method.GET);

            IRestResponse<List<RootObject>> response = client.Execute.List(request);
            return response.Data;
        }

        public List<RootObject> GetByZipConditions(string zip)
        {
            //Today's conditions
            var client = new RestClient("http://api.wunderground.com/api/3936351a6e594384/conditions/q/");

            var request = new RestRequest($"{zip}.json", Method.GET);

            IRestResponse<List<RootObject>> response = client.Execute.List(request);
            return response.Data;
        }

        public List<Forecast10day> GetByZipForecast(string zip)
        {
            //10 day Forcast
            var client = new RestClient("http://example.com");

            var request = new RestRequest($"{zip}.json", Method.GET);

            IRestResponse<List<Forecast10day>> response = client.Execute.List(request);
            return response.Data;
        }

        public List<Forecast10day> GetByCityStateForecast(string citystate)
        {
            //10 day Forcast
            var client = new RestClient("http://example.com");

            var request = new RestRequest($"{citystate}.json", Method.GET);

            IRestResponse<List<Forecast10day>> response = client.Execute.List(request);
            return response.Data;
        }
    }
}
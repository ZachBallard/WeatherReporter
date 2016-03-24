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
        List<Forcast10day> GetByZipForcast(string zip);
        List<Forcast10day> GetByCityStateForcast(string citystate);
    }

    public class WUGLookup : ILookup
    {
        public List<RootObject> GetByCityStateConditions(string citystate)
        {
            //Today's conditions
            var client = new RestClient("http://example.com");

            var request = new RestRequest("resource/{id}", Method.GET);

            IRestResponse<List<RootObject>> response = client.Execute.List(request);
            return response.Data;
        }

        public List<RootObject> GetByZipConditions(string zip)
        {
            //Today's conditions
            var client = new RestClient("http://example.com");

            var request = new RestRequest("resource/{id}", Method.GET);

            IRestResponse<List<RootObject>> response = client.Execute.List(request);
            return response.Data;
        }

        public List<Forcast10day> GetByZipForcast(string userInput)
        {
            //10 day Forcast
            var client = new RestClient("http://example.com");

            var request = new RestRequest("resource/{id}", Method.GET);

            IRestResponse<List<Forcast10day>> response = client.Execute.List(request);
            return response.Data;
        }

        public List<Forcast10day> GetByCityStateForcast(string userInput)
        {
            //10 day Forcast
            var client = new RestClient("http://example.com");

            var request = new RestRequest("resource/{id}", Method.GET);

            IRestResponse<List<Forcast10day>> response = client.Execute.List(request);
            return response.Data;
        }
    }
}
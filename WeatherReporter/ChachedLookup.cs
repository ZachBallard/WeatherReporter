using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp;

namespace WeatherReporter
{
    public class CachedLookup //interface usage not ready
    {
        public List<RootObject> GetByCityStateConditions(string citystate)
        {
            throw new NotImplementedException();
        }

        public List<Forcast10day> GetByZipForcast()
        {
            throw new NotImplementedException();
        }

        public List<Forcast10day> GetByCityStateForcast()
        {
            throw new NotImplementedException();
        }

        public List<RootObject> GetByZipConditions(string zip)
        {
            throw new NotImplementedException();
        }
    }
}

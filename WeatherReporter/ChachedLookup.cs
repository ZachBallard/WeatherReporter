using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp;

namespace WeatherReporter
{
    public class CachedLookup : ILookup
    {
        public RootObject GetByCityState(string citystate)
        {
            throw new NotImplementedException();
        }

        public RootObject GetByZip(string zip)
        {
            throw new NotImplementedException();
        }
    }
}

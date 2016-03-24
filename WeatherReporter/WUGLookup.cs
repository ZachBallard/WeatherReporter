using System;

namespace WeatherApp
{
    public interface ILookup
    {
        RootObject GetByCityState(string citystate);
        RootObject GetByZip(string zip);
    }

    public class WUGLookup : ILookup
    {
        public RootObject GetByCityState(string citystate)
        {
            //RESTSHARP CODE
            throw new NotImplementedException();
        }

        public RootObject GetByZip(string zip)
        {
            //RESTSHARP CODE
            throw new NotImplementedException();
        }
    }
}
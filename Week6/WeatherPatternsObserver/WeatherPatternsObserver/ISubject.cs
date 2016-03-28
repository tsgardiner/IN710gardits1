using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherPatternsObserver
{
    public interface ISubject
    {
        void AddObserver(IWeatherObserver o);
        void RemoveObserver(IWeatherObserver o);
        void NotifyObservers();
    }
}

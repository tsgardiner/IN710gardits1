using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherPatternsObserver
{
    public class WeatherSubject : ISubject
    {
        List<IWeatherObserver> weatherList;
        int temperature { get; set; }
        int humidity { get; set; }
        int pressure { get; set; }

        public WeatherSubject(int temperature, int humidity, int pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            weatherList = new List<IWeatherObserver>();
        }        

        public void AddObserver(IWeatherObserver o)
        {
            weatherList.Add(o);
        }

        public void RemoveObserver(IWeatherObserver o)
        {
            weatherList.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (WeatherStation weatherStation in weatherList)
            {
                weatherStation.updateTemperature(temperature);
                weatherStation.updateHumidity(humidity);
                weatherStation.updatePressure(pressure); 
            }
        }
    }
}

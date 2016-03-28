using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherPatternsObserver
{
    public interface IWeatherObserver
    {
        abstract void updateTemperature(int temperatureData);
        abstract void updateHumidity(int humidityData);
        abstract void updatePressure(int pressureData);
        abstract void Display();                   
    }
}

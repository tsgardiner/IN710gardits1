using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherPatternsObserver
{
    public abstract class WeatherStation : IWeatherObserver
    {

        protected RichTextBox displayBox;
        protected WeatherSubject weatherSubject;
        protected int currentTemperature;
        protected int currentHumidity;
        protected int currentPressure;

        public WeatherStation(RichTextBox  displayBox, WeatherSubject weatherSubject)
        {
            this.displayBox = displayBox;
            this.weatherSubject = weatherSubject;
            currentTemperature = 0;
            currentHumidity = 0;
            currentPressure = 0;

           weatherSubject.AddObserver(this);
        }



        public abstract void updateTemperature(int temperatureData);

        public abstract void updateHumidity(int humidityData);

        public abstract void updatePressure(int pressureData);

        public abstract void Display();
    }
}

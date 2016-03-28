using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherPatternsObserver
{
    public class TemperatureObserver : WeatherStation
    {

        public TemperatureObserver(RichTextBox displayBox, WeatherSubject weatherSubject)
            :base(displayBox, weatherSubject)
        {

        }

        public override void updateTemperature(int temperatureData)
        {
            throw new NotImplementedException();
        }

        public override void updateHumidity(int humidityData)
        {
            throw new NotImplementedException();
        }

        public override void updatePressure(int pressureData)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }


        
}

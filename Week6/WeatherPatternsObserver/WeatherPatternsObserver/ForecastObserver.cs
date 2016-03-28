using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherPatternsObserver
{
    public class ForecastObserver : WeatherStation
    {
        String tempString, humidityString, pressureString;

        public ForecastObserver(RichTextBox displayBox, WeatherSubject weatherSubject)
            :base(displayBox, weatherSubject)
        {

        }

        public override void updateTemperature(int temperatureData)
        {
            if (temperatureData < 25)
            {
                tempString = "Warmish"; 
            }
            else if (temperatureData < 10)
            {
                tempString = "Cold";  
            }
            else
            {
                tempString = "Too hot for Dunedin";
            }
        }

        public override void updateHumidity(int humidityData)
        {
            if (humidityData < 50)
            {
                humidityString = "Clear";
            }
            else
            {
                humidityString = "Overcast";
            }
        }

        public override void updatePressure(int pressureData)
        {
            if (pressureData < 700)
            {
                pressureString = "Lowish pressure";   
            }
            else
            {
                pressureString = "High pressure";
            }
        }

        public override void Display()
        {
            displayBox.Text = humidityString + tempString + "with " + pressureString;
        }
    }
}

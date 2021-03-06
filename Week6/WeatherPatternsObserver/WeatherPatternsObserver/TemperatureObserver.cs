﻿using System;
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
            currentTemperature = temperatureData;
        }

        public override void updateHumidity(int humidityData)
        {
            currentHumidity = humidityData;
        }

        public override void updatePressure(int pressureData)
        {
            currentPressure = pressureData;
        }

        public override void Display()
        {
            displayBox.Text = "Temperature:\t" + currentTemperature + "\n";
            displayBox.Text += "Humidity:\t" + currentHumidity + "\n";
            displayBox.Text += "Pressure:\t" + currentPressure + "\n";
        }
    }


        
}

using System;
using System.Collections.Generic;
using System.Text;
using WeatherStation.Interface;

namespace WeatherStation.Display
{
    class ForeCastDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private ISubject _weatherData;

        public ForeCastDisplay(ISubject weatherData)
        {
            this._weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

      
        void IDisplayElement.Display()
        {
            Console.WriteLine("-------------- today's forecast -----------");
            Console.WriteLine(_temperature + " f degree \n" + _humidity + " %  humidity \n" + _pressure + " pressure \n");

        }

        void IObserver.Update(float temp, float humidity, float pressure)
        {
            this._temperature = temp;
            this._humidity = humidity;
            this._pressure = pressure;
            //this.Display();
        }
    }
}

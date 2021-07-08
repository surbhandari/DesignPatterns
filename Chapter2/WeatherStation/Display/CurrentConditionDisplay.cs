using System;
using System.Collections.Generic;
using System.Text;

using WeatherStation.Interface;


namespace WeatherStation.Display
{
    class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private ISubject _weatherData;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            this._weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("****************** Current Condition *************");
            Console.WriteLine(_temperature + " F degree \n" + _humidity + " %  humidity \n" + _pressure + " Pressure\n");
        }

        void IObserver.Update(float temp, float humidity, float pressure)
        {
            this._temperature = temp;
            this._humidity = humidity;
            this._pressure = pressure;
            Display();
        }
    }
}

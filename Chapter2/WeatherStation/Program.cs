using System;
using WeatherStation.Display;
using WeatherStation.Data;
using WeatherStation.Interface;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weather Station");
            WeatherData weatherData = new WeatherData();
            WeatherData foreCastData = new WeatherData();

            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
            IDisplayElement foreCastDisplay = new ForeCastDisplay(foreCastData);

            foreCastData.SetMeasurements(100, 65, 30.4f);
            foreCastDisplay.Display();

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
        }
    }
}

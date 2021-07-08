using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using WeatherStation.Interface;

namespace WeatherStation.Data
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }
        public void NotifyObservers()
        {
            //for(int i = 0; i < _observers.Count; i++)
            //{
            //    IObserver observer = (IObserver)_observers[i];
            //    observer.Update(_temperature, _humidity, _pressure);

            //}

            _observers.ForEach(o =>
            {
                o.Update(_temperature, _humidity, _pressure);
            });
        }

        void ISubject.RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        void ISubject.RemoveObserver(IObserver o)
        {
            int i = _observers.IndexOf(o);
            if (i >= 0)
            {
                _observers.RemoveAt(i);
            }



        }
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            MeasurementsChanged();
        }
    }
}

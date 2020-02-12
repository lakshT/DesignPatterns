using ObserverPattern.Observers.Interfaces;
using ObserverPattern.Subject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Subject.Concretes
{
    class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>(); // This is how subject knows about observer, maintains a list of observer.
        }

        public void setMeasurements(float tem, float hum, float pre)
        {
            temperature = tem;
            humidity = hum;
            pressure = pre;
        }

        public void notifyAllObservers()
        {
           foreach(IObserver o in observers)
            {
                o.update(temperature, humidity, pressure);  // This is how each observer is notified.
            }
        }

        public void registerObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            foreach(IObserver o in observers)
            {
                if(o == observer)
                {
                    observers.Remove(observer);
                }
            }
        }
    }
}

using ObserverPattern.Observers.Interfaces;
using ObserverPattern.Subject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers.Concretes
{
    public class CurrentConditionsObserver : IObserver, IDisplayElement 
    {
        private float temperature;
        private float humidity;
        private float pressure;
        ISubject weatherDataSubject;

        public CurrentConditionsObserver(ISubject sub)
        {
            weatherDataSubject = sub;
            weatherDataSubject.registerObserver(this); // this is how observer registers itself with the subject
        }

        public void update(float tem, float hum, float pre)
        {
            temperature = tem;
            humidity = hum;
            pressure = pre;

            display();
        }

        public void display()
        {
            // display temprature, humidity and pressure on screen.
        }
    }
}

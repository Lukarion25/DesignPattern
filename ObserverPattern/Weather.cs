using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Weather
    {
        public double Pressure { get; }

        public double Humidity { get; }

        public double Temperature { get; }

        public Weather(double humdity, double pressure, double temperature)
        {
            Temperature = temperature;
            Pressure = pressure;
            Humidity = humdity;
        }
    }
}

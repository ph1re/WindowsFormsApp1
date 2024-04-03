using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.OpenWeather
{
    internal class main
    {
        public double humidity;
        public double tempmin;
        public double tempmax;
        public double temp;
        private double _pressure;
        public double pressure
        {
            get
            {
                return _pressure;
            }
            set 
            { 
                _pressure = value/1.3332239;
            }
        }
    }
}

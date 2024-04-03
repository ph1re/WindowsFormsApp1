using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.OpenWeather1
{
    internal class main
    {
        public double temp { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        private double _pressure;
        public double pressure
        {
            get
            {
                return _pressure;
            }
            set
            {
                _pressure = value / 1.3332239;
            }
        }
        public double sea_level { get; set; }
        public double grnd_level { get; set; }
        public double humidity { get; set; }
        public double temp_kf { get; set; }
    }
}

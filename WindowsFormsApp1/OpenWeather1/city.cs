using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.OpenWeather;

namespace WindowsFormsApp1.OpenWeather1
{
    internal class city
    {
        public int id { get; set; }
        public string name { get; set; }
        public coord coord { get; set; }
        public string country { get; set; }
    }
}

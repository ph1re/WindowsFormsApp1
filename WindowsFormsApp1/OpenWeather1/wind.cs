using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.OpenWeather1
{
    internal class wind
    {
        public double speed { get; set; }

        public double deg_d;
        public string deg_s;
        public double deg
        {
            get
            {
                return deg_d;
            }
            set
            {
                if (value <= 22.5 || value >= 337.5) { deg_s = "С"; }
                if (value <= 67.5 && value >= 22.5) { deg_s = "СВ"; }
                if (value <= 112.5 && value >= 67.5) { deg_s = "В"; }
                if (value <= 157.5 && value >= 112.5) { deg_s = "ЮВ"; }
                if (value <= 202.5 && value >= 157.5) { deg_s = "Ю"; }
                if (value <= 247.5 && value >= 202.5) { deg_s = "ЮЗ"; }
                if (value <= 292.5 && value >= 247.5) { deg_s = "З"; }
                if (value <= 337.5 && value >= 292.5) { deg_s = "СЗ"; }
                deg_d = value;
            }
        }
    }
}

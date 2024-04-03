using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Bibliography;
using Newtonsoft.Json;
using WindowsFormsApp1.OpenWeather;

namespace WindowsFormsApp1.OpenWeather1
{
    internal class OpenWeather1
    {
        public double cod;
        public double message;
        public double cnt;
        //[JsonProperty("list")]
        public List<List> list;
        public city city;
    }
}

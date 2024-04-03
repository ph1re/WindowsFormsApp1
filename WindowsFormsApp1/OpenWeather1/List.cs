using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.OpenWeather;

namespace WindowsFormsApp1.OpenWeather1
{
    internal class List
    {
        public int dt { get; set; }
        public main main { get; set; }
        public List<weather> weather { get; set; }
        public wind wind { get; set; }
        public string dt_txt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Data.SqlClient;
using System.Data.Common;
using System.Xml.Linq;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Controls;
using ClosedXML.Excel;

namespace WindowsFormsApp1
{
    public partial class Climate : Form
    {
        private SqlConnection SqlConnectionWarm = null;
        private SqlDataAdapter dataAdapterWarm = null;
        private DataSet dataSetWarm = null;
        private DataTable tableWarm = null;
        
        private SqlConnection SqlConnectionCold = null;
        private SqlDataAdapter dataAdapterCold = null;
        private DataSet dataSetCold = null;
        private DataTable tableCold = null;
        
        private SqlConnection SqlConnectionCity = null;
        private SqlDataAdapter dataAdapterCity = null;
        private DataSet dataSetCity = null;
        private DataTable tableCity = null;

        public Climate()
        {
            InitializeComponent();
            string[] SMPcity_ = { "Москва", "Санкт-Петербург", "Мурманск", "Архангельск", "Нарьян-мар", "Диксон", "Дудинка", "Хатанга", "Тикси", "Певек", "Анадырь", "Владивосток" };
            SMPcity.Items.AddRange(SMPcity_);
            SMPcity.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            StartPosition = FormStartPosition.CenterScreen;
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            SqlConnectionWarm = new SqlConnection(@"Data Source=DESKTOP-9ITJ4U4\SQLEXPRESS;Initial Catalog=Climate;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            SqlConnectionWarm.Open();
            dataAdapterWarm = new SqlDataAdapter("SELECT * FROM warm", SqlConnectionWarm);
            dataSetWarm = new DataSet();
            SqlConnectionCold = new SqlConnection(@"Data Source=DESKTOP-9ITJ4U4\SQLEXPRESS;Initial Catalog=Climate;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            SqlConnectionCold.Open();
            dataAdapterCold = new SqlDataAdapter("SELECT * FROM cold", SqlConnectionCold);
            dataSetCold = new DataSet();
            chartTemp.LegendLocation = LegendLocation.Bottom;
            chartMoisture.LegendLocation = LegendLocation.Bottom;

            WebRequest request1 = WebRequest.Create($"https://api.openweathermap.org/data/2.5/forecast?lat=59,9387&lon=30,3149&units=metric&lang=ru&appid=07c6b441a2e916cf7c54a17a93052493");
            request1.Method = "POST";
            request1.ContentType = "application/x-www-urlencoded";
            WebResponse response1 = await request1.GetResponseAsync();
            string answer1 = string.Empty;
            using (Stream s1 = response1.GetResponseStream())
            {
                using (StreamReader reader1 = new StreamReader(s1))
                {
                    answer1 = await reader1.ReadToEndAsync();
                }
            }
            response1.Close();
            OpenWeather1.OpenWeather1 oW1 = JsonConvert.DeserializeObject<OpenWeather1.OpenWeather1>(answer1);

            image_.BackgroundImage = oW1.list[0].weather[0].Icon;
            weatherMain.Text = oW1.list[0].weather[0].main;
            weatherDescription.Text = oW1.list[0].weather[0].description;
            temp_.Text = "Средняя температура (*С): " + oW1.list[0].main.temp.ToString("0.##");
            speed_.Text = "Скорость (м/с): " + oW1.list[0].wind.speed.ToString();
            deg_.Text = "Направление *: " + oW1.list[0].wind.deg_s;
            hum.Text = "Влажность (%): " + oW1.list[0].main.humidity.ToString();
            pres.Text = "Давление (ММ): " + ((int)oW1.list[0].main.pressure).ToString();
            time.Text = oW1.list[0].dt_txt.ToString();

            image_1.BackgroundImage = oW1.list[8].weather[0].Icon;
            weatherMain1.Text = oW1.list[8].weather[0].main;
            weatherDescription1.Text = oW1.list[8].weather[0].description;
            temp_1.Text = "Средняя температура (*С): " + oW1.list[8].main.temp.ToString("0.##");
            speed_1.Text = "Скорость (м/с): " + oW1.list[8].wind.speed.ToString();
            deg_1.Text = "Направление *: " + oW1.list[8].wind.deg_s;
            hum1.Text = "Влажность (%): " + oW1.list[8].main.humidity.ToString();
            pres1.Text = "Давление (ММ): " + ((int)oW1.list[8].main.pressure).ToString();
            time1.Text = oW1.list[8].dt_txt.ToString();

            image_2.BackgroundImage = oW1.list[16].weather[0].Icon;
            weatherMain2.Text = oW1.list[16].weather[0].main;
            weatherDescription2.Text = oW1.list[16].weather[0].description;
            temp_2.Text = "Средняя температура (*С): " + oW1.list[16].main.temp.ToString("0.##");
            speed_2.Text = "Скорость (м/с): " + oW1.list[16].wind.speed.ToString();
            deg_2.Text = "Направление *: " + oW1.list[16].wind.deg_s;
            hum2.Text = "Влажность (%): " + oW1.list[16].main.humidity.ToString();
            pres2.Text = "Давление (ММ): " + ((int)oW1.list[16].main.pressure).ToString();
            time2.Text = oW1.list[16].dt_txt.ToString();

            image_3.BackgroundImage = oW1.list[24].weather[0].Icon;
            weatherMain3.Text = oW1.list[24].weather[0].main;
            weatherDescription3.Text = oW1.list[24].weather[0].description;
            temp_3.Text = "Средняя температура (*С): " + oW1.list[24].main.temp.ToString("0.##");
            speed_3.Text = "Скорость (м/с): " + oW1.list[24].wind.speed.ToString();
            deg_3.Text = "Направление *: " + oW1.list[24].wind.deg_s;
            hum3.Text = "Влажность (%): " + oW1.list[24].main.humidity.ToString();
            pres3.Text = "Давление (ММ): " + ((int)oW1.list[24].main.pressure).ToString();
            time3.Text = oW1.list[24].dt_txt.ToString();

            image_4.BackgroundImage = oW1.list[32].weather[0].Icon;
            weatherMain4.Text = oW1.list[32].weather[0].main;
            weatherDescription4.Text = oW1.list[32].weather[0].description;
            temp_4.Text = "Средняя температура (*С): " + oW1.list[32].main.temp.ToString("0.##");
            speed_4.Text = "Скорость (м/с): " + oW1.list[32].wind.speed.ToString();
            deg_4.Text = "Направление *: " + oW1.list[32].wind.deg_s;
            hum4.Text = "Влажность (%): " + oW1.list[32].main.humidity.ToString();
            pres4.Text = "Давление (ММ): " + ((int)oW1.list[32].main.pressure).ToString();
            time4.Text = oW1.list[32].dt_txt.ToString();

            //richTextBox1.Text = answer1;

            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            double lat1 = 59.9387;
            double lon1 = 30.3149;
            gMapControl1.Position = new GMap.NET.PointLatLng(lat1, lon1);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.MarkersEnabled = true;
            gMapControl1.ShowCenter = false;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.IgnoreMarkerOnMouseWheel = true;
        }
        private void buttonWarm_Click(object sender, EventArgs e)
        {
            if (dataSetWarm.Tables["tableWarm"] != null)
                dataSetWarm.Tables["tableWarm"].Clear();
            dataAdapterWarm.Fill(dataSetWarm, "tableWarm");
            tableWarm = dataSetWarm.Tables["tableWarm"];
            SeriesCollection series1 = new SeriesCollection();
            ChartValues<int> temps1 = new ChartValues<int>();
            List<string> dates1 = new List<string>();
            foreach (DataRow row1 in tableWarm.Rows)
            {
                temps1.Add(Convert.ToInt32(row1["temp"]));
                dates1.Add(Convert.ToDateTime(row1["date"]).ToShortDateString());
                if (Convert.ToInt32(row1["temp"]) < 0 | Convert.ToInt32(row1["temp"]) > 6)
                {
                    Warning1.Text = Convert.ToString(row1["temp"]);
                }
                else
                {
                    Warning1.Text = Convert.ToString("В норме");
                }
            }
            dataGridView1.DataSource = dataSetWarm.Tables["tableWarm"];
            chartTemp.AxisX.Clear();
            chartTemp.AxisX.Add(new Axis()
            {
                Title = "Даты",
                Labels = dates1
            });
            LineSeries line1 = new LineSeries();
            line1.Title = "Температура";
            line1.Values = temps1;
            series1.Add(line1);
            chartTemp.Series = series1;
            chartTemp.AxisY.Clear();

            if (dataSetWarm.Tables["tableWarm"] != null)
                dataSetWarm.Tables["tableWarm"].Clear();
            dataAdapterWarm.Fill(dataSetWarm, "tableWarm");
            tableWarm = dataSetWarm.Tables["tableWarm"];
            SeriesCollection series2 = new SeriesCollection();
            ChartValues<int> temps2 = new ChartValues<int>();
            List<string> dates2 = new List<string>();
            foreach (DataRow row2 in tableWarm.Rows)
            {
                temps2.Add(Convert.ToInt32(row2["moisture"]));
                dates2.Add(Convert.ToDateTime(row2["date"]).ToShortDateString());
                if (Convert.ToInt32(row2["moisture"]) > 65)
                {
                    Warning2.Text = Convert.ToString(row2["moisture"]);
                }
                else
                {
                    Warning2.Text = Convert.ToString("В норме");
                }
            }
            chartMoisture.AxisX.Clear();
            chartMoisture.AxisX.Add(new Axis()
            {
                Title = "Даты",
                Labels = dates2
            });
            LineSeries line2 = new LineSeries();
            line2.Title = "Влажность";
            line2.Values = temps2;
            series2.Add(line2);
            chartMoisture.Series = series2;
            chartMoisture.AxisY.Clear();
        }
        private void buttonCold_Click(object sender, EventArgs e)
        {

            if (dataSetCold.Tables["tableCold"] != null)
                dataSetCold.Tables["tableCold"].Clear();
            dataAdapterCold.Fill(dataSetCold, "tableCold");
            tableCold = dataSetCold.Tables["tableCold"];
            SeriesCollection series1 = new SeriesCollection();
            ChartValues<int> temps1 = new ChartValues<int>();
            List<string> dates1 = new List<string>();
            foreach (DataRow row1 in tableCold.Rows)
            {
                temps1.Add(Convert.ToInt32(row1["temp"]));
                dates1.Add(Convert.ToDateTime(row1["date"]).ToShortDateString());
                if (Convert.ToInt32(row1["temp"]) < -18 | Convert.ToInt32(row1["temp"]) > -4)
                {
                    Warning1.Text = Convert.ToString(row1["temp"]);
                }
                else
                {
                    Warning1.Text = Convert.ToString("В норме");
                }
            }
            dataGridView1.DataSource = dataSetCold.Tables["tableCold"];
            chartTemp.AxisX.Clear();
            chartTemp.AxisX.Add(new Axis()
            {
                Title = "Даты",
                Labels = dates1
            });
            LineSeries line1 = new LineSeries();
            line1.Title = "Температура";
            line1.Values = temps1;
            series1.Add(line1);
            chartTemp.Series = series1;
            chartTemp.AxisY.Clear();

            if (dataSetCold.Tables["tableCold"] != null)
                dataSetCold.Tables["tableCold"].Clear();
            dataAdapterCold.Fill(dataSetCold, "tableCold");
            tableCold = dataSetCold.Tables["tableCold"];
            SeriesCollection series2 = new SeriesCollection();
            ChartValues<int> temps2 = new ChartValues<int>();
            List<string> dates2 = new List<string>();
            foreach (DataRow row2 in tableCold.Rows)
            {
                temps2.Add(Convert.ToInt32(row2["moisture"]));
                dates2.Add(Convert.ToDateTime(row2["date"]).ToShortDateString());
                if (Convert.ToInt32(row2["moisture"]) > 65)
                {
                    Warning2.Text = Convert.ToString(row2["moisture"]);
                }
                else
                {
                    Warning2.Text = Convert.ToString("В норме");
                }
            }
            chartMoisture.AxisX.Clear();
            chartMoisture.AxisX.Add(new Axis()
            {
                Title = "Даты",
                Labels = dates2
            });
            LineSeries line2 = new LineSeries();
            line2.Title = "Влажность";
            line2.Values = temps2;
            series2.Add(line2);
            chartMoisture.Series = series2;
            chartMoisture.AxisY.Clear();
        }

        private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnectionCity = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pam_9\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Database1.mdf;Integrated Security=True");
            SqlConnectionCity.Open();
            dataAdapterCity = new SqlDataAdapter("SELECT * FROM Cities", SqlConnectionCity);
            dataSetCity = new DataSet();
            if (dataSetCity.Tables["Cities"] != null)
                dataSetCity.Tables["Cities"].Clear();
            dataAdapterCity.Fill(dataSetCity, "Cities");
            tableCity = dataSetCity.Tables["Cities"];
            List<double> lat = new List<double>();
            List<double> lon = new List<double>();
            //MessageBox.Show(Convert.ToString(SMPcity.SelectedItem));
            foreach (DataRow row1 in tableCity.Rows)
            {
                lat.Add(Convert.ToDouble(row1["lat"]));
                lon.Add(Convert.ToDouble(row1["lon"]));
            }
            //MessageBox.Show(Convert.ToString(lat[SMPcity.SelectedIndex]));

            WebRequest request = WebRequest.Create($"https://api.openweathermap.org/data/2.5/forecast?lat={lat[SMPcity.SelectedIndex]}&lon={lon[SMPcity.SelectedIndex]}&units=metric&lang=ru&appid=07c6b441a2e916cf7c54a17a93052493");
            request.Method = "POST";
            request.ContentType = "application/x-www-urlencoded";
            WebResponse response = await request.GetResponseAsync();
            string answer = string.Empty;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    answer = await reader.ReadToEndAsync();
                }
            }
            response.Close();
            //richTextBox1.Text = answer;
            OpenWeather1.OpenWeather1 oW = JsonConvert.DeserializeObject<OpenWeather1.OpenWeather1>(answer);

            image_.BackgroundImage = oW.list[0].weather[0].Icon;
            weatherMain.Text = oW.list[0].weather[0].main;
            weatherDescription.Text = oW.list[0].weather[0].description;
            temp_.Text = "Средняя температура (*С): " + oW.list[0].main.temp.ToString("0.##");
            speed_.Text = "Скорость (м/с): " + oW.list[0].wind.speed.ToString();
            deg_.Text = "Направление *: " + oW.list[0].wind.deg_s;
            hum.Text = "Влажность (%): " + oW.list[0].main.humidity.ToString();
            pres.Text = "Давление (ММ): " + ((int)oW.list[0].main.pressure).ToString();
            time.Text = oW.list[0].dt_txt.ToString();

            image_1.BackgroundImage = oW.list[8].weather[0].Icon;
            weatherMain1.Text = oW.list[8].weather[0].main;
            weatherDescription1.Text = oW.list[8].weather[0].description;
            temp_1.Text = "Средняя температура (*С): " + oW.list[8].main.temp.ToString("0.##");
            speed_1.Text = "Скорость (м/с): " + oW.list[8].wind.speed.ToString();
            deg_1.Text = "Направление *: " + oW.list[8].wind.deg_s;
            hum1.Text = "Влажность (%): " + oW.list[8].main.humidity.ToString();
            pres1.Text = "Давление (ММ): " + ((int)oW.list[8].main.pressure).ToString();
            time1.Text = oW.list[8].dt_txt.ToString();

            image_2.BackgroundImage = oW.list[16].weather[0].Icon;
            weatherMain2.Text = oW.list[16].weather[0].main;
            weatherDescription2.Text = oW.list[16].weather[0].description;
            temp_2.Text = "Средняя температура (*С): " + oW.list[16].main.temp.ToString("0.##");
            speed_2.Text = "Скорость (м/с): " + oW.list[16].wind.speed.ToString();
            deg_2.Text = "Направление *: " + oW.list[16].wind.deg_s;
            hum2.Text = "Влажность (%): " + oW.list[16].main.humidity.ToString();
            pres2.Text = "Давление (ММ): " + ((int)oW.list[16].main.pressure).ToString();
            time2.Text = oW.list[16].dt_txt.ToString();

            image_3.BackgroundImage = oW.list[24].weather[0].Icon;
            weatherMain3.Text = oW.list[24].weather[0].main;
            weatherDescription3.Text = oW.list[24].weather[0].description;
            temp_3.Text = "Средняя температура (*С): " + oW.list[24].main.temp.ToString("0.##");
            speed_3.Text = "Скорость (м/с): " + oW.list[24].wind.speed.ToString();
            deg_3.Text = "Направление *: " + oW.list[24].wind.deg_s;
            hum3.Text = "Влажность (%): " + oW.list[24].main.humidity.ToString();
            pres3.Text = "Давление (ММ): " + ((int)oW.list[24].main.pressure).ToString();
            time3.Text = oW.list[24].dt_txt.ToString();

            image_4.BackgroundImage = oW.list[32].weather[0].Icon;
            weatherMain4.Text = oW.list[32].weather[0].main;
            weatherDescription4.Text = oW.list[32].weather[0].description;
            temp_4.Text = "Средняя температура (*С): " + oW.list[32].main.temp.ToString("0.##");
            speed_4.Text = "Скорость (м/с): " + oW.list[32].wind.speed.ToString();
            deg_4.Text = "Направление *: " + oW.list[32].wind.deg_s;
            hum4.Text = "Влажность (%): " + oW.list[32].main.humidity.ToString();
            pres4.Text = "Давление (ММ): " + ((int)oW.list[32].main.pressure).ToString();
            time4.Text = oW.list[32].dt_txt.ToString();

            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            //double lat1 = 71.6391;
            //double lon1 = 128.8703;
            gMapControl1.Position = new GMap.NET.PointLatLng(lat[SMPcity.SelectedIndex], lon[SMPcity.SelectedIndex]);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.MarkersEnabled = true;
            gMapControl1.ShowCenter = false;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.IgnoreMarkerOnMouseWheel = true;
        }
        private void buttonExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                MExcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    MExcel.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        MExcel.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MExcel.Columns.AutoFit();
                MExcel.Rows.AutoFit();
                MExcel.Columns.Font.Size = 12;
                MExcel.Visible = true;
            }
            else
            {
                MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
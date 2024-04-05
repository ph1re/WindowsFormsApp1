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
        private SqlConnection SqlCon = new SqlConnection(@"Data Source=DESKTOP-9ITJ4U4\SQLEXPRESS;Initial Catalog=Climate;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        private SqlDataAdapter dataAdapterWarm = null;
        private DataSet dataSetWarm = null;
        private DataTable tableWarm = null;
        private SqlDataAdapter dataAdapterCold = null;
        private DataSet dataSetCold = null;
        private DataTable tableCold = null;
        private SqlDataAdapter dataAdapterCity = null;
        private DataSet dataSetCity = null;
        private DataTable tableCity = null;
        private bool? tableCheck = null;
        public Climate()
        {
            InitializeComponent();
            string[] SMPcity_ = { "Москва", "Санкт-Петербург", "Мурманск", "Архангельск", "Нарьян-мар", "Диксон", "Дудинка", "Хатанга", "Тикси", "Певек", "Анадырь", "Владивосток" };
            SMPcity.Items.AddRange(SMPcity_);
            SMPcity.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            StartPosition = FormStartPosition.CenterScreen;
            chartTemp.LegendLocation = LegendLocation.Bottom;
            chartMoisture.LegendLocation = LegendLocation.Bottom;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            // TABLE
            dataAdapterWarm = new SqlDataAdapter("SELECT * FROM warm", SqlCon);
            dataSetWarm = new DataSet();
            dataAdapterCold = new SqlDataAdapter("SELECT * FROM cold", SqlCon);
            dataSetCold = new DataSet();

            // API
            WebRequest request = WebRequest.Create("https://api.openweathermap.org/data/2.5/forecast?lat=59,9387&lon=30,3149&units=metric&lang=ru&appid=07c6b441a2e916cf7c54a17a93052493");
            request.Method = "POST";
            request.ContentType = "application/x-www-urlencoded";
            WebResponse response = await request.GetResponseAsync();
            string answer = string.Empty;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader reader1 = new StreamReader(s))
                {
                    answer = await reader1.ReadToEndAsync();
                }
            }
            response.Close();
            OpenWeather1.OpenWeather1 oW1 = JsonConvert.DeserializeObject<OpenWeather1.OpenWeather1>(answer);

            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl1.Position = new GMap.NET.PointLatLng(59.9387, 30.3149);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.MarkersEnabled = true;
            gMapControl1.ShowCenter = false;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.IgnoreMarkerOnMouseWheel = true;

            // MAIN
            if (oW1.list[0].main.temp > oW1.list[8].main.temp) WarningTemp.Text = "Температура уменьшится \n на (*С):" + (oW1.list[0].main.temp - oW1.list[8].main.temp).ToString("0.##");
            else WarningTemp.Text = "Температура увеличится \n на (*С):" + (oW1.list[8].main.temp - oW1.list[0].main.temp).ToString("0.##");

            if (oW1.list[0].main.humidity > oW1.list[8].main.humidity) WarningMoist.Text = "Влажность уменьшится \n на (ММ):" + (oW1.list[0].main.humidity - oW1.list[8].main.humidity).ToString("0.##");
            else WarningMoist.Text = "Влажность увеличится \n на (ММ):" + (oW1.list[8].main.humidity - oW1.list[0].main.humidity).ToString("0.##");

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
        }
        private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TABLE
            dataAdapterCity = new SqlDataAdapter("SELECT * FROM cities", SqlCon);
            dataSetCity = new DataSet();
            if (dataSetCity.Tables["cities"] != null) dataSetCity.Tables["cities"].Clear();
            dataAdapterCity.Fill(dataSetCity, "cities");
            tableCity = dataSetCity.Tables["cities"];
            List<double> lat = new List<double>();
            List<double> lon = new List<double>();
            foreach (DataRow row in tableCity.Rows)
            {
                lat.Add(Convert.ToDouble(row["lat"]));
                lon.Add(Convert.ToDouble(row["lon"]));
            }

            // API
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
            OpenWeather1.OpenWeather1 oW = JsonConvert.DeserializeObject<OpenWeather1.OpenWeather1>(answer);

            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl1.Position = new GMap.NET.PointLatLng(lat[SMPcity.SelectedIndex], lon[SMPcity.SelectedIndex]);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.MarkersEnabled = true;
            gMapControl1.ShowCenter = false;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.IgnoreMarkerOnMouseWheel = true;

            // MAIN
            if (oW.list[0].main.temp > oW.list[8].main.temp) WarningTemp.Text = "Температура уменьшится \n на (*С):" + (oW.list[0].main.temp - oW.list[8].main.temp).ToString("0.##");
            else WarningTemp.Text = "Температура увеличится \n на (*С):" + (oW.list[8].main.temp - oW.list[0].main.temp).ToString("0.##");

            if (oW.list[0].main.humidity > oW.list[8].main.humidity) WarningMoist.Text = "Влажность уменьшится \n на (ММ):" + (oW.list[0].main.humidity - oW.list[8].main.humidity).ToString("0.##");
            else WarningMoist.Text = "Влажность увеличится \n на (ММ):" + (oW.list[8].main.humidity - oW.list[0].main.humidity).ToString("0.##");

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
        }
        private void buttonWarm_Click(object sender, EventArgs e)
        {
            tableCheck = true;
            dataAdapterWarm = new SqlDataAdapter($"SELECT * FROM warm WHERE date BETWEEN '{dateTimePicker1.Value}' AND '{dateTimePicker2.Value}'", SqlCon);
            dataSetWarm = new DataSet();
            if (dataSetWarm.Tables["tableWarm"] != null) dataSetWarm.Tables["tableWarm"].Clear();
            dataAdapterWarm.Fill(dataSetWarm, "tableWarm");
            tableWarm = dataSetWarm.Tables["tableWarm"];
            dataGridView1.DataSource = dataSetWarm.Tables["tableWarm"];

            SeriesCollection seriesTemp = new SeriesCollection();
            ChartValues<int> tempsTemp = new ChartValues<int>();
            List<string> datesTemp = new List<string>();
            LineSeries lineTemp = new LineSeries();
            foreach (DataRow rowTemp in tableWarm.Rows)
            {
                tempsTemp.Add(Convert.ToInt32(rowTemp["temp"]));
                datesTemp.Add(Convert.ToDateTime(rowTemp["date"]).ToShortDateString());
                if (Convert.ToInt32(rowTemp["temp"]) < 0 | Convert.ToInt32(rowTemp["temp"]) > 6){ Warning1.Text = Convert.ToString(rowTemp["temp"]);}
                else{Warning1.Text = Convert.ToString("В норме");}
            }
            chartTemp.AxisX.Clear();
            chartTemp.AxisX.Add(new Axis()
            {
                Title = "Даты",
                Labels = datesTemp
            });
            lineTemp.Title = "Температура";
            lineTemp.Values = tempsTemp;
            seriesTemp.Add(lineTemp);
            chartTemp.Series = seriesTemp;
            chartTemp.AxisY.Clear();

            SeriesCollection seriesMoist = new SeriesCollection();
            ChartValues<int> tempsMoist = new ChartValues<int>();
            List<string> datesMoist = new List<string>();
            LineSeries lineMoist = new LineSeries();
            foreach (DataRow rowMoist in tableWarm.Rows)
            {
                tempsMoist.Add(Convert.ToInt32(rowMoist["moisture"]));
                datesMoist.Add(Convert.ToDateTime(rowMoist["date"]).ToShortDateString());
                if (Convert.ToInt32(rowMoist["moisture"]) > 65){Warning2.Text = Convert.ToString(rowMoist["moisture"]);}
                else{Warning2.Text = Convert.ToString("В норме");}
            }
            chartMoisture.AxisX.Clear();
            chartMoisture.AxisX.Add(new Axis()
            {
                Title = "Даты",
                Labels = datesMoist
            });
            lineMoist.Title = "Влажность";
            lineMoist.Values = tempsMoist;
            seriesMoist.Add(lineMoist);
            chartMoisture.Series = seriesMoist;
            chartMoisture.AxisY.Clear();
        }
        private void buttonCold_Click(object sender, EventArgs e)
        {
            tableCheck = false;
            dataAdapterCold = new SqlDataAdapter($"SELECT * FROM Cold WHERE date BETWEEN '{dateTimePicker1.Value}' AND '{dateTimePicker2.Value}'", SqlCon);
            dataSetCold = new DataSet();
            if (dataSetCold.Tables["tableCold"] != null) dataSetCold.Tables["tableCold"].Clear();
            dataAdapterCold.Fill(dataSetCold, "tableCold");
            tableCold = dataSetCold.Tables["tableCold"];
            dataGridView1.DataSource = dataSetCold.Tables["tableCold"];

            SeriesCollection seriesTemp = new SeriesCollection();
            ChartValues<int> tempsTemp = new ChartValues<int>();
            List<string> datesTemp = new List<string>();
            LineSeries lineTemp = new LineSeries();
            foreach (DataRow rowTemp in tableCold.Rows)
            {
                tempsTemp.Add(Convert.ToInt32(rowTemp["temp"]));
                datesTemp.Add(Convert.ToDateTime(rowTemp["date"]).ToShortDateString());
                if (Convert.ToInt32(rowTemp["temp"]) < 0 | Convert.ToInt32(rowTemp["temp"]) > 6) { Warning1.Text = Convert.ToString(rowTemp["temp"]); }
                else { Warning1.Text = Convert.ToString("В норме"); }
            }
            chartTemp.AxisX.Clear();
            chartTemp.AxisX.Add(new Axis()
            {
                Title = "Даты",
                Labels = datesTemp
            });
            lineTemp.Title = "Температура";
            lineTemp.Values = tempsTemp;
            seriesTemp.Add(lineTemp);
            chartTemp.Series = seriesTemp;
            chartTemp.AxisY.Clear();

            SeriesCollection seriesMoist = new SeriesCollection();
            ChartValues<int> tempsMoist = new ChartValues<int>();
            List<string> datesMoist = new List<string>();
            LineSeries lineMoist = new LineSeries();
            foreach (DataRow rowMoist in tableCold.Rows)
            {
                tempsMoist.Add(Convert.ToInt32(rowMoist["moisture"]));
                datesMoist.Add(Convert.ToDateTime(rowMoist["date"]).ToShortDateString());
                if (Convert.ToInt32(rowMoist["moisture"]) > 65) { Warning2.Text = Convert.ToString(rowMoist["moisture"]); }
                else { Warning2.Text = Convert.ToString("В норме"); }
            }
            chartMoisture.AxisX.Clear();
            chartMoisture.AxisX.Add(new Axis()
            {
                Title = "Даты",
                Labels = datesMoist
            });
            lineMoist.Title = "Влажность";
            lineMoist.Values = tempsMoist;
            seriesMoist.Add(lineMoist);
            chartMoisture.Series = seriesMoist;
            chartMoisture.AxisY.Clear();
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
            else{MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }
        private void Max_Click(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", dataGridView1.DefaultCellStyle.Font.Size + 1, FontStyle.Regular);
            dataGridView1.RowTemplate.Height += 9;
            if (tableCheck == true)
            {
                dataAdapterWarm = new SqlDataAdapter($"SELECT * FROM warm WHERE date BETWEEN '{dateTimePicker1.Value}' AND '{dateTimePicker2.Value}'", SqlCon);
                dataSetWarm = new DataSet();
                if (dataSetWarm.Tables["tableWarm"] != null) dataSetWarm.Tables["tableWarm"].Clear();
                dataAdapterWarm.Fill(dataSetWarm, "tableWarm");
                tableWarm = dataSetWarm.Tables["tableWarm"];
                dataGridView1.DataSource = dataSetWarm.Tables["tableWarm"];
            }
            else if (tableCheck == false)
            {
                dataAdapterCold = new SqlDataAdapter($"SELECT * FROM Cold WHERE date BETWEEN '{dateTimePicker1.Value}' AND '{dateTimePicker2.Value}'", SqlCon);
                dataSetCold = new DataSet();
                if (dataSetCold.Tables["tableCold"] != null) dataSetCold.Tables["tableCold"].Clear();
                dataAdapterCold.Fill(dataSetCold, "tableCold");
                tableCold = dataSetCold.Tables["tableCold"];
                dataGridView1.DataSource = dataSetCold.Tables["tableCold"];
            }
        }
        private void Min_Click(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", dataGridView1.DefaultCellStyle.Font.Size - 1, FontStyle.Regular);
            dataGridView1.RowTemplate.Height -= 9;
            if (tableCheck == true)
            {
                dataAdapterWarm = new SqlDataAdapter($"SELECT * FROM warm WHERE date BETWEEN '{dateTimePicker1.Value}' AND '{dateTimePicker2.Value}'", SqlCon);
                dataSetWarm = new DataSet();
                if (dataSetWarm.Tables["tableWarm"] != null) dataSetWarm.Tables["tableWarm"].Clear();
                dataAdapterWarm.Fill(dataSetWarm, "tableWarm");
                tableWarm = dataSetWarm.Tables["tableWarm"];
                dataGridView1.DataSource = dataSetWarm.Tables["tableWarm"];
            }
            else if (tableCheck == false)
            {
                dataAdapterCold = new SqlDataAdapter($"SELECT * FROM Cold WHERE date BETWEEN '{dateTimePicker1.Value}' AND '{dateTimePicker2.Value}'", SqlCon);
                dataSetCold = new DataSet();
                if (dataSetCold.Tables["tableCold"] != null) dataSetCold.Tables["tableCold"].Clear();
                dataAdapterCold.Fill(dataSetCold, "tableCold");
                tableCold = dataSetCold.Tables["tableCold"];
                dataGridView1.DataSource = dataSetCold.Tables["tableCold"];
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (tableCheck == true)
            {
                dataAdapterWarm = new SqlDataAdapter($"SELECT * FROM warm WHERE date BETWEEN '{dateTimePicker1.Value}' AND '{dateTimePicker2.Value}'", SqlCon);
                dataSetWarm = new DataSet();
                if (dataSetWarm.Tables["tableWarm"] != null) dataSetWarm.Tables["tableWarm"].Clear();
                dataAdapterWarm.Fill(dataSetWarm, "tableWarm");
                tableWarm = dataSetWarm.Tables["tableWarm"];
                dataGridView1.DataSource = dataSetWarm.Tables["tableWarm"];

                SeriesCollection seriesTemp = new SeriesCollection();
                ChartValues<int> tempsTemp = new ChartValues<int>();
                List<string> datesTemp = new List<string>();
                LineSeries lineTemp = new LineSeries();
                foreach (DataRow rowTemp in tableWarm.Rows)
                {
                    tempsTemp.Add(Convert.ToInt32(rowTemp["temp"]));
                    datesTemp.Add(Convert.ToDateTime(rowTemp["date"]).ToShortDateString());
                    if (Convert.ToInt32(rowTemp["temp"]) < 0 | Convert.ToInt32(rowTemp["temp"]) > 6) { Warning1.Text = Convert.ToString(rowTemp["temp"]); }
                    else { Warning1.Text = Convert.ToString("В норме"); }
                }
                chartTemp.AxisX.Clear();
                chartTemp.AxisX.Add(new Axis()
                {
                    Title = "Даты",
                    Labels = datesTemp
                });
                lineTemp.Title = "Температура";
                lineTemp.Values = tempsTemp;
                seriesTemp.Add(lineTemp);
                chartTemp.Series = seriesTemp;
                chartTemp.AxisY.Clear();

                SeriesCollection seriesMoist = new SeriesCollection();
                ChartValues<int> tempsMoist = new ChartValues<int>();
                List<string> datesMoist = new List<string>();
                LineSeries lineMoist = new LineSeries();
                foreach (DataRow rowMoist in tableWarm.Rows)
                {
                    tempsMoist.Add(Convert.ToInt32(rowMoist["moisture"]));
                    datesMoist.Add(Convert.ToDateTime(rowMoist["date"]).ToShortDateString());
                    if (Convert.ToInt32(rowMoist["moisture"]) > 65) { Warning2.Text = Convert.ToString(rowMoist["moisture"]); }
                    else { Warning2.Text = Convert.ToString("В норме"); }
                }
                chartMoisture.AxisX.Clear();
                chartMoisture.AxisX.Add(new Axis()
                {
                    Title = "Даты",
                    Labels = datesMoist
                });
                lineMoist.Title = "Влажность";
                lineMoist.Values = tempsMoist;
                seriesMoist.Add(lineMoist);
                chartMoisture.Series = seriesMoist;
                chartMoisture.AxisY.Clear();
            }
            else if (tableCheck == false)
            {
                dataAdapterCold = new SqlDataAdapter($"SELECT * FROM Cold WHERE date BETWEEN '{dateTimePicker1.Value}' AND '{dateTimePicker2.Value}'", SqlCon);
                dataSetCold = new DataSet();
                if (dataSetCold.Tables["tableCold"] != null) dataSetCold.Tables["tableCold"].Clear();
                dataAdapterCold.Fill(dataSetCold, "tableCold");
                tableCold = dataSetCold.Tables["tableCold"];
                dataGridView1.DataSource = dataSetCold.Tables["tableCold"];

                SeriesCollection seriesTemp = new SeriesCollection();
                ChartValues<int> tempsTemp = new ChartValues<int>();
                List<string> datesTemp = new List<string>();
                LineSeries lineTemp = new LineSeries();
                foreach (DataRow rowTemp in tableCold.Rows)
                {
                    tempsTemp.Add(Convert.ToInt32(rowTemp["temp"]));
                    datesTemp.Add(Convert.ToDateTime(rowTemp["date"]).ToShortDateString());
                    if (Convert.ToInt32(rowTemp["temp"]) < 0 | Convert.ToInt32(rowTemp["temp"]) > 6) { Warning1.Text = Convert.ToString(rowTemp["temp"]); }
                    else { Warning1.Text = Convert.ToString("В норме"); }
                }
                chartTemp.AxisX.Clear();
                chartTemp.AxisX.Add(new Axis()
                {
                    Title = "Даты",
                    Labels = datesTemp
                });
                lineTemp.Title = "Температура";
                lineTemp.Values = tempsTemp;
                seriesTemp.Add(lineTemp);
                chartTemp.Series = seriesTemp;
                chartTemp.AxisY.Clear();

                SeriesCollection seriesMoist = new SeriesCollection();
                ChartValues<int> tempsMoist = new ChartValues<int>();
                List<string> datesMoist = new List<string>();
                LineSeries lineMoist = new LineSeries();
                foreach (DataRow rowMoist in tableCold.Rows)
                {
                    tempsMoist.Add(Convert.ToInt32(rowMoist["moisture"]));
                    datesMoist.Add(Convert.ToDateTime(rowMoist["date"]).ToShortDateString());
                    if (Convert.ToInt32(rowMoist["moisture"]) > 65) { Warning2.Text = Convert.ToString(rowMoist["moisture"]); }
                    else { Warning2.Text = Convert.ToString("В норме"); }
                }
                chartMoisture.AxisX.Clear();
                chartMoisture.AxisX.Add(new Axis()
                {
                    Title = "Даты",
                    Labels = datesMoist
                });
                lineMoist.Title = "Влажность";
                lineMoist.Values = tempsMoist;
                seriesMoist.Add(lineMoist);
                chartMoisture.Series = seriesMoist;
                chartMoisture.AxisY.Clear();
            }
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (tableCheck == true)
            {
                dataAdapterWarm = new SqlDataAdapter($"SELECT * FROM warm WHERE date BETWEEN '{dateTimePicker1.Value}' AND '{dateTimePicker2.Value}'", SqlCon);
                dataSetWarm = new DataSet();
                if (dataSetWarm.Tables["tableWarm"] != null) dataSetWarm.Tables["tableWarm"].Clear();
                dataAdapterWarm.Fill(dataSetWarm, "tableWarm");
                tableWarm = dataSetWarm.Tables["tableWarm"];
                dataGridView1.DataSource = dataSetWarm.Tables["tableWarm"];

                SeriesCollection seriesTemp = new SeriesCollection();
                ChartValues<int> tempsTemp = new ChartValues<int>();
                List<string> datesTemp = new List<string>();
                LineSeries lineTemp = new LineSeries();
                foreach (DataRow rowTemp in tableWarm.Rows)
                {
                    tempsTemp.Add(Convert.ToInt32(rowTemp["temp"]));
                    datesTemp.Add(Convert.ToDateTime(rowTemp["date"]).ToShortDateString());
                    if (Convert.ToInt32(rowTemp["temp"]) < 0 | Convert.ToInt32(rowTemp["temp"]) > 6) { Warning1.Text = Convert.ToString(rowTemp["temp"]); }
                    else { Warning1.Text = Convert.ToString("В норме"); }
                }
                chartTemp.AxisX.Clear();
                chartTemp.AxisX.Add(new Axis()
                {
                    Title = "Даты",
                    Labels = datesTemp
                });
                lineTemp.Title = "Температура";
                lineTemp.Values = tempsTemp;
                seriesTemp.Add(lineTemp);
                chartTemp.Series = seriesTemp;
                chartTemp.AxisY.Clear();

                SeriesCollection seriesMoist = new SeriesCollection();
                ChartValues<int> tempsMoist = new ChartValues<int>();
                List<string> datesMoist = new List<string>();
                LineSeries lineMoist = new LineSeries();
                foreach (DataRow rowMoist in tableWarm.Rows)
                {
                    tempsMoist.Add(Convert.ToInt32(rowMoist["moisture"]));
                    datesMoist.Add(Convert.ToDateTime(rowMoist["date"]).ToShortDateString());
                    if (Convert.ToInt32(rowMoist["moisture"]) > 65) { Warning2.Text = Convert.ToString(rowMoist["moisture"]); }
                    else { Warning2.Text = Convert.ToString("В норме"); }
                }
                chartMoisture.AxisX.Clear();
                chartMoisture.AxisX.Add(new Axis()
                {
                    Title = "Даты",
                    Labels = datesMoist
                });
                lineMoist.Title = "Влажность";
                lineMoist.Values = tempsMoist;
                seriesMoist.Add(lineMoist);
                chartMoisture.Series = seriesMoist;
                chartMoisture.AxisY.Clear();
            }
            else if (tableCheck == false)
            {
                dataAdapterCold = new SqlDataAdapter($"SELECT * FROM Cold WHERE date BETWEEN '{dateTimePicker1.Value}' AND '{dateTimePicker2.Value}'", SqlCon);
                dataSetCold = new DataSet();
                if (dataSetCold.Tables["tableCold"] != null) dataSetCold.Tables["tableCold"].Clear();
                dataAdapterCold.Fill(dataSetCold, "tableCold");
                tableCold = dataSetCold.Tables["tableCold"];
                dataGridView1.DataSource = dataSetCold.Tables["tableCold"];

                SeriesCollection seriesTemp = new SeriesCollection();
                ChartValues<int> tempsTemp = new ChartValues<int>();
                List<string> datesTemp = new List<string>();
                LineSeries lineTemp = new LineSeries();
                foreach (DataRow rowTemp in tableCold.Rows)
                {
                    tempsTemp.Add(Convert.ToInt32(rowTemp["temp"]));
                    datesTemp.Add(Convert.ToDateTime(rowTemp["date"]).ToShortDateString());
                    if (Convert.ToInt32(rowTemp["temp"]) < 0 | Convert.ToInt32(rowTemp["temp"]) > 6) { Warning1.Text = Convert.ToString(rowTemp["temp"]); }
                    else { Warning1.Text = Convert.ToString("В норме"); }
                }
                chartTemp.AxisX.Clear();
                chartTemp.AxisX.Add(new Axis()
                {
                    Title = "Даты",
                    Labels = datesTemp
                });
                lineTemp.Title = "Температура";
                lineTemp.Values = tempsTemp;
                seriesTemp.Add(lineTemp);
                chartTemp.Series = seriesTemp;
                chartTemp.AxisY.Clear();

                SeriesCollection seriesMoist = new SeriesCollection();
                ChartValues<int> tempsMoist = new ChartValues<int>();
                List<string> datesMoist = new List<string>();
                LineSeries lineMoist = new LineSeries();
                foreach (DataRow rowMoist in tableCold.Rows)
                {
                    tempsMoist.Add(Convert.ToInt32(rowMoist["moisture"]));
                    datesMoist.Add(Convert.ToDateTime(rowMoist["date"]).ToShortDateString());
                    if (Convert.ToInt32(rowMoist["moisture"]) > 65) { Warning2.Text = Convert.ToString(rowMoist["moisture"]); }
                    else { Warning2.Text = Convert.ToString("В норме"); }
                }
                chartMoisture.AxisX.Clear();
                chartMoisture.AxisX.Add(new Axis()
                {
                    Title = "Даты",
                    Labels = datesMoist
                });
                lineMoist.Title = "Влажность";
                lineMoist.Values = tempsMoist;
                seriesMoist.Add(lineMoist);
                chartMoisture.Series = seriesMoist;
                chartMoisture.AxisY.Clear();
            }
        }
    }
}
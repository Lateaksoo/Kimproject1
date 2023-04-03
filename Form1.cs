using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.InteropServices.ComTypes;


namespace Kimproject1
{
    public partial class Form1 : Form
    {
        NaverSearch naverSearch = new NaverSearch();
     
        public string search;
        public string startDate;
        public string endDate;
        public string age;
        public string sex;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search = txtSearch.Text;
            dynamic result =
                JsonConvert.DeserializeObject(naverSearch.naver(search, startDate, endDate, sex,age));
            List<double> ratios = new List<double>();
            foreach (var data in result.results[0].data)
            {
                ratios.Add((double)data.ratio);
            }

            chart1.Series.Clear();
            Series series = chart1.Series.Add($"{search} 검색 비율");
            series.ChartType = SeriesChartType.Column;
            for (int i = 0; i < ratios.Count; i++)
            {
                series.Points.AddXY(i + 1, ratios[i]);
            }
        }






        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
        }

        private void comboBoxAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxAge.Text)
            {
                case "10대": age = "1"; break;
                case "20대": age = "2"; break;
                case "30대": age = "3"; break;
                case "40대": age = "4"; break;
            }
        }

        private void comboBoxSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            sex = comboBoxSex.Text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;

namespace Kimproject1
{
    internal class NaverSearch
    {
        public string naver()
        {
            const string ClientId = "VtMF3sZjkx3ZpUODF_Zi";
            const string ClientSECRET = "M4XgPPJUUX";

            string url = "https://openapi.naver.com/v1/datalab/search";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", ClientId);
            request.Headers.Add("X-Naver-Client-Secret", ClientSECRET);
            request.ContentType = "application/json";
            request.Method = "POST";
            string body = "{\"startDate\":\"2017-01-01\",\"endDate\":\"2022-04-30\",\"timeUnit\":\"month\",\"keywordGroups\":[{\"groupName\":\"글록17\",\"keywords\":[\"총\"]}],\"device\":\"pc\",\"ages\":[\"1\",\"2\",\"3\",\"4\"]}";


            byte[] byteDataParams = Encoding.UTF8.GetBytes(body);
            request.ContentLength = byteDataParams.Length;
            Stream st = request.GetRequestStream();
            st.Write(byteDataParams, 0, byteDataParams.Length);
            st.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string text = reader.ReadToEnd();
            stream.Close();
            response.Close();
            reader.Close();


            return (text);
        }

    }
}


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    dynamic result = JsonConvert.DeserializeObject(naver());
        //    List<double> ratios = new List<double>();
        //    foreach (var data in result.results[0].data)
        //    {
        //        ratios.Add((double)data.ratio);
        //    }

        //    chart1.Series.Clear();
        //    Series series = chart1.Series.Add("글록17 검색 비율");
        //    series.ChartType = SeriesChartType.Column;
        //    for (int i = 0; i < ratios.Count; i++)
        //    {
        //        series.Points.AddXY(i + 1, ratios[i]);
        //    }
        //}

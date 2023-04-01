using System;
using System.IO;
using System.Net;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Kimproject1
{
    internal class NaverSearch
    {
        public string naver(string serarch ,string startDate , string endDate ,string sex, string age)
        {
        Form1 form1 = new Form1();
            

            const string ClientId = "VtMF3sZjkx3ZpUODF_Zi"; //네이버 api 아이디
            const string ClientSECRET = "M4XgPPJUUX";       //네이버 api 비번

            string url = "https://openapi.naver.com/v1/datalab/search";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", ClientId);
            request.Headers.Add("X-Naver-Client-Secret", ClientSECRET);
            request.ContentType = "application/json";
            request.Method = "POST";

       

            string body1 = $"{{\"startDate\":\"{startDate}\"," +
              $"\"endDate\":\"{endDate}\"," +
              $"\"timeUnit\":\"month\"," +
              $"\"keywordGroups\":" +
              $"[{{\"groupName\":\"{serarch}\",\"keywords\":[\"총\"]}}]," +
              $"\"device\":\"pc\",\"ages\":[\"{age}\"]}}";


            string body = "{\"startDate\":\"2017-01-01\"," +
                           "\"endDate\":\"2022-04-30\"," +
                           "\"timeUnit\":\"month\"," +
                           "\"keywordGroups\":" +
                           "[{\"groupName\":\"글록17\",\"keywords\":[\"총\"]}]," +
                           "\"device\":\"pc\",\"ages\":[\"1\",\"2\",\"3\",\"4\"]}";


            byte[] byteDataParams = Encoding.UTF8.GetBytes(body1);
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



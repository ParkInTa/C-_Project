using iotApp1005.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace iotApp1005.Util
{
    class ThingSpeak
    {
#pragma warning disable S1075 // URIs should not be hardcoded
        const string url = "http://api.thingspeak.com/";
        const string APIKEY_WRITE = "5H0M08JBVRDX9JVU";
        const string APIKEY_READ = "1S99TPU6I5VGWBS4";
        const string CHANNEL_ID = "1498607";

        public bool sendDataToThingSpeak(string field1, string field2,
            string field3, string field4, string field5,
            string field6, string field7, string field8)
        {
            string sbQS = string.Empty;
            // http 통신
            sbQS += url + "update?key=" + APIKEY_WRITE;
            if (field1 != null)
            {
                sbQS += "&field1=" + HttpUtility.UrlEncode(field1);
            }
            if (field2 != null)
            {
                sbQS += "&field2=" + HttpUtility.UrlEncode(field2);
            }
            if (field3 != null)
            {
                sbQS += "&field3=" + HttpUtility.UrlEncode(field3);
            }
            if (field4 != null)
            {
                sbQS += "&field4=" + HttpUtility.UrlEncode(field4);
            }
            if (field5 != null)
            {
                sbQS += "&field5=" + HttpUtility.UrlEncode(field5);
            }
            if (field6 != null)
            {
                sbQS += "&field6=" + HttpUtility.UrlEncode(field6);
            }
            if (field7 != null)
            {
                sbQS += "&field7=" + HttpUtility.UrlEncode(field7);
            }
            if (field8 != null)
            {
                sbQS += "&field8=" + HttpUtility.UrlEncode(field8);
            }
            int res = Convert.ToInt32(postToThingSpeak(sbQS));
            if (res <= 0)
            {
                return false;
            }
            return true;
        }

        public string postToThingSpeak(string str)
        {
            string response = string.Empty;
            byte[] buf = new byte[8192];

            HttpWebRequest myRequest =
                (HttpWebRequest)WebRequest.Create(str);
            HttpWebResponse webResponse =
                (HttpWebResponse)myRequest.GetResponse();

            try
            {
                Stream myResponse = webResponse.GetResponseStream();
                int count = 0;
                do
                {
                    count = myResponse.Read(buf, 0, buf.Length);
                    if (count != 0)
                    {
#pragma warning disable S1643 // Strings should not be concatenated using '+' in a loop
                        response += Encoding.ASCII.GetString(buf, 0, count);
                    }
                } while (count > 0);
                return response;
            }
            catch (WebException e)
            {
                Console.WriteLine("응답 에러: " + e.Message);
            }
            return "0";
        }

        public List<LineEnvData> readThingSpeak()
        {
#pragma warning disable S1117 // Local variables should not shadow class fields
            string url =
#pragma warning restore S1117 // Local variables should not shadow class fields
#pragma warning disable S3457 // Composite format strings should be used correctly
                string.Format($"https://api.thingspeak.com/channels/" +
                    $"{CHANNEL_ID}/feeds.json?api_key={APIKEY_READ}&results=1");
#pragma warning disable S2930 // "IDisposables" should be disposed
            WebClient webClient = new WebClient();
            var data = webClient.DownloadString(url);
            dynamic feed = JsonConvert.DeserializeObject<dynamic>(data);
            List<dynamic> feeds = feed.feeds.ToObject<List<dynamic>>();
            List<LineEnvData> list = new List<LineEnvData>();

            Console.WriteLine("채널 정보: " + feed.channel.name);
            for (int i = 0; i < feeds.Count; i++)
            {
                string time = feeds[i].created_at;
                string temp1 = feeds[i].field1;
                string humi1 = feeds[i].field2;
                string temp2 = feeds[i].field3;
                string humi2 = feeds[i].field4;
                list.Add(new LineEnvData(time, temp1, humi1,
                    temp2, humi2));
            }
            return list;
        }
    }

    class ThingSpeakTimer
    {
        readonly Timer timer;

        public ThingSpeakTimer(Timer timer)
        {
            this.timer = timer;
        }

        ~ThingSpeakTimer()
        {
            Console.WriteLine("타이머 소멸");
            stopTimer();
        }

        public void stopTimer()
        {
            timer.Dispose();
        }
    }
}

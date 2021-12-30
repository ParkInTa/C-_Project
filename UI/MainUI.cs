using iotApp1005.DAO;
using iotApp1005.Model;
using iotApp1005.UI;
using iotApp1005.Util;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Timer = System.Threading.Timer;

namespace iotApp1005
{
    enum DATA_TYPE
    {
        LINE,
        TEMP,
        HUMI
    }

    public partial class MainUI : MaterialForm
    {
        const string LINE1 = "1";
        const string LINE2 = "2";
        ThingSpeak ts = new ThingSpeak();
        ThingSpeakTimer sTimer, rTimer;
        string[] temp = {"15", "22", "38", "41", "57", "63",
                "77", "84", "92", "104"};
        string[] humi = {"15", "22", "38", "41", "57", "63",
                "77", "84", "92", "104"};
        Random r = new Random();
        IniData ini;

        public MainUI()
        {
            initINI();
            InitializeComponent();
            OraMgr.Instance.connectDB();
            sTimer = new ThingSpeakTimer(
                new Timer(new TimerCallback(writeHandler),
                null, 1000, 20000));

            rTimer = new ThingSpeakTimer(
                new Timer(new TimerCallback(readHandler),
                null, 2000, 20000));
            comDisconnect.Enabled = false;
        }

        private void initINI()
        {
            FileInfo fileInfo = new FileInfo(Application.ExecutablePath);
            string path = fileInfo.Directory.FullName.ToString();
            string filePath = path + IniData.INI_FILE_NAME;
            ini = new IniData(filePath);

            // 컴퓨터에 ini파일이 없으면
            if (!File.Exists(filePath))
            {
                ini.setIniVal(IniData.SECTION, IniData.KEY_PORT, 
                    IniData.DEFAULT_PORT);
                ini.setIniVal(IniData.SECTION, IniData.KEY_BAUDRATE,
                    IniData.DEFAULT_BAUDRATE);
                ini.setIniVal(IniData.SECTION, IniData.KEY_DATABITS,
                    IniData.DEFAULT_DATABITS);
                ini.setIniVal(IniData.SECTION, IniData.KEY_PARITY,
                    IniData.DEFAULT_PARITY);
                ini.setIniVal(IniData.SECTION, IniData.KEY_STOPBITS,
                    IniData.DEFAULT_STOPBITS);
            }
        }

        void writeHandler(object args)
        {
            string time = DateTime.Now.ToString("yyyy년MM월dd일 HH:mm:ss");
            string temp1 = temp[r.Next(10)];
            string humi1 = humi[r.Next(10)];
            string temp2 = temp[r.Next(10)];
            string humi2 = humi[r.Next(10)];
            bool chk = ts.sendDataToThingSpeak(
                temp1, humi1, temp2, humi2,
                null, null, null, null);
            if (chk)
            {
                Console.WriteLine("데이터 전송 성공!");
            }
            else
            {
                Console.WriteLine("데이터 전송 실패!");
            }
            OraMgr.Instance.insertDB(new LineEnvData(
            time, temp1, humi1, temp2, humi2));
            //OraMgr.Instance.showDB();
        }

        void readHandler(object args)
        {
            List<LineEnvData> list = ts.readThingSpeak();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("시간: " + list[i].Time);
                Console.WriteLine("부품 1라인 온도: " + list[i].Temp1 + " ℃");
                Console.WriteLine("부품 1라인 습도: " + list[i].Humi1 + " ℃");
                Console.WriteLine("부품 2라인 온도: " + list[i].Temp2 + " ℃");
                Console.WriteLine("부품 2라인 습도: " + list[i].Humi2 + " %");

                // work쓰레드에서 UI쓰레드 사용
                this.Invoke(new Action(delegate ()
                {
                    try
                    {
                        line1Temp.Text = list[i].Temp1 + " ℃";
                        line1Humi.Text = list[i].Humi1 + " %";
                        line1Time.Text = list[i].Time;
                        line2Temp.Value = int.Parse(list[i].Temp2);
                        line2Humi.Value = int.Parse(list[i].Humi2);
                    }
                    catch(FormatException e)
                    {
                        Console.WriteLine("잘못된 문자열 포맷 형식!");
                        return;
                    }
                }));

                Console.WriteLine("[부품 라인 모니터링 정보]");
                int nTemp1 = Convert.ToInt32(list[i].Temp1);
                if (nTemp1 < 20)
                {
                    line1Led.Color = Color.Red;
                    Console.WriteLine("[온도 낮음]부품 1라인 히터 가동합니다.");
                    new SoundPlayer(Properties.Resources.siren).Play();
                }
                else if (nTemp1 > 21 && nTemp1 < 70)
                {
                    line1Led.Color = Color.Green;
                    Console.WriteLine("[정상 온도]부품 1라인 정상 가동중입니다");
                }
                else
                {
                    line1Led.Color = Color.Red;
                    Console.WriteLine("[온도 높음]부품 1라인 에어컨 가동합니다.");
                    new SoundPlayer(Properties.Resources.siren).Play();
                }
                Console.WriteLine("---------------------------------");
                initCommChart2(list);
                //OraMgr.Instance.showDB();
            }
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            initCommChart();
            initBarChart();
            initPieChart();
        }

        int count = 0;
        void initCommChart()
        {
            chart1.Series["chartTemp1"].Points.Add(r.Next(100));
            chart1.Series["chartHumi1"].Points.Add(r.Next(100));
            chart1.Series["chartTemp2"].Points.Add(r.Next(100));
            chart1.Series["chartHumi2"].Points.Add(r.Next(100));
        }
        
        void initCommChart(List<LineEnvData> list)
        {
            if (count == 3)
            {
                foreach (var series in chart1.Series)
                {
                    Invoke(new Action(delegate ()
                    {
                        series.Points.Clear();
                    }));
                }
                count = 0;
            }

            for (int i = 0; i < list.Count; i++)
            {
                Invoke(new Action(delegate ()
                {
                    chart1.Series["chartTemp1"].Points.Add(
                        int.Parse(list[i].Temp1));
                    chart1.Series["chartTemp1"].LegendText = "1라인 온도";

                    chart1.Series["chartHumi1"].Points.Add(
                        int.Parse(list[i].Humi1));
                    chart1.Series["chartHumi1"].LegendText = "1라인 습도";

                    chart1.Series["chartTemp2"].Points.Add(
                        int.Parse(list[i].Temp2));
                    chart1.Series["chartTemp2"].LegendText = "2라인 온도";

                    chart1.Series["chartHumi2"].Points.Add(
                        int.Parse(list[i].Humi2));
                    chart1.Series["chartHumi2"].LegendText = "2라인 온도";
                }));
            }
            count++;
        }

        void initCommChart2(List<LineEnvData> list)
        {
            foreach (var series in chart1.Series)
            {
                Invoke(new Action(delegate ()
                {
                    series.Points.Clear();
                }));
            }

            for (int i = 0; i < list.Count; i++)
            {
                Invoke(new Action(delegate ()
                {
                    chart1.Series[i].Points.AddXY("1라인 온도",
                        int.Parse(list[i].Temp1));
                    chart1.Series[i].Points[0].Color = Color.Red;
                    chart1.Series[i].Points[0].Label = list[i].Temp1;
                    chart1.Series[i].Points[0].BackGradientStyle =
                        GradientStyle.None;

                    chart1.Series[i].Points.AddXY("1라인 습도",
                        int.Parse(list[i].Humi1));
                    chart1.Series[i].Points[1].Color = Color.Blue;
                    chart1.Series[i].Points[1].Label = list[i].Humi1;
                    chart1.Series[i].Points[1].BackGradientStyle =
                        GradientStyle.None;

                    chart1.Series[i].Points.AddXY("2라인 온도",
                        int.Parse(list[i].Temp2));
                    chart1.Series[i].Points[2].Color = Color.Green;
                    chart1.Series[i].Points[2].Label = list[i].Temp2;
                    chart1.Series[i].Points[2].BackGradientStyle =
                        GradientStyle.None;

                    chart1.Series[i].Points.AddXY("2라인 습도",
                        int.Parse(list[i].Humi2));
                    chart1.Series[i].Points[3].Color = Color.Cyan;
                    chart1.Series[i].Points[3].Label = list[i].Humi2;
                    chart1.Series[i].Points[3].BackGradientStyle =
                        GradientStyle.None;
                }));
            }
        }



        void initBarChart()
        {
            UIBarOption option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text = "생산1라인";
            option.Title.SubText = "온도 상태";

            // 범례 (Legend)
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Horizontal;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;
            option.Legend.AddData("온도");

            option.ToolTip = new UIBarToolTip();
            var series = new UIBarSeries();
            series.Name = "Temp";
            series.AddData(11);
            series.AddData(15);
            series.AddData(28);
            series.AddData(37);
            option.Series.Add(series);

            option.XAxis.Data.Add("21년9월3일");
            option.XAxis.Data.Add("21년9월4일");
            option.XAxis.Data.Add("21년9월5일");
            option.XAxis.Data.Add("21년9월6일");
            option.YAxis.Scale = true;

            option.XAxis.Name = "시간";
            option.YAxis.Name = "온도";
            uiBarChart1.SetOption(option);
        }

        private void comSetting_Click(object sender, EventArgs e)
        {
            new SettingCOM().ShowDialog();
        }

        private void comConnect_Click(object sender, EventArgs e)
        {
            safeAction(() => connect());
        }

        private void comDisconnect_Click(object sender, EventArgs e)
        {
            safeAction(() => portClose());
        }

        private void portClose()
        {
            if (mSerial.IsOpen)
            {
                safeAction(() => mSerial.Close(), false);
                userDelay(100);
                string str = mSerial.PortName + " 연결이 해제되었습니다.";
                comConnect.Enabled = true;
                comDisconnect.Enabled = false;
                comStatus.Text = str;
                MessageBox.Show(str);
                // 로그 처리
            }
        }

#pragma warning disable S3241 // Methods should not return values that are never used
        private static DateTime userDelay(int ms)
#pragma warning restore S3241 // Methods should not return values that are never used
        {
            DateTime nowTime = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime afterTime = nowTime.Add(duration);
            while (afterTime >= nowTime)
            {
                // 현재까지 윈도우에 존재하는 모든 메시지 처리
                Application.DoEvents();
                nowTime = DateTime.Now;
            }
            return DateTime.Now;
        }

        void safeAction(Action action, bool msg = true)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                if (msg)
                {
                    // 로그 처리
                    MessageBox.Show(e.Message, "오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // 로그 처리
                    Console.WriteLine(mSerial.PortName + "의 연결이 해제되었습니다.");
                }
            }
        }

        private void connect()
        {
            try
            {
                mSerial = new SerialPort();
                mSerial.PortName = ini.getIniVal(IniData.SECTION, IniData.KEY_PORT);
                mSerial.BaudRate =
                    int.Parse(ini.getIniVal(IniData.SECTION, IniData.KEY_BAUDRATE));
                mSerial.DataBits =
                    int.Parse(ini.getIniVal(IniData.SECTION, IniData.KEY_DATABITS));
                mSerial.Parity =
                    getParityIndex(ini.getIniVal(IniData.SECTION, IniData.KEY_PARITY));
                mSerial.StopBits =
                    getStopbitIndex(ini.getIniVal(IniData.SECTION, IniData.KEY_STOPBITS));
                mSerial.Handshake = Handshake.None;
                mSerial.DataReceived += 
                    new SerialDataReceivedEventHandler(dataRecvHandler);
                mSerial.Open();
                string str = mSerial.PortName + "에 연결이 되었습니다.";
                comConnect.Enabled = false;
                comDisconnect.Enabled = true;
                comStatus.Text = str;
                Console.WriteLine(str);
                MessageBox.Show(str);

                // 로그처리
            }
            catch (Exception e)
            {
                Console.WriteLine("접속 에러: " + e.Message);
                // 로그 처리
            }
        }

        private delegate void LineReceivedEvent(string line);
        private void dataRecvHandler(object sender, SerialDataReceivedEventArgs e)
        {
            safeAction(() =>
            {
                SerialPort sp = sender as SerialPort;
                string line = sp.ReadLine();
                BeginInvoke(new LineReceivedEvent(lineReceived), line);
            }, false);
        }

        private void lineReceived(string line)
        {
            Console.WriteLine("데이터 수신: " + line);
            string[] strArr = 
                ParsingData.parseAllWord(line, "[", "]");
            // 시작-라인-온도-습도-끝 [1/23/37]
            // [2/30/46]
            foreach(var data in strArr)
            {
                Console.WriteLine("data: {0}", data);
                if (data != null)
                {
                    string[] dataArr = data.Split("/");
                    switch (dataArr[(int)DATA_TYPE.LINE])
                    {
                        case LINE1:
                            line1Temp.Text = dataArr[(int)DATA_TYPE.TEMP];
                            line1Humi.Text = dataArr[(int)DATA_TYPE.HUMI];
                            break;
                        case LINE2:
                            line2Temp.Value = 
                                double.Parse(dataArr[(int)DATA_TYPE.TEMP]);
                            line2Humi.Value = 
                                double.Parse(dataArr[(int)DATA_TYPE.HUMI]);
                            break;
                    }
                }
            }
        }

        private StopBits getStopbitIndex(string stop)
        {
            int res = 0;
            if (stop.Equals("1"))
            {
                res = (int)StopBits.One;
            }
            else if (stop.Equals("1.5"))
            {
                res = (int)StopBits.OnePointFive;
            }
            else if (stop.Equals("2"))
            {
                res = (int)StopBits.Two;
            }
            return (StopBits)res;
        }

        private Parity getParityIndex(string parity)
        {
            int res = 0;
            if (parity.Equals("None"))
            {
                res = (int)Parity.None;
            }
            else if (parity.Equals("Odd"))
            {
                res = (int)Parity.Odd;
            }
            else if (parity.Equals("Even"))
            {
                res = (int)Parity.Even;
            }
            else if (parity.Equals("Mark"))
            {
                res = (int)Parity.Mark;
            }
            else if (parity.Equals("Space"))
            {
                res = (int)Parity.Space;
            }
            return (Parity)res;
        }

        void initPieChart()
        {
            var option = new UIPieOption();
            option.Title = new UITitle();
            option.Title.Text = "생산2라인";
            option.Title.SubText = "습도 상태";
            option.Title.Left = UILeftAlignment.Center;
            option.ToolTip = new UIPieToolTip();

            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;

            option.Legend.AddData("온도");
            option.Legend.AddData("습도");
            option.Legend.AddData("미세먼지");

            var series = new UIPieSeries();
            series.Name = "Humi";
            series.Center = new UICenter(50, 55);
            series.Radius = 70;
            series.AddData("온도", 38);
            series.AddData("습도", 40);
            series.AddData("미세먼지", 32);
            option.Series.Add(series);
            uiPieChart1.SetOption(option);
        }
    }
}
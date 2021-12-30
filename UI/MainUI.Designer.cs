
namespace iotApp1005
{
    partial class MainUI
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.line1Temp = new Sunny.UI.UISymbolLabel();
            this.line1Humi = new Sunny.UI.UISymbolLabel();
            this.line1Time = new Sunny.UI.UISymbolLabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.line2Temp = new Sunny.UI.UIAnalogMeter();
            this.uiBarChart1 = new Sunny.UI.UIBarChart();
            this.uiDoughnutChart1 = new Sunny.UI.UIDoughnutChart();
            this.uiLineChart1 = new Sunny.UI.UILineChart();
            this.uiPieChart1 = new Sunny.UI.UIPieChart();
            this.line2Humi = new Sunny.UI.UIAnalogMeter();
            this.line1Led = new Sunny.UI.UILedBulb();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel7 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel8 = new Sunny.UI.UISymbolLabel();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiLine3 = new Sunny.UI.UILine();
            this.comSetting = new Sunny.UI.UISymbolButton();
            this.comConnect = new Sunny.UI.UISymbolButton();
            this.comDisconnect = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mSerial = new System.IO.Ports.SerialPort(this.components);
            this.comStatus = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(47, 94);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(54, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(294, 60);
            this.uiSymbolLabel1.Symbol = 61573;
            this.uiSymbolLabel1.SymbolSize = 50;
            this.uiSymbolLabel1.TabIndex = 0;
            this.uiSymbolLabel1.Text = "부품 1라인 정보";
            // 
            // line1Temp
            // 
            this.line1Temp.BackColor = System.Drawing.Color.Transparent;
            this.line1Temp.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line1Temp.Location = new System.Drawing.Point(47, 176);
            this.line1Temp.MinimumSize = new System.Drawing.Size(1, 1);
            this.line1Temp.Name = "line1Temp";
            this.line1Temp.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.line1Temp.Size = new System.Drawing.Size(230, 60);
            this.line1Temp.Symbol = 62152;
            this.line1Temp.SymbolColor = System.Drawing.Color.Red;
            this.line1Temp.SymbolSize = 40;
            this.line1Temp.TabIndex = 1;
            this.line1Temp.Text = "0 ℃";
            this.line1Temp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // line1Humi
            // 
            this.line1Humi.BackColor = System.Drawing.Color.Transparent;
            this.line1Humi.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line1Humi.Location = new System.Drawing.Point(47, 242);
            this.line1Humi.MinimumSize = new System.Drawing.Size(1, 1);
            this.line1Humi.Name = "line1Humi";
            this.line1Humi.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.line1Humi.Size = new System.Drawing.Size(230, 60);
            this.line1Humi.Symbol = 61507;
            this.line1Humi.SymbolColor = System.Drawing.Color.RoyalBlue;
            this.line1Humi.SymbolSize = 40;
            this.line1Humi.TabIndex = 2;
            this.line1Humi.Text = "0 %";
            this.line1Humi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // line1Time
            // 
            this.line1Time.BackColor = System.Drawing.Color.Transparent;
            this.line1Time.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line1Time.Location = new System.Drawing.Point(47, 308);
            this.line1Time.MinimumSize = new System.Drawing.Size(1, 1);
            this.line1Time.Name = "line1Time";
            this.line1Time.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.line1Time.Size = new System.Drawing.Size(294, 60);
            this.line1Time.Symbol = 61463;
            this.line1Time.SymbolColor = System.Drawing.Color.Green;
            this.line1Time.SymbolSize = 40;
            this.line1Time.TabIndex = 3;
            this.line1Time.Text = "등록 시간";
            this.line1Time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Red;
            this.uiLine1.Location = new System.Drawing.Point(47, 157);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(294, 2);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 4;
            // 
            // line2Temp
            // 
            this.line2Temp.BackColor = System.Drawing.Color.White;
            this.line2Temp.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.line2Temp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.line2Temp.Location = new System.Drawing.Point(667, 143);
            this.line2Temp.MaxValue = 100D;
            this.line2Temp.MinimumSize = new System.Drawing.Size(1, 1);
            this.line2Temp.MinValue = 0D;
            this.line2Temp.Name = "line2Temp";
            this.line2Temp.NeedleColor = System.Drawing.Color.Red;
            this.line2Temp.Renderer = null;
            this.line2Temp.Size = new System.Drawing.Size(232, 227);
            this.line2Temp.Style = Sunny.UI.UIStyle.Custom;
            this.line2Temp.TabIndex = 6;
            this.line2Temp.Text = "uiAnalogMeter1";
            this.line2Temp.Value = 57D;
            // 
            // uiBarChart1
            // 
            this.uiBarChart1.FillColor = System.Drawing.Color.Transparent;
            this.uiBarChart1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiBarChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiBarChart1.Location = new System.Drawing.Point(47, 434);
            this.uiBarChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBarChart1.Name = "uiBarChart1";
            this.uiBarChart1.RectColor = System.Drawing.Color.Transparent;
            this.uiBarChart1.Size = new System.Drawing.Size(294, 246);
            this.uiBarChart1.Style = Sunny.UI.UIStyle.Custom;
            this.uiBarChart1.TabIndex = 7;
            this.uiBarChart1.Text = "uiBarChart1";
            // 
            // uiDoughnutChart1
            // 
            this.uiDoughnutChart1.FillColor = System.Drawing.Color.Transparent;
            this.uiDoughnutChart1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiDoughnutChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiDoughnutChart1.Location = new System.Drawing.Point(364, 434);
            this.uiDoughnutChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiDoughnutChart1.Name = "uiDoughnutChart1";
            this.uiDoughnutChart1.RectColor = System.Drawing.Color.Transparent;
            this.uiDoughnutChart1.Size = new System.Drawing.Size(294, 246);
            this.uiDoughnutChart1.Style = Sunny.UI.UIStyle.Custom;
            this.uiDoughnutChart1.TabIndex = 8;
            this.uiDoughnutChart1.Text = "uiDoughnutChart1";
            // 
            // uiLineChart1
            // 
            this.uiLineChart1.FillColor = System.Drawing.Color.Transparent;
            this.uiLineChart1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLineChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiLineChart1.Location = new System.Drawing.Point(677, 434);
            this.uiLineChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLineChart1.Name = "uiLineChart1";
            this.uiLineChart1.RectColor = System.Drawing.Color.Transparent;
            this.uiLineChart1.Size = new System.Drawing.Size(294, 246);
            this.uiLineChart1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLineChart1.TabIndex = 9;
            this.uiLineChart1.Text = "uiLineChart1";
            // 
            // uiPieChart1
            // 
            this.uiPieChart1.FillColor = System.Drawing.Color.Transparent;
            this.uiPieChart1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPieChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiPieChart1.Location = new System.Drawing.Point(989, 434);
            this.uiPieChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPieChart1.Name = "uiPieChart1";
            this.uiPieChart1.RectColor = System.Drawing.Color.Transparent;
            this.uiPieChart1.Size = new System.Drawing.Size(294, 246);
            this.uiPieChart1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPieChart1.TabIndex = 10;
            this.uiPieChart1.Text = "uiPieChart1";
            // 
            // line2Humi
            // 
            this.line2Humi.BackColor = System.Drawing.Color.White;
            this.line2Humi.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line2Humi.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.line2Humi.Location = new System.Drawing.Point(964, 143);
            this.line2Humi.MaxValue = 100D;
            this.line2Humi.MinimumSize = new System.Drawing.Size(1, 1);
            this.line2Humi.MinValue = 0D;
            this.line2Humi.Name = "line2Humi";
            this.line2Humi.NeedleColor = System.Drawing.Color.DeepSkyBlue;
            this.line2Humi.Renderer = null;
            this.line2Humi.Size = new System.Drawing.Size(232, 227);
            this.line2Humi.Style = Sunny.UI.UIStyle.Custom;
            this.line2Humi.TabIndex = 11;
            this.line2Humi.Text = "uiAnalogMeter2";
            this.line2Humi.Value = 57D;
            // 
            // line1Led
            // 
            this.line1Led.BackColor = System.Drawing.Color.Transparent;
            this.line1Led.Color = System.Drawing.Color.Red;
            this.line1Led.Location = new System.Drawing.Point(382, 143);
            this.line1Led.Name = "line1Led";
            this.line1Led.Size = new System.Drawing.Size(232, 241);
            this.line1Led.TabIndex = 12;
            this.line1Led.Text = "uiLedBulb2";
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(36, 686);
            this.chart1.Name = "chart1";
            series21.ChartArea = "ChartArea1";
            series21.Legend = "Legend1";
            series21.Name = "chartTemp1";
            series21.YValuesPerPoint = 2;
            series22.ChartArea = "ChartArea1";
            series22.Legend = "Legend1";
            series22.Name = "chartHumi1";
            series23.ChartArea = "ChartArea1";
            series23.Legend = "Legend1";
            series23.Name = "chartTemp2";
            series24.ChartArea = "ChartArea1";
            series24.Legend = "Legend1";
            series24.Name = "chartHumi2";
            this.chart1.Series.Add(series21);
            this.chart1.Series.Add(series22);
            this.chart1.Series.Add(series23);
            this.chart1.Series.Add(series24);
            this.chart1.Size = new System.Drawing.Size(1247, 250);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            title6.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            title6.ForeColor = System.Drawing.Color.DarkGreen;
            title6.Name = "Title1";
            title6.Text = "헤드램프 생산라인 환경";
            this.chart1.Titles.Add(title6);
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel5.Location = new System.Drawing.Point(382, 97);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(232, 40);
            this.uiSymbolLabel5.Symbol = 62152;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.Red;
            this.uiSymbolLabel5.SymbolSize = 40;
            this.uiSymbolLabel5.TabIndex = 14;
            this.uiSymbolLabel5.Text = "부품 1라인 온도";
            // 
            // uiSymbolLabel7
            // 
            this.uiSymbolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel7.Location = new System.Drawing.Point(667, 97);
            this.uiSymbolLabel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel7.Name = "uiSymbolLabel7";
            this.uiSymbolLabel7.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel7.Size = new System.Drawing.Size(232, 40);
            this.uiSymbolLabel7.Symbol = 62152;
            this.uiSymbolLabel7.SymbolColor = System.Drawing.Color.Red;
            this.uiSymbolLabel7.SymbolSize = 40;
            this.uiSymbolLabel7.TabIndex = 16;
            this.uiSymbolLabel7.Text = "부품 2라인 온도";
            // 
            // uiSymbolLabel8
            // 
            this.uiSymbolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel8.Location = new System.Drawing.Point(964, 97);
            this.uiSymbolLabel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel8.Name = "uiSymbolLabel8";
            this.uiSymbolLabel8.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel8.Size = new System.Drawing.Size(232, 40);
            this.uiSymbolLabel8.Symbol = 61507;
            this.uiSymbolLabel8.SymbolColor = System.Drawing.Color.DodgerBlue;
            this.uiSymbolLabel8.SymbolSize = 40;
            this.uiSymbolLabel8.TabIndex = 17;
            this.uiSymbolLabel8.Text = "부품 2라인 습도";
            // 
            // uiLine2
            // 
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine2.LineColor = System.Drawing.Color.Red;
            this.uiLine2.Location = new System.Drawing.Point(47, 390);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(1231, 2);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 18;
            // 
            // uiLine3
            // 
            this.uiLine3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine3.LineColor = System.Drawing.Color.Red;
            this.uiLine3.Location = new System.Drawing.Point(47, 670);
            this.uiLine3.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(1231, 2);
            this.uiLine3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine3.TabIndex = 19;
            // 
            // comSetting
            // 
            this.comSetting.BackColor = System.Drawing.Color.Transparent;
            this.comSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comSetting.FillColor = System.Drawing.Color.Transparent;
            this.comSetting.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comSetting.Location = new System.Drawing.Point(382, 12);
            this.comSetting.MinimumSize = new System.Drawing.Size(1, 1);
            this.comSetting.Name = "comSetting";
            this.comSetting.Radius = 40;
            this.comSetting.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comSetting.Size = new System.Drawing.Size(161, 44);
            this.comSetting.Style = Sunny.UI.UIStyle.Custom;
            this.comSetting.Symbol = 61459;
            this.comSetting.TabIndex = 20;
            this.comSetting.Text = "COM 설정";
            this.comSetting.Click += new System.EventHandler(this.comSetting_Click);
            // 
            // comConnect
            // 
            this.comConnect.BackColor = System.Drawing.Color.Transparent;
            this.comConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comConnect.FillColor = System.Drawing.Color.Transparent;
            this.comConnect.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comConnect.Location = new System.Drawing.Point(549, 12);
            this.comConnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.comConnect.Name = "comConnect";
            this.comConnect.Radius = 40;
            this.comConnect.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comConnect.Size = new System.Drawing.Size(161, 44);
            this.comConnect.Style = Sunny.UI.UIStyle.Custom;
            this.comConnect.Symbol = 61633;
            this.comConnect.TabIndex = 21;
            this.comConnect.Text = "COM 연결";
            this.comConnect.Click += new System.EventHandler(this.comConnect_Click);
            // 
            // comDisconnect
            // 
            this.comDisconnect.BackColor = System.Drawing.Color.Transparent;
            this.comDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comDisconnect.FillColor = System.Drawing.Color.Transparent;
            this.comDisconnect.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comDisconnect.Location = new System.Drawing.Point(716, 12);
            this.comDisconnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.comDisconnect.Name = "comDisconnect";
            this.comDisconnect.Radius = 40;
            this.comDisconnect.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comDisconnect.Size = new System.Drawing.Size(161, 44);
            this.comDisconnect.Style = Sunny.UI.UIStyle.Custom;
            this.comDisconnect.Symbol = 61735;
            this.comDisconnect.TabIndex = 22;
            this.comDisconnect.Text = "COM 해제";
            this.comDisconnect.Click += new System.EventHandler(this.comDisconnect_Click);
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel2.Location = new System.Drawing.Point(20, 12);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(257, 44);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.Symbol = 61568;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel2.SymbolSize = 32;
            this.uiSymbolLabel2.TabIndex = 23;
            this.uiSymbolLabel2.Text = "MES 생산관리 시스템 2.0";
            // 
            // comStatus
            // 
            this.comStatus.BackColor = System.Drawing.Color.Transparent;
            this.comStatus.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comStatus.ForeColor = System.Drawing.Color.Cyan;
            this.comStatus.Location = new System.Drawing.Point(894, 20);
            this.comStatus.Name = "comStatus";
            this.comStatus.Size = new System.Drawing.Size(326, 29);
            this.comStatus.TabIndex = 24;
            this.comStatus.Text = "포트 상태 정보";
            this.comStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1317, 963);
            this.Controls.Add(this.comStatus);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.comDisconnect);
            this.Controls.Add(this.comConnect);
            this.Controls.Add(this.comSetting);
            this.Controls.Add(this.uiLine3);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.uiSymbolLabel8);
            this.Controls.Add(this.uiSymbolLabel7);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.line1Led);
            this.Controls.Add(this.line2Humi);
            this.Controls.Add(this.uiPieChart1);
            this.Controls.Add(this.uiLineChart1);
            this.Controls.Add(this.uiDoughnutChart1);
            this.Controls.Add(this.uiBarChart1);
            this.Controls.Add(this.line2Temp);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.line1Time);
            this.Controls.Add(this.line1Humi);
            this.Controls.Add(this.line1Temp);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel line1Temp;
        private Sunny.UI.UISymbolLabel line1Humi;
        private Sunny.UI.UISymbolLabel line1Time;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIAnalogMeter line2Temp;
        private Sunny.UI.UIBarChart uiBarChart1;
        private Sunny.UI.UIDoughnutChart uiDoughnutChart1;
        private Sunny.UI.UILineChart uiLineChart1;
        private Sunny.UI.UIPieChart uiPieChart1;
        private Sunny.UI.UIAnalogMeter line2Humi;
        private Sunny.UI.UILedBulb line1Led;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UISymbolLabel uiSymbolLabel7;
        private Sunny.UI.UISymbolLabel uiSymbolLabel8;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILine uiLine3;
        private Sunny.UI.UISymbolButton comSetting;
        private Sunny.UI.UISymbolButton comConnect;
        private Sunny.UI.UISymbolButton comDisconnect;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort mSerial;
        private Sunny.UI.UILabel comStatus;
    }
}


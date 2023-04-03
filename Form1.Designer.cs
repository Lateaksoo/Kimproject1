namespace Kimproject1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProductManagement = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.check40 = new System.Windows.Forms.CheckBox();
            this.check80 = new System.Windows.Forms.CheckBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.check10 = new System.Windows.Forms.CheckBox();
            this.check70 = new System.Windows.Forms.CheckBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.check20 = new System.Windows.Forms.CheckBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.check60 = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.check30 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.check50 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProductManagement);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 493);
            this.tabControl1.TabIndex = 2;
            // 
            // tabProductManagement
            // 
            this.tabProductManagement.Location = new System.Drawing.Point(4, 22);
            this.tabProductManagement.Name = "tabProductManagement";
            this.tabProductManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductManagement.Size = new System.Drawing.Size(692, 467);
            this.tabProductManagement.TabIndex = 0;
            this.tabProductManagement.Text = "상품관리";
            this.tabProductManagement.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(692, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "상품추가";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxSearch);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.check40);
            this.tabPage1.Controls.Add(this.check80);
            this.tabPage1.Controls.Add(this.dtpEndDate);
            this.tabPage1.Controls.Add(this.check10);
            this.tabPage1.Controls.Add(this.check70);
            this.tabPage1.Controls.Add(this.dtpStartDate);
            this.tabPage1.Controls.Add(this.check20);
            this.tabPage1.Controls.Add(this.comboBoxSex);
            this.tabPage1.Controls.Add(this.check60);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Controls.Add(this.check30);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.check50);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(692, 467);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "판매 트렌드";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "데스크탑",
            "노트북",
            "모니터",
            "키보드/마우스"});
            this.comboBoxSearch.Location = new System.Drawing.Point(93, 40);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(111, 20);
            this.comboBoxSearch.TabIndex = 28;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "연령대 선택";
            // 
            // check40
            // 
            this.check40.AutoSize = true;
            this.check40.Location = new System.Drawing.Point(182, 125);
            this.check40.Name = "check40";
            this.check40.Size = new System.Drawing.Size(48, 16);
            this.check40.TabIndex = 22;
            this.check40.Text = "40대";
            this.check40.UseVisualStyleBackColor = true;
            // 
            // check80
            // 
            this.check80.AutoSize = true;
            this.check80.Location = new System.Drawing.Point(182, 159);
            this.check80.Name = "check80";
            this.check80.Size = new System.Drawing.Size(48, 16);
            this.check80.TabIndex = 26;
            this.check80.Text = "80대";
            this.check80.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(93, 314);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(113, 21);
            this.dtpEndDate.TabIndex = 18;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // check10
            // 
            this.check10.AutoSize = true;
            this.check10.Location = new System.Drawing.Point(20, 125);
            this.check10.Name = "check10";
            this.check10.Size = new System.Drawing.Size(48, 16);
            this.check10.TabIndex = 19;
            this.check10.Text = "10대";
            this.check10.UseVisualStyleBackColor = true;
            // 
            // check70
            // 
            this.check70.AutoSize = true;
            this.check70.Location = new System.Drawing.Point(128, 159);
            this.check70.Name = "check70";
            this.check70.Size = new System.Drawing.Size(48, 16);
            this.check70.TabIndex = 25;
            this.check70.Text = "70대";
            this.check70.UseVisualStyleBackColor = true;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(93, 263);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(113, 21);
            this.dtpStartDate.TabIndex = 17;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // check20
            // 
            this.check20.AutoSize = true;
            this.check20.Location = new System.Drawing.Point(74, 125);
            this.check20.Name = "check20";
            this.check20.Size = new System.Drawing.Size(48, 16);
            this.check20.TabIndex = 20;
            this.check20.Text = "20대";
            this.check20.UseVisualStyleBackColor = true;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "남",
            "여"});
            this.comboBoxSex.Location = new System.Drawing.Point(93, 218);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(111, 20);
            this.comboBoxSex.TabIndex = 16;
            this.comboBoxSex.SelectedIndexChanged += new System.EventHandler(this.comboBoxSex_SelectedIndexChanged);
            // 
            // check60
            // 
            this.check60.AutoSize = true;
            this.check60.Location = new System.Drawing.Point(74, 159);
            this.check60.Name = "check60";
            this.check60.Size = new System.Drawing.Size(48, 16);
            this.check60.TabIndex = 24;
            this.check60.Text = "60대";
            this.check60.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(227, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(462, 461);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // check30
            // 
            this.check30.AutoSize = true;
            this.check30.Location = new System.Drawing.Point(128, 125);
            this.check30.Name = "check30";
            this.check30.Size = new System.Drawing.Size(48, 16);
            this.check30.TabIndex = 21;
            this.check30.Text = "30대";
            this.check30.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "검색어";
            // 
            // check50
            // 
            this.check50.AutoSize = true;
            this.check50.Location = new System.Drawing.Point(20, 159);
            this.check50.Name = "check50";
            this.check50.Size = new System.Drawing.Size(48, 16);
            this.check50.TabIndex = 23;
            this.check50.Text = "50대";
            this.check50.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "종료일";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(40, 348);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 43);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "시작일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "성별 선택";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 493);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SHOOTERS CLUB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProductManagement;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.CheckBox check10;
        private System.Windows.Forms.CheckBox check60;
        private System.Windows.Forms.CheckBox check50;
        private System.Windows.Forms.CheckBox check40;
        private System.Windows.Forms.CheckBox check30;
        private System.Windows.Forms.CheckBox check20;
        private System.Windows.Forms.CheckBox check80;
        private System.Windows.Forms.CheckBox check70;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSearch;
    }
}


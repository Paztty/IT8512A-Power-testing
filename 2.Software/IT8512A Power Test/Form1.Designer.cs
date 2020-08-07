namespace IT8512A_Power_Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelResultB = new System.Windows.Forms.Label();
            this.labelResultA = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelGetVolB = new System.Windows.Forms.Label();
            this.labelGetVolA = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelVoltageB = new System.Windows.Forms.Label();
            this.labelVoltageA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelfinalTestResult = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chartDailyResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rawResponse = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSerialConnect = new System.Windows.Forms.Button();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxEndBit = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxDatabit = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonRefesh = new System.Windows.Forms.Button();
            this.Port = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusDataRecive = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPortStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxProductCode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDailyResult)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1048, 426);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.labelResultB, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelResultA, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelGetVolB, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelGetVolA, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelVoltageB, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelVoltageA, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelfinalTestResult, 0, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(727, 420);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // labelResultB
            // 
            this.labelResultB.AutoSize = true;
            this.labelResultB.BackColor = System.Drawing.Color.Blue;
            this.labelResultB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResultB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResultB.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultB.ForeColor = System.Drawing.Color.Red;
            this.labelResultB.Location = new System.Drawing.Point(438, 126);
            this.labelResultB.Name = "labelResultB";
            this.labelResultB.Size = new System.Drawing.Size(286, 84);
            this.labelResultB.TabIndex = 11;
            this.labelResultB.Text = "NG";
            this.labelResultB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResultA
            // 
            this.labelResultA.AutoSize = true;
            this.labelResultA.BackColor = System.Drawing.Color.DarkViolet;
            this.labelResultA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResultA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResultA.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultA.ForeColor = System.Drawing.Color.Lime;
            this.labelResultA.Location = new System.Drawing.Point(148, 126);
            this.labelResultA.Name = "labelResultA";
            this.labelResultA.Size = new System.Drawing.Size(284, 84);
            this.labelResultA.TabIndex = 10;
            this.labelResultA.Text = "OK";
            this.labelResultA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 84);
            this.label11.TabIndex = 9;
            this.label11.Text = "RESULT";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGetVolB
            // 
            this.labelGetVolB.AutoSize = true;
            this.labelGetVolB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGetVolB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGetVolB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetVolB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelGetVolB.Location = new System.Drawing.Point(438, 84);
            this.labelGetVolB.Name = "labelGetVolB";
            this.labelGetVolB.Size = new System.Drawing.Size(286, 42);
            this.labelGetVolB.TabIndex = 8;
            this.labelGetVolB.Text = "GET";
            this.labelGetVolB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGetVolA
            // 
            this.labelGetVolA.AutoSize = true;
            this.labelGetVolA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGetVolA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGetVolA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetVolA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelGetVolA.Location = new System.Drawing.Point(148, 84);
            this.labelGetVolA.Name = "labelGetVolA";
            this.labelGetVolA.Size = new System.Drawing.Size(284, 42);
            this.labelGetVolA.TabIndex = 7;
            this.labelGetVolA.Text = "GET";
            this.labelGetVolA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(3, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 42);
            this.label8.TabIndex = 6;
            this.label8.Text = "GET";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVoltageB
            // 
            this.labelVoltageB.AutoSize = true;
            this.labelVoltageB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVoltageB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVoltageB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoltageB.ForeColor = System.Drawing.Color.Green;
            this.labelVoltageB.Location = new System.Drawing.Point(438, 42);
            this.labelVoltageB.Name = "labelVoltageB";
            this.labelVoltageB.Size = new System.Drawing.Size(286, 42);
            this.labelVoltageB.TabIndex = 5;
            this.labelVoltageB.Text = "SLOT";
            this.labelVoltageB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVoltageA
            // 
            this.labelVoltageA.AutoSize = true;
            this.labelVoltageA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVoltageA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVoltageA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoltageA.ForeColor = System.Drawing.Color.Green;
            this.labelVoltageA.Location = new System.Drawing.Point(148, 42);
            this.labelVoltageA.Name = "labelVoltageA";
            this.labelVoltageA.Size = new System.Drawing.Size(284, 42);
            this.labelVoltageA.TabIndex = 4;
            this.labelVoltageA.Text = "SLOT";
            this.labelVoltageA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "SET";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "A";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "SLOT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "B";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelfinalTestResult
            // 
            this.labelfinalTestResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel3.SetColumnSpan(this.labelfinalTestResult, 3);
            this.labelfinalTestResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelfinalTestResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfinalTestResult.Location = new System.Drawing.Point(3, 210);
            this.labelfinalTestResult.Name = "labelfinalTestResult";
            this.labelfinalTestResult.Size = new System.Drawing.Size(721, 210);
            this.labelfinalTestResult.TabIndex = 12;
            this.labelfinalTestResult.Text = "OK";
            this.labelfinalTestResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.chartDailyResult, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rawResponse, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(736, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(309, 420);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImage = global::IT8512A_Power_Test.Properties.Resources.IT8512A;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 154);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chartDailyResult
            // 
            this.chartDailyResult.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chartDailyResult.ChartAreas.Add(chartArea1);
            this.chartDailyResult.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDailyResult.Legends.Add(legend1);
            this.chartDailyResult.Location = new System.Drawing.Point(3, 3);
            this.chartDailyResult.Name = "chartDailyResult";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDailyResult.Series.Add(series1);
            this.chartDailyResult.Size = new System.Drawing.Size(303, 234);
            this.chartDailyResult.TabIndex = 1;
            this.chartDailyResult.Text = "chart1";
            // 
            // rawResponse
            // 
            this.rawResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rawResponse.Location = new System.Drawing.Point(3, 403);
            this.rawResponse.Name = "rawResponse";
            this.rawResponse.Size = new System.Drawing.Size(303, 20);
            this.rawResponse.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.87449F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.30055F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.39344F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.786885F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 386F));
            this.tableLayoutPanel2.Controls.Add(this.buttonSerialConnect, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxComPort, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label16, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label15, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label14, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label13, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxEndBit, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxParity, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxDatabit, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxBaudrate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonRefesh, 5, 0);
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 484);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1048, 51);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // buttonSerialConnect
            // 
            this.buttonSerialConnect.BackColor = System.Drawing.Color.Lime;
            this.buttonSerialConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSerialConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSerialConnect.ForeColor = System.Drawing.Color.Red;
            this.buttonSerialConnect.Location = new System.Drawing.Point(663, 3);
            this.buttonSerialConnect.Name = "buttonSerialConnect";
            this.tableLayoutPanel2.SetRowSpan(this.buttonSerialConnect, 2);
            this.buttonSerialConnect.Size = new System.Drawing.Size(382, 45);
            this.buttonSerialConnect.TabIndex = 13;
            this.buttonSerialConnect.Text = "CONNECT";
            this.buttonSerialConnect.UseVisualStyleBackColor = false;
            this.buttonSerialConnect.Click += new System.EventHandler(this.buttonSerialConnect_Click_1);
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(3, 28);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(126, 21);
            this.comboBoxComPort.TabIndex = 11;
            this.comboBoxComPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxComPort_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(504, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 25);
            this.label16.TabIndex = 10;
            this.label16.Text = "END BIT";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(403, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "PARITY";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(293, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "DATABIT";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(135, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = "BAUDRATE";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxEndBit
            // 
            this.comboBoxEndBit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxEndBit.FormattingEnabled = true;
            this.comboBoxEndBit.Location = new System.Drawing.Point(504, 28);
            this.comboBoxEndBit.Name = "comboBoxEndBit";
            this.comboBoxEndBit.Size = new System.Drawing.Size(102, 21);
            this.comboBoxEndBit.TabIndex = 4;
            this.comboBoxEndBit.SelectedIndexChanged += new System.EventHandler(this.comboBoxEndBit_SelectedIndexChanged);
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(403, 28);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(95, 21);
            this.comboBoxParity.TabIndex = 3;
            this.comboBoxParity.SelectedIndexChanged += new System.EventHandler(this.comboBoxParity_SelectedIndexChanged);
            // 
            // comboBoxDatabit
            // 
            this.comboBoxDatabit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxDatabit.FormattingEnabled = true;
            this.comboBoxDatabit.Location = new System.Drawing.Point(293, 28);
            this.comboBoxDatabit.Name = "comboBoxDatabit";
            this.comboBoxDatabit.Size = new System.Drawing.Size(104, 21);
            this.comboBoxDatabit.TabIndex = 2;
            this.comboBoxDatabit.SelectedIndexChanged += new System.EventHandler(this.comboBoxDatabit_SelectedIndexChanged);
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Location = new System.Drawing.Point(135, 28);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(152, 21);
            this.comboBoxBaudrate.TabIndex = 1;
            this.comboBoxBaudrate.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaudrate_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "COM PORT";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRefesh
            // 
            this.buttonRefesh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefesh.BackgroundImage = global::IT8512A_Power_Test.Properties.Resources.refesh_icon;
            this.buttonRefesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRefesh.Location = new System.Drawing.Point(612, 3);
            this.buttonRefesh.Name = "buttonRefesh";
            this.tableLayoutPanel2.SetRowSpan(this.buttonRefesh, 2);
            this.buttonRefesh.Size = new System.Drawing.Size(45, 45);
            this.buttonRefesh.TabIndex = 12;
            this.buttonRefesh.UseVisualStyleBackColor = false;
            this.buttonRefesh.Click += new System.EventHandler(this.buttonRefesh_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusConnect,
            this.toolStripStatusLabel2,
            this.toolStripStatusDataRecive,
            this.serialPortStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1072, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusConnect
            // 
            this.toolStripStatusConnect.Name = "toolStripStatusConnect";
            this.toolStripStatusConnect.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusConnect.Text = "ITA8512A status";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel2.Text = "Data Recive: ";
            // 
            // toolStripStatusDataRecive
            // 
            this.toolStripStatusDataRecive.Name = "toolStripStatusDataRecive";
            this.toolStripStatusDataRecive.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusDataRecive.Text = "...";
            // 
            // serialPortStatus
            // 
            this.serialPortStatus.BackColor = System.Drawing.Color.Red;
            this.serialPortStatus.Name = "serialPortStatus";
            this.serialPortStatus.Size = new System.Drawing.Size(13, 17);
            this.serialPortStatus.Text = "  ";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.tableLayoutPanel5.Controls.Add(this.comboBoxProductCode, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonSetting, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1072, 52);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // comboBoxProductCode
            // 
            this.comboBoxProductCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProductCode.FormattingEnabled = true;
            this.comboBoxProductCode.Location = new System.Drawing.Point(355, 3);
            this.comboBoxProductCode.Name = "comboBoxProductCode";
            this.comboBoxProductCode.Size = new System.Drawing.Size(346, 39);
            this.comboBoxProductCode.TabIndex = 0;
            this.comboBoxProductCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductCode_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 52);
            this.label6.TabIndex = 1;
            this.label6.Text = "Model";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSetting
            // 
            this.buttonSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetting.Location = new System.Drawing.Point(987, 19);
            this.buttonSetting.Margin = new System.Windows.Forms.Padding(3, 3, 10, 10);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(75, 23);
            this.buttonSetting.TabIndex = 2;
            this.buttonSetting.Text = "Setting";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 565);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IT8512A Power Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDailyResult)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDailyResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxEndBit;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxDatabit;
        private System.Windows.Forms.ComboBox comboBoxBaudrate;
        private System.Windows.Forms.Label label12;
        private System.IO.Ports.SerialPort Port;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusConnect;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label labelVoltageA;
        public System.Windows.Forms.Label labelGetVolB;
        public System.Windows.Forms.Label labelVoltageB;
        public System.Windows.Forms.Label labelResultB;
        public System.Windows.Forms.Label labelResultA;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Label labelfinalTestResult;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDataRecive;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel serialPortStatus;
        private System.Windows.Forms.Button buttonSerialConnect;
        private System.Windows.Forms.Button buttonRefesh;
        private System.Windows.Forms.Label labelGetVolA;
        private System.Windows.Forms.TextBox rawResponse;
        public System.Windows.Forms.ComboBox comboBoxProductCode;
    }
}


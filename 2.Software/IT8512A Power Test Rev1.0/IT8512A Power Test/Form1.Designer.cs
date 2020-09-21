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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.rawResponse = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbDailyTotal = new System.Windows.Forms.Label();
            this.lbDailyNG = new System.Windows.Forms.Label();
            this.lbDailyOK = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelStatisticsTotal = new System.Windows.Forms.Label();
            this.labelStatisticNG = new System.Windows.Forms.Label();
            this.labelStatisticOK = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.Port = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxProductCode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutIT8512APowerTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbBigResult = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPortStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPerLB = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.67459F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.32541F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1326, 573);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rawResponse, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox1, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(979, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.06749F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.93251F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(344, 567);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(338, 242);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // rawResponse
            // 
            this.rawResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rawResponse.Location = new System.Drawing.Point(3, 545);
            this.rawResponse.Name = "rawResponse";
            this.rawResponse.ReadOnly = true;
            this.rawResponse.Size = new System.Drawing.Size(338, 20);
            this.rawResponse.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.24852F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.75148F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 251);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(338, 69);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel7.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lbDailyTotal, 3, 2);
            this.tableLayoutPanel7.Controls.Add(this.lbDailyNG, 2, 2);
            this.tableLayoutPanel7.Controls.Add(this.lbDailyOK, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label9, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.labelStatisticsTotal, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.labelStatisticNG, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.labelStatisticOK, 1, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(330, 61);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Lime;
            this.label20.Location = new System.Drawing.Point(3, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 21);
            this.label20.TabIndex = 10;
            this.label20.Text = "Daily Total";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Lime;
            this.label19.Location = new System.Drawing.Point(3, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 20);
            this.label19.TabIndex = 9;
            this.label19.Text = "Testing";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDailyTotal
            // 
            this.lbDailyTotal.AutoSize = true;
            this.lbDailyTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDailyTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDailyTotal.ForeColor = System.Drawing.Color.Blue;
            this.lbDailyTotal.Location = new System.Drawing.Point(263, 40);
            this.lbDailyTotal.Name = "lbDailyTotal";
            this.lbDailyTotal.Size = new System.Drawing.Size(64, 21);
            this.lbDailyTotal.TabIndex = 8;
            this.lbDailyTotal.Text = "0";
            this.lbDailyTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDailyNG
            // 
            this.lbDailyNG.AutoSize = true;
            this.lbDailyNG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDailyNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDailyNG.ForeColor = System.Drawing.Color.Red;
            this.lbDailyNG.Location = new System.Drawing.Point(197, 40);
            this.lbDailyNG.Name = "lbDailyNG";
            this.lbDailyNG.Size = new System.Drawing.Size(60, 21);
            this.lbDailyNG.TabIndex = 7;
            this.lbDailyNG.Text = "0";
            this.lbDailyNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDailyOK
            // 
            this.lbDailyOK.AutoSize = true;
            this.lbDailyOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDailyOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDailyOK.ForeColor = System.Drawing.Color.Lime;
            this.lbDailyOK.Location = new System.Drawing.Point(125, 40);
            this.lbDailyOK.Name = "lbDailyOK";
            this.lbDailyOK.Size = new System.Drawing.Size(66, 21);
            this.lbDailyOK.TabIndex = 6;
            this.lbDailyOK.Text = "0";
            this.lbDailyOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(125, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "OK";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(263, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(197, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "NG";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatisticsTotal
            // 
            this.labelStatisticsTotal.AutoSize = true;
            this.labelStatisticsTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatisticsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatisticsTotal.ForeColor = System.Drawing.Color.Blue;
            this.labelStatisticsTotal.Location = new System.Drawing.Point(263, 20);
            this.labelStatisticsTotal.Name = "labelStatisticsTotal";
            this.labelStatisticsTotal.Size = new System.Drawing.Size(64, 20);
            this.labelStatisticsTotal.TabIndex = 5;
            this.labelStatisticsTotal.Text = "0";
            this.labelStatisticsTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatisticNG
            // 
            this.labelStatisticNG.AutoSize = true;
            this.labelStatisticNG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatisticNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatisticNG.ForeColor = System.Drawing.Color.Red;
            this.labelStatisticNG.Location = new System.Drawing.Point(197, 20);
            this.labelStatisticNG.Name = "labelStatisticNG";
            this.labelStatisticNG.Size = new System.Drawing.Size(60, 20);
            this.labelStatisticNG.TabIndex = 4;
            this.labelStatisticNG.Text = "0";
            this.labelStatisticNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatisticOK
            // 
            this.labelStatisticOK.AutoSize = true;
            this.labelStatisticOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatisticOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatisticOK.ForeColor = System.Drawing.Color.Lime;
            this.labelStatisticOK.Location = new System.Drawing.Point(125, 20);
            this.labelStatisticOK.Name = "labelStatisticOK";
            this.labelStatisticOK.Size = new System.Drawing.Size(66, 20);
            this.labelStatisticOK.TabIndex = 3;
            this.labelStatisticOK.Text = "0";
            this.labelStatisticOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = global::IT8512A_Power_Test.Properties.Resources.DJ96_00222;
            this.pictureBox1.Location = new System.Drawing.Point(3, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.91812F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.01971F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.06217F));
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
            this.tableLayoutPanel3.Controls.Add(this.labelfinalTestResult, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(970, 567);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // labelResultB
            // 
            this.labelResultB.AutoSize = true;
            this.labelResultB.BackColor = System.Drawing.Color.Blue;
            this.labelResultB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResultB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultB.ForeColor = System.Drawing.Color.Red;
            this.labelResultB.Location = new System.Drawing.Point(563, 173);
            this.labelResultB.Margin = new System.Windows.Forms.Padding(3);
            this.labelResultB.Name = "labelResultB";
            this.labelResultB.Size = new System.Drawing.Size(399, 49);
            this.labelResultB.TabIndex = 11;
            this.labelResultB.Text = "NG";
            this.labelResultB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResultA
            // 
            this.labelResultA.AutoSize = true;
            this.labelResultA.BackColor = System.Drawing.Color.Aquamarine;
            this.labelResultA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResultA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultA.ForeColor = System.Drawing.Color.Blue;
            this.labelResultA.Location = new System.Drawing.Point(151, 173);
            this.labelResultA.Margin = new System.Windows.Forms.Padding(3);
            this.labelResultA.Name = "labelResultA";
            this.labelResultA.Size = new System.Drawing.Size(406, 49);
            this.labelResultA.TabIndex = 10;
            this.labelResultA.Text = "OK";
            this.labelResultA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 173);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.tableLayoutPanel3.SetRowSpan(this.label11, 2);
            this.label11.Size = new System.Drawing.Size(137, 386);
            this.label11.TabIndex = 9;
            this.label11.Text = "RESULT";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGetVolB
            // 
            this.labelGetVolB.AutoSize = true;
            this.labelGetVolB.BackColor = System.Drawing.Color.White;
            this.labelGetVolB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGetVolB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetVolB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelGetVolB.Location = new System.Drawing.Point(563, 118);
            this.labelGetVolB.Margin = new System.Windows.Forms.Padding(3);
            this.labelGetVolB.Name = "labelGetVolB";
            this.labelGetVolB.Size = new System.Drawing.Size(399, 49);
            this.labelGetVolB.TabIndex = 8;
            this.labelGetVolB.Text = "GET";
            this.labelGetVolB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGetVolA
            // 
            this.labelGetVolA.AutoSize = true;
            this.labelGetVolA.BackColor = System.Drawing.Color.White;
            this.labelGetVolA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGetVolA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetVolA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelGetVolA.Location = new System.Drawing.Point(151, 118);
            this.labelGetVolA.Margin = new System.Windows.Forms.Padding(3);
            this.labelGetVolA.Name = "labelGetVolA";
            this.labelGetVolA.Size = new System.Drawing.Size(406, 49);
            this.labelGetVolA.TabIndex = 7;
            this.labelGetVolA.Text = "GET";
            this.labelGetVolA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(8, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 49);
            this.label8.TabIndex = 6;
            this.label8.Text = "READ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVoltageB
            // 
            this.labelVoltageB.AutoSize = true;
            this.labelVoltageB.BackColor = System.Drawing.Color.White;
            this.labelVoltageB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVoltageB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoltageB.ForeColor = System.Drawing.Color.Green;
            this.labelVoltageB.Location = new System.Drawing.Point(563, 63);
            this.labelVoltageB.Margin = new System.Windows.Forms.Padding(3);
            this.labelVoltageB.Name = "labelVoltageB";
            this.labelVoltageB.Size = new System.Drawing.Size(399, 49);
            this.labelVoltageB.TabIndex = 5;
            this.labelVoltageB.Text = "SLOT";
            this.labelVoltageB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVoltageA
            // 
            this.labelVoltageA.AutoSize = true;
            this.labelVoltageA.BackColor = System.Drawing.Color.White;
            this.labelVoltageA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVoltageA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoltageA.ForeColor = System.Drawing.Color.Green;
            this.labelVoltageA.Location = new System.Drawing.Point(151, 63);
            this.labelVoltageA.Margin = new System.Windows.Forms.Padding(3);
            this.labelVoltageA.Name = "labelVoltageA";
            this.labelVoltageA.Size = new System.Drawing.Size(406, 49);
            this.labelVoltageA.TabIndex = 4;
            this.labelVoltageA.Text = "SLOT";
            this.labelVoltageA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(8, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 49);
            this.label4.TabIndex = 3;
            this.label4.Text = "SPEC";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "A";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "SLOT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "B";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelfinalTestResult
            // 
            this.labelfinalTestResult.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.SetColumnSpan(this.labelfinalTestResult, 2);
            this.labelfinalTestResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelfinalTestResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfinalTestResult.Location = new System.Drawing.Point(151, 228);
            this.labelfinalTestResult.Margin = new System.Windows.Forms.Padding(3);
            this.labelfinalTestResult.Name = "labelfinalTestResult";
            this.labelfinalTestResult.Size = new System.Drawing.Size(811, 331);
            this.labelfinalTestResult.TabIndex = 12;
            this.labelfinalTestResult.Text = "OK";
            this.labelfinalTestResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.02659F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.02659F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.153328F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.718787F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.0481F));
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
            this.tableLayoutPanel2.Controls.Add(this.button1, 7, 0);
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 651);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1326, 48);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // buttonSerialConnect
            // 
            this.buttonSerialConnect.BackColor = System.Drawing.Color.Lime;
            this.buttonSerialConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSerialConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSerialConnect.ForeColor = System.Drawing.Color.Red;
            this.buttonSerialConnect.Location = new System.Drawing.Point(892, 3);
            this.buttonSerialConnect.Name = "buttonSerialConnect";
            this.tableLayoutPanel2.SetRowSpan(this.buttonSerialConnect, 2);
            this.buttonSerialConnect.Size = new System.Drawing.Size(112, 42);
            this.buttonSerialConnect.TabIndex = 13;
            this.buttonSerialConnect.Text = "OPEN";
            this.buttonSerialConnect.UseVisualStyleBackColor = false;
            this.buttonSerialConnect.Click += new System.EventHandler(this.buttonSerialConnect_Click);
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(3, 25);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(238, 21);
            this.comboBoxComPort.TabIndex = 11;
            this.comboBoxComPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxComPort_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(735, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 22);
            this.label16.TabIndex = 10;
            this.label16.Text = "END BIT";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(613, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 22);
            this.label15.TabIndex = 9;
            this.label15.Text = "PARITY";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(491, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 22);
            this.label14.TabIndex = 8;
            this.label14.Text = "DATABIT";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(247, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(238, 22);
            this.label13.TabIndex = 7;
            this.label13.Text = "BAUDRATE";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxEndBit
            // 
            this.comboBoxEndBit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxEndBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEndBit.FormattingEnabled = true;
            this.comboBoxEndBit.Location = new System.Drawing.Point(735, 25);
            this.comboBoxEndBit.Name = "comboBoxEndBit";
            this.comboBoxEndBit.Size = new System.Drawing.Size(101, 21);
            this.comboBoxEndBit.TabIndex = 4;
            this.comboBoxEndBit.SelectedIndexChanged += new System.EventHandler(this.comboBoxEndBit_SelectedIndexChanged);
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(613, 25);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(116, 21);
            this.comboBoxParity.TabIndex = 3;
            this.comboBoxParity.SelectedIndexChanged += new System.EventHandler(this.comboBoxParity_SelectedIndexChanged);
            // 
            // comboBoxDatabit
            // 
            this.comboBoxDatabit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxDatabit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDatabit.FormattingEnabled = true;
            this.comboBoxDatabit.Location = new System.Drawing.Point(491, 25);
            this.comboBoxDatabit.Name = "comboBoxDatabit";
            this.comboBoxDatabit.Size = new System.Drawing.Size(116, 21);
            this.comboBoxDatabit.TabIndex = 2;
            this.comboBoxDatabit.SelectedIndexChanged += new System.EventHandler(this.comboBoxDatabit_SelectedIndexChanged);
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Location = new System.Drawing.Point(247, 25);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(238, 21);
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
            this.label12.Size = new System.Drawing.Size(238, 22);
            this.label12.TabIndex = 6;
            this.label12.Text = "COM PORT";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRefesh
            // 
            this.buttonRefesh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRefesh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefesh.BackgroundImage = global::IT8512A_Power_Test.Properties.Resources.refesh_icon;
            this.buttonRefesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefesh.Location = new System.Drawing.Point(842, 3);
            this.buttonRefesh.Name = "buttonRefesh";
            this.tableLayoutPanel2.SetRowSpan(this.buttonRefesh, 2);
            this.buttonRefesh.Size = new System.Drawing.Size(44, 42);
            this.buttonRefesh.TabIndex = 12;
            this.buttonRefesh.UseVisualStyleBackColor = false;
            this.buttonRefesh.Click += new System.EventHandler(this.buttonRefesh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(1010, 3);
            this.button1.Name = "button1";
            this.tableLayoutPanel2.SetRowSpan(this.button1, 2);
            this.button1.Size = new System.Drawing.Size(313, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "CONNECT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.Controls.Add(this.comboBoxProductCode, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1350, 49);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // comboBoxProductCode
            // 
            this.comboBoxProductCode.AllowDrop = true;
            this.comboBoxProductCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxProductCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProductCode.FormattingEnabled = true;
            this.comboBoxProductCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxProductCode.Location = new System.Drawing.Point(674, 3);
            this.comboBoxProductCode.Name = "comboBoxProductCode";
            this.comboBoxProductCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxProductCode.Size = new System.Drawing.Size(665, 39);
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
            this.label6.Size = new System.Drawing.Size(665, 49);
            this.label6.TabIndex = 1;
            this.label6.Text = "Model";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSettingToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadSettingToolStripMenuItem
            // 
            this.loadSettingToolStripMenuItem.Name = "loadSettingToolStripMenuItem";
            this.loadSettingToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.loadSettingToolStripMenuItem.Text = "Report managerment";
            this.loadSettingToolStripMenuItem.Click += new System.EventHandler(this.loadSettingToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPToolStripMenuItem,
            this.teToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.loginToolStripMenuItem.Text = "User";
            this.loginToolStripMenuItem.DropDownClosed += new System.EventHandler(this.loginToolStripMenuItem_DropDownClosed);
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // oPToolStripMenuItem
            // 
            this.oPToolStripMenuItem.Name = "oPToolStripMenuItem";
            this.oPToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.oPToolStripMenuItem.Text = "OP (default)";
            this.oPToolStripMenuItem.Click += new System.EventHandler(this.oPToolStripMenuItem_Click);
            // 
            // teToolStripMenuItem
            // 
            this.teToolStripMenuItem.Name = "teToolStripMenuItem";
            this.teToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.teToolStripMenuItem.Text = "Technical";
            this.teToolStripMenuItem.Click += new System.EventHandler(this.teToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelSettingToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // modelSettingToolStripMenuItem
            // 
            this.modelSettingToolStripMenuItem.Name = "modelSettingToolStripMenuItem";
            this.modelSettingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modelSettingToolStripMenuItem.Text = "Model setting";
            this.modelSettingToolStripMenuItem.Click += new System.EventHandler(this.modelSettingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutIT8512APowerTestToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutIT8512APowerTestToolStripMenuItem
            // 
            this.aboutIT8512APowerTestToolStripMenuItem.Name = "aboutIT8512APowerTestToolStripMenuItem";
            this.aboutIT8512APowerTestToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.aboutIT8512APowerTestToolStripMenuItem.Text = "About IT8512A Power Test";
            // 
            // lbBigResult
            // 
            this.lbBigResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBigResult.BackColor = System.Drawing.Color.Silver;
            this.lbBigResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBigResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbBigResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 300F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBigResult.Location = new System.Drawing.Point(74, 78);
            this.lbBigResult.Name = "lbBigResult";
            this.lbBigResult.Size = new System.Drawing.Size(1202, 484);
            this.lbBigResult.TabIndex = 6;
            this.lbBigResult.Text = "OK";
            this.lbBigResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbBigResult.DoubleClick += new System.EventHandler(this.lbBigResult_DoubleClick);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusConnect,
            this.toolStripStatusLabel3,
            this.serialPortStatus,
            this.tsPerLB});
            this.statusStrip2.Location = new System.Drawing.Point(0, 707);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1350, 22);
            this.statusStrip2.TabIndex = 7;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusConnect
            // 
            this.toolStripStatusConnect.Name = "toolStripStatusConnect";
            this.toolStripStatusConnect.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusConnect.Text = "ITA8512A status";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel3.Text = "...";
            // 
            // serialPortStatus
            // 
            this.serialPortStatus.BackColor = System.Drawing.Color.Red;
            this.serialPortStatus.Name = "serialPortStatus";
            this.serialPortStatus.Size = new System.Drawing.Size(13, 17);
            this.serialPortStatus.Text = "  ";
            // 
            // tsPerLB
            // 
            this.tsPerLB.Name = "tsPerLB";
            this.tsPerLB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsPerLB.Size = new System.Drawing.Size(0, 17);
            this.tsPerLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.lbBigResult);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "IT8512A Power Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label labelVoltageA;
        public System.Windows.Forms.Label labelGetVolB;
        public System.Windows.Forms.Label labelVoltageB;
        public System.Windows.Forms.Label labelResultB;
        public System.Windows.Forms.Label labelResultA;
        private System.Windows.Forms.Label labelfinalTestResult;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonSerialConnect;
        private System.Windows.Forms.Button buttonRefesh;
        private System.Windows.Forms.Label labelGetVolA;
        public System.Windows.Forms.ComboBox comboBoxProductCode;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox rawResponse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label labelStatisticsTotal;
        private System.Windows.Forms.Label labelStatisticNG;
        private System.Windows.Forms.Label labelStatisticOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutIT8512APowerTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSettingToolStripMenuItem;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbDailyTotal;
        private System.Windows.Forms.Label lbDailyNG;
        private System.Windows.Forms.Label lbDailyOK;
        private System.Windows.Forms.Label lbBigResult;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusConnect;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel serialPortStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsPerLB;
    }
}


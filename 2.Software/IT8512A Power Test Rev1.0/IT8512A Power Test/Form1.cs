using System;
using System.Drawing;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.IO.Ports;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;

namespace IT8512A_Power_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Port.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            
        }

        // Form load funtion
        public bool ComponentInitted = false;
        public void Form1_Load(object sender, EventArgs e)
        {
            if (ComponentInitted == false)
            {
                ComponentInitted = true;
            }
            hidelbBigResult();
            Serial_UI_init();
            ProductindomationInit();
            DrawChart(0, 0);

            checkPermission();
        }
        // End Form load function

        // Serial code
        public string[] BaudRate = { "300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "74880", "115200", "230400", "250000", "500000", "1000000", "2000000" };
        public byte[] Data_size = { 7, 8 };
        public String[] parity_bit = { "none", "even", "odd", "mark", "space" };
        public String[] end_bit = { "none", "1", "1.5", "2" };

        //private volatile Int32[] FrameResponse = new Int32[10];


        delegate void SetTextCallback(String text);

        // check var
        public static double VolA_H, VolA_L, VolB_H, VolB_L;
        public string _result_A, _result_B;
        public static bool form2Close;
        public string chanel = "chanelA";

        public static int Statistics_OK = 0, Statistics_NG = 0;
        public static int Statistics_DailyOK = 0, Statistics_DailyNG = 0, DailyTotal = 0;
        public bool chanelAcherked, chanelBcherked, waitResponse = false, retryTest = false;
        public uint retryTestCounter = 0;

        public string pass;
        public static string Permission = "OP";

        // end check var

        // product code
        public static productCode[] productsList =
                {
                //new productCode("Test Soft 1", 30, 10, 30, 10,1),
                //new productCode("Test Soft 2", 30, 10, 30, 10,2),
                new productCode("DJ96-00216", 37.6,37.4,37.6,37.4,1),
                new productCode("DJ96-00204", 24.95, 24.8, 24.95, 24.8,1),
                new productCode("DJ96-00210", 20.8, 20.6, 20.8, 20.6,1),
                new productCode("DJ96-00222", 25.95, 25.75, 25.95, 25.75,2),
                new productCode("DJ96-00229B",25.95,25.75,25.95,25.75,2),
                new productCode("DJ96-00229C",25.95,25.75,25.95,25.75,2),
                new productCode("DJ96-00229D",25.95,25.75,25.95,25.75,2),
                new productCode("DJ96-00229E",25.95,25.75,25.95,25.75,2),
                new productCode("DJ96-00229F",25.95,25.75,25.95,25.75,2),
                new productCode("DJ96-00229G",25.95,25.75,25.95,25.75,2),
                new productCode("DJ96-00229H",25.95,25.75,25.95,25.75,2),
                new productCode("DJ96-00229J",25.95,25.75,25.95,25.75,2),
                new productCode("DJ96-00229K",25.95,25.75,25.95,25.75,2),
                new productCode("DJ96-00229P",25.95,25.75,25.95,25.75,2),
                new productCode("DJ96-00229Q",25.95,25.75,25.95,25.75,2),
                new productCode("DJ96-00229L",25.95,25.75,25.95,25.75,2),
                new productCode("DJ96-00229N",25.95,25.75,25.95,25.75,2),

                    };

        public void ProductindomationInit()
        {
            string[] productNameList = new string[productsList.Length];
            for (int i = 0; i < productsList.Length; i++)
            {
                productNameList[i] = productsList[i].name;
            }
            comboBoxProductCode.DataSource = productNameList;
            comboBoxProductCode.SelectedIndex = 0;
            VolA_H = productsList[comboBoxProductCode.SelectedIndex].AVoltageHighLevel;
            VolB_H = productsList[comboBoxProductCode.SelectedIndex].BVoltageHighLevel;
            VolA_L = productsList[comboBoxProductCode.SelectedIndex].AVoltageLowLevel;
            VolB_L = productsList[comboBoxProductCode.SelectedIndex].BVoltageLowLevel;
            labelVoltageA.Text = VolA_L.ToString("F2") + " V  ~  " + VolA_H.ToString("F2") + " V";
            labelVoltageB.Text = VolB_L.ToString("F2") + " V  ~  " + VolB_H.ToString("F2") + " V";
            setLabelB_Empty();
            setLabelA_Empty();
            setLabelfinalTestResult_Empty();
        }

        // end product code

        public void Serial_UI_init()
        {
            comboBoxComPort.DataSource = SerialPort.GetPortNames();
            comboBoxBaudrate.DataSource = BaudRate;
            comboBoxDatabit.DataSource = Data_size;
            comboBoxParity.DataSource = parity_bit;
            comboBoxEndBit.DataSource = end_bit;

            comboBoxBaudrate.SelectedIndex = 9;
            comboBoxDatabit.SelectedIndex = 1;
            comboBoxEndBit.SelectedIndex = 1;
            comboBoxParity.SelectedIndex = 0;

            //Port.PortName = comboBoxComPort.Text;
            Port.Parity = Parity.None;
            Port.StopBits = StopBits.One;
            Port.BaudRate = Convert.ToInt32(comboBoxBaudrate.Text);

        }
        // Sellect com port
        private void comboBoxComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Port.PortName = comboBoxComPort.Text;
            }
            catch { }

        }
        //Sellect baudrate
        private void comboBoxBaudrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Port.BaudRate = Convert.ToInt32(comboBoxBaudrate.Text);
        }

        // Sellect parity
        private void comboBoxParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxParity.Text)
            {
                case "none":
                    {
                        Port.Parity = Parity.None;
                        break;
                    }
                case "even":
                    {
                        Port.Parity = Parity.Even;
                        break;
                    }
                case "odd":
                    {
                        Port.Parity = Parity.Odd;
                        break;
                    }
                case "mark":
                    {
                        Port.Parity = Parity.Mark;
                        break;
                    }
                case "space":
                    {
                        Port.Parity = Parity.Space;
                        break;
                    }
            }
        }
        // Sellect data size
        private void comboBoxDatabit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Port.DataBits = Convert.ToInt32(comboBoxDatabit.Text);
        }


        // connect/disconnect port
        private void buttonSerialConnect_Click(object sender, EventArgs e)
        {
            if (Port.IsOpen)
            {
                Port.DiscardInBuffer();
                Port.Close();
                if (!Port.IsOpen)
                    buttonSerialConnect.Text = "OPEN";
            }
            else
            {
                try
                {
                    Port.Open();
                    if (Port.IsOpen)
                        buttonSerialConnect.Text = "CLOSE";
                    timer1.Start();
                }
                catch (Exception)
                {
                    MessageBox.Show("Another program is using this port !");
                }

            }

        }
        private void comboBoxEndBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxEndBit.Text)
            {
                case "1":
                    {
                        Port.StopBits = StopBits.One;
                        break;
                    }
                case "1.5":
                    {
                        Port.StopBits = StopBits.OnePointFive;
                        break;
                    }
                case "2":
                    {
                        Port.StopBits = StopBits.Two;
                        break;
                    }
                case "none":
                    {
                        Port.StopBits = StopBits.Two;
                        break;
                    }
            }
        }

        private void buttonRefesh_Click(object sender, EventArgs e)
        {
            comboBoxComPort.DataSource = SerialPort.GetPortNames();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Dispose();
            timer1.Interval = 1000;
            timer1.Start();
            DrawChart(Statistics_OK, Statistics_NG);
            VolA_H = productsList[comboBoxProductCode.SelectedIndex].AVoltageHighLevel;
            VolB_H = productsList[comboBoxProductCode.SelectedIndex].BVoltageHighLevel;
            VolA_L = productsList[comboBoxProductCode.SelectedIndex].AVoltageLowLevel;
            VolB_L = productsList[comboBoxProductCode.SelectedIndex].BVoltageLowLevel;

        }

        // Reciver data
        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            if (!Port.IsOpen) return;
            string Frame = " ";
            Frame = Port.ReadLine();
            SetText(Frame);
        }

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.rawResponse.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                //rawResponse.Text = text;
                FrameProcessing(text);
            }
        }
        // End Serial code

        // check value
        private void checkValue(double volIn, int chanel)
        {
            if (chanel == 1)
            {
                label2.BackColor = Color.DarkGray;
                label3.BackColor = Color.White;

                labelGetVolA.Text = volIn.ToString() + " V";
                if (VolA_L <= volIn && volIn <= VolA_H)
                {
                    setLabelA_OK();
                    _result_A = "OK";
                    if (retryCounter >= 2)
                        retryCounter = retryLoop + 1;
                    else
                        retryCounter++;
                }

                else if (volIn == 0)
                {
                    setLabelA_Empty();
                    _result_A = "Empty";
                    retryCounter++;
                }
                else if (volIn > 0)
                {
                    setLabelA_NG();
                    _result_A = "NG";
                    retryCounter++;
                }
            }

            if (chanel == 2)
            {
                label3.BackColor = Color.DarkGray;
                label2.BackColor = Color.White;

                labelGetVolB.Text = volIn.ToString() + " V";
                if (VolB_L <= volIn && volIn <= VolB_H)
                {
                    setLabelB_OK();
                    _result_B = "OK";
                    if (retryCounter >= retryLoop + 3)
                        retryCounter = retryLoop * 2 + 1;
                    else
                        retryCounter++;
                }
                else if (volIn == 0)
                {
                    setLabelB_Empty();
                    _result_B = "Empty";
                    retryCounter++;
                }
                else if (volIn > 0)
                {
                    setLabelB_NG();
                    _result_B = "NG";
                    retryCounter++;
                }
            }

            if (testDone == true)
            {
                label2.BackColor = Color.White;
                label3.BackColor = Color.White;
                if (productsList[comboBoxProductCode.SelectedIndex].Number_chanel == 2)
                {
                    if (_result_A == "OK" && _result_B == "OK")
                    {
                        setLabelfinalTestResult_OK();
                        Port.Write("$|1|2|11|50\r");
                    }
                    if (_result_A == "NG" || _result_B == "NG")
                    {
                        setLabelfinalTestResult_NG();
                        Port.Write("$|1|2|00|39\r");
                    }
                    if (_result_A == "Empty" || _result_B == "Empty")
                    {
                        setLabelfinalTestResult_Empty();
                    }
                }
                if (productsList[comboBoxProductCode.SelectedIndex].Number_chanel == 1)
                {
                    if (_result_A == "OK")
                    {
                        setLabelfinalTestResult_OK();
                        Port.Write("$|1|2|11|50\r");
                    }
                    if (_result_A == "NG")
                    {
                        setLabelfinalTestResult_NG();
                        Port.Write("$|1|2|00|39\r");
                    }
                    if (_result_A == "Empty")
                    {
                        setLabelfinalTestResult_Empty();
                    }
                }
                testDone = false;
                if (labelfinalTestResult.Text == "OK")
                {
                    Statistics_DailyOK++;
                    Statistics_OK++;
                }
                else if (labelfinalTestResult.Text == "NG")
                {
                    Statistics_DailyNG++;
                    Statistics_NG++;
                }   
                reportWrite(labelGetVolA.Text, labelGetVolB.Text, labelResultA.Text, labelResultB.Text, labelfinalTestResult.Text);
                DrawChart(Statistics_OK, Statistics_NG);
            }

        }
        //End check value

        // Set result label on UI 
        public void setLabelA_OK()
        {
            labelResultA.BackColor = System.Drawing.Color.White;
            labelResultA.ForeColor = System.Drawing.Color.RoyalBlue;
            labelResultA.Text = "OK";
        }
        public void setLabelA_NG()
        {
            labelResultA.BackColor = System.Drawing.Color.Silver;
            labelResultA.ForeColor = System.Drawing.Color.Black;
            labelResultA.Text = "NG";
        }
        public void setLabelB_OK()
        {
            labelResultB.BackColor = System.Drawing.Color.White;
            labelResultB.ForeColor = System.Drawing.Color.RoyalBlue;
            labelResultB.Text = "OK";
        }
        public void setLabelB_NG()
        {
            labelResultB.BackColor = System.Drawing.Color.Silver;
            labelResultB.ForeColor = System.Drawing.Color.Black;
            labelResultB.Text = "NG";
        }
        public void setLabelA_Empty()
        {
            labelResultA.BackColor = System.Drawing.Color.White;
            labelResultA.ForeColor = System.Drawing.Color.Black;
            labelResultA.Text = "Empty";
        }
        public void setLabelB_Empty()
        {
            labelResultB.BackColor = System.Drawing.Color.White;
            labelResultB.ForeColor = System.Drawing.Color.Black;
            labelResultB.Text = "Empty";
        }
        public void setLabelfinalTestResult_Empty()
        {
            labelfinalTestResult.BackColor = System.Drawing.Color.White;
            labelfinalTestResult.ForeColor = System.Drawing.Color.Black;
            labelfinalTestResult.Text = "Empty";
        }

        public void comboBoxProductCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            VolA_H = productsList[comboBoxProductCode.SelectedIndex].AVoltageHighLevel;
            VolB_H = productsList[comboBoxProductCode.SelectedIndex].BVoltageHighLevel;
            VolA_L = productsList[comboBoxProductCode.SelectedIndex].AVoltageLowLevel;
            VolB_L = productsList[comboBoxProductCode.SelectedIndex].BVoltageLowLevel;
            labelVoltageA.Text = VolA_L.ToString("F2") + " V  ~  " + VolA_H.ToString("F2") + " V";
            labelVoltageB.Text = VolB_L.ToString("F2") + " V  ~  " + VolB_H.ToString("F2") + " V";
            setLabelB_Empty();
            setLabelA_Empty();
            setLabelfinalTestResult_Empty();
            int OK_num = Statistics_OK;
            int NG_num = Statistics_NG;

            Statistics_OK = 0;
            Statistics_NG = 0;
            LoadNewPict();
        }

        private void LoadNewPict()
        {
            // You should replace the bold image
            // in the sample below with an icon of your own choosing.  
            // Note the escape character used (@) when specifying the path.
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                if (comboBoxProductCode.SelectedItem.ToString().Contains("DJ96-00222") || comboBoxProductCode.SelectedItem.ToString().Contains("DJ96-00229"))
                {
                    pictureBox1.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\im\" + "DJ96-00222" + ".jpg");
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\im\" + comboBoxProductCode.SelectedItem.ToString() + ".jpg");
                }

            }
            catch (Exception)
            { }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modelSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void teToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }

        
        public void checkPermission()
        {
            if (Permission == "Technical")
            {
                tsPerLB.Text = Permission;
                modelSettingToolStripMenuItem.Enabled = true;
                comboBoxBaudrate.Enabled = true;
                comboBoxDatabit.Enabled = true;
                comboBoxEndBit.Enabled = true;
                comboBoxParity.Enabled = true;
            }
            else if(Permission == "OP")
            {
                tsPerLB.Text = Permission;
                modelSettingToolStripMenuItem.Enabled = false;
                comboBoxBaudrate.Enabled = false;
                comboBoxDatabit.Enabled = false;
                comboBoxEndBit.Enabled = false;
                comboBoxParity.Enabled = false;
            }

        }

        private void oPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permission = "OP";
            checkPermission();
        }

        private void loadSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkPermission();
            if(Permission == "Technical")
                new Form3().ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Port.Close();
            }
            catch (Exception)
            { }
        }

        private void comPortSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Port.IsOpen)
            {
                if (button1.Text != "DISCONNECT")
                {
                    button1.Text = "CONNECTING...";
                    Port.Write("$|1|0|0|37\r");
                }
                else if (button1.Text != "CONNECT")
                {
                    button1.Text = "CONNECT";
                    Port.Write("$|1|0|0|37\r");
                }
            }
            else
                button1.Text = "Open serial fist";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DrawChart(int okNumber, int ngNumber)
        {
            int Total = okNumber + ngNumber;
            DailyTotal = Statistics_DailyNG + Statistics_DailyOK;

            labelStatisticNG.Text = ngNumber.ToString();
            labelStatisticOK.Text = okNumber.ToString();
            labelStatisticsTotal.Text = Total.ToString();
            lbDailyNG.Text = Statistics_DailyNG.ToString();
            lbDailyOK.Text = Statistics_DailyOK.ToString();
            lbDailyTotal.Text = DailyTotal.ToString();

            if (Total == 0) Total = 10000000;
            float okRadian = (float)360.0 / Total * okNumber;
            float ngRadian = (float)360.0 - okRadian;


            //rawResponse.Text = "Hàng OK: " + okNumber.ToString() + "   Hàng NG: " + ngNumber.ToString() + " Tổng cộng" + Total.ToString() + "\r\n";
            //rawResponse.Text += "Góc OK: " + okRadian.ToString() + "   Góc NG: " + ngRadian.ToString();
            int startRectY = pictureBox.Size.Height / 2 - pictureBox.Size.Width / 2;
            int startRectX = pictureBox.Size.Width / 2 - pictureBox.Size.Height / 2;
            int rectDimemtions = pictureBox.Size.Width;
            if (startRectY < 0)
            {
                startRectY = 0;
                rectDimemtions = pictureBox.Size.Height;
            }
            if (startRectX < 0)
            {
                startRectX = 0;
                rectDimemtions = pictureBox.Size.Width;
            }

            Rectangle rect = new Rectangle(startRectX, startRectY, rectDimemtions, rectDimemtions);
            Bitmap custormChart = new Bitmap(pictureBox.Size.Width, pictureBox.Size.Height);
            Graphics g = Graphics.FromImage(custormChart);

            //g.FillEllipse(Brushes.Red, pictureBox.Size.Width / 2 - pictureBox.Size.Height / 2, pictureBox.Size.Height / 2 - pictureBox.Size.Height / 2, pictureBox.Size.Height , pictureBox.Size.Height);
            g.FillPie(Brushes.Lime, rect, 0, okRadian);
            g.FillPie(Brushes.Red, rect, okRadian, ngRadian);
            //g.FillEllipse(Brushes.White, pictureBox.Size.Width / 2 - pictureBox.Size.Height / 2 + 10, pictureBox.Size.Height / 2 - pictureBox.Size.Height / 2 + 10, pictureBox.Size.Height - 20, pictureBox.Size.Height - 20);
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
            }
            pictureBox.Image = custormChart;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Dispose();
            timer2.Start();

            if (timer2.Interval == 2000)
            {
                setLabelA_Empty();
                setLabelB_Empty();
                setLabelfinalTestResult_Empty();
                //label3.BackColor = Color.White;
                //label2.BackColor = Color.White;
                timer2.Stop();
            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            hidelbBigResult();
        }

        private void lbBigResult_DoubleClick(object sender, EventArgs e)
        {
            hidelbBigResult();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Port.Close();
            }
            catch (Exception)
            { }
        }

        private void loginToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            checkPermission();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkPermission();
        }

        public void setLabelfinalTestResult_OK()
        {
            labelfinalTestResult.BackColor = System.Drawing.Color.RoyalBlue;
            labelfinalTestResult.ForeColor = System.Drawing.Color.Black;
            labelfinalTestResult.Text = "OK";
            setlbBigResult_OK();
        }
        public void setLabelfinalTestResult_NG()
        {
            labelfinalTestResult.BackColor = System.Drawing.Color.Silver;
            labelfinalTestResult.ForeColor = System.Drawing.Color.Black;
            labelfinalTestResult.Text = "NG";
            setlbBigResult_NG();
        }

        public void setlbBigResult_OK()
        {
            lbBigResult.Visible = true;
            lbBigResult.BackColor = System.Drawing.Color.RoyalBlue;
            lbBigResult.ForeColor = System.Drawing.Color.Black;
            lbBigResult.Text = "OK";
        }
        public void setlbBigResult_NG()
        {
            lbBigResult.Visible = true;
            lbBigResult.BackColor = System.Drawing.Color.Silver;
            lbBigResult.ForeColor = System.Drawing.Color.Black;
            lbBigResult.Text = "NG";
        }
        public void hidelbBigResult()
        {
            lbBigResult.Visible = false;
        }

        public uint retryCounter = 0, retryLoop = 6;
        public bool testDone = false;
        public void FrameProcessing(string Frame)
        {
            // cắt chuỗi thành khung truyền để xử lí
            try
            {
                string frame = Frame.Substring(Frame.LastIndexOf("$"));
                string[] FrameBuffer = frame.Split('|');
                Int32[] FrameInNumber = new Int32[FrameBuffer.Length];
                Int64 checkSum = 36;
                for (int i = 1; i < FrameInNumber.Length; i++)
                {
                    try
                    {
                        FrameInNumber[i] = Convert.ToInt32(FrameBuffer[i]);
                        checkSum += FrameInNumber[i];
                    }
                    catch (Exception)
                    { }
                }

                checkSum = checkSum - FrameInNumber[FrameBuffer.Length - 1];
                if (checkSum % 256 == FrameInNumber[FrameBuffer.Length - 1])
                {
                    switch (FrameInNumber[2])
                    {
                        case 0:
                            {
                                switch (FrameInNumber[3])
                                {
                                    case 0:
                                        {
                                            toolStripStatusConnect.Text = "IT8512A has disconnected";
                                            rawResponse.Text = "can't connect to IT8512A, check cable.";
                                            button1.Text = "CONNECT";
                                            serialPortStatus.BackColor = System.Drawing.Color.Blue;
                                            break;
                                        }
                                    case 1:
                                        {
                                            toolStripStatusConnect.Text = "IT8512A online";
                                            rawResponse.Text = "IT8512A connected";
                                            button1.Text = "DISCONNECT";
                                            serialPortStatus.BackColor = System.Drawing.Color.Silver;
                                            break;
                                        }
                                }
                                break;
                            }
                        case 1:
                            {
                                if (productsList[comboBoxProductCode.SelectedIndex].Number_chanel == 1 & retryCounter <= retryLoop + 1)
                                {
                                    uint counter = retryCounter;
                                    checkValue(FrameInNumber[4] / 1000.0, FrameInNumber[3]);
                                    if (counter < retryCounter && retryCounter <= retryLoop)
                                    {
                                        Port.Write("$|1|1|1|39\r");
                                    }
                                    if (retryCounter > retryLoop)
                                    {
                                        testDone = true;
                                        checkValue(0, 0);
                                    }

                                }
                                if (productsList[comboBoxProductCode.SelectedIndex].Number_chanel == 2 & retryCounter <= retryLoop * 2 + 1)
                                {
                                    uint counter = retryCounter;
                                    checkValue(FrameInNumber[4] / 1000.0, FrameInNumber[3]);
                                    if (counter < retryCounter)
                                        if (retryCounter <= retryLoop)
                                        {

                                            label2.BackColor = Color.DarkGray;
                                            label3.BackColor = Color.White;
                                            Port.Write("$|1|1|1|39\r");
                                        }
                                        else if (retryLoop < retryCounter && retryCounter <= retryLoop * 2)
                                        {
                                            Port.Write("$|1|1|2|40\r");
                                            label3.BackColor = Color.DarkGray;
                                            label2.BackColor = Color.White;
                                        }
                                        else
                                        {
                                            testDone = true;
                                            checkValue(0, 0);
                                        }
                                }

                                break;
                            }
                        case 4:
                            {
                                switch (FrameInNumber[3])
                                {
                                    case 11:
                                        {
                                            hidelbBigResult();
                                            Port.Write("$|1|1|1|39\r");
                                            labelResultA.Text = "Testing...";
                                            labelResultB.Text = "Testing...";
                                            if (productsList[comboBoxProductCode.SelectedIndex].Number_chanel == 1)
                                                labelResultB.Text = "Not use";
                                            retryCounter = 0;
                                            timer2.Stop();
                                            break;

                                        }
                                    case 10:
                                        {
                                            hidelbBigResult();
                                            if (productsList[comboBoxProductCode.SelectedIndex].Number_chanel == 1)
                                            {
                                                Port.Write("$|1|1|1|39\r");
                                                labelResultA.Text = "Testing...";
                                                timer2.Stop();
                                                setLabelB_Empty();
                                                retryCounter = 0;
                                            }
                                            else if (productsList[comboBoxProductCode.SelectedIndex].Number_chanel == 2)
                                            {
                                                if (labelfinalTestResult.Text == "Empty")
                                                    labelResultA.Text = "Wait slot B";
                                                retryCounter = 0;
                                            }
                                            break;
                                        }
                                    case 1:
                                        {
                                            hidelbBigResult();
                                            if (productsList[comboBoxProductCode.SelectedIndex].Number_chanel == 2)
                                            {
                                                if (labelfinalTestResult.Text == "Empty")
                                                    labelResultB.Text = "wait slot A";
                                                retryCounter = 0;
                                            }
                                            else if (productsList[comboBoxProductCode.SelectedIndex].Number_chanel == 1)
                                            {
                                                labelResultB.Text = "Connect to slot A";
                                                retryCounter = 0;
                                                timer2.Interval = 2000;
                                                timer2.Start();
                                            }
                                            break;
                                        }
                                    case 0:
                                        {
                                            hidelbBigResult();
                                            retryCounter = 0;
                                            timer2.Interval = 2000;
                                            timer2.Start();
                                            Port.Write("$|1|2|11|50\r");
                                            break;
                                        }

                                }
                                break;
                            }

                    }

                }
                else
                    rawResponse.Text += "\r\n check sum fail. Right sum is :" + (checkSum % 256).ToString();

            }
            catch (Exception e)
            {
                // MessageBox.Show(e.ToString());
            }


        }
        public string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 2; i > -1; i = i - 2)
            {
                reverse += cArray[i];
                reverse += cArray[i + 1];
            }
            return reverse;
        }

        // end set result label status 
        // write report file
        public void reportWrite(string voltageA, string voltageB, string resultA, string resultB, string Result)
        {
            DateTime dateNew = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 30, 0);
            string moment = DateTime.Now.ToString("yyyyMMddHHmmss");

            string today_txt;
            int resultDay = DateTime.Compare(dateNew, DateTime.Now);

            if (resultDay > 0)
                today_txt = "Report-"+ DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
            else
                today_txt = "Report-" + DateTime.Now.ToString("yyyy-MM-dd");


            if (!Directory.Exists(@"C:\Changer DC Tester\Report\")) Directory.CreateDirectory(@"C:\Changer DC Tester\Report\");

            if (File.Exists(@"C:\Changer DC Tester\Report\"+ today_txt + ".txt")) // Nếu file lịch sử tồn tại thì lưu thông tin vào
            {
                int line = File.ReadAllLines(@"C:\Changer DC Tester\Report\" + today_txt + ".txt").Length;
                using (StreamWriter sw = File.AppendText(@"C:\Changer DC Tester\Report\" + today_txt + ".txt"))
                {
                    string reportData = "L" + line.ToString() + "/" + Result + "/" + productsList[comboBoxProductCode.SelectedIndex].name + "/" + moment + "/" + voltageA + "/" + resultA + "/" + voltageB + "/" + resultB;
                    sw.WriteLine(reportData);
                }

            }
            else
            {
                using (StreamWriter sw = File.AppendText(@"C:\Changer DC Tester\Report\" + today_txt + ".txt"))
                {
                    string reportData = "STT/" + "Final result/" + "Product name " + "/" + "Time" + "/" + "Chanel A" + "/" + "ResultA" + "/" + "Chanel B" + "/" + "ResultB" + "\n";
                    reportData += "L" + "1" + "/" + Result + "/" + productsList[comboBoxProductCode.SelectedIndex].name + "/" + moment + "/" + voltageA + "/" + resultA + "/" + voltageB + "/" + resultB;
                    sw.WriteLine(reportData);
                }
            }
        }

    }

    public class productCode
    {
        public string name;
        public double AVoltageHighLevel;
        public double BVoltageHighLevel;
        public double AVoltageLowLevel;
        public double BVoltageLowLevel;
        public uint Number_chanel;

        public productCode(string name, double AvolHighLevel, double AvolLowLevel, double BvolHighLevel, double BvolLowLevel, uint Number_chanel)
        {
            this.name = name;
            this.AVoltageHighLevel = AvolHighLevel;
            this.AVoltageLowLevel = AvolLowLevel;
            this.BVoltageHighLevel = BvolHighLevel;
            this.BVoltageLowLevel = BvolLowLevel;
            this.Number_chanel = Number_chanel;
        }

    }


}

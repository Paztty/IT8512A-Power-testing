using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.IO.Ports;
using System.Threading;

using System.Drawing.Design;
using System.Drawing.Drawing2D;//Cung cap cac doi tuong ve vector 2 chieu
using System.Drawing.Imaging;//Thao tac vs hinh anh
using System.Drawing.Printing;//Thuc hien in, cac tac vu in an
using System.Drawing.Text;//Thuc hien ve voi Font



namespace IT8512A_Power_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Serial_UI_init();
            ProductindomationInit();
            Port.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            timer1.Start();

        }

        // Form load funtion
        public bool ComponentInitted = false;
        public void Form1_Load(object sender, EventArgs e)
        {
            if (ComponentInitted == false)
            {
                ComponentInitted = true;
            }
            DrawChart(1,1);
        }
        // End Form load function

        // Serial code
        public string[] BaudRate = { "300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "74880", "115200", "230400", "250000", "500000", "1000000", "2000000" };
        public byte[] Data_size = { 7, 8 };
        public String[] parity_bit = { "none", "even", "odd", "mark", "space" };
        public String[] end_bit = { "none", "1", "1.5", "2" };

        public byte[] readCmd = { 0xaa, 0x00, 0x5f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x09 };
        public string String_response = string.Empty;
        bool Message_allow = true;
        public String DataReciver = string.Empty;
        public string DataRespose = string.Empty;

        delegate void SetTextCallback(string text);

        // check var
        public static double VolA_H, VolA_L, VolB_H, VolB_L;
        public string _result_A, _result_B;
        public static bool form2Close;
        public string chanel = "chanelA";

        public int Statistics_OK = 1, Statistics_NG = 1;
        public bool chanelAcherked, chanelBcherked, waitResponse = false, retryTest;

        // end check var

        // product code
        public static productCode[] productsList =
                { new productCode("DJ96-00216", 37.6,37.4,37.6,37.4),
                  new productCode("DJ96-00204", 24.95, 24.8, 24.95, 24.8),
                  new productCode("DJ96-00210", 20.8, 20.6, 20.8, 20.6),
                  new productCode("DJ96-00222", 25.95, 25.75, 25.95, 25.75),
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
            labelVoltageA.Text = ((VolA_H + VolA_L) / 2.0).ToString("F3") + " V";
            labelVoltageB.Text = ((VolB_H + VolB_L) / 2.0).ToString("F3") + " V";
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
           
            Console.Write("Begin");
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
        private void buttonSerialConnect_Click_1(object sender, EventArgs e)
        {
            if(comboBoxProductCode.Enabled == true)
                comboBoxProductCode.Enabled = false;
            else
                comboBoxProductCode.Enabled = true;
            try
            {
                if (Port.IsOpen)
                {
                    Port.DiscardInBuffer();
                    Port.Close();
                    buttonSerialConnect.Text = "OPEN";
                    //toolStripStatusConnect.Text = "IT8512A has disconnected";
                    Message_allow = false;
                }
                else
                {
                    Port.Open();
                    buttonSerialConnect.Text = "CLOSE";
                   // toolStripStatusConnect.Text = "IT8512A has connected";
                    timer1.Enabled = true;
                    Message_allow = true;
                }
            }
            catch (Exception Port)
            {
                MessageBox.Show(Port.Message);
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
            DrawChart(Statistics_OK, Statistics_NG);
            VolA_H = productsList[comboBoxProductCode.SelectedIndex].AVoltageHighLevel;
            VolB_H = productsList[comboBoxProductCode.SelectedIndex].BVoltageHighLevel;
            VolA_L = productsList[comboBoxProductCode.SelectedIndex].AVoltageLowLevel;
            VolB_L = productsList[comboBoxProductCode.SelectedIndex].BVoltageLowLevel;
            labelVoltageA.Text = "Min:" + VolA_L.ToString("F3") + " V  Max:" + VolA_H.ToString("F3") + " V";
            labelVoltageB.Text = "Min:" + VolA_L.ToString("F3") + " V  Max:" + VolA_H.ToString("F3") + " V";
            try
            {
                if (Port.IsOpen)
                {
                    if (DataReciver != String.Empty)
                    {
                        toolStripStatusConnect.Text = "IT8512A has connected";
                    }
                    else
                        toolStripStatusConnect.Text = "IT8512A has dis connected";
                }
            
            }
            catch (Exception Port)
            {
                if (Message_allow == true)
                {
                    Message_allow = false;
                    buttonSerialConnect.Text = "OPEN";
                    toolStripStatusConnect.Text = "IT8512A has disconnected";
                    MessageBox.Show(Port.Message);
                }
            }
            if (Message_allow == true && toolStripStatusConnect.Text == "IT8512A has connected")
            {
                if (serialPortStatus.BackColor == System.Drawing.Color.Red)
                    serialPortStatus.BackColor = System.Drawing.Color.Blue;
                else
                    serialPortStatus.BackColor = System.Drawing.Color.Red;
            }
        }

        // Reciver data
        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            if (!Port.IsOpen) return;
            int bytes = Port.BytesToRead;
            string InputData = string.Empty;
            string InputDataBuffer = string.Empty;
            byte[] buffer = new byte[bytes];

            try
            {
                Port.Read(buffer, 0, bytes);
            }
            catch (Exception)
            {
                return;
            }
            for (int i = 0; i < bytes; i++)
            {
                InputData += (char)buffer[i];
            }

            SetText(InputData);
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
                DataReciver += text;
                //rawResponse.Text = DataReciver;
                rawRespons_to_singleUpdate(DataReciver);
            }
        }
        // End Serial code

        // check value
        private void checkValue(double volIn, string chanel)
        {

            if (chanel == "chanelA")
            {
                label2.BackColor = Color.DarkGray;
                label3.BackColor = Color.White;

                labelGetVolA.Text = volIn.ToString() + " V";
                if (VolA_L <= volIn && volIn <= VolA_H)
                {
                    setLabelA_OK();
                    _result_A = "OK";
                }

                else if (volIn == 0)
                {
                    setLabelA_Empty();
                    _result_A = "Empty";
                }
                else if (volIn > 0)
                {
                    setLabelA_NG();
                    _result_A = "NG";
                }

            }
            if (chanel == "chanelB")
            {
                label3.BackColor = Color.DarkGray;
                label2.BackColor = Color.White;
                labelGetVolB.Text = volIn.ToString() + " V";
                if (VolB_L <= volIn && volIn <= VolB_H)
                {
                    setLabelB_OK();
                    _result_B = "OK";
                }
                else if (volIn == 0)
                {
                    setLabelB_Empty();
                    _result_B = "Empty";
                }
                else if (volIn > 0)
                {
                    setLabelB_NG();
                    _result_B = "NG";
                }
            }
            if (chanel == "Result")
            {
                if (chanelAcherked && chanelBcherked == true)
                {
                    if (_result_A == "OK" && _result_B == "OK")
                    {
                        setLabelfinalTestResult_OK();
                    }
                    if (_result_A == "NG" || _result_B == "NG")
                    {
                        if (retryTest == true)
                        {
                            try
                            {
                                Port.Write("A");
                            }
                            catch
                            { }
                            retryTest = false;
                        }
                        else
                            setLabelfinalTestResult_NG();
                    }
                    if (_result_A == "Empty" || _result_B == "Empty")
                    {
                        setLabelfinalTestResult_Empty();
                    }
                    chanelAcherked = false;
                    chanelBcherked = false;

                    if (labelfinalTestResult.Text == "OK")
                        Statistics_OK++;
                    else if (labelfinalTestResult.Text == "NG")
                        Statistics_NG++;

                    DrawChart(Statistics_OK, Statistics_NG);

                }
            }
        }
        //End check value

        // Set result label on UI 
        public void setLabelA_OK()
        {
            labelResultA.BackColor = System.Drawing.Color.White;
            labelResultA.ForeColor = System.Drawing.Color.Lime;
            labelResultA.Text = "OK";
        }
        public void setLabelA_NG()
        {
            labelResultA.BackColor = System.Drawing.Color.Blue;
            labelResultA.ForeColor = System.Drawing.Color.Red;
            labelResultA.Text = "NG";
        }
        public void setLabelB_OK()
        {
            labelResultB.BackColor = System.Drawing.Color.White;
            labelResultB.ForeColor = System.Drawing.Color.Lime;
            labelResultB.Text = "OK";
        }
        public void setLabelB_NG()
        {
            labelResultB.BackColor = System.Drawing.Color.Blue;
            labelResultB.ForeColor = System.Drawing.Color.Red;
            labelResultB.Text = "NG";
        }
        public void setLabelA_Empty()
        {
            labelResultA.BackColor = System.Drawing.Color.DarkViolet;
            labelResultA.ForeColor = System.Drawing.Color.White;
            labelResultA.Text = "Empty";
        }
        public void setLabelB_Empty()
        {
            labelResultB.BackColor = System.Drawing.Color.DarkViolet;
            labelResultB.ForeColor = System.Drawing.Color.White;
            labelResultB.Text = "Empty";
        }
        public void setLabelfinalTestResult_Empty()
        {
            labelfinalTestResult.BackColor = System.Drawing.Color.DarkViolet;
            labelfinalTestResult.ForeColor = System.Drawing.Color.White;
            labelfinalTestResult.Text = "Empty";
        }

        public void comboBoxProductCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            VolA_H = productsList[comboBoxProductCode.SelectedIndex].AVoltageHighLevel;
            VolB_H = productsList[comboBoxProductCode.SelectedIndex].BVoltageHighLevel;
            VolA_L = productsList[comboBoxProductCode.SelectedIndex].AVoltageLowLevel;
            VolB_L = productsList[comboBoxProductCode.SelectedIndex].BVoltageLowLevel;
            labelVoltageA.Text = "Min: " + VolA_L.ToString("F3") + " V  Max: " + VolA_L.ToString("F3") + " V";
            labelVoltageB.Text = "Min: " + VolB_L.ToString("F3") + " V  Max: " + VolB_L.ToString("F3") + " V";
            setLabelB_Empty();
            setLabelA_Empty();
            setLabelfinalTestResult_Empty();
            LoadNewPict();
        }

        private void LoadNewPict()
        {
            // You should replace the bold image
            // in the sample below with an icon of your own choosing.  
            // Note the escape character used (@) when specifying the path.  
            pictureBox1.BackgroundImage = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath)+ @"\image\DJ96-00222.jpg");
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modelSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2Close = false;
            new Form2().ShowDialog();
        }

        private void teToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void comPortSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Port.IsOpen)
            {
                if(button1.Text == "CONNECT")
                {
                    Port.Write("SSSS");
                    button1.Text = "DISCONNECT";
                }
                else if (button1.Text == "DISCONNECT")
                {
                    Port.Write("EEEE");
                    button1.Text = "CONNECT";
                }
            }       
        }

        private void DrawChart(int okNumber, int ngNumber)
        {
            int Total = okNumber + ngNumber;

            labelStatisticNG.Text = ngNumber.ToString();
            labelStatisticOK.Text = okNumber.ToString();
            labelStatisticsTotal.Text = Total.ToString();

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
            if (timer2.Interval == 2000)
            {
                setLabelA_Empty();
                setLabelB_Empty();
                setLabelfinalTestResult_Empty();
                label3.BackColor = Color.White;
                label2.BackColor = Color.White;
                timer2.Stop();
            }

        }


        public void setLabelfinalTestResult_OK()
        {
            labelfinalTestResult.BackColor = System.Drawing.Color.White;
            labelfinalTestResult.ForeColor = System.Drawing.Color.Lime;
            labelfinalTestResult.Text = "OK";
        }
        public void setLabelfinalTestResult_NG()
        {
            labelfinalTestResult.BackColor = System.Drawing.Color.Blue;
            labelfinalTestResult.ForeColor = System.Drawing.Color.Red;
            labelfinalTestResult.Text = "NG";
        }




        public void rawRespons_to_singleUpdate(string InputString)
        {
            rawResponse.Text = InputString;
            int num;
            double value;
            string hexString;
            if (InputString.Contains("IDE"))
            {
                timer2.Interval = 2000;
                timer2.Start();
                DataReciver = "";
            }
            if (InputString.Contains("run"))
            {
                button1.Text = "DISCONNECT";
            }
            if (InputString.Contains("stop"))
            {
                button1.Text = "CONNECT";
            }
            if (InputString.Contains("start"))
            {
                DataReciver = "";
                Port.Write("A");
            }
            if (InputString.Contains("StartA"))
            {
                DataReciver = "";
                chanelAcherked = false;
            }
            if (InputString.Contains("StartB"))
            {
                DataReciver = "";
                chanelBcherked = false;
            }
            if (InputString.Contains("DoneA"))
            {
                DataReciver = "";
                chanelAcherked = true;
                Port.Write("B");
            }
            if (InputString.Contains("DoneB"))
            {
                DataReciver = "";
                chanelBcherked = true;
            }
                try
                {
                    hexString = Reverse(InputString.Substring(6, 8));
                    num = Int32.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
                    value = num / 1000.0;
                if (chanelAcherked == false)
                    checkValue(value, "chanelA");
                else if (chanelBcherked == false)
                    checkValue(value, "chanelB");
                else
                    checkValue(value, "Result");
                }
                catch (Exception)
                {
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



    }

    public class productCode
    {
        public string name;
        public double AVoltageHighLevel;
        public double BVoltageHighLevel;
        public double AVoltageLowLevel;
        public double BVoltageLowLevel;

        public productCode(string name, double AvolHighLevel, double AvolLowLevel, double BvolHighLevel, double BvolLowLevel)
        {
            this.name = name;
            this.AVoltageHighLevel = AvolHighLevel;
            this.AVoltageLowLevel = AvolLowLevel;
            this.BVoltageHighLevel = BvolHighLevel;
            this.BVoltageLowLevel = BvolLowLevel;
        }

    }
}

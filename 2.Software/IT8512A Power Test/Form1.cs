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
        private void Form1_Load(object sender, EventArgs e)
        {
            if (ComponentInitted == false)
            {
                Serial_UI_init();
                ComponentInitted = true;
            }
            ProductindomationInit();
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
            labelVoltageA.Text = ((VolA_H + VolA_L)/2.0).ToString() + " V";
            labelVoltageB.Text = ((VolB_H + VolB_L) / 2.0).ToString() + " V";
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

            comboBoxBaudrate.SelectedIndex = 4;
            comboBoxDatabit.SelectedIndex = 1;
            comboBoxEndBit.SelectedIndex = 1;
            comboBoxParity.SelectedIndex = 0;

            Port.PortName = comboBoxComPort.Text;
            Port.Parity = Parity.None;
            Port.StopBits = StopBits.One;
            Port.BaudRate = Convert.ToInt32(comboBoxBaudrate.Text);
            Console.Write("Begin");
        }
        // Sellect com port
        private void comboBoxComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Port.PortName = comboBoxComPort.Text;
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
            try
            {
                if (Port.IsOpen)
                {
                    Port.Close();
                    buttonSerialConnect.Text = "CONNECT";
                    toolStripStatusConnect.Text = "IT8512A has disconnected";
                    timer1.Enabled = false;
                    Message_allow = false;
                }
                else
                {
                    Port.Open();
                    buttonSerialConnect.Text = "DISCONNECT";
                    toolStripStatusConnect.Text = "IT8512A has connected";
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
            try
            {
                if (Port.IsOpen)
                {
                    Port.DiscardOutBuffer();
                    Port.Write(readCmd, 0, 26);
                    //rawResponse.Text = "";
                }
            }
            catch (Exception Port)
            {
                if (Message_allow == true)
                {
                    Message_allow = false;
                    buttonSerialConnect.Text = "CONNECT";
                    toolStripStatusConnect.Text = "IT8512A has disconnected";
                    MessageBox.Show(Port.Message);
                    timer1.Enabled = false;
                }
            }
            if (Message_allow == true)
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
            byte[] buffer = new byte[bytes];
            Port.Read(buffer, 0, bytes);
            string InputData = string.Empty;
            string InputDataBuffer = string.Empty;
            for (int i = 0; i < buffer.Length; i++)
            {
                try
                {
                    InputData += buffer[i].ToString("X2");
                }
                catch (Exception)
                {

                }
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
                DataRespose += text;
                rawRespons_to_singleUpdate(DataRespose);
            }
        }
        // End Serial code

        // check value
        private void checkValue(double volIn, string chanel)
        {
            labelGetVolA.Text = volIn.ToString() + " V";
            if (chanel == "chanelA")
            {
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
            if (_result_A == "OK" && _result_B == "OK")
            {
                setLabelfinalTestResult_OK();
            }
            if (_result_A == "NG" || _result_B == "NG")
            {
                setLabelfinalTestResult_NG();
            }
            if (_result_A == "Empty" || _result_B == "Empty")
            {
                setLabelfinalTestResult_Empty();
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
            labelVoltageA.Text = ((VolA_H + VolA_L) / 2.0).ToString() + " V";
            labelVoltageB.Text = ((VolB_H + VolB_L) / 2.0).ToString() + " V";
            setLabelB_Empty();
            setLabelA_Empty();
            setLabelfinalTestResult_Empty();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            new Form2().Show();
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
            //rawResponse.Text = InputString;
            int num;
            double value;
            string hexString;
            try
            {
                hexString = Reverse(InputString.Substring(6, 8));
                num = Int32.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
                value = num / 1000.0;
                checkValue(value, "chanelA");
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

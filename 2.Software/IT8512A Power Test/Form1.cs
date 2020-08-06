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
            Serial_UI_init();
            Port.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
        }

        // Form load funtion
        private void Form1_Load(object sender, EventArgs e)
        {

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
        delegate void SetTextCallback(string text);

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
        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.WriteLine("Data Received:");
            Console.Write(indata);
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
            //comboBoxComPort.DataSource = SerialPort.GetPortNames();
            Port.DiscardOutBuffer();
            Port.Write(readCmd, 0, 26);
            rawResponse.Text = "";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Port.IsOpen)
                {
                    //Port.DiscardOutBuffer();
                    //Port.Write(readCmd, 0, 26);
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
            String InputData = Port.ReadExisting();
            if (InputData != String.Empty)
            {
                SetText(InputData); // Chính vì vậy phải sử dụng ủy quyền tại đây. Gọi delegate đã khai báo trước đó
            }
        }
        private void SetText(string text)
        {
            if (this.rawResponse.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else 
            { 
                this.rawResponse.Text += text;
            }
        }
        // End Serial code


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

        


        public void rawResponsUpdate()
        {
            rawResponse.Text = String_response;
        }









        // end set result label status 

        

    }
}

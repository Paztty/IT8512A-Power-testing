/* IT8512A test machine */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// add for Serial port
using System.IO;
using System.IO.Ports;
using System.Xml;




namespace IT8512A_Power_Test
{
    public partial class mainForm : Form
    {
        SerialPort serialPort1 = new SerialPort();
        delegate void SetTextCallback(String data);
        String InputData = String.Empty;
        String[] PortName = { };

        public mainForm()
        {
            InitializeComponent();
            PortName = SerialPort.GetPortNames();
            serialPort1.PortName = PortName[0];
            serialPort1.BaudRate = 9600;
            serialPort1.Parity = Parity.None;


            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
        }
        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            InputData = serialPort1.ReadExisting();
            if (InputData != String.Empty)
            {
                SetText(InputData); // Chính vì vậy phải sử dụng ủy quyền tại đây. Gọi delegate đã khai báo trước đó
            }
        }
        private void SetText(string text)
        {
            if (this.textDataResponse.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else this.textDataResponse.Text += text;
        }

         private void mainForm_Load(object sender, EventArgs e)
         {
            serialPort1.Open();
            PortLabel.Text = PortName[0];
        }

    }
}

using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT8512A_Power_Test
{
    public partial class Form3 : Form
    {

        public int[] MounthFrom = {   1 ,  2 ,  3 ,  4 ,  5 ,  6 ,  7 ,  8 ,  9 ,  10 ,
                                 11 ,  12 };
        public int[] MounthTo = {   1 ,  2 ,  3 ,  4 ,  5 ,  6 ,  7 ,  8 ,  9 ,  10 ,
                                 11 ,  12 };
        public int[] Dayfrom = {  1 ,  2 ,  3 ,  4 ,  5 ,  6 ,  7 ,  8 ,  9 ,  10 ,
                                 11 ,  12 ,  13 ,  14 ,  15 ,  16 ,  17 ,  18 ,  19 ,  20 ,
                                 21 ,  22 ,  23 ,  24 ,  25 ,  26 ,  27 ,  28 ,  29 ,  30 ,  31  };
        public int[] Dayto = {  1 ,  2 ,  3 ,  4 ,  5 ,  6 ,  7 ,  8 ,  9 ,  10 ,
                                 11 ,  12 ,  13 ,  14 ,  15 ,  16 ,  17 ,  18 ,  19 ,  20 ,
                                 21 ,  22 ,  23 ,  24 ,  25 ,  26 ,  27 ,  28 ,  29 ,  30 ,  31  };
        FillterMan fillterMan = new FillterMan();
        string reportFilePath = "";
        string[] productNameList = new string[Form1.productsList.Length +1];
        public string exReport = "STT/" + "Final result/" + "Product name " + "/" + "Time" + "/" + "Chanel A" + "/" + "ResultA" + "/" + "Chanel B" + "/" + "ResultB" + "\n";

        public int Ok, NG, Total;
        public string ExportReportPath = "";

        public Form3()
        {
            InitializeComponent();
            //pnOption.Visible = false;

            productNameList[0] = "None";
            for (int i = 1; i < Form1.productsList.Length+1; i++)
            {
                productNameList[i] = Form1.productsList[i-1].name;
            }
            cbModel.DataSource = productNameList;
            string today_name = DateTime.Now.ToString("yyyy-MM-dd");
            //lbTimerFillter.Text = today_name;
            //loadReport(DateTime.Now);
            for (int i = 0; i < reportFilePath.Length; i++)
            {
                Console.WriteLine(reportFilePath[i]);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pnOption.Visible = true;
            cbMonth.DataSource = MounthFrom;
            cbDay.DataSource = Dayfrom;
            cbMonthTo.DataSource = MounthTo;
            cbDayTo.DataSource = Dayto;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        public void loadReport(DateTime date)
        {
            String[] dataInLine;
            dgReport.SelectAll();
            dgReport.ClearSelection();
            string pathReport = @"C:\Changer DC Tester\Report\Report-" + date.ToString("yyyy-MM-dd") + ".txt";
            if (File.Exists(pathReport)) // if computer has report file, push it on data grit view
            {
                var lines = File.ReadAllLines(pathReport);
                for (int i = lines.Length - 1; i >= 0; i--)
                {
                    dataInLine = lines[i].Split('/');

                    if (dataInLine[2] == productNameList[cbModel.SelectedIndex])
                    {
                        if (dataInLine[1].Contains("OK")) Ok++;
                        if (dataInLine[1].Contains("NG")) NG++;
                        if (dataInLine[0].Contains("L")) Total++;
                        dgReport.Rows.Add(Total.ToString(), dataInLine[1], dataInLine[2], dataInLine[3], dataInLine[4], dataInLine[5], dataInLine[6], dataInLine[7]);

                    }
                    else if (productNameList[cbModel.SelectedIndex] == "None")
                    {
                        if (dataInLine[1].Contains("OK")) Ok++;
                        if (dataInLine[1].Contains("NG")) NG++;
                        if (dataInLine[0].Contains("L"))
                        {
                            Total++;
                            dgReport.Rows.Add(Total.ToString(), dataInLine[1], dataInLine[2], dataInLine[3], dataInLine[4], dataInLine[5], dataInLine[6], dataInLine[7]);
                        }
                    }

                }
                lbStaTTnum.Text = Total.ToString();
                lbStaOKnum.Text = Ok.ToString("D");
                lbStaNGnum.Text = NG.ToString("D");
            }
        }
        public void loadReportToday()
        {
            string pathReport = @"C:\Changer DC Tester\Report\Report-" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            String[] dataInLine;
            if (File.Exists(pathReport)) // if computer has report file, push it on data grit view
            {
                
                var lines = File.ReadAllLines(pathReport);
                for (int i = lines.Length - 1; i >= 0; i--)
                {
                    dataInLine = lines[i].Split('/');
                    if (dataInLine[1].Contains("OK")) Ok++;
                    if (dataInLine[1].Contains("NG")) NG++;
                    if (dataInLine[0].Contains("L"))
                    {
                        Total++;
                        dgReport.Rows.Add(Total.ToString(), dataInLine[1], dataInLine[2], dataInLine[3], dataInLine[4], dataInLine[5], dataInLine[6], dataInLine[7]);
                    }
                }
                lbStaTTnum.Text = Total.ToString();
                lbStaOKnum.Text = Ok.ToString("D");
                lbStaNGnum.Text = NG.ToString("D");
            }
        }


        private void btOptionClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClearNG_Click(object sender, EventArgs e)
        {
            Form1.Statistics_NG = 0;
            Form1.Statistics_DailyNG = 0;
        }


        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btFillter_Click(object sender, EventArgs e)
        {
            Ok = 0;
            NG = 0;
            Total = 0;
            dgReport.Rows.Clear();
            dgReport.Refresh();
            fillterMan.changeFillterTime(Convert.ToInt32(Dayfrom[cbDay.SelectedIndex]),
                                         Convert.ToInt32(MounthFrom[cbMonth.SelectedIndex]),
                                         Convert.ToInt32(nbYearFrom.Value),
                                         Convert.ToInt32(Dayto[cbDayTo.SelectedIndex]),
                                         Convert.ToInt32(MounthTo[cbMonthTo.SelectedIndex]),
                                         Convert.ToInt32(nbYearTo.Value));

            DateTime dayFrom = new DateTime(fillterMan.fromYear, fillterMan.fromMonth, fillterMan.fromDay);
            DateTime dayTo = new DateTime(fillterMan.toYear, fillterMan.toMonth, fillterMan.toDay);
            lbTimerFillter.Text  = "Report from: " + dayFrom.ToString("yyyy-MM-dd") + " to: " + dayTo.ToString("yyyy-MM-dd");
            while (dayFrom <= dayTo)
            {
                loadReport(dayFrom);
                dayFrom = dayFrom.AddDays(1);
                Console.WriteLine(dayFrom.ToString("yyyy-MM-dd"));
            }
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            exReport = "STT/" + "Final result/" + "Product name " + "/" + "Time" + "/" + "Chanel A" + "/" + "ResultA" + "/" + "Chanel B" + "/" + "ResultB" + "\n";

            for (int i = 0; i < dgReport.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgReport.Columns.Count; j++)
                    {
                        exReport += dgReport.Rows[i].Cells[j].Value.ToString();
                        exReport += "/";
                    }
                    exReport += System.Environment.NewLine;
                }
            
            saveFileReport.DefaultExt =".txt";
            saveFileReport.ShowDialog();
        }

        private void saveFileReport_FileOk(object sender, CancelEventArgs e)
        {
            if (saveFileReport.CheckFileExists == true)
            {
                MessageBox.Show("Save fail, file exists : " + saveFileReport.FileName.ToString());
            }
            else {
                ExportReportPath = saveFileReport.FileName.ToString();
                {
                    using (StreamWriter sw = File.AppendText(ExportReportPath))
                    {
                        sw.WriteLine(exReport);
                    }
                }
            }


        }

        private void btloadToday_Click(object sender, EventArgs e)
        {
            dgReport.Rows.Clear();
            dgReport.Refresh();

            Ok = 0;
            NG = 0;
            Total = 0;

            loadReportToday();
        }

    }

    class FillterMan
    {
        public int fromYear, fromMonth, fromDay;
        public int toYear, toMonth, toDay;

        public FillterMan()
        {
            this.fromDay = System.DateTime.Now.Day;
            this.fromMonth = System.DateTime.Now.Month;
            this.fromYear = System.DateTime.Now.Year;
            this.toDay = System.DateTime.Now.Day;
            this.toMonth = System.DateTime.Now.Month;
            this.toYear = System.DateTime.Now.Year;
        }

        public void changeFillterTime(int fromThisDay, int fromThisMonth, int fromThisYear, int toThisDay, int toThisMonth, int toThisYear)
        {
            this.fromDay = fromThisDay;
            this.fromMonth = fromThisMonth;
            this.fromYear = fromThisYear;

            this.toDay = toThisDay;
            this.toMonth = toThisMonth;
            this.toYear = toThisYear;
        }



    }
}

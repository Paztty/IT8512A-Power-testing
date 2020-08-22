using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT8512A_Power_Test
{
    public partial class Form2 : Form
    {
        public static double VolA_H, VolA_L, VolB_H, VolB_L;
        public Form2()
        {
            InitializeComponent();
            ProductindomationInit();
        }


        private void comboBoxProductCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxMaxVol.Text = Form1.productsList[comboBoxProductCode.SelectedIndex].AVoltageLowLevel.ToString();
            textBoxMinVol.Text = Form1.productsList[comboBoxProductCode.SelectedIndex].AVoltageLowLevel.ToString();
        }
        public void ProductindomationInit()
        {
            string[] productNameList = new string[Form1.productsList.Length];
            for (int i = 0; i < Form1.productsList.Length; i++)
            {
                productNameList[i] = Form1.productsList[i].name;
            }
            comboBoxProductCode.DataSource = productNameList;
            textBoxMaxVol.Text = Form1.productsList[comboBoxProductCode.SelectedIndex].AVoltageHighLevel.ToString("F3");
            textBoxMinVol.Text = Form1.productsList[comboBoxProductCode.SelectedIndex].AVoltageLowLevel.ToString("F3");
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBoxMaxVol_TextChanged(object sender, EventArgs e)
        {
            try
            {
                VolA_H = float.Parse(textBoxMaxVol.Text, System.Globalization.NumberStyles.Float);
            }
            catch (Exception String)
            {
                MessageBox.Show(String.Message);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            buttonApply_Click(sender, e);
            this.Close();
            //Form1_Load(sender, e);
        }

        private void textBoxMinVol_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMinVol.Text != String.Empty)
                try
                {
                    VolA_L = float.Parse(textBoxMinVol.Text, System.Globalization.NumberStyles.Float);
                }
                catch (Exception String)
                {
                    MessageBox.Show(String.Message);
                }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (VolA_L >= 0.0)
            {
                Form1.productsList[comboBoxProductCode.SelectedIndex].AVoltageLowLevel = VolA_L;
                Form1.productsList[comboBoxProductCode.SelectedIndex].BVoltageLowLevel = VolA_L;
            }
            else
            {
                MessageBox.Show("Giá trị không phù hợp");
            }


            if (VolA_H >= VolA_L)
            {
                Form1.productsList[comboBoxProductCode.SelectedIndex].AVoltageHighLevel = VolA_H;
                Form1.productsList[comboBoxProductCode.SelectedIndex].BVoltageHighLevel = VolA_H;
            }
            else
            {
                MessageBox.Show("Giá trị không phù hợp");
            }

        }
        private void Form2_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Form1.form2Close = true;
        }

    }
}

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
                textBoxMaxVol.Text = comboBoxProductCode.SelectedIndex.ToString();
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
            textBoxMaxVol.Text = Form1.productsList[comboBoxProductCode.SelectedIndex].AVoltageHighLevel.ToString();
            textBoxMinVol.Text = Form1.productsList[comboBoxProductCode.SelectedIndex].AVoltageLowLevel.ToString();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBoxMaxVol_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMaxVol.Text != String.Empty)
                VolA_H = float.Parse(textBoxMaxVol.Text);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            buttonApply_Click(sender, e);
            this.Close();
        }

        private void textBoxMinVol_TextChanged(object sender, EventArgs e)
        {
            if(textBoxMinVol.Text != String.Empty)
                VolA_L = float.Parse(textBoxMinVol.Text);
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
    }
}

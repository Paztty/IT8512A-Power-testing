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

namespace IT8512A_Power_Test
{
    public partial class Form5 : Form
    {
        public productCode product_code = new productCode();
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            bool addValueOk = true;
            product_code.name = tbproductCodeName.Text;
            product_code.Number_chanel = (uint)numericUpDown1.Value;
            try
            {
                product_code.AVoltageLowLevel = Convert.ToDouble(textBoxMinVol.Text);
                product_code.BVoltageLowLevel = Convert.ToDouble(textBoxMinVol.Text);
                product_code.AVoltageHighLevel = Convert.ToDouble(textBoxMaxVol.Text);
                product_code.BVoltageHighLevel = Convert.ToDouble(textBoxMaxVol.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Giá trị không phù hợp");
                addValueOk = false;
            }

            if(tbproductCodeName.Text == null) addValueOk = false;
            if (product_code.AVoltageHighLevel < product_code.AVoltageLowLevel)
            {
                MessageBox.Show("Giá trị không phù hợp");
                addValueOk = false;
            }
            if (product_code.AVoltageHighLevel < 0.0)
            {
                MessageBox.Show("Giá trị không phù hợp");
                addValueOk = false;
            }
            if (product_code.AVoltageLowLevel < 0.0)
            {
                MessageBox.Show("Giá trị không phù hợp");
                addValueOk = false;
            }
            if (addValueOk)
            {
                string modelData = product_code.name + ","
                                    + product_code.AVoltageHighLevel.ToString("f2") + ","
                                    + product_code.AVoltageLowLevel.ToString("f2") + ","
                                    + product_code.BVoltageHighLevel.ToString("f2") + ","
                                    + product_code.BVoltageLowLevel.ToString("f2") + ","
                                    + product_code.Number_chanel + Environment.NewLine;
                File.AppendAllText(@"C:\Charger DC Tester\Model\model.txt", modelData);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void tbproductCodeName_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

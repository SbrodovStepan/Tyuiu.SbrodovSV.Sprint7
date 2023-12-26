using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project.V10
{
    public partial class FormClients_SSV : Form
    {
        public FormClients_SSV()
        {
            InitializeComponent();
        }
        decimal sum = 0;
        int last1 = 0, last2 = 0, last3 = 0;
        string text = "", price = "", colvo = "";
        private void toolStripMenuItemExit_SSV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItemAbout_SSV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void toolStripMenuItemInstruction_SSV_Click(object sender, EventArgs e)
        {
            FormInstruction formInstruction = new FormInstruction();
            formInstruction.ShowDialog();
        }

        private void radioButtonTovar1_SSV_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTovar1_SSV.Checked == true)
            {
                numericUpDownTovar1_SSV.Enabled = true;
                sum += 30000 * numericUpDownTovar1_SSV.Value;
                textBoxLastPrice_SSV.Text = sum.ToString();
                text = radioButtonTovar1_SSV.Text;
                price = textBoxPrice1_SSV.Text;
            }
            else
            {
                numericUpDownTovar1_SSV.Enabled = false;
                sum -= 30000 * numericUpDownTovar1_SSV.Value;
                textBoxLastPrice_SSV.Text = sum.ToString();
            }
        }

        private void radioButtonTovar2_SSV_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTovar2_SSV.Checked == true)
            {
                numericUpDownTovar2_SSV.Enabled = true;
                sum += 16000 * numericUpDownTovar2_SSV.Value;
                textBoxLastPrice_SSV.Text = sum.ToString();
                text = radioButtonTovar2_SSV.Text;
                price = textBoxPrice2_SSV.Text;
            }
            else
            {
                numericUpDownTovar2_SSV.Enabled = false;
                sum -= 16000 * numericUpDownTovar2_SSV.Value;
                textBoxLastPrice_SSV.Text = sum.ToString();
            }
        }

        private void radioButtonTovar3_SSV_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTovar3_SSV.Checked == true)
            {
                numericUpDownTovar3_SSV.Enabled = true;
                sum += 600 * numericUpDownTovar3_SSV.Value;
                textBoxLastPrice_SSV.Text = sum.ToString();
                text = radioButtonTovar3_SSV.Text;
                price = textBoxPrice3_SSV.Text;
            }
            else
            {
                numericUpDownTovar3_SSV.Enabled = false;
                sum -= 600 * numericUpDownTovar3_SSV.Value;
                textBoxLastPrice_SSV.Text = sum.ToString();
            }
        }

        private void numericUpDownTovar3_SSV_ValueChanged(object sender, EventArgs e)
        {
            sum = numericUpDownTovar3_SSV.Value > last3 ? sum + 600 : sum - 600;
            textBoxLastPrice_SSV.Text = sum.ToString();
            last3 = (int)numericUpDownTovar3_SSV.Value;
            colvo = numericUpDownTovar3_SSV.Text;
        }

        private void buttonDoOrder_SSV_Click(object sender, EventArgs e)
        {
            FormWorkers_SSV formWorkers_SSV = new FormWorkers_SSV();
            Random random = new Random();
            string numberOrder = random.Next(00000000,99999999).ToString();
            while (numberOrder.Length < 8)
            {
                numberOrder = "0" + numberOrder;
            }
            if (colvo != "")
            {
                colvo = (int.Parse(colvo) + 1).ToString();
                formWorkers_SSV.AddRowToDataGridView(numberOrder, dateTimePickerOrderEnd_SSV.Text, textBoxLastPrice_SSV.Text, text, price, colvo);
                formWorkers_SSV.buttonDownload_SSV();
            }
        }

        private void numericUpDownTovar1_SSV_ValueChanged(object sender, EventArgs e)
        {
            sum = numericUpDownTovar1_SSV.Value > last1 ? sum + 30000 : sum - 30000;
            textBoxLastPrice_SSV.Text = sum.ToString();
            last1 = (int)numericUpDownTovar1_SSV.Value;
            colvo = numericUpDownTovar1_SSV.Text;
        }

        private void numericUpDownTovar2_SSV_ValueChanged(object sender, EventArgs e)
        {
            sum = numericUpDownTovar2_SSV.Value > last2 ? sum + 16000 : sum - 16000;
            textBoxLastPrice_SSV.Text = sum.ToString();
            last2 = (int)numericUpDownTovar2_SSV.Value;
            colvo = numericUpDownTovar2_SSV.Text;
        }
    }
}
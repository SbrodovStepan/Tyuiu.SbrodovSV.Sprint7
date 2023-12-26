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
        public FormClients_SSV(FormMain_SSV formMain_SSV)
        {
            InitializeComponent();
        }
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

        private void checkBoxTovar1_SSV_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBoxTovar1_SSV.CheckState)
            {
                case CheckState.Checked:
                    numericUpDownTovar1_SSV.Enabled = true;
                    sum += 30000 * numericUpDownTovar1_SSV.Value;
                    textBoxLastPrice_SSV.Text = sum.ToString();
                    break;
                case CheckState.Unchecked:
                    numericUpDownTovar1_SSV.Enabled = false;
                    sum -= 30000 * numericUpDownTovar1_SSV.Value;
                    textBoxLastPrice_SSV.Text = sum.ToString();
                    break;
                case CheckState.Indeterminate:  
                    break;
            }
        }

        private void checkBoxTovar2_SSV_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBoxTovar2_SSV.CheckState)
            {
                case CheckState.Checked:
                    numericUpDownTovar2_SSV.Enabled = true;
                    sum += 16000 * numericUpDownTovar2_SSV.Value;
                    textBoxLastPrice_SSV.Text = sum.ToString();
                    break;
                case CheckState.Unchecked:
                    numericUpDownTovar2_SSV.Enabled = false;
                    sum -= 16000 * numericUpDownTovar2_SSV.Value;
                    textBoxLastPrice_SSV.Text = sum.ToString();
                    break;
                case CheckState.Indeterminate:
                    break;
            }
        }

        private void checkBoxTovar3_SSV_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBoxTovar3_SSV.CheckState)
            {
                case CheckState.Checked:
                    numericUpDownTovar3_SSV.Enabled = true;
                    sum += 600 * numericUpDownTovar3_SSV.Value;
                    textBoxLastPrice_SSV.Text = sum.ToString();
                    break;
                case CheckState.Unchecked:
                    numericUpDownTovar3_SSV.Enabled = false;
                    sum -= 600 * numericUpDownTovar3_SSV.Value;
                    textBoxLastPrice_SSV.Text = sum.ToString();
                    break;
                case CheckState.Indeterminate:
                    break;
            }
        }
        int last1 = 0, last2 = 0, last3 = 0;

        private void numericUpDownTovar3_SSV_ValueChanged(object sender, EventArgs e)
        {
            sum = numericUpDownTovar3_SSV.Value > last3 ? sum + 600 : sum - 600;
            textBoxLastPrice_SSV.Text = sum.ToString();
            last3 = (int)numericUpDownTovar2_SSV.Value;
        }

        private void buttonDoOrder_SSV_Click(object sender, EventArgs e)
        {
            FormWorkers_SSV formWorkers_SSV = new FormWorkers_SSV();
            
        }

        private void numericUpDownTovar1_SSV_ValueChanged(object sender, EventArgs e)
        {
            sum = numericUpDownTovar1_SSV.Value > last1 ? sum + 30000 : sum - 30000;
            textBoxLastPrice_SSV.Text = sum.ToString();
            last1 = (int)numericUpDownTovar1_SSV.Value;
        }

        private void numericUpDownTovar2_SSV_ValueChanged(object sender, EventArgs e)
        {
            sum = numericUpDownTovar2_SSV.Value > last2 ? sum + 16000 : sum - 16000;
            textBoxLastPrice_SSV.Text = sum.ToString();
            last2 = (int)numericUpDownTovar2_SSV.Value;
        }
    }
}
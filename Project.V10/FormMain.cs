using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Button buttonGoToOrder = new Button();
            buttonGoToOrder.BackColor = SystemColors.Control;
            buttonGoToOrder.Location = new Point(700, 300);
            this.Controls.Add(buttonGoToOrder);
        }
    }
}

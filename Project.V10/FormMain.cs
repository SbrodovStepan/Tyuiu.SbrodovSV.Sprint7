using Project.V10.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V10
{
    public partial class FormMain_SSV : Form
    {
        public FormMain_SSV()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        int cols, rows;

        private void aboutProgramToolStripMenuItem_SSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта программа содержит в себе данные:\r* О заказах клиентов(Номер заказа, дата исполнения, стоимость заказа, название товара, цена, количество)", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_SSV_Click(object sender, EventArgs e)
        {
            openFileDialogTable_SSV.ShowDialog();
            openFilePath = openFileDialogTable_SSV.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewTableOrders_SSV.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewTableOrders_SSV.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewTableOrders_SSV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            if (dataGridViewTableOrders_SSV.Rows.Count != 0) { buttonRemoveRows_SSV.Enabled = true; }
        }

        private void buttonDownload_SSV_Click(object sender, EventArgs e)
        {
            saveFileDialogTable_SSV.FileName = "DataBase.csv";
            saveFileDialogTable_SSV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTable_SSV.ShowDialog();

            
            string path = saveFileDialogTable_SSV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewTableOrders_SSV.RowCount;
            int columns = dataGridViewTableOrders_SSV.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewTableOrders_SSV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewTableOrders_SSV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }


        private void buttonAdd_SSV_Click(object sender, EventArgs e)
        {
            dataGridViewTableOrders_SSV.Rows.Add();
            buttonRemoveRows_SSV.Enabled = true;
        }

        private void buttonInfo_SSV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void toolStripMenuItemExit_SSV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRemoveRows_SSV_Click(object sender, EventArgs e)
        {
            int ind = dataGridViewTableOrders_SSV.SelectedCells[0].RowIndex;
            dataGridViewTableOrders_SSV.Rows.RemoveAt(ind);
            if (dataGridViewTableOrders_SSV.Rows.Count == 0) { buttonRemoveRows_SSV.Enabled = false; }
        }

        private void buttonSearch_SSV_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewTableOrders_SSV.RowCount; i++)
            {
                dataGridViewTableOrders_SSV.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewTableOrders_SSV.ColumnCount; j++)
                    if (dataGridViewTableOrders_SSV.Rows[i].Cells[j].Value != null)
                        if (dataGridViewTableOrders_SSV.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch_SSV.Text))
                        {
                            dataGridViewTableOrders_SSV.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void buttonFilter_SSV_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridViewTableOrders_SSV.Rows)
            {
                if ((r.Cells[comboBoxColsNames_SSV.SelectedIndex - 1].Value).ToString().ToUpper().Contains(textBoxFilter_SSV.Text.ToUpper()))
                {
                    dataGridViewTableOrders_SSV.Rows[r.Index].Visible = true;
                    dataGridViewTableOrders_SSV.Rows[r.Index].Selected = true;
                }
                else
                {
                    dataGridViewTableOrders_SSV.CurrentCell = null;
                    dataGridViewTableOrders_SSV.Rows[r.Index].Visible = false;
                }
            }
        }

        private void textBoxSearch_SSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxColsNames_SSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxColsNames_SSV.SelectedIndex != 0)
            {
                textBoxFilter_SSV.Enabled = true;
                buttonFilter_SSV.Enabled = true;
            }
            else
            {
                textBoxFilter_SSV.Enabled = false;
                buttonFilter_SSV.Enabled = false;
            }
        }

        private void dataGridViewTable_SSV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.dataGridViewTableOrders_SSV.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridViewTableOrders_SSV.Rows[index].HeaderCell.Value = indexStr;
        }
    }
}

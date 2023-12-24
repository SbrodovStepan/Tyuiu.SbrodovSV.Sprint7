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

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridViewTableOrders_SSV.DataSource;
            bs.Filter = dataGridViewTableOrders_SSV.Columns[5].HeaderText.ToString() + " LIKE '%" + textBox1.Text + "%'";
            dataGridViewTableOrders_SSV.DataSource = bs;
        }

        private void textBoxSearch_SSV_TextChanged(object sender, EventArgs e)
        {

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

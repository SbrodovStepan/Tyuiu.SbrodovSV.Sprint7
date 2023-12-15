using Project.V10.Lib;
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

        private void exitToolStripMenuItem_SSV_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutProgramToolStripMenuItem_SSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта программа содержит в себе данные:\r* О клиентах магазина(ФИО, номер счёта, адрес проживания, номер телефона)\r* О заказах клиентов(Номер заказа, дата исполнения, стоимость заказа, название товара, цена, количество)", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_SSV_Click(object sender, EventArgs e)
        {
            openFileDialogTable_SSV.ShowDialog();
            openFilePath = openFileDialogTable_SSV.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewTable_SSV.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewTable_SSV.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    dataGridViewTable_SSV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (arrayValues[i, 3] == "True")
                    dataGridViewTable_SSV.Rows[i].Cells[3].Value = true;
                else
                    dataGridViewTable_SSV.Rows[i].Cells[3].Value = false;
            }
        }

        private void buttonDownload_SSV_Click(object sender, EventArgs e)
        {
            saveFileDialogTable_SSV.FileName = "OutPutFileTask7.csv";
            saveFileDialogTable_SSV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTable_SSV.ShowDialog();

            string path = saveFileDialogTable_SSV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewTable_SSV.RowCount;
            int columns = dataGridViewTable_SSV.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewTable_SSV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewTable_SSV.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonAdd_SSV_Click(object sender, EventArgs e)
        {
            dataGridViewTable_SSV.Rows.Add();
        }

        private void buttonInfo_SSV_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTable_SSV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.dataGridViewTable_SSV.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridViewTable_SSV.Rows[index].HeaderCell.Value = indexStr;
        }
    }
}

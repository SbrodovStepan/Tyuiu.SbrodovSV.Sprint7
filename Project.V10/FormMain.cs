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
            MessageBox.Show("Эта программа содержит в себе данные:\r* О клиентах магазина(ФИО, номер счёта, адрес проживания, номер телефона)\r* О заказах клиентов(Номер заказа, дата исполнения, стоимость заказа, название товара, цена, количество)", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_SSV_Click(object sender, EventArgs e)
        {
            openFileDialogTable_SSV.ShowDialog();
            openFilePath = openFileDialogTable_SSV.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            switch (tabControl_SSV.SelectedIndex)
            {
                case 0:
                    dataGridViewTableClients_SSV.ColumnCount = cols = arrayValues.GetLength(1);
                    dataGridViewTableClients_SSV.RowCount = rows = arrayValues.GetLength(0);

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            dataGridViewTableClients_SSV.Rows[i].Cells[j].Value = arrayValues[i, j];
                        }
                    }
                    break;
                case 1:
                    dataGridViewTableOrders_SSV.ColumnCount = cols = arrayValues.GetLength(1);
                    dataGridViewTableOrders_SSV.RowCount = rows = arrayValues.GetLength(0);

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            dataGridViewTableOrders_SSV.Rows[i].Cells[j].Value = arrayValues[i, j];
                        }
                    }
                    break;
                default:
                    break;
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
            
            switch (tabControl_SSV.SelectedIndex)
            {
                case 0:
                    int rows = dataGridViewTableClients_SSV.RowCount;
                    int columns = dataGridViewTableClients_SSV.ColumnCount;
                    string str = "";

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            if (j != columns - 1)
                            {
                                str = str + dataGridViewTableClients_SSV.Rows[i].Cells[j].Value + ";";
                            }
                            else
                            {
                                str = str + dataGridViewTableClients_SSV.Rows[i].Cells[j].Value;
                            }
                        }

                        File.AppendAllText(path, str + Environment.NewLine);
                        str = "";
                    }
                    break;
                case 1:
                    rows = dataGridViewTableOrders_SSV.RowCount;
                    columns = dataGridViewTableOrders_SSV.ColumnCount;
                    str = "";

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
                    break;
                default:
                    break;

            }
        }

        private void buttonAdd_SSV_Click(object sender, EventArgs e)
        {
            switch(tabControl_SSV.SelectedIndex) 
            {
                case 0:
                    dataGridViewTableClients_SSV.Rows.Add();
                    break;
                case 1:
                    dataGridViewTableOrders_SSV.Rows.Add();
                    break;
                default:
                    break;
            }
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

        private void dataGridViewTable_SSV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            switch (tabControl_SSV.SelectedIndex)
            {
                case 0:
                    int index = e.RowIndex;
                    string indexStr = (index + 1).ToString();
                    object header = this.dataGridViewTableClients_SSV.Rows[index].HeaderCell.Value;
                    if (header == null || !header.Equals(indexStr))
                        this.dataGridViewTableClients_SSV.Rows[index].HeaderCell.Value = indexStr;
                    break;
                case 1:
                    index = e.RowIndex;
                    indexStr = (index + 1).ToString();
                    header = this.dataGridViewTableOrders_SSV.Rows[index].HeaderCell.Value;
                    if (header == null || !header.Equals(indexStr))
                        this.dataGridViewTableOrders_SSV.Rows[index].HeaderCell.Value = indexStr;
                    break;
                default:
                    break;
            }

        }
    }
}

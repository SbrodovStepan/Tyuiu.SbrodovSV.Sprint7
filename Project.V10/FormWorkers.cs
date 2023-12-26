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
using System.Windows.Forms.DataVisualization.Charting;

namespace Project.V10
{
    public partial class FormWorkers_SSV : Form
    {
        public FormWorkers_SSV()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        int cols, rows;

        private void buttonOpen_SSV_Click(object sender, EventArgs e)
        {
            try
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
            catch { }
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

        public void buttonDownload_SSV()
        {
            string path = $@"{Directory.GetCurrentDirectory()}\DataBase.csv";

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

        private void buttonFilter_SSV_Click(object sender, EventArgs e)
        {
            comboBoxColsNames_SSV.GetItemText(comboBoxColsNames_SSV.SelectedIndex);
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

        private void button1_Click(object sender, EventArgs e)
        {
            chartStats_SSV.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Популярность товаров");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (DataGridViewRow row in this.dataGridViewTableOrders_SSV.Rows)
            {
                if (!row.IsNewRow && row.Cells[5] != null && row.Cells[5].Value != null)
                {
                    string label = row.Cells[3].Value.ToString();
                    double hours = Convert.ToDouble(row.Cells[5].Value);
                    series.Points.AddXY(label, hours);
                }
            }
            this.chartStats_SSV.Series.Add(series);
        }

        private void toolStripMenuItemInstruction_SSV_Click(object sender, EventArgs e)
        {
            FormInstruction formInstruction = new FormInstruction();
            formInstruction.ShowDialog();
        }

        private void textBoxSearch_SSV_TextChanged_1(object sender, EventArgs e)
        {
            if (textBoxSearch_SSV != null)
            {
                string currentText = textBoxSearch_SSV.Text;
                foreach (DataGridViewRow row in dataGridViewTableOrders_SSV.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && textBoxSearch_SSV.Text != string.Empty && cell.Value.ToString().Contains(textBoxSearch_SSV.Text))
                        {
                            cell.Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void toolStripTextBoxSearch_SSV_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBoxSearch_SSV != null)
            {
                string currentText = toolStripTextBoxSearch_SSV.Text;
                foreach (DataGridViewRow row in dataGridViewTableOrders_SSV.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && toolStripTextBoxSearch_SSV.Text != string.Empty && cell.Value.ToString().Contains(toolStripTextBoxSearch_SSV.Text))
                        {
                            cell.Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void buttonGetProfit_SSV_Click(object sender, EventArgs e)
        {
            double sum = 0;
            foreach (DataGridViewRow row in this.dataGridViewTableOrders_SSV.Rows)
            {
                if (!row.IsNewRow && row.Cells[2] != null && row.Cells[2].Value != null)
                {
                    sum += Convert.ToDouble(row.Cells[2].Value);
                }
            }
            textBoxSum_SSV.Text = sum.ToString();
        }

        private void buttonGetAVG_SSV_Click(object sender, EventArgs e)
        {
            int count = 0;
            double sum = 0;
            foreach (DataGridViewRow row in this.dataGridViewTableOrders_SSV.Rows)
            {
                count += 1;
                if (!row.IsNewRow && row.Cells[2] != null && row.Cells[2].Value != null)
                {
                    sum += Convert.ToDouble(row.Cells[2].Value);
                }
            }
            textBoxAVG_SSV.Text = (sum/count).ToString();
        }

        private void buttonGetMinSum_SSV_Click(object sender, EventArgs e)
        {
            double min = double.MaxValue;
            foreach (DataGridViewRow row in this.dataGridViewTableOrders_SSV.Rows)
            {
                if (!row.IsNewRow && row.Cells[2] != null && row.Cells[2].Value != null && min > Convert.ToDouble(row.Cells[2].Value))
                {
                    min = Convert.ToDouble(row.Cells[2].Value);
                }
            }
            textBoxMinSum_SSV.Text = min.ToString();
        }

        private void buttonMaxSum_SSV_Click(object sender, EventArgs e)
        {
            double max = double.MinValue;
            foreach (DataGridViewRow row in this.dataGridViewTableOrders_SSV.Rows)
            {
                if (!row.IsNewRow && row.Cells[2] != null && row.Cells[2].Value != null && max < Convert.ToDouble(row.Cells[2].Value))
                {
                    max = Convert.ToDouble(row.Cells[2].Value);
                }
            }
            textBoxMaxSum_SSV.Text = max.ToString();
        }
        public void AddRowToDataGridView(string value1, string value2, string value3, string value4, string value5, string value6)
        {
            try
            {
                openFilePath = $@"{Directory.GetCurrentDirectory()}\DataBase.csv";

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
                dataGridViewTableOrders_SSV.Rows.Add(value1, value2, value3, value4, value5, value6);
            }
            catch { dataGridViewTableOrders_SSV.Rows.Add(value1, value2, value3, value4, value5, value6); }
        }

        private void FormWorkers_SSV_Load(object sender, EventArgs e)
        {
            try
            {
                openFilePath = $@"{Directory.GetCurrentDirectory()}\DataBase.csv";

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
            catch { };
        }

        private void FormWorkers_SSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonDownload_SSV();
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

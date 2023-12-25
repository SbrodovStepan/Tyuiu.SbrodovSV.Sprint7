namespace Project.V10
{
    partial class FormWorkers_SSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.saveFileDialogTable_SSV = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTable_SSV = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip_SSV = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdd_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxSearch_SSV = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItemInfo_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInstruction_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageStats_SSV = new System.Windows.Forms.TabPage();
            this.buttonGetStats_SSV = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageOrderData_SSV = new System.Windows.Forms.TabPage();
            this.dataGridViewTableOrders_SSV = new System.Windows.Forms.DataGridView();
            this.NumberOrder_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDone_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOrder_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOrder_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxMovesOrders_SSV = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxColsNames_SSV = new System.Windows.Forms.ComboBox();
            this.labelSearch_SSV = new System.Windows.Forms.Label();
            this.textBoxFilter_SSV = new System.Windows.Forms.TextBox();
            this.textBoxSearch_SSV = new System.Windows.Forms.TextBox();
            this.buttonOpenOrder_SSV = new System.Windows.Forms.Button();
            this.buttonRemoveRows_SSV = new System.Windows.Forms.Button();
            this.buttonFilter_SSV = new System.Windows.Forms.Button();
            this.buttonAddOrders_SSV = new System.Windows.Forms.Button();
            this.buttonDownloadOrders_SSV = new System.Windows.Forms.Button();
            this.tabControl_SSV = new System.Windows.Forms.TabControl();
            this.menuStrip_SSV.SuspendLayout();
            this.tabPageStats_SSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPageOrderData_SSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableOrders_SSV)).BeginInit();
            this.groupBoxMovesOrders_SSV.SuspendLayout();
            this.tabControl_SSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogTable_SSV
            // 
            this.openFileDialogTable_SSV.FileName = "openFileDialog1";
            // 
            // menuStrip_SSV
            // 
            this.menuStrip_SSV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile_SSV,
            this.SearchToolStripMenuItem_SSV,
            this.toolStripMenuItemInfo_SSV,
            this.toolStripMenuItemExit_SSV});
            this.menuStrip_SSV.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_SSV.Name = "menuStrip_SSV";
            this.menuStrip_SSV.Size = new System.Drawing.Size(1093, 24);
            this.menuStrip_SSV.TabIndex = 4;
            this.menuStrip_SSV.Text = "menuStrip1";
            // 
            // toolStripMenuFile_SSV
            // 
            this.toolStripMenuFile_SSV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd_SSV,
            this.toolStripMenuItemOpen_SSV,
            this.toolStripMenuItemSave_SSV});
            this.toolStripMenuFile_SSV.Name = "toolStripMenuFile_SSV";
            this.toolStripMenuFile_SSV.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuFile_SSV.Text = "Файл";
            // 
            // toolStripMenuItemAdd_SSV
            // 
            this.toolStripMenuItemAdd_SSV.Name = "toolStripMenuItemAdd_SSV";
            this.toolStripMenuItemAdd_SSV.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItemAdd_SSV.Text = "Добавить";
            this.toolStripMenuItemAdd_SSV.Click += new System.EventHandler(this.buttonAdd_SSV_Click);
            // 
            // toolStripMenuItemOpen_SSV
            // 
            this.toolStripMenuItemOpen_SSV.Name = "toolStripMenuItemOpen_SSV";
            this.toolStripMenuItemOpen_SSV.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItemOpen_SSV.Text = "Открыть";
            this.toolStripMenuItemOpen_SSV.Click += new System.EventHandler(this.buttonOpen_SSV_Click);
            // 
            // toolStripMenuItemSave_SSV
            // 
            this.toolStripMenuItemSave_SSV.Name = "toolStripMenuItemSave_SSV";
            this.toolStripMenuItemSave_SSV.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItemSave_SSV.Text = "Сохранить";
            this.toolStripMenuItemSave_SSV.Click += new System.EventHandler(this.buttonDownload_SSV_Click);
            // 
            // SearchToolStripMenuItem_SSV
            // 
            this.SearchToolStripMenuItem_SSV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxSearch_SSV});
            this.SearchToolStripMenuItem_SSV.Name = "SearchToolStripMenuItem_SSV";
            this.SearchToolStripMenuItem_SSV.Size = new System.Drawing.Size(53, 20);
            this.SearchToolStripMenuItem_SSV.Text = "Найти";
            // 
            // toolStripTextBoxSearch_SSV
            // 
            this.toolStripTextBoxSearch_SSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxSearch_SSV.Name = "toolStripTextBoxSearch_SSV";
            this.toolStripTextBoxSearch_SSV.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxSearch_SSV.TextChanged += new System.EventHandler(this.toolStripTextBoxSearch_SSV_TextChanged);
            // 
            // toolStripMenuItemInfo_SSV
            // 
            this.toolStripMenuItemInfo_SSV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemInstruction_SSV,
            this.toolStripMenuItemAbout_SSV});
            this.toolStripMenuItemInfo_SSV.Name = "toolStripMenuItemInfo_SSV";
            this.toolStripMenuItemInfo_SSV.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItemInfo_SSV.Text = "Справка";
            // 
            // toolStripMenuItemInstruction_SSV
            // 
            this.toolStripMenuItemInstruction_SSV.Name = "toolStripMenuItemInstruction_SSV";
            this.toolStripMenuItemInstruction_SSV.Size = new System.Drawing.Size(268, 22);
            this.toolStripMenuItemInstruction_SSV.Text = "Краткое руководство пользователя";
            this.toolStripMenuItemInstruction_SSV.Click += new System.EventHandler(this.toolStripMenuItemInstruction_SSV_Click);
            // 
            // toolStripMenuItemAbout_SSV
            // 
            this.toolStripMenuItemAbout_SSV.Name = "toolStripMenuItemAbout_SSV";
            this.toolStripMenuItemAbout_SSV.Size = new System.Drawing.Size(268, 22);
            this.toolStripMenuItemAbout_SSV.Text = "О программе ";
            this.toolStripMenuItemAbout_SSV.Click += new System.EventHandler(this.buttonInfo_SSV_Click);
            // 
            // toolStripMenuItemExit_SSV
            // 
            this.toolStripMenuItemExit_SSV.Name = "toolStripMenuItemExit_SSV";
            this.toolStripMenuItemExit_SSV.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItemExit_SSV.Text = "Выход";
            this.toolStripMenuItemExit_SSV.Click += new System.EventHandler(this.toolStripMenuItemExit_SSV_Click);
            // 
            // tabPageStats_SSV
            // 
            this.tabPageStats_SSV.Controls.Add(this.buttonGetStats_SSV);
            this.tabPageStats_SSV.Controls.Add(this.chart1);
            this.tabPageStats_SSV.Location = new System.Drawing.Point(4, 22);
            this.tabPageStats_SSV.Name = "tabPageStats_SSV";
            this.tabPageStats_SSV.Size = new System.Drawing.Size(1085, 525);
            this.tabPageStats_SSV.TabIndex = 2;
            this.tabPageStats_SSV.Text = "Статистика";
            this.tabPageStats_SSV.UseVisualStyleBackColor = true;
            // 
            // buttonGetStats_SSV
            // 
            this.buttonGetStats_SSV.Location = new System.Drawing.Point(8, 336);
            this.buttonGetStats_SSV.Name = "buttonGetStats_SSV";
            this.buttonGetStats_SSV.Size = new System.Drawing.Size(170, 39);
            this.buttonGetStats_SSV.TabIndex = 1;
            this.buttonGetStats_SSV.Text = "Получить статистику по популярным товарам";
            this.buttonGetStats_SSV.UseVisualStyleBackColor = true;
            this.buttonGetStats_SSV.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(8, 3);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(475, 327);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPageOrderData_SSV
            // 
            this.tabPageOrderData_SSV.Controls.Add(this.dataGridViewTableOrders_SSV);
            this.tabPageOrderData_SSV.Controls.Add(this.groupBoxMovesOrders_SSV);
            this.tabPageOrderData_SSV.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrderData_SSV.Name = "tabPageOrderData_SSV";
            this.tabPageOrderData_SSV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrderData_SSV.Size = new System.Drawing.Size(1085, 525);
            this.tabPageOrderData_SSV.TabIndex = 1;
            this.tabPageOrderData_SSV.Text = "База данных по заказам";
            this.tabPageOrderData_SSV.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTableOrders_SSV
            // 
            this.dataGridViewTableOrders_SSV.AllowUserToAddRows = false;
            this.dataGridViewTableOrders_SSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTableOrders_SSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTableOrders_SSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberOrder_SSV,
            this.DateDone_SSV,
            this.PriceOrder_SSV,
            this.NameOrder_SSV,
            this.Price_SSV,
            this.Quantity_SSV});
            this.dataGridViewTableOrders_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTableOrders_SSV.Location = new System.Drawing.Point(183, 3);
            this.dataGridViewTableOrders_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTableOrders_SSV.Name = "dataGridViewTableOrders_SSV";
            this.dataGridViewTableOrders_SSV.RowHeadersWidth = 51;
            this.dataGridViewTableOrders_SSV.RowTemplate.Height = 24;
            this.dataGridViewTableOrders_SSV.Size = new System.Drawing.Size(899, 519);
            this.dataGridViewTableOrders_SSV.TabIndex = 1;
            this.dataGridViewTableOrders_SSV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewTable_SSV_RowPrePaint);
            // 
            // NumberOrder_SSV
            // 
            this.NumberOrder_SSV.HeaderText = "Номер заказа";
            this.NumberOrder_SSV.MinimumWidth = 6;
            this.NumberOrder_SSV.Name = "NumberOrder_SSV";
            // 
            // DateDone_SSV
            // 
            this.DateDone_SSV.HeaderText = "Дата исполнения";
            this.DateDone_SSV.MinimumWidth = 6;
            this.DateDone_SSV.Name = "DateDone_SSV";
            this.DateDone_SSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PriceOrder_SSV
            // 
            this.PriceOrder_SSV.HeaderText = "Стоимость заказа";
            this.PriceOrder_SSV.MinimumWidth = 6;
            this.PriceOrder_SSV.Name = "PriceOrder_SSV";
            // 
            // NameOrder_SSV
            // 
            this.NameOrder_SSV.HeaderText = "Название товара";
            this.NameOrder_SSV.MinimumWidth = 6;
            this.NameOrder_SSV.Name = "NameOrder_SSV";
            this.NameOrder_SSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameOrder_SSV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price_SSV
            // 
            this.Price_SSV.HeaderText = "Цена товара";
            this.Price_SSV.Name = "Price_SSV";
            // 
            // Quantity_SSV
            // 
            this.Quantity_SSV.HeaderText = "Количество товаров";
            this.Quantity_SSV.Name = "Quantity_SSV";
            // 
            // groupBoxMovesOrders_SSV
            // 
            this.groupBoxMovesOrders_SSV.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxMovesOrders_SSV.Controls.Add(this.label2);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.label1);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.comboBoxColsNames_SSV);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.labelSearch_SSV);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.textBoxFilter_SSV);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.textBoxSearch_SSV);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.buttonOpenOrder_SSV);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.buttonRemoveRows_SSV);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.buttonFilter_SSV);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.buttonAddOrders_SSV);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.buttonDownloadOrders_SSV);
            this.groupBoxMovesOrders_SSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxMovesOrders_SSV.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMovesOrders_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMovesOrders_SSV.Name = "groupBoxMovesOrders_SSV";
            this.groupBoxMovesOrders_SSV.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMovesOrders_SSV.Size = new System.Drawing.Size(180, 519);
            this.groupBoxMovesOrders_SSV.TabIndex = 4;
            this.groupBoxMovesOrders_SSV.TabStop = false;
            this.groupBoxMovesOrders_SSV.Text = "Действия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Напишите нужное слово";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите столбец";
            // 
            // comboBoxColsNames_SSV
            // 
            this.comboBoxColsNames_SSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColsNames_SSV.FormattingEnabled = true;
            this.comboBoxColsNames_SSV.Items.AddRange(new object[] {
            "",
            "Номер заказа",
            "Дата исполнения",
            "Стоимость заказа",
            "Название товара",
            "Цена товара",
            "Количество товаров"});
            this.comboBoxColsNames_SSV.Location = new System.Drawing.Point(5, 295);
            this.comboBoxColsNames_SSV.Name = "comboBoxColsNames_SSV";
            this.comboBoxColsNames_SSV.Size = new System.Drawing.Size(167, 21);
            this.comboBoxColsNames_SSV.TabIndex = 3;
            this.comboBoxColsNames_SSV.SelectedIndexChanged += new System.EventHandler(this.comboBoxColsNames_SSV_SelectedIndexChanged);
            // 
            // labelSearch_SSV
            // 
            this.labelSearch_SSV.AutoSize = true;
            this.labelSearch_SSV.Location = new System.Drawing.Point(1, 187);
            this.labelSearch_SSV.Name = "labelSearch_SSV";
            this.labelSearch_SSV.Size = new System.Drawing.Size(148, 13);
            this.labelSearch_SSV.TabIndex = 2;
            this.labelSearch_SSV.Text = "Введите объект для поиска\r\n";
            // 
            // textBoxFilter_SSV
            // 
            this.textBoxFilter_SSV.Enabled = false;
            this.textBoxFilter_SSV.Location = new System.Drawing.Point(5, 335);
            this.textBoxFilter_SSV.Name = "textBoxFilter_SSV";
            this.textBoxFilter_SSV.Size = new System.Drawing.Size(168, 20);
            this.textBoxFilter_SSV.TabIndex = 1;
            // 
            // textBoxSearch_SSV
            // 
            this.textBoxSearch_SSV.Location = new System.Drawing.Point(3, 203);
            this.textBoxSearch_SSV.Name = "textBoxSearch_SSV";
            this.textBoxSearch_SSV.Size = new System.Drawing.Size(168, 20);
            this.textBoxSearch_SSV.TabIndex = 1;
            this.textBoxSearch_SSV.TextChanged += new System.EventHandler(this.textBoxSearch_SSV_TextChanged_1);
            // 
            // buttonOpenOrder_SSV
            // 
            this.buttonOpenOrder_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenOrder_SSV.Location = new System.Drawing.Point(4, 17);
            this.buttonOpenOrder_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenOrder_SSV.Name = "buttonOpenOrder_SSV";
            this.buttonOpenOrder_SSV.Size = new System.Drawing.Size(170, 39);
            this.buttonOpenOrder_SSV.TabIndex = 0;
            this.buttonOpenOrder_SSV.Text = "Открыть базу данных по заказам";
            this.buttonOpenOrder_SSV.UseVisualStyleBackColor = true;
            this.buttonOpenOrder_SSV.Click += new System.EventHandler(this.buttonOpen_SSV_Click);
            // 
            // buttonRemoveRows_SSV
            // 
            this.buttonRemoveRows_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveRows_SSV.Enabled = false;
            this.buttonRemoveRows_SSV.Location = new System.Drawing.Point(4, 146);
            this.buttonRemoveRows_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveRows_SSV.Name = "buttonRemoveRows_SSV";
            this.buttonRemoveRows_SSV.Size = new System.Drawing.Size(170, 39);
            this.buttonRemoveRows_SSV.TabIndex = 0;
            this.buttonRemoveRows_SSV.Text = "Удалить заказ";
            this.buttonRemoveRows_SSV.UseVisualStyleBackColor = true;
            this.buttonRemoveRows_SSV.Click += new System.EventHandler(this.buttonRemoveRows_SSV_Click);
            // 
            // buttonFilter_SSV
            // 
            this.buttonFilter_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter_SSV.Enabled = false;
            this.buttonFilter_SSV.Location = new System.Drawing.Point(4, 360);
            this.buttonFilter_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFilter_SSV.Name = "buttonFilter_SSV";
            this.buttonFilter_SSV.Size = new System.Drawing.Size(170, 39);
            this.buttonFilter_SSV.TabIndex = 0;
            this.buttonFilter_SSV.Text = "Отфильтровать";
            this.buttonFilter_SSV.UseVisualStyleBackColor = true;
            this.buttonFilter_SSV.Click += new System.EventHandler(this.buttonFilter_SSV_Click);
            // 
            // buttonAddOrders_SSV
            // 
            this.buttonAddOrders_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddOrders_SSV.Location = new System.Drawing.Point(4, 103);
            this.buttonAddOrders_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddOrders_SSV.Name = "buttonAddOrders_SSV";
            this.buttonAddOrders_SSV.Size = new System.Drawing.Size(170, 39);
            this.buttonAddOrders_SSV.TabIndex = 0;
            this.buttonAddOrders_SSV.Text = "Добавить заказ";
            this.buttonAddOrders_SSV.UseVisualStyleBackColor = true;
            this.buttonAddOrders_SSV.Click += new System.EventHandler(this.buttonAdd_SSV_Click);
            // 
            // buttonDownloadOrders_SSV
            // 
            this.buttonDownloadOrders_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownloadOrders_SSV.Location = new System.Drawing.Point(4, 60);
            this.buttonDownloadOrders_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDownloadOrders_SSV.Name = "buttonDownloadOrders_SSV";
            this.buttonDownloadOrders_SSV.Size = new System.Drawing.Size(170, 39);
            this.buttonDownloadOrders_SSV.TabIndex = 0;
            this.buttonDownloadOrders_SSV.Text = "Сохранить базу данных по заказам";
            this.buttonDownloadOrders_SSV.UseVisualStyleBackColor = true;
            this.buttonDownloadOrders_SSV.Click += new System.EventHandler(this.buttonDownload_SSV_Click);
            // 
            // tabControl_SSV
            // 
            this.tabControl_SSV.Controls.Add(this.tabPageOrderData_SSV);
            this.tabControl_SSV.Controls.Add(this.tabPageStats_SSV);
            this.tabControl_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_SSV.Location = new System.Drawing.Point(0, 24);
            this.tabControl_SSV.Name = "tabControl_SSV";
            this.tabControl_SSV.SelectedIndex = 0;
            this.tabControl_SSV.Size = new System.Drawing.Size(1093, 551);
            this.tabControl_SSV.TabIndex = 3;
            // 
            // FormWorkers_SSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 575);
            this.Controls.Add(this.tabControl_SSV);
            this.Controls.Add(this.menuStrip_SSV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormWorkers_SSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip_SSV.ResumeLayout(false);
            this.menuStrip_SSV.PerformLayout();
            this.tabPageStats_SSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPageOrderData_SSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableOrders_SSV)).EndInit();
            this.groupBoxMovesOrders_SSV.ResumeLayout(false);
            this.groupBoxMovesOrders_SSV.PerformLayout();
            this.tabControl_SSV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialogTable_SSV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable_SSV;
        private System.Windows.Forms.MenuStrip menuStrip_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInstruction_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit_SSV;
        private System.Windows.Forms.TabPage tabPageStats_SSV;
        private System.Windows.Forms.TabPage tabPageOrderData_SSV;
        private System.Windows.Forms.DataGridView dataGridViewTableOrders_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOrder_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDone_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOrder_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOrder_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_SSV;
        private System.Windows.Forms.GroupBox groupBoxMovesOrders_SSV;
        private System.Windows.Forms.Button buttonOpenOrder_SSV;
        private System.Windows.Forms.Button buttonAddOrders_SSV;
        private System.Windows.Forms.Button buttonDownloadOrders_SSV;
        private System.Windows.Forms.TabControl tabControl_SSV;
        private System.Windows.Forms.Button buttonFilter_SSV;
        private System.Windows.Forms.TextBox textBoxSearch_SSV;
        private System.Windows.Forms.TextBox textBoxFilter_SSV;
        private System.Windows.Forms.Button buttonRemoveRows_SSV;
        private System.Windows.Forms.Label labelSearch_SSV;
        private System.Windows.Forms.ComboBox comboBoxColsNames_SSV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetStats_SSV;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem_SSV;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch_SSV;
    }
}


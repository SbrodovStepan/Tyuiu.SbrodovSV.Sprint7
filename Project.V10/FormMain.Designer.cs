namespace Project.V10
{
    partial class FormMain_SSV
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
            this.dataGridViewTableClients_SSV = new System.Windows.Forms.DataGridView();
            this.FullName_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientAddress_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxMovesClients_SSV = new System.Windows.Forms.GroupBox();
            this.buttonOpenClients_SSV = new System.Windows.Forms.Button();
            this.buttonAddClients_SSV = new System.Windows.Forms.Button();
            this.buttonDownloadClients_SSV = new System.Windows.Forms.Button();
            this.saveFileDialogTable_SSV = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTable_SSV = new System.Windows.Forms.OpenFileDialog();
            this.tabControl_SSV = new System.Windows.Forms.TabControl();
            this.tabPageClientsData_SSV = new System.Windows.Forms.TabPage();
            this.tabPageOrderData_SSV = new System.Windows.Forms.TabPage();
            this.dataGridViewTableOrders_SSV = new System.Windows.Forms.DataGridView();
            this.NumberOrder_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDone_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOrder_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOrder_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxMovesOrders_SSV = new System.Windows.Forms.GroupBox();
            this.buttonOpenOrder_SSV = new System.Windows.Forms.Button();
            this.buttonAddOrders_SSV = new System.Windows.Forms.Button();
            this.buttonDownloadOrders_SSV = new System.Windows.Forms.Button();
            this.tabPageStats_SSV = new System.Windows.Forms.TabPage();
            this.menuStrip_SSV = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdd_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInfo_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInstruction_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit_SSV = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableClients_SSV)).BeginInit();
            this.groupBoxMovesClients_SSV.SuspendLayout();
            this.tabControl_SSV.SuspendLayout();
            this.tabPageClientsData_SSV.SuspendLayout();
            this.tabPageOrderData_SSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableOrders_SSV)).BeginInit();
            this.groupBoxMovesOrders_SSV.SuspendLayout();
            this.menuStrip_SSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTableClients_SSV
            // 
            this.dataGridViewTableClients_SSV.AllowUserToAddRows = false;
            this.dataGridViewTableClients_SSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTableClients_SSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTableClients_SSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName_SSV,
            this.AccountNumber_SSV,
            this.ClientAddress_SSV,
            this.Phone_SSV});
            this.dataGridViewTableClients_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTableClients_SSV.Location = new System.Drawing.Point(183, 3);
            this.dataGridViewTableClients_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTableClients_SSV.Name = "dataGridViewTableClients_SSV";
            this.dataGridViewTableClients_SSV.RowHeadersWidth = 51;
            this.dataGridViewTableClients_SSV.RowTemplate.Height = 24;
            this.dataGridViewTableClients_SSV.Size = new System.Drawing.Size(727, 351);
            this.dataGridViewTableClients_SSV.TabIndex = 1;
            this.dataGridViewTableClients_SSV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewTable_SSV_RowPrePaint);
            // 
            // FullName_SSV
            // 
            this.FullName_SSV.HeaderText = "ФИО";
            this.FullName_SSV.MinimumWidth = 6;
            this.FullName_SSV.Name = "FullName_SSV";
            // 
            // AccountNumber_SSV
            // 
            this.AccountNumber_SSV.HeaderText = "Номер счёта";
            this.AccountNumber_SSV.MinimumWidth = 6;
            this.AccountNumber_SSV.Name = "AccountNumber_SSV";
            this.AccountNumber_SSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ClientAddress_SSV
            // 
            this.ClientAddress_SSV.HeaderText = "Адрес клиента";
            this.ClientAddress_SSV.MinimumWidth = 6;
            this.ClientAddress_SSV.Name = "ClientAddress_SSV";
            // 
            // Phone_SSV
            // 
            this.Phone_SSV.HeaderText = "Телефон";
            this.Phone_SSV.MinimumWidth = 6;
            this.Phone_SSV.Name = "Phone_SSV";
            this.Phone_SSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // groupBoxMovesClients_SSV
            // 
            this.groupBoxMovesClients_SSV.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxMovesClients_SSV.Controls.Add(this.buttonOpenClients_SSV);
            this.groupBoxMovesClients_SSV.Controls.Add(this.buttonAddClients_SSV);
            this.groupBoxMovesClients_SSV.Controls.Add(this.buttonDownloadClients_SSV);
            this.groupBoxMovesClients_SSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxMovesClients_SSV.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMovesClients_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMovesClients_SSV.Name = "groupBoxMovesClients_SSV";
            this.groupBoxMovesClients_SSV.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMovesClients_SSV.Size = new System.Drawing.Size(180, 351);
            this.groupBoxMovesClients_SSV.TabIndex = 2;
            this.groupBoxMovesClients_SSV.TabStop = false;
            this.groupBoxMovesClients_SSV.Text = "Действия";
            // 
            // buttonOpenClients_SSV
            // 
            this.buttonOpenClients_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenClients_SSV.Location = new System.Drawing.Point(2, 102);
            this.buttonOpenClients_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenClients_SSV.Name = "buttonOpenClients_SSV";
            this.buttonOpenClients_SSV.Size = new System.Drawing.Size(170, 39);
            this.buttonOpenClients_SSV.TabIndex = 0;
            this.buttonOpenClients_SSV.Text = "Открыть базу данных по клиентам";
            this.buttonOpenClients_SSV.UseVisualStyleBackColor = true;
            this.buttonOpenClients_SSV.Click += new System.EventHandler(this.buttonOpen_SSV_Click);
            // 
            // buttonAddClients_SSV
            // 
            this.buttonAddClients_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddClients_SSV.Location = new System.Drawing.Point(2, 188);
            this.buttonAddClients_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddClients_SSV.Name = "buttonAddClients_SSV";
            this.buttonAddClients_SSV.Size = new System.Drawing.Size(170, 39);
            this.buttonAddClients_SSV.TabIndex = 0;
            this.buttonAddClients_SSV.Text = "Добавить клиента";
            this.buttonAddClients_SSV.UseVisualStyleBackColor = true;
            this.buttonAddClients_SSV.Click += new System.EventHandler(this.buttonAdd_SSV_Click);
            // 
            // buttonDownloadClients_SSV
            // 
            this.buttonDownloadClients_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownloadClients_SSV.Location = new System.Drawing.Point(2, 145);
            this.buttonDownloadClients_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDownloadClients_SSV.Name = "buttonDownloadClients_SSV";
            this.buttonDownloadClients_SSV.Size = new System.Drawing.Size(170, 39);
            this.buttonDownloadClients_SSV.TabIndex = 0;
            this.buttonDownloadClients_SSV.Text = "Сохранить базу данных по клиентам";
            this.buttonDownloadClients_SSV.UseVisualStyleBackColor = true;
            this.buttonDownloadClients_SSV.Click += new System.EventHandler(this.buttonDownload_SSV_Click);
            // 
            // openFileDialogTable_SSV
            // 
            this.openFileDialogTable_SSV.FileName = "openFileDialog1";
            // 
            // tabControl_SSV
            // 
            this.tabControl_SSV.Controls.Add(this.tabPageClientsData_SSV);
            this.tabControl_SSV.Controls.Add(this.tabPageOrderData_SSV);
            this.tabControl_SSV.Controls.Add(this.tabPageStats_SSV);
            this.tabControl_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_SSV.Location = new System.Drawing.Point(0, 24);
            this.tabControl_SSV.Name = "tabControl_SSV";
            this.tabControl_SSV.SelectedIndex = 0;
            this.tabControl_SSV.Size = new System.Drawing.Size(921, 383);
            this.tabControl_SSV.TabIndex = 3;
            // 
            // tabPageClientsData_SSV
            // 
            this.tabPageClientsData_SSV.Controls.Add(this.dataGridViewTableClients_SSV);
            this.tabPageClientsData_SSV.Controls.Add(this.groupBoxMovesClients_SSV);
            this.tabPageClientsData_SSV.Location = new System.Drawing.Point(4, 22);
            this.tabPageClientsData_SSV.Name = "tabPageClientsData_SSV";
            this.tabPageClientsData_SSV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClientsData_SSV.Size = new System.Drawing.Size(913, 357);
            this.tabPageClientsData_SSV.TabIndex = 0;
            this.tabPageClientsData_SSV.Text = "База данных по клиентам";
            this.tabPageClientsData_SSV.UseVisualStyleBackColor = true;
            // 
            // tabPageOrderData_SSV
            // 
            this.tabPageOrderData_SSV.Controls.Add(this.dataGridViewTableOrders_SSV);
            this.tabPageOrderData_SSV.Controls.Add(this.groupBoxMovesOrders_SSV);
            this.tabPageOrderData_SSV.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrderData_SSV.Name = "tabPageOrderData_SSV";
            this.tabPageOrderData_SSV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrderData_SSV.Size = new System.Drawing.Size(913, 357);
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
            this.dataGridViewTableOrders_SSV.Size = new System.Drawing.Size(727, 351);
            this.dataGridViewTableOrders_SSV.TabIndex = 1;
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
            this.groupBoxMovesOrders_SSV.Controls.Add(this.buttonOpenOrder_SSV);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.buttonAddOrders_SSV);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.buttonDownloadOrders_SSV);
            this.groupBoxMovesOrders_SSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxMovesOrders_SSV.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMovesOrders_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMovesOrders_SSV.Name = "groupBoxMovesOrders_SSV";
            this.groupBoxMovesOrders_SSV.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMovesOrders_SSV.Size = new System.Drawing.Size(180, 351);
            this.groupBoxMovesOrders_SSV.TabIndex = 4;
            this.groupBoxMovesOrders_SSV.TabStop = false;
            this.groupBoxMovesOrders_SSV.Text = "Действия";
            // 
            // buttonOpenOrder_SSV
            // 
            this.buttonOpenOrder_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenOrder_SSV.Location = new System.Drawing.Point(2, 102);
            this.buttonOpenOrder_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenOrder_SSV.Name = "buttonOpenOrder_SSV";
            this.buttonOpenOrder_SSV.Size = new System.Drawing.Size(170, 39);
            this.buttonOpenOrder_SSV.TabIndex = 0;
            this.buttonOpenOrder_SSV.Text = "Открыть базу данных по заказам";
            this.buttonOpenOrder_SSV.UseVisualStyleBackColor = true;
            this.buttonOpenOrder_SSV.Click += new System.EventHandler(this.buttonOpen_SSV_Click);
            // 
            // buttonAddOrders_SSV
            // 
            this.buttonAddOrders_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddOrders_SSV.Location = new System.Drawing.Point(2, 188);
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
            this.buttonDownloadOrders_SSV.Location = new System.Drawing.Point(2, 145);
            this.buttonDownloadOrders_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDownloadOrders_SSV.Name = "buttonDownloadOrders_SSV";
            this.buttonDownloadOrders_SSV.Size = new System.Drawing.Size(170, 39);
            this.buttonDownloadOrders_SSV.TabIndex = 0;
            this.buttonDownloadOrders_SSV.Text = "Сохранить базу данных по заказам";
            this.buttonDownloadOrders_SSV.UseVisualStyleBackColor = true;
            this.buttonDownloadOrders_SSV.Click += new System.EventHandler(this.buttonDownload_SSV_Click);
            // 
            // tabPageStats_SSV
            // 
            this.tabPageStats_SSV.Location = new System.Drawing.Point(4, 22);
            this.tabPageStats_SSV.Name = "tabPageStats_SSV";
            this.tabPageStats_SSV.Size = new System.Drawing.Size(913, 357);
            this.tabPageStats_SSV.TabIndex = 2;
            this.tabPageStats_SSV.Text = "Статистика";
            this.tabPageStats_SSV.UseVisualStyleBackColor = true;
            // 
            // menuStrip_SSV
            // 
            this.menuStrip_SSV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile_SSV,
            this.toolStripMenuItemInfo_SSV,
            this.toolStripMenuItemExit_SSV});
            this.menuStrip_SSV.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_SSV.Name = "menuStrip_SSV";
            this.menuStrip_SSV.Size = new System.Drawing.Size(921, 24);
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
            this.toolStripMenuItemAdd_SSV.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemAdd_SSV.Text = "Добавить";
            this.toolStripMenuItemAdd_SSV.Click += new System.EventHandler(this.buttonAdd_SSV_Click);
            // 
            // toolStripMenuItemOpen_SSV
            // 
            this.toolStripMenuItemOpen_SSV.Name = "toolStripMenuItemOpen_SSV";
            this.toolStripMenuItemOpen_SSV.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemOpen_SSV.Text = "Открыть";
            this.toolStripMenuItemOpen_SSV.Click += new System.EventHandler(this.buttonOpen_SSV_Click);
            // 
            // toolStripMenuItemSave_SSV
            // 
            this.toolStripMenuItemSave_SSV.Name = "toolStripMenuItemSave_SSV";
            this.toolStripMenuItemSave_SSV.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemSave_SSV.Text = "Сохранить";
            this.toolStripMenuItemSave_SSV.Click += new System.EventHandler(this.buttonDownload_SSV_Click);
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
            this.toolStripMenuItemInstruction_SSV.Size = new System.Drawing.Size(317, 22);
            this.toolStripMenuItemInstruction_SSV.Text = "Инструкция по использованию программы";
            // 
            // toolStripMenuItemAbout_SSV
            // 
            this.toolStripMenuItemAbout_SSV.Name = "toolStripMenuItemAbout_SSV";
            this.toolStripMenuItemAbout_SSV.Size = new System.Drawing.Size(317, 22);
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
            // FormMain_SSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 407);
            this.Controls.Add(this.tabControl_SSV);
            this.Controls.Add(this.menuStrip_SSV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain_SSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableClients_SSV)).EndInit();
            this.groupBoxMovesClients_SSV.ResumeLayout(false);
            this.tabControl_SSV.ResumeLayout(false);
            this.tabPageClientsData_SSV.ResumeLayout(false);
            this.tabPageOrderData_SSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableOrders_SSV)).EndInit();
            this.groupBoxMovesOrders_SSV.ResumeLayout(false);
            this.menuStrip_SSV.ResumeLayout(false);
            this.menuStrip_SSV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewTableClients_SSV;
        private System.Windows.Forms.GroupBox groupBoxMovesClients_SSV;
        private System.Windows.Forms.Button buttonOpenClients_SSV;
        private System.Windows.Forms.Button buttonAddClients_SSV;
        private System.Windows.Forms.Button buttonDownloadClients_SSV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTable_SSV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable_SSV;
        private System.Windows.Forms.TabControl tabControl_SSV;
        private System.Windows.Forms.TabPage tabPageClientsData_SSV;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientAddress_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_SSV;
        private System.Windows.Forms.MenuStrip menuStrip_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo_SSV;
        private System.Windows.Forms.TabPage tabPageStats_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInstruction_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit_SSV;
    }
}


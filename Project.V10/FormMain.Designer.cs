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
            this.menuStrip_SSV = new System.Windows.Forms.MenuStrip();
            this.ActionsToolStripMenuItem_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTable_SSV = new System.Windows.Forms.DataGridView();
            this.groupBoxMoves_SSV = new System.Windows.Forms.GroupBox();
            this.buttonOpen_SSV = new System.Windows.Forms.Button();
            this.buttonInfo_SSV = new System.Windows.Forms.Button();
            this.buttonAdd_SSV = new System.Windows.Forms.Button();
            this.buttonDownload_SSV = new System.Windows.Forms.Button();
            this.saveFileDialogTable_SSV = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTable_SSV = new System.Windows.Forms.OpenFileDialog();
            this.FullName_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientAddress_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip_SSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_SSV)).BeginInit();
            this.groupBoxMoves_SSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_SSV
            // 
            this.menuStrip_SSV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_SSV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionsToolStripMenuItem_SSV,
            this.aboutProgramToolStripMenuItem_SSV,
            this.exitToolStripMenuItem_SSV});
            this.menuStrip_SSV.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_SSV.Name = "menuStrip_SSV";
            this.menuStrip_SSV.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip_SSV.Size = new System.Drawing.Size(771, 24);
            this.menuStrip_SSV.TabIndex = 0;
            this.menuStrip_SSV.Text = "menuStrip1";
            // 
            // ActionsToolStripMenuItem_SSV
            // 
            this.ActionsToolStripMenuItem_SSV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem_SSV,
            this.saveToolStripMenuItem_SSV,
            this.addToolStripMenuItem_SSV,
            this.infoToolStripMenuItem_SSV});
            this.ActionsToolStripMenuItem_SSV.Name = "ActionsToolStripMenuItem_SSV";
            this.ActionsToolStripMenuItem_SSV.Size = new System.Drawing.Size(70, 20);
            this.ActionsToolStripMenuItem_SSV.Text = "Действия";
            // 
            // openToolStripMenuItem_SSV
            // 
            this.openToolStripMenuItem_SSV.Name = "openToolStripMenuItem_SSV";
            this.openToolStripMenuItem_SSV.Size = new System.Drawing.Size(133, 22);
            this.openToolStripMenuItem_SSV.Text = "Открыть";
            // 
            // saveToolStripMenuItem_SSV
            // 
            this.saveToolStripMenuItem_SSV.Name = "saveToolStripMenuItem_SSV";
            this.saveToolStripMenuItem_SSV.Size = new System.Drawing.Size(133, 22);
            this.saveToolStripMenuItem_SSV.Text = "Сохранить";
            // 
            // addToolStripMenuItem_SSV
            // 
            this.addToolStripMenuItem_SSV.Name = "addToolStripMenuItem_SSV";
            this.addToolStripMenuItem_SSV.Size = new System.Drawing.Size(133, 22);
            this.addToolStripMenuItem_SSV.Text = "Добавить";
            // 
            // infoToolStripMenuItem_SSV
            // 
            this.infoToolStripMenuItem_SSV.Name = "infoToolStripMenuItem_SSV";
            this.infoToolStripMenuItem_SSV.Size = new System.Drawing.Size(133, 22);
            this.infoToolStripMenuItem_SSV.Text = "Инфо";
            // 
            // aboutProgramToolStripMenuItem_SSV
            // 
            this.aboutProgramToolStripMenuItem_SSV.Name = "aboutProgramToolStripMenuItem_SSV";
            this.aboutProgramToolStripMenuItem_SSV.Size = new System.Drawing.Size(94, 20);
            this.aboutProgramToolStripMenuItem_SSV.Text = "О программе";
            this.aboutProgramToolStripMenuItem_SSV.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_SSV_Click);
            // 
            // exitToolStripMenuItem_SSV
            // 
            this.exitToolStripMenuItem_SSV.Name = "exitToolStripMenuItem_SSV";
            this.exitToolStripMenuItem_SSV.Size = new System.Drawing.Size(54, 20);
            this.exitToolStripMenuItem_SSV.Text = "Выход";
            this.exitToolStripMenuItem_SSV.Click += new System.EventHandler(this.exitToolStripMenuItem_SSV_Click);
            // 
            // dataGridViewTable_SSV
            // 
            this.dataGridViewTable_SSV.AllowUserToAddRows = false;
            this.dataGridViewTable_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTable_SSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTable_SSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable_SSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName_SSV,
            this.AccountNumber_SSV,
            this.ClientAddress_SSV,
            this.Phone_SSV});
            this.dataGridViewTable_SSV.Location = new System.Drawing.Point(9, 25);
            this.dataGridViewTable_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTable_SSV.Name = "dataGridViewTable_SSV";
            this.dataGridViewTable_SSV.RowHeadersWidth = 51;
            this.dataGridViewTable_SSV.RowTemplate.Height = 24;
            this.dataGridViewTable_SSV.Size = new System.Drawing.Size(568, 271);
            this.dataGridViewTable_SSV.TabIndex = 1;
            this.dataGridViewTable_SSV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewTable_SSV_RowPrePaint);
            // 
            // groupBoxMoves_SSV
            // 
            this.groupBoxMoves_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMoves_SSV.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxMoves_SSV.Controls.Add(this.buttonOpen_SSV);
            this.groupBoxMoves_SSV.Controls.Add(this.buttonInfo_SSV);
            this.groupBoxMoves_SSV.Controls.Add(this.buttonAdd_SSV);
            this.groupBoxMoves_SSV.Controls.Add(this.buttonDownload_SSV);
            this.groupBoxMoves_SSV.Location = new System.Drawing.Point(582, 25);
            this.groupBoxMoves_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMoves_SSV.Name = "groupBoxMoves_SSV";
            this.groupBoxMoves_SSV.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMoves_SSV.Size = new System.Drawing.Size(180, 271);
            this.groupBoxMoves_SSV.TabIndex = 2;
            this.groupBoxMoves_SSV.TabStop = false;
            this.groupBoxMoves_SSV.Text = "Действия";
            // 
            // buttonOpen_SSV
            // 
            this.buttonOpen_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen_SSV.Location = new System.Drawing.Point(4, 12);
            this.buttonOpen_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpen_SSV.Name = "buttonOpen_SSV";
            this.buttonOpen_SSV.Size = new System.Drawing.Size(170, 39);
            this.buttonOpen_SSV.TabIndex = 0;
            this.buttonOpen_SSV.Text = "Открыть базу данных по клиентам";
            this.buttonOpen_SSV.UseVisualStyleBackColor = true;
            this.buttonOpen_SSV.Click += new System.EventHandler(this.buttonOpen_SSV_Click);
            // 
            // buttonInfo_SSV
            // 
            this.buttonInfo_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_SSV.Location = new System.Drawing.Point(4, 144);
            this.buttonInfo_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo_SSV.Name = "buttonInfo_SSV";
            this.buttonInfo_SSV.Size = new System.Drawing.Size(170, 39);
            this.buttonInfo_SSV.TabIndex = 0;
            this.buttonInfo_SSV.Text = "Информация о разработчике";
            this.buttonInfo_SSV.UseVisualStyleBackColor = true;
            this.buttonInfo_SSV.Click += new System.EventHandler(this.buttonInfo_SSV_Click);
            // 
            // buttonAdd_SSV
            // 
            this.buttonAdd_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd_SSV.Location = new System.Drawing.Point(4, 100);
            this.buttonAdd_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd_SSV.Name = "buttonAdd_SSV";
            this.buttonAdd_SSV.Size = new System.Drawing.Size(170, 39);
            this.buttonAdd_SSV.TabIndex = 0;
            this.buttonAdd_SSV.Text = "Добавить клиента";
            this.buttonAdd_SSV.UseVisualStyleBackColor = true;
            this.buttonAdd_SSV.Click += new System.EventHandler(this.buttonAdd_SSV_Click);
            // 
            // buttonDownload_SSV
            // 
            this.buttonDownload_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownload_SSV.Location = new System.Drawing.Point(4, 56);
            this.buttonDownload_SSV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDownload_SSV.Name = "buttonDownload_SSV";
            this.buttonDownload_SSV.Size = new System.Drawing.Size(170, 39);
            this.buttonDownload_SSV.TabIndex = 0;
            this.buttonDownload_SSV.Text = "Сохранить базу данных по клиентам";
            this.buttonDownload_SSV.UseVisualStyleBackColor = true;
            this.buttonDownload_SSV.Click += new System.EventHandler(this.buttonDownload_SSV_Click);
            // 
            // openFileDialogTable_SSV
            // 
            this.openFileDialogTable_SSV.FileName = "openFileDialog1";
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
            this.Phone_SSV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormMain_SSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 306);
            this.Controls.Add(this.groupBoxMoves_SSV);
            this.Controls.Add(this.dataGridViewTable_SSV);
            this.Controls.Add(this.menuStrip_SSV);
            this.MainMenuStrip = this.menuStrip_SSV;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain_SSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip_SSV.ResumeLayout(false);
            this.menuStrip_SSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_SSV)).EndInit();
            this.groupBoxMoves_SSV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_SSV;
        private System.Windows.Forms.ToolStripMenuItem ActionsToolStripMenuItem_SSV;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem_SSV;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem_SSV;
        private System.Windows.Forms.DataGridView dataGridViewTable_SSV;
        private System.Windows.Forms.GroupBox groupBoxMoves_SSV;
        private System.Windows.Forms.Button buttonOpen_SSV;
        private System.Windows.Forms.Button buttonInfo_SSV;
        private System.Windows.Forms.Button buttonAdd_SSV;
        private System.Windows.Forms.Button buttonDownload_SSV;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem_SSV;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem_SSV;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem_SSV;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem_SSV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTable_SSV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientAddress_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_SSV;
    }
}


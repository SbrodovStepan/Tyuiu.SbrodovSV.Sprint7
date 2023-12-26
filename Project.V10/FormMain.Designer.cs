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
            this.components = new System.ComponentModel.Container();
            this.menuStrip_SSV = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemInfo_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInstruction_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMain_SSV = new System.Windows.Forms.Label();
            this.buttonEnterWorker_SSV = new System.Windows.Forms.Button();
            this.buttonEnterClient_SSV = new System.Windows.Forms.Button();
            this.toolTip_SSV = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip_SSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_SSV
            // 
            this.menuStrip_SSV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemInfo_SSV,
            this.toolStripMenuItemExit_SSV});
            this.menuStrip_SSV.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_SSV.Name = "menuStrip_SSV";
            this.menuStrip_SSV.Size = new System.Drawing.Size(520, 24);
            this.menuStrip_SSV.TabIndex = 5;
            this.menuStrip_SSV.Text = "menuStrip1";
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
            this.toolStripMenuItemInstruction_SSV.ToolTipText = "Гайд по использованию программы";
            this.toolStripMenuItemInstruction_SSV.Click += new System.EventHandler(this.toolStripMenuItemInstruction_SSV_Click);
            // 
            // toolStripMenuItemAbout_SSV
            // 
            this.toolStripMenuItemAbout_SSV.Name = "toolStripMenuItemAbout_SSV";
            this.toolStripMenuItemAbout_SSV.Size = new System.Drawing.Size(268, 22);
            this.toolStripMenuItemAbout_SSV.Text = "О программе ";
            this.toolStripMenuItemAbout_SSV.ToolTipText = "Информация о разработчике";
            this.toolStripMenuItemAbout_SSV.Click += new System.EventHandler(this.toolStripMenuItemAbout_SSV_Click);
            // 
            // toolStripMenuItemExit_SSV
            // 
            this.toolStripMenuItemExit_SSV.Name = "toolStripMenuItemExit_SSV";
            this.toolStripMenuItemExit_SSV.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItemExit_SSV.Text = "Выход";
            this.toolStripMenuItemExit_SSV.Click += new System.EventHandler(this.toolStripMenuItemExit_SSV_Click);
            // 
            // labelMain_SSV
            // 
            this.labelMain_SSV.AutoSize = true;
            this.labelMain_SSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelMain_SSV.Location = new System.Drawing.Point(134, 48);
            this.labelMain_SSV.Name = "labelMain_SSV";
            this.labelMain_SSV.Size = new System.Drawing.Size(226, 31);
            this.labelMain_SSV.TabIndex = 6;
            this.labelMain_SSV.Text = "Вы хотите войти:\r\n";
            // 
            // buttonEnterWorker_SSV
            // 
            this.buttonEnterWorker_SSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnterWorker_SSV.Location = new System.Drawing.Point(64, 125);
            this.buttonEnterWorker_SSV.Name = "buttonEnterWorker_SSV";
            this.buttonEnterWorker_SSV.Size = new System.Drawing.Size(170, 39);
            this.buttonEnterWorker_SSV.TabIndex = 7;
            this.buttonEnterWorker_SSV.Text = "Как рабочий";
            this.toolTip_SSV.SetToolTip(this.buttonEnterWorker_SSV, "Открыть окно для работника");
            this.buttonEnterWorker_SSV.UseVisualStyleBackColor = true;
            this.buttonEnterWorker_SSV.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEnterClient_SSV
            // 
            this.buttonEnterClient_SSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnterClient_SSV.Location = new System.Drawing.Point(295, 125);
            this.buttonEnterClient_SSV.Name = "buttonEnterClient_SSV";
            this.buttonEnterClient_SSV.Size = new System.Drawing.Size(170, 39);
            this.buttonEnterClient_SSV.TabIndex = 7;
            this.buttonEnterClient_SSV.Text = "Как пользователь";
            this.toolTip_SSV.SetToolTip(this.buttonEnterClient_SSV, "Открыть окно заказчика");
            this.buttonEnterClient_SSV.UseVisualStyleBackColor = true;
            this.buttonEnterClient_SSV.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMain_SSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 267);
            this.Controls.Add(this.buttonEnterClient_SSV);
            this.Controls.Add(this.buttonEnterWorker_SSV);
            this.Controls.Add(this.labelMain_SSV);
            this.Controls.Add(this.menuStrip_SSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(536, 306);
            this.Name = "FormMain_SSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.menuStrip_SSV.ResumeLayout(false);
            this.menuStrip_SSV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInstruction_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit_SSV;
        private System.Windows.Forms.Label labelMain_SSV;
        private System.Windows.Forms.Button buttonEnterWorker_SSV;
        private System.Windows.Forms.Button buttonEnterClient_SSV;
        private System.Windows.Forms.ToolTip toolTip_SSV;
    }
}
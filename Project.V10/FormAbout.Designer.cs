namespace Project.V10
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOK_SSV = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_SSV = new System.Windows.Forms.PictureBox();
            this.labelInfo_SSV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SSV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_SSV
            // 
            this.buttonOK_SSV.Location = new System.Drawing.Point(345, 130);
            this.buttonOK_SSV.Name = "buttonOK_SSV";
            this.buttonOK_SSV.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_SSV.TabIndex = 1;
            this.buttonOK_SSV.Text = "Ок";
            this.buttonOK_SSV.UseVisualStyleBackColor = true;
            this.buttonOK_SSV.Click += new System.EventHandler(this.buttonOK_SSV_Click);
            // 
            // pictureBoxAvatar_SSV
            // 
            this.pictureBoxAvatar_SSV.Image = global::Project.V10.Properties.Resources._7XnkBGmKW4k4EFWs7372cA;
            this.pictureBoxAvatar_SSV.Location = new System.Drawing.Point(12, 39);
            this.pictureBoxAvatar_SSV.Name = "pictureBoxAvatar_SSV";
            this.pictureBoxAvatar_SSV.Size = new System.Drawing.Size(117, 78);
            this.pictureBoxAvatar_SSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_SSV.TabIndex = 2;
            this.pictureBoxAvatar_SSV.TabStop = false;
            // 
            // labelInfo_SSV
            // 
            this.labelInfo_SSV.AutoSize = true;
            this.labelInfo_SSV.Location = new System.Drawing.Point(136, 9);
            this.labelInfo_SSV.Name = "labelInfo_SSV";
            this.labelInfo_SSV.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_SSV.TabIndex = 3;
            this.labelInfo_SSV.Text = resources.GetString("labelInfo_SSV.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 165);
            this.Controls.Add(this.labelInfo_SSV);
            this.Controls.Add(this.pictureBoxAvatar_SSV);
            this.Controls.Add(this.buttonOK_SSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOK_SSV;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_SSV;
        private System.Windows.Forms.Label labelInfo_SSV;
    }
}
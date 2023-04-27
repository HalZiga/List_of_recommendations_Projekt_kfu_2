namespace Projekt_kfu_2
{
    partial class AddFurn
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
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxFDescription = new System.Windows.Forms.TextBox();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonFAdd = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(266, 25);
            this.textBoxFName.Multiline = true;
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(292, 36);
            this.textBoxFName.TabIndex = 1;
            this.textBoxFName.Enter += new System.EventHandler(this.textBoxFName_Enter);
            this.textBoxFName.Leave += new System.EventHandler(this.textBoxFName_Leave);
            // 
            // textBoxFDescription
            // 
            this.textBoxFDescription.Location = new System.Drawing.Point(266, 160);
            this.textBoxFDescription.Multiline = true;
            this.textBoxFDescription.Name = "textBoxFDescription";
            this.textBoxFDescription.Size = new System.Drawing.Size(292, 98);
            this.textBoxFDescription.TabIndex = 3;
            this.textBoxFDescription.Enter += new System.EventHandler(this.textBoxFDescription_Enter);
            this.textBoxFDescription.Leave += new System.EventHandler(this.textBoxFDescription_Leave);
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAdd.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(222, 219);
            this.pictureBoxAdd.TabIndex = 0;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.pictureBoxAdd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Диваны",
            "Столы"});
            this.comboBox1.Location = new System.Drawing.Point(266, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // buttonFAdd
            // 
            this.buttonFAdd.Location = new System.Drawing.Point(28, 263);
            this.buttonFAdd.Name = "buttonFAdd";
            this.buttonFAdd.Size = new System.Drawing.Size(194, 41);
            this.buttonFAdd.TabIndex = 5;
            this.buttonFAdd.Text = "button1";
            this.buttonFAdd.UseVisualStyleBackColor = true;
            this.buttonFAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddFurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 354);
            this.Controls.Add(this.buttonFAdd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxFDescription);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.pictureBoxAdd);
            this.Name = "AddFurn";
            this.Text = "AddFurn";
            this.Load += new System.EventHandler(this.AddFurn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxFDescription;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonFAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
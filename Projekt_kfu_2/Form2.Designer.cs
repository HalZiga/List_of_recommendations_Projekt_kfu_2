namespace Projekt_kfu_2
{
    partial class Regestration
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
            this.buttonRegestration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPasswod = new System.Windows.Forms.TextBox();
            this.textBoxSecondPassword = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurename = new System.Windows.Forms.TextBox();
            this.textBoxFathername = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRegestration
            // 
            this.buttonRegestration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(188)))), ((int)(((byte)(126)))));
            this.buttonRegestration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegestration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegestration.Location = new System.Drawing.Point(66, 390);
            this.buttonRegestration.Name = "buttonRegestration";
            this.buttonRegestration.Size = new System.Drawing.Size(215, 48);
            this.buttonRegestration.TabIndex = 1;
            this.buttonRegestration.Text = "Зарегистрироваться";
            this.buttonRegestration.UseVisualStyleBackColor = false;
            this.buttonRegestration.Click += new System.EventHandler(this.buttonRegestration_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(232)))), ((int)(((byte)(217)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(55, 83);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(236, 32);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxPasswod
            // 
            this.textBoxPasswod.Location = new System.Drawing.Point(55, 190);
            this.textBoxPasswod.Multiline = true;
            this.textBoxPasswod.Name = "textBoxPasswod";
            this.textBoxPasswod.Size = new System.Drawing.Size(236, 32);
            this.textBoxPasswod.TabIndex = 5;
            this.textBoxPasswod.Enter += new System.EventHandler(this.textBoxPasswod_Enter);
            this.textBoxPasswod.Leave += new System.EventHandler(this.textBoxPasswod_Leave);
            // 
            // textBoxSecondPassword
            // 
            this.textBoxSecondPassword.Location = new System.Drawing.Point(55, 228);
            this.textBoxSecondPassword.Multiline = true;
            this.textBoxSecondPassword.Name = "textBoxSecondPassword";
            this.textBoxSecondPassword.Size = new System.Drawing.Size(236, 32);
            this.textBoxSecondPassword.TabIndex = 6;
            this.textBoxSecondPassword.Enter += new System.EventHandler(this.textBoxSecondPassword_Enter);
            this.textBoxSecondPassword.Leave += new System.EventHandler(this.textBoxSecondPassword_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(55, 266);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(236, 32);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxSurename
            // 
            this.textBoxSurename.Location = new System.Drawing.Point(55, 304);
            this.textBoxSurename.Multiline = true;
            this.textBoxSurename.Name = "textBoxSurename";
            this.textBoxSurename.Size = new System.Drawing.Size(236, 32);
            this.textBoxSurename.TabIndex = 8;
            this.textBoxSurename.Enter += new System.EventHandler(this.textBoxSurename_Enter);
            this.textBoxSurename.Leave += new System.EventHandler(this.textBoxSurename_Leave);
            // 
            // textBoxFathername
            // 
            this.textBoxFathername.Location = new System.Drawing.Point(55, 342);
            this.textBoxFathername.Multiline = true;
            this.textBoxFathername.Name = "textBoxFathername";
            this.textBoxFathername.Size = new System.Drawing.Size(236, 32);
            this.textBoxFathername.TabIndex = 9;
            this.textBoxFathername.Enter += new System.EventHandler(this.textBoxFathername_Enter);
            this.textBoxFathername.Leave += new System.EventHandler(this.textBoxFathername_Leave);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(55, 140);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(236, 32);
            this.textBoxLogin.TabIndex = 10;
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // Regestration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxFathername);
            this.Controls.Add(this.textBoxSurename);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSecondPassword);
            this.Controls.Add(this.textBoxPasswod);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegestration);
            this.Name = "Regestration";
            this.Load += new System.EventHandler(this.Regestration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRegestration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPasswod;
        private System.Windows.Forms.TextBox textBoxSecondPassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurename;
        private System.Windows.Forms.TextBox textBoxFathername;
        private System.Windows.Forms.TextBox textBoxLogin;
    }
}
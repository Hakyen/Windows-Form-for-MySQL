namespace BD_06
{
    partial class Avtorization
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
            this.Ok_passw = new System.Windows.Forms.Button();
            this.Cancel_passw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ok_passw
            // 
            this.Ok_passw.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok_passw.Location = new System.Drawing.Point(35, 214);
            this.Ok_passw.Name = "Ok_passw";
            this.Ok_passw.Size = new System.Drawing.Size(75, 23);
            this.Ok_passw.TabIndex = 0;
            this.Ok_passw.Text = "Ok";
            this.Ok_passw.UseVisualStyleBackColor = true;
            // 
            // Cancel_passw
            // 
            this.Cancel_passw.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_passw.Location = new System.Drawing.Point(165, 214);
            this.Cancel_passw.Name = "Cancel_passw";
            this.Cancel_passw.Size = new System.Drawing.Size(75, 23);
            this.Cancel_passw.TabIndex = 1;
            this.Cancel_passw.Text = "Cancel";
            this.Cancel_passw.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // Login_tb
            // 
            this.Login_tb.Location = new System.Drawing.Point(108, 52);
            this.Login_tb.Name = "Login_tb";
            this.Login_tb.Size = new System.Drawing.Size(100, 20);
            this.Login_tb.TabIndex = 4;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(108, 120);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(100, 20);
            this.password_tb.TabIndex = 5;
            // 
            // Avtorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.Login_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel_passw);
            this.Controls.Add(this.Ok_passw);
            this.Name = "Avtorization";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Cancel_passw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button Ok_passw;
        public System.Windows.Forms.TextBox Login_tb;
        public System.Windows.Forms.TextBox password_tb;
    }
}
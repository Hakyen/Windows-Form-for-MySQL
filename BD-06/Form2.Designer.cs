namespace BD_06
{
    partial class DialogINs
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.name_corp = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.developer = new System.Windows.Forms.TextBox();
            this.Date_manufactured = new System.Windows.Forms.TextBox();
            this.button_ok_ins = new System.Windows.Forms.Button();
            this.button_cancel_ins = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name-corp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Developer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date manufactored";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(215, 50);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 6;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // name_corp
            // 
            this.name_corp.Location = new System.Drawing.Point(215, 83);
            this.name_corp.Name = "name_corp";
            this.name_corp.Size = new System.Drawing.Size(100, 20);
            this.name_corp.TabIndex = 7;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(215, 115);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 8;
            // 
            // developer
            // 
            this.developer.Location = new System.Drawing.Point(215, 141);
            this.developer.Name = "developer";
            this.developer.Size = new System.Drawing.Size(100, 20);
            this.developer.TabIndex = 9;
            // 
            // Date_manufactured
            // 
            this.Date_manufactured.Location = new System.Drawing.Point(215, 176);
            this.Date_manufactured.Name = "Date_manufactured";
            this.Date_manufactured.Size = new System.Drawing.Size(100, 20);
            this.Date_manufactured.TabIndex = 10;
            // 
            // button_ok_ins
            // 
            this.button_ok_ins.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok_ins.Location = new System.Drawing.Point(390, 65);
            this.button_ok_ins.Name = "button_ok_ins";
            this.button_ok_ins.Size = new System.Drawing.Size(95, 25);
            this.button_ok_ins.TabIndex = 11;
            this.button_ok_ins.Text = "Ok";
            this.button_ok_ins.UseVisualStyleBackColor = true;
            // 
            // button_cancel_ins
            // 
            this.button_cancel_ins.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel_ins.Location = new System.Drawing.Point(389, 118);
            this.button_cancel_ins.Name = "button_cancel_ins";
            this.button_cancel_ins.Size = new System.Drawing.Size(95, 32);
            this.button_cancel_ins.TabIndex = 12;
            this.button_cancel_ins.Text = "cancel";
            this.button_cancel_ins.UseVisualStyleBackColor = true;
            // 
            // DialogINs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 261);
            this.Controls.Add(this.button_cancel_ins);
            this.Controls.Add(this.button_ok_ins);
            this.Controls.Add(this.Date_manufactured);
            this.Controls.Add(this.developer);
            this.Controls.Add(this.name);
            this.Controls.Add(this.name_corp);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DialogINs";
            this.Text = "Insert";
            this.Load += new System.EventHandler(this.DialogINs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox id;
        public System.Windows.Forms.TextBox name_corp;
        public System.Windows.Forms.TextBox name;
        public System.Windows.Forms.TextBox developer;
        public System.Windows.Forms.TextBox Date_manufactured;
        public System.Windows.Forms.Button button_ok_ins;
        public System.Windows.Forms.Button button_cancel_ins;
    }
}
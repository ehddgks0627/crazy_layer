namespace Crazy
{
    partial class Search_Room
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
            this.r_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.r_pw = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.CheckBox();
            this.enter = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // r_id
            // 
            this.r_id.Location = new System.Drawing.Point(240, 98);
            this.r_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.r_id.MaxLength = 4;
            this.r_id.Name = "r_id";
            this.r_id.Size = new System.Drawing.Size(56, 21);
            this.r_id.TabIndex = 0;
            this.r_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "방번호";
            // 
            // r_pw
            // 
            this.r_pw.Location = new System.Drawing.Point(240, 168);
            this.r_pw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.r_pw.MaxLength = 20;
            this.r_pw.Name = "r_pw";
            this.r_pw.PasswordChar = '*';
            this.r_pw.ReadOnly = true;
            this.r_pw.Size = new System.Drawing.Size(56, 21);
            this.r_pw.TabIndex = 2;
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.Location = new System.Drawing.Point(99, 170);
            this.pwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(72, 16);
            this.pwd.TabIndex = 3;
            this.pwd.Text = "비밀번호";
            this.pwd.UseVisualStyleBackColor = true;
            this.pwd.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(96, 248);
            this.enter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(77, 52);
            this.enter.TabIndex = 4;
            this.enter.Text = "입장";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(228, 248);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(77, 52);
            this.exit.TabIndex = 5;
            this.exit.Text = "취소";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Search_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(404, 381);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.r_pw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.r_id);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Search_Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_Room";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox r_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox r_pw;
        private System.Windows.Forms.CheckBox pwd;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button exit;
    }
}
﻿namespace Crazy
{
    partial class Make_Room
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
            this.label1 = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.CheckBox();
            this.room_sub = new System.Windows.Forms.TextBox();
            this.room_pwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.room_max = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(220, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "방제목";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.Location = new System.Drawing.Point(222, 252);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(71, 24);
            this.pwd.TabIndex = 1;
            this.pwd.Text = "비밀방";
            this.pwd.UseVisualStyleBackColor = true;
            this.pwd.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // room_sub
            // 
            this.room_sub.Location = new System.Drawing.Point(329, 123);
            this.room_sub.MaxLength = 12;
            this.room_sub.Name = "room_sub";
            this.room_sub.Size = new System.Drawing.Size(279, 26);
            this.room_sub.TabIndex = 2;
            // 
            // room_pwd
            // 
            this.room_pwd.Location = new System.Drawing.Point(329, 250);
            this.room_pwd.MaxLength = 20;
            this.room_pwd.Name = "room_pwd";
            this.room_pwd.PasswordChar = '*';
            this.room_pwd.ReadOnly = true;
            this.room_pwd.Size = new System.Drawing.Size(279, 26);
            this.room_pwd.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 127);
            this.button1.TabIndex = 4;
            this.button1.Text = "생성";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 127);
            this.button2.TabIndex = 5;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // room_max
            // 
            this.room_max.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.room_max.FormattingEnabled = true;
            this.room_max.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.room_max.Location = new System.Drawing.Point(523, 340);
            this.room_max.Name = "room_max";
            this.room_max.Size = new System.Drawing.Size(85, 28);
            this.room_max.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(212, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "인원";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Make_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 850);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.room_max);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.room_pwd);
            this.Controls.Add(this.room_sub);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.label1);
            this.Name = "Make_Room";
            this.Text = "Make_Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox pwd;
        private System.Windows.Forms.TextBox room_sub;
        private System.Windows.Forms.TextBox room_pwd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox room_max;
        private System.Windows.Forms.Label label2;
    }
}
namespace Crazy
{
    partial class Quit_ask
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
            this.ASK = new System.Windows.Forms.Label();
            this.quitButton_Yes = new System.Windows.Forms.Button();
            this.quitButton_No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ASK
            // 
            this.ASK.AutoSize = true;
            this.ASK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ASK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ASK.Location = new System.Drawing.Point(67, 52);
            this.ASK.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ASK.Name = "ASK";
            this.ASK.Size = new System.Drawing.Size(469, 44);
            this.ASK.TabIndex = 0;
            this.ASK.Text = "게임을 종료하시겠습니까?";
            // 
            // quitButton_Yes
            // 
            this.quitButton_Yes.Location = new System.Drawing.Point(74, 136);
            this.quitButton_Yes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.quitButton_Yes.Name = "quitButton_Yes";
            this.quitButton_Yes.Size = new System.Drawing.Size(139, 46);
            this.quitButton_Yes.TabIndex = 1;
            this.quitButton_Yes.Text = "예";
            this.quitButton_Yes.UseVisualStyleBackColor = true;
            this.quitButton_Yes.Click += new System.EventHandler(this.quitButton_Yes_Click);
            // 
            // quitButton_No
            // 
            this.quitButton_No.Location = new System.Drawing.Point(319, 136);
            this.quitButton_No.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.quitButton_No.Name = "quitButton_No";
            this.quitButton_No.Size = new System.Drawing.Size(139, 46);
            this.quitButton_No.TabIndex = 1;
            this.quitButton_No.Text = "아니오";
            this.quitButton_No.UseVisualStyleBackColor = true;
            this.quitButton_No.Click += new System.EventHandler(this.quitButton_No_Click);
            // 
            // Quit_ask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(539, 216);
            this.ControlBox = false;
            this.Controls.Add(this.quitButton_No);
            this.Controls.Add(this.quitButton_Yes);
            this.Controls.Add(this.ASK);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Quit_ask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ASK;
        private System.Windows.Forms.Button quitButton_Yes;
        private System.Windows.Forms.Button quitButton_No;
    }
}
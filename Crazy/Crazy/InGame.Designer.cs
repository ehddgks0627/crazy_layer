namespace Crazy
{
    partial class ingame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingame));
            this.gmae_out = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gmae_out)).BeginInit();
            this.SuspendLayout();
            // 
            // gmae_out
            // 
            this.gmae_out.Image = ((System.Drawing.Image)(resources.GetObject("gmae_out.Image")));
            this.gmae_out.Location = new System.Drawing.Point(647, 560);
            this.gmae_out.Name = "gmae_out";
            this.gmae_out.Size = new System.Drawing.Size(140, 32);
            this.gmae_out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gmae_out.TabIndex = 0;
            this.gmae_out.TabStop = false;
            this.gmae_out.Click += new System.EventHandler(this.gmae_out_Click);
            // 
            // ingame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 601);
            this.Controls.Add(this.gmae_out);
            this.Name = "ingame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ingame";
            ((System.ComponentModel.ISupportInitialize)(this.gmae_out)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gmae_out;
    }
}
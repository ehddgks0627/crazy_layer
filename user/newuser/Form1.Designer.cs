namespace newuser
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.thisone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.thisone)).BeginInit();
            this.SuspendLayout();
            // 
            // thisone
            // 
            this.thisone.Image = global::newuser.Properties.Resources.pika;
            this.thisone.Location = new System.Drawing.Point(0, 0);
            this.thisone.Name = "thisone";
            this.thisone.Size = new System.Drawing.Size(51, 50);
            this.thisone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thisone.TabIndex = 0;
            this.thisone.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(456, 353);
            this.Controls.Add(this.thisone);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.thisone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox thisone;
    }
}


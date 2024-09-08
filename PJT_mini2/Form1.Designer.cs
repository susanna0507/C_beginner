namespace PJT_mini2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.영상처리1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확대ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.축소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상하반전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.좌우반전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회전90도ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회전180도ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회전270도ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.영상처리2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회색이미지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.반전이미지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.흑백이미지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.블러링ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.윤곽선검출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pbox_image = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.영상처리1ToolStripMenuItem,
            this.영상처리2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.프로그램종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.저장ToolStripMenuItem.Text = "저장";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
            // 
            // 프로그램종료ToolStripMenuItem
            // 
            this.프로그램종료ToolStripMenuItem.Name = "프로그램종료ToolStripMenuItem";
            this.프로그램종료ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.프로그램종료ToolStripMenuItem.Text = "프로그램 종료";
            // 
            // 영상처리1ToolStripMenuItem
            // 
            this.영상처리1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.확대ToolStripMenuItem,
            this.축소ToolStripMenuItem,
            this.상하반전ToolStripMenuItem,
            this.좌우반전ToolStripMenuItem,
            this.회전90도ToolStripMenuItem,
            this.회전180도ToolStripMenuItem,
            this.회전270도ToolStripMenuItem});
            this.영상처리1ToolStripMenuItem.Name = "영상처리1ToolStripMenuItem";
            this.영상처리1ToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.영상처리1ToolStripMenuItem.Text = "영상처리(1)";
            // 
            // 확대ToolStripMenuItem
            // 
            this.확대ToolStripMenuItem.Name = "확대ToolStripMenuItem";
            this.확대ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.확대ToolStripMenuItem.Text = "확대";
            this.확대ToolStripMenuItem.Click += new System.EventHandler(this.확대ToolStripMenuItem_Click);
            // 
            // 축소ToolStripMenuItem
            // 
            this.축소ToolStripMenuItem.Name = "축소ToolStripMenuItem";
            this.축소ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.축소ToolStripMenuItem.Text = "축소";
            this.축소ToolStripMenuItem.Click += new System.EventHandler(this.축소ToolStripMenuItem_Click);
            // 
            // 상하반전ToolStripMenuItem
            // 
            this.상하반전ToolStripMenuItem.Name = "상하반전ToolStripMenuItem";
            this.상하반전ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.상하반전ToolStripMenuItem.Text = "상하 반전";
            this.상하반전ToolStripMenuItem.Click += new System.EventHandler(this.상하반전ToolStripMenuItem_Click);
            // 
            // 좌우반전ToolStripMenuItem
            // 
            this.좌우반전ToolStripMenuItem.Name = "좌우반전ToolStripMenuItem";
            this.좌우반전ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.좌우반전ToolStripMenuItem.Text = "좌우 반전";
            this.좌우반전ToolStripMenuItem.Click += new System.EventHandler(this.좌우반전ToolStripMenuItem_Click);
            // 
            // 회전90도ToolStripMenuItem
            // 
            this.회전90도ToolStripMenuItem.Name = "회전90도ToolStripMenuItem";
            this.회전90도ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.회전90도ToolStripMenuItem.Text = "회전(90도)";
            this.회전90도ToolStripMenuItem.Click += new System.EventHandler(this.회전90도ToolStripMenuItem_Click);
            // 
            // 회전180도ToolStripMenuItem
            // 
            this.회전180도ToolStripMenuItem.Name = "회전180도ToolStripMenuItem";
            this.회전180도ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.회전180도ToolStripMenuItem.Text = "회전(180도)";
            this.회전180도ToolStripMenuItem.Click += new System.EventHandler(this.회전180도ToolStripMenuItem_Click);
            // 
            // 회전270도ToolStripMenuItem
            // 
            this.회전270도ToolStripMenuItem.Name = "회전270도ToolStripMenuItem";
            this.회전270도ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.회전270도ToolStripMenuItem.Text = "회전(270도)";
            this.회전270도ToolStripMenuItem.Click += new System.EventHandler(this.회전270도ToolStripMenuItem_Click);
            // 
            // 영상처리2ToolStripMenuItem
            // 
            this.영상처리2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회색이미지ToolStripMenuItem,
            this.반전이미지ToolStripMenuItem,
            this.흑백이미지ToolStripMenuItem,
            this.블러링ToolStripMenuItem,
            this.윤곽선검출ToolStripMenuItem});
            this.영상처리2ToolStripMenuItem.Name = "영상처리2ToolStripMenuItem";
            this.영상처리2ToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.영상처리2ToolStripMenuItem.Text = "영상처리(2)";
            // 
            // 회색이미지ToolStripMenuItem
            // 
            this.회색이미지ToolStripMenuItem.Name = "회색이미지ToolStripMenuItem";
            this.회색이미지ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.회색이미지ToolStripMenuItem.Text = "회색 이미지";
            this.회색이미지ToolStripMenuItem.Click += new System.EventHandler(this.회색이미지ToolStripMenuItem_Click);
            // 
            // 반전이미지ToolStripMenuItem
            // 
            this.반전이미지ToolStripMenuItem.Name = "반전이미지ToolStripMenuItem";
            this.반전이미지ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.반전이미지ToolStripMenuItem.Text = "반전 이미지";
            this.반전이미지ToolStripMenuItem.Click += new System.EventHandler(this.반전이미지ToolStripMenuItem_Click);
            // 
            // 흑백이미지ToolStripMenuItem
            // 
            this.흑백이미지ToolStripMenuItem.Name = "흑백이미지ToolStripMenuItem";
            this.흑백이미지ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.흑백이미지ToolStripMenuItem.Text = "흑백 이미지";
            this.흑백이미지ToolStripMenuItem.Click += new System.EventHandler(this.흑백이미지ToolStripMenuItem_Click);
            // 
            // 블러링ToolStripMenuItem
            // 
            this.블러링ToolStripMenuItem.Name = "블러링ToolStripMenuItem";
            this.블러링ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.블러링ToolStripMenuItem.Text = "블러링";
            this.블러링ToolStripMenuItem.Click += new System.EventHandler(this.블러링ToolStripMenuItem_Click);
            // 
            // 윤곽선검출ToolStripMenuItem
            // 
            this.윤곽선검출ToolStripMenuItem.Name = "윤곽선검출ToolStripMenuItem";
            this.윤곽선검출ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.윤곽선검출ToolStripMenuItem.Text = "윤곽선 검출";
            this.윤곽선검출ToolStripMenuItem.Click += new System.EventHandler(this.윤곽선검출ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbox_image
            // 
            this.pbox_image.Location = new System.Drawing.Point(0, 28);
            this.pbox_image.Name = "pbox_image";
            this.pbox_image.Size = new System.Drawing.Size(279, 263);
            this.pbox_image.TabIndex = 1;
            this.pbox_image.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbox_image);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 영상처리1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 영상처리2ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pbox_image;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확대ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 축소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상하반전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 좌우반전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회전90도ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회전180도ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회전270도ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회색이미지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 반전이미지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 흑백이미지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 블러링ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 윤곽선검출ToolStripMenuItem;
    }
}


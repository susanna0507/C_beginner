namespace PJT09_Q
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
            this.label1 = new System.Windows.Forms.Label();
            this.rb_dog = new System.Windows.Forms.RadioButton();
            this.rb_cat = new System.Windows.Forms.RadioButton();
            this.rb_penguin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_view = new System.Windows.Forms.Button();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(173, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "좋아하는 동물은?";
            // 
            // rb_dog
            // 
            this.rb_dog.AutoSize = true;
            this.rb_dog.Location = new System.Drawing.Point(36, 34);
            this.rb_dog.Name = "rb_dog";
            this.rb_dog.Size = new System.Drawing.Size(59, 16);
            this.rb_dog.TabIndex = 1;
            this.rb_dog.TabStop = true;
            this.rb_dog.Text = "강아지";
            this.rb_dog.UseVisualStyleBackColor = true;
            
            // 
            // rb_cat
            // 
            this.rb_cat.AutoSize = true;
            this.rb_cat.Location = new System.Drawing.Point(162, 34);
            this.rb_cat.Name = "rb_cat";
            this.rb_cat.Size = new System.Drawing.Size(59, 16);
            this.rb_cat.TabIndex = 2;
            this.rb_cat.TabStop = true;
            this.rb_cat.Text = "고양이";
            this.rb_cat.UseVisualStyleBackColor = true;
            
            // 
            // rb_penguin
            // 
            this.rb_penguin.AutoSize = true;
            this.rb_penguin.Location = new System.Drawing.Point(304, 34);
            this.rb_penguin.Name = "rb_penguin";
            this.rb_penguin.Size = new System.Drawing.Size(47, 16);
            this.rb_penguin.TabIndex = 3;
            this.rb_penguin.TabStop = true;
            this.rb_penguin.Text = "펭귄";
            this.rb_penguin.UseVisualStyleBackColor = true;
            
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_dog);
            this.groupBox1.Controls.Add(this.rb_cat);
            this.groupBox1.Controls.Add(this.rb_penguin);
            this.groupBox1.Location = new System.Drawing.Point(81, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 77);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(226, 209);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(105, 45);
            this.btn_view.TabIndex = 5;
            this.btn_view.Text = "사진 보기";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // pb_image
            // 
            this.pb_image.Location = new System.Drawing.Point(154, 283);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(253, 235);
            this.pb_image.TabIndex = 6;
            this.pb_image.TabStop = false;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 548);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_dog;
        private System.Windows.Forms.RadioButton rb_cat;
        private System.Windows.Forms.RadioButton rb_penguin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.PictureBox pb_image;
    }
}


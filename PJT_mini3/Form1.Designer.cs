namespace PJT_mini3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_kor = new System.Windows.Forms.TextBox();
            this.tb_math = new System.Windows.Forms.TextBox();
            this.tb_eng = new System.Windows.Forms.TextBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.tb_avg = new System.Windows.Forms.TextBox();
            this.btn_Compute = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "국어";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "수학";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "영어";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "총점";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "평균";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_eng);
            this.groupBox1.Controls.Add(this.tb_math);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_kor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 182);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성적입력";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_total);
            this.groupBox2.Controls.Add(this.tb_avg);
            this.groupBox2.Location = new System.Drawing.Point(292, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 135);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tb_kor
            // 
            this.tb_kor.Location = new System.Drawing.Point(80, 20);
            this.tb_kor.Name = "tb_kor";
            this.tb_kor.Size = new System.Drawing.Size(81, 21);
            this.tb_kor.TabIndex = 6;
            // 
            // tb_math
            // 
            this.tb_math.Location = new System.Drawing.Point(80, 81);
            this.tb_math.Name = "tb_math";
            this.tb_math.Size = new System.Drawing.Size(81, 21);
            this.tb_math.TabIndex = 7;
            // 
            // tb_eng
            // 
            this.tb_eng.Location = new System.Drawing.Point(80, 138);
            this.tb_eng.Name = "tb_eng";
            this.tb_eng.Size = new System.Drawing.Size(81, 21);
            this.tb_eng.TabIndex = 8;
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(88, 30);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(81, 21);
            this.tb_total.TabIndex = 9;
            // 
            // tb_avg
            // 
            this.tb_avg.Location = new System.Drawing.Point(88, 82);
            this.tb_avg.Name = "tb_avg";
            this.tb_avg.Size = new System.Drawing.Size(81, 21);
            this.tb_avg.TabIndex = 10;
            // 
            // btn_Compute
            // 
            this.btn_Compute.Location = new System.Drawing.Point(380, 233);
            this.btn_Compute.Name = "btn_Compute";
            this.btn_Compute.Size = new System.Drawing.Size(110, 38);
            this.btn_Compute.TabIndex = 6;
            this.btn_Compute.Text = "계산";
            this.btn_Compute.UseVisualStyleBackColor = true;
            this.btn_Compute.Click += new System.EventHandler(this.btn_Compute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 292);
            this.Controls.Add(this.btn_Compute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_eng;
        private System.Windows.Forms.TextBox tb_math;
        private System.Windows.Forms.TextBox tb_kor;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.TextBox tb_avg;
        private System.Windows.Forms.Button btn_Compute;
    }
}


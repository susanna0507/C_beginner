namespace PJT09_4
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
            this.combo_lang = new System.Windows.Forms.ComboBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.list_lang = new System.Windows.Forms.ListBox();
            this.datepick_birth = new System.Windows.Forms.DateTimePicker();
            this.masktb_birth = new System.Windows.Forms.MaskedTextBox();
            this.masktb_tel = new System.Windows.Forms.MaskedTextBox();
            this.masktb_id = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo_lang
            // 
            this.combo_lang.FormattingEnabled = true;
            this.combo_lang.Items.AddRange(new object[] {
            "C#",
            "Java",
            "Python",
            "C++",
            "Go",
            "PHP",
            "JSP",
            "ASP.Net"});
            this.combo_lang.Location = new System.Drawing.Point(44, 50);
            this.combo_lang.Name = "combo_lang";
            this.combo_lang.Size = new System.Drawing.Size(150, 20);
            this.combo_lang.TabIndex = 0;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(222, 109);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(66, 40);
            this.btn_select.TabIndex = 1;
            this.btn_select.Text = ">>";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // list_lang
            // 
            this.list_lang.FormattingEnabled = true;
            this.list_lang.ItemHeight = 12;
            this.list_lang.Location = new System.Drawing.Point(329, 37);
            this.list_lang.Name = "list_lang";
            this.list_lang.Size = new System.Drawing.Size(123, 160);
            this.list_lang.TabIndex = 2;
            // 
            // datepick_birth
            // 
            this.datepick_birth.Location = new System.Drawing.Point(509, 37);
            this.datepick_birth.Name = "datepick_birth";
            this.datepick_birth.Size = new System.Drawing.Size(200, 21);
            this.datepick_birth.TabIndex = 3;
            this.datepick_birth.ValueChanged += new System.EventHandler(this.datepick_birth_ValueChanged);
            // 
            // masktb_birth
            // 
            this.masktb_birth.Location = new System.Drawing.Point(609, 88);
            this.masktb_birth.Mask = "0000년 90월 90일";
            this.masktb_birth.Name = "masktb_birth";
            this.masktb_birth.Size = new System.Drawing.Size(100, 21);
            this.masktb_birth.TabIndex = 4;
            this.masktb_birth.ValidatingType = typeof(System.DateTime);
            // 
            // masktb_tel
            // 
            this.masktb_tel.Location = new System.Drawing.Point(609, 133);
            this.masktb_tel.Mask = "(999)9000-0000";
            this.masktb_tel.Name = "masktb_tel";
            this.masktb_tel.Size = new System.Drawing.Size(100, 21);
            this.masktb_tel.TabIndex = 5;
            // 
            // masktb_id
            // 
            this.masktb_id.Location = new System.Drawing.Point(609, 176);
            this.masktb_id.Mask = "999999-9999999";
            this.masktb_id.Name = "masktb_id";
            this.masktb_id.Size = new System.Drawing.Size(100, 21);
            this.masktb_id.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "출생연월일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "연락처";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "주민번호";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 272);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.masktb_id);
            this.Controls.Add(this.masktb_tel);
            this.Controls.Add(this.masktb_birth);
            this.Controls.Add(this.datepick_birth);
            this.Controls.Add(this.list_lang);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.combo_lang);
            this.Name = "Form1";
            this.Text = "다양한 컨트롤";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_lang;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.ListBox list_lang;
        private System.Windows.Forms.DateTimePicker datepick_birth;
        private System.Windows.Forms.MaskedTextBox masktb_birth;
        private System.Windows.Forms.MaskedTextBox masktb_tel;
        private System.Windows.Forms.MaskedTextBox masktb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


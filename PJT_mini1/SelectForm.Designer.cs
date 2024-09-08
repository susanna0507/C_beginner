namespace PJT_mini1
{
    partial class SelectForm
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
            this.list_member = new System.Windows.Forms.ListView();
            this.btn_sel_update = new System.Windows.Forms.Button();
            this.btn_sel_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(156, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원 조회";
            // 
            // list_member
            // 
            this.list_member.HideSelection = false;
            this.list_member.Location = new System.Drawing.Point(83, 114);
            this.list_member.Name = "list_member";
            this.list_member.Size = new System.Drawing.Size(292, 183);
            this.list_member.TabIndex = 1;
            this.list_member.UseCompatibleStateImageBehavior = false;
            // 
            // btn_sel_update
            // 
            this.btn_sel_update.Location = new System.Drawing.Point(108, 338);
            this.btn_sel_update.Name = "btn_sel_update";
            this.btn_sel_update.Size = new System.Drawing.Size(108, 29);
            this.btn_sel_update.TabIndex = 2;
            this.btn_sel_update.Text = "선택 회원 수정";
            this.btn_sel_update.UseVisualStyleBackColor = true;
            this.btn_sel_update.Click += new System.EventHandler(this.btn_sel_update_Click);
            // 
            // btn_sel_delete
            // 
            this.btn_sel_delete.Location = new System.Drawing.Point(246, 338);
            this.btn_sel_delete.Name = "btn_sel_delete";
            this.btn_sel_delete.Size = new System.Drawing.Size(108, 29);
            this.btn_sel_delete.TabIndex = 3;
            this.btn_sel_delete.Text = "선택 회원 삭제";
            this.btn_sel_delete.UseVisualStyleBackColor = true;
            this.btn_sel_delete.Click += new System.EventHandler(this.btn_sel_delete_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 420);
            this.Controls.Add(this.btn_sel_delete);
            this.Controls.Add(this.btn_sel_update);
            this.Controls.Add(this.list_member);
            this.Controls.Add(this.label1);
            this.Name = "SelectForm";
            this.Text = "회원 조회";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectForm_FormClosed);
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView list_member;
        private System.Windows.Forms.Button btn_sel_update;
        private System.Windows.Forms.Button btn_sel_delete;
    }
}
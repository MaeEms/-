namespace CommunityEpidemicManagementSystem
{
    partial class AdministratorTaskAdd
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
            this.components = new System.ComponentModel.Container();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.dtpDeadLine = new System.Windows.Forms.DateTimePicker();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.AdministratorTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AdministratorTaskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbWorker
            // 
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(246, 79);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(540, 35);
            this.cmbWorker.TabIndex = 81;
            // 
            // dtpDeadLine
            // 
            this.dtpDeadLine.Checked = false;
            this.dtpDeadLine.Location = new System.Drawing.Point(246, 155);
            this.dtpDeadLine.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtpDeadLine.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpDeadLine.Name = "dtpDeadLine";
            this.dtpDeadLine.Size = new System.Drawing.Size(540, 38);
            this.dtpDeadLine.TabIndex = 80;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(390, 706);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 52);
            this.btnOk.TabIndex = 79;
            this.btnOk.Text = "确 定";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 78;
            this.label1.Text = "任务内容：";
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(246, 238);
            this.txtTask.Margin = new System.Windows.Forms.Padding(7);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(540, 337);
            this.txtTask.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 76;
            this.label3.Text = "工作人员：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 27);
            this.label4.TabIndex = 75;
            this.label4.Text = "截止时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 629);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 83;
            this.label2.Text = "备注：";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(246, 618);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(540, 38);
            this.txtComment.TabIndex = 84;
            // 
            // AdministratorTaskAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 807);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbWorker);
            this.Controls.Add(this.dtpDeadLine);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "AdministratorTaskAdd";
            this.Text = "布置任务";
            ((System.ComponentModel.ISupportInitialize)(this.AdministratorTaskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbWorker;
        private System.Windows.Forms.DateTimePicker dtpDeadLine;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.BindingSource AdministratorTaskBindingSource;
    }
}
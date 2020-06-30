namespace CommunityEpidemicManagementSystem
{
    partial class MissionAddResident
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
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMissionContent = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMissionTitle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDeadLine = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.MissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MissionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(514, 675);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 52);
            this.btnOk.TabIndex = 62;
            this.btnOk.Text = "确 认";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 596);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 61;
            this.label1.Text = "备注：";
            // 
            // txtMissionContent
            // 
            this.txtMissionContent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MissionBindingSource, "Description", true));
            this.txtMissionContent.Location = new System.Drawing.Point(243, 218);
            this.txtMissionContent.Margin = new System.Windows.Forms.Padding(7);
            this.txtMissionContent.Multiline = true;
            this.txtMissionContent.Name = "txtMissionContent";
            this.txtMissionContent.Size = new System.Drawing.Size(788, 337);
            this.txtMissionContent.TabIndex = 60;
            // 
            // txtComment
            // 
            this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MissionBindingSource, "Remark", true));
            this.txtComment.Location = new System.Drawing.Point(243, 585);
            this.txtComment.Margin = new System.Windows.Forms.Padding(7);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(788, 38);
            this.txtComment.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 57;
            this.label3.Text = "截止时间：";
            // 
            // txtMissionTitle
            // 
            this.txtMissionTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MissionBindingSource, "Title", true));
            this.txtMissionTitle.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMissionTitle.Location = new System.Drawing.Point(243, 79);
            this.txtMissionTitle.Margin = new System.Windows.Forms.Padding(7);
            this.txtMissionTitle.Name = "txtMissionTitle";
            this.txtMissionTitle.Size = new System.Drawing.Size(788, 38);
            this.txtMissionTitle.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 27);
            this.label11.TabIndex = 53;
            this.label11.Text = "需求标题：";
            // 
            // dtpDeadLine
            // 
            this.dtpDeadLine.Checked = false;
            this.dtpDeadLine.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.MissionBindingSource, "DDLTime", true));
            this.dtpDeadLine.Location = new System.Drawing.Point(243, 145);
            this.dtpDeadLine.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtpDeadLine.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpDeadLine.Name = "dtpDeadLine";
            this.dtpDeadLine.Size = new System.Drawing.Size(788, 38);
            this.dtpDeadLine.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 27);
            this.label4.TabIndex = 56;
            this.label4.Text = "需求内容：";
            // 
            // MissionBindingSource
            // 
            this.MissionBindingSource.DataSource = typeof(CommunityEpidemicManagementSystem.ResidentMission);
            // 
            // MissionAddResident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 778);
            this.Controls.Add(this.dtpDeadLine);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMissionContent);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMissionTitle);
            this.Controls.Add(this.label11);
            this.Name = "MissionAddResident";
            this.Text = "添加订单";
            ((System.ComponentModel.ISupportInitialize)(this.MissionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMissionContent;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMissionTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDeadLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource MissionBindingSource;
    }
}
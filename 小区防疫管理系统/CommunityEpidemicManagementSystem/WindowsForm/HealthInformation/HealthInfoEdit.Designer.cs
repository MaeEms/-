namespace CommunityEpidemicManagementSystem
{
    partial class HealthInfoEdit
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
            this.cmbHealthyStatus = new System.Windows.Forms.ComboBox();
            this.HealthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HealthBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHealthyStatus
            // 
            this.cmbHealthyStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHealthyStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbHealthyStatus.FormattingEnabled = true;
            this.cmbHealthyStatus.Items.AddRange(new object[] {
            "健康",
            "隔离中",
            "确诊"});
            this.cmbHealthyStatus.Location = new System.Drawing.Point(243, 279);
            this.cmbHealthyStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHealthyStatus.Name = "cmbHealthyStatus";
            this.cmbHealthyStatus.Size = new System.Drawing.Size(788, 35);
            this.cmbHealthyStatus.TabIndex = 52;
            // 
            // HealthBindingSource
            // 
            this.HealthBindingSource.DataSource = typeof(CommunityEpidemicManagementSystem.HealthInformation);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(514, 725);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 52);
            this.btnOk.TabIndex = 51;
            this.btnOk.Text = "确 认";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 351);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 50;
            this.label1.Text = "备注：";
            // 
            // txtComment
            // 
            this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.HealthBindingSource, "Comment", true));
            this.txtComment.Location = new System.Drawing.Point(243, 344);
            this.txtComment.Margin = new System.Windows.Forms.Padding(7);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(788, 337);
            this.txtComment.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 48;
            this.label2.Text = "健康状态：";
            // 
            // txtTemperature
            // 
            this.txtTemperature.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.HealthBindingSource, "Temperature", true));
            this.txtTemperature.Location = new System.Drawing.Point(243, 209);
            this.txtTemperature.Margin = new System.Windows.Forms.Padding(7);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(788, 38);
            this.txtTemperature.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 46;
            this.label3.Text = "证件号码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 27);
            this.label4.TabIndex = 45;
            this.label4.Text = "体温：";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtName.Location = new System.Drawing.Point(243, 79);
            this.txtName.Margin = new System.Windows.Forms.Padding(7);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(788, 38);
            this.txtName.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(140, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 27);
            this.label11.TabIndex = 42;
            this.label11.Text = "姓名：";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(243, 146);
            this.txtId.Margin = new System.Windows.Forms.Padding(7);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(788, 38);
            this.txtId.TabIndex = 44;
            // 
            // HealthInfoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 823);
            this.Controls.Add(this.cmbHealthyStatus);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HealthInfoEdit";
            this.Text = "健康信息";
            ((System.ComponentModel.ISupportInitialize)(this.HealthBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHealthyStatus;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.BindingSource HealthBindingSource;
    }
}
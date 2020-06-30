namespace CommunityEpidemicManagementSystem
{
    partial class AccessManagementAddOut
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
            this.txtHealthStatus = new System.Windows.Forms.TextBox();
            this.VisitorAccessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorAccessBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHealthStatus
            // 
            this.txtHealthStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VisitorAccessBindingSource, "HealthState", true));
            this.txtHealthStatus.Location = new System.Drawing.Point(261, 261);
            this.txtHealthStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtHealthStatus.Name = "txtHealthStatus";
            this.txtHealthStatus.Size = new System.Drawing.Size(536, 38);
            this.txtHealthStatus.TabIndex = 47;
            // 
            // VisitorAccessBindingSource
            // 
            this.VisitorAccessBindingSource.DataSource = typeof(CommunityEpidemicManagementSystem.VisitorAccessManagement);
            // 
            // txtPurpose
            // 
            this.txtPurpose.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VisitorAccessBindingSource, "AccessPurpose", true));
            this.txtPurpose.Location = new System.Drawing.Point(261, 398);
            this.txtPurpose.Margin = new System.Windows.Forms.Padding(4);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(788, 38);
            this.txtPurpose.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 337);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 27);
            this.label8.TabIndex = 43;
            this.label8.Text = "体温：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 27);
            this.label7.TabIndex = 42;
            this.label7.Text = "联系方式：";
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VisitorAccessBindingSource, "IDCard", true));
            this.txtId.Location = new System.Drawing.Point(261, 130);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(536, 38);
            this.txtId.TabIndex = 40;
            // 
            // txtTel
            // 
            this.txtTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VisitorAccessBindingSource, "PhoneNumber", true));
            this.txtTel.Location = new System.Drawing.Point(261, 194);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(536, 38);
            this.txtTel.TabIndex = 39;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VisitorAccessBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(261, 65);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(536, 38);
            this.txtName.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 466);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 27);
            this.label6.TabIndex = 37;
            this.label6.Text = "备注：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 27);
            this.label5.TabIndex = 36;
            this.label5.Text = "证件号码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 405);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 35;
            this.label3.Text = "到访目的：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 34;
            this.label2.Text = "姓名：";
            // 
            // txtComment
            // 
            this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VisitorAccessBindingSource, "Notes", true));
            this.txtComment.Location = new System.Drawing.Point(261, 466);
            this.txtComment.Margin = new System.Windows.Forms.Padding(7);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(788, 337);
            this.txtComment.TabIndex = 61;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(630, 842);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 52);
            this.btnCancel.TabIndex = 68;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(416, 842);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 52);
            this.btnOk.TabIndex = 67;
            this.btnOk.Text = "添 加";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // txtTemperature
            // 
            this.txtTemperature.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VisitorAccessBindingSource, "Tempreture", true));
            this.txtTemperature.Location = new System.Drawing.Point(261, 326);
            this.txtTemperature.Margin = new System.Windows.Forms.Padding(4);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(536, 38);
            this.txtTemperature.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 69;
            this.label1.Text = "健康状态：";
            // 
            // AccessManagementAddOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 945);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtHealthStatus);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccessManagementAddOut";
            this.Text = "添加记录";
            ((System.ComponentModel.ISupportInitialize)(this.VisitorAccessBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHealthStatus;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource VisitorAccessBindingSource;
    }
}
namespace CommunityEpidemicManagementSystem
{
    partial class AccessManagementAdd
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
            this.txtComment = new System.Windows.Forms.TextBox();
            this.ResidentAccessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAccess = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResidentAccessBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(494, 679);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 52);
            this.btnOk.TabIndex = 51;
            this.btnOk.Text = "添 加";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 299);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 50;
            this.label1.Text = "备注：";
            // 
            // txtComment
            // 
            this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ResidentAccessBindingSource, "Notes", true));
            this.txtComment.Location = new System.Drawing.Point(215, 295);
            this.txtComment.Margin = new System.Windows.Forms.Padding(7);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(788, 337);
            this.txtComment.TabIndex = 49;
            // 
            // ResidentAccessBindingSource
            // 
            this.ResidentAccessBindingSource.DataSource = typeof(CommunityEpidemicManagementSystem.ResidentAccessManagement);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 46;
            this.label3.Text = "体温：";
            // 
            // txtTemperature
            // 
            this.txtTemperature.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ResidentAccessBindingSource, "Tempreture", true));
            this.txtTemperature.Location = new System.Drawing.Point(215, 151);
            this.txtTemperature.Margin = new System.Windows.Forms.Padding(7);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(788, 38);
            this.txtTemperature.TabIndex = 44;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ResidentAccessBindingSource, "ResidentAccessManagementId", true));
            this.txtId.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtId.Location = new System.Drawing.Point(215, 79);
            this.txtId.Margin = new System.Windows.Forms.Padding(7);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(546, 38);
            this.txtId.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 27);
            this.label11.TabIndex = 42;
            this.label11.Text = "用户名：";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(793, 77);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(212, 52);
            this.btnQuery.TabIndex = 53;
            this.btnQuery.Text = "查询健康状态";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 27);
            this.label2.TabIndex = 56;
            this.label2.Text = "出/入：";
            // 
            // cmbAccess
            // 
            this.cmbAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccess.FormattingEnabled = true;
            this.cmbAccess.Items.AddRange(new object[] {
            "入",
            "出"});
            this.cmbAccess.Location = new System.Drawing.Point(215, 227);
            this.cmbAccess.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAccess.Name = "cmbAccess";
            this.cmbAccess.Size = new System.Drawing.Size(788, 35);
            this.cmbAccess.TabIndex = 57;
            // 
            // AccessManagementAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 772);
            this.Controls.Add(this.cmbAccess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccessManagementAdd";
            this.Text = "添加记录";
            ((System.ComponentModel.ISupportInitialize)(this.ResidentAccessBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAccess;
        private System.Windows.Forms.BindingSource ResidentAccessBindingSource;
    }
}
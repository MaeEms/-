namespace CommunityEpidemicManagementSystem
{
    partial class InformationEdit
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.cmbRelationship = new System.Windows.Forms.ComboBox();
            this.ResidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ResidentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(242, 132);
            this.txtId.Margin = new System.Windows.Forms.Padding(7);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(788, 38);
            this.txtId.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtName.Location = new System.Drawing.Point(242, 67);
            this.txtName.Margin = new System.Windows.Forms.Padding(7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(788, 38);
            this.txtName.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(139, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 27);
            this.label11.TabIndex = 27;
            this.label11.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 27);
            this.label2.TabIndex = 37;
            this.label2.Text = "与户主关系：";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(242, 196);
            this.txtTel.Margin = new System.Windows.Forms.Padding(7);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(788, 38);
            this.txtTel.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 33;
            this.label3.Text = "身份证号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 27);
            this.label4.TabIndex = 32;
            this.label4.Text = "联系方式：";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(242, 331);
            this.txtComment.Margin = new System.Windows.Forms.Padding(7);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(788, 337);
            this.txtComment.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 39;
            this.label1.Text = "备注：";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(500, 713);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 52);
            this.btnOk.TabIndex = 40;
            this.btnOk.Text = "确 认";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // cmbRelationship
            // 
            this.cmbRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelationship.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRelationship.FormattingEnabled = true;
            this.cmbRelationship.Items.AddRange(new object[] {
            "户主",
            "丈夫",
            "妻子",
            "儿子",
            "女儿",
            "父亲",
            "母亲",
            "孙子/外孙子",
            "孙女/外孙女",
            "祖父/外祖父",
            "祖母/外祖母",
            "其它"});
            this.cmbRelationship.Location = new System.Drawing.Point(242, 266);
            this.cmbRelationship.Name = "cmbRelationship";
            this.cmbRelationship.Size = new System.Drawing.Size(788, 35);
            this.cmbRelationship.TabIndex = 41;
            // 
            // InformationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 810);
            this.Controls.Add(this.cmbRelationship);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label11);
            this.Name = "InformationEdit";
            this.Text = "居民信息";
            ((System.ComponentModel.ISupportInitialize)(this.ResidentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cmbRelationship;
        private System.Windows.Forms.BindingSource ResidentBindingSource;
    }
}
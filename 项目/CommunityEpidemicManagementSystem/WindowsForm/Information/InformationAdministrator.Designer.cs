namespace CommunityEpidemicManagementSystem
{
    partial class InformationAdministrator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.cmbQuery = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvInfromation = new System.Windows.Forms.DataGridView();
            this.InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.健康状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfromation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.txtQuery);
            this.panel1.Controls.Add(this.cmbQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 68);
            this.panel1.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(474, 19);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(86, 29);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查 询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(232, 24);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(209, 25);
            this.txtQuery.TabIndex = 1;
            // 
            // cmbQuery
            // 
            this.cmbQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuery.FormattingEnabled = true;
            this.cmbQuery.Items.AddRange(new object[] {
            "全部",
            "按姓名查询",
            "按用户名查询",
            "未审核",
            "健康",
            "隔离",
            "患病"});
            this.cmbQuery.Location = new System.Drawing.Point(31, 24);
            this.cmbQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbQuery.Name = "cmbQuery";
            this.cmbQuery.Size = new System.Drawing.Size(174, 23);
            this.cmbQuery.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 587);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 60);
            this.panel2.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Location = new System.Drawing.Point(511, 18);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 29);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "编 辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvInfromation);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(6, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(14, 6, 14, 14);
            this.groupBox1.Size = new System.Drawing.Size(1130, 513);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "居民信息";
            // 
            // dgvInfromation
            // 
            this.dgvInfromation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfromation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column7,
            this.健康状态});
            this.dgvInfromation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfromation.Location = new System.Drawing.Point(14, 24);
            this.dgvInfromation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvInfromation.Name = "dgvInfromation";
            this.dgvInfromation.RowHeadersWidth = 92;
            this.dgvInfromation.RowTemplate.Height = 40;
            this.dgvInfromation.Size = new System.Drawing.Size(1102, 475);
            this.dgvInfromation.TabIndex = 1;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "用户名";
            this.Column9.MinimumWidth = 11;
            this.Column9.Name = "Column9";
            this.Column9.Width = 225;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "姓名";
            this.Column1.MinimumWidth = 11;
            this.Column1.Name = "Column1";
            this.Column1.Width = 225;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "性别";
            this.Column2.MinimumWidth = 11;
            this.Column2.Name = "Column2";
            this.Column2.Width = 225;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "年龄";
            this.Column3.MinimumWidth = 11;
            this.Column3.Name = "Column3";
            this.Column3.Width = 225;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "身份证号";
            this.Column4.MinimumWidth = 11;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "联系方式（选填）";
            this.Column5.MinimumWidth = 11;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "与户主关系";
            this.Column6.MinimumWidth = 11;
            this.Column6.Name = "Column6";
            this.Column6.Width = 225;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "状态";
            this.Column8.MinimumWidth = 11;
            this.Column8.Name = "Column8";
            this.Column8.Width = 225;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "备注";
            this.Column7.MinimumWidth = 11;
            this.Column7.Name = "Column7";
            this.Column7.Width = 200;
            // 
            // 健康状态
            // 
            this.健康状态.HeaderText = "健康状态";
            this.健康状态.MinimumWidth = 6;
            this.健康状态.Name = "健康状态";
            this.健康状态.Width = 125;
            // 
            // InformationAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InformationAdministrator";
            this.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Text = "居民信息";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfromation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ComboBox cmbQuery;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvInfromation;
        private System.Windows.Forms.BindingSource InfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn 健康状态;
    }
}
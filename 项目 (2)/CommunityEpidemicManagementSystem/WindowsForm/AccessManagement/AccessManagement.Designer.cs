namespace CommunityEpidemicManagementSystem
{
    partial class AccessManagement
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAccess = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.cmbQuery = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAccessOut = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQueryOut = new System.Windows.Forms.Button();
            this.txtQueryOut = new System.Windows.Forms.TextBox();
            this.cmbQueryOut = new System.Windows.Forms.ComboBox();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnAddOut = new System.Windows.Forms.Button();
            this.ResidentAccessManagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VisitorAccessManagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccess)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessOut)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResidentAccessManagementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorAccessManagementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1675, 982);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(10, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(1655, 926);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " 小区人员出入管理 ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAccess);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(1635, 801);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "出入记录";
            // 
            // dgvAccess
            // 
            this.dgvAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column14,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column13,
            this.Column7});
            this.dgvAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccess.Location = new System.Drawing.Point(10, 41);
            this.dgvAccess.Name = "dgvAccess";
            this.dgvAccess.RowHeadersWidth = 92;
            this.dgvAccess.RowTemplate.Height = 40;
            this.dgvAccess.Size = new System.Drawing.Size(1615, 750);
            this.dgvAccess.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "编号";
            this.Column1.MinimumWidth = 11;
            this.Column1.Name = "Column1";
            this.Column1.Width = 225;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "居民ID";
            this.Column14.MinimumWidth = 11;
            this.Column14.Name = "Column14";
            this.Column14.Width = 225;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "姓名";
            this.Column2.MinimumWidth = 11;
            this.Column2.Name = "Column2";
            this.Column2.Width = 225;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "体温";
            this.Column4.MinimumWidth = 11;
            this.Column4.Name = "Column4";
            this.Column4.Width = 225;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "出入时间";
            this.Column3.MinimumWidth = 11;
            this.Column3.Name = "Column3";
            this.Column3.Width = 225;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "出/入";
            this.Column13.MinimumWidth = 11;
            this.Column13.Name = "Column13";
            this.Column13.Width = 225;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "备注";
            this.Column7.MinimumWidth = 11;
            this.Column7.Name = "Column7";
            this.Column7.Width = 225;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.txtQuery);
            this.panel1.Controls.Add(this.cmbQuery);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1635, 105);
            this.panel1.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(806, 27);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(150, 52);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "查 询";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(390, 37);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(362, 38);
            this.txtQuery.TabIndex = 8;
            // 
            // cmbQuery
            // 
            this.cmbQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuery.FormattingEnabled = true;
            this.cmbQuery.Items.AddRange(new object[] {
            "全部",
            "按姓名查询",
            "按日期查询"});
            this.cmbQuery.Location = new System.Drawing.Point(40, 37);
            this.cmbQuery.Name = "cmbQuery";
            this.cmbQuery.Size = new System.Drawing.Size(301, 35);
            this.cmbQuery.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Location = new System.Drawing.Point(1036, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(202, 52);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加记录";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(10, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Size = new System.Drawing.Size(1655, 926);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " 外来人员出入管理 ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAccessOut);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(1635, 801);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "到访记录";
            // 
            // dgvAccessOut
            // 
            this.dgvAccessOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccessOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column6,
            this.Column8,
            this.Column11,
            this.dataGridViewTextBoxColumn3,
            this.Column10,
            this.Column9,
            this.Column12,
            this.Column5,
            this.dataGridViewTextBoxColumn5});
            this.dgvAccessOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccessOut.Location = new System.Drawing.Point(10, 41);
            this.dgvAccessOut.Name = "dgvAccessOut";
            this.dgvAccessOut.RowHeadersWidth = 92;
            this.dgvAccessOut.RowTemplate.Height = 40;
            this.dgvAccessOut.Size = new System.Drawing.Size(1615, 750);
            this.dgvAccessOut.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "编号";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "证件号码";
            this.Column6.MinimumWidth = 11;
            this.Column6.Name = "Column6";
            this.Column6.Width = 225;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "联系方式";
            this.Column8.MinimumWidth = 11;
            this.Column8.Name = "Column8";
            this.Column8.Width = 80;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "健康状态";
            this.Column11.MinimumWidth = 11;
            this.Column11.Name = "Column11";
            this.Column11.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "体温";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "到访时间";
            this.Column10.MinimumWidth = 11;
            this.Column10.Name = "Column10";
            this.Column10.Width = 80;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "到访目的";
            this.Column9.MinimumWidth = 11;
            this.Column9.Name = "Column9";
            this.Column9.Width = 225;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "离开时间";
            this.Column12.MinimumWidth = 11;
            this.Column12.Name = "Column12";
            this.Column12.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "登记人员";
            this.Column5.MinimumWidth = 11;
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "备注";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 225;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQueryOut);
            this.panel2.Controls.Add(this.txtQueryOut);
            this.panel2.Controls.Add(this.cmbQueryOut);
            this.panel2.Controls.Add(this.btnLeave);
            this.panel2.Controls.Add(this.btnAddOut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1635, 105);
            this.panel2.TabIndex = 3;
            // 
            // btnQueryOut
            // 
            this.btnQueryOut.Location = new System.Drawing.Point(809, 28);
            this.btnQueryOut.Name = "btnQueryOut";
            this.btnQueryOut.Size = new System.Drawing.Size(150, 52);
            this.btnQueryOut.TabIndex = 10;
            this.btnQueryOut.Text = "查 询";
            this.btnQueryOut.UseVisualStyleBackColor = true;
            // 
            // txtQueryOut
            // 
            this.txtQueryOut.Location = new System.Drawing.Point(391, 38);
            this.txtQueryOut.Name = "txtQueryOut";
            this.txtQueryOut.Size = new System.Drawing.Size(362, 38);
            this.txtQueryOut.TabIndex = 9;
            // 
            // cmbQueryOut
            // 
            this.cmbQueryOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQueryOut.FormattingEnabled = true;
            this.cmbQueryOut.Items.AddRange(new object[] {
            "全部",
            "按姓名查询",
            "按日期查询"});
            this.cmbQueryOut.Location = new System.Drawing.Point(41, 38);
            this.cmbQueryOut.Name = "cmbQueryOut";
            this.cmbQueryOut.Size = new System.Drawing.Size(301, 35);
            this.cmbQueryOut.TabIndex = 8;
            // 
            // btnLeave
            // 
            this.btnLeave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLeave.Location = new System.Drawing.Point(1334, 28);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(202, 52);
            this.btnLeave.TabIndex = 7;
            this.btnLeave.Text = "访客离开";
            this.btnLeave.UseVisualStyleBackColor = true;
            // 
            // btnAddOut
            // 
            this.btnAddOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddOut.Location = new System.Drawing.Point(1057, 28);
            this.btnAddOut.Name = "btnAddOut";
            this.btnAddOut.Size = new System.Drawing.Size(202, 52);
            this.btnAddOut.TabIndex = 6;
            this.btnAddOut.Text = "添加到访记录";
            this.btnAddOut.UseVisualStyleBackColor = true;
            // 
            // AccessManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 996);
            this.Controls.Add(this.tabControl1);
            this.Name = "AccessManagement";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Text = "出入管理";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccess)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessOut)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResidentAccessManagementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorAccessManagementBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvAccess;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAccessOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddOut;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnQueryOut;
        private System.Windows.Forms.TextBox txtQueryOut;
        private System.Windows.Forms.ComboBox cmbQueryOut;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ComboBox cmbQuery;
        private System.Windows.Forms.BindingSource ResidentAccessManagementBindingSource;
        private System.Windows.Forms.BindingSource VisitorAccessManagementBindingSource;
    }
}
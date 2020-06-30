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
            this.ResidentAccessManagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.cmbQuery = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAccessOut = new System.Windows.Forms.DataGridView();
            this.VisitorAccessManagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQueryOut = new System.Windows.Forms.Button();
            this.txtQueryOut = new System.Windows.Forms.TextBox();
            this.cmbQueryOut = new System.Windows.Forms.ComboBox();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnAddOut = new System.Windows.Forms.Button();
            this.residentAccessManagementIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempretureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorAccessManagementIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempretureDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessPurposeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResidentAccessManagementBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorAccessManagementBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1675, 981);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(10, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.tabPage1.Size = new System.Drawing.Size(1655, 925);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " 小区人员出入管理 ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAccess);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.groupBox1.Size = new System.Drawing.Size(1635, 799);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "出入记录";
            // 
            // dgvAccess
            // 
            this.dgvAccess.AutoGenerateColumns = false;
            this.dgvAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.residentAccessManagementIdDataGridViewTextBoxColumn,
            this.residentIdDataGridViewTextBoxColumn,
            this.tempretureDataGridViewTextBoxColumn,
            this.accessTimeDataGridViewTextBoxColumn,
            this.inOutDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dgvAccess.DataSource = this.ResidentAccessManagementBindingSource;
            this.dgvAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccess.Location = new System.Drawing.Point(10, 42);
            this.dgvAccess.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAccess.Name = "dgvAccess";
            this.dgvAccess.RowHeadersWidth = 92;
            this.dgvAccess.RowTemplate.Height = 40;
            this.dgvAccess.Size = new System.Drawing.Size(1615, 746);
            this.dgvAccess.TabIndex = 0;
            // 
            // ResidentAccessManagementBindingSource
            // 
            this.ResidentAccessManagementBindingSource.DataSource = typeof(CommunityEpidemicManagementSystem.ResidentAccessManagement);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.txtQuery);
            this.panel1.Controls.Add(this.cmbQuery);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1635, 104);
            this.panel1.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(807, 27);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(150, 52);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "查 询";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(390, 38);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(363, 38);
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
            this.cmbQuery.Location = new System.Drawing.Point(40, 38);
            this.cmbQuery.Margin = new System.Windows.Forms.Padding(4);
            this.cmbQuery.Name = "cmbQuery";
            this.cmbQuery.Size = new System.Drawing.Size(302, 35);
            this.cmbQuery.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Location = new System.Drawing.Point(1035, 27);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(201, 52);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加记录";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(10, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.tabPage2.Size = new System.Drawing.Size(1655, 925);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " 外来人员出入管理 ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAccessOut);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 115);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.groupBox2.Size = new System.Drawing.Size(1635, 799);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "到访记录";
            // 
            // dgvAccessOut
            // 
            this.dgvAccessOut.AutoGenerateColumns = false;
            this.dgvAccessOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccessOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitorAccessManagementIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.iDCardDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.healthStateDataGridViewTextBoxColumn,
            this.tempretureDataGridViewTextBoxColumn1,
            this.accessTimeDataGridViewTextBoxColumn1,
            this.accessPurposeDataGridViewTextBoxColumn,
            this.leaveTimeDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn1});
            this.dgvAccessOut.DataSource = this.VisitorAccessManagementBindingSource;
            this.dgvAccessOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccessOut.Location = new System.Drawing.Point(10, 42);
            this.dgvAccessOut.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAccessOut.Name = "dgvAccessOut";
            this.dgvAccessOut.RowHeadersWidth = 92;
            this.dgvAccessOut.RowTemplate.Height = 40;
            this.dgvAccessOut.Size = new System.Drawing.Size(1615, 746);
            this.dgvAccessOut.TabIndex = 0;
            // 
            // VisitorAccessManagementBindingSource
            // 
            this.VisitorAccessManagementBindingSource.DataSource = typeof(CommunityEpidemicManagementSystem.VisitorAccessManagement);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQueryOut);
            this.panel2.Controls.Add(this.txtQueryOut);
            this.panel2.Controls.Add(this.cmbQueryOut);
            this.panel2.Controls.Add(this.btnLeave);
            this.panel2.Controls.Add(this.btnAddOut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1635, 104);
            this.panel2.TabIndex = 3;
            // 
            // btnQueryOut
            // 
            this.btnQueryOut.Location = new System.Drawing.Point(808, 29);
            this.btnQueryOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueryOut.Name = "btnQueryOut";
            this.btnQueryOut.Size = new System.Drawing.Size(150, 52);
            this.btnQueryOut.TabIndex = 10;
            this.btnQueryOut.Text = "查 询";
            this.btnQueryOut.UseVisualStyleBackColor = true;
            // 
            // txtQueryOut
            // 
            this.txtQueryOut.Location = new System.Drawing.Point(390, 38);
            this.txtQueryOut.Margin = new System.Windows.Forms.Padding(4);
            this.txtQueryOut.Name = "txtQueryOut";
            this.txtQueryOut.Size = new System.Drawing.Size(363, 38);
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
            this.cmbQueryOut.Location = new System.Drawing.Point(40, 38);
            this.cmbQueryOut.Margin = new System.Windows.Forms.Padding(4);
            this.cmbQueryOut.Name = "cmbQueryOut";
            this.cmbQueryOut.Size = new System.Drawing.Size(302, 35);
            this.cmbQueryOut.TabIndex = 8;
            // 
            // btnLeave
            // 
            this.btnLeave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLeave.Location = new System.Drawing.Point(1332, 29);
            this.btnLeave.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(201, 52);
            this.btnLeave.TabIndex = 7;
            this.btnLeave.Text = "访客离开";
            this.btnLeave.UseVisualStyleBackColor = true;
            // 
            // btnAddOut
            // 
            this.btnAddOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddOut.Location = new System.Drawing.Point(1056, 29);
            this.btnAddOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddOut.Name = "btnAddOut";
            this.btnAddOut.Size = new System.Drawing.Size(201, 52);
            this.btnAddOut.TabIndex = 6;
            this.btnAddOut.Text = "添加到访记录";
            this.btnAddOut.UseVisualStyleBackColor = true;
            // 
            // residentAccessManagementIdDataGridViewTextBoxColumn
            // 
            this.residentAccessManagementIdDataGridViewTextBoxColumn.DataPropertyName = "ResidentAccessManagementId";
            this.residentAccessManagementIdDataGridViewTextBoxColumn.HeaderText = "出入ID";
            this.residentAccessManagementIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.residentAccessManagementIdDataGridViewTextBoxColumn.Name = "residentAccessManagementIdDataGridViewTextBoxColumn";
            this.residentAccessManagementIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // residentIdDataGridViewTextBoxColumn
            // 
            this.residentIdDataGridViewTextBoxColumn.DataPropertyName = "ResidentId";
            this.residentIdDataGridViewTextBoxColumn.HeaderText = "用户ID";
            this.residentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.residentIdDataGridViewTextBoxColumn.Name = "residentIdDataGridViewTextBoxColumn";
            this.residentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // tempretureDataGridViewTextBoxColumn
            // 
            this.tempretureDataGridViewTextBoxColumn.DataPropertyName = "Tempreture";
            this.tempretureDataGridViewTextBoxColumn.HeaderText = "体温";
            this.tempretureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tempretureDataGridViewTextBoxColumn.Name = "tempretureDataGridViewTextBoxColumn";
            this.tempretureDataGridViewTextBoxColumn.Width = 125;
            // 
            // accessTimeDataGridViewTextBoxColumn
            // 
            this.accessTimeDataGridViewTextBoxColumn.DataPropertyName = "AccessTime";
            this.accessTimeDataGridViewTextBoxColumn.HeaderText = "到达时间";
            this.accessTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accessTimeDataGridViewTextBoxColumn.Name = "accessTimeDataGridViewTextBoxColumn";
            this.accessTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // inOutDataGridViewTextBoxColumn
            // 
            this.inOutDataGridViewTextBoxColumn.DataPropertyName = "In_Out";
            this.inOutDataGridViewTextBoxColumn.HeaderText = "出/入";
            this.inOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inOutDataGridViewTextBoxColumn.Name = "inOutDataGridViewTextBoxColumn";
            this.inOutDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "备注";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 125;
            // 
            // visitorAccessManagementIdDataGridViewTextBoxColumn
            // 
            this.visitorAccessManagementIdDataGridViewTextBoxColumn.DataPropertyName = "VisitorAccessManagementId";
            this.visitorAccessManagementIdDataGridViewTextBoxColumn.HeaderText = "外出记录ID";
            this.visitorAccessManagementIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.visitorAccessManagementIdDataGridViewTextBoxColumn.Name = "visitorAccessManagementIdDataGridViewTextBoxColumn";
            this.visitorAccessManagementIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCardDataGridViewTextBoxColumn
            // 
            this.iDCardDataGridViewTextBoxColumn.DataPropertyName = "IDCard";
            this.iDCardDataGridViewTextBoxColumn.HeaderText = "身份证号";
            this.iDCardDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCardDataGridViewTextBoxColumn.Name = "iDCardDataGridViewTextBoxColumn";
            this.iDCardDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "联系方式";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // healthStateDataGridViewTextBoxColumn
            // 
            this.healthStateDataGridViewTextBoxColumn.DataPropertyName = "HealthState";
            this.healthStateDataGridViewTextBoxColumn.HeaderText = "健康状态";
            this.healthStateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.healthStateDataGridViewTextBoxColumn.Name = "healthStateDataGridViewTextBoxColumn";
            this.healthStateDataGridViewTextBoxColumn.Width = 125;
            // 
            // tempretureDataGridViewTextBoxColumn1
            // 
            this.tempretureDataGridViewTextBoxColumn1.DataPropertyName = "Tempreture";
            this.tempretureDataGridViewTextBoxColumn1.HeaderText = "体温";
            this.tempretureDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tempretureDataGridViewTextBoxColumn1.Name = "tempretureDataGridViewTextBoxColumn1";
            this.tempretureDataGridViewTextBoxColumn1.Width = 125;
            // 
            // accessTimeDataGridViewTextBoxColumn1
            // 
            this.accessTimeDataGridViewTextBoxColumn1.DataPropertyName = "AccessTime";
            this.accessTimeDataGridViewTextBoxColumn1.HeaderText = "到访时间";
            this.accessTimeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.accessTimeDataGridViewTextBoxColumn1.Name = "accessTimeDataGridViewTextBoxColumn1";
            this.accessTimeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // accessPurposeDataGridViewTextBoxColumn
            // 
            this.accessPurposeDataGridViewTextBoxColumn.DataPropertyName = "AccessPurpose";
            this.accessPurposeDataGridViewTextBoxColumn.HeaderText = "到访目的";
            this.accessPurposeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accessPurposeDataGridViewTextBoxColumn.Name = "accessPurposeDataGridViewTextBoxColumn";
            this.accessPurposeDataGridViewTextBoxColumn.Width = 125;
            // 
            // leaveTimeDataGridViewTextBoxColumn
            // 
            this.leaveTimeDataGridViewTextBoxColumn.DataPropertyName = "LeaveTime";
            this.leaveTimeDataGridViewTextBoxColumn.HeaderText = "离开时间";
            this.leaveTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaveTimeDataGridViewTextBoxColumn.Name = "leaveTimeDataGridViewTextBoxColumn";
            this.leaveTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn1
            // 
            this.notesDataGridViewTextBoxColumn1.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn1.HeaderText = "备注";
            this.notesDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn1.Name = "notesDataGridViewTextBoxColumn1";
            this.notesDataGridViewTextBoxColumn1.Width = 125;
            // 
            // AccessManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 995);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccessManagement";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Text = "出入管理";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResidentAccessManagementBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorAccessManagementBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button btnQueryOut;
        private System.Windows.Forms.TextBox txtQueryOut;
        private System.Windows.Forms.ComboBox cmbQueryOut;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ComboBox cmbQuery;
        private System.Windows.Forms.BindingSource ResidentAccessManagementBindingSource;
        private System.Windows.Forms.BindingSource VisitorAccessManagementBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentAccessManagementIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempretureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitorAccessManagementIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempretureDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessPurposeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn1;
    }
}
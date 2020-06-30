namespace CommunityEpidemicManagementSystem
{
    partial class Mission
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
            this.btnAllocate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefuse = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMission = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbQueryW = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.cmbQueryU = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMissionHistory = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnQueryHistory = new System.Windows.Forms.Button();
            this.txtQueryHistory = new System.Windows.Forms.TextBox();
            this.cmbQueryHistory = new System.Windows.Forms.ComboBox();
            this.WorkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.residentMissionIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDLTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishedTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MissionHisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.residentMissionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDLTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMission)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissionHistory)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissionHisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAllocate);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnRefuse);
            this.panel1.Controls.Add(this.btnFinish);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 501);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 57);
            this.panel1.TabIndex = 8;
            // 
            // btnAllocate
            // 
            this.btnAllocate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAllocate.Location = new System.Drawing.Point(313, 15);
            this.btnAllocate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(115, 29);
            this.btnAllocate.TabIndex = 14;
            this.btnAllocate.Text = "分配需求";
            this.btnAllocate.UseVisualStyleBackColor = true;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(677, 15);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 29);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消订单";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreate.Location = new System.Drawing.Point(291, 15);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(115, 29);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "创建需求";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Location = new System.Drawing.Point(486, 15);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 29);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "修改订单";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefuse
            // 
            this.btnRefuse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefuse.Location = new System.Drawing.Point(653, 15);
            this.btnRefuse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefuse.Name = "btnRefuse";
            this.btnRefuse.Size = new System.Drawing.Size(115, 29);
            this.btnRefuse.TabIndex = 7;
            this.btnRefuse.Text = "拒绝需求";
            this.btnRefuse.UseVisualStyleBackColor = true;
            this.btnRefuse.Click += new System.EventHandler(this.btnRefuse_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFinish.Location = new System.Drawing.Point(313, 15);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(115, 29);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.Text = "完成需求";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1099, 591);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1091, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " 未完成需求 ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMission);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(4, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(14, 6, 14, 14);
            this.groupBox1.Size = new System.Drawing.Size(1083, 422);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "全部需求（双击相应需求可查看该需求明细）";
            // 
            // dgvMission
            // 
            this.dgvMission.AutoGenerateColumns = false;
            this.dgvMission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.residentMissionIdDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1,
            this.createdTimeDataGridViewTextBoxColumn1,
            this.dDLTimeDataGridViewTextBoxColumn1,
            this.finishedTimeDataGridViewTextBoxColumn1,
            this.stateDataGridViewTextBoxColumn1,
            this.serverDataGridViewTextBoxColumn1,
            this.remarkDataGridViewTextBoxColumn1,
            this.residentIdDataGridViewTextBoxColumn1,
            this.residentDataGridViewTextBoxColumn1});
            this.dgvMission.DataSource = this.MissionBindingSource;
            this.dgvMission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMission.Location = new System.Drawing.Point(14, 24);
            this.dgvMission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMission.Name = "dgvMission";
            this.dgvMission.RowHeadersWidth = 92;
            this.dgvMission.RowTemplate.Height = 40;
            this.dgvMission.Size = new System.Drawing.Size(1055, 384);
            this.dgvMission.TabIndex = 0;
            this.dgvMission.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMissionList_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbQueryW);
            this.groupBox3.Controls.Add(this.btnQuery);
            this.groupBox3.Controls.Add(this.txtQuery);
            this.groupBox3.Controls.Add(this.cmbQueryU);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(1083, 75);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询需求";
            // 
            // cmbQueryW
            // 
            this.cmbQueryW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQueryW.FormattingEnabled = true;
            this.cmbQueryW.Items.AddRange(new object[] {
            "全部",
            "按编号查询",
            "按用户ID查询",
            "按日期查询"});
            this.cmbQueryW.Location = new System.Drawing.Point(35, 32);
            this.cmbQueryW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbQueryW.Name = "cmbQueryW";
            this.cmbQueryW.Size = new System.Drawing.Size(174, 23);
            this.cmbQueryW.TabIndex = 11;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(473, 26);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(86, 29);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "查 询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(235, 32);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(209, 25);
            this.txtQuery.TabIndex = 8;
            // 
            // cmbQueryU
            // 
            this.cmbQueryU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQueryU.FormattingEnabled = true;
            this.cmbQueryU.Items.AddRange(new object[] {
            "全部",
            "按日期查询"});
            this.cmbQueryU.Location = new System.Drawing.Point(35, 32);
            this.cmbQueryU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbQueryU.Name = "cmbQueryU";
            this.cmbQueryU.Size = new System.Drawing.Size(174, 23);
            this.cmbQueryU.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1091, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  历史需求  ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMissionHistory);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 79);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(14, 6, 14, 14);
            this.groupBox2.Size = new System.Drawing.Size(1083, 479);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "全部需求（双击相应需求可查看该需求明细）";
            // 
            // dgvMissionHistory
            // 
            this.dgvMissionHistory.AutoGenerateColumns = false;
            this.dgvMissionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMissionHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.residentMissionIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.createdTimeDataGridViewTextBoxColumn,
            this.dDLTimeDataGridViewTextBoxColumn,
            this.finishedTimeDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.serverDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.residentIdDataGridViewTextBoxColumn,
            this.residentDataGridViewTextBoxColumn});
            this.dgvMissionHistory.DataSource = this.MissionHisBindingSource;
            this.dgvMissionHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMissionHistory.Location = new System.Drawing.Point(14, 24);
            this.dgvMissionHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMissionHistory.Name = "dgvMissionHistory";
            this.dgvMissionHistory.RowHeadersWidth = 92;
            this.dgvMissionHistory.RowTemplate.Height = 40;
            this.dgvMissionHistory.Size = new System.Drawing.Size(1055, 441);
            this.dgvMissionHistory.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnQueryHistory);
            this.groupBox4.Controls.Add(this.txtQueryHistory);
            this.groupBox4.Controls.Add(this.cmbQueryHistory);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(4, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(1083, 75);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "查询需求";
            // 
            // btnQueryHistory
            // 
            this.btnQueryHistory.Location = new System.Drawing.Point(473, 26);
            this.btnQueryHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQueryHistory.Name = "btnQueryHistory";
            this.btnQueryHistory.Size = new System.Drawing.Size(86, 29);
            this.btnQueryHistory.TabIndex = 9;
            this.btnQueryHistory.Text = "查 询";
            this.btnQueryHistory.UseVisualStyleBackColor = true;
            this.btnQueryHistory.Click += new System.EventHandler(this.btnQueryHistory_Click);
            // 
            // txtQueryHistory
            // 
            this.txtQueryHistory.Location = new System.Drawing.Point(235, 32);
            this.txtQueryHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQueryHistory.Name = "txtQueryHistory";
            this.txtQueryHistory.Size = new System.Drawing.Size(209, 25);
            this.txtQueryHistory.TabIndex = 8;
            // 
            // cmbQueryHistory
            // 
            this.cmbQueryHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQueryHistory.FormattingEnabled = true;
            this.cmbQueryHistory.Items.AddRange(new object[] {
            "全部",
            "按订单编号查询",
            "按用户ID查询",
            "按日期查询"});
            this.cmbQueryHistory.Location = new System.Drawing.Point(35, 32);
            this.cmbQueryHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbQueryHistory.Name = "cmbQueryHistory";
            this.cmbQueryHistory.Size = new System.Drawing.Size(174, 23);
            this.cmbQueryHistory.TabIndex = 7;
            // 
            // residentMissionIdDataGridViewTextBoxColumn1
            // 
            this.residentMissionIdDataGridViewTextBoxColumn1.DataPropertyName = "ResidentMissionId";
            this.residentMissionIdDataGridViewTextBoxColumn1.HeaderText = "ResidentMissionId";
            this.residentMissionIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.residentMissionIdDataGridViewTextBoxColumn1.Name = "residentMissionIdDataGridViewTextBoxColumn1";
            this.residentMissionIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.Width = 125;
            // 
            // createdTimeDataGridViewTextBoxColumn1
            // 
            this.createdTimeDataGridViewTextBoxColumn1.DataPropertyName = "CreatedTime";
            this.createdTimeDataGridViewTextBoxColumn1.HeaderText = "CreatedTime";
            this.createdTimeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.createdTimeDataGridViewTextBoxColumn1.Name = "createdTimeDataGridViewTextBoxColumn1";
            this.createdTimeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dDLTimeDataGridViewTextBoxColumn1
            // 
            this.dDLTimeDataGridViewTextBoxColumn1.DataPropertyName = "DDLTime";
            this.dDLTimeDataGridViewTextBoxColumn1.HeaderText = "DDLTime";
            this.dDLTimeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dDLTimeDataGridViewTextBoxColumn1.Name = "dDLTimeDataGridViewTextBoxColumn1";
            this.dDLTimeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // finishedTimeDataGridViewTextBoxColumn1
            // 
            this.finishedTimeDataGridViewTextBoxColumn1.DataPropertyName = "FinishedTime";
            this.finishedTimeDataGridViewTextBoxColumn1.HeaderText = "FinishedTime";
            this.finishedTimeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.finishedTimeDataGridViewTextBoxColumn1.Name = "finishedTimeDataGridViewTextBoxColumn1";
            this.finishedTimeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn1
            // 
            this.stateDataGridViewTextBoxColumn1.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn1.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn1.Name = "stateDataGridViewTextBoxColumn1";
            this.stateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // serverDataGridViewTextBoxColumn1
            // 
            this.serverDataGridViewTextBoxColumn1.DataPropertyName = "Server";
            this.serverDataGridViewTextBoxColumn1.HeaderText = "Server";
            this.serverDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.serverDataGridViewTextBoxColumn1.Name = "serverDataGridViewTextBoxColumn1";
            this.serverDataGridViewTextBoxColumn1.Width = 125;
            // 
            // remarkDataGridViewTextBoxColumn1
            // 
            this.remarkDataGridViewTextBoxColumn1.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn1.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.remarkDataGridViewTextBoxColumn1.Name = "remarkDataGridViewTextBoxColumn1";
            this.remarkDataGridViewTextBoxColumn1.Width = 125;
            // 
            // residentIdDataGridViewTextBoxColumn1
            // 
            this.residentIdDataGridViewTextBoxColumn1.DataPropertyName = "ResidentId";
            this.residentIdDataGridViewTextBoxColumn1.HeaderText = "ResidentId";
            this.residentIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.residentIdDataGridViewTextBoxColumn1.Name = "residentIdDataGridViewTextBoxColumn1";
            this.residentIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // residentDataGridViewTextBoxColumn1
            // 
            this.residentDataGridViewTextBoxColumn1.DataPropertyName = "Resident";
            this.residentDataGridViewTextBoxColumn1.HeaderText = "Resident";
            this.residentDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.residentDataGridViewTextBoxColumn1.Name = "residentDataGridViewTextBoxColumn1";
            this.residentDataGridViewTextBoxColumn1.Width = 125;
            // 
            // MissionBindingSource
            // 
            this.MissionBindingSource.DataSource = typeof(CommunityEpidemicManagementSystem.ResidentMission);
            // 
            // MissionHisBindingSource
            // 
            this.MissionHisBindingSource.DataSource = typeof(CommunityEpidemicManagementSystem.ResidentMission);
            // 
            // residentMissionIdDataGridViewTextBoxColumn
            // 
            this.residentMissionIdDataGridViewTextBoxColumn.DataPropertyName = "ResidentMissionId";
            this.residentMissionIdDataGridViewTextBoxColumn.HeaderText = "ResidentMissionId";
            this.residentMissionIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.residentMissionIdDataGridViewTextBoxColumn.Name = "residentMissionIdDataGridViewTextBoxColumn";
            this.residentMissionIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // createdTimeDataGridViewTextBoxColumn
            // 
            this.createdTimeDataGridViewTextBoxColumn.DataPropertyName = "CreatedTime";
            this.createdTimeDataGridViewTextBoxColumn.HeaderText = "CreatedTime";
            this.createdTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdTimeDataGridViewTextBoxColumn.Name = "createdTimeDataGridViewTextBoxColumn";
            this.createdTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dDLTimeDataGridViewTextBoxColumn
            // 
            this.dDLTimeDataGridViewTextBoxColumn.DataPropertyName = "DDLTime";
            this.dDLTimeDataGridViewTextBoxColumn.HeaderText = "DDLTime";
            this.dDLTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dDLTimeDataGridViewTextBoxColumn.Name = "dDLTimeDataGridViewTextBoxColumn";
            this.dDLTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // finishedTimeDataGridViewTextBoxColumn
            // 
            this.finishedTimeDataGridViewTextBoxColumn.DataPropertyName = "FinishedTime";
            this.finishedTimeDataGridViewTextBoxColumn.HeaderText = "FinishedTime";
            this.finishedTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finishedTimeDataGridViewTextBoxColumn.Name = "finishedTimeDataGridViewTextBoxColumn";
            this.finishedTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.Width = 125;
            // 
            // serverDataGridViewTextBoxColumn
            // 
            this.serverDataGridViewTextBoxColumn.DataPropertyName = "Server";
            this.serverDataGridViewTextBoxColumn.HeaderText = "Server";
            this.serverDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serverDataGridViewTextBoxColumn.Name = "serverDataGridViewTextBoxColumn";
            this.serverDataGridViewTextBoxColumn.Width = 125;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.Width = 125;
            // 
            // residentIdDataGridViewTextBoxColumn
            // 
            this.residentIdDataGridViewTextBoxColumn.DataPropertyName = "ResidentId";
            this.residentIdDataGridViewTextBoxColumn.HeaderText = "ResidentId";
            this.residentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.residentIdDataGridViewTextBoxColumn.Name = "residentIdDataGridViewTextBoxColumn";
            this.residentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // residentDataGridViewTextBoxColumn
            // 
            this.residentDataGridViewTextBoxColumn.DataPropertyName = "Resident";
            this.residentDataGridViewTextBoxColumn.HeaderText = "Resident";
            this.residentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.residentDataGridViewTextBoxColumn.Name = "residentDataGridViewTextBoxColumn";
            this.residentDataGridViewTextBoxColumn.Width = 125;
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 599);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Mission";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text = "我的需求";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMission)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissionHistory)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissionHisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefuse;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMission;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMissionHistory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ComboBox cmbQueryU;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnQueryHistory;
        private System.Windows.Forms.TextBox txtQueryHistory;
        private System.Windows.Forms.ComboBox cmbQueryHistory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.BindingSource MissionBindingSource;
        private System.Windows.Forms.ComboBox cmbQueryW;
        private System.Windows.Forms.BindingSource WorkerBindingSource;
        private System.Windows.Forms.BindingSource MissionHisBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentMissionIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDLTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishedTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentMissionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDLTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentDataGridViewTextBoxColumn;
    }
}
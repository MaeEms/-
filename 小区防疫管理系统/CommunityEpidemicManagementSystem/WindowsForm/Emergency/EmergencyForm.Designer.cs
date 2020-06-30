namespace CommunityEpidemicManagementSystem
{
    partial class EmergencyForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAllocate = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEmergency = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.cmbQuery = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEmergencyHistory = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQueryHistory = new System.Windows.Forms.Button();
            this.txtQueryHistory = new System.Windows.Forms.TextBox();
            this.cmbQueryHistory = new System.Windows.Forms.ComboBox();
            this.EmergencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmergencyHisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emergencyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raiseTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raiseTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergStateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmergency)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmergencyHistory)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmergencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmergencyHisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7);
            this.panel1.Size = new System.Drawing.Size(1747, 1017);
            this.panel1.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1733, 1003);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.ForeColor = System.Drawing.Color.Red;
            this.tabPage1.Location = new System.Drawing.Point(10, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(7);
            this.tabPage1.Size = new System.Drawing.Size(1713, 947);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "未处理事件";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAllocate);
            this.panel3.Controls.Add(this.btnFinish);
            this.panel3.Controls.Add(this.btnAccept);
            this.panel3.Controls.Add(this.btnCreate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(7, 818);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1699, 122);
            this.panel3.TabIndex = 18;
            // 
            // btnAllocate
            // 
            this.btnAllocate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAllocate.Font = new System.Drawing.Font("宋体", 10.66667F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAllocate.ForeColor = System.Drawing.Color.Red;
            this.btnAllocate.Location = new System.Drawing.Point(752, 30);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(198, 76);
            this.btnAllocate.TabIndex = 21;
            this.btnAllocate.Text = "分配事件";
            this.btnAllocate.UseVisualStyleBackColor = true;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFinish.Font = new System.Drawing.Font("宋体", 10.66667F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFinish.ForeColor = System.Drawing.Color.Red;
            this.btnFinish.Location = new System.Drawing.Point(973, 30);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(198, 76);
            this.btnFinish.TabIndex = 24;
            this.btnFinish.Text = "完成事件";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAccept.Font = new System.Drawing.Font("宋体", 10.66667F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAccept.ForeColor = System.Drawing.Color.Red;
            this.btnAccept.Location = new System.Drawing.Point(528, 30);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(198, 76);
            this.btnAccept.TabIndex = 23;
            this.btnAccept.Text = "接受事件";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreate.ForeColor = System.Drawing.Color.Red;
            this.btnCreate.Location = new System.Drawing.Point(706, 30);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(279, 76);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "创建紧急事件";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEmergency);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(7, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(25, 10, 25, 25);
            this.groupBox1.Size = new System.Drawing.Size(1699, 691);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "紧急事件";
            // 
            // dgvEmergency
            // 
            this.dgvEmergency.AutoGenerateColumns = false;
            this.dgvEmergency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmergency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emergencyIdDataGridViewTextBoxColumn,
            this.residentIdDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.raiseTimeDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.workerIdDataGridViewTextBoxColumn,
            this.emergStateDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dgvEmergency.DataSource = this.EmergencyBindingSource;
            this.dgvEmergency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmergency.Location = new System.Drawing.Point(25, 41);
            this.dgvEmergency.Name = "dgvEmergency";
            this.dgvEmergency.RowHeadersWidth = 92;
            this.dgvEmergency.RowTemplate.Height = 200;
            this.dgvEmergency.Size = new System.Drawing.Size(1649, 625);
            this.dgvEmergency.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnQuery);
            this.groupBox4.Controls.Add(this.txtQuery);
            this.groupBox4.Controls.Add(this.cmbQuery);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(7, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1699, 120);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "查询事件";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(828, 39);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(150, 52);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "查 询";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(412, 49);
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
            "按用户名查询",
            "按事件描述查询",
            "按处理人查询"});
            this.cmbQuery.Location = new System.Drawing.Point(62, 49);
            this.cmbQuery.Name = "cmbQuery";
            this.cmbQuery.Size = new System.Drawing.Size(301, 35);
            this.cmbQuery.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(10, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(7);
            this.tabPage2.Size = new System.Drawing.Size(1713, 947);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " 历史记录 ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEmergencyHistory);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(7, 127);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(25, 10, 25, 25);
            this.groupBox2.Size = new System.Drawing.Size(1699, 813);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "紧急事件";
            // 
            // dgvEmergencyHistory
            // 
            this.dgvEmergencyHistory.AutoGenerateColumns = false;
            this.dgvEmergencyHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmergencyHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emergencyIdDataGridViewTextBoxColumn1,
            this.residentIdDataGridViewTextBoxColumn1,
            this.detailsDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn1,
            this.raiseTimeDataGridViewTextBoxColumn1,
            this.workerIdDataGridViewTextBoxColumn1,
            this.emergStateDataGridViewTextBoxColumn1,
            this.notesDataGridViewTextBoxColumn1});
            this.dgvEmergencyHistory.DataSource = this.EmergencyHisBindingSource;
            this.dgvEmergencyHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmergencyHistory.Location = new System.Drawing.Point(25, 41);
            this.dgvEmergencyHistory.Name = "dgvEmergencyHistory";
            this.dgvEmergencyHistory.RowHeadersWidth = 92;
            this.dgvEmergencyHistory.RowTemplate.Height = 200;
            this.dgvEmergencyHistory.Size = new System.Drawing.Size(1649, 747);
            this.dgvEmergencyHistory.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnQueryHistory);
            this.groupBox3.Controls.Add(this.txtQueryHistory);
            this.groupBox3.Controls.Add(this.cmbQueryHistory);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1699, 120);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询事件";
            // 
            // btnQueryHistory
            // 
            this.btnQueryHistory.Location = new System.Drawing.Point(828, 39);
            this.btnQueryHistory.Name = "btnQueryHistory";
            this.btnQueryHistory.Size = new System.Drawing.Size(150, 52);
            this.btnQueryHistory.TabIndex = 9;
            this.btnQueryHistory.Text = "查 询";
            this.btnQueryHistory.UseVisualStyleBackColor = true;
            // 
            // txtQueryHistory
            // 
            this.txtQueryHistory.Location = new System.Drawing.Point(412, 49);
            this.txtQueryHistory.Name = "txtQueryHistory";
            this.txtQueryHistory.Size = new System.Drawing.Size(362, 38);
            this.txtQueryHistory.TabIndex = 8;
            // 
            // cmbQueryHistory
            // 
            this.cmbQueryHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQueryHistory.FormattingEnabled = true;
            this.cmbQueryHistory.Items.AddRange(new object[] {
            "全部",
            "按用户名查询",
            "按事件描述查询",
            "按处理人查询"});
            this.cmbQueryHistory.Location = new System.Drawing.Point(62, 49);
            this.cmbQueryHistory.Name = "cmbQueryHistory";
            this.cmbQueryHistory.Size = new System.Drawing.Size(301, 35);
            this.cmbQueryHistory.TabIndex = 7;
            // 
            // EmergencyBindingSource
            // 
            this.EmergencyBindingSource.DataSource = typeof(CommunityEpidemicManagementSystem.Emergency);
            // 
            // EmergencyHisBindingSource
            // 
            this.EmergencyHisBindingSource.DataSource = typeof(CommunityEpidemicManagementSystem.Emergency);
            // 
            // emergencyIdDataGridViewTextBoxColumn
            // 
            this.emergencyIdDataGridViewTextBoxColumn.DataPropertyName = "EmergencyId";
            this.emergencyIdDataGridViewTextBoxColumn.HeaderText = "事件编号";
            this.emergencyIdDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.emergencyIdDataGridViewTextBoxColumn.Name = "emergencyIdDataGridViewTextBoxColumn";
            this.emergencyIdDataGridViewTextBoxColumn.Width = 225;
            // 
            // residentIdDataGridViewTextBoxColumn
            // 
            this.residentIdDataGridViewTextBoxColumn.DataPropertyName = "ResidentId";
            this.residentIdDataGridViewTextBoxColumn.HeaderText = "用户ID";
            this.residentIdDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.residentIdDataGridViewTextBoxColumn.Name = "residentIdDataGridViewTextBoxColumn";
            this.residentIdDataGridViewTextBoxColumn.Width = 225;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "事件描述";
            this.detailsDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.Width = 225;
            // 
            // raiseTimeDataGridViewTextBoxColumn
            // 
            this.raiseTimeDataGridViewTextBoxColumn.DataPropertyName = "RaiseTime";
            this.raiseTimeDataGridViewTextBoxColumn.HeaderText = "发生时间";
            this.raiseTimeDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.raiseTimeDataGridViewTextBoxColumn.Name = "raiseTimeDataGridViewTextBoxColumn";
            this.raiseTimeDataGridViewTextBoxColumn.Width = 225;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "发生地址";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 225;
            // 
            // workerIdDataGridViewTextBoxColumn
            // 
            this.workerIdDataGridViewTextBoxColumn.DataPropertyName = "WorkerId";
            this.workerIdDataGridViewTextBoxColumn.HeaderText = "处理人ID";
            this.workerIdDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.workerIdDataGridViewTextBoxColumn.Name = "workerIdDataGridViewTextBoxColumn";
            this.workerIdDataGridViewTextBoxColumn.Width = 225;
            // 
            // emergStateDataGridViewTextBoxColumn
            // 
            this.emergStateDataGridViewTextBoxColumn.DataPropertyName = "EmergState";
            this.emergStateDataGridViewTextBoxColumn.HeaderText = "状态";
            this.emergStateDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.emergStateDataGridViewTextBoxColumn.Name = "emergStateDataGridViewTextBoxColumn";
            this.emergStateDataGridViewTextBoxColumn.Width = 225;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "备注";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 225;
            // 
            // emergencyIdDataGridViewTextBoxColumn1
            // 
            this.emergencyIdDataGridViewTextBoxColumn1.DataPropertyName = "EmergencyId";
            this.emergencyIdDataGridViewTextBoxColumn1.HeaderText = "事件编号";
            this.emergencyIdDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.emergencyIdDataGridViewTextBoxColumn1.Name = "emergencyIdDataGridViewTextBoxColumn1";
            this.emergencyIdDataGridViewTextBoxColumn1.Width = 225;
            // 
            // residentIdDataGridViewTextBoxColumn1
            // 
            this.residentIdDataGridViewTextBoxColumn1.DataPropertyName = "ResidentId";
            this.residentIdDataGridViewTextBoxColumn1.HeaderText = "居民ID";
            this.residentIdDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.residentIdDataGridViewTextBoxColumn1.Name = "residentIdDataGridViewTextBoxColumn1";
            this.residentIdDataGridViewTextBoxColumn1.Width = 225;
            // 
            // detailsDataGridViewTextBoxColumn1
            // 
            this.detailsDataGridViewTextBoxColumn1.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn1.HeaderText = "事件描述";
            this.detailsDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.detailsDataGridViewTextBoxColumn1.Name = "detailsDataGridViewTextBoxColumn1";
            this.detailsDataGridViewTextBoxColumn1.Width = 225;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "发生地址";
            this.addressDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            this.addressDataGridViewTextBoxColumn1.Width = 225;
            // 
            // raiseTimeDataGridViewTextBoxColumn1
            // 
            this.raiseTimeDataGridViewTextBoxColumn1.DataPropertyName = "RaiseTime";
            this.raiseTimeDataGridViewTextBoxColumn1.HeaderText = "发生时间";
            this.raiseTimeDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.raiseTimeDataGridViewTextBoxColumn1.Name = "raiseTimeDataGridViewTextBoxColumn1";
            this.raiseTimeDataGridViewTextBoxColumn1.Width = 225;
            // 
            // workerIdDataGridViewTextBoxColumn1
            // 
            this.workerIdDataGridViewTextBoxColumn1.DataPropertyName = "WorkerId";
            this.workerIdDataGridViewTextBoxColumn1.HeaderText = "处理人ID";
            this.workerIdDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.workerIdDataGridViewTextBoxColumn1.Name = "workerIdDataGridViewTextBoxColumn1";
            this.workerIdDataGridViewTextBoxColumn1.Width = 225;
            // 
            // emergStateDataGridViewTextBoxColumn1
            // 
            this.emergStateDataGridViewTextBoxColumn1.DataPropertyName = "EmergState";
            this.emergStateDataGridViewTextBoxColumn1.HeaderText = "事件状态";
            this.emergStateDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.emergStateDataGridViewTextBoxColumn1.Name = "emergStateDataGridViewTextBoxColumn1";
            this.emergStateDataGridViewTextBoxColumn1.Width = 225;
            // 
            // notesDataGridViewTextBoxColumn1
            // 
            this.notesDataGridViewTextBoxColumn1.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn1.HeaderText = "备注";
            this.notesDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.notesDataGridViewTextBoxColumn1.Name = "notesDataGridViewTextBoxColumn1";
            this.notesDataGridViewTextBoxColumn1.Width = 225;
            // 
            // EmergencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1747, 1017);
            this.Controls.Add(this.panel1);
            this.Name = "EmergencyForm";
            this.Text = "紧急事件";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmergency)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmergencyHistory)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmergencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmergencyHisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEmergencyHistory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEmergency;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQueryHistory;
        private System.Windows.Forms.TextBox txtQueryHistory;
        private System.Windows.Forms.ComboBox cmbQueryHistory;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ComboBox cmbQuery;
        private System.Windows.Forms.BindingSource EmergencyBindingSource;
        private System.Windows.Forms.BindingSource EmergencyHisBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raiseTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn raiseTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergStateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn1;
    }
}
namespace CommunityEpidemicManagementSystem
{
    partial class HealthInfoResident
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPunchIn = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPunchInRecord = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.cmbQuery = new System.Windows.Forms.ComboBox();
            this.TodayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthStatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HealthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ResidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.residentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPunchIn)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPunchInRecord)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TodayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResidentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(2, 2);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1033, 592);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1025, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " 今日打卡 ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 503);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1017, 56);
            this.panel2.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.Location = new System.Drawing.Point(602, 15);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(115, 29);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "提  交";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Location = new System.Drawing.Point(294, 15);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 29);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "编  辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPunchIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(14, 6, 14, 6);
            this.panel1.Size = new System.Drawing.Size(1017, 499);
            this.panel1.TabIndex = 0;
            // 
            // dgvPunchIn
            // 
            this.dgvPunchIn.AutoGenerateColumns = false;
            this.dgvPunchIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPunchIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.residentNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn1,
            this.temperatureDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dgvPunchIn.DataSource = this.TodayBindingSource;
            this.dgvPunchIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPunchIn.Location = new System.Drawing.Point(14, 6);
            this.dgvPunchIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPunchIn.Name = "dgvPunchIn";
            this.dgvPunchIn.RowHeadersWidth = 92;
            this.dgvPunchIn.RowTemplate.Height = 40;
            this.dgvPunchIn.Size = new System.Drawing.Size(989, 487);
            this.dgvPunchIn.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1025, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " 打卡记录 ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPunchInRecord);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(14, 6, 14, 6);
            this.groupBox1.Size = new System.Drawing.Size(1017, 480);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "打卡记录";
            // 
            // dgvPunchInRecord
            // 
            this.dgvPunchInRecord.AutoGenerateColumns = false;
            this.dgvPunchInRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPunchInRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.residentIdDataGridViewTextBoxColumn1,
            this.residentDataGridViewTextBoxColumn1,
            this.temperatureDataGridViewTextBoxColumn1,
            this.healthStatusDataGridViewTextBoxColumn1,
            this.commentDataGridViewTextBoxColumn1});
            this.dgvPunchInRecord.DataSource = this.HealthBindingSource;
            this.dgvPunchInRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPunchInRecord.Location = new System.Drawing.Point(14, 24);
            this.dgvPunchInRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPunchInRecord.Name = "dgvPunchInRecord";
            this.dgvPunchInRecord.RowHeadersWidth = 92;
            this.dgvPunchInRecord.RowTemplate.Height = 40;
            this.dgvPunchInRecord.Size = new System.Drawing.Size(989, 450);
            this.dgvPunchInRecord.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnQuery);
            this.groupBox3.Controls.Add(this.txtQuery);
            this.groupBox3.Controls.Add(this.cmbQuery);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(1017, 75);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询打卡记录";
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
            // cmbQuery
            // 
            this.cmbQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuery.FormattingEnabled = true;
            this.cmbQuery.Items.AddRange(new object[] {
            "全部",
            "按居民ID查询",
            "按日期查询"});
            this.cmbQuery.Location = new System.Drawing.Point(35, 32);
            this.cmbQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbQuery.Name = "cmbQuery";
            this.cmbQuery.Size = new System.Drawing.Size(174, 23);
            this.cmbQuery.TabIndex = 7;
            // 
            // TodayBindingSource
            // 
            this.TodayBindingSource.DataSource = typeof(CommunityEpidemicManagementSystem.HealthInformation);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 225;
            // 
            // residentIdDataGridViewTextBoxColumn1
            // 
            this.residentIdDataGridViewTextBoxColumn1.DataPropertyName = "ResidentId";
            this.residentIdDataGridViewTextBoxColumn1.HeaderText = "居民ID";
            this.residentIdDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.residentIdDataGridViewTextBoxColumn1.Name = "residentIdDataGridViewTextBoxColumn1";
            this.residentIdDataGridViewTextBoxColumn1.Width = 225;
            // 
            // residentDataGridViewTextBoxColumn1
            // 
            this.residentDataGridViewTextBoxColumn1.DataPropertyName = "Resident";
            this.residentDataGridViewTextBoxColumn1.HeaderText = "居民姓名";
            this.residentDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.residentDataGridViewTextBoxColumn1.Name = "residentDataGridViewTextBoxColumn1";
            this.residentDataGridViewTextBoxColumn1.Width = 225;
            // 
            // temperatureDataGridViewTextBoxColumn1
            // 
            this.temperatureDataGridViewTextBoxColumn1.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn1.HeaderText = "体温";
            this.temperatureDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.temperatureDataGridViewTextBoxColumn1.Name = "temperatureDataGridViewTextBoxColumn1";
            this.temperatureDataGridViewTextBoxColumn1.Width = 225;
            // 
            // healthStatusDataGridViewTextBoxColumn1
            // 
            this.healthStatusDataGridViewTextBoxColumn1.DataPropertyName = "HealthStatus";
            this.healthStatusDataGridViewTextBoxColumn1.HeaderText = "健康状态";
            this.healthStatusDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.healthStatusDataGridViewTextBoxColumn1.Name = "healthStatusDataGridViewTextBoxColumn1";
            this.healthStatusDataGridViewTextBoxColumn1.Width = 225;
            // 
            // commentDataGridViewTextBoxColumn1
            // 
            this.commentDataGridViewTextBoxColumn1.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn1.HeaderText = "备注";
            this.commentDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.commentDataGridViewTextBoxColumn1.Name = "commentDataGridViewTextBoxColumn1";
            this.commentDataGridViewTextBoxColumn1.Width = 225;
            // 
            // HealthBindingSource
            // 
            this.HealthBindingSource.DataSource = typeof(CommunityEpidemicManagementSystem.HealthInformation);
            // 
            // ResidentBindingSource
            // 
            this.ResidentBindingSource.DataSource = typeof(CommunityEpidemicManagementSystem.Resident);
            // 
            // residentNameDataGridViewTextBoxColumn
            // 
            this.residentNameDataGridViewTextBoxColumn.DataPropertyName = "ResidentName";
            this.residentNameDataGridViewTextBoxColumn.HeaderText = "ResidentName";
            this.residentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.residentNameDataGridViewTextBoxColumn.Name = "residentNameDataGridViewTextBoxColumn";
            this.residentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.residentNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            this.temperatureDataGridViewTextBoxColumn.Width = 125;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 125;
            // 
            // HealthInfoResident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 596);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HealthInfoResident";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Text = "健康打卡";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPunchIn)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPunchInRecord)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TodayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResidentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPunchIn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ComboBox cmbQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPunchInRecord;
        private System.Windows.Forms.BindingSource TodayBindingSource;
        private System.Windows.Forms.BindingSource ResidentBindingSource;
        private System.Windows.Forms.BindingSource HealthBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthStatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}
namespace CommunityEpidemicManagementSystem
{
    partial class HealthInfoAdministrator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HealthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.cmbQuery = new System.Windows.Forms.ComboBox();
            this.healthInformationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(7, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(25, 10, 25, 25);
            this.groupBox1.Size = new System.Drawing.Size(1815, 892);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "居民打卡信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.healthInformationIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.residentIdDataGridViewTextBoxColumn,
            this.residentDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn,
            this.healthStatusDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.HealthBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(25, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1765, 826);
            this.dataGridView1.TabIndex = 1;
            // 
            // HealthBindingSource
            // 
            this.HealthBindingSource.DataSource = typeof(CommunityEpidemicManagementSystem.HealthInformation);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnQuery);
            this.groupBox3.Controls.Add(this.txtQuery);
            this.groupBox3.Controls.Add(this.cmbQuery);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1815, 135);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询打卡记录";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(849, 50);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(150, 52);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "查 询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(433, 60);
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
            "按居民ID查询",
            "按用户ID查询",
            "按姓名查询"});
            this.cmbQuery.Location = new System.Drawing.Point(83, 60);
            this.cmbQuery.Name = "cmbQuery";
            this.cmbQuery.Size = new System.Drawing.Size(301, 35);
            this.cmbQuery.TabIndex = 7;
            // 
            // healthInformationIdDataGridViewTextBoxColumn
            // 
            this.healthInformationIdDataGridViewTextBoxColumn.DataPropertyName = "HealthInformationId";
            this.healthInformationIdDataGridViewTextBoxColumn.HeaderText = "健康信息编号";
            this.healthInformationIdDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.healthInformationIdDataGridViewTextBoxColumn.Name = "healthInformationIdDataGridViewTextBoxColumn";
            this.healthInformationIdDataGridViewTextBoxColumn.Width = 225;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 225;
            // 
            // residentIdDataGridViewTextBoxColumn
            // 
            this.residentIdDataGridViewTextBoxColumn.DataPropertyName = "ResidentId";
            this.residentIdDataGridViewTextBoxColumn.HeaderText = "居民ID";
            this.residentIdDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.residentIdDataGridViewTextBoxColumn.Name = "residentIdDataGridViewTextBoxColumn";
            this.residentIdDataGridViewTextBoxColumn.Width = 225;
            // 
            // residentDataGridViewTextBoxColumn
            // 
            this.residentDataGridViewTextBoxColumn.DataPropertyName = "Resident";
            this.residentDataGridViewTextBoxColumn.HeaderText = "居民姓名";
            this.residentDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.residentDataGridViewTextBoxColumn.Name = "residentDataGridViewTextBoxColumn";
            this.residentDataGridViewTextBoxColumn.Width = 225;
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "体温";
            this.temperatureDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            this.temperatureDataGridViewTextBoxColumn.Width = 225;
            // 
            // healthStatusDataGridViewTextBoxColumn
            // 
            this.healthStatusDataGridViewTextBoxColumn.DataPropertyName = "HealthStatus";
            this.healthStatusDataGridViewTextBoxColumn.HeaderText = "健康状态";
            this.healthStatusDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.healthStatusDataGridViewTextBoxColumn.Name = "healthStatusDataGridViewTextBoxColumn";
            this.healthStatusDataGridViewTextBoxColumn.Width = 225;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "备注";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 225;
            // 
            // HealthInfoAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1829, 1041);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "HealthInfoAdministrator";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Text = "查询打卡记录";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ComboBox cmbQuery;
        private System.Windows.Forms.BindingSource HealthBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthInformationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.cmbQuery = new System.Windows.Forms.ComboBox();
            this.HealthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealthBindingSource)).BeginInit();
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(25, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1765, 826);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "居民ID";
            this.Column1.MinimumWidth = 11;
            this.Column1.Name = "Column1";
            this.Column1.Width = 225;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "姓名";
            this.Column2.MinimumWidth = 11;
            this.Column2.Name = "Column2";
            this.Column2.Width = 225;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "证件号码";
            this.Column3.MinimumWidth = 11;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "体温";
            this.Column4.MinimumWidth = 11;
            this.Column4.Name = "Column4";
            this.Column4.Width = 225;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "个人健康状态";
            this.Column5.MinimumWidth = 11;
            this.Column5.Name = "Column5";
            this.Column5.Width = 225;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "备注";
            this.Column6.MinimumWidth = 11;
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealthBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ComboBox cmbQuery;
        private System.Windows.Forms.BindingSource HealthBindingSource;
    }
}
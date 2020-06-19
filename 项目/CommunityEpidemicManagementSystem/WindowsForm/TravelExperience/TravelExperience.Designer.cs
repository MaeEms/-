namespace CommunityEpidemicManagementSystem
{
    partial class TravelExperience
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
            this.dgvTravelExperience = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.cmbQuery = new System.Windows.Forms.ComboBox();
            this.TravelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravelExperience)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TravelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTravelExperience);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(7, 142);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(25);
            this.panel1.Size = new System.Drawing.Size(1748, 722);
            this.panel1.TabIndex = 0;
            // 
            // dgvTravelExperience
            // 
            this.dgvTravelExperience.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTravelExperience.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column13,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column1});
            this.dgvTravelExperience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTravelExperience.Location = new System.Drawing.Point(25, 25);
            this.dgvTravelExperience.Name = "dgvTravelExperience";
            this.dgvTravelExperience.RowHeadersWidth = 92;
            this.dgvTravelExperience.RowTemplate.Height = 40;
            this.dgvTravelExperience.Size = new System.Drawing.Size(1698, 672);
            this.dgvTravelExperience.TabIndex = 1;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "姓名";
            this.Column7.MinimumWidth = 11;
            this.Column7.Name = "Column7";
            this.Column7.Width = 225;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "证件号码";
            this.Column8.MinimumWidth = 11;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "出发地";
            this.Column9.MinimumWidth = 11;
            this.Column9.Name = "Column9";
            this.Column9.Width = 225;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "目的地";
            this.Column13.MinimumWidth = 11;
            this.Column13.Name = "Column13";
            this.Column13.Width = 225;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "出行日期";
            this.Column10.MinimumWidth = 11;
            this.Column10.Name = "Column10";
            this.Column10.Width = 225;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "交通方式";
            this.Column11.MinimumWidth = 11;
            this.Column11.Name = "Column11";
            this.Column11.Width = 225;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "乘坐航班车次或车牌号码";
            this.Column12.MinimumWidth = 11;
            this.Column12.Name = "Column12";
            this.Column12.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "备注";
            this.Column1.MinimumWidth = 11;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(7, 864);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1748, 94);
            this.panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(1108, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(202, 52);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "删除出行经历";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(433, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(202, 52);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "添加出行经历";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Location = new System.Drawing.Point(774, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(202, 52);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "修改出行经历";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnQuery);
            this.groupBox3.Controls.Add(this.txtQuery);
            this.groupBox3.Controls.Add(this.cmbQuery);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1748, 135);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询出行经历";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(828, 47);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(150, 52);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "查 询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(412, 57);
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
            "按ID查询",
            "按日期查询"});
            this.cmbQuery.Location = new System.Drawing.Point(62, 57);
            this.cmbQuery.Name = "cmbQuery";
            this.cmbQuery.Size = new System.Drawing.Size(301, 35);
            this.cmbQuery.TabIndex = 7;
            // 
            // TravelExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1762, 965);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Name = "TravelExperience";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Text = "出行经历";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravelExperience)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TravelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTravelExperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ComboBox cmbQuery;
        private System.Windows.Forms.BindingSource TravelBindingSource;
    }
}
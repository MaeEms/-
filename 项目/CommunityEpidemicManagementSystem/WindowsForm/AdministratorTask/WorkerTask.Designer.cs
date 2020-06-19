namespace CommunityEpidemicManagementSystem
{
    partial class WorkerTask
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnComplete = new System.Windows.Forms.Button();
            this.dgvTaskUnfinished = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTaskFinished = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.cmbQuery = new System.Windows.Forms.ComboBox();
            this.WorkerTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskUnfinished)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskFinished)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerTaskBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(911, 525);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgvTaskUnfinished);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(14, 14, 14, 6);
            this.tabPage1.Size = new System.Drawing.Size(903, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "未完成";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnComplete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(14, 435);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 55);
            this.panel1.TabIndex = 1;
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnComplete.Location = new System.Drawing.Point(380, 14);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(115, 29);
            this.btnComplete.TabIndex = 7;
            this.btnComplete.Text = "完成任务";
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // dgvTaskUnfinished
            // 
            this.dgvTaskUnfinished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskUnfinished.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dgvTaskUnfinished.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTaskUnfinished.Location = new System.Drawing.Point(14, 14);
            this.dgvTaskUnfinished.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTaskUnfinished.Name = "dgvTaskUnfinished";
            this.dgvTaskUnfinished.RowHeadersWidth = 92;
            this.dgvTaskUnfinished.RowTemplate.Height = 40;
            this.dgvTaskUnfinished.Size = new System.Drawing.Size(875, 421);
            this.dgvTaskUnfinished.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "任务编号";
            this.Column6.MinimumWidth = 11;
            this.Column6.Name = "Column6";
            this.Column6.Width = 225;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "日期";
            this.Column7.MinimumWidth = 11;
            this.Column7.Name = "Column7";
            this.Column7.Width = 225;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "任务内容";
            this.Column1.MinimumWidth = 11;
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "截止时间";
            this.Column2.MinimumWidth = 11;
            this.Column2.Name = "Column2";
            this.Column2.Width = 225;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "任务状态";
            this.Column4.MinimumWidth = 11;
            this.Column4.Name = "Column4";
            this.Column4.Width = 225;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "备注";
            this.Column3.MinimumWidth = 11;
            this.Column3.Name = "Column3";
            this.Column3.Width = 225;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTaskFinished);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.tabPage2.Size = new System.Drawing.Size(903, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "已完成";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTaskFinished
            // 
            this.dgvTaskFinished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskFinished.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column8,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvTaskFinished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaskFinished.Location = new System.Drawing.Point(14, 78);
            this.dgvTaskFinished.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTaskFinished.Name = "dgvTaskFinished";
            this.dgvTaskFinished.RowHeadersWidth = 92;
            this.dgvTaskFinished.RowTemplate.Height = 40;
            this.dgvTaskFinished.Size = new System.Drawing.Size(875, 404);
            this.dgvTaskFinished.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "任务编号";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 225;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "日期";
            this.Column8.MinimumWidth = 11;
            this.Column8.Name = "Column8";
            this.Column8.Width = 225;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "任务内容";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "截止时间";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 225;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "完成时间";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 225;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "备注";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 225;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuery);
            this.panel2.Controls.Add(this.txtQuery);
            this.panel2.Controls.Add(this.cmbQuery);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(14, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 64);
            this.panel2.TabIndex = 14;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(481, 15);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(86, 29);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查 询";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(243, 21);
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
            "按编号查询",
            "按日期查询"});
            this.cmbQuery.Location = new System.Drawing.Point(43, 21);
            this.cmbQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbQuery.Name = "cmbQuery";
            this.cmbQuery.Size = new System.Drawing.Size(174, 23);
            this.cmbQuery.TabIndex = 0;
            // 
            // WorkerTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 533);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WorkerTask";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text = "我的任务";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskUnfinished)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskFinished)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerTaskBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTaskUnfinished;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.DataGridView dgvTaskFinished;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ComboBox cmbQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.BindingSource WorkerTaskBindingSource;
    }
}
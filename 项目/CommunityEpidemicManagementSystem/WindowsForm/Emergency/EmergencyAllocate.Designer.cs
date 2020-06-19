namespace CommunityEpidemicManagementSystem
{
    partial class EmergencyAllocate
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
            this.btnOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.EmergencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WorkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmergencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(379, 203);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 52);
            this.btnOk.TabIndex = 78;
            this.btnOk.Text = "确 定";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 75;
            this.label3.Text = "工作人员：";
            // 
            // cmbWorker
            // 
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(228, 97);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(540, 35);
            this.cmbWorker.TabIndex = 79;
            // 
            // EmergencyAllocate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 319);
            this.Controls.Add(this.cmbWorker);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Name = "EmergencyAllocate";
            this.Text = "事件分配";
            ((System.ComponentModel.ISupportInitialize)(this.EmergencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbWorker;
        private System.Windows.Forms.BindingSource EmergencyBindingSource;
        private System.Windows.Forms.BindingSource WorkerBindingSource;
    }
}
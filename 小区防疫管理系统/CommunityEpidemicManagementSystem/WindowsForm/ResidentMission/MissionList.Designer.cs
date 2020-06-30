namespace CommunityEpidemicManagementSystem
{
    partial class MissionList
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.MissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MissionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单标题：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "订单明细：";
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MissionBindingSource, "Title", true));
            this.textBox11.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox11.Location = new System.Drawing.Point(224, 96);
            this.textBox11.Margin = new System.Windows.Forms.Padding(7);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(788, 38);
            this.textBox11.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MissionBindingSource, "Description", true));
            this.textBox3.Location = new System.Drawing.Point(224, 181);
            this.textBox3.Margin = new System.Windows.Forms.Padding(7);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(788, 561);
            this.textBox3.TabIndex = 39;
            // 
            // MissionBindingSource
            // 
            this.MissionBindingSource.DataSource = typeof(CommunityEpidemicManagementSystem.ResidentMission);
            // 
            // MissionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 842);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MissionList";
            this.Text = "订单明细";
            ((System.ComponentModel.ISupportInitialize)(this.MissionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource MissionBindingSource;
    }
}
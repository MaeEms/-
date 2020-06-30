namespace CommunityEpidemicManagementSystem
{
    partial class EmergencyAddResident
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmergency = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EmergencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmergencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(482, 604);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(199, 66);
            this.btnOk.TabIndex = 72;
            this.btnOk.Text = "提 交";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(144, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 71;
            this.label1.Text = "备注：";
            // 
            // txtEmergency
            // 
            this.txtEmergency.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EmergencyBindingSource, "Details", true));
            this.txtEmergency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtEmergency.Location = new System.Drawing.Point(256, 145);
            this.txtEmergency.Margin = new System.Windows.Forms.Padding(7);
            this.txtEmergency.Multiline = true;
            this.txtEmergency.Name = "txtEmergency";
            this.txtEmergency.Size = new System.Drawing.Size(788, 337);
            this.txtEmergency.TabIndex = 70;
            this.txtEmergency.Text = "请简明扼要描述事件发生地点、情况、需求";
            // 
            // txtComment
            // 
            this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EmergencyBindingSource, "Notes", true));
            this.txtComment.Location = new System.Drawing.Point(256, 515);
            this.txtComment.Margin = new System.Windows.Forms.Padding(7);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(788, 38);
            this.txtComment.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(90, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 27);
            this.label11.TabIndex = 65;
            this.label11.Text = "事件描述：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(90, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 74;
            this.label2.Text = "发生地点：";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EmergencyBindingSource, "Address", true));
            this.textBox1.Location = new System.Drawing.Point(256, 73);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(788, 38);
            this.textBox1.TabIndex = 73;
            // 
            // EmergencyBindingSource
            // 
            this.EmergencyBindingSource.DataSource = typeof(CommunityEpidemicManagementSystem.Emergency);
            // 
            // EmergencyAddResident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 727);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmergency);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label11);
            this.Name = "EmergencyAddResident";
            this.Text = "添加紧急事件";
            ((System.ComponentModel.ISupportInitialize)(this.EmergencyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmergency;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource EmergencyBindingSource;
    }
}
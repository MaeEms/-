namespace CommunityEpidemicManagementSystem
{
    partial class TravelExperienceEdit
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
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTransportation = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpTravelDate = new System.Windows.Forms.DateTimePicker();
            this.TravelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TravelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(500, 968);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 52);
            this.btnOk.TabIndex = 62;
            this.btnOk.Text = "确 认";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 61;
            this.label1.Text = "交通方式：";
            // 
            // txtComment
            // 
            this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TravelBindingSource, "Remarks", true));
            this.txtComment.Location = new System.Drawing.Point(257, 593);
            this.txtComment.Margin = new System.Windows.Forms.Padding(7);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(788, 337);
            this.txtComment.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 59;
            this.label2.Text = "出发日期：";
            // 
            // txtDeparture
            // 
            this.txtDeparture.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TravelBindingSource, "Departure", true));
            this.txtDeparture.Location = new System.Drawing.Point(257, 190);
            this.txtDeparture.Margin = new System.Windows.Forms.Padding(7);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(788, 38);
            this.txtDeparture.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 57;
            this.label3.Text = "证件号码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 27);
            this.label4.TabIndex = 56;
            this.label4.Text = "出发地：";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(257, 126);
            this.txtId.Margin = new System.Windows.Forms.Padding(7);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(788, 38);
            this.txtId.TabIndex = 55;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TravelBindingSource, "Resident", true));
            this.txtName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtName.Location = new System.Drawing.Point(257, 61);
            this.txtName.Margin = new System.Windows.Forms.Padding(7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(788, 38);
            this.txtName.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 27);
            this.label11.TabIndex = 53;
            this.label11.Text = "姓名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 27);
            this.label5.TabIndex = 64;
            this.label5.Text = "乘坐航班车次";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 27);
            this.label6.TabIndex = 65;
            this.label6.Text = "或车牌号码";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 596);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 27);
            this.label7.TabIndex = 66;
            this.label7.Text = "备注：";
            // 
            // txtTransportation
            // 
            this.txtTransportation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TravelBindingSource, "Transport", true));
            this.txtTransportation.Location = new System.Drawing.Point(257, 454);
            this.txtTransportation.Margin = new System.Windows.Forms.Padding(7);
            this.txtTransportation.Name = "txtTransportation";
            this.txtTransportation.Size = new System.Drawing.Size(788, 38);
            this.txtTransportation.TabIndex = 67;
            // 
            // txtNumber
            // 
            this.txtNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TravelBindingSource, "TransportNumber", true));
            this.txtNumber.Location = new System.Drawing.Point(257, 523);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(7);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(788, 38);
            this.txtNumber.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 27);
            this.label8.TabIndex = 70;
            this.label8.Text = "：";
            // 
            // txtDestination
            // 
            this.txtDestination.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TravelBindingSource, "Destination", true));
            this.txtDestination.Location = new System.Drawing.Point(257, 253);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(7);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(788, 38);
            this.txtDestination.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 27);
            this.label9.TabIndex = 71;
            this.label9.Text = "目的地：";
            // 
            // dtpTravelDate
            // 
            this.dtpTravelDate.Checked = false;
            this.dtpTravelDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.TravelBindingSource, "DateLeave", true));
            this.dtpTravelDate.Location = new System.Drawing.Point(257, 321);
            this.dtpTravelDate.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtpTravelDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpTravelDate.Name = "dtpTravelDate";
            this.dtpTravelDate.Size = new System.Drawing.Size(788, 38);
            this.dtpTravelDate.TabIndex = 73;
            // 
            // TravelBindingSource
            // 
            this.TravelBindingSource.DataSource = typeof(CommunityEpidemicManagementSystem.TravelRecord);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.TravelBindingSource, "DateCome", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(257, 390);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(788, 38);
            this.dateTimePicker1.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 27);
            this.label10.TabIndex = 74;
            this.label10.Text = "返回日期：";
            // 
            // TravelExperienceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 1052);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpTravelDate);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtTransportation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Name = "TravelExperienceEdit";
            this.Text = "出行经历";
            ((System.ComponentModel.ISupportInitialize)(this.TravelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTransportation;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpTravelDate;
        private System.Windows.Forms.BindingSource TravelBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
    }
}
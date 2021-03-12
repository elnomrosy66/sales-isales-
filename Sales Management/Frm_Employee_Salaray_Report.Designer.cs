namespace Sales_Management
{
    partial class Frm_Employee_Salaray_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Employee_Salaray_Report));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.DtbEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DtbStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEmployee = new System.Windows.Forms.ComboBox();
            this.rbtnOne = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.DgvSearchBuy = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPhar = new System.Windows.Forms.TextBox();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(401, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 36);
            this.label6.TabIndex = 351;
            this.label6.Text = "تقرير صرف المرتبات";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.DtbEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DtbStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxEmployee);
            this.groupBox1.Controls.Add(this.rbtnOne);
            this.groupBox1.Controls.Add(this.rbtnAll);
            this.groupBox1.Location = new System.Drawing.Point(6, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 85);
            this.groupBox1.TabIndex = 352;
            this.groupBox1.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton1.Location = new System.Drawing.Point(12, 26);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(126, 42);
            this.simpleButton1.TabIndex = 370;
            this.simpleButton1.Text = "بحث";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // DtbEnd
            // 
            this.DtbEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbEnd.Location = new System.Drawing.Point(155, 30);
            this.DtbEnd.Name = "DtbEnd";
            this.DtbEnd.Size = new System.Drawing.Size(134, 36);
            this.DtbEnd.TabIndex = 356;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(295, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 28);
            this.label2.TabIndex = 353;
            this.label2.Text = "الى:";
            // 
            // DtbStart
            // 
            this.DtbStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbStart.Location = new System.Drawing.Point(341, 31);
            this.DtbStart.Name = "DtbStart";
            this.DtbStart.Size = new System.Drawing.Size(139, 36);
            this.DtbStart.TabIndex = 353;
            this.DtbStart.Value = new System.DateTime(2014, 7, 20, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(486, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 353;
            this.label1.Text = "من:";
            // 
            // cbxEmployee
            // 
            this.cbxEmployee.FormattingEnabled = true;
            this.cbxEmployee.Location = new System.Drawing.Point(534, 31);
            this.cbxEmployee.Name = "cbxEmployee";
            this.cbxEmployee.Size = new System.Drawing.Size(188, 36);
            this.cbxEmployee.TabIndex = 355;
            // 
            // rbtnOne
            // 
            this.rbtnOne.AutoSize = true;
            this.rbtnOne.ForeColor = System.Drawing.Color.Blue;
            this.rbtnOne.Location = new System.Drawing.Point(728, 35);
            this.rbtnOne.Name = "rbtnOne";
            this.rbtnOne.Size = new System.Drawing.Size(114, 32);
            this.rbtnOne.TabIndex = 354;
            this.rbtnOne.Text = "موظف محدد";
            this.rbtnOne.UseVisualStyleBackColor = true;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.ForeColor = System.Drawing.Color.Blue;
            this.rbtnAll.Location = new System.Drawing.Point(848, 35);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(117, 32);
            this.rbtnAll.TabIndex = 353;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "كل الموظفين";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // DgvSearchBuy
            // 
            this.DgvSearchBuy.AllowUserToAddRows = false;
            this.DgvSearchBuy.AllowUserToDeleteRows = false;
            this.DgvSearchBuy.AllowUserToResizeColumns = false;
            this.DgvSearchBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvSearchBuy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvSearchBuy.BackgroundColor = System.Drawing.Color.White;
            this.DgvSearchBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSearchBuy.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSearchBuy.Location = new System.Drawing.Point(6, 127);
            this.DgvSearchBuy.Name = "DgvSearchBuy";
            this.DgvSearchBuy.ReadOnly = true;
            this.DgvSearchBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearchBuy.Size = new System.Drawing.Size(982, 351);
            this.DgvSearchBuy.TabIndex = 354;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(508, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 28);
            this.label3.TabIndex = 358;
            this.label3.Text = "اجمالى المرتبات فى هذه الفترة:";
            // 
            // txtTotalPhar
            // 
            this.txtTotalPhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPhar.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalPhar.Location = new System.Drawing.Point(739, 487);
            this.txtTotalPhar.Name = "txtTotalPhar";
            this.txtTotalPhar.ReadOnly = true;
            this.txtTotalPhar.Size = new System.Drawing.Size(249, 36);
            this.txtTotalPhar.TabIndex = 357;
            this.txtTotalPhar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseTextOptions = true;
            this.btnDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnDelete.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnDelete.Location = new System.Drawing.Point(6, 484);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(307, 39);
            this.btnDelete.TabIndex = 379;
            this.btnDelete.Text = "مسح البيانات فى هذه الفترة";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Frm_Employee_Salaray_Report
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(994, 526);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalPhar);
            this.Controls.Add(this.DgvSearchBuy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Employee_Salaray_Report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير صرف مرتبات الموظفين";
            this.Load += new System.EventHandler(this.Frm_Employee_Salaray_Report_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DtbEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtbStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEmployee;
        private System.Windows.Forms.RadioButton rbtnOne;
        private System.Windows.Forms.RadioButton rbtnAll;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridView DgvSearchBuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalPhar;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}
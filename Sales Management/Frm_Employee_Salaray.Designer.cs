namespace Sales_Management
{
    partial class Frm_Employee_Salaray
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Employee_Salaray));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBorrowItems = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtbDate = new System.Windows.Forms.DateTimePicker();
            this.cbxEmployee = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DtbReminder = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTotalSalary);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBorrowItems);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DtbDate);
            this.groupBox1.Controls.Add(this.cbxEmployee);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DtbReminder);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(7, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 231);
            this.groupBox1.TabIndex = 194;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اذن صرف مرتب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(290, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 355;
            this.label1.Text = "اختراسم الموظف:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(730, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 28);
            this.label9.TabIndex = 354;
            this.label9.Text = "صافى الراتب:";
            // 
            // txtTotalSalary
            // 
            this.txtTotalSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalSalary.Location = new System.Drawing.Point(454, 170);
            this.txtTotalSalary.Name = "txtTotalSalary";
            this.txtTotalSalary.ReadOnly = true;
            this.txtTotalSalary.Size = new System.Drawing.Size(271, 36);
            this.txtTotalSalary.TabIndex = 353;
            this.txtTotalSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(729, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 28);
            this.label6.TabIndex = 350;
            this.label6.Text = "السلف والمسحوبات:";
            // 
            // txtBorrowItems
            // 
            this.txtBorrowItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBorrowItems.Location = new System.Drawing.Point(454, 121);
            this.txtBorrowItems.Name = "txtBorrowItems";
            this.txtBorrowItems.ReadOnly = true;
            this.txtBorrowItems.Size = new System.Drawing.Size(271, 36);
            this.txtBorrowItems.TabIndex = 349;
            this.txtBorrowItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(289, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 28);
            this.label3.TabIndex = 348;
            this.label3.Text = "تاريخ الصرف:";
            // 
            // DtbDate
            // 
            this.DtbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbDate.Location = new System.Drawing.Point(6, 64);
            this.DtbDate.Name = "DtbDate";
            this.DtbDate.Size = new System.Drawing.Size(280, 36);
            this.DtbDate.TabIndex = 347;
            this.DtbDate.Value = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            // 
            // cbxEmployee
            // 
            this.cbxEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEmployee.FormattingEnabled = true;
            this.cbxEmployee.Location = new System.Drawing.Point(6, 24);
            this.cbxEmployee.Name = "cbxEmployee";
            this.cbxEmployee.Size = new System.Drawing.Size(280, 36);
            this.cbxEmployee.TabIndex = 345;
            this.cbxEmployee.SelectedIndexChanged += new System.EventHandler(this.cbxEmployee_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(288, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 28);
            this.label7.TabIndex = 322;
            this.label7.Text = "تاريخ الاستحقاق:";
            // 
            // DtbReminder
            // 
            this.DtbReminder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbReminder.Location = new System.Drawing.Point(6, 174);
            this.DtbReminder.Name = "DtbReminder";
            this.DtbReminder.Size = new System.Drawing.Size(280, 36);
            this.DtbReminder.TabIndex = 321;
            this.DtbReminder.Value = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(730, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 28);
            this.label5.TabIndex = 184;
            this.label5.Text = "الراتب الشهرى:";
            // 
            // txtSalary
            // 
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalary.Location = new System.Drawing.Point(454, 71);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(271, 36);
            this.txtSalary.TabIndex = 183;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(291, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 28);
            this.label4.TabIndex = 168;
            this.label4.Text = "ملاحظات:";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Location = new System.Drawing.Point(6, 104);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(280, 61);
            this.txtNotes.TabIndex = 167;
            this.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(454, 24);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(271, 36);
            this.txtID.TabIndex = 163;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(730, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 164;
            this.label2.Text = "رقم العملية:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(331, 4);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(232, 40);
            this.labelControl1.TabIndex = 365;
            this.labelControl1.Text = "صرف مرتبات الموظفين";
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Appearance.Options.UseTextOptions = true;
            this.btnSearch.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSearch.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSearch.Location = new System.Drawing.Point(300, 277);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(295, 49);
            this.btnSearch.TabIndex = 366;
            this.btnSearch.Text = "صرف الراتب";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Frm_Employee_Salaray
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(895, 338);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Employee_Salaray";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صرف مرتبات الموظفين";
            this.Load += new System.EventHandler(this.Frm_Employee_Salaray_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBorrowItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtbDate;
        private System.Windows.Forms.ComboBox cbxEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtbReminder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
    }
}
namespace Sales_Management
{
    partial class Frm_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Employee));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DtbReminder = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDNationalty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DtbReminder);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIDNationalty);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmpName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 216);
            this.groupBox1.TabIndex = 193;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الموظفين";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(762, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 28);
            this.label7.TabIndex = 322;
            this.label7.Text = "تاريخ الاستحقاق:";
            // 
            // DtbReminder
            // 
            this.DtbReminder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbReminder.Location = new System.Drawing.Point(456, 164);
            this.DtbReminder.Name = "DtbReminder";
            this.DtbReminder.Size = new System.Drawing.Size(296, 36);
            this.DtbReminder.TabIndex = 321;
            this.DtbReminder.Value = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(267, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 28);
            this.label6.TabIndex = 186;
            this.label6.Text = "رقم تحقيق الشخصيه:";
            // 
            // txtIDNationalty
            // 
            this.txtIDNationalty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDNationalty.Location = new System.Drawing.Point(9, 79);
            this.txtIDNationalty.Name = "txtIDNationalty";
            this.txtIDNationalty.Size = new System.Drawing.Size(249, 36);
            this.txtIDNationalty.TabIndex = 185;
            this.txtIDNationalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(762, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 28);
            this.label5.TabIndex = 184;
            this.label5.Text = "الراتب الشهرى:";
            // 
            // txtSalary
            // 
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalary.Location = new System.Drawing.Point(456, 118);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(296, 36);
            this.txtSalary.TabIndex = 183;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(267, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 28);
            this.label8.TabIndex = 182;
            this.label8.Text = "التلفون:";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(9, 33);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(249, 36);
            this.txtPhone.TabIndex = 176;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(267, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 168;
            this.label4.Text = "العنوان:";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(9, 121);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(249, 73);
            this.txtAddress.TabIndex = 167;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(762, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 166;
            this.label3.Text = "اسم الموظف:";
            // 
            // txtEmpName
            // 
            this.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpName.Location = new System.Drawing.Point(456, 77);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(296, 36);
            this.txtEmpName.TabIndex = 165;
            this.txtEmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(456, 30);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(296, 36);
            this.txtID.TabIndex = 163;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(762, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 164;
            this.label2.Text = "رقم الموظف:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFirst);
            this.groupBox2.Controls.Add(this.btnPrev);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.btnLast);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(149)))));
            this.groupBox2.Location = new System.Drawing.Point(231, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 91);
            this.groupBox2.TabIndex = 250;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اسهم التنقل";
            // 
            // btnFirst
            // 
            this.btnFirst.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Appearance.Options.UseFont = true;
            this.btnFirst.Appearance.Options.UseTextOptions = true;
            this.btnFirst.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnFirst.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFirst.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnFirst.Location = new System.Drawing.Point(26, 29);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(96, 49);
            this.btnFirst.TabIndex = 253;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Appearance.Options.UseFont = true;
            this.btnPrev.Appearance.Options.UseTextOptions = true;
            this.btnPrev.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnPrev.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrev.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnPrev.Location = new System.Drawing.Point(133, 29);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(96, 49);
            this.btnPrev.TabIndex = 252;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Appearance.Options.UseTextOptions = true;
            this.btnNext.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnNext.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNext.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnNext.Location = new System.Drawing.Point(239, 29);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(96, 49);
            this.btnNext.TabIndex = 251;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Appearance.Options.UseFont = true;
            this.btnLast.Appearance.Options.UseTextOptions = true;
            this.btnLast.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnLast.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLast.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnLast.Location = new System.Drawing.Point(344, 29);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(96, 49);
            this.btnLast.TabIndex = 250;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnDeleteAll);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(6, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(889, 145);
            this.groupBox3.TabIndex = 251;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات المتاحة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(599, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 28);
            this.label1.TabIndex = 356;
            this.label1.Text = "اكتب اسم الموظف او جزء منه للبحث:";
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Appearance.Options.UseTextOptions = true;
            this.btnSearch.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSearch.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSearch.Location = new System.Drawing.Point(20, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 38);
            this.btnSearch.TabIndex = 355;
            this.btnSearch.Text = "بحث";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseTextOptions = true;
            this.btnExit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnExit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnExit.Location = new System.Drawing.Point(20, 80);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 56);
            this.btnExit.TabIndex = 354;
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.Appearance.Options.UseFont = true;
            this.btnDeleteAll.Appearance.Options.UseTextOptions = true;
            this.btnDeleteAll.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnDeleteAll.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Image")));
            this.btnDeleteAll.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnDeleteAll.Location = new System.Drawing.Point(160, 80);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(149, 56);
            this.btnDeleteAll.TabIndex = 353;
            this.btnDeleteAll.Text = "حذف الكل";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(313, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 56);
            this.btnDelete.TabIndex = 352;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Appearance.Options.UseTextOptions = true;
            this.btnUpdate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnUpdate.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnUpdate.Location = new System.Drawing.Point(450, 80);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 56);
            this.btnUpdate.TabIndex = 351;
            this.btnUpdate.Text = "حفظ";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Appearance.Options.UseTextOptions = true;
            this.btnClear.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnClear.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnClear.Location = new System.Drawing.Point(588, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 56);
            this.btnClear.TabIndex = 350;
            this.btnClear.Text = "جديد";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseTextOptions = true;
            this.btnAdd.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnAdd.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAdd.Location = new System.Drawing.Point(727, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 56);
            this.btnAdd.TabIndex = 349;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSearch.Location = new System.Drawing.Point(181, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(413, 36);
            this.txtSearch.TabIndex = 184;
            this.txtSearch.Text = "ابحث بالكلمة او جزء منها";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_Employee
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(904, 468);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Employee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادخال بيانات موظف جديد";
            this.Load += new System.EventHandler(this.Frm_Employee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtbReminder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDNationalty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAll;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
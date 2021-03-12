namespace Sales_Management
{
    partial class Frm_Deserved
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Deserved));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtbDate = new System.Windows.Forms.DateTimePicker();
            this.NudPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DtbDate);
            this.groupBox1.Controls.Add(this.NudPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDesID);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(7, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(735, 194);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المصروفات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(266, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "ملاحظات:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(8, 91);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(254, 83);
            this.txtNotes.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(617, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "المبلغ المدفوع:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(266, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "تاريخ الدفع:";
            // 
            // DtbDate
            // 
            this.DtbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbDate.Location = new System.Drawing.Point(8, 29);
            this.DtbDate.Name = "DtbDate";
            this.DtbDate.Size = new System.Drawing.Size(254, 36);
            this.DtbDate.TabIndex = 9;
            // 
            // NudPrice
            // 
            this.NudPrice.DecimalPlaces = 2;
            this.NudPrice.Location = new System.Drawing.Point(403, 138);
            this.NudPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NudPrice.Name = "NudPrice";
            this.NudPrice.Size = new System.Drawing.Size(208, 36);
            this.NudPrice.TabIndex = 6;
            this.NudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(617, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "النوع:";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(404, 91);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(207, 36);
            this.cbxType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(617, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "الرقم:";
            // 
            // txtDesID
            // 
            this.txtDesID.Location = new System.Drawing.Point(404, 30);
            this.txtDesID.Name = "txtDesID";
            this.txtDesID.ReadOnly = true;
            this.txtDesID.Size = new System.Drawing.Size(207, 36);
            this.txtDesID.TabIndex = 0;
            this.txtDesID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFirst);
            this.groupBox2.Controls.Add(this.btnPrev);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.btnLast);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(149)))));
            this.groupBox2.Location = new System.Drawing.Point(199, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 91);
            this.groupBox2.TabIndex = 249;
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
            this.btnFirst.Location = new System.Drawing.Point(7, 30);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(74, 46);
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
            this.btnPrev.Location = new System.Drawing.Point(88, 30);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(74, 46);
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
            this.btnNext.Location = new System.Drawing.Point(167, 30);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 46);
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
            this.btnLast.Location = new System.Drawing.Point(247, 30);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(74, 46);
            this.btnLast.TabIndex = 250;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeleteAll);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(149)))));
            this.groupBox3.Location = new System.Drawing.Point(88, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(591, 96);
            this.groupBox3.TabIndex = 250;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات المتاحة";
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
            this.btnDeleteAll.Location = new System.Drawing.Point(12, 28);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(127, 47);
            this.btnDeleteAll.TabIndex = 254;
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
            this.btnDelete.Location = new System.Drawing.Point(148, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 47);
            this.btnDelete.TabIndex = 253;
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
            this.btnUpdate.Location = new System.Drawing.Point(254, 28);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 47);
            this.btnUpdate.TabIndex = 252;
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
            this.btnClear.Location = new System.Drawing.Point(360, 28);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 47);
            this.btnClear.TabIndex = 251;
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
            this.btnAdd.Location = new System.Drawing.Point(469, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 47);
            this.btnAdd.TabIndex = 250;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Frm_Deserved
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseTextOptions = true;
            this.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(749, 399);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_Deserved";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة المصروفات";
            this.Load += new System.EventHandler(this.Frm_Deserved_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtbDate;
        private System.Windows.Forms.NumericUpDown NudPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesID;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAll;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotes;
    }
}
namespace Sales_Management
{
    partial class Frm_Borrow_Money
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Borrow_Money));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxEmployee = new System.Windows.Forms.ComboBox();
            this.rbtnNormal = new System.Windows.Forms.RadioButton();
            this.rbtnEmployee = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBorrowFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBorrowTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DtbReminder = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtbDate = new System.Windows.Forms.DateTimePicker();
            this.NudPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbxEmployee);
            this.groupBox1.Controls.Add(this.rbtnNormal);
            this.groupBox1.Controls.Add(this.rbtnEmployee);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBorrowFrom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBorrowTo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DtbReminder);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DtbDate);
            this.groupBox1.Controls.Add(this.NudPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Location = new System.Drawing.Point(6, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 277);
            this.groupBox1.TabIndex = 351;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عمليات السلف";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(788, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 31);
            this.label8.TabIndex = 359;
            this.label8.Text = "اسم الموظف:";
            // 
            // cbxEmployee
            // 
            this.cbxEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEmployee.FormattingEnabled = true;
            this.cbxEmployee.Location = new System.Drawing.Point(488, 165);
            this.cbxEmployee.Name = "cbxEmployee";
            this.cbxEmployee.Size = new System.Drawing.Size(298, 36);
            this.cbxEmployee.TabIndex = 358;
            this.cbxEmployee.SelectedIndexChanged += new System.EventHandler(this.cbxEmployee_SelectedIndexChanged);
            // 
            // rbtnNormal
            // 
            this.rbtnNormal.AutoSize = true;
            this.rbtnNormal.Checked = true;
            this.rbtnNormal.Location = new System.Drawing.Point(678, 82);
            this.rbtnNormal.Name = "rbtnNormal";
            this.rbtnNormal.Size = new System.Drawing.Size(109, 32);
            this.rbtnNormal.TabIndex = 357;
            this.rbtnNormal.TabStop = true;
            this.rbtnNormal.Text = "شخص عادى";
            this.rbtnNormal.UseVisualStyleBackColor = true;
            this.rbtnNormal.CheckedChanged += new System.EventHandler(this.rbtnNormal_CheckedChanged);
            // 
            // rbtnEmployee
            // 
            this.rbtnEmployee.AutoSize = true;
            this.rbtnEmployee.Location = new System.Drawing.Point(578, 82);
            this.rbtnEmployee.Name = "rbtnEmployee";
            this.rbtnEmployee.Size = new System.Drawing.Size(74, 32);
            this.rbtnEmployee.TabIndex = 356;
            this.rbtnEmployee.Text = "موظف";
            this.rbtnEmployee.UseVisualStyleBackColor = true;
            this.rbtnEmployee.CheckedChanged += new System.EventHandler(this.rbtnEmployee_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(790, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 28);
            this.label7.TabIndex = 355;
            this.label7.Text = "اسم الدائن:";
            // 
            // txtBorrowFrom
            // 
            this.txtBorrowFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBorrowFrom.Location = new System.Drawing.Point(488, 210);
            this.txtBorrowFrom.Multiline = true;
            this.txtBorrowFrom.Name = "txtBorrowFrom";
            this.txtBorrowFrom.Size = new System.Drawing.Size(298, 39);
            this.txtBorrowFrom.TabIndex = 354;
            this.txtBorrowFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(338, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 31);
            this.label5.TabIndex = 353;
            this.label5.Text = "ملاحظات:";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Location = new System.Drawing.Point(15, 165);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(317, 84);
            this.txtNotes.TabIndex = 352;
            this.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(788, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 351;
            this.label1.Text = "اسم الشخص:";
            // 
            // txtBorrowTo
            // 
            this.txtBorrowTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBorrowTo.Location = new System.Drawing.Point(488, 121);
            this.txtBorrowTo.Multiline = true;
            this.txtBorrowTo.Name = "txtBorrowTo";
            this.txtBorrowTo.Size = new System.Drawing.Size(298, 37);
            this.txtBorrowTo.TabIndex = 350;
            this.txtBorrowTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(338, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 28);
            this.label6.TabIndex = 349;
            this.label6.Text = "تاريخ الاستحقاق:";
            // 
            // DtbReminder
            // 
            this.DtbReminder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbReminder.Location = new System.Drawing.Point(15, 79);
            this.DtbReminder.Name = "DtbReminder";
            this.DtbReminder.Size = new System.Drawing.Size(317, 36);
            this.DtbReminder.TabIndex = 348;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(338, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "تاريخ السلف:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(338, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 31);
            this.label2.TabIndex = 347;
            this.label2.Text = "الملبغ:";
            // 
            // DtbDate
            // 
            this.DtbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbDate.Location = new System.Drawing.Point(15, 37);
            this.DtbDate.Name = "DtbDate";
            this.DtbDate.Size = new System.Drawing.Size(317, 36);
            this.DtbDate.TabIndex = 11;
            // 
            // NudPrice
            // 
            this.NudPrice.DecimalPlaces = 2;
            this.NudPrice.Location = new System.Drawing.Point(15, 121);
            this.NudPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NudPrice.Name = "NudPrice";
            this.NudPrice.Size = new System.Drawing.Size(317, 36);
            this.NudPrice.TabIndex = 346;
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
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(790, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "رقم العملية:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(488, 40);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(298, 36);
            this.txtID.TabIndex = 3;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(411, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 40);
            this.labelControl1.TabIndex = 366;
            this.labelControl1.Text = "السلفيات";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Appearance.Options.UseTextOptions = true;
            this.btnUpdate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnUpdate.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnUpdate.Location = new System.Drawing.Point(311, 328);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(295, 49);
            this.btnUpdate.TabIndex = 367;
            this.btnUpdate.Text = "حفظ العملية";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Frm_Borrow_Money
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(916, 385);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Borrow_Money";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "السلفيات";
            this.Load += new System.EventHandler(this.Frm_Borrow_Money_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxEmployee;
        private System.Windows.Forms.RadioButton rbtnNormal;
        private System.Windows.Forms.RadioButton rbtnEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBorrowFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBorrowTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtbReminder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtbDate;
        private System.Windows.Forms.NumericUpDown NudPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
    }
}
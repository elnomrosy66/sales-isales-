namespace Sales_Management
{
    partial class Frm_Rent_Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rent_Report));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rbtnPart = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.cbxEmp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtbEnd = new System.Windows.Forms.DateTimePicker();
            this.DtbStart = new System.Windows.Forms.DateTimePicker();
            this.txtTotalPhar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvSearchBuy = new System.Windows.Forms.DataGridView();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 36);
            this.textBox1.TabIndex = 386;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 32);
            this.checkBox1.TabIndex = 385;
            this.checkBox1.Text = "رقم فاتورة الكراء";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rbtnPart
            // 
            this.rbtnPart.AutoSize = true;
            this.rbtnPart.ForeColor = System.Drawing.Color.Blue;
            this.rbtnPart.Location = new System.Drawing.Point(160, 57);
            this.rbtnPart.Name = "rbtnPart";
            this.rbtnPart.Size = new System.Drawing.Size(127, 32);
            this.rbtnPart.TabIndex = 384;
            this.rbtnPart.Text = "مستخدم محدد";
            this.rbtnPart.UseVisualStyleBackColor = true;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.ForeColor = System.Drawing.Color.Blue;
            this.rbtnAll.Location = new System.Drawing.Point(14, 57);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(135, 32);
            this.rbtnAll.TabIndex = 383;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "كل المستخدمين";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // cbxEmp
            // 
            this.cbxEmp.FormattingEnabled = true;
            this.cbxEmp.Location = new System.Drawing.Point(300, 56);
            this.cbxEmp.Name = "cbxEmp";
            this.cbxEmp.Size = new System.Drawing.Size(224, 36);
            this.cbxEmp.TabIndex = 382;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(616, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 28);
            this.label3.TabIndex = 379;
            this.label3.Text = "اجمالى مبلغ الكراء:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(418, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 28);
            this.label2.TabIndex = 378;
            this.label2.Text = "الى:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(236, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 377;
            this.label1.Text = "من:";
            // 
            // DtbEnd
            // 
            this.DtbEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbEnd.Location = new System.Drawing.Point(461, 98);
            this.DtbEnd.Name = "DtbEnd";
            this.DtbEnd.Size = new System.Drawing.Size(134, 36);
            this.DtbEnd.TabIndex = 376;
            // 
            // DtbStart
            // 
            this.DtbStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbStart.Location = new System.Drawing.Point(278, 98);
            this.DtbStart.Name = "DtbStart";
            this.DtbStart.Size = new System.Drawing.Size(126, 36);
            this.DtbStart.TabIndex = 375;
            this.DtbStart.Value = new System.DateTime(2014, 7, 20, 0, 0, 0, 0);
            // 
            // txtTotalPhar
            // 
            this.txtTotalPhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPhar.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalPhar.Location = new System.Drawing.Point(761, 474);
            this.txtTotalPhar.Name = "txtTotalPhar";
            this.txtTotalPhar.ReadOnly = true;
            this.txtTotalPhar.Size = new System.Drawing.Size(225, 36);
            this.txtTotalPhar.TabIndex = 374;
            this.txtTotalPhar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(312, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 52);
            this.label6.TabIndex = 373;
            this.label6.Text = "اجمالى الكراء فى فترة";
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
            this.DgvSearchBuy.Location = new System.Drawing.Point(7, 143);
            this.DgvSearchBuy.Name = "DgvSearchBuy";
            this.DgvSearchBuy.ReadOnly = true;
            this.DgvSearchBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearchBuy.Size = new System.Drawing.Size(979, 330);
            this.DgvSearchBuy.TabIndex = 372;
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
            this.btnDelete.Location = new System.Drawing.Point(7, 476);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(307, 39);
            this.btnDelete.TabIndex = 387;
            this.btnDelete.Text = "مسح البيانات فى هذه الفترة";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.simpleButton1.Location = new System.Drawing.Point(611, 97);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(239, 38);
            this.simpleButton1.TabIndex = 388;
            this.simpleButton1.Text = "بحث";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Frm_Rent_Report
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 520);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.rbtnPart);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.cbxEmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtbEnd);
            this.Controls.Add(this.DtbStart);
            this.Controls.Add(this.txtTotalPhar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DgvSearchBuy);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Rent_Report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير الكراء";
            this.Load += new System.EventHandler(this.Frm_Rent_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rbtnPart;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.ComboBox cbxEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtbEnd;
        private System.Windows.Forms.DateTimePicker DtbStart;
        private System.Windows.Forms.TextBox txtTotalPhar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvSearchBuy;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
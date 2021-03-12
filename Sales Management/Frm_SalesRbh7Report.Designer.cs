namespace Sales_Management
{
    partial class Frm_SalesRbh7Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SalesRbh7Report));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.DgvBuyDetalis = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.cbxEmp = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalRbh7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalWithTax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnPart = new System.Windows.Forms.RadioButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DtbEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtbStart = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuyDetalis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(366, -1);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(237, 25);
            this.labelControl1.TabIndex = 388;
            this.labelControl1.Text = "اجمالى ارباح المبيعات فى فترة";
            // 
            // DgvBuyDetalis
            // 
            this.DgvBuyDetalis.AllowUserToAddRows = false;
            this.DgvBuyDetalis.AllowUserToDeleteRows = false;
            this.DgvBuyDetalis.AllowUserToResizeColumns = false;
            this.DgvBuyDetalis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvBuyDetalis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvBuyDetalis.BackgroundColor = System.Drawing.Color.White;
            this.DgvBuyDetalis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBuyDetalis.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvBuyDetalis.Location = new System.Drawing.Point(12, 146);
            this.DgvBuyDetalis.Name = "DgvBuyDetalis";
            this.DgvBuyDetalis.ReadOnly = true;
            this.DgvBuyDetalis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBuyDetalis.Size = new System.Drawing.Size(1029, 395);
            this.DgvBuyDetalis.TabIndex = 390;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Blue;
            this.radioButton1.Location = new System.Drawing.Point(147, 106);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 20);
            this.radioButton1.TabIndex = 397;
            this.radioButton1.Text = "مستخدم محدد";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.ForeColor = System.Drawing.Color.Blue;
            this.rbtnAll.Location = new System.Drawing.Point(16, 106);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(99, 20);
            this.rbtnAll.TabIndex = 396;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "كل المستخدمين";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // cbxEmp
            // 
            this.cbxEmp.FormattingEnabled = true;
            this.cbxEmp.Location = new System.Drawing.Point(276, 104);
            this.cbxEmp.Name = "cbxEmp";
            this.cbxEmp.Size = new System.Drawing.Size(187, 24);
            this.cbxEmp.TabIndex = 395;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(812, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 44);
            this.pictureBox1.TabIndex = 394;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(877, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 22);
            this.dateTimePicker1.TabIndex = 393;
            this.dateTimePicker1.Value = new System.DateTime(2014, 7, 20, 0, 0, 0, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseTextOptions = true;
            this.btnDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnDelete.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnDelete.Location = new System.Drawing.Point(734, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(210, 36);
            this.btnDelete.TabIndex = 391;
            this.btnDelete.Text = "مسح البيانات فى هذه الفترة";
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalRbh7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTotalWithTax);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(14, 537);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1029, 70);
            this.groupBox2.TabIndex = 392;
            this.groupBox2.TabStop = false;
            // 
            // txtTotalRbh7
            // 
            this.txtTotalRbh7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalRbh7.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalRbh7.Location = new System.Drawing.Point(534, 24);
            this.txtTotalRbh7.Name = "txtTotalRbh7";
            this.txtTotalRbh7.ReadOnly = true;
            this.txtTotalRbh7.Size = new System.Drawing.Size(290, 22);
            this.txtTotalRbh7.TabIndex = 382;
            this.txtTotalRbh7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(830, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 16);
            this.label4.TabIndex = 381;
            this.label4.Text = "اجمالى الارباح فى هذه الفترة:";
            // 
            // txtTotalWithTax
            // 
            this.txtTotalWithTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalWithTax.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalWithTax.Location = new System.Drawing.Point(51, 24);
            this.txtTotalWithTax.Name = "txtTotalWithTax";
            this.txtTotalWithTax.ReadOnly = true;
            this.txtTotalWithTax.Size = new System.Drawing.Size(179, 22);
            this.txtTotalWithTax.TabIndex = 376;
            this.txtTotalWithTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(229, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 375;
            this.label3.Text = "اجمالى البيع بعد الضريبة:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnPart);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbxType);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.DtbEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DtbStart);
            this.groupBox1.Location = new System.Drawing.Point(16, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 66);
            this.groupBox1.TabIndex = 389;
            this.groupBox1.TabStop = false;
            // 
            // rbtnPart
            // 
            this.rbtnPart.AutoSize = true;
            this.rbtnPart.ForeColor = System.Drawing.Color.Blue;
            this.rbtnPart.Location = new System.Drawing.Point(724, -46);
            this.rbtnPart.Name = "rbtnPart";
            this.rbtnPart.Size = new System.Drawing.Size(90, 20);
            this.rbtnPart.TabIndex = 382;
            this.rbtnPart.Text = "مستخدم محدد";
            this.rbtnPart.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Appearance.Options.UseTextOptions = true;
            this.btnSearch.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSearch.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSearch.Location = new System.Drawing.Point(55, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 36);
            this.btnSearch.TabIndex = 376;
            this.btnSearch.Text = "بحث";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(713, -78);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(148, 24);
            this.cbxType.TabIndex = 380;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(798, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 20);
            this.checkBox1.TabIndex = 374;
            this.checkBox1.Text = "رقم الفاتورة";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(658, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 22);
            this.textBox1.TabIndex = 375;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DtbEnd
            // 
            this.DtbEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbEnd.Location = new System.Drawing.Point(297, 21);
            this.DtbEnd.Name = "DtbEnd";
            this.DtbEnd.Size = new System.Drawing.Size(132, 22);
            this.DtbEnd.TabIndex = 370;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(435, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 372;
            this.label2.Text = "الى:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(616, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 371;
            this.label1.Text = "من:";
            // 
            // DtbStart
            // 
            this.DtbStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbStart.Location = new System.Drawing.Point(481, 21);
            this.DtbStart.Name = "DtbStart";
            this.DtbStart.Size = new System.Drawing.Size(131, 22);
            this.DtbStart.TabIndex = 369;
            this.DtbStart.Value = new System.DateTime(2014, 7, 20, 0, 0, 0, 0);
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Appearance.Options.UseTextOptions = true;
            this.btnPrint.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnPrint.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnPrint.Location = new System.Drawing.Point(574, 104);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(154, 36);
            this.btnPrint.TabIndex = 398;
            this.btnPrint.Text = "طباعة تقرير مفصل";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Frm_SalesRbh7Report
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1020, 618);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.DgvBuyDetalis);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.cbxEmp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Frm_SalesRbh7Report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير ارباح المبيعات";
            this.Load += new System.EventHandler(this.Frm_SalesRbh7Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuyDetalis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView DgvBuyDetalis;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.ComboBox cbxEmp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotalWithTax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnPart;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker DtbEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtbStart;
        private System.Windows.Forms.TextBox txtTotalRbh7;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnPrint;

    }
}
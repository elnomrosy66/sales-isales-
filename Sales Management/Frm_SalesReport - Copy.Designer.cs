namespace Sales_Management
{
    partial class Frm_SalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SalesReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtbEnd = new System.Windows.Forms.DateTimePicker();
            this.DtbStart = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.rbtnPart = new System.Windows.Forms.RadioButton();
            this.DgvBuyDetalis = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalTax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalWithTax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.cbxEmp = new System.Windows.Forms.ComboBox();
            this.button2 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtRbh7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuyDetalis)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(406, -6);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(189, 25);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "اجمالى المبيعات فى فترة";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(664, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(808, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 22);
            this.checkBox1.TabIndex = 374;
            this.checkBox1.Text = "رقم الفاتورة";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(445, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 372;
            this.label2.Text = "الى:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(626, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 371;
            this.label1.Text = "من:";
            // 
            // DtbEnd
            // 
            this.DtbEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbEnd.Location = new System.Drawing.Point(307, 21);
            this.DtbEnd.Name = "DtbEnd";
            this.DtbEnd.Size = new System.Drawing.Size(132, 24);
            this.DtbEnd.TabIndex = 370;
            // 
            // DtbStart
            // 
            this.DtbStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbStart.Location = new System.Drawing.Point(491, 21);
            this.DtbStart.Name = "DtbStart";
            this.DtbStart.Size = new System.Drawing.Size(131, 24);
            this.DtbStart.TabIndex = 369;
            this.DtbStart.Value = new System.DateTime(2014, 7, 20, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbxType);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.DtbEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DtbStart);
            this.groupBox1.Location = new System.Drawing.Point(27, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 66);
            this.groupBox1.TabIndex = 376;
            this.groupBox1.TabStop = false;
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
            this.btnSearch.Location = new System.Drawing.Point(83, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 36);
            this.btnSearch.TabIndex = 376;
            this.btnSearch.Text = "بحث";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(741, -78);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(148, 26);
            this.cbxType.TabIndex = 380;
            // 
            // rbtnPart
            // 
            this.rbtnPart.AutoSize = true;
            this.rbtnPart.ForeColor = System.Drawing.Color.Blue;
            this.rbtnPart.Location = new System.Drawing.Point(160, 101);
            this.rbtnPart.Name = "rbtnPart";
            this.rbtnPart.Size = new System.Drawing.Size(91, 22);
            this.rbtnPart.TabIndex = 382;
            this.rbtnPart.Text = "مستخدم محدد";
            this.rbtnPart.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBuyDetalis.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvBuyDetalis.Location = new System.Drawing.Point(14, 141);
            this.DgvBuyDetalis.Name = "DgvBuyDetalis";
            this.DgvBuyDetalis.ReadOnly = true;
            this.DgvBuyDetalis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBuyDetalis.Size = new System.Drawing.Size(1029, 371);
            this.DgvBuyDetalis.TabIndex = 377;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTotalTax);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTotalWithTax);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(15, 502);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1029, 70);
            this.groupBox2.TabIndex = 378;
            this.groupBox2.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.ForeColor = System.Drawing.Color.Blue;
            this.txtTotal.Location = new System.Drawing.Point(700, 24);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(167, 24);
            this.txtTotal.TabIndex = 380;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(866, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 379;
            this.label5.Text = "اجمالى مبلغ المبيعات:";
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalTax.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalTax.Location = new System.Drawing.Point(406, 24);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.ReadOnly = true;
            this.txtTotalTax.Size = new System.Drawing.Size(179, 24);
            this.txtTotalTax.TabIndex = 378;
            this.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalTax.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(584, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 377;
            this.label4.Text = "اجمالى الضريبة:";
            this.label4.Visible = false;
            // 
            // txtTotalWithTax
            // 
            this.txtTotalWithTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalWithTax.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalWithTax.Location = new System.Drawing.Point(86, 24);
            this.txtTotalWithTax.Name = "txtTotalWithTax";
            this.txtTotalWithTax.ReadOnly = true;
            this.txtTotalWithTax.Size = new System.Drawing.Size(179, 24);
            this.txtTotalWithTax.TabIndex = 376;
            this.txtTotalWithTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalWithTax.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(267, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 375;
            this.label3.Text = "اجمالى البيع بعد الضريبة:";
            this.label3.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(917, 1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 24);
            this.dateTimePicker1.TabIndex = 382;
            this.dateTimePicker1.Value = new System.DateTime(2014, 7, 20, 0, 0, 0, 0);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.ForeColor = System.Drawing.Color.Blue;
            this.rbtnAll.Location = new System.Drawing.Point(27, 103);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(101, 22);
            this.rbtnAll.TabIndex = 385;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "كل المستخدمين";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // cbxEmp
            // 
            this.cbxEmp.FormattingEnabled = true;
            this.cbxEmp.Location = new System.Drawing.Point(293, 101);
            this.cbxEmp.Name = "cbxEmp";
            this.cbxEmp.Size = new System.Drawing.Size(187, 26);
            this.cbxEmp.TabIndex = 384;
            // 
            // button2
            // 
            this.button2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Appearance.Options.UseFont = true;
            this.button2.Appearance.Options.UseTextOptions = true;
            this.button2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.button2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.button2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button2.ImageOptions.Image")));
            this.button2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.button2.Location = new System.Drawing.Point(584, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 36);
            this.button2.TabIndex = 387;
            this.button2.Text = "طباعة تقرير مفصل";
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(830, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 44);
            this.pictureBox1.TabIndex = 383;
            this.pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseTextOptions = true;
            this.btnDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnDelete.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDelete.Enabled = false;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnDelete.Location = new System.Drawing.Point(745, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(210, 36);
            this.btnDelete.TabIndex = 377;
            this.btnDelete.Text = "مسح البيانات فى هذه الفترة";
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtRbh7
            // 
            this.txtRbh7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRbh7.ForeColor = System.Drawing.Color.Blue;
            this.txtRbh7.Location = new System.Drawing.Point(629, 579);
            this.txtRbh7.Name = "txtRbh7";
            this.txtRbh7.ReadOnly = true;
            this.txtRbh7.Size = new System.Drawing.Size(192, 24);
            this.txtRbh7.TabIndex = 382;
            this.txtRbh7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRbh7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(458, 584);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 18);
            this.label6.TabIndex = 381;
            this.label6.Text = "اجمالى مبلغ الربح للبائع المحدد:";
            this.label6.Visible = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.ForeColor = System.Drawing.Color.Red;
            this.lbl.Location = new System.Drawing.Point(843, 581);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(20, 18);
            this.lbl.TabIndex = 388;
            this.lbl.Text = "...";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton1.Location = new System.Drawing.Point(14, 581);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(233, 36);
            this.simpleButton1.TabIndex = 389;
            this.simpleButton1.Text = "طباعة الفاتورة المحددة فقط";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Frm_SalesReport
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1053, 636);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.rbtnPart);
            this.Controls.Add(this.txtRbh7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.DgvBuyDetalis);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.cbxEmp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_SalesReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير المبيعات";
            this.Load += new System.EventHandler(this.Frm_SalesReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuyDetalis)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtbEnd;
        private System.Windows.Forms.DateTimePicker DtbStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.DataGridView DgvBuyDetalis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotalWithTax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnPart;
        private System.Windows.Forms.ComboBox cbxType;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.ComboBox cbxEmp;
        private DevExpress.XtraEditors.SimpleButton button2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalTax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRbh7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
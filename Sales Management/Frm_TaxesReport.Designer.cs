namespace Sales_Management
{
    partial class Frm_TaxesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TaxesReport));
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalWithTax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalTax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPhar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtbEnd = new System.Windows.Forms.DateTimePicker();
            this.DtbStart = new System.Windows.Forms.DateTimePicker();
            this.checkSale = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkReturnBuy = new System.Windows.Forms.CheckBox();
            this.checkReturnSale = new System.Windows.Forms.CheckBox();
            this.checkBuy = new System.Windows.Forms.CheckBox();
            this.DgvSearchBuy = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1014, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 389;
            this.label5.Text = "الاجمالى بعد الضرائب:";
            // 
            // txtTotalWithTax
            // 
            this.txtTotalWithTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalWithTax.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalWithTax.Location = new System.Drawing.Point(1143, 513);
            this.txtTotalWithTax.Name = "txtTotalWithTax";
            this.txtTotalWithTax.ReadOnly = true;
            this.txtTotalWithTax.Size = new System.Drawing.Size(145, 36);
            this.txtTotalWithTax.TabIndex = 388;
            this.txtTotalWithTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(743, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 387;
            this.label4.Text = "اجمالى الضرائب:";
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalTax.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalTax.Location = new System.Drawing.Point(848, 513);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.ReadOnly = true;
            this.txtTotalTax.Size = new System.Drawing.Size(145, 36);
            this.txtTotalTax.TabIndex = 386;
            this.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(481, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 385;
            this.label3.Text = "اجمالى الفواتير:";
            // 
            // txtTotalPhar
            // 
            this.txtTotalPhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPhar.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalPhar.Location = new System.Drawing.Point(579, 513);
            this.txtTotalPhar.Name = "txtTotalPhar";
            this.txtTotalPhar.ReadOnly = true;
            this.txtTotalPhar.Size = new System.Drawing.Size(158, 36);
            this.txtTotalPhar.TabIndex = 384;
            this.txtTotalPhar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(122, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 28);
            this.label2.TabIndex = 377;
            this.label2.Text = "الى:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(297, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 376;
            this.label1.Text = "من:";
            // 
            // DtbEnd
            // 
            this.DtbEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbEnd.Location = new System.Drawing.Point(7, 41);
            this.DtbEnd.Name = "DtbEnd";
            this.DtbEnd.Size = new System.Drawing.Size(109, 36);
            this.DtbEnd.TabIndex = 375;
            // 
            // DtbStart
            // 
            this.DtbStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbStart.Location = new System.Drawing.Point(182, 41);
            this.DtbStart.Name = "DtbStart";
            this.DtbStart.Size = new System.Drawing.Size(112, 36);
            this.DtbStart.TabIndex = 374;
            this.DtbStart.Value = new System.DateTime(2014, 7, 20, 0, 0, 0, 0);
            // 
            // checkSale
            // 
            this.checkSale.AutoSize = true;
            this.checkSale.Checked = true;
            this.checkSale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSale.Location = new System.Drawing.Point(418, 22);
            this.checkSale.Name = "checkSale";
            this.checkSale.Size = new System.Drawing.Size(129, 32);
            this.checkSale.TabIndex = 357;
            this.checkSale.Text = "فواتير المبيعات";
            this.checkSale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkReturnBuy);
            this.groupBox1.Controls.Add(this.checkReturnSale);
            this.groupBox1.Controls.Add(this.checkSale);
            this.groupBox1.Controls.Add(this.checkBuy);
            this.groupBox1.Location = new System.Drawing.Point(4, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 90);
            this.groupBox1.TabIndex = 379;
            this.groupBox1.TabStop = false;
            // 
            // checkReturnBuy
            // 
            this.checkReturnBuy.AutoSize = true;
            this.checkReturnBuy.Checked = true;
            this.checkReturnBuy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkReturnBuy.Location = new System.Drawing.Point(58, 54);
            this.checkReturnBuy.Name = "checkReturnBuy";
            this.checkReturnBuy.Size = new System.Drawing.Size(191, 32);
            this.checkReturnBuy.TabIndex = 358;
            this.checkReturnBuy.Text = "فواتير مرتجعات مشتريات";
            this.checkReturnBuy.UseVisualStyleBackColor = true;
            // 
            // checkReturnSale
            // 
            this.checkReturnSale.AutoSize = true;
            this.checkReturnSale.Checked = true;
            this.checkReturnSale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkReturnSale.Location = new System.Drawing.Point(95, 24);
            this.checkReturnSale.Name = "checkReturnSale";
            this.checkReturnSale.Size = new System.Drawing.Size(154, 32);
            this.checkReturnSale.TabIndex = 357;
            this.checkReturnSale.Text = "فواتير مرتجعات بيع";
            this.checkReturnSale.UseVisualStyleBackColor = true;
            // 
            // checkBuy
            // 
            this.checkBuy.AutoSize = true;
            this.checkBuy.Checked = true;
            this.checkBuy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBuy.Location = new System.Drawing.Point(407, 54);
            this.checkBuy.Name = "checkBuy";
            this.checkBuy.Size = new System.Drawing.Size(140, 32);
            this.checkBuy.TabIndex = 357;
            this.checkBuy.Text = "فواتير المشتريات";
            this.checkBuy.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSearchBuy.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSearchBuy.Location = new System.Drawing.Point(4, 131);
            this.DgvSearchBuy.Name = "DgvSearchBuy";
            this.DgvSearchBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearchBuy.Size = new System.Drawing.Size(1284, 367);
            this.DgvSearchBuy.TabIndex = 373;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(565, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 36);
            this.label6.TabIndex = 372;
            this.label6.Text = "الاقرار الضريبى";
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
            this.simpleButton1.Location = new System.Drawing.Point(1059, 78);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(229, 39);
            this.simpleButton1.TabIndex = 390;
            this.simpleButton1.Text = "عرض التقرير";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton2.Location = new System.Drawing.Point(4, 510);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(191, 39);
            this.simpleButton2.TabIndex = 391;
            this.simpleButton2.Text = "مسح البيانات المحدده";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseTextOptions = true;
            this.simpleButton3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton3.Location = new System.Drawing.Point(201, 510);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(129, 39);
            this.simpleButton3.TabIndex = 392;
            this.simpleButton3.Text = "طباعة تقرير";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Appearance.Options.UseTextOptions = true;
            this.simpleButton4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton4.Location = new System.Drawing.Point(336, 510);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(139, 39);
            this.simpleButton4.TabIndex = 393;
            this.simpleButton4.Text = "طباعة الملخص";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DtbEnd);
            this.groupBox3.Controls.Add(this.DtbStart);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(655, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 89);
            this.groupBox3.TabIndex = 381;
            this.groupBox3.TabStop = false;
            // 
            // Frm_TaxesReport
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1294, 562);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalWithTax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalTax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalPhar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvSearchBuy);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_TaxesReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاقرار الضريبى";
            this.Load += new System.EventHandler(this.Frm_TaxesReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalWithTax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalTax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalPhar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtbEnd;
        private System.Windows.Forms.DateTimePicker DtbStart;
        private System.Windows.Forms.CheckBox checkSale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBuy;
        private System.Windows.Forms.DataGridView DgvSearchBuy;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkReturnSale;
        private System.Windows.Forms.CheckBox checkReturnBuy;
    }
}
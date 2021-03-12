namespace Sales_Management
{
    partial class Frm_StockTransfire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_StockTransfire));
            this.label7 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrentMoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxStock = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtbDate = new System.Windows.Forms.DateTimePicker();
            this.NudMoney = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(118, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 409;
            this.label7.Text = "سبب التحويل:";
            // 
            // txtReason
            // 
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Location = new System.Drawing.Point(218, 302);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(262, 32);
            this.txtReason.TabIndex = 408;
            this.txtReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(179, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 407;
            this.label5.Text = "الرصيد:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(179, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 406;
            this.label4.Text = "الرصيد:";
            // 
            // lblCurrentMoney
            // 
            this.lblCurrentMoney.AutoSize = true;
            this.lblCurrentMoney.Location = new System.Drawing.Point(271, 54);
            this.lblCurrentMoney.Name = "lblCurrentMoney";
            this.lblCurrentMoney.Size = new System.Drawing.Size(28, 25);
            this.lblCurrentMoney.TabIndex = 394;
            this.lblCurrentMoney.Text = "....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(139, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 405;
            this.label2.Text = "الى خزنه:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(218, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 33);
            this.comboBox1.TabIndex = 404;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(107, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 403;
            this.label8.Text = "تحويل من خزنه:";
            // 
            // cbxStock
            // 
            this.cbxStock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStock.FormattingEnabled = true;
            this.cbxStock.Location = new System.Drawing.Point(218, 12);
            this.cbxStock.Name = "cbxStock";
            this.cbxStock.Size = new System.Drawing.Size(262, 33);
            this.cbxStock.TabIndex = 402;
            this.cbxStock.SelectedIndexChanged += new System.EventHandler(this.cbxStock_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(5, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 400;
            this.label1.Text = "اسم الشخص المسؤل عن التحويل:";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(218, 258);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(262, 32);
            this.txtItemName.TabIndex = 399;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(118, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 398;
            this.label3.Text = "تاريخ التحويل:";
            // 
            // DtbDate
            // 
            this.DtbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbDate.Location = new System.Drawing.Point(218, 217);
            this.DtbDate.Name = "DtbDate";
            this.DtbDate.Size = new System.Drawing.Size(262, 32);
            this.DtbDate.TabIndex = 397;
            // 
            // NudMoney
            // 
            this.NudMoney.DecimalPlaces = 2;
            this.NudMoney.Location = new System.Drawing.Point(218, 174);
            this.NudMoney.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.NudMoney.Name = "NudMoney";
            this.NudMoney.Size = new System.Drawing.Size(262, 32);
            this.NudMoney.TabIndex = 396;
            this.NudMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(81, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 25);
            this.label9.TabIndex = 395;
            this.label9.Text = "المبلغ المراد تحويله:";
            // 
            // button1
            // 
            this.button1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Appearance.Options.UseFont = true;
            this.button1.Appearance.Options.UseTextOptions = true;
            this.button1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.button1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.button1.Location = new System.Drawing.Point(218, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 40);
            this.button1.TabIndex = 425;
            this.button1.Text = "تحويل";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 25);
            this.label6.TabIndex = 426;
            this.label6.Text = "....";
            // 
            // Frm_StockTransfire
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(487, 415);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCurrentMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtbDate);
            this.Controls.Add(this.NudMoney);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Frm_StockTransfire";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحويل رصيد من خزنه الى اخرى";
            this.Load += new System.EventHandler(this.Frm_StockTransfire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrentMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtbDate;
        private System.Windows.Forms.NumericUpDown NudMoney;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton button1;
        private System.Windows.Forms.Label label6;
    }
}
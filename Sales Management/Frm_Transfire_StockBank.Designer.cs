namespace Sales_Management
{
    partial class Frm_Transfire_StockBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Transfire_StockBank));
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtbDate = new System.Windows.Forms.DateTimePicker();
            this.NudMoney = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCurrentMoney = new System.Windows.Forms.Label();
            this.rbtnFromStockToBank = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMoneyBank = new System.Windows.Forms.Label();
            this.rbtnFromBankToStock = new System.Windows.Forms.RadioButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.NudMoney)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 28);
            this.label1.TabIndex = 383;
            this.label1.Text = "اسم الشخص المسؤل عن التحويل:";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(239, 298);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(289, 36);
            this.txtItemName.TabIndex = 382;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(132, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 381;
            this.label3.Text = "تاريخ التحويل:";
            // 
            // DtbDate
            // 
            this.DtbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbDate.Location = new System.Drawing.Point(239, 257);
            this.DtbDate.Name = "DtbDate";
            this.DtbDate.Size = new System.Drawing.Size(289, 36);
            this.DtbDate.TabIndex = 380;
            // 
            // NudMoney
            // 
            this.NudMoney.DecimalPlaces = 2;
            this.NudMoney.Location = new System.Drawing.Point(239, 214);
            this.NudMoney.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.NudMoney.Name = "NudMoney";
            this.NudMoney.Size = new System.Drawing.Size(289, 36);
            this.NudMoney.TabIndex = 379;
            this.NudMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(91, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 28);
            this.label9.TabIndex = 378;
            this.label9.Text = "المبلغ المراد تحويله:";
            // 
            // lblCurrentMoney
            // 
            this.lblCurrentMoney.AutoSize = true;
            this.lblCurrentMoney.Location = new System.Drawing.Point(194, 68);
            this.lblCurrentMoney.Name = "lblCurrentMoney";
            this.lblCurrentMoney.Size = new System.Drawing.Size(32, 28);
            this.lblCurrentMoney.TabIndex = 362;
            this.lblCurrentMoney.Text = "....";
            // 
            // rbtnFromStockToBank
            // 
            this.rbtnFromStockToBank.AutoSize = true;
            this.rbtnFromStockToBank.Checked = true;
            this.rbtnFromStockToBank.ForeColor = System.Drawing.Color.Blue;
            this.rbtnFromStockToBank.Location = new System.Drawing.Point(10, 161);
            this.rbtnFromStockToBank.Name = "rbtnFromStockToBank";
            this.rbtnFromStockToBank.Size = new System.Drawing.Size(245, 32);
            this.rbtnFromStockToBank.TabIndex = 376;
            this.rbtnFromStockToBank.TabStop = true;
            this.rbtnFromStockToBank.Text = "تحويل الرصيد من الخزنة الى البنك";
            this.rbtnFromStockToBank.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblCurrentMoney);
            this.groupBox1.Controls.Add(this.lblMoneyBank);
            this.groupBox1.Location = new System.Drawing.Point(10, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 153);
            this.groupBox1.TabIndex = 377;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(295, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 374;
            this.label4.Text = "اختر خزنه:";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(6, 24);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(283, 36);
            this.cbxType.TabIndex = 373;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(286, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 36);
            this.label2.TabIndex = 363;
            this.label2.Text = "رصيد البنك الحالى:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(286, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 36);
            this.label6.TabIndex = 361;
            this.label6.Text = "رصيد الخزنة الحالى هو :";
            // 
            // lblMoneyBank
            // 
            this.lblMoneyBank.AutoSize = true;
            this.lblMoneyBank.Location = new System.Drawing.Point(194, 103);
            this.lblMoneyBank.Name = "lblMoneyBank";
            this.lblMoneyBank.Size = new System.Drawing.Size(32, 28);
            this.lblMoneyBank.TabIndex = 364;
            this.lblMoneyBank.Text = "....";
            // 
            // rbtnFromBankToStock
            // 
            this.rbtnFromBankToStock.AutoSize = true;
            this.rbtnFromBankToStock.ForeColor = System.Drawing.Color.Blue;
            this.rbtnFromBankToStock.Location = new System.Drawing.Point(283, 161);
            this.rbtnFromBankToStock.Name = "rbtnFromBankToStock";
            this.rbtnFromBankToStock.Size = new System.Drawing.Size(245, 32);
            this.rbtnFromBankToStock.TabIndex = 375;
            this.rbtnFromBankToStock.Text = "تحويل الرصيد من البنك الى الخزنة";
            this.rbtnFromBankToStock.UseVisualStyleBackColor = true;
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
            this.btnSearch.Location = new System.Drawing.Point(239, 340);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(289, 46);
            this.btnSearch.TabIndex = 394;
            this.btnSearch.Text = "اتمام عملية التحويل";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Frm_Transfire_StockBank
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(545, 390);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtbDate);
            this.Controls.Add(this.NudMoney);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbtnFromStockToBank);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbtnFromBankToStock);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Transfire_StockBank";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحويل رصيد من البنك للخزنه والعكس";
            this.Load += new System.EventHandler(this.Frm_Transfire_StockBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudMoney)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtbDate;
        private System.Windows.Forms.NumericUpDown NudMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCurrentMoney;
        private System.Windows.Forms.RadioButton rbtnFromStockToBank;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMoneyBank;
        private System.Windows.Forms.RadioButton rbtnFromBankToStock;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxType;
    }
}
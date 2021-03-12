namespace Sales_Management
{
    partial class Frm_ItemsOutStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ItemsOutStore));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cbxUnit = new System.Windows.Forms.ComboBox();
            this.NudQty = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxStoreFrom = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DtbSaleDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQty)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxItems);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.cbxUnit);
            this.groupBox1.Controls.Add(this.NudQty);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbxStoreFrom);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 234);
            this.groupBox1.TabIndex = 372;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المنتج";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(283, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 382;
            this.label2.Text = "بحث بالباركود:";
            // 
            // cbxItems
            // 
            this.cbxItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(20, 57);
            this.cbxItems.Margin = new System.Windows.Forms.Padding(2);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(254, 30);
            this.cbxItems.TabIndex = 375;
            this.cbxItems.SelectedIndexChanged += new System.EventHandler(this.cbxItems_SelectedIndexChanged);
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Location = new System.Drawing.Point(21, 23);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(253, 30);
            this.txtBarcode.TabIndex = 381;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(279, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 376;
            this.label1.Text = "اختر المنتج:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(275, 199);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 22);
            this.label24.TabIndex = 374;
            this.label24.Text = "الوحدة:";
            // 
            // cbxUnit
            // 
            this.cbxUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxUnit.FormattingEnabled = true;
            this.cbxUnit.Location = new System.Drawing.Point(20, 194);
            this.cbxUnit.Margin = new System.Windows.Forms.Padding(2);
            this.cbxUnit.Name = "cbxUnit";
            this.cbxUnit.Size = new System.Drawing.Size(254, 30);
            this.cbxUnit.TabIndex = 373;
            // 
            // NudQty
            // 
            this.NudQty.DecimalPlaces = 2;
            this.NudQty.Location = new System.Drawing.Point(20, 146);
            this.NudQty.Margin = new System.Windows.Forms.Padding(2);
            this.NudQty.Maximum = new decimal(new int[] {
            -402653184,
            -1613725636,
            54210108,
            0});
            this.NudQty.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.NudQty.Name = "NudQty";
            this.NudQty.Size = new System.Drawing.Size(254, 30);
            this.NudQty.TabIndex = 372;
            this.NudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(284, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 22);
            this.label9.TabIndex = 371;
            this.label9.Text = "الكمية:";
            // 
            // cbxStoreFrom
            // 
            this.cbxStoreFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStoreFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStoreFrom.FormattingEnabled = true;
            this.cbxStoreFrom.Location = new System.Drawing.Point(20, 102);
            this.cbxStoreFrom.Margin = new System.Windows.Forms.Padding(2);
            this.cbxStoreFrom.Name = "cbxStoreFrom";
            this.cbxStoreFrom.Size = new System.Drawing.Size(254, 30);
            this.cbxStoreFrom.TabIndex = 369;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(279, 105);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 22);
            this.label19.TabIndex = 370;
            this.label19.Text = "المخزن :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DtbSaleDate);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.txtReason);
            this.groupBox3.Location = new System.Drawing.Point(393, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 234);
            this.groupBox3.TabIndex = 382;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات العملية";
            // 
            // DtbSaleDate
            // 
            this.DtbSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbSaleDate.Location = new System.Drawing.Point(6, 29);
            this.DtbSaleDate.Name = "DtbSaleDate";
            this.DtbSaleDate.Size = new System.Drawing.Size(253, 30);
            this.DtbSaleDate.TabIndex = 376;
            this.DtbSaleDate.Value = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
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
            this.btnAdd.Location = new System.Drawing.Point(5, 178);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(253, 46);
            this.btnAdd.TabIndex = 380;
            this.btnAdd.Text = "اتمام العملية";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(268, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 22);
            this.label5.TabIndex = 377;
            this.label5.Text = "التاريخ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(268, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 375;
            this.label4.Text = "سبب الاخراج:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(268, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 22);
            this.label6.TabIndex = 379;
            this.label6.Text = "المسؤل عن الاخراج:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(6, 71);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 30);
            this.txtName.TabIndex = 378;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReason
            // 
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Location = new System.Drawing.Point(6, 114);
            this.txtReason.Margin = new System.Windows.Forms.Padding(2);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(253, 58);
            this.txtReason.TabIndex = 375;
            this.txtReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_ItemsOutStore
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(777, 256);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_ItemsOutStore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اخراج المنتجات التالفه من المخزن";
            this.Load += new System.EventHandler(this.Frm_ItemsOutStore_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQty)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbxItems;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.ComboBox cbxUnit;
        private System.Windows.Forms.NumericUpDown NudQty;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cbxStoreFrom;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker DtbSaleDate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtReason;
    }
}
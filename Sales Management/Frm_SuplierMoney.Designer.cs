namespace Sales_Management
{
    partial class Frm_SuplierMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SuplierMoney));
            this.DtbSaleDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NudSale = new System.Windows.Forms.NumericUpDown();
            this.rbtnPart = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPhar = new System.Windows.Forms.TextBox();
            this.DgvSearchBuy = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.rbtnAllCustomer = new System.Windows.Forms.RadioButton();
            this.cbxCustomer = new System.Windows.Forms.ComboBox();
            this.rbtnOneCustomer = new System.Windows.Forms.RadioButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DtbSaleDate
            // 
            this.DtbSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbSaleDate.Location = new System.Drawing.Point(42, 12);
            this.DtbSaleDate.Name = "DtbSaleDate";
            this.DtbSaleDate.Size = new System.Drawing.Size(198, 24);
            this.DtbSaleDate.TabIndex = 374;
            this.DtbSaleDate.Value = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NudSale);
            this.groupBox1.Controls.Add(this.rbtnPart);
            this.groupBox1.Controls.Add(this.rbtnAll);
            this.groupBox1.Location = new System.Drawing.Point(27, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 66);
            this.groupBox1.TabIndex = 373;
            this.groupBox1.TabStop = false;
            // 
            // NudSale
            // 
            this.NudSale.DecimalPlaces = 2;
            this.NudSale.Location = new System.Drawing.Point(17, 22);
            this.NudSale.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.NudSale.Name = "NudSale";
            this.NudSale.Size = new System.Drawing.Size(82, 24);
            this.NudSale.TabIndex = 344;
            this.NudSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudSale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbtnPart
            // 
            this.rbtnPart.AutoSize = true;
            this.rbtnPart.ForeColor = System.Drawing.Color.Red;
            this.rbtnPart.Location = new System.Drawing.Point(99, 23);
            this.rbtnPart.Name = "rbtnPart";
            this.rbtnPart.Size = new System.Drawing.Size(98, 22);
            this.rbtnPart.TabIndex = 343;
            this.rbtnPart.Text = "تسديد جزء منه";
            this.rbtnPart.UseVisualStyleBackColor = true;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.ForeColor = System.Drawing.Color.Red;
            this.rbtnAll.Location = new System.Drawing.Point(234, 24);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(112, 22);
            this.rbtnAll.TabIndex = 342;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "تسديد المبلغ كامل";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(626, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 366;
            this.label3.Text = "اجمالى المبالغ المتبقية:";
            // 
            // txtTotalPhar
            // 
            this.txtTotalPhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPhar.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalPhar.Location = new System.Drawing.Point(800, 444);
            this.txtTotalPhar.Name = "txtTotalPhar";
            this.txtTotalPhar.ReadOnly = true;
            this.txtTotalPhar.Size = new System.Drawing.Size(130, 24);
            this.txtTotalPhar.TabIndex = 365;
            this.txtTotalPhar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DgvSearchBuy
            // 
            this.DgvSearchBuy.AllowUserToAddRows = false;
            this.DgvSearchBuy.AllowUserToDeleteRows = false;
            this.DgvSearchBuy.AllowUserToResizeColumns = false;
            this.DgvSearchBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSearchBuy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvSearchBuy.BackgroundColor = System.Drawing.Color.White;
            this.DgvSearchBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSearchBuy.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSearchBuy.Location = new System.Drawing.Point(27, 121);
            this.DgvSearchBuy.Name = "DgvSearchBuy";
            this.DgvSearchBuy.ReadOnly = true;
            this.DgvSearchBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearchBuy.Size = new System.Drawing.Size(903, 299);
            this.DgvSearchBuy.TabIndex = 363;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.rbtnAllCustomer);
            this.groupBox2.Controls.Add(this.cbxCustomer);
            this.groupBox2.Controls.Add(this.rbtnOneCustomer);
            this.groupBox2.Location = new System.Drawing.Point(26, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(903, 73);
            this.groupBox2.TabIndex = 376;
            this.groupBox2.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Appearance.Options.UseTextOptions = true;
            this.btnPrint.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnPrint.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnPrint.Location = new System.Drawing.Point(31, 23);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(167, 35);
            this.btnPrint.TabIndex = 375;
            this.btnPrint.Text = "طباعة تقرير مفصل";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.btnSearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(232, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 35);
            this.btnSearch.TabIndex = 374;
            this.btnSearch.Text = "بحث";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbtnAllCustomer
            // 
            this.rbtnAllCustomer.AutoSize = true;
            this.rbtnAllCustomer.Checked = true;
            this.rbtnAllCustomer.ForeColor = System.Drawing.Color.Red;
            this.rbtnAllCustomer.Location = new System.Drawing.Point(395, 28);
            this.rbtnAllCustomer.Name = "rbtnAllCustomer";
            this.rbtnAllCustomer.Size = new System.Drawing.Size(87, 22);
            this.rbtnAllCustomer.TabIndex = 371;
            this.rbtnAllCustomer.TabStop = true;
            this.rbtnAllCustomer.Text = "كل الموردين";
            this.rbtnAllCustomer.UseVisualStyleBackColor = true;
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.Location = new System.Drawing.Point(649, 26);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(240, 26);
            this.cbxCustomer.TabIndex = 373;
            // 
            // rbtnOneCustomer
            // 
            this.rbtnOneCustomer.AutoSize = true;
            this.rbtnOneCustomer.ForeColor = System.Drawing.Color.Red;
            this.rbtnOneCustomer.Location = new System.Drawing.Point(522, 29);
            this.rbtnOneCustomer.Name = "rbtnOneCustomer";
            this.rbtnOneCustomer.Size = new System.Drawing.Size(78, 22);
            this.rbtnOneCustomer.TabIndex = 372;
            this.rbtnOneCustomer.Text = "مورد محدد";
            this.rbtnOneCustomer.UseVisualStyleBackColor = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(345, 4);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(187, 25);
            this.labelControl1.TabIndex = 377;
            this.labelControl1.Text = "المبالغ المتبقية للموردين";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseTextOptions = true;
            this.btnDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnDelete.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(446, 436);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 46);
            this.btnDelete.TabIndex = 376;
            this.btnDelete.Text = "تسديد المحدد";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 50);
            this.pictureBox1.TabIndex = 375;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_SuplierMoney
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseTextOptions = true;
            this.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(942, 492);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtbSaleDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalPhar);
            this.Controls.Add(this.DgvSearchBuy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_SuplierMoney";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابات الموردين";
            this.Load += new System.EventHandler(this.Frm_SuplierMoney_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DtbSaleDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NudSale;
        private System.Windows.Forms.RadioButton rbtnPart;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalPhar;
        private System.Windows.Forms.DataGridView DgvSearchBuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnAllCustomer;
        public System.Windows.Forms.ComboBox cbxCustomer;
        private System.Windows.Forms.RadioButton rbtnOneCustomer;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
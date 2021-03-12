namespace Sales_Management
{
    partial class Frm_CustomerMoneyRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CustomerMoneyRent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnAllCustomer = new System.Windows.Forms.RadioButton();
            this.cbxCustomer = new System.Windows.Forms.ComboBox();
            this.rbtnOneCustomer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.DtbSaleDate = new System.Windows.Forms.DateTimePicker();
            this.DgvSearchBuy = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.NudQty = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rbtnPart = new System.Windows.Forms.RadioButton();
            this.txtTotalPhar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NudProblemPay = new System.Windows.Forms.NumericUpDown();
            this.btnProblemPay = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalAll = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NudQtyAll = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NudAllPrice = new System.Windows.Forms.NumericUpDown();
            this.btnPayOrder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQty)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudProblemPay)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQtyAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAllPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(313, -5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 52);
            this.label6.TabIndex = 359;
            this.label6.Text = "حسابات العملاء الايجار";
            // 
            // rbtnAllCustomer
            // 
            this.rbtnAllCustomer.AutoSize = true;
            this.rbtnAllCustomer.Checked = true;
            this.rbtnAllCustomer.ForeColor = System.Drawing.Color.Blue;
            this.rbtnAllCustomer.Location = new System.Drawing.Point(604, 25);
            this.rbtnAllCustomer.Name = "rbtnAllCustomer";
            this.rbtnAllCustomer.Size = new System.Drawing.Size(99, 32);
            this.rbtnAllCustomer.TabIndex = 366;
            this.rbtnAllCustomer.TabStop = true;
            this.rbtnAllCustomer.Text = "كل العملاء";
            this.rbtnAllCustomer.UseVisualStyleBackColor = true;
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.Location = new System.Drawing.Point(270, 23);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(210, 36);
            this.cbxCustomer.TabIndex = 368;
            // 
            // rbtnOneCustomer
            // 
            this.rbtnOneCustomer.AutoSize = true;
            this.rbtnOneCustomer.ForeColor = System.Drawing.Color.Blue;
            this.rbtnOneCustomer.Location = new System.Drawing.Point(486, 25);
            this.rbtnOneCustomer.Name = "rbtnOneCustomer";
            this.rbtnOneCustomer.Size = new System.Drawing.Size(103, 32);
            this.rbtnOneCustomer.TabIndex = 367;
            this.rbtnOneCustomer.Text = "عميل محدد";
            this.rbtnOneCustomer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbxCustomer);
            this.groupBox1.Controls.Add(this.rbtnAllCustomer);
            this.groupBox1.Controls.Add(this.rbtnOneCustomer);
            this.groupBox1.Location = new System.Drawing.Point(118, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 71);
            this.groupBox1.TabIndex = 372;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Appearance.Options.UseTextOptions = true;
            this.btnSearch.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSearch.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSearch.Location = new System.Drawing.Point(25, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(215, 37);
            this.btnSearch.TabIndex = 376;
            this.btnSearch.Text = "بحث";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DtbSaleDate
            // 
            this.DtbSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbSaleDate.Location = new System.Drawing.Point(722, 5);
            this.DtbSaleDate.Name = "DtbSaleDate";
            this.DtbSaleDate.Size = new System.Drawing.Size(124, 36);
            this.DtbSaleDate.TabIndex = 373;
            this.DtbSaleDate.Value = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
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
            this.DgvSearchBuy.Location = new System.Drawing.Point(6, 113);
            this.DgvSearchBuy.Name = "DgvSearchBuy";
            this.DgvSearchBuy.ReadOnly = true;
            this.DgvSearchBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearchBuy.Size = new System.Drawing.Size(951, 267);
            this.DgvSearchBuy.TabIndex = 375;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnAll);
            this.groupBox2.Controls.Add(this.NudQty);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.rbtnPart);
            this.groupBox2.Location = new System.Drawing.Point(8, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 73);
            this.groupBox2.TabIndex = 376;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "طريقة الاسترداد";
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.ForeColor = System.Drawing.Color.Blue;
            this.rbtnAll.Location = new System.Drawing.Point(435, 27);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(167, 32);
            this.rbtnAll.TabIndex = 347;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "استرداد الكمية كاملة";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // NudQty
            // 
            this.NudQty.DecimalPlaces = 2;
            this.NudQty.Location = new System.Drawing.Point(199, 25);
            this.NudQty.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.NudQty.Name = "NudQty";
            this.NudQty.Size = new System.Drawing.Size(73, 36);
            this.NudQty.TabIndex = 349;
            this.NudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(14, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 41);
            this.btnDelete.TabIndex = 370;
            this.btnDelete.Text = "استرداد الصنف المحدد";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rbtnPart
            // 
            this.rbtnPart.AutoSize = true;
            this.rbtnPart.ForeColor = System.Drawing.Color.Blue;
            this.rbtnPart.Location = new System.Drawing.Point(281, 27);
            this.rbtnPart.Name = "rbtnPart";
            this.rbtnPart.Size = new System.Drawing.Size(140, 32);
            this.rbtnPart.TabIndex = 348;
            this.rbtnPart.Text = "استرداد جزء منها";
            this.rbtnPart.UseVisualStyleBackColor = true;
            // 
            // txtTotalPhar
            // 
            this.txtTotalPhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPhar.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalPhar.Location = new System.Drawing.Point(730, 454);
            this.txtTotalPhar.Name = "txtTotalPhar";
            this.txtTotalPhar.ReadOnly = true;
            this.txtTotalPhar.Size = new System.Drawing.Size(201, 36);
            this.txtTotalPhar.TabIndex = 377;
            this.txtTotalPhar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(759, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 28);
            this.label3.TabIndex = 378;
            this.label3.Text = "اجمالى المبالغ للكراء";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.NudProblemPay);
            this.groupBox3.Controls.Add(this.btnProblemPay);
            this.groupBox3.Location = new System.Drawing.Point(8, 465);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 66);
            this.groupBox3.TabIndex = 379;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تعويض عن الضرر";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(279, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 28);
            this.label1.TabIndex = 373;
            this.label1.Text = "مبلغ التعويض عن الضرر او التاخير للعميل :";
            // 
            // NudProblemPay
            // 
            this.NudProblemPay.DecimalPlaces = 2;
            this.NudProblemPay.Location = new System.Drawing.Point(199, 20);
            this.NudProblemPay.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.NudProblemPay.Name = "NudProblemPay";
            this.NudProblemPay.Size = new System.Drawing.Size(74, 36);
            this.NudProblemPay.TabIndex = 349;
            this.NudProblemPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudProblemPay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnProblemPay
            // 
            this.btnProblemPay.ForeColor = System.Drawing.Color.Black;
            this.btnProblemPay.Location = new System.Drawing.Point(14, 19);
            this.btnProblemPay.Name = "btnProblemPay";
            this.btnProblemPay.Size = new System.Drawing.Size(165, 39);
            this.btnProblemPay.TabIndex = 372;
            this.btnProblemPay.Text = "التعويض عن الضرر";
            this.btnProblemPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProblemPay.UseVisualStyleBackColor = true;
            this.btnProblemPay.Click += new System.EventHandler(this.btnProblemPay_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtTotalAll);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.NudQtyAll);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.NudAllPrice);
            this.groupBox4.Controls.Add(this.btnPayOrder);
            this.groupBox4.Location = new System.Drawing.Point(9, 537);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(948, 74);
            this.groupBox4.TabIndex = 380;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "تسديد ثمن المنتج فى حاله التلف";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(285, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 28);
            this.label5.TabIndex = 376;
            this.label5.Text = "اجمالى:";
            // 
            // txtTotalAll
            // 
            this.txtTotalAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAll.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalAll.Location = new System.Drawing.Point(156, 28);
            this.txtTotalAll.Name = "txtTotalAll";
            this.txtTotalAll.ReadOnly = true;
            this.txtTotalAll.Size = new System.Drawing.Size(128, 36);
            this.txtTotalAll.TabIndex = 375;
            this.txtTotalAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(442, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 28);
            this.label4.TabIndex = 375;
            this.label4.Text = "عدد المنتجات التالفة:";
            // 
            // NudQtyAll
            // 
            this.NudQtyAll.DecimalPlaces = 2;
            this.NudQtyAll.Location = new System.Drawing.Point(358, 27);
            this.NudQtyAll.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.NudQtyAll.Name = "NudQtyAll";
            this.NudQtyAll.Size = new System.Drawing.Size(78, 36);
            this.NudQtyAll.TabIndex = 374;
            this.NudQtyAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudQtyAll.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudQtyAll.ValueChanged += new System.EventHandler(this.NudQtyAll_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(699, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 28);
            this.label2.TabIndex = 373;
            this.label2.Text = "دفع ثمن المنتج كامل للتلف:";
            // 
            // NudAllPrice
            // 
            this.NudAllPrice.DecimalPlaces = 2;
            this.NudAllPrice.Location = new System.Drawing.Point(611, 27);
            this.NudAllPrice.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.NudAllPrice.Name = "NudAllPrice";
            this.NudAllPrice.Size = new System.Drawing.Size(84, 36);
            this.NudAllPrice.TabIndex = 349;
            this.NudAllPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudAllPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudAllPrice.ValueChanged += new System.EventHandler(this.NudAllPrice_ValueChanged);
            // 
            // btnPayOrder
            // 
            this.btnPayOrder.ForeColor = System.Drawing.Color.Black;
            this.btnPayOrder.Location = new System.Drawing.Point(13, 27);
            this.btnPayOrder.Name = "btnPayOrder";
            this.btnPayOrder.Size = new System.Drawing.Size(123, 39);
            this.btnPayOrder.TabIndex = 372;
            this.btnPayOrder.Text = "اتمام العملية";
            this.btnPayOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPayOrder.UseVisualStyleBackColor = true;
            this.btnPayOrder.Click += new System.EventHandler(this.btnPayOrder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(689, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 40);
            this.pictureBox1.TabIndex = 374;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_CustomerMoneyRent
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(964, 616);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtTotalPhar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DgvSearchBuy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtbSaleDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CustomerMoneyRent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابات العملاء - الايجار";
            this.Load += new System.EventHandler(this.Frm_CustomerMoneyRent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQty)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudProblemPay)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQtyAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAllPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtnAllCustomer;
        public System.Windows.Forms.ComboBox cbxCustomer;
        private System.Windows.Forms.RadioButton rbtnOneCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.DateTimePicker DtbSaleDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DgvSearchBuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.NumericUpDown NudQty;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton rbtnPart;
        private System.Windows.Forms.TextBox txtTotalPhar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NudProblemPay;
        private System.Windows.Forms.Button btnProblemPay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudQtyAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NudAllPrice;
        private System.Windows.Forms.Button btnPayOrder;
    }
}
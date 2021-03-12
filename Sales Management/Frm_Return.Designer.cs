namespace Sales_Management
{
    partial class Frm_Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Return));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label8 = new System.Windows.Forms.Label();
            this.textParcode = new System.Windows.Forms.TextBox();
            this.rbtnSuplier = new System.Windows.Forms.RadioButton();
            this.rbtnCustomer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.NudMadfo3 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTotalWithtax = new System.Windows.Forms.TextBox();
            this.txtTotalTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblStore1 = new System.Windows.Forms.Label();
            this.cbxStore = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReturnerName = new System.Windows.Forms.TextBox();
            this.btnReturnAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnReturnPart = new DevExpress.XtraEditors.SimpleButton();
            this.DtbSaleDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvSearchBuy = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblStore2 = new System.Windows.Forms.Label();
            this.NudQtyReturn = new System.Windows.Forms.NumericUpDown();
            this.cbxStore2 = new System.Windows.Forms.ComboBox();
            this.rbtnReturnPart = new System.Windows.Forms.RadioButton();
            this.rbtnReturnAll = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReturnerName2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudMadfo3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQtyReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.labelControl1.Location = new System.Drawing.Point(356, -1);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(174, 40);
            this.labelControl1.TabIndex = 378;
            this.labelControl1.Text = "عمليات المرتجعات";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(518, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 28);
            this.label8.TabIndex = 384;
            this.label8.Text = "بحث برقم الفاتورة:";
            // 
            // textParcode
            // 
            this.textParcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textParcode.ForeColor = System.Drawing.Color.Blue;
            this.textParcode.Location = new System.Drawing.Point(653, 52);
            this.textParcode.Name = "textParcode";
            this.textParcode.Size = new System.Drawing.Size(198, 36);
            this.textParcode.TabIndex = 383;
            this.textParcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textParcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textParcode_KeyPress);
            // 
            // rbtnSuplier
            // 
            this.rbtnSuplier.AutoSize = true;
            this.rbtnSuplier.Location = new System.Drawing.Point(6, 21);
            this.rbtnSuplier.Name = "rbtnSuplier";
            this.rbtnSuplier.Size = new System.Drawing.Size(130, 32);
            this.rbtnSuplier.TabIndex = 381;
            this.rbtnSuplier.Text = "مرتجع مشتريات";
            this.rbtnSuplier.UseVisualStyleBackColor = true;
            this.rbtnSuplier.CheckedChanged += new System.EventHandler(this.rbtnSuplier_CheckedChanged);
            // 
            // rbtnCustomer
            // 
            this.rbtnCustomer.AutoSize = true;
            this.rbtnCustomer.Checked = true;
            this.rbtnCustomer.Location = new System.Drawing.Point(157, 21);
            this.rbtnCustomer.Name = "rbtnCustomer";
            this.rbtnCustomer.Size = new System.Drawing.Size(119, 32);
            this.rbtnCustomer.TabIndex = 380;
            this.rbtnCustomer.TabStop = true;
            this.rbtnCustomer.Text = "مرتجع مبيعات";
            this.rbtnCustomer.UseVisualStyleBackColor = true;
            this.rbtnCustomer.CheckedChanged += new System.EventHandler(this.rbtnCustomer_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCustomer);
            this.groupBox1.Controls.Add(this.rbtnSuplier);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 62);
            this.groupBox1.TabIndex = 385;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtReport);
            this.groupBox2.Controls.Add(this.NudMadfo3);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtTotalWithtax);
            this.groupBox2.Controls.Add(this.txtTotalTax);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(12, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(839, 105);
            this.groupBox2.TabIndex = 459;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtReport
            // 
            this.txtReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReport.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.txtReport.ForeColor = System.Drawing.Color.Blue;
            this.txtReport.Location = new System.Drawing.Point(385, 67);
            this.txtReport.Name = "txtReport";
            this.txtReport.ReadOnly = true;
            this.txtReport.Size = new System.Drawing.Size(357, 30);
            this.txtReport.TabIndex = 421;
            this.txtReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NudMadfo3
            // 
            this.NudMadfo3.DecimalPlaces = 2;
            this.NudMadfo3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.NudMadfo3.Location = new System.Drawing.Point(627, 21);
            this.NudMadfo3.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.NudMadfo3.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.NudMadfo3.Name = "NudMadfo3";
            this.NudMadfo3.ReadOnly = true;
            this.NudMadfo3.Size = new System.Drawing.Size(108, 30);
            this.NudMadfo3.TabIndex = 452;
            this.NudMadfo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudMadfo3.ValueChanged += new System.EventHandler(this.NudMadfo3_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(254, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(141, 22);
            this.label20.TabIndex = 456;
            this.label20.Text = "الاجمالى بعد الضريبة:";
            // 
            // txtTotalWithtax
            // 
            this.txtTotalWithtax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalWithtax.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.txtTotalWithtax.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalWithtax.Location = new System.Drawing.Point(6, 67);
            this.txtTotalWithtax.Name = "txtTotalWithtax";
            this.txtTotalWithtax.ReadOnly = true;
            this.txtTotalWithtax.Size = new System.Drawing.Size(246, 30);
            this.txtTotalWithtax.TabIndex = 455;
            this.txtTotalWithtax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalTax.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.txtTotalTax.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalTax.Location = new System.Drawing.Point(6, 23);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.ReadOnly = true;
            this.txtTotalTax.Size = new System.Drawing.Size(246, 30);
            this.txtTotalTax.TabIndex = 453;
            this.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.txtTotal.ForeColor = System.Drawing.Color.Blue;
            this.txtTotal.Location = new System.Drawing.Point(385, 23);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(133, 30);
            this.txtTotal.TabIndex = 448;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(254, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 22);
            this.label19.TabIndex = 454;
            this.label19.Text = "اجمالى الضريبة:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(524, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 449;
            this.label5.Text = "اجمالى الفاتورة:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(753, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 28);
            this.label14.TabIndex = 422;
            this.label14.Text = "الباقى:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(737, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 451;
            this.label1.Text = "المبلغ المدفوع:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblStore1);
            this.groupBox3.Controls.Add(this.cbxStore);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtReturnerName);
            this.groupBox3.Controls.Add(this.btnReturnAll);
            this.groupBox3.Location = new System.Drawing.Point(12, 487);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 160);
            this.groupBox3.TabIndex = 460;
            this.groupBox3.TabStop = false;
            // 
            // lblStore1
            // 
            this.lblStore1.AutoSize = true;
            this.lblStore1.ForeColor = System.Drawing.Color.Red;
            this.lblStore1.Location = new System.Drawing.Point(243, 73);
            this.lblStore1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStore1.Name = "lblStore1";
            this.lblStore1.Size = new System.Drawing.Size(87, 28);
            this.lblStore1.TabIndex = 481;
            this.lblStore1.Text = "الى المخزن:";
            // 
            // cbxStore
            // 
            this.cbxStore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxStore.FormattingEnabled = true;
            this.cbxStore.Location = new System.Drawing.Point(6, 70);
            this.cbxStore.Name = "cbxStore";
            this.cbxStore.Size = new System.Drawing.Size(234, 36);
            this.cbxStore.TabIndex = 480;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(246, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 457;
            this.label3.Text = "اسم العميل:";
            // 
            // txtReturnerName
            // 
            this.txtReturnerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReturnerName.ForeColor = System.Drawing.Color.Blue;
            this.txtReturnerName.Location = new System.Drawing.Point(6, 26);
            this.txtReturnerName.Name = "txtReturnerName";
            this.txtReturnerName.Size = new System.Drawing.Size(234, 36);
            this.txtReturnerName.TabIndex = 479;
            this.txtReturnerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReturnAll
            // 
            this.btnReturnAll.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnAll.Appearance.Options.UseFont = true;
            this.btnReturnAll.Appearance.Options.UseTextOptions = true;
            this.btnReturnAll.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnReturnAll.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnReturnAll.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnAll.Image")));
            this.btnReturnAll.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnReturnAll.Location = new System.Drawing.Point(6, 112);
            this.btnReturnAll.Name = "btnReturnAll";
            this.btnReturnAll.Size = new System.Drawing.Size(234, 40);
            this.btnReturnAll.TabIndex = 424;
            this.btnReturnAll.Text = "ارجاع الفاتورة بالكامل";
            this.btnReturnAll.Click += new System.EventHandler(this.btnReturnAll_Click);
            // 
            // btnReturnPart
            // 
            this.btnReturnPart.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnPart.Appearance.Options.UseFont = true;
            this.btnReturnPart.Appearance.Options.UseTextOptions = true;
            this.btnReturnPart.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnReturnPart.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnReturnPart.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnPart.Image")));
            this.btnReturnPart.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnReturnPart.Location = new System.Drawing.Point(6, 70);
            this.btnReturnPart.Name = "btnReturnPart";
            this.btnReturnPart.Size = new System.Drawing.Size(200, 40);
            this.btnReturnPart.TabIndex = 423;
            this.btnReturnPart.Text = "ارجاع الصنف المحدد فقط";
            this.btnReturnPart.Click += new System.EventHandler(this.btnReturnPart_Click);
            // 
            // DtbSaleDate
            // 
            this.DtbSaleDate.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.DtbSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbSaleDate.Location = new System.Drawing.Point(393, 54);
            this.DtbSaleDate.Name = "DtbSaleDate";
            this.DtbSaleDate.Size = new System.Drawing.Size(98, 30);
            this.DtbSaleDate.TabIndex = 476;
            this.DtbSaleDate.Value = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(297, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 477;
            this.label2.Text = "تاريخ المرتجع:";
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
            this.DgvSearchBuy.Location = new System.Drawing.Point(12, 99);
            this.DgvSearchBuy.Name = "DgvSearchBuy";
            this.DgvSearchBuy.ReadOnly = true;
            this.DgvSearchBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearchBuy.Size = new System.Drawing.Size(839, 299);
            this.DgvSearchBuy.TabIndex = 478;
            this.DgvSearchBuy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSearchBuy_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblStore2);
            this.groupBox4.Controls.Add(this.NudQtyReturn);
            this.groupBox4.Controls.Add(this.cbxStore2);
            this.groupBox4.Controls.Add(this.rbtnReturnPart);
            this.groupBox4.Controls.Add(this.rbtnReturnAll);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtReturnerName2);
            this.groupBox4.Controls.Add(this.btnReturnPart);
            this.groupBox4.Location = new System.Drawing.Point(356, 487);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(495, 160);
            this.groupBox4.TabIndex = 480;
            this.groupBox4.TabStop = false;
            // 
            // lblStore2
            // 
            this.lblStore2.AutoSize = true;
            this.lblStore2.ForeColor = System.Drawing.Color.Red;
            this.lblStore2.Location = new System.Drawing.Point(341, 121);
            this.lblStore2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStore2.Name = "lblStore2";
            this.lblStore2.Size = new System.Drawing.Size(87, 28);
            this.lblStore2.TabIndex = 483;
            this.lblStore2.Text = "الى المخزن:";
            // 
            // NudQtyReturn
            // 
            this.NudQtyReturn.DecimalPlaces = 2;
            this.NudQtyReturn.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.NudQtyReturn.Location = new System.Drawing.Point(227, 78);
            this.NudQtyReturn.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.NudQtyReturn.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.NudQtyReturn.Name = "NudQtyReturn";
            this.NudQtyReturn.Size = new System.Drawing.Size(108, 30);
            this.NudQtyReturn.TabIndex = 457;
            this.NudQtyReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxStore2
            // 
            this.cbxStore2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStore2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStore2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxStore2.FormattingEnabled = true;
            this.cbxStore2.Location = new System.Drawing.Point(6, 118);
            this.cbxStore2.Name = "cbxStore2";
            this.cbxStore2.Size = new System.Drawing.Size(329, 36);
            this.cbxStore2.TabIndex = 482;
            // 
            // rbtnReturnPart
            // 
            this.rbtnReturnPart.AutoSize = true;
            this.rbtnReturnPart.Location = new System.Drawing.Point(341, 76);
            this.rbtnReturnPart.Name = "rbtnReturnPart";
            this.rbtnReturnPart.Size = new System.Drawing.Size(148, 32);
            this.rbtnReturnPart.TabIndex = 480;
            this.rbtnReturnPart.Text = "ارجاع كمية محددة";
            this.rbtnReturnPart.UseVisualStyleBackColor = true;
            // 
            // rbtnReturnAll
            // 
            this.rbtnReturnAll.AutoSize = true;
            this.rbtnReturnAll.Checked = true;
            this.rbtnReturnAll.Location = new System.Drawing.Point(330, 32);
            this.rbtnReturnAll.Name = "rbtnReturnAll";
            this.rbtnReturnAll.Size = new System.Drawing.Size(159, 32);
            this.rbtnReturnAll.TabIndex = 382;
            this.rbtnReturnAll.TabStop = true;
            this.rbtnReturnAll.Text = "ارجاع الكمية الكاملة";
            this.rbtnReturnAll.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(227, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 457;
            this.label4.Text = "اسم العميل:";
            // 
            // txtReturnerName2
            // 
            this.txtReturnerName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReturnerName2.ForeColor = System.Drawing.Color.Blue;
            this.txtReturnerName2.Location = new System.Drawing.Point(6, 26);
            this.txtReturnerName2.Name = "txtReturnerName2";
            this.txtReturnerName2.Size = new System.Drawing.Size(200, 36);
            this.txtReturnerName2.TabIndex = 479;
            this.txtReturnerName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_Return
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseTextOptions = true;
            this.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(857, 651);
            this.Controls.Add(this.DgvSearchBuy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DtbSaleDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textParcode);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_Return";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة المرتجعات";
            this.Load += new System.EventHandler(this.Frm_Return_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudMadfo3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQtyReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textParcode;
        private System.Windows.Forms.RadioButton rbtnSuplier;
        private System.Windows.Forms.RadioButton rbtnCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.NumericUpDown NudMadfo3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTotalWithtax;
        private System.Windows.Forms.TextBox txtTotalTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnReturnAll;
        private DevExpress.XtraEditors.SimpleButton btnReturnPart;
        private System.Windows.Forms.DateTimePicker DtbSaleDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvSearchBuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReturnerName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReturnerName2;
        private System.Windows.Forms.NumericUpDown NudQtyReturn;
        private System.Windows.Forms.RadioButton rbtnReturnPart;
        private System.Windows.Forms.RadioButton rbtnReturnAll;
        private System.Windows.Forms.Label lblStore1;
        public System.Windows.Forms.ComboBox cbxStore;
        private System.Windows.Forms.Label lblStore2;
        public System.Windows.Forms.ComboBox cbxStore2;
    }
}
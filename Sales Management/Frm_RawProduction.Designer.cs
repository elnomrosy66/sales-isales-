namespace Sales_Management
{
    partial class Frm_RawProduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RawProduction));
            this.label13 = new System.Windows.Forms.Label();
            this.cbxStore = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.DgvStoreQty = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxRaw = new System.Windows.Forms.ComboBox();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.cbxUnitRaw = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NudQtyRaw = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxUnitItems = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NudQtyItems = new System.Windows.Forms.NumericUpDown();
            this.DtbSaleDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.NudBuyPrice = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.NudSalePrice = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.DtpExpired = new System.Windows.Forms.DateTimePicker();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStoreQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQtyRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQtyItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBuyPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSalePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(248, 13);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(206, 18);
            this.label13.TabIndex = 504;
            this.label13.Text = "المخزن الذى سيخزن بيه المنتج المصنع:";
            // 
            // cbxStore
            // 
            this.cbxStore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxStore.FormattingEnabled = true;
            this.cbxStore.Location = new System.Drawing.Point(514, 7);
            this.cbxStore.Name = "cbxStore";
            this.cbxStore.Size = new System.Drawing.Size(215, 26);
            this.cbxStore.TabIndex = 502;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(0, 479);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 18);
            this.label10.TabIndex = 501;
            this.label10.Text = "المنتج الذى تريد انتاجه:";
            // 
            // cbxItems
            // 
            this.cbxItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(129, 475);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(187, 26);
            this.cbxItems.TabIndex = 490;
            this.cbxItems.SelectedIndexChanged += new System.EventHandler(this.cbxItems_SelectedIndexChanged);
            this.cbxItems.SelectionChangeCommitted += new System.EventHandler(this.cbxItems_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(4, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 484;
            this.label3.Text = "رقم العملية:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderID.Location = new System.Drawing.Point(105, 11);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(139, 24);
            this.txtOrderID.TabIndex = 483;
            this.txtOrderID.Text = "1";
            this.txtOrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1087, 615);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(258, 38);
            this.txtTotal.TabIndex = 480;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DgvStoreQty
            // 
            this.DgvStoreQty.AllowUserToAddRows = false;
            this.DgvStoreQty.AllowUserToDeleteRows = false;
            this.DgvStoreQty.AllowUserToResizeColumns = false;
            this.DgvStoreQty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvStoreQty.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvStoreQty.BackgroundColor = System.Drawing.Color.White;
            this.DgvStoreQty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStoreQty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvStoreQty.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvStoreQty.Location = new System.Drawing.Point(5, 94);
            this.DgvStoreQty.Name = "DgvStoreQty";
            this.DgvStoreQty.ReadOnly = true;
            this.DgvStoreQty.RowHeadersVisible = false;
            this.DgvStoreQty.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvStoreQty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvStoreQty.Size = new System.Drawing.Size(1053, 371);
            this.DgvStoreQty.TabIndex = 474;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 25F;
            this.Column1.HeaderText = "رقم الخامة";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 60.14138F;
            this.Column2.HeaderText = "اسم الخامة";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 42.14138F;
            this.Column3.HeaderText = "الوحدة";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 20.14138F;
            this.Column4.HeaderText = "الكمية";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "السعر";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 506;
            this.label1.Text = "اختر خامة:";
            // 
            // cbxRaw
            // 
            this.cbxRaw.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxRaw.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxRaw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxRaw.FormattingEnabled = true;
            this.cbxRaw.Location = new System.Drawing.Point(105, 52);
            this.cbxRaw.Name = "cbxRaw";
            this.cbxRaw.Size = new System.Drawing.Size(191, 26);
            this.cbxRaw.TabIndex = 505;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseTextOptions = true;
            this.btnAdd.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnAdd.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAdd.Location = new System.Drawing.Point(864, 55);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 31);
            this.btnAdd.TabIndex = 507;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxUnitRaw
            // 
            this.cbxUnitRaw.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxUnitRaw.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxUnitRaw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxUnitRaw.FormattingEnabled = true;
            this.cbxUnitRaw.Location = new System.Drawing.Point(386, 52);
            this.cbxUnitRaw.Name = "cbxUnitRaw";
            this.cbxUnitRaw.Size = new System.Drawing.Size(138, 26);
            this.cbxUnitRaw.TabIndex = 508;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(301, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 509;
            this.label4.Text = "اختر وحدة:";
            // 
            // NudQtyRaw
            // 
            this.NudQtyRaw.DecimalPlaces = 3;
            this.NudQtyRaw.Location = new System.Drawing.Point(750, 53);
            this.NudQtyRaw.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NudQtyRaw.Name = "NudQtyRaw";
            this.NudQtyRaw.Size = new System.Drawing.Size(108, 24);
            this.NudQtyRaw.TabIndex = 510;
            this.NudQtyRaw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudQtyRaw.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(534, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 18);
            this.label5.TabIndex = 511;
            this.label5.Text = "الكمية المستخدمة فى الانتاج:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(452, 475);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 513;
            this.label2.Text = "الوحدة من المنتج المصنع:";
            // 
            // cbxUnitItems
            // 
            this.cbxUnitItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxUnitItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxUnitItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxUnitItems.FormattingEnabled = true;
            this.cbxUnitItems.Location = new System.Drawing.Point(594, 471);
            this.cbxUnitItems.Name = "cbxUnitItems";
            this.cbxUnitItems.Size = new System.Drawing.Size(148, 26);
            this.cbxUnitItems.TabIndex = 512;
            this.cbxUnitItems.SelectionChangeCommitted += new System.EventHandler(this.cbxUnitItems_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(745, 475);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 18);
            this.label6.TabIndex = 515;
            this.label6.Text = "الكمية من المنتج بعد تصنيعه:";
            // 
            // NudQtyItems
            // 
            this.NudQtyItems.DecimalPlaces = 3;
            this.NudQtyItems.Location = new System.Drawing.Point(896, 471);
            this.NudQtyItems.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NudQtyItems.Name = "NudQtyItems";
            this.NudQtyItems.Size = new System.Drawing.Size(120, 24);
            this.NudQtyItems.TabIndex = 514;
            this.NudQtyItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudQtyItems.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudQtyItems.ValueChanged += new System.EventHandler(this.NudQtyItems_ValueChanged);
            // 
            // DtbSaleDate
            // 
            this.DtbSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbSaleDate.Location = new System.Drawing.Point(852, 5);
            this.DtbSaleDate.Name = "DtbSaleDate";
            this.DtbSaleDate.Size = new System.Drawing.Size(118, 24);
            this.DtbSaleDate.TabIndex = 516;
            this.DtbSaleDate.Value = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(745, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 517;
            this.label7.Text = "تاريخ العملية:";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseTextOptions = true;
            this.btnSave.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSave.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSave.Location = new System.Drawing.Point(351, 560);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 56);
            this.btnSave.TabIndex = 518;
            this.btnSave.Text = "حفظ العملية";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDelete.Location = new System.Drawing.Point(919, 55);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 31);
            this.btnDelete.TabIndex = 519;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(1, 529);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 15);
            this.label8.TabIndex = 521;
            this.label8.Text = "سعر تكلفة المنتج بعد التصنيع (سعرالشراء):";
            // 
            // NudBuyPrice
            // 
            this.NudBuyPrice.DecimalPlaces = 3;
            this.NudBuyPrice.Location = new System.Drawing.Point(201, 523);
            this.NudBuyPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NudBuyPrice.Name = "NudBuyPrice";
            this.NudBuyPrice.Size = new System.Drawing.Size(93, 24);
            this.NudBuyPrice.TabIndex = 520;
            this.NudBuyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudBuyPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(664, 527);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 15);
            this.label11.TabIndex = 525;
            this.label11.Text = "سعر تكلفة المنتج بعد التصنيع (سعر بيع التجزئة):";
            // 
            // NudSalePrice
            // 
            this.NudSalePrice.DecimalPlaces = 3;
            this.NudSalePrice.Location = new System.Drawing.Point(898, 523);
            this.NudSalePrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NudSalePrice.Name = "NudSalePrice";
            this.NudSalePrice.Size = new System.Drawing.Size(101, 24);
            this.NudSalePrice.TabIndex = 524;
            this.NudSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudSalePrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudSalePrice.ValueChanged += new System.EventHandler(this.NudSalePrice_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(306, 525);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 18);
            this.label9.TabIndex = 527;
            this.label9.Text = "تاريخ انتهاء الصلاحية ان وجد:";
            // 
            // DtpExpired
            // 
            this.DtpExpired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpExpired.Location = new System.Drawing.Point(512, 519);
            this.DtpExpired.Name = "DtpExpired";
            this.DtpExpired.Size = new System.Drawing.Size(140, 24);
            this.DtpExpired.TabIndex = 526;
            this.DtpExpired.Value = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(327, 475);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(117, 27);
            this.simpleButton1.TabIndex = 528;
            this.simpleButton1.Text = "جلب الخامات";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Frm_RawProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 616);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DtpExpired);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NudSalePrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NudBuyPrice);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DtbSaleDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NudQtyItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxUnitItems);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NudQtyRaw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxUnitRaw);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxRaw);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxStore);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.DgvStoreQty);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_RawProduction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انتاج منتج جديد";
            this.Load += new System.EventHandler(this.Frm_RawProduction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStoreQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQtyRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQtyItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBuyPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSalePrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox cbxStore;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cbxItems;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtOrderID;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.DataGridView DgvStoreQty;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbxRaw;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        public System.Windows.Forms.ComboBox cbxUnitRaw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudQtyRaw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbxUnitItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NudQtyItems;
        private System.Windows.Forms.DateTimePicker DtbSaleDate;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NudBuyPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NudSalePrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DtpExpired;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
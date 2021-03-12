namespace Sales_Management
{
    partial class Frm_SalesSuperMarket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SalesSuperMarket));
            this.DgvStoreQty = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtnCustomerNakdy = new System.Windows.Forms.RadioButton();
            this.rbtnCustomerAagel = new System.Windows.Forms.RadioButton();
            this.cbxCustomer = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.DtbSaleDate = new System.Windows.Forms.DateTimePicker();
            this.DtbTime = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DtbReminder = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCustomerNakdy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFavItems = new DevExpress.XtraEditors.SimpleButton();
            this.label13 = new System.Windows.Forms.Label();
            this.past = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStoreQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvStoreQty
            // 
            this.DgvStoreQty.AllowUserToAddRows = false;
            this.DgvStoreQty.AllowUserToDeleteRows = false;
            this.DgvStoreQty.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvStoreQty.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvStoreQty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvStoreQty.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvStoreQty.BackgroundColor = System.Drawing.Color.White;
            this.DgvStoreQty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStoreQty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvStoreQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvStoreQty.Location = new System.Drawing.Point(12, 125);
            this.DgvStoreQty.Name = "DgvStoreQty";
            this.DgvStoreQty.ReadOnly = true;
            this.DgvStoreQty.RowHeadersVisible = false;
            this.DgvStoreQty.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvStoreQty.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvStoreQty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvStoreQty.Size = new System.Drawing.Size(1229, 446);
            this.DgvStoreQty.TabIndex = 367;
            this.DgvStoreQty.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStoreQty_CellEndEdit);
            this.DgvStoreQty.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStoreQty_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 15F;
            this.Column1.HeaderText = "رقم المنتج";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 60.14138F;
            this.Column2.HeaderText = "اسم المنتج";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 15F;
            this.Column3.HeaderText = "الوحدة";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 15F;
            this.Column4.HeaderText = "الكمية";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 15F;
            this.Column5.HeaderText = "السعر شامل الضريبة";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 15F;
            this.Column6.HeaderText = "الخصم";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 15F;
            this.Column7.HeaderText = "الاجمالى";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(83, 90);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(182, 29);
            this.txtBarcode.TabIndex = 369;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(17, 94);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 368;
            this.label12.Text = "باركود المنتج:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(271, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 376;
            this.label5.Text = "F1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(734, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 378;
            this.label6.Text = "F2";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(647, 574);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(200, 30);
            this.txtTotal.TabIndex = 379;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(505, 583);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 380;
            this.label1.Text = "اجمالى الفاتورة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(993, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 381;
            this.label2.Text = "لتعديل الكمية او الوحدة او الخصم اضغط F11";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 383;
            this.label3.Text = "رقم الفاتورة:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderID.Location = new System.Drawing.Point(82, 25);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(182, 21);
            this.txtOrderID.TabIndex = 382;
            this.txtOrderID.Text = "1";
            this.txtOrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(993, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 17);
            this.label4.TabIndex = 384;
            this.label4.Text = "لدفع وحفظ وطباعه الفاتورة اضغط F12        ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxItems
            // 
            this.cbxItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(416, 90);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(260, 32);
            this.cbxItems.TabIndex = 422;
            this.cbxItems.SelectedIndexChanged += new System.EventHandler(this.cbxItems_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(351, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 423;
            this.label7.Text = "اختر منتج:";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(824, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 425;
            this.label8.Text = "Delete";
            // 
            // rbtnCustomerNakdy
            // 
            this.rbtnCustomerNakdy.AutoSize = true;
            this.rbtnCustomerNakdy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCustomerNakdy.Location = new System.Drawing.Point(317, 18);
            this.rbtnCustomerNakdy.Name = "rbtnCustomerNakdy";
            this.rbtnCustomerNakdy.Size = new System.Drawing.Size(77, 19);
            this.rbtnCustomerNakdy.TabIndex = 426;
            this.rbtnCustomerNakdy.Text = "عميل نقدى";
            this.rbtnCustomerNakdy.UseVisualStyleBackColor = true;
            this.rbtnCustomerNakdy.Visible = false;
            this.rbtnCustomerNakdy.CheckedChanged += new System.EventHandler(this.rbtnCustomerNakdy_CheckedChanged);
            // 
            // rbtnCustomerAagel
            // 
            this.rbtnCustomerAagel.AutoSize = true;
            this.rbtnCustomerAagel.Checked = true;
            this.rbtnCustomerAagel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCustomerAagel.Location = new System.Drawing.Point(416, 18);
            this.rbtnCustomerAagel.Name = "rbtnCustomerAagel";
            this.rbtnCustomerAagel.Size = new System.Drawing.Size(73, 19);
            this.rbtnCustomerAagel.TabIndex = 427;
            this.rbtnCustomerAagel.TabStop = true;
            this.rbtnCustomerAagel.Text = "عميل أجل";
            this.rbtnCustomerAagel.UseVisualStyleBackColor = true;
            this.rbtnCustomerAagel.CheckedChanged += new System.EventHandler(this.rbtnCustomerAagel_CheckedChanged);
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.Location = new System.Drawing.Point(505, 16);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(171, 32);
            this.cbxCustomer.TabIndex = 428;
            this.cbxCustomer.SelectionChangeCommitted += new System.EventHandler(this.cbxCustomer_SelectionChangeCommitted);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Appearance.Options.UseFont = true;
            this.btnBrowse.Appearance.Options.UseTextOptions = true;
            this.btnBrowse.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnBrowse.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnBrowse.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnBrowse.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBrowse.Location = new System.Drawing.Point(681, 15);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(51, 31);
            this.btnBrowse.TabIndex = 429;
            this.btnBrowse.Text = "....";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 574);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 430;
            this.label9.Text = "اسم المستخدم:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(85, 574);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(18, 17);
            this.lblUser.TabIndex = 431;
            this.lblUser.Text = "...";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCount.ForeColor = System.Drawing.Color.Black;
            this.lblCount.Location = new System.Drawing.Point(369, 574);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(18, 17);
            this.lblCount.TabIndex = 433;
            this.lblCount.Text = "...";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(290, 574);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 432;
            this.label11.Text = "عدد الاصناف";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnDelete.Location = new System.Drawing.Point(771, 90);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 31);
            this.btnDelete.TabIndex = 424;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(681, 90);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 31);
            this.btnAdd.TabIndex = 377;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DtbSaleDate
            // 
            this.DtbSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbSaleDate.Location = new System.Drawing.Point(886, 90);
            this.DtbSaleDate.Name = "DtbSaleDate";
            this.DtbSaleDate.Size = new System.Drawing.Size(118, 21);
            this.DtbSaleDate.TabIndex = 434;
            this.DtbSaleDate.Value = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            // 
            // DtbTime
            // 
            this.DtbTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtbTime.Location = new System.Drawing.Point(1219, 85);
            this.DtbTime.Name = "DtbTime";
            this.DtbTime.Size = new System.Drawing.Size(102, 21);
            this.DtbTime.TabIndex = 435;
            this.DtbTime.Value = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1162, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 35);
            this.pictureBox1.TabIndex = 436;
            this.pictureBox1.TabStop = false;
            // 
            // DtbReminder
            // 
            this.DtbReminder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbReminder.Location = new System.Drawing.Point(859, 17);
            this.DtbReminder.Name = "DtbReminder";
            this.DtbReminder.Size = new System.Drawing.Size(118, 21);
            this.DtbReminder.TabIndex = 437;
            this.DtbReminder.Value = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(756, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 15);
            this.label21.TabIndex = 438;
            this.label21.Text = "تاريخ الاستحقاق:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCustomerNakdy
            // 
            this.txtCustomerNakdy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerNakdy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerNakdy.Location = new System.Drawing.Point(388, 57);
            this.txtCustomerNakdy.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerNakdy.Name = "txtCustomerNakdy";
            this.txtCustomerNakdy.Size = new System.Drawing.Size(182, 29);
            this.txtCustomerNakdy.TabIndex = 439;
            this.txtCustomerNakdy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomerNakdy.Visible = false;
            this.txtCustomerNakdy.TextChanged += new System.EventHandler(this.txtCustomerNakdy_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(315, 61);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 440;
            this.label10.Text = "عميل نقدى:";
            this.label10.Visible = false;
            // 
            // btnFavItems
            // 
            this.btnFavItems.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavItems.Appearance.Options.UseFont = true;
            this.btnFavItems.Appearance.Options.UseTextOptions = true;
            this.btnFavItems.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnFavItems.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnFavItems.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFavItems.ImageOptions.Image")));
            this.btnFavItems.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnFavItems.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFavItems.Location = new System.Drawing.Point(1038, 80);
            this.btnFavItems.Margin = new System.Windows.Forms.Padding(2);
            this.btnFavItems.Name = "btnFavItems";
            this.btnFavItems.Size = new System.Drawing.Size(205, 36);
            this.btnFavItems.TabIndex = 441;
            this.btnFavItems.Text = "المنتجات المفضلة F3";
            this.btnFavItems.Visible = false;
            this.btnFavItems.Click += new System.EventHandler(this.btnFavItems_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(519, 619);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 23);
            this.label13.TabIndex = 442;
            this.label13.Text = "رصيد سابق:";
            // 
            // past
            // 
            this.past.AutoSize = true;
            this.past.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.past.ForeColor = System.Drawing.Color.Red;
            this.past.Location = new System.Drawing.Point(741, 619);
            this.past.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.past.Name = "past";
            this.past.Size = new System.Drawing.Size(20, 23);
            this.past.TabIndex = 443;
            this.past.Text = "0";
            this.past.Click += new System.EventHandler(this.past_Click);
            // 
            // Frm_SalesSuperMarket
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1244, 689);
            this.Controls.Add(this.past);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnFavItems);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCustomerNakdy);
            this.Controls.Add(this.DtbReminder);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtbTime);
            this.Controls.Add(this.DtbSaleDate);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cbxCustomer);
            this.Controls.Add(this.rbtnCustomerAagel);
            this.Controls.Add(this.rbtnCustomerNakdy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DgvStoreQty);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Office 2010 Black";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_SalesSuperMarket";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتورة مبيعات (باركود)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_SalesSuperMarket_FormClosing);
            this.Load += new System.EventHandler(this.Frm_SalesSuperMarket_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_SalesSuperMarket_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_SalesSuperMarket_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStoreQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtOrderID;
        public System.Windows.Forms.DataGridView DgvStoreQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxItems;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.RadioButton rbtnCustomerNakdy;
        private System.Windows.Forms.RadioButton rbtnCustomerAagel;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cbxCustomer;
        private System.Windows.Forms.DateTimePicker DtbSaleDate;
        private System.Windows.Forms.DateTimePicker DtbTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DtbReminder;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtCustomerNakdy;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btnFavItems;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label past;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
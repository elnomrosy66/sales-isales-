namespace Sales_Management
{
    partial class Frm_BuyRAW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuyRAW));
            this.label10 = new System.Windows.Forms.Label();
            this.DtbSaleDate = new System.Windows.Forms.DateTimePicker();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.cbxSuplier = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvStoreQty = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbxRawUnit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtnAagel = new System.Windows.Forms.RadioButton();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.DtbReminder = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.Nud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStoreQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(368, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 487;
            this.label10.Text = "اختر مورد:";
            // 
            // DtbSaleDate
            // 
            this.DtbSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbSaleDate.Location = new System.Drawing.Point(976, 70);
            this.DtbSaleDate.Name = "DtbSaleDate";
            this.DtbSaleDate.Size = new System.Drawing.Size(205, 24);
            this.DtbSaleDate.TabIndex = 485;
            this.DtbSaleDate.Value = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
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
            this.btnBrowse.Location = new System.Drawing.Point(714, 8);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(51, 31);
            this.btnBrowse.TabIndex = 484;
            this.btnBrowse.Text = "....";
            // 
            // cbxSuplier
            // 
            this.cbxSuplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSuplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSuplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxSuplier.FormattingEnabled = true;
            this.cbxSuplier.Location = new System.Drawing.Point(449, 9);
            this.cbxSuplier.Name = "cbxSuplier";
            this.cbxSuplier.Size = new System.Drawing.Size(260, 26);
            this.cbxSuplier.TabIndex = 483;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(892, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 482;
            this.label8.Text = "Delete";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(11, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 18);
            this.label7.TabIndex = 480;
            this.label7.Text = "اختر الخامة التى تريد شرائها:";
            // 
            // cbxItems
            // 
            this.cbxItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(218, 70);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(260, 26);
            this.cbxItems.TabIndex = 479;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(2, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 477;
            this.label3.Text = "رقم الفاتورة:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderID.Location = new System.Drawing.Point(105, 10);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(255, 24);
            this.txtOrderID.TabIndex = 476;
            this.txtOrderID.Text = "1";
            this.txtOrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(802, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 474;
            this.label6.Text = "F2";
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
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvStoreQty.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvStoreQty.Location = new System.Drawing.Point(12, 121);
            this.DgvStoreQty.Name = "DgvStoreQty";
            this.DgvStoreQty.ReadOnly = true;
            this.DgvStoreQty.RowHeadersVisible = false;
            this.DgvStoreQty.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvStoreQty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvStoreQty.Size = new System.Drawing.Size(1308, 446);
            this.DgvStoreQty.TabIndex = 469;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 25F;
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
            this.Column5.FillWeight = 42.14138F;
            this.Column5.HeaderText = "السعر شامل الضريبة";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 42.14138F;
            this.Column6.HeaderText = "الخصم";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 42.14138F;
            this.Column7.HeaderText = "الاجمالى";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(689, 600);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 489;
            this.label1.Text = "اجمالى المطلوب:";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(807, 586);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(190, 38);
            this.txtTotal.TabIndex = 488;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxRawUnit
            // 
            this.cbxRawUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxRawUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxRawUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxRawUnit.FormattingEnabled = true;
            this.cbxRawUnit.Location = new System.Drawing.Point(582, 70);
            this.cbxRawUnit.Name = "cbxRawUnit";
            this.cbxRawUnit.Size = new System.Drawing.Size(157, 26);
            this.cbxRawUnit.TabIndex = 490;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(483, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 491;
            this.label5.Text = "وحدة الخامة:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(11, 574);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(128, 57);
            this.simpleButton2.TabIndex = 493;
            this.simpleButton2.Text = "تعديل الكمية";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
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
            this.simpleButton1.Location = new System.Drawing.Point(143, 575);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(176, 57);
            this.simpleButton1.TabIndex = 492;
            this.simpleButton1.Text = "حفظ الفاتورة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(839, 70);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 31);
            this.btnDelete.TabIndex = 481;
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
            this.btnAdd.Location = new System.Drawing.Point(749, 70);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 31);
            this.btnAdd.TabIndex = 473;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1162, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 35);
            this.pictureBox1.TabIndex = 486;
            this.pictureBox1.TabStop = false;
            // 
            // rbtnAagel
            // 
            this.rbtnAagel.AutoSize = true;
            this.rbtnAagel.Location = new System.Drawing.Point(337, 607);
            this.rbtnAagel.Name = "rbtnAagel";
            this.rbtnAagel.Size = new System.Drawing.Size(107, 22);
            this.rbtnAagel.TabIndex = 497;
            this.rbtnAagel.Text = "دفع الفاتورة أجل";
            this.rbtnAagel.UseVisualStyleBackColor = true;
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Checked = true;
            this.rbtnCash.Location = new System.Drawing.Point(337, 575);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(109, 22);
            this.rbtnCash.TabIndex = 496;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "دفع الفاتورة كاش";
            this.rbtnCash.UseVisualStyleBackColor = true;
            // 
            // DtbReminder
            // 
            this.DtbReminder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbReminder.Location = new System.Drawing.Point(544, 608);
            this.DtbReminder.Name = "DtbReminder";
            this.DtbReminder.Size = new System.Drawing.Size(118, 24);
            this.DtbReminder.TabIndex = 494;
            this.DtbReminder.Value = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(447, 610);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 18);
            this.label21.TabIndex = 495;
            this.label21.Text = "تاريخ الاستحقاق:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Nud
            // 
            this.Nud.DecimalPlaces = 2;
            this.Nud.Location = new System.Drawing.Point(540, 574);
            this.Nud.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.Nud.Name = "Nud";
            this.Nud.Size = new System.Drawing.Size(122, 24);
            this.Nud.TabIndex = 498;
            this.Nud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(453, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 499;
            this.label2.Text = "المدفوع:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frm_BuyRAW
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 642);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nud);
            this.Controls.Add(this.rbtnAagel);
            this.Controls.Add(this.rbtnCash);
            this.Controls.Add(this.DtbReminder);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.DtbSaleDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxRawUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cbxSuplier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DgvStoreQty);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_BuyRAW";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتورة شراء خامات جديدة";
            this.Load += new System.EventHandler(this.Frm_BuyRAW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStoreQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DtbSaleDate;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        public System.Windows.Forms.ComboBox cbxSuplier;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxItems;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtOrderID;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView DgvStoreQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cbxRawUnit;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.RadioButton rbtnAagel;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.DateTimePicker DtbReminder;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown Nud;
        private System.Windows.Forms.Label label2;
    }
}
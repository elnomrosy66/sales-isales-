namespace Sales_Management
{
    partial class Frm_Add_Raw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Add_Raw));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NudCountInMainUnit = new System.Windows.Forms.NumericUpDown();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cbxUnitSmall = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxMainUnit = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.NudQty = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NudSalePrice = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NudBuyPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCountInMainUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBuyPrice)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NudCountInMainUnit);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.cbxUnitSmall);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.simpleButton7);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cbxMainUnit);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.NudQty);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.NudSalePrice);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.NudBuyPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.txtItemID);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(11, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(827, 221);
            this.groupBox1.TabIndex = 196;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الخامات";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(592, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 28);
            this.label1.TabIndex = 380;
            this.label1.Text = "عدد الوحدة الصغرى داخل الكبيرى:";
            // 
            // NudCountInMainUnit
            // 
            this.NudCountInMainUnit.DecimalPlaces = 2;
            this.NudCountInMainUnit.Location = new System.Drawing.Point(415, 171);
            this.NudCountInMainUnit.Margin = new System.Windows.Forms.Padding(2);
            this.NudCountInMainUnit.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.NudCountInMainUnit.Name = "NudCountInMainUnit";
            this.NudCountInMainUnit.Size = new System.Drawing.Size(173, 36);
            this.NudCountInMainUnit.TabIndex = 379;
            this.NudCountInMainUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudCountInMainUnit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton1.Location = new System.Drawing.Point(415, 127);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(49, 32);
            this.simpleButton1.TabIndex = 378;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cbxUnitSmall
            // 
            this.cbxUnitSmall.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxUnitSmall.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxUnitSmall.FormattingEnabled = true;
            this.cbxUnitSmall.Location = new System.Drawing.Point(469, 125);
            this.cbxUnitSmall.Margin = new System.Windows.Forms.Padding(2);
            this.cbxUnitSmall.Name = "cbxUnitSmall";
            this.cbxUnitSmall.Size = new System.Drawing.Size(222, 36);
            this.cbxUnitSmall.TabIndex = 376;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(693, 128);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(115, 28);
            this.label27.TabIndex = 377;
            this.label27.Text = "الوحدة الصغرى:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(687, 132);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(0, 28);
            this.label28.TabIndex = 375;
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Appearance.Options.UseTextOptions = true;
            this.simpleButton7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton7.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton7.Image")));
            this.simpleButton7.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton7.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton7.Location = new System.Drawing.Point(415, 74);
            this.simpleButton7.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(49, 32);
            this.simpleButton7.TabIndex = 374;
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(693, 78);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 28);
            this.label17.TabIndex = 365;
            this.label17.Text = "الوحدة الكبرى:";
            // 
            // cbxMainUnit
            // 
            this.cbxMainUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMainUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMainUnit.FormattingEnabled = true;
            this.cbxMainUnit.Location = new System.Drawing.Point(469, 74);
            this.cbxMainUnit.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMainUnit.Name = "cbxMainUnit";
            this.cbxMainUnit.Size = new System.Drawing.Size(222, 36);
            this.cbxMainUnit.TabIndex = 364;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(687, 82);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 28);
            this.label18.TabIndex = 362;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(271, 173);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 28);
            this.label13.TabIndex = 213;
            this.label13.Text = "الكمية الحالية:";
            // 
            // NudQty
            // 
            this.NudQty.DecimalPlaces = 2;
            this.NudQty.Location = new System.Drawing.Point(15, 171);
            this.NudQty.Margin = new System.Windows.Forms.Padding(2);
            this.NudQty.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.NudQty.Name = "NudQty";
            this.NudQty.Size = new System.Drawing.Size(255, 36);
            this.NudQty.TabIndex = 212;
            this.NudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(692, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 210;
            this.label2.Text = "رقم الخامة:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(274, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 28);
            this.label6.TabIndex = 203;
            this.label6.Text = "سعر البيع :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(229, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 28);
            this.label7.TabIndex = 202;
            // 
            // NudSalePrice
            // 
            this.NudSalePrice.DecimalPlaces = 2;
            this.NudSalePrice.Location = new System.Drawing.Point(15, 122);
            this.NudSalePrice.Margin = new System.Windows.Forms.Padding(2);
            this.NudSalePrice.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.NudSalePrice.Name = "NudSalePrice";
            this.NudSalePrice.Size = new System.Drawing.Size(256, 36);
            this.NudSalePrice.TabIndex = 201;
            this.NudSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudSalePrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(274, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 28);
            this.label10.TabIndex = 200;
            this.label10.Text = "سعر الشراء:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(229, 22);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 28);
            this.label11.TabIndex = 199;
            // 
            // NudBuyPrice
            // 
            this.NudBuyPrice.DecimalPlaces = 2;
            this.NudBuyPrice.Location = new System.Drawing.Point(15, 73);
            this.NudBuyPrice.Margin = new System.Windows.Forms.Padding(2);
            this.NudBuyPrice.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.NudBuyPrice.Name = "NudBuyPrice";
            this.NudBuyPrice.Size = new System.Drawing.Size(256, 36);
            this.NudBuyPrice.TabIndex = 198;
            this.NudBuyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudBuyPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(272, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 166;
            this.label3.Text = "اسم الخامة:";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(15, 29);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(256, 36);
            this.txtItemName.TabIndex = 165;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtItemID
            // 
            this.txtItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemID.Location = new System.Drawing.Point(415, 29);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(276, 36);
            this.txtItemID.TabIndex = 163;
            this.txtItemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxItems);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.btnDeleteAll);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(147, 316);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(579, 113);
            this.groupBox3.TabIndex = 250;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات المتاحة";
            // 
            // cbxItems
            // 
            this.cbxItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(164, 24);
            this.cbxItems.Margin = new System.Windows.Forms.Padding(2);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(252, 36);
            this.cbxItems.TabIndex = 358;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Blue;
            this.btnSearch.Location = new System.Drawing.Point(7, 24);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 34);
            this.btnSearch.TabIndex = 357;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.Appearance.Options.UseFont = true;
            this.btnDeleteAll.Appearance.Options.UseTextOptions = true;
            this.btnDeleteAll.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnDeleteAll.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Image")));
            this.btnDeleteAll.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnDeleteAll.Location = new System.Drawing.Point(7, 68);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(115, 37);
            this.btnDeleteAll.TabIndex = 353;
            this.btnDeleteAll.Text = "حذف الكل";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseTextOptions = true;
            this.btnDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnDelete.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnDelete.Location = new System.Drawing.Point(134, 68);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 37);
            this.btnDelete.TabIndex = 352;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Appearance.Options.UseTextOptions = true;
            this.btnUpdate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnUpdate.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnUpdate.Location = new System.Drawing.Point(247, 68);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 37);
            this.btnUpdate.TabIndex = 351;
            this.btnUpdate.Text = "حفظ";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Appearance.Options.UseTextOptions = true;
            this.btnClear.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnClear.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnClear.Location = new System.Drawing.Point(360, 68);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 37);
            this.btnClear.TabIndex = 350;
            this.btnClear.Text = "جديد";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(473, 68);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 37);
            this.btnAdd.TabIndex = 349;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnFirst);
            this.groupBox2.Controls.Add(this.btnPrev);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.btnLast);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(149)))));
            this.groupBox2.Location = new System.Drawing.Point(250, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 85);
            this.groupBox2.TabIndex = 255;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اسهم التنقل";
            // 
            // btnFirst
            // 
            this.btnFirst.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Appearance.Options.UseFont = true;
            this.btnFirst.Appearance.Options.UseTextOptions = true;
            this.btnFirst.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnFirst.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFirst.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnFirst.Location = new System.Drawing.Point(7, 30);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(74, 40);
            this.btnFirst.TabIndex = 253;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Appearance.Options.UseFont = true;
            this.btnPrev.Appearance.Options.UseTextOptions = true;
            this.btnPrev.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnPrev.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrev.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnPrev.Location = new System.Drawing.Point(88, 30);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(74, 40);
            this.btnPrev.TabIndex = 252;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Appearance.Options.UseTextOptions = true;
            this.btnNext.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnNext.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNext.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnNext.Location = new System.Drawing.Point(167, 30);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 40);
            this.btnNext.TabIndex = 251;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Appearance.Options.UseFont = true;
            this.btnLast.Appearance.Options.UseTextOptions = true;
            this.btnLast.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnLast.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLast.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnLast.Location = new System.Drawing.Point(247, 30);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(74, 40);
            this.btnLast.TabIndex = 250;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // Frm_Add_Raw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "Frm_Add_Raw";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة خامة جديدة";
            this.Load += new System.EventHandler(this.Frm_Add_Raw_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCountInMainUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSalePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBuyPrice)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cbxUnitSmall;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.ComboBox cbxMainUnit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown NudQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NudSalePrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NudBuyPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemName;
        public System.Windows.Forms.TextBox txtItemID;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NudCountInMainUnit;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ComboBox cbxItems;
        private System.Windows.Forms.Button btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAll;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnLast;

    }
}
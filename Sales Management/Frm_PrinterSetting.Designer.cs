namespace Sales_Management
{
    partial class Frm_PrinterSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PrinterSetting));
            this.cbxPrinters = new System.Windows.Forms.ComboBox();
            this.btnSave1 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnValue = new System.Windows.Forms.RadioButton();
            this.rbtnPersent = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDeleteDoctorImage = new System.Windows.Forms.Button();
            this.btnAddDoctorImage = new System.Windows.Forms.Button();
            this.pictureBoxDoctorPhoto = new System.Windows.Forms.PictureBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave2 = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn8cmBuy = new System.Windows.Forms.RadioButton();
            this.rbnA4Buy = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn8Cm = new System.Windows.Forms.RadioButton();
            this.rbtnA4 = new System.Windows.Forms.RadioButton();
            this.checkbuyPrint = new System.Windows.Forms.CheckBox();
            this.checsalesPrint = new System.Windows.Forms.CheckBox();
            this.checkBockSaleDiscount = new System.Windows.Forms.CheckBox();
            this.checkBoxTaxes = new System.Windows.Forms.CheckBox();
            this.NudOrderBuyNum = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.NudOrderSalesNum = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave3 = new DevExpress.XtraEditors.SimpleButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoctorPhoto)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudOrderBuyNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudOrderSalesNum)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxPrinters
            // 
            this.cbxPrinters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxPrinters.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPrinters.FormattingEnabled = true;
            this.cbxPrinters.Location = new System.Drawing.Point(255, 151);
            this.cbxPrinters.Name = "cbxPrinters";
            this.cbxPrinters.Size = new System.Drawing.Size(296, 36);
            this.cbxPrinters.TabIndex = 193;
            // 
            // btnSave1
            // 
            this.btnSave1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave1.Appearance.Options.UseFont = true;
            this.btnSave1.Appearance.Options.UseTextOptions = true;
            this.btnSave1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSave1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSave1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave1.ImageOptions.Image")));
            this.btnSave1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSave1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnSave1.Location = new System.Drawing.Point(255, 209);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(296, 38);
            this.btnSave1.TabIndex = 401;
            this.btnSave1.Text = "حفظ";
            this.btnSave1.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(228, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 28);
            this.label2.TabIndex = 402;
            this.label2.Text = "اختر طابعه لكى تكون هى الطابعه الاساسية للبرنامج";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(373, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 28);
            this.label1.TabIndex = 434;
            this.label1.Text = "هل تريد ان يكون الخصم على المنتجات نسبه مؤيه ام قيمه ؟";
            // 
            // rbtnValue
            // 
            this.rbtnValue.AutoSize = true;
            this.rbtnValue.Checked = true;
            this.rbtnValue.Location = new System.Drawing.Point(572, 34);
            this.rbtnValue.Name = "rbtnValue";
            this.rbtnValue.Size = new System.Drawing.Size(125, 32);
            this.rbtnValue.TabIndex = 435;
            this.rbtnValue.TabStop = true;
            this.rbtnValue.Text = "قيمه من المال";
            this.rbtnValue.UseVisualStyleBackColor = true;
            // 
            // rbtnPersent
            // 
            this.rbtnPersent.AutoSize = true;
            this.rbtnPersent.Location = new System.Drawing.Point(449, 34);
            this.rbtnPersent.Name = "rbtnPersent";
            this.rbtnPersent.Size = new System.Drawing.Size(100, 32);
            this.rbtnPersent.TabIndex = 436;
            this.rbtnPersent.Text = "نسبه مؤية";
            this.rbtnPersent.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 378);
            this.tabControl1.TabIndex = 437;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cbxPrinters);
            this.tabPage2.Controls.Add(this.btnSave1);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(801, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "اعدادت الطابعات";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnDeleteDoctorImage);
            this.tabPage1.Controls.Add(this.btnAddDoctorImage);
            this.tabPage1.Controls.Add(this.pictureBoxDoctorPhoto);
            this.tabPage1.Controls.Add(this.txtDescription);
            this.tabPage1.Controls.Add(this.btnSave2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtPhone2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtPhone1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 337);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "اعدادات الفاتورة";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = true;
            this.txtName.AcceptsTab = true;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(423, 283);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 36);
            this.txtName.TabIndex = 448;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(712, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 28);
            this.label10.TabIndex = 447;
            this.label10.Text = "اسم المحل:";
            // 
            // btnDeleteDoctorImage
            // 
            this.btnDeleteDoctorImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDeleteDoctorImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDoctorImage.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDoctorImage.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDoctorImage.Location = new System.Drawing.Point(423, 190);
            this.btnDeleteDoctorImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteDoctorImage.Name = "btnDeleteDoctorImage";
            this.btnDeleteDoctorImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteDoctorImage.Size = new System.Drawing.Size(130, 33);
            this.btnDeleteDoctorImage.TabIndex = 446;
            this.btnDeleteDoctorImage.Text = "مسح الصورة";
            this.btnDeleteDoctorImage.UseVisualStyleBackColor = false;
            this.btnDeleteDoctorImage.Click += new System.EventHandler(this.btnDeleteDoctorImage_Click);
            // 
            // btnAddDoctorImage
            // 
            this.btnAddDoctorImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddDoctorImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDoctorImage.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDoctorImage.ForeColor = System.Drawing.Color.White;
            this.btnAddDoctorImage.Location = new System.Drawing.Point(581, 190);
            this.btnAddDoctorImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDoctorImage.Name = "btnAddDoctorImage";
            this.btnAddDoctorImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddDoctorImage.Size = new System.Drawing.Size(128, 33);
            this.btnAddDoctorImage.TabIndex = 445;
            this.btnAddDoctorImage.Text = "اختيار صورة";
            this.btnAddDoctorImage.UseVisualStyleBackColor = false;
            this.btnAddDoctorImage.Click += new System.EventHandler(this.btnAddDoctorImage_Click);
            // 
            // pictureBoxDoctorPhoto
            // 
            this.pictureBoxDoctorPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDoctorPhoto.Location = new System.Drawing.Point(425, 49);
            this.pictureBoxDoctorPhoto.Name = "pictureBoxDoctorPhoto";
            this.pictureBoxDoctorPhoto.Size = new System.Drawing.Size(282, 134);
            this.pictureBoxDoctorPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDoctorPhoto.TabIndex = 444;
            this.pictureBoxDoctorPhoto.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsTab = true;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(7, 49);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(241, 36);
            this.txtDescription.TabIndex = 439;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave2
            // 
            this.btnSave2.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave2.Appearance.Options.UseFont = true;
            this.btnSave2.Appearance.Options.UseTextOptions = true;
            this.btnSave2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSave2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSave2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave2.ImageOptions.Image")));
            this.btnSave2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSave2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnSave2.Location = new System.Drawing.Point(7, 283);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(241, 38);
            this.btnSave2.TabIndex = 443;
            this.btnSave2.Text = "حفظ";
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(254, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 28);
            this.label7.TabIndex = 442;
            this.label7.Text = "رقم تليفون 2:";
            // 
            // txtPhone2
            // 
            this.txtPhone2.AcceptsTab = true;
            this.txtPhone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone2.Location = new System.Drawing.Point(7, 228);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(241, 36);
            this.txtPhone2.TabIndex = 441;
            this.txtPhone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(254, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 28);
            this.label6.TabIndex = 440;
            this.label6.Text = "جملة فى اسفل الفاتورة:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(254, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 438;
            this.label4.Text = "رقم تليفون 1:";
            // 
            // txtPhone1
            // 
            this.txtPhone1.AcceptsTab = true;
            this.txtPhone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone1.Location = new System.Drawing.Point(7, 133);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(241, 36);
            this.txtPhone1.TabIndex = 437;
            this.txtPhone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(709, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 436;
            this.label3.Text = "لوجو المحل:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(709, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 28);
            this.label5.TabIndex = 435;
            this.label5.Text = "عنوان المحل:";
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = true;
            this.txtAddress.AcceptsTab = true;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(423, 228);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(286, 36);
            this.txtAddress.TabIndex = 434;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.checkbuyPrint);
            this.tabPage3.Controls.Add(this.checsalesPrint);
            this.tabPage3.Controls.Add(this.checkBockSaleDiscount);
            this.tabPage3.Controls.Add(this.checkBoxTaxes);
            this.tabPage3.Controls.Add(this.NudOrderBuyNum);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.NudOrderSalesNum);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnSave3);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.rbtnPersent);
            this.tabPage3.Controls.Add(this.rbtnValue);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(801, 337);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "اعدادات عامة";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn8cmBuy);
            this.groupBox2.Controls.Add(this.rbnA4Buy);
            this.groupBox2.Location = new System.Drawing.Point(65, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 76);
            this.groupBox2.TabIndex = 450;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "طباعة فاتورة المشتريات";
            // 
            // rbtn8cmBuy
            // 
            this.rbtn8cmBuy.AutoSize = true;
            this.rbtn8cmBuy.Location = new System.Drawing.Point(9, 35);
            this.rbtn8cmBuy.Name = "rbtn8cmBuy";
            this.rbtn8cmBuy.Size = new System.Drawing.Size(181, 32);
            this.rbtn8cmBuy.TabIndex = 448;
            this.rbtn8cmBuy.Text = "طابعة حرارى (8 سنتى)";
            this.rbtn8cmBuy.UseVisualStyleBackColor = true;
            // 
            // rbnA4Buy
            // 
            this.rbnA4Buy.AutoSize = true;
            this.rbnA4Buy.Checked = true;
            this.rbnA4Buy.Location = new System.Drawing.Point(196, 35);
            this.rbnA4Buy.Name = "rbnA4Buy";
            this.rbnA4Buy.Size = new System.Drawing.Size(98, 32);
            this.rbnA4Buy.TabIndex = 447;
            this.rbnA4Buy.TabStop = true;
            this.rbnA4Buy.Text = "طابعة A4";
            this.rbnA4Buy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn8Cm);
            this.groupBox1.Controls.Add(this.rbtnA4);
            this.groupBox1.Location = new System.Drawing.Point(65, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 76);
            this.groupBox1.TabIndex = 449;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "طباعة فاتورة المبيعات";
            // 
            // rbtn8Cm
            // 
            this.rbtn8Cm.AutoSize = true;
            this.rbtn8Cm.Location = new System.Drawing.Point(9, 35);
            this.rbtn8Cm.Name = "rbtn8Cm";
            this.rbtn8Cm.Size = new System.Drawing.Size(181, 32);
            this.rbtn8Cm.TabIndex = 448;
            this.rbtn8Cm.Text = "طابعة حرارى (8 سنتى)";
            this.rbtn8Cm.UseVisualStyleBackColor = true;
            // 
            // rbtnA4
            // 
            this.rbtnA4.AutoSize = true;
            this.rbtnA4.Checked = true;
            this.rbtnA4.Location = new System.Drawing.Point(196, 35);
            this.rbtnA4.Name = "rbtnA4";
            this.rbtnA4.Size = new System.Drawing.Size(98, 32);
            this.rbtnA4.TabIndex = 447;
            this.rbtnA4.TabStop = true;
            this.rbtnA4.Text = "طابعة A4";
            this.rbtnA4.UseVisualStyleBackColor = true;
            // 
            // checkbuyPrint
            // 
            this.checkbuyPrint.AutoSize = true;
            this.checkbuyPrint.Checked = true;
            this.checkbuyPrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbuyPrint.Location = new System.Drawing.Point(500, 245);
            this.checkbuyPrint.Name = "checkbuyPrint";
            this.checkbuyPrint.Size = new System.Drawing.Size(274, 32);
            this.checkbuyPrint.TabIndex = 446;
            this.checkbuyPrint.Text = "تفعيل طباعة فواتير شاشة المشتريات";
            this.checkbuyPrint.UseVisualStyleBackColor = true;
            // 
            // checsalesPrint
            // 
            this.checsalesPrint.AutoSize = true;
            this.checsalesPrint.Checked = true;
            this.checsalesPrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checsalesPrint.Location = new System.Drawing.Point(511, 221);
            this.checsalesPrint.Name = "checsalesPrint";
            this.checsalesPrint.Size = new System.Drawing.Size(263, 32);
            this.checsalesPrint.TabIndex = 445;
            this.checsalesPrint.Text = "تفعيل طباعة فواتير شاشة المبيعات";
            this.checsalesPrint.UseVisualStyleBackColor = true;
            // 
            // checkBockSaleDiscount
            // 
            this.checkBockSaleDiscount.AutoSize = true;
            this.checkBockSaleDiscount.Checked = true;
            this.checkBockSaleDiscount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBockSaleDiscount.Location = new System.Drawing.Point(417, 196);
            this.checkBockSaleDiscount.Name = "checkBockSaleDiscount";
            this.checkBockSaleDiscount.Size = new System.Drawing.Size(357, 32);
            this.checkBockSaleDiscount.TabIndex = 444;
            this.checkBockSaleDiscount.Text = "تفعيل امكانيه الخصم على فواتير المبيعات للكاشير";
            this.checkBockSaleDiscount.UseVisualStyleBackColor = true;
            // 
            // checkBoxTaxes
            // 
            this.checkBoxTaxes.AutoSize = true;
            this.checkBoxTaxes.Checked = true;
            this.checkBoxTaxes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTaxes.Location = new System.Drawing.Point(555, 168);
            this.checkBoxTaxes.Name = "checkBoxTaxes";
            this.checkBoxTaxes.Size = new System.Drawing.Size(219, 32);
            this.checkBoxTaxes.TabIndex = 443;
            this.checkBoxTaxes.Text = "تفعيل ضريبة القيمة المضافة";
            this.checkBoxTaxes.UseVisualStyleBackColor = true;
            // 
            // NudOrderBuyNum
            // 
            this.NudOrderBuyNum.Location = new System.Drawing.Point(401, 135);
            this.NudOrderBuyNum.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.NudOrderBuyNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudOrderBuyNum.Name = "NudOrderBuyNum";
            this.NudOrderBuyNum.Size = new System.Drawing.Size(128, 36);
            this.NudOrderBuyNum.TabIndex = 441;
            this.NudOrderBuyNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudOrderBuyNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(535, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 28);
            this.label9.TabIndex = 440;
            this.label9.Text = "عدد طباعة نسخة فواتير المشتريات:";
            // 
            // NudOrderSalesNum
            // 
            this.NudOrderSalesNum.Location = new System.Drawing.Point(401, 78);
            this.NudOrderSalesNum.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.NudOrderSalesNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudOrderSalesNum.Name = "NudOrderSalesNum";
            this.NudOrderSalesNum.Size = new System.Drawing.Size(128, 36);
            this.NudOrderSalesNum.TabIndex = 439;
            this.NudOrderSalesNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudOrderSalesNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(546, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 28);
            this.label8.TabIndex = 438;
            this.label8.Text = "عدد طباعة نسخة فواتير المبيعات:";
            // 
            // btnSave3
            // 
            this.btnSave3.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave3.Appearance.Options.UseFont = true;
            this.btnSave3.Appearance.Options.UseTextOptions = true;
            this.btnSave3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSave3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSave3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave3.ImageOptions.Image")));
            this.btnSave3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSave3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnSave3.Location = new System.Drawing.Point(248, 292);
            this.btnSave3.Name = "btnSave3";
            this.btnSave3.Size = new System.Drawing.Size(296, 38);
            this.btnSave3.TabIndex = 437;
            this.btnSave3.Text = "حفظ";
            this.btnSave3.Click += new System.EventHandler(this.btnSave3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.simpleButton1);
            this.tabPage4.Controls.Add(this.txtQuery);
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(801, 337);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "RunQuery";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(171, 57);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(460, 149);
            this.txtQuery.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.simpleButton1.Location = new System.Drawing.Point(171, 212);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(460, 38);
            this.simpleButton1.TabIndex = 438;
            this.simpleButton1.Text = "RUN";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Frm_PrinterSetting
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(813, 383);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_PrinterSetting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادت البرنامج";
            this.Load += new System.EventHandler(this.Frm_PrinterSetting_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoctorPhoto)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudOrderBuyNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudOrderSalesNum)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPrinters;
        private DevExpress.XtraEditors.SimpleButton btnSave1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnValue;
        private System.Windows.Forms.RadioButton rbtnPersent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private DevExpress.XtraEditors.SimpleButton btnSave2;
        private DevExpress.XtraEditors.SimpleButton btnSave3;
        public System.Windows.Forms.Button btnDeleteDoctorImage;
        public System.Windows.Forms.Button btnAddDoctorImage;
        private System.Windows.Forms.PictureBox pictureBoxDoctorPhoto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NudOrderBuyNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NudOrderSalesNum;
        private System.Windows.Forms.CheckBox checkBockSaleDiscount;
        private System.Windows.Forms.CheckBox checkBoxTaxes;
        private System.Windows.Forms.CheckBox checkbuyPrint;
        private System.Windows.Forms.CheckBox checsalesPrint;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn8Cm;
        private System.Windows.Forms.RadioButton rbtnA4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn8cmBuy;
        private System.Windows.Forms.RadioButton rbnA4Buy;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtQuery;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
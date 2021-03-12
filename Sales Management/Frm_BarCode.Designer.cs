namespace Sales_Management
{
    partial class Frm_BarCode
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
            this.components = new System.ComponentModel.Container();
            this.txtEncoded = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkGenerateLabel = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbLabelLocation = new System.Windows.Forms.ComboBox();
            this.lblLabelLocation = new System.Windows.Forms.Label();
            this.cbEncodeType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbRotateFlip = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.tslblLibraryVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblCredits = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbBarcodeAlign = new System.Windows.Forms.ComboBox();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEncoded
            // 
            this.txtEncoded.Location = new System.Drawing.Point(18, 240);
            this.txtEncoded.Multiline = true;
            this.txtEncoded.Name = "txtEncoded";
            this.txtEncoded.ReadOnly = true;
            this.txtEncoded.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncoded.Size = new System.Drawing.Size(238, 36);
            this.txtEncoded.TabIndex = 84;
            this.txtEncoded.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 100;
            this.button1.Text = "طباعة";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "رقم الباركود:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtWidth);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtHeight);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(147, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(110, 49);
            this.groupBox4.TabIndex = 99;
            this.groupBox4.TabStop = false;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(16, 25);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(35, 20);
            this.txtWidth.TabIndex = 43;
            this.txtWidth.Text = "380";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "العرض";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "الارتفاع";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(59, 25);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(35, 20);
            this.txtHeight.TabIndex = 44;
            this.txtHeight.Text = "250";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "x";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(18, 28);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(235, 20);
            this.txtData.TabIndex = 80;
            this.txtData.Text = "038000356216";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.chkGenerateLabel);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cbLabelLocation);
            this.groupBox3.Controls.Add(this.lblLabelLocation);
            this.groupBox3.Location = new System.Drawing.Point(147, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 120);
            this.groupBox3.TabIndex = 98;
            this.groupBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 54;
            // 
            // chkGenerateLabel
            // 
            this.chkGenerateLabel.AutoSize = true;
            this.chkGenerateLabel.Location = new System.Drawing.Point(25, 11);
            this.chkGenerateLabel.Name = "chkGenerateLabel";
            this.chkGenerateLabel.Size = new System.Drawing.Size(71, 17);
            this.chkGenerateLabel.TabIndex = 40;
            this.chkGenerateLabel.Text = "اضافة نص";
            this.chkGenerateLabel.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "موضوع النص";
            // 
            // cbLabelLocation
            // 
            this.cbLabelLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLabelLocation.FormattingEnabled = true;
            this.cbLabelLocation.Items.AddRange(new object[] {
            "BottomCenter",
            "BottomLeft",
            "BottomRight",
            "TopCenter",
            "TopLeft",
            "TopRight"});
            this.cbLabelLocation.Location = new System.Drawing.Point(6, 94);
            this.cbLabelLocation.Name = "cbLabelLocation";
            this.cbLabelLocation.Size = new System.Drawing.Size(90, 21);
            this.cbLabelLocation.TabIndex = 0;
            // 
            // lblLabelLocation
            // 
            this.lblLabelLocation.AutoSize = true;
            this.lblLabelLocation.Location = new System.Drawing.Point(25, 78);
            this.lblLabelLocation.Name = "lblLabelLocation";
            this.lblLabelLocation.Size = new System.Drawing.Size(55, 13);
            this.lblLabelLocation.TabIndex = 48;
            this.lblLabelLocation.Text = "مكان النص";
            // 
            // cbEncodeType
            // 
            this.cbEncodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncodeType.FormattingEnabled = true;
            this.cbEncodeType.ItemHeight = 13;
            this.cbEncodeType.Items.AddRange(new object[] {
            "UPC-A",
            "UPC-E",
            "UPC 2 Digit Ext.",
            "UPC 5 Digit Ext.",
            "EAN-13",
            "JAN-13",
            "EAN-8",
            "ITF-14",
            "Interleaved 2 of 5",
            "Standard 2 of 5",
            "Codabar",
            "PostNet",
            "Bookland/ISBN",
            "Code 11",
            "Code 39",
            "Code 39 Extended",
            "Code 39 Mod 43",
            "Code 93",
            "Code 128",
            "Code 128-A",
            "Code 128-B",
            "Code 128-C",
            "LOGMARS",
            "MSI",
            "Telepen",
            "FIM",
            "Pharmacode"});
            this.cbEncodeType.Location = new System.Drawing.Point(18, 68);
            this.cbEncodeType.Name = "cbEncodeType";
            this.cbEncodeType.Size = new System.Drawing.Size(108, 21);
            this.cbEncodeType.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "الترميز";
            // 
            // barcode
            // 
            this.barcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.barcode.Location = new System.Drawing.Point(280, 0);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(369, 371);
            this.barcode.TabIndex = 106;
            this.barcode.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "الدوران";
            // 
            // cbRotateFlip
            // 
            this.cbRotateFlip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRotateFlip.FormattingEnabled = true;
            this.cbRotateFlip.Items.AddRange(new object[] {
            "Center",
            "Left",
            "Right"});
            this.cbRotateFlip.Location = new System.Drawing.Point(18, 110);
            this.cbRotateFlip.Name = "cbRotateFlip";
            this.cbRotateFlip.Size = new System.Drawing.Size(108, 21);
            this.cbRotateFlip.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "قيمه الباركود";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(92, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 46);
            this.btnSave.TabIndex = 83;
            this.btnSave.Text = "حفظ كصورة";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnForeColor
            // 
            this.btnForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForeColor.Location = new System.Drawing.Point(18, 196);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(58, 23);
            this.btnForeColor.TabIndex = 88;
            this.btnForeColor.UseVisualStyleBackColor = true;
            // 
            // tslblLibraryVersion
            // 
            this.tslblLibraryVersion.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tslblLibraryVersion.Name = "tslblLibraryVersion";
            this.tslblLibraryVersion.Size = new System.Drawing.Size(643, 17);
            this.tslblLibraryVersion.Spring = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblLibraryVersion,
            this.tslblCredits});
            this.statusStrip1.Location = new System.Drawing.Point(0, 385);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(658, 22);
            this.statusStrip1.TabIndex = 107;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblCredits
            // 
            this.tslblCredits.Name = "tslblCredits";
            this.tslblCredits.Size = new System.Drawing.Size(0, 17);
            this.tslblCredits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbBarcodeAlign
            // 
            this.cbBarcodeAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBarcodeAlign.FormattingEnabled = true;
            this.cbBarcodeAlign.Items.AddRange(new object[] {
            "Center",
            "Left",
            "Right"});
            this.cbBarcodeAlign.Location = new System.Drawing.Point(18, 152);
            this.cbBarcodeAlign.Name = "cbBarcodeAlign";
            this.cbBarcodeAlign.Size = new System.Drawing.Size(107, 21);
            this.cbBarcodeAlign.TabIndex = 94;
            // 
            // btnBackColor
            // 
            this.btnBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackColor.Location = new System.Drawing.Point(83, 196);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(58, 23);
            this.btnBackColor.TabIndex = 89;
            this.btnBackColor.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "الخلفية";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEncoded);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cbEncodeType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbRotateFlip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnForeColor);
            this.groupBox1.Controls.Add(this.cbBarcodeAlign);
            this.groupBox1.Controls.Add(this.btnBackColor);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnEncode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(5, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 338);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاعدادت";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 95;
            this.label8.Text = "محاذاه الباركود";
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(18, 287);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(69, 46);
            this.btnEncode.TabIndex = 82;
            this.btnEncode.Text = "توليد";
            this.btnEncode.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "الامامية";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 31);
            this.button2.TabIndex = 104;
            this.button2.Text = "توليد باركود عشوائى";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Frm_BarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 407);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_BarCode";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "طباعة الباركود";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEncoded;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkGenerateLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbLabelLocation;
        private System.Windows.Forms.Label lblLabelLocation;
        private System.Windows.Forms.ComboBox cbEncodeType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox barcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbRotateFlip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.ToolStripStatusLabel tslblLibraryVersion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblCredits;
        private System.Windows.Forms.ComboBox cbBarcodeAlign;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
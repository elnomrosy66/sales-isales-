namespace Sales_Management
{
    partial class Frm_Store_TransfireReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Store_TransfireReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.DgvSearchBuy = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtbStart = new System.Windows.Forms.DateTimePicker();
            this.DtbEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchٍSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxStoreFrom = new System.Windows.Forms.ComboBox();
            this.rbtnOneStoreForm = new System.Windows.Forms.RadioButton();
            this.rbtnAllStoreFrom = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxStoreTo = new System.Windows.Forms.ComboBox();
            this.rbtnOneStoreTo = new System.Windows.Forms.RadioButton();
            this.rbtnAllStoreTo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.btnDelete.Location = new System.Drawing.Point(14, 531);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(352, 43);
            this.btnDelete.TabIndex = 392;
            this.btnDelete.Text = "مسح البيانات فى الفترة المحددة";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(726, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 22);
            this.label3.TabIndex = 391;
            this.label3.Text = "اجمالى الكميات المحولة:";
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalQty.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalQty.Location = new System.Drawing.Point(870, 531);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.ReadOnly = true;
            this.txtTotalQty.Size = new System.Drawing.Size(204, 30);
            this.txtTotalQty.TabIndex = 390;
            this.txtTotalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSearchBuy.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSearchBuy.Location = new System.Drawing.Point(14, 140);
            this.DgvSearchBuy.Name = "DgvSearchBuy";
            this.DgvSearchBuy.ReadOnly = true;
            this.DgvSearchBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearchBuy.Size = new System.Drawing.Size(1060, 385);
            this.DgvSearchBuy.TabIndex = 389;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DtbStart);
            this.groupBox2.Controls.Add(this.DtbEnd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(730, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 56);
            this.groupBox2.TabIndex = 388;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الفترة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(309, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 22);
            this.label1.TabIndex = 365;
            this.label1.Text = "من:";
            // 
            // DtbStart
            // 
            this.DtbStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbStart.Location = new System.Drawing.Point(183, 19);
            this.DtbStart.Name = "DtbStart";
            this.DtbStart.Size = new System.Drawing.Size(120, 30);
            this.DtbStart.TabIndex = 363;
            this.DtbStart.Value = new System.DateTime(2014, 7, 20, 0, 0, 0, 0);
            // 
            // DtbEnd
            // 
            this.DtbEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbEnd.Location = new System.Drawing.Point(11, 19);
            this.DtbEnd.Name = "DtbEnd";
            this.DtbEnd.Size = new System.Drawing.Size(132, 30);
            this.DtbEnd.TabIndex = 364;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(144, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 22);
            this.label2.TabIndex = 366;
            this.label2.Text = "الى:";
            // 
            // btnSearchٍSupplier
            // 
            this.btnSearchٍSupplier.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchٍSupplier.Appearance.Options.UseFont = true;
            this.btnSearchٍSupplier.Appearance.Options.UseTextOptions = true;
            this.btnSearchٍSupplier.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSearchٍSupplier.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSearchٍSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchٍSupplier.Image")));
            this.btnSearchٍSupplier.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSearchٍSupplier.Location = new System.Drawing.Point(383, 36);
            this.btnSearchٍSupplier.Name = "btnSearchٍSupplier";
            this.btnSearchٍSupplier.Size = new System.Drawing.Size(310, 38);
            this.btnSearchٍSupplier.TabIndex = 368;
            this.btnSearchٍSupplier.Text = "بحث";
            this.btnSearchٍSupplier.Click += new System.EventHandler(this.btnSearchٍSupplier_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.labelControl1.Location = new System.Drawing.Point(348, -3);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(369, 40);
            this.labelControl1.TabIndex = 387;
            this.labelControl1.Text = "اجمالى المنتجات المحولة بين المخازن";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxStoreFrom);
            this.groupBox1.Controls.Add(this.rbtnOneStoreForm);
            this.groupBox1.Controls.Add(this.rbtnAllStoreFrom);
            this.groupBox1.Location = new System.Drawing.Point(14, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 56);
            this.groupBox1.TabIndex = 389;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المخازن المحول منها";
            // 
            // cbxStoreFrom
            // 
            this.cbxStoreFrom.FormattingEnabled = true;
            this.cbxStoreFrom.Location = new System.Drawing.Point(6, 19);
            this.cbxStoreFrom.Name = "cbxStoreFrom";
            this.cbxStoreFrom.Size = new System.Drawing.Size(155, 30);
            this.cbxStoreFrom.TabIndex = 372;
            // 
            // rbtnOneStoreForm
            // 
            this.rbtnOneStoreForm.AutoSize = true;
            this.rbtnOneStoreForm.ForeColor = System.Drawing.Color.Blue;
            this.rbtnOneStoreForm.Location = new System.Drawing.Point(167, 23);
            this.rbtnOneStoreForm.Name = "rbtnOneStoreForm";
            this.rbtnOneStoreForm.Size = new System.Drawing.Size(85, 26);
            this.rbtnOneStoreForm.TabIndex = 371;
            this.rbtnOneStoreForm.Text = "مخزن محدد";
            this.rbtnOneStoreForm.UseVisualStyleBackColor = true;
            // 
            // rbtnAllStoreFrom
            // 
            this.rbtnAllStoreFrom.AutoSize = true;
            this.rbtnAllStoreFrom.Checked = true;
            this.rbtnAllStoreFrom.ForeColor = System.Drawing.Color.Blue;
            this.rbtnAllStoreFrom.Location = new System.Drawing.Point(257, 23);
            this.rbtnAllStoreFrom.Name = "rbtnAllStoreFrom";
            this.rbtnAllStoreFrom.Size = new System.Drawing.Size(84, 26);
            this.rbtnAllStoreFrom.TabIndex = 370;
            this.rbtnAllStoreFrom.TabStop = true;
            this.rbtnAllStoreFrom.Text = "كل المخازن";
            this.rbtnAllStoreFrom.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxStoreTo);
            this.groupBox3.Controls.Add(this.rbtnOneStoreTo);
            this.groupBox3.Controls.Add(this.rbtnAllStoreTo);
            this.groupBox3.Location = new System.Drawing.Point(372, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 56);
            this.groupBox3.TabIndex = 390;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "المخازن المحول لها";
            // 
            // cbxStoreTo
            // 
            this.cbxStoreTo.FormattingEnabled = true;
            this.cbxStoreTo.Location = new System.Drawing.Point(6, 19);
            this.cbxStoreTo.Name = "cbxStoreTo";
            this.cbxStoreTo.Size = new System.Drawing.Size(155, 30);
            this.cbxStoreTo.TabIndex = 372;
            // 
            // rbtnOneStoreTo
            // 
            this.rbtnOneStoreTo.AutoSize = true;
            this.rbtnOneStoreTo.ForeColor = System.Drawing.Color.Blue;
            this.rbtnOneStoreTo.Location = new System.Drawing.Point(167, 23);
            this.rbtnOneStoreTo.Name = "rbtnOneStoreTo";
            this.rbtnOneStoreTo.Size = new System.Drawing.Size(85, 26);
            this.rbtnOneStoreTo.TabIndex = 371;
            this.rbtnOneStoreTo.Text = "مخزن محدد";
            this.rbtnOneStoreTo.UseVisualStyleBackColor = true;
            // 
            // rbtnAllStoreTo
            // 
            this.rbtnAllStoreTo.AutoSize = true;
            this.rbtnAllStoreTo.Checked = true;
            this.rbtnAllStoreTo.ForeColor = System.Drawing.Color.Blue;
            this.rbtnAllStoreTo.Location = new System.Drawing.Point(257, 23);
            this.rbtnAllStoreTo.Name = "rbtnAllStoreTo";
            this.rbtnAllStoreTo.Size = new System.Drawing.Size(84, 26);
            this.rbtnAllStoreTo.TabIndex = 370;
            this.rbtnAllStoreTo.TabStop = true;
            this.rbtnAllStoreTo.Text = "كل المخازن";
            this.rbtnAllStoreTo.UseVisualStyleBackColor = true;
            // 
            // Frm_Store_TransfireReport
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1084, 579);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearchٍSupplier);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalQty);
            this.Controls.Add(this.DgvSearchBuy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_Store_TransfireReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير تحويل المنتجات بين المخازن";
            this.Load += new System.EventHandler(this.Frm_Store_TransfireReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.DataGridView DgvSearchBuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtbStart;
        private System.Windows.Forms.DateTimePicker DtbEnd;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnSearchٍSupplier;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnOneStoreForm;
        private System.Windows.Forms.RadioButton rbtnAllStoreFrom;
        private System.Windows.Forms.ComboBox cbxStoreFrom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxStoreTo;
        private System.Windows.Forms.RadioButton rbtnOneStoreTo;
        private System.Windows.Forms.RadioButton rbtnAllStoreTo;
    }
}
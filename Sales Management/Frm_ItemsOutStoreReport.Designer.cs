namespace Sales_Management
{
    partial class Frm_ItemsOutStoreReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ItemsOutStoreReport));
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.DtbStart = new System.Windows.Forms.DateTimePicker();
            this.cbxStoreFrom = new System.Windows.Forms.ComboBox();
            this.DtbEnd = new System.Windows.Forms.DateTimePicker();
            this.rbtnOneStoreForm = new System.Windows.Forms.RadioButton();
            this.rbtnAllStoreFrom = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.DgvSearchBuy = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchٍSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(309, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 365;
            this.label1.Text = "من:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(331, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(329, 25);
            this.labelControl1.TabIndex = 394;
            this.labelControl1.Text = "اجمالى المنتجات التالفة المخزة من المخزن";
            // 
            // DtbStart
            // 
            this.DtbStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbStart.Location = new System.Drawing.Point(183, 19);
            this.DtbStart.Name = "DtbStart";
            this.DtbStart.Size = new System.Drawing.Size(120, 21);
            this.DtbStart.TabIndex = 363;
            this.DtbStart.Value = new System.DateTime(2014, 7, 20, 0, 0, 0, 0);
            // 
            // cbxStoreFrom
            // 
            this.cbxStoreFrom.FormattingEnabled = true;
            this.cbxStoreFrom.Location = new System.Drawing.Point(6, 19);
            this.cbxStoreFrom.Name = "cbxStoreFrom";
            this.cbxStoreFrom.Size = new System.Drawing.Size(155, 23);
            this.cbxStoreFrom.TabIndex = 372;
            // 
            // DtbEnd
            // 
            this.DtbEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbEnd.Location = new System.Drawing.Point(11, 19);
            this.DtbEnd.Name = "DtbEnd";
            this.DtbEnd.Size = new System.Drawing.Size(132, 21);
            this.DtbEnd.TabIndex = 364;
            // 
            // rbtnOneStoreForm
            // 
            this.rbtnOneStoreForm.AutoSize = true;
            this.rbtnOneStoreForm.ForeColor = System.Drawing.Color.Blue;
            this.rbtnOneStoreForm.Location = new System.Drawing.Point(167, 23);
            this.rbtnOneStoreForm.Name = "rbtnOneStoreForm";
            this.rbtnOneStoreForm.Size = new System.Drawing.Size(72, 19);
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
            this.rbtnAllStoreFrom.Size = new System.Drawing.Size(72, 19);
            this.rbtnAllStoreFrom.TabIndex = 370;
            this.rbtnAllStoreFrom.TabStop = true;
            this.rbtnAllStoreFrom.Text = "كل المخازن";
            this.rbtnAllStoreFrom.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxStoreFrom);
            this.groupBox1.Controls.Add(this.rbtnOneStoreForm);
            this.groupBox1.Controls.Add(this.rbtnAllStoreFrom);
            this.groupBox1.Location = new System.Drawing.Point(0, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 56);
            this.groupBox1.TabIndex = 397;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المخازن المخزج منها";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(144, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 366;
            this.label2.Text = "الى:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(650, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 400;
            this.label3.Text = "اجمالى الكميات المخرة:";
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalQty.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalQty.Location = new System.Drawing.Point(787, 540);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.ReadOnly = true;
            this.txtTotalQty.Size = new System.Drawing.Size(204, 21);
            this.txtTotalQty.TabIndex = 398;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSearchBuy.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSearchBuy.Location = new System.Drawing.Point(17, 149);
            this.DgvSearchBuy.Name = "DgvSearchBuy";
            this.DgvSearchBuy.ReadOnly = true;
            this.DgvSearchBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearchBuy.Size = new System.Drawing.Size(1060, 385);
            this.DgvSearchBuy.TabIndex = 396;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DtbStart);
            this.groupBox2.Controls.Add(this.DtbEnd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(646, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 56);
            this.groupBox2.TabIndex = 395;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الفترة";
            // 
            // btnSearchٍSupplier
            // 
            this.btnSearchٍSupplier.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchٍSupplier.Appearance.Options.UseFont = true;
            this.btnSearchٍSupplier.Appearance.Options.UseTextOptions = true;
            this.btnSearchٍSupplier.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSearchٍSupplier.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSearchٍSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchٍSupplier.ImageOptions.Image")));
            this.btnSearchٍSupplier.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSearchٍSupplier.Location = new System.Drawing.Point(323, 50);
            this.btnSearchٍSupplier.Name = "btnSearchٍSupplier";
            this.btnSearchٍSupplier.Size = new System.Drawing.Size(310, 38);
            this.btnSearchٍSupplier.TabIndex = 393;
            this.btnSearchٍSupplier.Text = "بحث";
            this.btnSearchٍSupplier.Click += new System.EventHandler(this.btnSearchٍSupplier_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(17, 540);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(352, 43);
            this.btnDelete.TabIndex = 401;
            this.btnDelete.Text = "مسح البيانات فى الفترة المحددة";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Frm_ItemsOutStoreReport
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1020, 589);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearchٍSupplier);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalQty);
            this.Controls.Add(this.DgvSearchBuy);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_ItemsOutStoreReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير المنتجات القالة المخزه من المخزن";
            this.Load += new System.EventHandler(this.Frm_ItemsOutStoreReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker DtbStart;
        private System.Windows.Forms.ComboBox cbxStoreFrom;
        private System.Windows.Forms.DateTimePicker DtbEnd;
        private System.Windows.Forms.RadioButton rbtnOneStoreForm;
        private System.Windows.Forms.RadioButton rbtnAllStoreFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnSearchٍSupplier;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.DataGridView DgvSearchBuy;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
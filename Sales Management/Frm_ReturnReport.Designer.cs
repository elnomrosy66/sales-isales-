namespace Sales_Management
{
    partial class Frm_ReturnReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReturnReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtbEnd = new System.Windows.Forms.DateTimePicker();
            this.DtbStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.rbtnSales = new System.Windows.Forms.RadioButton();
            this.rbtnBuys = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.DgvSearchBuy = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPhar = new System.Windows.Forms.TextBox();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalTax = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DtbEnd);
            this.groupBox1.Controls.Add(this.DtbStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(418, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حدد فترة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(116, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 400;
            this.label2.Text = "الى:";
            // 
            // DtbEnd
            // 
            this.DtbEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbEnd.Location = new System.Drawing.Point(4, 26);
            this.DtbEnd.Name = "DtbEnd";
            this.DtbEnd.Size = new System.Drawing.Size(113, 24);
            this.DtbEnd.TabIndex = 399;
            // 
            // DtbStart
            // 
            this.DtbStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbStart.Location = new System.Drawing.Point(156, 26);
            this.DtbStart.Name = "DtbStart";
            this.DtbStart.Size = new System.Drawing.Size(113, 24);
            this.DtbStart.TabIndex = 356;
            this.DtbStart.Value = new System.DateTime(2014, 7, 20, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(267, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 357;
            this.label1.Text = "من:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(298, 7);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(206, 25);
            this.labelControl2.TabIndex = 398;
            this.labelControl2.Text = "اجمالى المرتجعات فى فترة";
            // 
            // rbtnSales
            // 
            this.rbtnSales.AutoSize = true;
            this.rbtnSales.ForeColor = System.Drawing.Color.Blue;
            this.rbtnSales.Location = new System.Drawing.Point(147, 27);
            this.rbtnSales.Name = "rbtnSales";
            this.rbtnSales.Size = new System.Drawing.Size(111, 22);
            this.rbtnSales.TabIndex = 349;
            this.rbtnSales.Text = "مرتجعات مبيعات";
            this.rbtnSales.UseVisualStyleBackColor = true;
            // 
            // rbtnBuys
            // 
            this.rbtnBuys.AutoSize = true;
            this.rbtnBuys.ForeColor = System.Drawing.Color.Blue;
            this.rbtnBuys.Location = new System.Drawing.Point(3, 27);
            this.rbtnBuys.Name = "rbtnBuys";
            this.rbtnBuys.Size = new System.Drawing.Size(121, 22);
            this.rbtnBuys.TabIndex = 348;
            this.rbtnBuys.Text = "مرتجعات مشتريات";
            this.rbtnBuys.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnAll);
            this.groupBox2.Controls.Add(this.rbtnBuys);
            this.groupBox2.Controls.Add(this.rbtnSales);
            this.groupBox2.Location = new System.Drawing.Point(5, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 69);
            this.groupBox2.TabIndex = 355;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فلترة البحث";
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.ForeColor = System.Drawing.Color.Blue;
            this.rbtnAll.Location = new System.Drawing.Point(283, 27);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(97, 22);
            this.rbtnAll.TabIndex = 350;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "كل المرتجعات";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Location = new System.Drawing.Point(728, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 69);
            this.groupBox3.TabIndex = 399;
            this.groupBox3.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Appearance.Options.UseTextOptions = true;
            this.btnSearch.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSearch.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(5, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(174, 39);
            this.btnSearch.TabIndex = 375;
            this.btnSearch.Text = "بحث";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSearchBuy.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSearchBuy.Location = new System.Drawing.Point(5, 133);
            this.DgvSearchBuy.Name = "DgvSearchBuy";
            this.DgvSearchBuy.ReadOnly = true;
            this.DgvSearchBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearchBuy.Size = new System.Drawing.Size(906, 328);
            this.DgvSearchBuy.TabIndex = 400;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(553, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 402;
            this.label3.Text = "اجمالى مبلغ المرتجعات:";
            // 
            // txtTotalPhar
            // 
            this.txtTotalPhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPhar.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalPhar.Location = new System.Drawing.Point(720, 470);
            this.txtTotalPhar.Name = "txtTotalPhar";
            this.txtTotalPhar.ReadOnly = true;
            this.txtTotalPhar.Size = new System.Drawing.Size(191, 24);
            this.txtTotalPhar.TabIndex = 401;
            this.txtTotalPhar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(3)))));
            this.btnDelete.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(3)))));
            this.btnDelete.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(3)))));
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseBorderColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.Appearance.Options.UseTextOptions = true;
            this.btnDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnDelete.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnDelete.Location = new System.Drawing.Point(5, 467);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(209, 39);
            this.btnDelete.TabIndex = 403;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 42);
            this.pictureBox1.TabIndex = 356;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(233, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 405;
            this.label4.Text = "اجمالى الضرائب:";
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalTax.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalTax.Location = new System.Drawing.Point(356, 470);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.ReadOnly = true;
            this.txtTotalTax.Size = new System.Drawing.Size(191, 24);
            this.txtTotalTax.TabIndex = 404;
            this.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_ReturnReport
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
            this.ClientSize = new System.Drawing.Size(915, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalTax);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalPhar);
            this.Controls.Add(this.DgvSearchBuy);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_ReturnReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير المرتجعات";
            this.Load += new System.EventHandler(this.Frm_ReturnReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtbEnd;
        private System.Windows.Forms.DateTimePicker DtbStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtnSales;
        private System.Windows.Forms.RadioButton rbtnBuys;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.DataGridView DgvSearchBuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalPhar;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalTax;
    }
}
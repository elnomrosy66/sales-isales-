namespace Sales_Management
{
    partial class Frm_ItemReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ItemReport));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalSale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalBuy = new System.Windows.Forms.TextBox();
            this.cbxDesName = new System.Windows.Forms.ComboBox();
            this.rbtnOne = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.DgvBuyDetalis = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.textParcode = new System.Windows.Forms.TextBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRbh7 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxStorea = new System.Windows.Forms.ComboBox();
            this.rbtnOneStore = new System.Windows.Forms.RadioButton();
            this.rbtnAllStore = new System.Windows.Forms.RadioButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuyDetalis)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(673, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 353;
            this.label1.Text = "اجمالى مبلغ المنتجات(مبلغ البيع):";
            // 
            // txtTotalSale
            // 
            this.txtTotalSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalSale.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalSale.Location = new System.Drawing.Point(856, 518);
            this.txtTotalSale.Name = "txtTotalSale";
            this.txtTotalSale.ReadOnly = true;
            this.txtTotalSale.Size = new System.Drawing.Size(165, 24);
            this.txtTotalSale.TabIndex = 352;
            this.txtTotalSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(298, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 18);
            this.label5.TabIndex = 351;
            this.label5.Text = "اجمالى مبلغ المنتجات(مبلغ الشراء):";
            // 
            // txtTotalBuy
            // 
            this.txtTotalBuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalBuy.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalBuy.Location = new System.Drawing.Point(493, 518);
            this.txtTotalBuy.Name = "txtTotalBuy";
            this.txtTotalBuy.ReadOnly = true;
            this.txtTotalBuy.Size = new System.Drawing.Size(171, 24);
            this.txtTotalBuy.TabIndex = 350;
            this.txtTotalBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxDesName
            // 
            this.cbxDesName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxDesName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDesName.FormattingEnabled = true;
            this.cbxDesName.Location = new System.Drawing.Point(5, 25);
            this.cbxDesName.Name = "cbxDesName";
            this.cbxDesName.Size = new System.Drawing.Size(210, 26);
            this.cbxDesName.TabIndex = 349;
            this.cbxDesName.SelectedIndexChanged += new System.EventHandler(this.cbxDesName_SelectedIndexChanged);
            this.cbxDesName.RightToLeftChanged += new System.EventHandler(this.cbxDesName_RightToLeftChanged);
            // 
            // rbtnOne
            // 
            this.rbtnOne.AutoSize = true;
            this.rbtnOne.Location = new System.Drawing.Point(221, 26);
            this.rbtnOne.Name = "rbtnOne";
            this.rbtnOne.Size = new System.Drawing.Size(83, 22);
            this.rbtnOne.TabIndex = 348;
            this.rbtnOne.Text = "صنف محدد";
            this.rbtnOne.UseVisualStyleBackColor = true;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Location = new System.Drawing.Point(331, 26);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(89, 22);
            this.rbtnAll.TabIndex = 347;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "كل الاصناف";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // DgvBuyDetalis
            // 
            this.DgvBuyDetalis.AllowUserToAddRows = false;
            this.DgvBuyDetalis.AllowUserToDeleteRows = false;
            this.DgvBuyDetalis.AllowUserToResizeColumns = false;
            this.DgvBuyDetalis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBuyDetalis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvBuyDetalis.BackgroundColor = System.Drawing.Color.White;
            this.DgvBuyDetalis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBuyDetalis.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvBuyDetalis.Location = new System.Drawing.Point(8, 113);
            this.DgvBuyDetalis.Name = "DgvBuyDetalis";
            this.DgvBuyDetalis.ReadOnly = true;
            this.DgvBuyDetalis.RowHeadersVisible = false;
            this.DgvBuyDetalis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvBuyDetalis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBuyDetalis.Size = new System.Drawing.Size(1013, 396);
            this.DgvBuyDetalis.TabIndex = 346;
            this.DgvBuyDetalis.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvBuyDetalis_MouseClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(917, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 18);
            this.label17.TabIndex = 359;
            this.label17.Text = "ابحث بالباركود:";
            // 
            // textParcode
            // 
            this.textParcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textParcode.ForeColor = System.Drawing.Color.Blue;
            this.textParcode.Location = new System.Drawing.Point(886, 65);
            this.textParcode.Name = "textParcode";
            this.textParcode.Size = new System.Drawing.Size(134, 24);
            this.textParcode.TabIndex = 358;
            this.textParcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textParcode.TextChanged += new System.EventHandler(this.textParcode_TextChanged);
            this.textParcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textParcode_KeyPress);
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
            this.btnSearch.Location = new System.Drawing.Point(326, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(276, 39);
            this.btnSearch.TabIndex = 354;
            this.btnSearch.Text = "جرد جميع الاصناف فى المخزن";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(-4, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 361;
            this.label2.Text = "الارباح المتوقعه:";
            // 
            // txtRbh7
            // 
            this.txtRbh7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRbh7.ForeColor = System.Drawing.Color.Blue;
            this.txtRbh7.Location = new System.Drawing.Point(94, 519);
            this.txtRbh7.Name = "txtRbh7";
            this.txtRbh7.ReadOnly = true;
            this.txtRbh7.Size = new System.Drawing.Size(192, 24);
            this.txtRbh7.TabIndex = 360;
            this.txtRbh7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnAll);
            this.groupBox1.Controls.Add(this.rbtnOne);
            this.groupBox1.Controls.Add(this.cbxDesName);
            this.groupBox1.Location = new System.Drawing.Point(4, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 69);
            this.groupBox1.TabIndex = 362;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxStorea);
            this.groupBox2.Controls.Add(this.rbtnOneStore);
            this.groupBox2.Controls.Add(this.rbtnAllStore);
            this.groupBox2.Location = new System.Drawing.Point(453, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 69);
            this.groupBox2.TabIndex = 363;
            this.groupBox2.TabStop = false;
            // 
            // cbxStorea
            // 
            this.cbxStorea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStorea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStorea.FormattingEnabled = true;
            this.cbxStorea.Location = new System.Drawing.Point(31, 25);
            this.cbxStorea.Name = "cbxStorea";
            this.cbxStorea.Size = new System.Drawing.Size(204, 26);
            this.cbxStorea.TabIndex = 350;
            // 
            // rbtnOneStore
            // 
            this.rbtnOneStore.AutoSize = true;
            this.rbtnOneStore.Location = new System.Drawing.Point(244, 25);
            this.rbtnOneStore.Name = "rbtnOneStore";
            this.rbtnOneStore.Size = new System.Drawing.Size(83, 22);
            this.rbtnOneStore.TabIndex = 350;
            this.rbtnOneStore.Text = "مخزن محدد";
            this.rbtnOneStore.UseVisualStyleBackColor = true;
            // 
            // rbtnAllStore
            // 
            this.rbtnAllStore.AutoSize = true;
            this.rbtnAllStore.Checked = true;
            this.rbtnAllStore.Location = new System.Drawing.Point(332, 25);
            this.rbtnAllStore.Name = "rbtnAllStore";
            this.rbtnAllStore.Size = new System.Drawing.Size(84, 22);
            this.rbtnAllStore.TabIndex = 350;
            this.rbtnAllStore.TabStop = true;
            this.rbtnAllStore.Text = "كل المخازن";
            this.rbtnAllStore.UseVisualStyleBackColor = true;
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
            this.simpleButton1.Location = new System.Drawing.Point(635, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(276, 39);
            this.simpleButton1.TabIndex = 364;
            this.simpleButton1.Text = "طباعة الجرد";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Frm_ItemReport
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
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1058, 563);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textParcode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRbh7);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalSale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalBuy);
            this.Controls.Add(this.DgvBuyDetalis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_ItemReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جرد الاصناف";
            this.Load += new System.EventHandler(this.Frm_ItemReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuyDetalis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalSale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalBuy;
        private System.Windows.Forms.ComboBox cbxDesName;
        private System.Windows.Forms.RadioButton rbtnOne;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.DataGridView DgvBuyDetalis;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textParcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRbh7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxStorea;
        private System.Windows.Forms.RadioButton rbtnOneStore;
        private System.Windows.Forms.RadioButton rbtnAllStore;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
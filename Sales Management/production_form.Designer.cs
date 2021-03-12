namespace Sales_Management
{
    partial class production_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(production_form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.NudQtyRaw = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxUnitRaw = new System.Windows.Forms.ComboBox();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxRaw = new System.Windows.Forms.ComboBox();
            this.DgvStoreQty = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudQtyRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStoreQty)).BeginInit();
            this.SuspendLayout();
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
            this.btnDelete.Location = new System.Drawing.Point(260, 306);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 31);
            this.btnDelete.TabIndex = 533;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(4, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 530;
            this.label5.Text = "الكمية المستخدمة فى الانتاج:";
            // 
            // NudQtyRaw
            // 
            this.NudQtyRaw.DecimalPlaces = 3;
            this.NudQtyRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudQtyRaw.Location = new System.Drawing.Point(159, 236);
            this.NudQtyRaw.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NudQtyRaw.Name = "NudQtyRaw";
            this.NudQtyRaw.Size = new System.Drawing.Size(108, 26);
            this.NudQtyRaw.TabIndex = 529;
            this.NudQtyRaw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudQtyRaw.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(5, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 528;
            this.label4.Text = "اختر وحدة:";
            // 
            // cbxUnitRaw
            // 
            this.cbxUnitRaw.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxUnitRaw.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxUnitRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnitRaw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxUnitRaw.FormattingEnabled = true;
            this.cbxUnitRaw.Location = new System.Drawing.Point(76, 200);
            this.cbxUnitRaw.Name = "cbxUnitRaw";
            this.cbxUnitRaw.Size = new System.Drawing.Size(138, 28);
            this.cbxUnitRaw.TabIndex = 527;
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
            this.btnAdd.Location = new System.Drawing.Point(205, 306);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 31);
            this.btnAdd.TabIndex = 526;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 525;
            this.label1.Text = "اختر خامة:";
            // 
            // cbxRaw
            // 
            this.cbxRaw.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxRaw.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRaw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxRaw.FormattingEnabled = true;
            this.cbxRaw.Location = new System.Drawing.Point(8, 159);
            this.cbxRaw.Name = "cbxRaw";
            this.cbxRaw.Size = new System.Drawing.Size(191, 28);
            this.cbxRaw.TabIndex = 524;
            this.cbxRaw.SelectionChangeCommitted += new System.EventHandler(this.cbxRaw_SelectionChangeCommitted);
            // 
            // DgvStoreQty
            // 
            this.DgvStoreQty.AllowUserToAddRows = false;
            this.DgvStoreQty.AllowUserToDeleteRows = false;
            this.DgvStoreQty.AllowUserToResizeColumns = false;
            this.DgvStoreQty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvStoreQty.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvStoreQty.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvStoreQty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvStoreQty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStoreQty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvStoreQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvStoreQty.Location = new System.Drawing.Point(361, 12);
            this.DgvStoreQty.Name = "DgvStoreQty";
            this.DgvStoreQty.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvStoreQty.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvStoreQty.RowHeadersVisible = false;
            this.DgvStoreQty.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvStoreQty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvStoreQty.Size = new System.Drawing.Size(535, 473);
            this.DgvStoreQty.TabIndex = 534;
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
            this.Column5.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(169, 373);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(117, 27);
            this.simpleButton1.TabIndex = 547;
            this.simpleButton1.Text = "تحديث";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(4, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 536;
            this.label10.Text = "المنتج الذى تريد انتاجه:";
            // 
            // cbxItems
            // 
            this.cbxItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(8, 48);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(224, 28);
            this.cbxItems.TabIndex = 535;
            this.cbxItems.SelectedIndexChanged += new System.EventHandler(this.cbxItems_SelectedIndexChanged);
            // 
            // production_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 497);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxItems);
            this.Controls.Add(this.DgvStoreQty);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NudQtyRaw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxUnitRaw);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxRaw);
            this.Name = "production_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "production_form";
            this.Load += new System.EventHandler(this.production_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudQtyRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStoreQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NudQtyRaw;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbxUnitRaw;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbxRaw;
        public System.Windows.Forms.DataGridView DgvStoreQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cbxItems;
    }
}
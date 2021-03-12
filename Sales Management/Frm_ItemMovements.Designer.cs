namespace Sales_Management
{
    partial class Frm_ItemMovements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ItemMovements));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.DgvBuyDetalis = new System.Windows.Forms.DataGridView();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.DtbEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtbStart = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalٍS = new System.Windows.Forms.TextBox();
            this.TxtTotalB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuyDetalis)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSearch.Location = new System.Drawing.Point(6, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 36);
            this.btnSearch.TabIndex = 376;
            this.btnSearch.Text = "بحث";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DgvBuyDetalis
            // 
            this.DgvBuyDetalis.AllowUserToAddRows = false;
            this.DgvBuyDetalis.AllowUserToDeleteRows = false;
            this.DgvBuyDetalis.AllowUserToResizeColumns = false;
            this.DgvBuyDetalis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBuyDetalis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvBuyDetalis.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBuyDetalis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvBuyDetalis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBuyDetalis.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvBuyDetalis.Location = new System.Drawing.Point(79, 155);
            this.DgvBuyDetalis.Name = "DgvBuyDetalis";
            this.DgvBuyDetalis.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBuyDetalis.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvBuyDetalis.RowHeadersVisible = false;
            this.DgvBuyDetalis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBuyDetalis.Size = new System.Drawing.Size(1029, 431);
            this.DgvBuyDetalis.TabIndex = 393;
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(741, -78);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(148, 21);
            this.cbxType.TabIndex = 380;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxItems);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbxType);
            this.groupBox1.Controls.Add(this.DtbEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DtbStart);
            this.groupBox1.Location = new System.Drawing.Point(92, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 109);
            this.groupBox1.TabIndex = 391;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(843, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 24);
            this.label7.TabIndex = 425;
            this.label7.Text = "اسم الصنف";
            // 
            // cbxItems
            // 
            this.cbxItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(577, 60);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(260, 32);
            this.cbxItems.TabIndex = 424;
            // 
            // DtbEnd
            // 
            this.DtbEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtbEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbEnd.Location = new System.Drawing.Point(187, 63);
            this.DtbEnd.Name = "DtbEnd";
            this.DtbEnd.Size = new System.Drawing.Size(143, 29);
            this.DtbEnd.TabIndex = 370;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(336, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 372;
            this.label2.Text = "الى:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(537, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 371;
            this.label1.Text = "من:";
            // 
            // DtbStart
            // 
            this.DtbStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtbStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbStart.Location = new System.Drawing.Point(378, 63);
            this.DtbStart.Name = "DtbStart";
            this.DtbStart.Size = new System.Drawing.Size(148, 29);
            this.DtbStart.TabIndex = 369;
            this.DtbStart.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(524, 6);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 25);
            this.labelControl1.TabIndex = 390;
            this.labelControl1.Text = "حركة الاصناف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(228, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 426;
            this.label3.Text = "اجمالي المبيعات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(685, 606);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 426;
            this.label4.Text = "اجمالي المشتريات";
            // 
            // txtTotalٍS
            // 
            this.txtTotalٍS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalٍS.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalٍS.Location = new System.Drawing.Point(354, 610);
            this.txtTotalٍS.Name = "txtTotalٍS";
            this.txtTotalٍS.ReadOnly = true;
            this.txtTotalٍS.Size = new System.Drawing.Size(167, 20);
            this.txtTotalٍS.TabIndex = 427;
            this.txtTotalٍS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTotalB
            // 
            this.TxtTotalB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalB.ForeColor = System.Drawing.Color.Blue;
            this.TxtTotalB.Location = new System.Drawing.Point(841, 610);
            this.TxtTotalB.Name = "TxtTotalB";
            this.TxtTotalB.ReadOnly = true;
            this.TxtTotalB.Size = new System.Drawing.Size(167, 20);
            this.TxtTotalB.TabIndex = 427;
            this.TxtTotalB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_ItemMovements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 639);
            this.Controls.Add(this.TxtTotalB);
            this.Controls.Add(this.txtTotalٍS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvBuyDetalis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ItemMovements";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ItemMovements";
            this.Load += new System.EventHandler(this.Frm_ItemMovements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuyDetalis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.DataGridView DgvBuyDetalis;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DtbEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtbStart;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalٍS;
        private System.Windows.Forms.TextBox TxtTotalB;
    }
}
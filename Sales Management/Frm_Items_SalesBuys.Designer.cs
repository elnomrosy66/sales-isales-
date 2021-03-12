namespace Sales_Management
{
    partial class Frm_Items_SalesBuys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Items_SalesBuys));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnItemsBuyDC = new System.Windows.Forms.RadioButton();
            this.rbtnItemsBuyAC = new System.Windows.Forms.RadioButton();
            this.rbtnItemsSaleAC = new System.Windows.Forms.RadioButton();
            this.rbtnItemsSaleDC = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtbEnd = new System.Windows.Forms.DateTimePicker();
            this.DtbStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvBuyDetalis = new System.Windows.Forms.DataGridView();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuyDetalis)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnItemsBuyDC);
            this.groupBox1.Controls.Add(this.rbtnItemsBuyAC);
            this.groupBox1.Controls.Add(this.rbtnItemsSaleAC);
            this.groupBox1.Controls.Add(this.rbtnItemsSaleDC);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 85);
            this.groupBox1.TabIndex = 360;
            this.groupBox1.TabStop = false;
            // 
            // rbtnItemsBuyDC
            // 
            this.rbtnItemsBuyDC.AutoSize = true;
            this.rbtnItemsBuyDC.ForeColor = System.Drawing.Color.Blue;
            this.rbtnItemsBuyDC.Location = new System.Drawing.Point(13, 22);
            this.rbtnItemsBuyDC.Name = "rbtnItemsBuyDC";
            this.rbtnItemsBuyDC.Size = new System.Drawing.Size(208, 32);
            this.rbtnItemsBuyDC.TabIndex = 353;
            this.rbtnItemsBuyDC.Text = "الاصناف الاكثر شراء (تنازليا)";
            this.rbtnItemsBuyDC.UseVisualStyleBackColor = true;
            // 
            // rbtnItemsBuyAC
            // 
            this.rbtnItemsBuyAC.AutoSize = true;
            this.rbtnItemsBuyAC.Checked = true;
            this.rbtnItemsBuyAC.ForeColor = System.Drawing.Color.Blue;
            this.rbtnItemsBuyAC.Location = new System.Drawing.Point(246, 22);
            this.rbtnItemsBuyAC.Name = "rbtnItemsBuyAC";
            this.rbtnItemsBuyAC.Size = new System.Drawing.Size(223, 32);
            this.rbtnItemsBuyAC.TabIndex = 348;
            this.rbtnItemsBuyAC.TabStop = true;
            this.rbtnItemsBuyAC.Text = "الاصناف الاكثر شراء (تصاعديا)";
            this.rbtnItemsBuyAC.UseVisualStyleBackColor = true;
            // 
            // rbtnItemsSaleAC
            // 
            this.rbtnItemsSaleAC.AutoSize = true;
            this.rbtnItemsSaleAC.ForeColor = System.Drawing.Color.Blue;
            this.rbtnItemsSaleAC.Location = new System.Drawing.Point(251, 51);
            this.rbtnItemsSaleAC.Name = "rbtnItemsSaleAC";
            this.rbtnItemsSaleAC.Size = new System.Drawing.Size(219, 32);
            this.rbtnItemsSaleAC.TabIndex = 349;
            this.rbtnItemsSaleAC.Text = "الاصناف الاكثر بيعا (تصاعديا)";
            this.rbtnItemsSaleAC.UseVisualStyleBackColor = true;
            // 
            // rbtnItemsSaleDC
            // 
            this.rbtnItemsSaleDC.AutoSize = true;
            this.rbtnItemsSaleDC.ForeColor = System.Drawing.Color.Blue;
            this.rbtnItemsSaleDC.Location = new System.Drawing.Point(18, 51);
            this.rbtnItemsSaleDC.Name = "rbtnItemsSaleDC";
            this.rbtnItemsSaleDC.Size = new System.Drawing.Size(204, 32);
            this.rbtnItemsSaleDC.TabIndex = 354;
            this.rbtnItemsSaleDC.Text = "الاصناف الاكثر بيعا (تنازليا)";
            this.rbtnItemsSaleDC.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtbEnd);
            this.groupBox2.Controls.Add(this.DtbStart);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(511, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 85);
            this.groupBox2.TabIndex = 361;
            this.groupBox2.TabStop = false;
            // 
            // DtbEnd
            // 
            this.DtbEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbEnd.Location = new System.Drawing.Point(6, 35);
            this.DtbEnd.Name = "DtbEnd";
            this.DtbEnd.Size = new System.Drawing.Size(156, 36);
            this.DtbEnd.TabIndex = 356;
            // 
            // DtbStart
            // 
            this.DtbStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbStart.Location = new System.Drawing.Point(216, 35);
            this.DtbStart.Name = "DtbStart";
            this.DtbStart.Size = new System.Drawing.Size(153, 36);
            this.DtbStart.TabIndex = 355;
            this.DtbStart.Value = new System.DateTime(2014, 7, 20, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(168, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 28);
            this.label2.TabIndex = 358;
            this.label2.Text = "الى:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(375, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 357;
            this.label1.Text = "من:";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBuyDetalis.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvBuyDetalis.Location = new System.Drawing.Point(12, 147);
            this.DgvBuyDetalis.Name = "DgvBuyDetalis";
            this.DgvBuyDetalis.ReadOnly = true;
            this.DgvBuyDetalis.RowHeadersVisible = false;
            this.DgvBuyDetalis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvBuyDetalis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBuyDetalis.Size = new System.Drawing.Size(919, 296);
            this.DgvBuyDetalis.TabIndex = 362;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Appearance.Options.UseTextOptions = true;
            this.btnSearch.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSearch.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSearch.Location = new System.Drawing.Point(250, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(436, 46);
            this.btnSearch.TabIndex = 369;
            this.btnSearch.Text = "جرد";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Frm_Items_SalesBuys
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 449);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.DgvBuyDetalis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Items_SalesBuys";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير الاصناف الاكثر شراء والاكثر مبيعا";
            this.Load += new System.EventHandler(this.Frm_Items_SalesBuys_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuyDetalis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnItemsBuyDC;
        private System.Windows.Forms.RadioButton rbtnItemsBuyAC;
        private System.Windows.Forms.RadioButton rbtnItemsSaleAC;
        private System.Windows.Forms.RadioButton rbtnItemsSaleDC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DtbEnd;
        private System.Windows.Forms.DateTimePicker DtbStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvBuyDetalis;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
    }
}
namespace Sales_Management
{
    partial class Frm_Items_Top20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Items_Top20));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtbEnd = new System.Windows.Forms.DateTimePicker();
            this.DtbStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnTopLessSales = new System.Windows.Forms.RadioButton();
            this.rbtnTopMoreSales = new System.Windows.Forms.RadioButton();
            this.DgvBuyDetalis = new System.Windows.Forms.DataGridView();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuyDetalis)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtbEnd);
            this.groupBox2.Controls.Add(this.DtbStart);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(584, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 75);
            this.groupBox2.TabIndex = 366;
            this.groupBox2.TabStop = false;
            // 
            // DtbEnd
            // 
            this.DtbEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbEnd.Location = new System.Drawing.Point(6, 26);
            this.DtbEnd.Name = "DtbEnd";
            this.DtbEnd.Size = new System.Drawing.Size(131, 36);
            this.DtbEnd.TabIndex = 356;
            // 
            // DtbStart
            // 
            this.DtbStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbStart.Location = new System.Drawing.Point(187, 26);
            this.DtbStart.Name = "DtbStart";
            this.DtbStart.Size = new System.Drawing.Size(124, 36);
            this.DtbStart.TabIndex = 355;
            this.DtbStart.Value = new System.DateTime(2014, 7, 20, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(139, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 28);
            this.label2.TabIndex = 358;
            this.label2.Text = "الى:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(317, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 357;
            this.label1.Text = "من:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnTopLessSales);
            this.groupBox1.Controls.Add(this.rbtnTopMoreSales);
            this.groupBox1.Location = new System.Drawing.Point(8, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 74);
            this.groupBox1.TabIndex = 365;
            this.groupBox1.TabStop = false;
            // 
            // rbtnTopLessSales
            // 
            this.rbtnTopLessSales.AutoSize = true;
            this.rbtnTopLessSales.ForeColor = System.Drawing.Color.Blue;
            this.rbtnTopLessSales.Location = new System.Drawing.Point(6, 29);
            this.rbtnTopLessSales.Name = "rbtnTopLessSales";
            this.rbtnTopLessSales.Size = new System.Drawing.Size(247, 32);
            this.rbtnTopLessSales.TabIndex = 353;
            this.rbtnTopLessSales.Text = "الاصناف الاكثر ركودا فى المبيعات";
            this.rbtnTopLessSales.UseVisualStyleBackColor = true;
            // 
            // rbtnTopMoreSales
            // 
            this.rbtnTopMoreSales.AutoSize = true;
            this.rbtnTopMoreSales.Checked = true;
            this.rbtnTopMoreSales.ForeColor = System.Drawing.Color.Blue;
            this.rbtnTopMoreSales.Location = new System.Drawing.Point(284, 29);
            this.rbtnTopMoreSales.Name = "rbtnTopMoreSales";
            this.rbtnTopMoreSales.Size = new System.Drawing.Size(244, 32);
            this.rbtnTopMoreSales.TabIndex = 348;
            this.rbtnTopMoreSales.TabStop = true;
            this.rbtnTopMoreSales.Text = "الاصناف الاكثر رواجا فى المبيعات";
            this.rbtnTopMoreSales.UseVisualStyleBackColor = true;
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
            this.DgvBuyDetalis.Location = new System.Drawing.Point(8, 141);
            this.DgvBuyDetalis.Name = "DgvBuyDetalis";
            this.DgvBuyDetalis.ReadOnly = true;
            this.DgvBuyDetalis.RowHeadersVisible = false;
            this.DgvBuyDetalis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvBuyDetalis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBuyDetalis.Size = new System.Drawing.Size(949, 282);
            this.DgvBuyDetalis.TabIndex = 371;
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
            this.btnSearch.Location = new System.Drawing.Point(268, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(436, 46);
            this.btnSearch.TabIndex = 370;
            this.btnSearch.Text = "جرد";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Frm_Items_Top20
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 429);
            this.Controls.Add(this.DgvBuyDetalis);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Items_Top20";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاصناف الرائجة والاصناف الراكدة";
            this.Load += new System.EventHandler(this.Frm_Items_Top20_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuyDetalis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DtbEnd;
        private System.Windows.Forms.DateTimePicker DtbStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnTopLessSales;
        private System.Windows.Forms.RadioButton rbtnTopMoreSales;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.DataGridView DgvBuyDetalis;
    }
}
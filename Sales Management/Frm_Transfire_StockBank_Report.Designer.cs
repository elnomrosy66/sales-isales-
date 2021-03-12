namespace Sales_Management
{
    partial class Frm_Transfire_StockBank_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Transfire_StockBank_Report));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.DtbEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnFromBankToStock = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.DtbStart = new System.Windows.Forms.DateTimePicker();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnFromStockToBank = new System.Windows.Forms.RadioButton();
            this.DgvSearchBuy = new System.Windows.Forms.DataGridView();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPhar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.DtbEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbtnFromBankToStock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DtbStart);
            this.groupBox1.Controls.Add(this.rbtnAll);
            this.groupBox1.Controls.Add(this.rbtnFromStockToBank);
            this.groupBox1.Location = new System.Drawing.Point(10, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton1.Location = new System.Drawing.Point(23, 37);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(151, 39);
            this.simpleButton1.TabIndex = 386;
            this.simpleButton1.Text = "بحث";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // DtbEnd
            // 
            this.DtbEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbEnd.Location = new System.Drawing.Point(192, 37);
            this.DtbEnd.Name = "DtbEnd";
            this.DtbEnd.Size = new System.Drawing.Size(134, 36);
            this.DtbEnd.TabIndex = 378;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(326, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 28);
            this.label2.TabIndex = 380;
            this.label2.Text = "الى:";
            // 
            // rbtnFromBankToStock
            // 
            this.rbtnFromBankToStock.AutoSize = true;
            this.rbtnFromBankToStock.Location = new System.Drawing.Point(551, 35);
            this.rbtnFromBankToStock.Name = "rbtnFromBankToStock";
            this.rbtnFromBankToStock.Size = new System.Drawing.Size(128, 32);
            this.rbtnFromBankToStock.TabIndex = 385;
            this.rbtnFromBankToStock.Text = "من البنك للخزنة";
            this.rbtnFromBankToStock.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(500, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 379;
            this.label1.Text = "من:";
            // 
            // DtbStart
            // 
            this.DtbStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbStart.Location = new System.Drawing.Point(372, 37);
            this.DtbStart.Name = "DtbStart";
            this.DtbStart.Size = new System.Drawing.Size(126, 36);
            this.DtbStart.TabIndex = 377;
            this.DtbStart.Value = new System.DateTime(2014, 7, 20, 0, 0, 0, 0);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Location = new System.Drawing.Point(819, 35);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(115, 32);
            this.rbtnAll.TabIndex = 383;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "كل التحويلات";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // rbtnFromStockToBank
            // 
            this.rbtnFromStockToBank.AutoSize = true;
            this.rbtnFromStockToBank.Location = new System.Drawing.Point(685, 35);
            this.rbtnFromStockToBank.Name = "rbtnFromStockToBank";
            this.rbtnFromStockToBank.Size = new System.Drawing.Size(128, 32);
            this.rbtnFromStockToBank.TabIndex = 384;
            this.rbtnFromStockToBank.Text = "من الخزنة للبنك";
            this.rbtnFromStockToBank.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSearchBuy.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSearchBuy.Location = new System.Drawing.Point(10, 154);
            this.DgvSearchBuy.Name = "DgvSearchBuy";
            this.DgvSearchBuy.ReadOnly = true;
            this.DgvSearchBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearchBuy.Size = new System.Drawing.Size(957, 341);
            this.DgvSearchBuy.TabIndex = 371;
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
            this.btnDelete.Location = new System.Drawing.Point(10, 502);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(307, 38);
            this.btnDelete.TabIndex = 403;
            this.btnDelete.Text = "مسح البيانات فى هذه الفترة";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(467, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 28);
            this.label3.TabIndex = 401;
            this.label3.Text = "اجمالى المبالغ المحوله  فى الفتره المحددة:";
            // 
            // txtTotalPhar
            // 
            this.txtTotalPhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPhar.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalPhar.Location = new System.Drawing.Point(770, 504);
            this.txtTotalPhar.Name = "txtTotalPhar";
            this.txtTotalPhar.ReadOnly = true;
            this.txtTotalPhar.Size = new System.Drawing.Size(197, 36);
            this.txtTotalPhar.TabIndex = 402;
            this.txtTotalPhar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(313, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 36);
            this.label6.TabIndex = 404;
            this.label6.Text = "اجمالى التحويل بين الخزنة والبنك";
            // 
            // Frm_Transfire_StockBank_Report
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(977, 548);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalPhar);
            this.Controls.Add(this.DgvSearchBuy);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_Transfire_StockBank_Report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير التحويل بين الخزنة والبنك";
            this.Load += new System.EventHandler(this.Frm_Transfire_StockBank_Report_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DtbEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnFromBankToStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtbStart;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnFromStockToBank;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridView DgvSearchBuy;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalPhar;
        private System.Windows.Forms.Label label6;
    }
}
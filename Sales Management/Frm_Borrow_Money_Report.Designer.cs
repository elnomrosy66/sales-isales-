namespace Sales_Management
{
    partial class Frm_Borrow_Money_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Borrow_Money_Report));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtbEnd = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.DtbStart = new System.Windows.Forms.DateTimePicker();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnOne = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvSearchBuy = new System.Windows.Forms.DataGridView();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPhar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DtbEnd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.DtbStart);
            this.groupBox1.Controls.Add(this.rbtnAll);
            this.groupBox1.Controls.Add(this.rbtnOne);
            this.groupBox1.Location = new System.Drawing.Point(6, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 77);
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
            this.simpleButton1.Location = new System.Drawing.Point(10, 24);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(117, 39);
            this.simpleButton1.TabIndex = 371;
            this.simpleButton1.Text = "بحث";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(263, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 28);
            this.label2.TabIndex = 366;
            this.label2.Text = "الى:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(426, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 366;
            this.label1.Text = "من:";
            // 
            // DtbEnd
            // 
            this.DtbEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbEnd.Location = new System.Drawing.Point(134, 25);
            this.DtbEnd.Name = "DtbEnd";
            this.DtbEnd.Size = new System.Drawing.Size(123, 36);
            this.DtbEnd.TabIndex = 365;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(475, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 36);
            this.txtName.TabIndex = 374;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DtbStart
            // 
            this.DtbStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbStart.Location = new System.Drawing.Point(310, 25);
            this.DtbStart.Name = "DtbStart";
            this.DtbStart.Size = new System.Drawing.Size(115, 36);
            this.DtbStart.TabIndex = 365;
            this.DtbStart.Value = new System.DateTime(2014, 7, 20, 0, 0, 0, 0);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.ForeColor = System.Drawing.Color.Blue;
            this.rbtnAll.Location = new System.Drawing.Point(792, 29);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(114, 32);
            this.rbtnAll.TabIndex = 372;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "كل السلفيات";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // rbtnOne
            // 
            this.rbtnOne.AutoSize = true;
            this.rbtnOne.ForeColor = System.Drawing.Color.Blue;
            this.rbtnOne.Location = new System.Drawing.Point(676, 29);
            this.rbtnOne.Name = "rbtnOne";
            this.rbtnOne.Size = new System.Drawing.Size(110, 32);
            this.rbtnOne.TabIndex = 373;
            this.rbtnOne.Text = "شخص محدد";
            this.rbtnOne.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(396, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 40);
            this.label6.TabIndex = 364;
            this.label6.Text = "تقرير السلفيات";
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
            this.DgvSearchBuy.Location = new System.Drawing.Point(8, 121);
            this.DgvSearchBuy.Name = "DgvSearchBuy";
            this.DgvSearchBuy.ReadOnly = true;
            this.DgvSearchBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearchBuy.Size = new System.Drawing.Size(920, 281);
            this.DgvSearchBuy.TabIndex = 367;
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
            this.btnDelete.Location = new System.Drawing.Point(148, 412);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(307, 38);
            this.btnDelete.TabIndex = 380;
            this.btnDelete.Text = "مسح البيانات فى هذه الفترة";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(533, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 28);
            this.label3.TabIndex = 382;
            this.label3.Text = "اجمالى السلفيات فى هذه الفترة:";
            // 
            // txtTotalPhar
            // 
            this.txtTotalPhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPhar.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalPhar.Location = new System.Drawing.Point(773, 408);
            this.txtTotalPhar.Name = "txtTotalPhar";
            this.txtTotalPhar.ReadOnly = true;
            this.txtTotalPhar.Size = new System.Drawing.Size(155, 36);
            this.txtTotalPhar.TabIndex = 381;
            this.txtTotalPhar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_Borrow_Money_Report
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(936, 463);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalPhar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.DgvSearchBuy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Borrow_Money_Report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير السلفيات";
            this.Load += new System.EventHandler(this.Frm_Borrow_Money_Report_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtbEnd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker DtbStart;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnOne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvSearchBuy;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalPhar;
    }
}
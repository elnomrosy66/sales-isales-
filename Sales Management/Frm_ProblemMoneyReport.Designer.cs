namespace Sales_Management
{
    partial class Frm_ProblemMoneyReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProblemMoneyReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.rbtnLAte = new System.Windows.Forms.RadioButton();
            this.rbtnDameg = new System.Windows.Forms.RadioButton();
            this.DtbEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtbStart = new System.Windows.Forms.DateTimePicker();
            this.DgvBuyDetalis = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuyDetalis)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(173, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(536, 52);
            this.label6.TabIndex = 382;
            this.label6.Text = "اجمالى مبالغ التلفيات فى عمليات الايجار";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.rbtnLAte);
            this.groupBox1.Controls.Add(this.rbtnDameg);
            this.groupBox1.Controls.Add(this.DtbEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DtbStart);
            this.groupBox1.Location = new System.Drawing.Point(8, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 70);
            this.groupBox1.TabIndex = 383;
            this.groupBox1.TabStop = false;
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
            this.btnSearch.Location = new System.Drawing.Point(15, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 37);
            this.btnSearch.TabIndex = 384;
            this.btnSearch.Text = "بحث";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbtnLAte
            // 
            this.rbtnLAte.AutoSize = true;
            this.rbtnLAte.Location = new System.Drawing.Point(594, 26);
            this.rbtnLAte.Name = "rbtnLAte";
            this.rbtnLAte.Size = new System.Drawing.Size(199, 32);
            this.rbtnLAte.TabIndex = 390;
            this.rbtnLAte.Text = "التعويض عن التاخير والضرر";
            this.rbtnLAte.UseVisualStyleBackColor = true;
            // 
            // rbtnDameg
            // 
            this.rbtnDameg.AutoSize = true;
            this.rbtnDameg.Checked = true;
            this.rbtnDameg.Location = new System.Drawing.Point(799, 26);
            this.rbtnDameg.Name = "rbtnDameg";
            this.rbtnDameg.Size = new System.Drawing.Size(82, 32);
            this.rbtnDameg.TabIndex = 389;
            this.rbtnDameg.TabStop = true;
            this.rbtnDameg.Text = "التلفيات";
            this.rbtnDameg.UseVisualStyleBackColor = true;
            // 
            // DtbEnd
            // 
            this.DtbEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbEnd.Location = new System.Drawing.Point(171, 22);
            this.DtbEnd.Name = "DtbEnd";
            this.DtbEnd.Size = new System.Drawing.Size(134, 36);
            this.DtbEnd.TabIndex = 386;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(311, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 28);
            this.label2.TabIndex = 388;
            this.label2.Text = "الى:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(520, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 387;
            this.label1.Text = "من:";
            // 
            // DtbStart
            // 
            this.DtbStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbStart.Location = new System.Drawing.Point(361, 22);
            this.DtbStart.Name = "DtbStart";
            this.DtbStart.Size = new System.Drawing.Size(153, 36);
            this.DtbStart.TabIndex = 385;
            this.DtbStart.Value = new System.DateTime(2014, 7, 20, 0, 0, 0, 0);
            // 
            // DgvBuyDetalis
            // 
            this.DgvBuyDetalis.AllowUserToAddRows = false;
            this.DgvBuyDetalis.AllowUserToDeleteRows = false;
            this.DgvBuyDetalis.AllowUserToResizeColumns = false;
            this.DgvBuyDetalis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.DgvBuyDetalis.Location = new System.Drawing.Point(8, 115);
            this.DgvBuyDetalis.Name = "DgvBuyDetalis";
            this.DgvBuyDetalis.ReadOnly = true;
            this.DgvBuyDetalis.RowHeadersVisible = false;
            this.DgvBuyDetalis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvBuyDetalis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBuyDetalis.Size = new System.Drawing.Size(896, 264);
            this.DgvBuyDetalis.TabIndex = 384;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(475, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 31);
            this.label5.TabIndex = 387;
            this.label5.Text = "اجمالى مبلغ التلفيات:";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.ForeColor = System.Drawing.Color.Blue;
            this.txtTotal.Location = new System.Drawing.Point(661, 389);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(241, 36);
            this.txtTotal.TabIndex = 386;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnDelete.Location = new System.Drawing.Point(64, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(246, 43);
            this.btnDelete.TabIndex = 385;
            this.btnDelete.Text = "مسح البيانات فى هذه الفترة";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Frm_ProblemMoneyReport
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(913, 434);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.DgvBuyDetalis);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ProblemMoneyReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير مبالغ التلف والتعويضات";
            this.Load += new System.EventHandler(this.Frm_ProblemMoneyReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuyDetalis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnLAte;
        private System.Windows.Forms.RadioButton rbtnDameg;
        private System.Windows.Forms.DateTimePicker DtbEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtbStart;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.DataGridView DgvBuyDetalis;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
    }
}
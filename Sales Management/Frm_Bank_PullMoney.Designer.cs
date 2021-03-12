namespace Sales_Management
{
    partial class Frm_Bank_PullMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Bank_PullMoney));
            this.label3 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtbDate = new System.Windows.Forms.DateTimePicker();
            this.NudMoney = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCurrentMoney = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.NudMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(55, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 389;
            this.label3.Text = "سبب السحب:";
            // 
            // txtReason
            // 
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Location = new System.Drawing.Point(157, 188);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(247, 73);
            this.txtReason.TabIndex = 388;
            this.txtReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(53, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 387;
            this.label1.Text = "اسم الساحب:";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(157, 143);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(247, 36);
            this.txtItemName.TabIndex = 386;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(53, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 385;
            this.label2.Text = "تاريخ السحب:";
            // 
            // DtbDate
            // 
            this.DtbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbDate.Location = new System.Drawing.Point(156, 99);
            this.DtbDate.Name = "DtbDate";
            this.DtbDate.Size = new System.Drawing.Size(247, 36);
            this.DtbDate.TabIndex = 384;
            // 
            // NudMoney
            // 
            this.NudMoney.DecimalPlaces = 2;
            this.NudMoney.Location = new System.Drawing.Point(156, 57);
            this.NudMoney.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.NudMoney.Name = "NudMoney";
            this.NudMoney.Size = new System.Drawing.Size(247, 36);
            this.NudMoney.TabIndex = 382;
            this.NudMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(15, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 28);
            this.label9.TabIndex = 381;
            this.label9.Text = "المبلغ المراد سحبه:";
            // 
            // lblCurrentMoney
            // 
            this.lblCurrentMoney.AutoSize = true;
            this.lblCurrentMoney.Location = new System.Drawing.Point(253, 15);
            this.lblCurrentMoney.Name = "lblCurrentMoney";
            this.lblCurrentMoney.Size = new System.Drawing.Size(32, 28);
            this.lblCurrentMoney.TabIndex = 380;
            this.lblCurrentMoney.Text = "....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(14, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 36);
            this.label6.TabIndex = 379;
            this.label6.Text = "رصيد البنك الحالى هو :";
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
            this.btnSearch.Location = new System.Drawing.Point(156, 267);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(248, 46);
            this.btnSearch.TabIndex = 393;
            this.btnSearch.Text = "سحب";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Frm_Bank_PullMoney
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(415, 320);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtbDate);
            this.Controls.Add(this.NudMoney);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCurrentMoney);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Bank_PullMoney";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سحب رصيد من البنك";
            this.Load += new System.EventHandler(this.Frm_Bank_PullMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtbDate;
        private System.Windows.Forms.NumericUpDown NudMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCurrentMoney;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
    }
}
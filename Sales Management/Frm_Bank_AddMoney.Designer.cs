namespace Sales_Management
{
    partial class Frm_Bank_AddMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Bank_AddMoney));
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtbDate = new System.Windows.Forms.DateTimePicker();
            this.NudMoney = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCurrentMoney = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(55, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 363;
            this.label1.Text = "اسم المودع:";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(159, 134);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(229, 36);
            this.txtItemName.TabIndex = 362;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(54, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 361;
            this.label2.Text = "تاريخ الايداع:";
            // 
            // DtbDate
            // 
            this.DtbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbDate.Location = new System.Drawing.Point(159, 90);
            this.DtbDate.Name = "DtbDate";
            this.DtbDate.Size = new System.Drawing.Size(229, 36);
            this.DtbDate.TabIndex = 360;
            // 
            // NudMoney
            // 
            this.NudMoney.DecimalPlaces = 2;
            this.NudMoney.Location = new System.Drawing.Point(159, 48);
            this.NudMoney.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.NudMoney.Name = "NudMoney";
            this.NudMoney.Size = new System.Drawing.Size(231, 36);
            this.NudMoney.TabIndex = 358;
            this.NudMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(25, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 28);
            this.label9.TabIndex = 357;
            this.label9.Text = "ايداع رصيد جديد:";
            // 
            // lblCurrentMoney
            // 
            this.lblCurrentMoney.AutoSize = true;
            this.lblCurrentMoney.Location = new System.Drawing.Point(212, 10);
            this.lblCurrentMoney.Name = "lblCurrentMoney";
            this.lblCurrentMoney.Size = new System.Drawing.Size(32, 28);
            this.lblCurrentMoney.TabIndex = 356;
            this.lblCurrentMoney.Text = "....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(22, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 36);
            this.label6.TabIndex = 355;
            this.label6.Text = "رصيد البنك الحالى:";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseTextOptions = true;
            this.btnAdd.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnAdd.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAdd.Location = new System.Drawing.Point(157, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(231, 46);
            this.btnAdd.TabIndex = 369;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtReason
            // 
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Location = new System.Drawing.Point(159, 176);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(229, 82);
            this.txtReason.TabIndex = 370;
            this.txtReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(55, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 371;
            this.label3.Text = "سبب الايداع:";
            // 
            // Frm_Bank_AddMoney
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(402, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.btnAdd);
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
            this.Name = "Frm_Bank_AddMoney";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة رصيد للبنك";
            this.Load += new System.EventHandler(this.Frm_Bank_AddMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtbDate;
        private System.Windows.Forms.NumericUpDown NudMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCurrentMoney;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label3;
    }
}
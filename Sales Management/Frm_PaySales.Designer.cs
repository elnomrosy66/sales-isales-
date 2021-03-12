namespace Sales_Management
{
    partial class Frm_PaySales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PaySales));
            this.label12 = new System.Windows.Forms.Label();
            this.txtMadfou3 = new System.Windows.Forms.TextBox();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatloub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textReminder = new System.Windows.Forms.TextBox();
            this.btnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkVisa = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(18, 120);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 28);
            this.label12.TabIndex = 381;
            this.label12.Text = "المدفوع:";
            // 
            // txtMadfou3
            // 
            this.txtMadfou3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMadfou3.Font = new System.Drawing.Font("Droid Arabic Kufi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMadfou3.Location = new System.Drawing.Point(95, 102);
            this.txtMadfou3.Margin = new System.Windows.Forms.Padding(2);
            this.txtMadfou3.Name = "txtMadfou3";
            this.txtMadfou3.Size = new System.Drawing.Size(327, 59);
            this.txtMadfou3.TabIndex = 380;
            this.txtMadfou3.Text = "1";
            this.txtMadfou3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMadfou3.TextChanged += new System.EventHandler(this.txtMadfou3_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Appearance.Options.UseTextOptions = true;
            this.btnClose.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnClose.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(95, 291);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(217, 44);
            this.btnClose.TabIndex = 388;
            this.btnClose.Text = "للحفظ والطباعة اضغط انتر";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 390;
            this.label1.Text = "المطلوب:";
            // 
            // txtMatloub
            // 
            this.txtMatloub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatloub.Font = new System.Drawing.Font("Droid Arabic Kufi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatloub.Location = new System.Drawing.Point(95, 11);
            this.txtMatloub.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatloub.Name = "txtMatloub";
            this.txtMatloub.ReadOnly = true;
            this.txtMatloub.Size = new System.Drawing.Size(327, 68);
            this.txtMatloub.TabIndex = 389;
            this.txtMatloub.Text = "1";
            this.txtMatloub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(28, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 28);
            this.label2.TabIndex = 392;
            this.label2.Text = "الباقى:";
            // 
            // textReminder
            // 
            this.textReminder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textReminder.Font = new System.Drawing.Font("Droid Arabic Kufi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReminder.Location = new System.Drawing.Point(95, 189);
            this.textReminder.Margin = new System.Windows.Forms.Padding(2);
            this.textReminder.Name = "textReminder";
            this.textReminder.ReadOnly = true;
            this.textReminder.Size = new System.Drawing.Size(327, 68);
            this.textReminder.TabIndex = 391;
            this.textReminder.Text = "1";
            this.textReminder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReturn
            // 
            this.btnReturn.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Appearance.Options.UseFont = true;
            this.btnReturn.Appearance.Options.UseTextOptions = true;
            this.btnReturn.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnReturn.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnReturn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.ImageOptions.Image")));
            this.btnReturn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnReturn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnReturn.Location = new System.Drawing.Point(316, 291);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(106, 44);
            this.btnReturn.TabIndex = 393;
            this.btnReturn.Text = "رجوع";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(361, 338);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 24);
            this.label8.TabIndex = 426;
            this.label8.Text = "F12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(177, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 427;
            this.label3.Text = "Enter";
            // 
            // checkVisa
            // 
            this.checkVisa.AutoSize = true;
            this.checkVisa.Location = new System.Drawing.Point(191, 262);
            this.checkVisa.Name = "checkVisa";
            this.checkVisa.Size = new System.Drawing.Size(148, 26);
            this.checkVisa.TabIndex = 428;
            this.checkVisa.Text = "دفع بالبطاقة الائتمانية";
            this.checkVisa.UseVisualStyleBackColor = true;
            // 
            // Frm_PaySales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(445, 369);
            this.Controls.Add(this.checkVisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textReminder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatloub);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMadfou3);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_PaySales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_PaySales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_PaySales_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMadfou3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatloub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textReminder;
        private DevExpress.XtraEditors.SimpleButton btnReturn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkVisa;
    }
}
namespace Sales_Management
{
    partial class Frm_Qty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Qty));
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cbxUnit = new System.Windows.Forms.ComboBox();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Droid Arabic Kufi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(83, 198);
            this.txtQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(302, 59);
            this.txtQty.TabIndex = 370;
            this.txtQty.Text = "1";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(20, 209);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 28);
            this.label12.TabIndex = 371;
            this.label12.Text = "الكمية:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 28);
            this.label1.TabIndex = 373;
            this.label1.Text = "الخصم:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Droid Arabic Kufi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(83, 21);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(302, 53);
            this.txtDiscount.TabIndex = 372;
            this.txtDiscount.Text = "0.0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 28);
            this.label2.TabIndex = 375;
            this.label2.Text = "السعر:";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Droid Arabic Kufi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(83, 79);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(302, 53);
            this.txtPrice.TabIndex = 374;
            this.txtPrice.Text = "1";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(16, 150);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 28);
            this.label24.TabIndex = 378;
            this.label24.Text = "الوحدة:";
            // 
            // cbxUnit
            // 
            this.cbxUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxUnit.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnit.FormattingEnabled = true;
            this.cbxUnit.Location = new System.Drawing.Point(83, 138);
            this.cbxUnit.Margin = new System.Windows.Forms.Padding(2);
            this.cbxUnit.Name = "cbxUnit";
            this.cbxUnit.Size = new System.Drawing.Size(302, 48);
            this.cbxUnit.TabIndex = 377;
            this.cbxUnit.SelectedIndexChanged += new System.EventHandler(this.cbxUnit_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Appearance.Options.UseTextOptions = true;
            this.btnClose.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnClose.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnClose.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnClose.Location = new System.Drawing.Point(83, 267);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(302, 44);
            this.btnClose.TabIndex = 379;
            this.btnClose.Text = "اضغط انتر";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Frm_Qty
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(406, 322);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cbxUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtQty);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Qty";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Qty_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Qty_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Qty_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Qty_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.ComboBox cbxUnit;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}
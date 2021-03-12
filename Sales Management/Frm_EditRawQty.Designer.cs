namespace Sales_Management
{
    partial class Frm_EditRawQty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EditRawQty));
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(17, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 435;
            this.label2.Text = "الخصم:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Droid Arabic Kufi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(84, 98);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(327, 68);
            this.txtDiscount.TabIndex = 434;
            this.txtDiscount.Text = "1";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(21, 29);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 28);
            this.label12.TabIndex = 430;
            this.label12.Text = "الكمية:";
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Droid Arabic Kufi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(84, 11);
            this.txtQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(327, 59);
            this.txtQty.TabIndex = 429;
            this.txtQty.Text = "1";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnClose.Location = new System.Drawing.Point(84, 170);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(327, 44);
            this.btnClose.TabIndex = 431;
            this.btnClose.Text = "للحفظ والطباعة اضغط انتر";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Frm_EditRawQty
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(435, 233);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtQty);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_EditRawQty";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل الكمية والخصم";
            this.Load += new System.EventHandler(this.Frm_EditRawQty_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_EditRawQty_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiscount;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQty;
    }
}
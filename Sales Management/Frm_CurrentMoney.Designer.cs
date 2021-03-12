namespace Sales_Management
{
    partial class Frm_CurrentMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CurrentMoney));
            this.lblCurrentMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentMoneybank = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCurrentMoney
            // 
            this.lblCurrentMoney.AutoSize = true;
            this.lblCurrentMoney.Location = new System.Drawing.Point(299, 76);
            this.lblCurrentMoney.Name = "lblCurrentMoney";
            this.lblCurrentMoney.Size = new System.Drawing.Size(32, 28);
            this.lblCurrentMoney.TabIndex = 357;
            this.lblCurrentMoney.Text = "....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 36);
            this.label1.TabIndex = 356;
            this.label1.Text = "رصيد الخزنة المحدده هو :";
            // 
            // lblCurrentMoneybank
            // 
            this.lblCurrentMoneybank.AutoSize = true;
            this.lblCurrentMoneybank.Location = new System.Drawing.Point(299, 115);
            this.lblCurrentMoneybank.Name = "lblCurrentMoneybank";
            this.lblCurrentMoneybank.Size = new System.Drawing.Size(32, 28);
            this.lblCurrentMoneybank.TabIndex = 355;
            this.lblCurrentMoneybank.Text = "....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(77, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 36);
            this.label6.TabIndex = 354;
            this.label6.Text = "رصيد البنك الحالى:";
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
            this.btnSearch.Location = new System.Drawing.Point(29, 182);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 46);
            this.btnSearch.TabIndex = 395;
            this.btnSearch.Text = "ايداع رصيد للخزنه";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button1
            // 
            this.button1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Appearance.Options.UseFont = true;
            this.button1.Appearance.Options.UseTextOptions = true;
            this.button1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.button1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.button1.Location = new System.Drawing.Point(213, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 46);
            this.button1.TabIndex = 396;
            this.button1.Text = "ايداع رصيد فى البنك";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 398;
            this.label4.Text = "اختر خزنه:";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(98, 12);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(293, 36);
            this.cbxType.TabIndex = 397;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // Frm_CurrentMoney
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(403, 241);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblCurrentMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrentMoneybank);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CurrentMoney";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رصيد الخزنه والبنك الحالى";
            this.Load += new System.EventHandler(this.Frm_CurrentMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentMoneybank;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxType;
    }
}
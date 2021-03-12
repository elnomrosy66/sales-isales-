namespace Sales_Management
{
    partial class sup_dept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sup_dept));
            this.label2 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxSuplier = new System.Windows.Forms.ComboBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.money)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(99, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 506;
            this.label2.Text = "الرصيد";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // money
            // 
            this.money.DecimalPlaces = 3;
            this.money.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money.Location = new System.Drawing.Point(178, 156);
            this.money.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(157, 29);
            this.money.TabIndex = 505;
            this.money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(99, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 504;
            this.label5.Text = "العميل:";
            // 
            // cbxSuplier
            // 
            this.cbxSuplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSuplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSuplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSuplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxSuplier.FormattingEnabled = true;
            this.cbxSuplier.Location = new System.Drawing.Point(178, 95);
            this.cbxSuplier.Name = "cbxSuplier";
            this.cbxSuplier.Size = new System.Drawing.Size(157, 32);
            this.cbxSuplier.TabIndex = 503;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseTextOptions = true;
            this.btnSave.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSave.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSave.Location = new System.Drawing.Point(178, 218);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 57);
            this.btnSave.TabIndex = 507;
            this.btnSave.Text = "إضافة";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // sup_dept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 370);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxSuplier);
            this.Name = "sup_dept";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "رصيد افتتاحي موردين";
            this.Load += new System.EventHandler(this.sup_dept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.money)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown money;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxSuplier;
    }
}
namespace Sales_Management
{
    partial class Frm_Item_Requers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DtbSaleDate = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.DgvSearchBuy = new System.Windows.Forms.DataGridView();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblYesOrNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // DtbSaleDate
            // 
            this.DtbSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbSaleDate.Location = new System.Drawing.Point(12, 38);
            this.DtbSaleDate.Name = "DtbSaleDate";
            this.DtbSaleDate.Size = new System.Drawing.Size(198, 36);
            this.DtbSaleDate.TabIndex = 353;
            this.DtbSaleDate.Value = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            this.DtbSaleDate.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.labelControl1.Location = new System.Drawing.Point(300, -2);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(373, 40);
            this.labelControl1.TabIndex = 354;
            this.labelControl1.Text = "المنتجات التى وصلت الى  الحد االدنى";
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
            this.DgvSearchBuy.Location = new System.Drawing.Point(12, 40);
            this.DgvSearchBuy.Name = "DgvSearchBuy";
            this.DgvSearchBuy.ReadOnly = true;
            this.DgvSearchBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearchBuy.Size = new System.Drawing.Size(962, 380);
            this.DgvSearchBuy.TabIndex = 355;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.Color.Red;
            this.lblCount.Location = new System.Drawing.Point(7, 420);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(32, 28);
            this.lblCount.TabIndex = 356;
            this.lblCount.Text = "....";
            // 
            // lblYesOrNo
            // 
            this.lblYesOrNo.AutoSize = true;
            this.lblYesOrNo.ForeColor = System.Drawing.Color.Red;
            this.lblYesOrNo.Location = new System.Drawing.Point(458, 420);
            this.lblYesOrNo.Name = "lblYesOrNo";
            this.lblYesOrNo.Size = new System.Drawing.Size(0, 28);
            this.lblYesOrNo.TabIndex = 357;
            // 
            // Frm_Item_Requers
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseTextOptions = true;
            this.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(986, 454);
            this.Controls.Add(this.lblYesOrNo);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.DgvSearchBuy);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.DtbSaleDate);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_Item_Requers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نواقص الاصناف";
            this.Load += new System.EventHandler(this.Frm_Item_Requers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtbSaleDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView DgvSearchBuy;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblYesOrNo;
    }
}
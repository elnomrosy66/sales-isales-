namespace Sales_Management
{
    partial class Frm_Employee_Borrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Employee_Borrow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textParcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtbDate = new System.Windows.Forms.DateTimePicker();
            this.NudQty = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbxEmployee = new System.Windows.Forms.ComboBox();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.textParcode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DtbDate);
            this.groupBox1.Controls.Add(this.NudQty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.cbxEmployee);
            this.groupBox1.Controls.Add(this.cbxItems);
            this.groupBox1.Location = new System.Drawing.Point(9, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 169);
            this.groupBox1.TabIndex = 349;
            this.groupBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(309, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 28);
            this.label17.TabIndex = 359;
            this.label17.Text = "بحث بالباركود:";
            // 
            // textParcode
            // 
            this.textParcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textParcode.ForeColor = System.Drawing.Color.Blue;
            this.textParcode.Location = new System.Drawing.Point(9, 24);
            this.textParcode.Name = "textParcode";
            this.textParcode.Size = new System.Drawing.Size(297, 36);
            this.textParcode.TabIndex = 358;
            this.textParcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textParcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textParcode_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(312, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "تاريخ السحب:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(312, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 347;
            this.label2.Text = "الكمية المسحوبة:";
            // 
            // DtbDate
            // 
            this.DtbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtbDate.Location = new System.Drawing.Point(9, 66);
            this.DtbDate.Name = "DtbDate";
            this.DtbDate.Size = new System.Drawing.Size(297, 36);
            this.DtbDate.TabIndex = 11;
            // 
            // NudQty
            // 
            this.NudQty.DecimalPlaces = 2;
            this.NudQty.Location = new System.Drawing.Point(9, 108);
            this.NudQty.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NudQty.Name = "NudQty";
            this.NudQty.Size = new System.Drawing.Size(297, 36);
            this.NudQty.TabIndex = 346;
            this.NudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(733, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "رقم العملية:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(736, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 31);
            this.label5.TabIndex = 344;
            this.label5.Text = "اختراسم الموظف:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(738, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 345;
            this.label1.Text = "اختر المنتج:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(472, 24);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(258, 36);
            this.txtID.TabIndex = 3;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxEmployee
            // 
            this.cbxEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEmployee.FormattingEnabled = true;
            this.cbxEmployee.Location = new System.Drawing.Point(472, 108);
            this.cbxEmployee.Name = "cbxEmployee";
            this.cbxEmployee.Size = new System.Drawing.Size(261, 36);
            this.cbxEmployee.TabIndex = 175;
            // 
            // cbxItems
            // 
            this.cbxItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(472, 66);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(259, 36);
            this.cbxItems.TabIndex = 174;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.labelControl1.Location = new System.Drawing.Point(276, 4);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(340, 40);
            this.labelControl1.TabIndex = 364;
            this.labelControl1.Text = "المسحوبات من الموظف ( منتجات)";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Appearance.Options.UseTextOptions = true;
            this.btnUpdate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnUpdate.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnUpdate.Location = new System.Drawing.Point(301, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(295, 49);
            this.btnUpdate.TabIndex = 365;
            this.btnUpdate.Text = "حفظ العملية";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Frm_Employee_Borrow
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(897, 280);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Employee_Borrow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المسحوبات من الموظف ( منتجات)";
            this.Load += new System.EventHandler(this.Frm_Employee_Borrow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textParcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtbDate;
        private System.Windows.Forms.NumericUpDown NudQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbxEmployee;
        private System.Windows.Forms.ComboBox cbxItems;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
    }
}
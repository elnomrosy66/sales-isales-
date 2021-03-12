namespace Sales_Management
{
    partial class Frm_Store_Gard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Store_Gard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxStorea = new System.Windows.Forms.ComboBox();
            this.rbtnOneStore = new System.Windows.Forms.RadioButton();
            this.rbtnAllStore = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRbh7 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTotalSale = new System.Windows.Forms.TextBox();
            this.DgvBuyDetalis = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textParcode = new System.Windows.Forms.TextBox();
            this.txtTotalBuy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuyDetalis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Appearance.Options.UseTextOptions = true;
            this.btnSearch.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSearch.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSearch.Location = new System.Drawing.Point(486, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(276, 39);
            this.btnSearch.TabIndex = 369;
            this.btnSearch.Text = "جرد جميع الاصناف فى مخزن محدد";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxStorea);
            this.groupBox2.Controls.Add(this.rbtnOneStore);
            this.groupBox2.Controls.Add(this.rbtnAllStore);
            this.groupBox2.Location = new System.Drawing.Point(12, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 69);
            this.groupBox2.TabIndex = 375;
            this.groupBox2.TabStop = false;
            // 
            // cbxStorea
            // 
            this.cbxStorea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStorea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStorea.FormattingEnabled = true;
            this.cbxStorea.Location = new System.Drawing.Point(44, 25);
            this.cbxStorea.Name = "cbxStorea";
            this.cbxStorea.Size = new System.Drawing.Size(204, 23);
            this.cbxStorea.TabIndex = 350;
            // 
            // rbtnOneStore
            // 
            this.rbtnOneStore.AutoSize = true;
            this.rbtnOneStore.Location = new System.Drawing.Point(261, 25);
            this.rbtnOneStore.Name = "rbtnOneStore";
            this.rbtnOneStore.Size = new System.Drawing.Size(72, 19);
            this.rbtnOneStore.TabIndex = 350;
            this.rbtnOneStore.Text = "مخزن محدد";
            this.rbtnOneStore.UseVisualStyleBackColor = true;
            // 
            // rbtnAllStore
            // 
            this.rbtnAllStore.AutoSize = true;
            this.rbtnAllStore.Checked = true;
            this.rbtnAllStore.Location = new System.Drawing.Point(351, 24);
            this.rbtnAllStore.Name = "rbtnAllStore";
            this.rbtnAllStore.Size = new System.Drawing.Size(72, 19);
            this.rbtnAllStore.TabIndex = 350;
            this.rbtnAllStore.TabStop = true;
            this.rbtnAllStore.Text = "كل المخازن";
            this.rbtnAllStore.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(2, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 373;
            this.label2.Text = "الارباح المتوقعه:";
            // 
            // txtRbh7
            // 
            this.txtRbh7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRbh7.ForeColor = System.Drawing.Color.Blue;
            this.txtRbh7.Location = new System.Drawing.Point(128, 545);
            this.txtRbh7.Name = "txtRbh7";
            this.txtRbh7.ReadOnly = true;
            this.txtRbh7.Size = new System.Drawing.Size(192, 21);
            this.txtRbh7.TabIndex = 372;
            this.txtRbh7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(700, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 15);
            this.label17.TabIndex = 371;
            this.label17.Text = "ابحث بالباركود:";
            // 
            // txtTotalSale
            // 
            this.txtTotalSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalSale.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalSale.Location = new System.Drawing.Point(1014, 536);
            this.txtTotalSale.Name = "txtTotalSale";
            this.txtTotalSale.ReadOnly = true;
            this.txtTotalSale.Size = new System.Drawing.Size(192, 21);
            this.txtTotalSale.TabIndex = 367;
            this.txtTotalSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DgvBuyDetalis
            // 
            this.DgvBuyDetalis.AllowUserToAddRows = false;
            this.DgvBuyDetalis.AllowUserToDeleteRows = false;
            this.DgvBuyDetalis.AllowUserToResizeColumns = false;
            this.DgvBuyDetalis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBuyDetalis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvBuyDetalis.BackgroundColor = System.Drawing.Color.White;
            this.DgvBuyDetalis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBuyDetalis.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvBuyDetalis.Location = new System.Drawing.Point(5, 144);
            this.DgvBuyDetalis.Name = "DgvBuyDetalis";
            this.DgvBuyDetalis.ReadOnly = true;
            this.DgvBuyDetalis.RowHeadersVisible = false;
            this.DgvBuyDetalis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvBuyDetalis.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvBuyDetalis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBuyDetalis.Size = new System.Drawing.Size(886, 396);
            this.DgvBuyDetalis.TabIndex = 364;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(355, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 18);
            this.label5.TabIndex = 366;
            this.label5.Text = "اجمالى مبلغ المنتجات(مبلغ الشراء):";
            // 
            // textParcode
            // 
            this.textParcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textParcode.ForeColor = System.Drawing.Color.Blue;
            this.textParcode.Location = new System.Drawing.Point(776, 85);
            this.textParcode.Name = "textParcode";
            this.textParcode.Size = new System.Drawing.Size(113, 21);
            this.textParcode.TabIndex = 370;
            this.textParcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textParcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textParcode_KeyPress);
            // 
            // txtTotalBuy
            // 
            this.txtTotalBuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalBuy.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalBuy.Location = new System.Drawing.Point(740, 546);
            this.txtTotalBuy.Name = "txtTotalBuy";
            this.txtTotalBuy.ReadOnly = true;
            this.txtTotalBuy.Size = new System.Drawing.Size(171, 21);
            this.txtTotalBuy.TabIndex = 365;
            this.txtTotalBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(560, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 368;
            this.label1.Text = "اجمالى مبلغ المنتجات(مبلغ البيع):";
            // 
            // cbxItems
            // 
            this.cbxItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(409, 78);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(223, 32);
            this.cbxItems.TabIndex = 423;
            this.cbxItems.SelectedIndexChanged += new System.EventHandler(this.cbxItems_SelectedIndexChanged);
            this.cbxItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxItems_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseTextOptions = true;
            this.btnAdd.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnAdd.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAdd.Location = new System.Drawing.Point(641, 81);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 31);
            this.btnAdd.TabIndex = 424;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Frm_Store_Gard
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(975, 589);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxItems);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRbh7);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtTotalSale);
            this.Controls.Add(this.DgvBuyDetalis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textParcode);
            this.Controls.Add(this.txtTotalBuy);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_Store_Gard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جرد المخازن";
            this.Load += new System.EventHandler(this.Frm_Store_Gard_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuyDetalis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxStorea;
        private System.Windows.Forms.RadioButton rbtnOneStore;
        private System.Windows.Forms.RadioButton rbtnAllStore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRbh7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTotalSale;
        private System.Windows.Forms.DataGridView DgvBuyDetalis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textParcode;
        private System.Windows.Forms.TextBox txtTotalBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxItems;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}
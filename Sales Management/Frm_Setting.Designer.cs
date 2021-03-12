namespace Sales_Management
{
    partial class Frm_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Setting));
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "الباسورد:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(155, 226);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(328, 36);
            this.txtPassword.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "اسم المستخدم:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(155, 174);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(328, 36);
            this.txtID.TabIndex = 16;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(157, 283);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(255, 32);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "عدم اظهار هذه الشاشة مره اخرى";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "قاعدة البيانات:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(155, 122);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(328, 36);
            this.txtDatabase.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "اسم السيرفر:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(155, 68);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(328, 36);
            this.txtServer.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(186, 9);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(164, 40);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "اعدادات السيرفر";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseTextOptions = true;
            this.btnSave.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSave.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSave.Location = new System.Drawing.Point(183, 331);
            this.btnSave.LookAndFeel.SkinName = "Seven Classic";
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(227, 47);
            this.btnSave.TabIndex = 253;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Frm_Setting
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseTextOptions = true;
            this.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(524, 400);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServer);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Setting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "اعدادت السيرفر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}
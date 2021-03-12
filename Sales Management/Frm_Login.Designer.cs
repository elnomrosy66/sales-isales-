namespace Sales_Management
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.txtUSERNAME = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnUser = new System.Windows.Forms.RadioButton();
            this.rbtnManager = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Button1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUSERNAME
            // 
            this.txtUSERNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUSERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUSERNAME.ForeColor = System.Drawing.Color.Blue;
            this.txtUSERNAME.Location = new System.Drawing.Point(14, 76);
            this.txtUSERNAME.Name = "txtUSERNAME";
            this.txtUSERNAME.Size = new System.Drawing.Size(221, 24);
            this.txtUSERNAME.TabIndex = 0;
            this.txtUSERNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUSERNAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUSERNAME_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.ForeColor = System.Drawing.Color.Blue;
            this.txtPassword.Location = new System.Drawing.Point(14, 146);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(221, 24);
            this.txtPassword.TabIndex = 239;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(56, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 238;
            this.label2.Text = "ادخل اسم المستخدم";
            // 
            // rbtnUser
            // 
            this.rbtnUser.AutoSize = true;
            this.rbtnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUser.ForeColor = System.Drawing.Color.Blue;
            this.rbtnUser.Location = new System.Drawing.Point(138, 12);
            this.rbtnUser.Name = "rbtnUser";
            this.rbtnUser.Size = new System.Drawing.Size(59, 22);
            this.rbtnUser.TabIndex = 237;
            this.rbtnUser.Text = "موظف";
            this.rbtnUser.UseVisualStyleBackColor = true;
            // 
            // rbtnManager
            // 
            this.rbtnManager.AutoSize = true;
            this.rbtnManager.Checked = true;
            this.rbtnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnManager.ForeColor = System.Drawing.Color.Blue;
            this.rbtnManager.Location = new System.Drawing.Point(61, 12);
            this.rbtnManager.Name = "rbtnManager";
            this.rbtnManager.Size = new System.Drawing.Size(48, 22);
            this.rbtnManager.TabIndex = 236;
            this.rbtnManager.TabStop = true;
            this.rbtnManager.Text = "مدير";
            this.rbtnManager.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(56, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 235;
            this.label1.Text = "ادخل كلمة السر للنظام";
            // 
            // Button1
            // 
            this.Button1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Appearance.Options.UseFont = true;
            this.Button1.Appearance.Options.UseTextOptions = true;
            this.Button1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Button1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.Button1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Button1.ImageOptions.Image")));
            this.Button1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.Button1.Location = new System.Drawing.Point(14, 188);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(221, 47);
            this.Button1.TabIndex = 250;
            this.Button1.Text = "دخول";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton1.Location = new System.Drawing.Point(241, 188);
            this.simpleButton1.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(268, 47);
            this.simpleButton1.TabIndex = 252;
            this.simpleButton1.Text = "خروج";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sales_Management.Properties.Resources.logo_i_sales;
            this.pictureBox1.Location = new System.Drawing.Point(241, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 251;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Frm_Login
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(521, 246);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbtnUser);
            this.Controls.Add(this.rbtnManager);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtUSERNAME);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الدخول للنظام";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUSERNAME;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnUser;
        private System.Windows.Forms.RadioButton rbtnManager;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton Button1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Principal;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;

namespace Sales_Management
{
    public partial class Frm_Login : DevExpress.XtraEditors.XtraForm
    {
        Thread t;
        public Frm_Login()
        {
            // Create Thread 
            
            try
            {
                 t = new Thread(new ThreadStart(StartSplash));
                t.Start();
                Thread.Sleep(1000);
            }
            catch (Exception) { }

            InitializeComponent();

            // Teeminate the Thread
            try
            {
                t.Abort();
            }
            catch (Exception) { }
        }

        // Method To Start Splash For
        private void StartSplash()
        {
            try
            {
                Application.Run(new SplashScreen2());
            }
            catch (Exception) { }
        }


        DB db = new DB();
        DataTable tbl = new DataTable();
        int introw = 0;


        private bool ISDBExisits()
        {


            bool exist = false;
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLExpress;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("", conn);
            try
            {


                SqlDataReader rdr;
                cmd.CommandText = "exec sys.sp_databases";
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr.GetString(0) == "Sales_StandardV2")
                    {
                        exist = true;
                        break;
                    }

                }

                conn.Close();
                rdr.Dispose();
                cmd.Dispose();
                conn.Dispose();


            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); return false; conn.Close(); }

            return exist;


        }

        private bool GrantAccess(string fullPath)
        {
            DirectoryInfo dInfo = new DirectoryInfo(fullPath);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);
            return true;
        }

        public void createDatabase()
        {

            if (check() == false)
            {
                try
                {
                    var fileContent = File.ReadAllText(Application.StartupPath + @"\sqlscript.sql");
                    var sqlqueries = fileContent.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

                    var con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security=True");
                    var cmd = new SqlCommand("query", con);
                    con.Open();

                    foreach (var query in sqlqueries)
                    {
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                catch (Exception) { }
            }
        }

        private bool check()
        {
            bool exist = false;
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.\SQLExpress;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("", conn);
                SqlDataReader rdr;
                cmd.CommandText = "exec sys.sp_databases";
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr.GetString(0) == "Sales_StandardV2")
                    {
                        exist = true;
                        break;
                    }

                }

                conn.Close();
                rdr.Dispose();
                cmd.Dispose();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }

            return exist;

        }



        private bool Trial()
        {
            try
            {

                int day = Properties.Settings.Default.T;
                int thisday = day + 1;
                Properties.Settings.Default.T = thisday;
                Properties.Settings.Default.Save();
                if (thisday >= 80)
                {
                    MessageBox.Show("تم انتهاء النسخه التجريبيه للبرنامج  ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    int baky = 80 - thisday;
                    MessageBox.Show(" هذه نسخه تجربيبه باقى عدد مرات لفتح البرنامج " + baky + " مره", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception) { }
            return true;
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            try
            {
                createDatabase();
            }
            catch (Exception) { }
            txtUSERNAME.Clear();
            txtPassword.Focus();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            DataTable tblUser = new DataTable();
            tblUser.Clear();
           // Properties.Settings.Default.Reset();
            if (Properties.Settings.Default.ProductKey == "NO")
            {
                Frm_Serial frm = new Frm_Serial();
                frm.ShowDialog();
            }
            else
            {
                tbl.Clear();
                tblUser = db.RunReader("select * from Users", "");
                if (tblUser.Rows.Count <= 0)
                {

                    db.RunNunQuary("INSERT INTO [Users] ([ID],[Password],[UserName],[Type],[Stock_ID] ,[Rbh7]) VALUES(1,'123','123','مدير',1,5)", "");
                    db.RunNunQuary("insert into Users_Setting Values (1,1,1,1,1,1,1,1,1,1,1,1)", "");
                    db.RunNunQuary("insert into Users_Suplier Values (1 ,1,1,1)", "");
                    db.RunNunQuary("insert into Users_Customer Values (1 ,1,1,1)", "");
                    db.RunNunQuary("insert into Users_Buy Values (1,1,1)", "");
                    db.RunNunQuary("insert into Users_Sale Values (1,1,1,1,1)", "");
                    db.RunNunQuary("insert into Users_Return Values (1 ,1,1)", "");
                    db.RunNunQuary("insert into Users_Deserved Values (1,1,1,1,1,1,1,1)", "");
                    db.RunNunQuary("insert into Users_Emplyee Values (1 ,1,1,1,1,1,1,1)", "");
                    db.RunNunQuary("insert into Users_StockBank Values (1 ,1,1,1,1,1,1,1,1,1)", "");
                    db.RunNunQuary("insert into Users_BackUp Values (1 ,1,1)", "");
                    db.RunNunQuary("INSERT INTO [Trial] VALUES (0)", "");
                    db.RunNunQuary("insert into RandomBarcode Values(10000000)", "");
                }
                tbl.Clear();
                tblUser = db.RunReader("select * from Stock_Data", "");
                if (tblUser.Rows.Count <= 0)
                {
                    db.RunNunQuary("insert into Stock_Data values (1,N'الخزنة الرئيسية')", "");
                    db.RunNunQuary("insert into Stock values (0,1)", "");
              
                }
                if (txtPassword.Text == "")
                { MessageBox.Show("من فضلك ادخل كلمة السر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                if (txtUSERNAME.Text == "")
                { MessageBox.Show("من فضلك ادخل اسم المستخدم ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                if (rbtnManager.Checked == true)
                    tbl = db.RunReader("select * from Users where Password =N'" + txtPassword.Text + "' and UserName='" + txtUSERNAME.Text + "' and  Type=N'مدير'", "");
                else
                    tbl = db.RunReader("select * from Users where Password =N'" + txtPassword.Text + "' and UserName='" + txtUSERNAME.Text + "' and Type=N'مستخدم عادى'", "");

                if (tbl.Rows.Count >= 1)
                {
                    //bool check = Trial();
                    //if (check)
                    //{
                        if (rbtnManager.Checked == true)
                    {
                        Properties.Settings.Default.UserType = "مدير";
                    }
                    else {
                        Properties.Settings.Default.UserType = "مستخدم";
                    }
                    Properties.Settings.Default.UserName = txtUSERNAME.Text;
                    Properties.Settings.Default.UserStock = tbl.Rows[0][4].ToString();
                    Properties.Settings.Default.Save();
                    this.Hide();
                    Frm_Home frm = new Frm_Home();
                    frm.ShowDialog();
                //}
                //else { return; }


                }
                else
                {
                    MessageBox.Show("كلمة السر او اسم المستخدم خطأ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtUSERNAME.Clear();
                    txtUSERNAME.Focus();
                }
            }
        }

        private void txtUSERNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Button1_Click(null, null);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
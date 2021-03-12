using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Threading;
using Microsoft.SqlServer.Management.Smo;

namespace Sales_Management
{
    public partial class Frm_Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Frm_Home()
        {
             
            InitializeComponent();

        }


       
        

        private void Frm_Home_Load(object sender, EventArgs e)
        {
            this.barStaticItem1.Caption = "اسم المستخدم" + " | " + Properties.Settings.Default.UserName;
            this.barStaticItem3.Caption = "التاريخ" + " | " + DateTime.Now.Date.ToShortDateString();
            Frm_Home_LoadExtracted();
        }

        private void Frm_Home_LoadExtracted()
        {
            Frm_Home_LoadExtractedExtracted();
        }

        private void Frm_Home_LoadExtractedExtracted()
        {
           
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            this.barStaticItem4.Caption = " الوقت الحالى" + " : " + DateTime.Now.ToLongTimeString(); 
         
        }


        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select UserPermisson from Users_Setting where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_NewPass frm = new Frm_NewPass();
            frm.Show();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Sale from Users_Sale where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_SalesSuperMarket frm = new Frm_SalesSuperMarket();
            frm.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select ItemsView from Users_Setting where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Items_View frm = new Frm_Items_View();
            frm.Show();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select UserPermisson from Users_Setting where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_NewPass frm = new Frm_NewPass();
            frm.Show();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select CurrentMoney from Users_StockBank where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_CurrentMoney frm = new Frm_CurrentMoney();
            frm.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select ItemsGroup from Users_Setting where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Items_Group frm = new Frm_Items_Group();
            frm.Show();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select ItemsView from Users_Setting where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Items frm = new Frm_Items();
            frm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Suplier from Users_Suplier where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }

            Frm_Suplier frm = new Frm_Suplier();
            frm.Show();
        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Suplier_Money from Users_Suplier where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_SuplierMoney frm = new Frm_SuplierMoney();
              frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Suplier_Money from Users_Suplier where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_SuplierMoney frm = new Frm_SuplierMoney();
            frm.Show();
        }

        private void tileItem6_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Customer_Money from Users_Customer where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_CustomerMoney frm = new Frm_CustomerMoney();
            frm.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Supliey_MoneyReport from Users_Suplier where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Suplier_Report frm = new Frm_Suplier_Report();
            frm.Show();
        }

        private void tileItem7_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Sale from Users_Sale where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_SalesSuperMarket frm = new Frm_SalesSuperMarket();
            frm.Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Customer from Users_Customer where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }

            Frm_Customer frm = new Frm_Customer();
            frm.Show();
        }

        private void tileItem8_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_Customer frm = new Frm_Customer();
            frm.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Customer_Money from Users_Customer where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_CustomerMoney frm = new Frm_CustomerMoney();
            frm.Show();
        }

        private void tileItem9_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_CustomerMoney frm = new Frm_CustomerMoney();
            frm.Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Customer_Kest frm = new Frm_Customer_Kest();
            frm.Show();
        }

        private void tileItem10_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_Customer_Kest frm = new Frm_Customer_Kest();
            frm.Show();
        }

        private void tileItem11_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_Customer_Report frm = new Frm_Customer_Report();
            frm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {

            Frm_Customer_Report frm = new Frm_Customer_Report();
            frm.Show();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Sale_Report from Users_Sale where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_SalesReport frm = new Frm_SalesReport();
            frm.ShowDialog();
        }

        private void tileItem16_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_SalesReport frm = new Frm_SalesReport();
            frm.ShowDialog();
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Items_Gard from Users_Sale where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_ItemReport frm = new Frm_ItemReport();
            frm.ShowDialog();
        }

        private void tileItem15_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Sale_ReportRp7h from Users_Sale where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_SalesRbh7Report frm = new Frm_SalesRbh7Report();
            frm.ShowDialog();
        
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Return frm = new Frm_Return();
            frm.ShowDialog();
        }

        private void tileItem17_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_Return frm = new Frm_Return();
            frm.ShowDialog();
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReturnReport frm = new Frm_ReturnReport();
            frm.ShowDialog();
        }

        private void tileItem18_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_ReturnReport frm = new Frm_ReturnReport();
            frm.ShowDialog();
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Deserved_Type from Users_Deserved where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_DeservedType frm = new Frm_DeservedType();
            frm.ShowDialog();
        }

        private void tileItem19_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_DeservedType frm = new Frm_DeservedType();
            frm.ShowDialog();
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Deserved from Users_Deserved where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Deserved frm = new Frm_Deserved();
            frm.ShowDialog();
        }

        private void tileItem20_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_Deserved frm = new Frm_Deserved();
            frm.ShowDialog();
        }
       
        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Deserved_Report from Users_Deserved where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_DeservedReport frm = new Frm_DeservedReport();
            frm.ShowDialog();
        }

        private void tileItem21_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_DeservedReport frm = new Frm_DeservedReport();
            frm.ShowDialog();
        }

        private void barButtonItem60_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Reports from Users_StockBank where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Stock_AddMoney_Report frm = new Frm_Stock_AddMoney_Report();
            frm.ShowDialog();
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_CustomerMoneyRent frm = new Frm_CustomerMoneyRent();
            frm.ShowDialog();
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Customer_MoneyReport from Users_Customer where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Customer_Report frm = new Frm_Customer_Report();
            frm.ShowDialog();
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ProblemMoneyReport frm = new Frm_ProblemMoneyReport();
            frm.ShowDialog();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Buy from Users_Buy where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_BuySuperMarket frm = new Frm_BuySuperMarket();
            frm.ShowDialog();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Buy_Report from Users_Buy where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_BuyReport frm = new Frm_BuyReport();
            frm.ShowDialog();
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Items_SalesBuys frm = new Frm_Items_SalesBuys();
            frm.ShowDialog();
        }

        private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Items_Top20 frm = new Frm_Items_Top20();
            frm.ShowDialog();
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Rent_Data frm = new Frm_Rent_Data();
            frm.ShowDialog();
        }

        private void barButtonItem35_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Rent_Report frm = new Frm_Rent_Report();
            frm.ShowDialog();
        }

        private void barButtonItem4_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem37_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Gard frm = new Frm_Gard();
            frm.ShowDialog();
        }

        private void barButtonItem38_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Emplyee_Add from Users_Emplyee where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Employee frm = new Frm_Employee();
            frm.ShowDialog();
        }

        private void barButtonItem39_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Emplyee_Borrow from Users_Emplyee where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Employee_Borrow frm = new Frm_Employee_Borrow();
            frm.ShowDialog();
        }

        private void barButtonItem40_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Emplyee_Salary from Users_Emplyee where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Employee_Salaray frm = new Frm_Employee_Salaray();
            frm.ShowDialog();
        }

        private void barButtonItem41_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Emplyee_BorrowMoney from Users_Emplyee where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Borrow_Money frm = new Frm_Borrow_Money();
            frm.ShowDialog();
        }

        private void barButtonItem42_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Emplyee_SalaryReport from Users_Emplyee where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Employee_Salaray_Report frm = new Frm_Employee_Salaray_Report();
            frm.ShowDialog();
        }

        private void barButtonItem43_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Emplyee_BorrowMoneyReport from Users_Emplyee where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Borrow_Money_Report frm = new Frm_Borrow_Money_Report();
            frm.ShowDialog();
        }

        private void barButtonItem44_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Emplyee_BorrowReport from Users_Emplyee where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Employee_Borrow_Rport frm = new Frm_Employee_Borrow_Rport();
            frm.ShowDialog();
        }

        private void barButtonItem45_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Stock_Insert from Users_StockBank where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Stock_AddMoney frm = new Frm_Stock_AddMoney();
            frm.ShowDialog();
        }

        private void barButtonItem46_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Bank_AddMoney frm = new Frm_Bank_AddMoney();
            frm.ShowDialog();
        }

        private void barButtonItem47_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Stock_Pull from Users_StockBank where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Stock_PullMoney frm = new Frm_Stock_PullMoney();
            frm.ShowDialog();
        }

        private void barButtonItem48_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Bank_Pull from Users_StockBank where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Bank_PullMoney frm = new Frm_Bank_PullMoney();
            frm.ShowDialog();
        }

        private void barButtonItem49_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Stock_BankTransfire from Users_StockBank where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Transfire_StockBank frm = new Frm_Transfire_StockBank();
            frm.ShowDialog();
        }

        private void barButtonItem50_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select CurrentMoney from Users_StockBank where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_CurrentMoney frm = new Frm_CurrentMoney();
            frm.ShowDialog();
        }

        private void barButtonItem61_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Reports from Users_StockBank where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Bank_AddMoney_Report frm = new Frm_Bank_AddMoney_Report();
            frm.ShowDialog();
        }

        private void barButtonItem62_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Reports from Users_StockBank where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Stock_PullMoney_Report frm = new Frm_Stock_PullMoney_Report();
            frm.ShowDialog();
        }

        private void barButtonItem63_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Reports from Users_StockBank where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Bank_PullMoney_Report frm = new Frm_Bank_PullMoney_Report();
            frm.ShowDialog();
        }

        private void barButtonItem64_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Reports from Users_StockBank where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Transfire_StockBank_Report frm = new Frm_Transfire_StockBank_Report();
            frm.ShowDialog();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem37_ItemClick_1(object sender, ItemClickEventArgs e)
        {try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Bank_Insert from Users_StockBank where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Bank_AddMoney frm = new Frm_Bank_AddMoney();
            frm.ShowDialog();
        }

        private void barButtonItem65_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Stock_Add from Users_StockBank where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Stock frm = new Frm_Stock();
            frm.ShowDialog();
        }

        private void barButtonItem66_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Stock_Transfire from Users_StockBank where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_StockTransfire frm = new Frm_StockTransfire();
            frm.ShowDialog();
        }

        private void barButtonItem68_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Sanad_Kabd from Users_Deserved where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_SanadKabd frm = new Frm_SanadKabd();
            frm.ShowDialog();
        }

        private void barButtonItem70_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Sanad_Sarf from Users_Deserved where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_SanadSarf frm = new Frm_SanadSarf();
            frm.ShowDialog();
        }

        private void barButtonItem71_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Sanad_Report from Users_Deserved where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_SanadKabdSarfReport frm = new Frm_SanadKabdSarfReport();
            frm.ShowDialog();
        }

        private void barButtonItem72_ItemClick(object sender, ItemClickEventArgs e)
        {
            try {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='"+Properties.Settings.Default.UserName+"'", "");
                tbl = db.RunReader("select Program_Setting from Users_Setting where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!","تاكيد",MessageBoxButtons.OK,MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_PrinterSetting frm = new Frm_PrinterSetting();
            frm.ShowDialog();
        }

        private void barButtonItem73_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Taxes_Report from Users_Deserved where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_TaxesReport frm = new Frm_TaxesReport();
            frm.ShowDialog();
        }

        private void barStaticItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem75_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Return_ from Users_Return where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Return frm = new Frm_Return();
            frm.ShowDialog();
        }

        private void barButtonItem76_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Return_Report from Users_Return where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_ReturnReport frm = new Frm_ReturnReport();
            frm.ShowDialog();
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            //try
            //{
            //    DataTable tbl = new DataTable();
            //    tbl.Clear(); DataTable tbluser = new DataTable();
            //    tbluser.Clear();
            //    tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
            //    tbl = db.RunReader("select Return_ from Users_Return where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
            //    if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
            //    { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            //}
            //catch (Exception) { }
            Frm_ExpierdItems frm = new Frm_ExpierdItems();
            frm.ShowDialog();
        }

        private void barButtonItem78_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select AddStore from Users_Setting where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            
            Frm_Store frm = new Frm_Store();
            frm.ShowDialog();
        }

        private void barButtonItem82_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Units from Users_Setting where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Unit frm = new Frm_Unit();
            frm.ShowDialog();
        }

        private void barButtonItem83_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Sale_ReportRp7h from Users_Sale where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_SalesRbh7Report frm = new Frm_SalesRbh7Report();
            frm.ShowDialog();
        }

        private void barButtonItem79_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select GardStore from Users_Setting where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Store_Gard frm = new Frm_Store_Gard();
            frm.ShowDialog();
        }

        private void barButtonItem80_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select ItemsTransfire from Users_Setting where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Store_Transfire frm = new Frm_Store_Transfire();
            frm.ShowDialog();
        }

        private void barButtonItem84_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select ItemsTransfire_Report from Users_Setting where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_Store_TransfireReport frm = new Frm_Store_TransfireReport();
            frm.ShowDialog();
        }

        private void barButtonItem85_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select ItemsOutStore from Users_Setting where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_ItemsOutStore frm = new Frm_ItemsOutStore();
            frm.ShowDialog();
        }

        private void barButtonItem86_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select ItemsOutStore_Report from Users_Setting where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_ItemsOutStoreReport frm = new Frm_ItemsOutStoreReport();
            frm.ShowDialog();
        }

        private void tileItem12_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Buy from Users_Buy where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception) { }
            Frm_BuySuperMarket frm = new Frm_BuySuperMarket();
            frm.ShowDialog();
        }

        private void tileItem14_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_Item_Requers frm = new Frm_Item_Requers();
            frm.ShowDialog();
        }
        DB db = new DB();
        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            backup();


        }
        void backup()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Take_Backup from Users_BackUp where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


            try
            {
                string d = DateTime.Now.Date.ToString("dd-MM-yyyy");
                SaveFileDialog open = new SaveFileDialog();
                open.Filter = "BackUp Files (*.Back) | *.back";

                open.FileName = "BackUp_Sales_" + d + "";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    db.RunNunQuary("backup database Sales_StandardV2 To Disk='" + open.FileName + "'", "تم اخذ النسخة الاحتياطية بنجاح");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl.Clear(); DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.RunReader("select ID from Users where UserName='" + Properties.Settings.Default.UserName + "'", "");
                tbl = db.RunReader("select Restore_BackUp from Users_BackUp where User_ID=" + Convert.ToInt32(tbluser.Rows[0][0]) + " ", "");
                if (Convert.ToInt32(tbl.Rows[0][0]) == 0)
                { MessageBox.Show("انت لا تملك الصلاحية للدخول لهذه الشاشة !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


            Server myServer = new Server(Properties.Settings.Default.Server);

            Database mydb = myServer.Databases["Sales_StandardV2"];
            if (mydb != null)
                myServer.KillAllProcesses(mydb.Name);

            Restore restoreDB = new Restore();
            restoreDB.Database = mydb.Name;
            restoreDB.Action = RestoreActionType.Database;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "BackUp Files (*.Back) | *.back";
            if (open.ShowDialog() == DialogResult.OK)
            {
                restoreDB.Devices.AddDevice(open.FileName, DeviceType.File);
                restoreDB.ReplaceDatabase = true;
                restoreDB.NoRecovery = false;
                restoreDB.SqlRestore(myServer);
                MessageBox.Show("تم استرجاع النسخه الاحتياطية بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void barButtonItem87_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Add_Raw frm = new Frm_Add_Raw();
            frm.ShowDialog();
        }

        private void barButtonItem88_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_RawProduction frm = new Frm_RawProduction();
            frm.ShowDialog();
        }

        private void barButtonItem90_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_RawReport frm = new Frm_RawReport();
            frm.ShowDialog();
        }

        private void barButtonItem91_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_RawProductionReport frm = new Frm_RawProductionReport();
            frm.ShowDialog();
        }

        private void barButtonItem93_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_BuyReport frm = new Frm_BuyReport();
            frm.ShowDialog();
        }

        private void barButtonItem94_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_BuyRAW frm = new Frm_BuyRAW();
            frm.ShowDialog();
        }

        private void barButtonItem95_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_BuyRAWReport frm = new Frm_BuyRAWReport();
            frm.ShowDialog();
        }

        private void Frm_Home_FormClosing(object sender, FormClosingEventArgs e)
        {

            //DialogResult dialog1 = MessageBox.Show("هل تريد اخذ نسخة احتياطية من البرنامج؟", "نسخة احتياطية", MessageBoxButtons.YesNo);
            //if (dialog1 == DialogResult.Yes)
            //{
            //   backup();
            //}
            //else if (dialog1 == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}

            DialogResult dialog = MessageBox.Show("سيتم إغلاق البرنامج هل أنت متأكد؟", "خروج", MessageBoxButtons.YesNo);
           if( dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
           else if (dialog ==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Frm_Home_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void barButtonItem97_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ItemMovements frm = new Frm_ItemMovements();
            frm.ShowDialog();
        }

        private void btn_prod_data_ItemClick(object sender, ItemClickEventArgs e)
        {
            production_form frm = new production_form();
            frm.ShowDialog();
        }

        private void barButtonItem97_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            cust_dept frm = new cust_dept();
            frm.ShowDialog();
        }

        private void barButtonItem98_ItemClick(object sender, ItemClickEventArgs e)
        {
            sup_dept frm = new sup_dept();
            frm.ShowDialog();
        }
    }
}
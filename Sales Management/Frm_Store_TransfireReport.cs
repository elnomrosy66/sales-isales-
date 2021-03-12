using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Sales_Management
{
    public partial class Frm_Store_TransfireReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Store_TransfireReport()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        private void FillOwners()
        {
            cbxStoreFrom.DataSource = db.RunReader("select * from Store", "");
            cbxStoreFrom.DisplayMember = "Store_Name";
            cbxStoreFrom.ValueMember = "Store_ID";
            cbxStoreTo.DataSource = db.RunReader("select * from Store", "");
            cbxStoreTo.DisplayMember = "Store_Name";
            cbxStoreTo.ValueMember = "Store_ID";
        }
        private void Frm_Store_TransfireReport_Load(object sender, EventArgs e)
        {
            FillOwners();
            if (Properties.Settings.Default.UserType == "مدير") { btnDelete.Enabled = true; } else { btnDelete.Enabled = false; }
            DtbStart.Text = DateTime.Now.ToShortDateString();
            DtbEnd.Text = DateTime.Now.ToShortDateString();
        }

        private void btnSearchٍSupplier_Click(object sender, EventArgs e)
        {
            decimal Total;
            tbl.Clear(); Total = 0;
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");


            if (rbtnAllStoreFrom.Checked == true)
            {
                if (rbtnAllStoreTo.Checked == true)
                    tbl = db.RunReader("SELECT [Order_ID] as 'رقم العملية',[Item_Name] as 'اسم المنتج',[Store_From] as 'التحويل من',[Store_To] as 'التحويل الى',[Qty] as 'الكمية',[Unit] as 'الوحدة',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع',[Date] as 'تاريخ التحويل',[TranFire_Name] as 'المسؤل عن التحويل',[Reason] as 'سبب التحويل' FROM [Items_Transfire] where Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
                else if (rbtnOneStoreTo.Checked == true)
                    tbl = db.RunReader("SELECT [Order_ID] as 'رقم العملية',[Item_Name] as 'اسم المنتج',[Store_From] as 'التحويل من',[Store_To] as 'التحويل الى',[Qty] as 'الكمية',[Unit] as 'الوحدة',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع',[Date] as 'تاريخ التحويل',[TranFire_Name] as 'المسؤل عن التحويل',[Reason] as 'سبب التحويل' FROM [Items_Transfire]  where [Store_To]='"+cbxStoreTo.Text+"' and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
            }
            else if (rbtnAllStoreTo.Checked == true)
            {
                if (rbtnAllStoreFrom.Checked == true)
                    tbl = db.RunReader("SELECT [Order_ID] as 'رقم العملية',[Item_Name] as 'اسم المنتج',[Store_From] as 'التحويل من',[Store_To] as 'التحويل الى',[Qty] as 'الكمية',[Unit] as 'الوحدة',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع',[Date] as 'تاريخ التحويل',[TranFire_Name] as 'المسؤل عن التحويل',[Reason] as 'سبب التحويل' FROM [Items_Transfire] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
                else if (rbtnOneStoreForm.Checked == true )
                    tbl = db.RunReader("SELECT [Order_ID] as 'رقم العملية',[Item_Name] as 'اسم المنتج',[Store_From] as 'التحويل من',[Store_To] as 'التحويل الى',[Qty] as 'الكمية',[Unit] as 'الوحدة',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع',[Date] as 'تاريخ التحويل',[TranFire_Name] as 'المسؤل عن التحويل',[Reason] as 'سبب التحويل' FROM [Items_Transfire] where [Store_From]='" + cbxStoreFrom.Text + "' and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
            }
            else if (rbtnOneStoreForm.Checked == true)
            {
                if (rbtnAllStoreTo.Checked == true)
                    tbl = db.RunReader("SELECT [Order_ID] as 'رقم العملية',[Item_Name] as 'اسم المنتج',[Store_From] as 'التحويل من',[Store_To] as 'التحويل الى',[Qty] as 'الكمية',[Unit] as 'الوحدة',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع',[Date] as 'تاريخ التحويل',[TranFire_Name] as 'المسؤل عن التحويل',[Reason] as 'سبب التحويل' FROM [Items_Transfire] where [Store_From]='" + cbxStoreFrom.Text + "' and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
                else if (rbtnOneStoreTo.Checked == true)
                    tbl = db.RunReader("SELECT [Order_ID] as 'رقم العملية',[Item_Name] as 'اسم المنتج',[Store_From] as 'التحويل من',[Store_To] as 'التحويل الى',[Qty] as 'الكمية',[Unit] as 'الوحدة',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع',[Date] as 'تاريخ التحويل',[TranFire_Name] as 'المسؤل عن التحويل',[Reason] as 'سبب التحويل' FROM [Items_Transfire]  where [Store_From]='" + cbxStoreFrom.Text + "' and [Store_To]='" + cbxStoreTo.Text + "' and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
            
            }
            else if (rbtnOneStoreTo.Checked == true)
            {
                if (rbtnAllStoreFrom.Checked == true)
                    tbl = db.RunReader("SELECT [Order_ID] as 'رقم العملية',[Item_Name] as 'اسم المنتج',[Store_From] as 'التحويل من',[Store_To] as 'التحويل الى',[Qty] as 'الكمية',[Unit] as 'الوحدة',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع',[Date] as 'تاريخ التحويل',[TranFire_Name] as 'المسؤل عن التحويل',[Reason] as 'سبب التحويل' FROM [Items_Transfire] where [Store_To]='" + cbxStoreFrom.Text + "' and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
                else if (rbtnOneStoreForm.Checked == true)
                    tbl = db.RunReader("SELECT [Order_ID] as 'رقم العملية',[Item_Name] as 'اسم المنتج',[Store_From] as 'التحويل من',[Store_To] as 'التحويل الى',[Qty] as 'الكمية',[Unit] as 'الوحدة',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع',[Date] as 'تاريخ التحويل',[TranFire_Name] as 'المسؤل عن التحويل',[Reason] as 'سبب التحويل' FROM [Items_Transfire]  where [Store_From]='" + cbxStoreFrom.Text + "' and [Store_To]='" + cbxStoreTo.Text + "' and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
            
            }
            decimal TotalTax = 0;

            if (tbl.Rows.Count >= 1)
            {
                DgvSearchBuy.DataSource = tbl;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Total += Convert.ToDecimal(tbl.Rows[i][4]);
                }
                txtTotalQty.Text = Math.Round(Total, 2).ToString();
            }
            else
            {
                MessageBox.Show("لا يوجد تحويلات فى هذه الفترة ", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotalQty.Text = "0";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");
            if (DgvSearchBuy.Rows.Count >= 1)
            {
                if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.RunNunQuary("delete  from Items_Transfire where Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'  ", "تم حذف البيانات  بنجاح");

                }
            }
        }
    }
}
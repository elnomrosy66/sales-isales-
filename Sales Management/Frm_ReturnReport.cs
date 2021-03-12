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
    public partial class Frm_ReturnReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ReturnReport()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        private void Frm_ReturnReport_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserType == "مدير") { btnDelete.Enabled = true; } else { btnDelete.Enabled = false; }
            DtbStart.Text = DateTime.Now.ToShortDateString();
            DtbEnd.Text = DateTime.Now.ToShortDateString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            decimal Total;
            tbl.Clear(); Total = 0;
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");

            if (rbtnAll.Checked == true)
            {

                tbl = db.RunReader("SELECT [ReturnOrder_ID] as 'رقم العملية',[Item_Name] as 'الصنف',[Qty] as 'الكمية',Unit as 'الوحدة',[Price] as 'السعر',[Tax] as 'الضريبة المضافة',[Pric_Tax] as 'الاجمالى بعد الضريبة',[ReturnName] as 'اسم العميل او المورد',[UserName] as 'اسم المستخدم',[Return_Date] as 'تاريخ الارجاع',[Return_Type] as 'نوع العملية',[Order_ID] as 'رقم عملية البيع' FROM [Return_Detalis] where  Convert(date,[Return_Date],105) Between '" + d + "' and '" + d2 + "'", "");
            }
            else if (rbtnSales.Checked == true)
            {
                tbl = db.RunReader("SELECT [ReturnOrder_ID] as 'رقم العملية',[Item_Name] as 'الصنف',[Qty] as 'الكمية',Unit as 'الوحدة',[Price] as 'السعر',[Tax] as 'الضريبة المضافة',[Pric_Tax] as 'الاجمالى بعد الضريبة',[ReturnName] as 'اسم العميل',[UserName] as 'اسم المستخدم',[Return_Date] as 'تاريخ الارجاع',[Return_Type] as 'نوع العملية',[Order_ID] as 'رقم عملية البيع' FROM [Return_Detalis] where Return_Type='مرتجعات بيع' and Convert(date,[Return_Date],105) Between '" + d + "' and '" + d2 + "'", "");

            }
            else if (rbtnBuys.Checked == true)
            {
                tbl = db.RunReader("SELECT [ReturnOrder_ID] as 'رقم العملية',[Item_Name] as 'الصنف',[Qty] as 'الكمية',Unit as 'الوحدة',[Price] as 'السعر',[Tax] as 'الضريبة المضافة',[Pric_Tax] as 'الاجمالى بعد الضريبة',[ReturnName] as 'اسم المورد',[UserName] as 'اسم المستخدم',[Return_Date] as 'تاريخ الارجاع',[Return_Type] as 'نوع العملية',[Order_ID] as 'رقم عملية البيع' FROM [Return_Detalis] where Return_Type='مرتجعات مشتريات' and Convert(date,[Return_Date],105) Between '" + d + "' and '" + d2 + "'", "");

            }
            decimal TotalTax = 0;

            if (tbl.Rows.Count >= 1)
            {
                DgvSearchBuy.DataSource = tbl;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Total += Convert.ToDecimal(tbl.Rows[i][6]);
                    TotalTax += Convert.ToDecimal(tbl.Rows[i][5]);
                }
                txtTotalPhar.Text = Math.Round(Total, 2).ToString();
                txtTotalTax.Text = Math.Round(TotalTax, 2).ToString();
            }
            else
            {
                MessageBox.Show("لا يوجد مرتجعات فى هذه الفترة ", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotalPhar.Text = "0";
                txtTotalTax.Text = "0";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");
            if (MessageBox.Show("تحذير سيتم مسح جميع البيانات فى هذه الفترة ", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete from Return_ where Convert(date,[Date],105) between '" + d + "' and '" + d2 + "' ", "");
                db.RunNunQuary("delete from Return_Detalis where Convert(date,[Return_Date],105) between '" + d + "' and '" + d2 + "' ", "تم حذف جميع البيانات فى هذه الفترة  بنجاح");
                tbl.Clear();
                DgvSearchBuy.DataSource = tbl;
            }
        }
    }
}
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
    public partial class Frm_ProblemMoneyReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ProblemMoneyReport()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        private void Frm_ProblemMoneyReport_Load(object sender, EventArgs e)
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

            if (rbtnDameg.Checked == true)
                tbl = db.RunReader("select Order_ID as 'رقم العملية',Cust_Name as 'اسم المكترى',Item_Name as 'اسم المنتج',Date as 'تاريخ الدفع',Qty as 'الكمية',Total as 'مبلغ التعويض' from Items_RentDameg Where Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");

            else
                tbl = db.RunReader("select Order_ID as 'رقم العملية' ,Cust_Name as 'اسم المكترى',Pay_Price as 'مبلغ التعويض',Item_Name as 'اسم الصنف',Date as 'تاريخ الدفع' from Items_ProblemPay Where Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");

            if (tbl.Rows.Count >= 1)
            {
                DgvBuyDetalis.DataSource = tbl;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    if (rbtnDameg.Checked)
                        Total += Convert.ToDecimal(tbl.Rows[i][5]);
                    else
                        Total += Convert.ToDecimal(tbl.Rows[i][2]);
                }
                txtTotal.Text = Math.Round(Total, 2).ToString();
            }
            else
            {
                MessageBox.Show("لا يوجد مبالغ تلفيات فى هذه الفترة ", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotal.Text = "0";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");
            if (MessageBox.Show("تحذير سيتم مسح جميع البيانات فى هذه الفترة ", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete from Items_RentDameg where Convert(date,Date,105) between '" + d + "' and '" + d2 + "' ", "تم حذف جميع البيانات فى هذه الفترة  بنجاح");
                tbl.Clear();
                DgvBuyDetalis.DataSource = tbl;
                txtTotal.Text = "0";
            }
        }
    }
}
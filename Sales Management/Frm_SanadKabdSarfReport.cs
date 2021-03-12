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
    public partial class Frm_SanadKabdSarfReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SanadKabdSarfReport()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        decimal Total = 0;
        private void Frm_SanadKabdSarfReport_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserType == "مدير") { btnDelete.Enabled = true; } else { btnDelete.Enabled = false; }
            DtbEnd.Text = DateTime.Now.ToShortDateString();
            DtbStart.Text = DateTime.Now.ToShortDateString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tbl.Clear(); Total = 0;
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");
            if (rbtnKabd.Checked == true)
            {
                tbl = db.RunReader("SELECT [Order_ID] as 'رقم العميلة',[Sanad_Name] as 'اسم المسؤل عن القبض',[Sanad_Price] as 'مبلغ القبض',[Sanad_From] as 'جهه القبض',[Sanad_Date] as 'تاريخ القبض',[Notes] as 'ملاحظات' FROM  [Sanad_Kabd] where Convert(date,[Sanad_Date],105) between '" + d + "' and '" + d2 + "'", "");
            }
            else {
                tbl = db.RunReader("SELECT [Order_ID] as 'رقم العميلة',[Sanad_Name] as 'اسم المسؤل عن الصرف',[Sanad_Price] as 'مبلغ الصرف',[Sanad_To] as 'جهه الصرف',[Sanad_Date] as 'تاريخ الصرف',[Notes] as 'ملاحظات' FROM  [Sanad_Sarf] where Convert(date,[Sanad_Date],105) between '" + d + "' and '" + d2 + "'", "");

            }

            if (tbl.Rows.Count >= 1)
            {
                DgvSearchBuy.DataSource = tbl;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Total += Convert.ToDecimal(tbl.Rows[i][2]);
                }
                txtTotal.Text = Math.Round(Total, 2).ToString();
            }
            else
            {
                MessageBox.Show("لا يوجد سندات فى هذه الفترة ", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotal.Text = "0";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");
            if (MessageBox.Show("تحذير سيتم مسح جميع البيانات فى هذه الفترة ", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if(rbtnKabd.Checked==true)
                    db.RunNunQuary("delete from Sanad_Kabd where Convert(date,Sanad_Date,105) between '" + d + "' and '" + d2 + "' ", "تم حذف جميع البيانات فى هذه الفترة  بنجاح");
                else
                    db.RunNunQuary("delete from Sanad_Sarf where Convert(date,Sanad_Date,105) between '" + d + "' and '" + d2 + "' ", "تم حذف جميع البيانات فى هذه الفترة  بنجاح");

                tbl.Clear();
                DgvSearchBuy.DataSource = tbl;
                txtTotal.Text = "0";
            }
        }
    }
}
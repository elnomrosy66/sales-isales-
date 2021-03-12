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
    public partial class Frm_Borrow_Money_Report : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Borrow_Money_Report()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();


        private void Frm_Borrow_Money_Report_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserType == "مدير") { btnDelete.Enabled = true; } else { btnDelete.Enabled = false; }

            DtbStart.Text = DateTime.Now.ToShortDateString();
            DtbEnd.Text = DateTime.Now.ToShortDateString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            decimal Total;
            tbl.Clear(); Total = 0;
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");
            if (rbtnAll.Checked == true)
                tbl = db.RunReader("select Order_ID as 'قم العميلة' ,Price as 'المبلغ' ,Borrow_From as 'اسم الدائن' ,Borrow_To as 'اسم السخص المدين' ,Date as 'تاريخ السلفية' ,Date_Reminder as 'تاريخ الاستحقاق' ,Note as 'ملاحظات' from Borrow where  Convert(date,Borrow.Date,105) Between '" + d + "' and '" + d2 + "'", "");
            else if (rbtnOne.Checked == true)
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم الشخص المدين او جزء منه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                tbl = db.RunReader("select Order_ID as 'قم العميلة' ,Price as 'المبلغ' ,Borrow_From as 'اسم الدائن' ,Borrow_To as 'اسم السخص المدين' ,Date as 'تاريخ السلفية' ,Date_Reminder as 'تاريخ الاستحقاق' ,Note as 'ملاحظات' from Borrow where Borrow_To like '%" + txtName.Text + "%' and Convert(date,Borrow.Date,105) Between '" + d + "' and '" + d2 + "'", "");
            }
            if (tbl.Rows.Count >= 1)
            {
                DgvSearchBuy.DataSource = tbl;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Total += Convert.ToDecimal(tbl.Rows[i][1]);
                }
                txtTotalPhar.Text = Math.Round(Total, 2).ToString();
            }
            else
            {
                MessageBox.Show("لا يوجد اى سلفيات فى هذه الفترة ", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotalPhar.Text = "0";
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
                    db.RunNunQuary("delete  from Borrow where Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'  ", "تم حذف البيانات  بنجاح");

                }
            }
        }
    }
}
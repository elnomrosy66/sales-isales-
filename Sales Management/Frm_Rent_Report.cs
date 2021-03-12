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
    public partial class Frm_Rent_Report : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Rent_Report()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        private void FillOwners()
        {
            cbxEmp.DataSource = db.RunReader("select * from Employee", "");
            cbxEmp.DisplayMember = "Emp_Name";
            cbxEmp.ValueMember = "Emp_ID";
        }
        private void Frm_Rent_Report_Load(object sender, EventArgs e)
        {
            FillOwners();
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
            if (cbxEmp.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك ادخل بيانات الموظفين اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbtnAll.Checked == true)
            {
                if (checkBox1.Checked == true)
                    tbl = db.RunReader("select Order_ID as 'رقم العملية',Items.Item_Name as 'اسم المنتج',Customer.Cust_Name as 'اسم المكترى',Rent_Detalis.Qty as 'الكمية',Rent_Detalis.Price as 'السعر',DateFrom as 'تاريخ الاكتراء' ,DateTo as 'تاريخ الاسترداد', Total_Order as 'اجمالى مبلغ الاكتراء',UserName as 'اسم المستخدم'  from Rent_Detalis,Items ,Customer where Rent_Detalis.Cust_ID=Customer.Cust_ID and Rent_Detalis.Item_ID=Items.Item_ID and [Order_ID]=" + textBox1.Text + " and Convert(date,DateRent,105) Between '" + d + "' and '" + d2 + "'", "");
                else
                    tbl = db.RunReader("select Order_ID as 'رقم العملية',Items.Item_Name as 'اسم المنتج',Customer.Cust_Name as 'اسم المكترى',Rent_Detalis.Qty as 'الكمية',Rent_Detalis.Price as 'السعر',DateFrom as 'تاريخ الاكتراء' ,DateTo as 'تاريخ الاسترداد', Total_Order as 'اجمالى مبلغ الاكتراء',UserName as 'اسم المستخدم'  from Rent_Detalis,Items ,Customer where Rent_Detalis.Cust_ID=Customer.Cust_ID and Rent_Detalis.Item_ID=Items.Item_ID and Convert(date,DateRent,105) Between '" + d + "' and '" + d2 + "'", "");

            }
            else if (rbtnPart.Checked == true)
            {

                if (checkBox1.Checked == true)
                    tbl = db.RunReader("select Order_ID as 'رقم العملية',Items.Item_Name as 'اسم المنتج',Customer.Cust_Name as 'اسم المكترى',Rent_Detalis.Qty as 'الكمية',Rent_Detalis.Price as 'السعر',DateFrom as 'تاريخ الاكتراء' ,DateTo as 'تاريخ الاسترداد', Total_Order as 'اجمالى مبلغ الاكتراء',UserName as 'اسم المستخدم'  from Rent_Detalis,Items ,Customer where Rent_Detalis.Cust_ID=Customer.Cust_ID and Rent_Detalis.Item_ID=Items.Item_ID and Rent_Detalis.UserName='" + cbxEmp.Text + "' and [Order_ID]=" + textBox1.Text + " and Convert(date,DateRent,105) Between '" + d + "' and '" + d2 + "'", "");
                else
                    tbl = db.RunReader("select Order_ID as 'رقم العملية',Items.Item_Name as 'اسم المنتج',Customer.Cust_Name as 'اسم المكترى',Rent_Detalis.Qty as 'الكمية',Rent_Detalis.Price as 'السعر',DateFrom as 'تاريخ الاكتراء' ,DateTo as 'تاريخ الاسترداد', Total_Order as 'اجمالى مبلغ الاكتراء',UserName as 'اسم المستخدم'  from Rent_Detalis,Items ,Customer where Rent_Detalis.Cust_ID=Customer.Cust_ID and Rent_Detalis.Item_ID=Items.Item_ID and Rent_Detalis.UserName='" + cbxEmp.Text + "' and Convert(date,DateRent,105) Between '" + d + "' and '" + d2 + "'", "");

            }

            if (tbl.Rows.Count >= 1)
            {
                DgvSearchBuy.DataSource = tbl;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Total += Convert.ToDecimal(tbl.Rows[i][7]);
                }
                txtTotalPhar.Text = Math.Round(Total, 2).ToString();
            }
            else
            {
                MessageBox.Show("لا يوجد عمليات فى هذه الفترة ", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotalPhar.Text = "0";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");
            if (MessageBox.Show("تحذير سيتم مسح جميع البيانات فى هذه الفترة ", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete from Rent where Convert(date,Date,105) between '" + d + "' and '" + d2 + "' ", "");
                db.RunNunQuary("delete from Rent_Detalis where Convert(date,DateRent,105) between '" + d + "' and '" + d2 + "' ", "تم حذف جميع البيانات فى هذه الفترة  بنجاح");

                tbl.Clear();
                DgvSearchBuy.DataSource = tbl;
                txtTotalPhar.Text = "0";
            }
        }
    }
}
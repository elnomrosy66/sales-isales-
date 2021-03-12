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
    public partial class Frm_Employee_Salaray_Report : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Employee_Salaray_Report()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        private void FillEmp()
        {
            cbxEmployee.DataSource = db.RunReader("select * from Employee", "");
            cbxEmployee.DisplayMember = "Emp_Name";
            cbxEmployee.ValueMember = "Emp_ID";
        }
        private void Frm_Employee_Salaray_Report_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserType == "مدير") { btnDelete.Enabled = true; } else { btnDelete.Enabled = false; }
            FillEmp();
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
                tbl = db.RunReader("select Order_ID as 'رقم العملية',Employee.Emp_Name as 'اسم الموظف' ,Employee_Salary.Salary as 'المرتب',Date_Reminder as 'تاريخ الاستحقاق',Employee_Salary.Date as 'تاريخ الصرف',Employee_Salary.Notes as 'ملاحظات' from Employee_Salary,Employee  where Employee_Salary.Emp_ID=Employee.Emp_ID and Convert(date,Employee_Salary.Date,105) Between '" + d + "' and '" + d2 + "'", "");
            else if (rbtnOne.Checked == true)
            {
                if (cbxEmployee.Items.Count <= 0)
                {
                    MessageBox.Show("من فضلك ادخل بيانات الموظفين اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                tbl = db.RunReader("select Order_ID as 'رقم العملية',Employee.Emp_Name as 'اسم الموظف' ,Employee_Salary.Salary as 'المرتب',Date_Reminder as 'تاريخ الاستحقاق',Employee_Salary.Date as 'تاريخ الصرف',Employee_Salary.Notes as 'ملاحظات' from Employee_Salary,Employee  where Employee_Salary.Emp_ID=Employee.Emp_ID and Employee_Salary.Emp_ID=" + cbxEmployee.SelectedValue + " and Convert(date,Employee_Salary.Date,105) Between '" + d + "' and '" + d2 + "'", "");
            }
            if (tbl.Rows.Count >= 1)
            {
                DgvSearchBuy.DataSource = tbl;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Total += Convert.ToDecimal(tbl.Rows[i][2]);
                }
                txtTotalPhar.Text = Math.Round(Total, 2).ToString();
            }
            else
            {
                MessageBox.Show("لا يوجد اى اذن صرف مرتب فى هذه الفترة ", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotalPhar.Text = "0";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");
            if (MessageBox.Show("تحذير سيتم مسح جميع البيانات فى هذه الفترة ", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete from Employee_Salary where Convert(date,Employee_Salary.Date,105) between '" + d + "' and '" + d2 + "' ", "تم حذف جميع البيانات فى هذه الفترة  بنجاح");
                tbl.Clear();
                DgvSearchBuy.DataSource = tbl;
            }
        }
    }
}
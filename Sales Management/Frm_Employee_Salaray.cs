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
    public partial class Frm_Employee_Salaray : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Employee_Salaray()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        public void AutoNum()
        {
            tbl.Clear();
            tbl = db.RunReader("Select Max(Order_ID) from Employee_Salary", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
                txtID.Text = "1";
            else
                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0].ToString()) + 1).ToString();

            txtSalary.Clear();
            DtbDate.Text = DateTime.Now.ToShortDateString();
            DtbReminder.Text = DateTime.Now.ToShortDateString();
            txtTotalSalary.Text = "0";
            txtBorrowItems.Text = "0";
            if (cbxEmployee.Items.Count >= 1)
                cbxEmployee.SelectedIndex = 0;
        }
        private void FillEmp()
        {
            cbxEmployee.DataSource = db.RunReader("select * from Employee", "");
            cbxEmployee.DisplayMember = "Emp_Name";
            cbxEmployee.ValueMember = "Emp_ID";
        }
        int stock_ID;
        private void Frm_Employee_Salaray_Load(object sender, EventArgs e)
        {
            try
            {
                FillEmp();
                AutoNum();
            }
            catch (Exception) { }
            stock_ID = Convert.ToInt32( Properties.Settings.Default.UserStock );

        }

        private void cbxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbl.Clear();
                if (cbxEmployee.Items.Count >= 1)
                {
                    tbl = db.RunReader("select * from Employee where Emp_ID=" + cbxEmployee.SelectedValue + "", "");
                    txtSalary.Text = tbl.Rows[0][2].ToString();

                    this.Text = tbl.Rows[0][3].ToString();
                    DateTime dt = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                    DtbReminder.Value = dt;
                }
            }
            catch (Exception) { }
            DataTable tblCheck = new DataTable();
            tblCheck.Clear();
            try
            {
                decimal total = 0;
                tblCheck = db.RunReader("select * from Employee_SalaryMinus where Emp_ID=" + cbxEmployee.SelectedValue + " and Pay='NO' ", "");

                for (int i = 0; i <= tblCheck.Rows.Count - 1; i++)
                {
                    total = total + Convert.ToDecimal(tblCheck.Rows[i][5]);
                }
                txtBorrowItems.Text = total.ToString();


                txtTotalSalary.Text = (Convert.ToDecimal(txtSalary.Text) - Convert.ToDecimal(txtBorrowItems.Text)).ToString();
            }
            catch (Exception) { }

        }

        private bool CheckDate()
        {

            try
            {
                DateTime dNow = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                DateTime dReminder;

                dReminder = Convert.ToDateTime(DtbReminder.Text);
                TimeSpan difference = dReminder - dNow;
                if (difference.Days <= 0)
                {
                    return true;
                }
            }
            catch (Exception) { }
            return false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool check = CheckDate();
            if (check == false)
            {
                MessageBox.Show("لم يحين ميعاد صرف المرتب للموظف", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {

                if (cbxEmployee.Items.Count <= 0)
                {
                    MessageBox.Show("لا يوجد موظفين لكى تتم عملية صرف المرتب", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataTable tblCheck = new DataTable();
                tblCheck.Clear();

                tblCheck = db.RunReader("select * from Stock where Stock_ID="+stock_ID+"", "");
                decimal Money = Convert.ToDecimal(tblCheck.Rows[0][0]);
                decimal total = Convert.ToDecimal(txtTotalSalary.Text);
                if (Money - total < 0)
                {
                    MessageBox.Show("لا يوجد رصيد كافى فى الخزنه لاتمام العملية", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string d = DtbDate.Value.ToString("dd/MM/yyyy");
                string dReminder = DtbReminder.Value.ToString("dd/MM/yyyy");
                db.RunNunQuary("insert into Employee_Salary values(" + txtID.Text + " ," + cbxEmployee.SelectedValue + " ," + txtTotalSalary.Text + " ,'" + dReminder + "' ,'" + d + "' ,N'" + txtNotes.Text + "')", "تم صرف المرتب بنجاح");
                db.RunNunQuary("update Stock set Money=Money - " + txtSalary.Text + " where Stock_ID=" + stock_ID + "", "");
                db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type,Stock_ID) Values(" + txtTotalSalary.Text + " ,'" + d + "' ,N'مرتب','مرتبات موظفين',"+stock_ID+")", "");



            }
            catch (Exception) { }
            try
            {
                PayBorrow();
            }
            catch (Exception) { }

            AutoNum();
        }


        private void PayBorrow()
        {
            DataTable tblMoney = new DataTable();
            decimal tot = Convert.ToDecimal(txtSalary.Text);
            tblMoney = db.RunReader("select Price from Employee_SalaryMinus where Emp_ID=" + cbxEmployee.SelectedValue + " and Pay='NO'", "");

            for (int i = 0; i <= tblMoney.Rows.Count - 1; i++)
            {

                if (tot >= Convert.ToDecimal(tblMoney.Rows[i][0]))
                {
                    db.RunNunQuary("update Employee_SalaryMinus set Pay='YES' where Emp_ID=" + cbxEmployee.SelectedValue + " and Pay='NO' and Price=" + Convert.ToDecimal(tblMoney.Rows[i][0]) + " and Emp_Name='" + cbxEmployee.Text + "'", "");
                    tot = tot - Convert.ToDecimal(tblMoney.Rows[i][0]);
                }
            }
        }
    }
}
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
    public partial class Frm_Borrow_Money : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Borrow_Money()
        {
            InitializeComponent();
        }


        DB db = new DB();
        DataTable tbl = new DataTable();

        public void AutoNum()
        {
            tbl.Clear();
            tbl = db.RunReader("Select Max(Order_ID) from Borrow", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
                txtID.Text = "1";
            else
                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0].ToString()) + 1).ToString();

            NudPrice.Value = 1;
            DtbDate.Text = DateTime.Now.ToShortDateString();
            DtbReminder.Text = DateTime.Now.ToShortDateString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string d = DtbDate.Value.ToString("dd/MM/yyyy");
            string dReminder = DtbReminder.Value.ToString("dd/MM/yyyy");
            try
            {
                if (txtBorrowFrom.Text == "" || NudPrice.Value <= 0)
                { MessageBox.Show("من فضلك اكمل البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                DataTable tblCheck = new DataTable();
                tblCheck.Clear();
                tblCheck = db.RunReader("select * from Stock where Stock_ID="+stock_ID+"", "");
                decimal Money = Convert.ToDecimal(tblCheck.Rows[0][0]);
                decimal total = Convert.ToDecimal(NudPrice.Value);
                if (Money - total < 0)
                {
                    MessageBox.Show("لا يوجد رصيد كافى فى الخزنه لاتمام العملية", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (rbtnNormal.Checked == true)
                {
                    db.RunNunQuary("insert into Borrow Values(" + txtID.Text + " ," + NudPrice.Value + " ,N'" + txtBorrowFrom.Text + "' ,N'" + txtBorrowTo.Text + "' ,'" + d + "' ,'" + dReminder + "' ,N'" + txtNotes.Text + "')", "تمت عمليه السلف بنجاح");
                    db.RunNunQuary("insert into Employee_SalaryMinus ( Emp_ID,Emp_Name ,Date,Qty,Price,Pay ) Values(0, N'" + txtBorrowTo.Text + "' ,'" + d + "' ,0 ," + NudPrice.Value + " ,'NO')", "");
                }
                else if (rbtnEmployee.Checked == true)
                {
                    db.RunNunQuary("insert into Borrow Values(" + txtID.Text + " ," + NudPrice.Value + " ,N'" + txtBorrowFrom.Text + "' ,N'" + cbxEmployee.Text + "' ,'" + d + "' ,'" + dReminder + "' ,N'" + txtNotes.Text + "')", "تمت عمليه السلف بنجاح");
                    db.RunNunQuary("insert into Employee_SalaryMinus ( Emp_ID,Emp_Name ,Date,Qty,Price,Pay ) Values(" + cbxEmployee.SelectedValue + ", N'" + cbxEmployee.Text + "' ,'" + d + "' ,0 ," + NudPrice.Value + " ,'NO')", "");
                }
                db.RunNunQuary("update Stock set Money=Money - " + NudPrice.Value + " where Stock_ID="+stock_ID+"", "");
                db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type,Stock_ID) Values(" + NudPrice.Value + " ,'" + d + "' ,N'سلف' ,'سلفيات' ,"+stock_ID+")", "");


            }
            catch (Exception) { }

        }
        private void FillEmp()
        {
            cbxEmployee.DataSource = db.RunReader("select * from Employee", "");
            cbxEmployee.DisplayMember = "Emp_Name";
            cbxEmployee.ValueMember = "Emp_ID";
        }
        int stock_ID;
        private void Frm_Borrow_Money_Load(object sender, EventArgs e)
        {
            stock_ID = Convert.ToInt32(Properties.Settings.Default.UserStock);
            try
            {
                cbxEmployee.Enabled = false;
                txtBorrowTo.Enabled = true;
                FillEmp();
                AutoNum();
            }
            catch (Exception) { }
        }

        private void rbtnNormal_CheckedChanged(object sender, EventArgs e)
        {
            cbxEmployee.Enabled = false;
            txtBorrowTo.Enabled = true;
        }

        private void rbtnEmployee_CheckedChanged(object sender, EventArgs e)
        {
            cbxEmployee.Enabled = true;
            txtBorrowTo.Enabled = false;
        }

        private void cbxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class Frm_Employee_Borrow : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Employee_Borrow()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        private void FillItem()
        {
            cbxItems.DataSource = db.RunReader("select * from Items", "");
            cbxItems.DisplayMember = "Item_Name";
            cbxItems.ValueMember = "Item_ID";
        }
        private void FillEmp()
        {
            cbxEmployee.DataSource = db.RunReader("select * from Employee", "");
            cbxEmployee.DisplayMember = "Emp_Name";
            cbxEmployee.ValueMember = "Emp_ID";
        }
        public void AutoNum()
        {
            tbl.Clear();
            tbl = db.RunReader("Select Max(Order_ID) from Employee_Borrow", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
                txtID.Text = "1";
            else
                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0].ToString()) + 1).ToString();
            if (cbxItems.Items.Count >= 1)
                cbxItems.SelectedIndex = 0;
            NudQty.Value = 1;
            DtbDate.Text = DateTime.Now.ToShortDateString();
            try
            {
                cbxEmployee.SelectedIndex = 0;
                cbxItems.SelectedIndex = 0;
            }
            catch (Exception) { }
        }
        private void Frm_Employee_Borrow_Load(object sender, EventArgs e)
        {

            try
            {
                FillItem();
                FillEmp();
                AutoNum();
            }
            catch (Exception) { }
        }
        int stock_ID;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbxItems.Items.Count <= 0 || cbxEmployee.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك تاكد من اكتمال البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            stock_ID = Convert.ToInt32( Properties.Settings.Default.UserStock );
            tbl.Clear();
            int qty = 0;
            decimal price = 0;
            string d = DtbDate.Value.ToString("dd/MM/yyyy");
            tbl = db.RunReader("select Item_Qty - " + NudQty.Value + " from Items where Item_ID=" + cbxItems.SelectedValue + "", "");
            qty = Convert.ToInt32(db.RunReader("select Item_Qty from Items where Item_ID=" + cbxItems.SelectedValue + "", "").Rows[0][0]);
            price = Convert.ToInt32(db.RunReader("select Item_Price_Sale_Part from Items where Item_ID=" + cbxItems.SelectedValue + "", "").Rows[0][0]);

            if (Convert.ToInt32(tbl.Rows[0][0]) == 0 || Convert.ToInt32(tbl.Rows[0][0]) >= 1)
            {
                db.RunNunQuary("insert into Employee_Borrow Values(" + txtID.Text + " ," + cbxItems.SelectedValue + " ," + cbxEmployee.SelectedValue + " ,'" + d + "' ," + NudQty.Value + ")", "");
                db.RunNunQuary("update Items set Item_Qty =(Item_Qty - " + NudQty.Value + " ) where Item_ID=" + cbxItems.SelectedValue + "", "تمت عملية السحب بنجاح للموظف " + cbxEmployee.Text);
                db.RunNunQuary("insert into Employee_SalaryMinus (Emp_ID,Emp_Name ,Date,Qty,Price,Pay) Values(" + cbxEmployee.SelectedValue + ",N'" + cbxEmployee.Text + "' ,'" + d + "' ," + NudQty.Value + " ," + price + " ,'NO')", "");
            }
            else if (Convert.ToInt32(tbl.Rows[0][0]) < 0)
            {
                MessageBox.Show("لا يوجد كميه كافيه فى المخزن من المنتج المحدد فالكمية الموجوده حاليا هى  " + qty, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        DataTable tblPar = new DataTable();
        private void textParcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            tblPar.Clear();
            if (e.KeyChar == 13)
            {
                tblPar = db.RunReader("select * from Items where barcode='" + textParcode.Text + "'", "");
                if (tblPar.Rows.Count >= 1)
                {
                    cbxItems.SelectedValue = tblPar.Rows[0][0].ToString();

                    textParcode.Clear();
                    textParcode.Focus();
                }
                else
                {
                    textParcode.Clear();
                    textParcode.Focus();
                }
            }
        }
    }
}
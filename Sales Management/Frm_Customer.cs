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
    public partial class Frm_Customer : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Customer()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        int introw = 0;
        public void AutoNum()
        {
            tbl.Clear();
            tbl = db.RunReader("Select Max(Cust_ID) from Customer", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
                txtCustomerID.Text = "1";
            else
                txtCustomerID.Text = (Convert.ToInt32(tbl.Rows[0][0].ToString()) + 1).ToString();
            txtCustAddress.Clear();
            txtCustName.Clear();
            txtPhone1.Clear();
            txtSearch.Clear();
            txtCustCode.Clear();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            txtSearch.Enabled = true;
        }
        private void showData()
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Customer", "");
            if ((tbl.Rows.Count <= 0))
            {
                MessageBox.Show("لا يوجد بيانات فى هذه الشاشة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try{
                txtCustomerID.Text = tbl.Rows[introw][0].ToString();
                txtCustName.Text = tbl.Rows[introw][1].ToString();
                txtCustAddress.Text = tbl.Rows[introw][2].ToString();
                txtPhone1.Text = tbl.Rows[introw][3].ToString();
                txtCustCode.Text = tbl.Rows[introw][4].ToString();
                }
                catch (Exception) { }
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
            }
        }
        private void Frm_Customer_Load(object sender, EventArgs e)
        {
            AutoNum();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            introw = 0;
            showData();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

            if (introw == 0)
            {
                tbl.Clear();
                tbl = db.RunReader("select * from Customer", "");
                introw = tbl.Rows.Count - 1;
                
                showData();
                 
            }
            else
            {
                introw -= 1;
                showData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Customer", "");
            
            if (introw == 0) {
                introw++;
                showData();
                
            }
            else if (introw == tbl.Rows.Count -1) {
                introw = 0;
                showData();
            }
            else
            {
                introw += 1;
                showData();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Customer", "");
            introw = tbl.Rows.Count - 1;
            showData();
        }
        DataTable tblCustmoer = new DataTable();
        private void btnClear_Click(object sender, EventArgs e)
        {
            AutoNum();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCustName.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            try
            {
                tblCustmoer.Clear();
                tblCustmoer = db.RunReader("select Cust_Name from Customer", "");
                if (tblCustmoer.Rows.Count >= 1)
                {
                    for (int i = 0; i <= tblCustmoer.Rows.Count - 1; i++)
                    {
                        if (txtCustName.Text == tblCustmoer.Rows[0][i].ToString())
                        {
                            MessageBox.Show("هذا الاسم مسجل من قبل من فضلك راجع البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
            }
            catch (Exception) { }
            try
            {
                db.RunNunQuary("insert into Customer values(" + txtCustomerID.Text + ",N'" + txtCustName.Text + "',N'" + txtCustAddress.Text + "',N'" + txtPhone1.Text + "',N'" + txtCustCode.Text + "')", "تم اضافه بيانات العميل بنجاح");
                AutoNum();
            }
            catch (Exception)
            { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustName.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            try
            {
                db.RunNunQuary("update Customer set Cust_Name=N'" + txtCustName.Text + "',Cust_Address=N'" + txtCustAddress.Text + "',Cust_Phone=N'" + txtPhone1.Text + "',Cust_Code=N'" + txtCustCode.Text + "'  where Cust_ID=" + txtCustomerID.Text + "", "تم حفظ بيانات العميل بنجاح");
                AutoNum();
            }
            catch (Exception)
            { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Customer where Cust_ID=" + txtCustomerID.Text + " ", "تم حذف بيانات العميل بنجاح");
                Frm_Customer_Load(null, null);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Customer ", "تم حذف بيانات العملاء ");
                Frm_Customer_Load(null, null);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                DataTable tblSearch = new DataTable();
                tblSearch.Clear();
                tblSearch = db.RunReader("select * from Customer where Cust_Name  Like N'%" + txtSearch.Text + "%' ", "");
                if ((tblSearch.Rows.Count <= 0))
                {
                    MessageBox.Show("لا يوجد اسم عميل مماثل لهذا", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtCustomerID.Text = tblSearch.Rows[0][0].ToString();
                    txtCustName.Text = tblSearch.Rows[0][1].ToString();
                    txtCustAddress.Text = tblSearch.Rows[0][2].ToString();
                    txtPhone1.Text = tblSearch.Rows[0][3].ToString();
                    txtCustCode.Text = tblSearch.Rows[0][4].ToString();
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDeleteAll.Enabled = true;
                }
            }
        }

        private void Frm_Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Frm_SalesSuperMarket.GetMainForm.FillCustomer();
            }
            catch (Exception) { }
         
        }
    }
}
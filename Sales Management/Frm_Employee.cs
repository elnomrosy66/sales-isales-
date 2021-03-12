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
    public partial class Frm_Employee : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Employee()
        {
            InitializeComponent();
        }

        DB db = new DB();
        DataTable tbl = new DataTable();
        int introw = 0;
        public void AutoNum()
        {
            tbl.Clear();
            tbl = db.RunReader("Select Max(Emp_ID) from Employee", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
                txtID.Text = "1";
            else
                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0].ToString()) + 1).ToString();
            txtIDNationalty.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtSearch.Clear();
            txtEmpName.Clear();
            txtSalary.Clear();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            txtSearch.Enabled = true;
            DtbReminder.Text = DateTime.Now.ToShortDateString();
        }
        private void showData()
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Employee", "");
            if ((tbl.Rows.Count <= 0))
            {
                MessageBox.Show("لا يوجد بيانات فى هذه الشاشة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try{
                txtID.Text = tbl.Rows[introw][0].ToString();
                txtEmpName.Text = tbl.Rows[introw][1].ToString();
                txtSalary.Text = tbl.Rows[introw][2].ToString();
                }
                catch (Exception) { }
                try
                {
                    this.Text = tbl.Rows[introw][3].ToString();
                    DateTime dt = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                    DtbReminder.Value = dt;
                }
                catch (Exception) { }
                try{
                txtPhone.Text = tbl.Rows[introw][4].ToString();
                txtIDNationalty.Text = tbl.Rows[introw][5].ToString();
                txtAddress.Text = tbl.Rows[introw][6].ToString();
                }
                catch (Exception) { }
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
            }
        }
        private void Frm_Employee_Load(object sender, EventArgs e)
        {
            AutoNum();
        }
        DataTable tblCustmoer = new DataTable();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            try
            {
                tblCustmoer.Clear();
                tblCustmoer = db.RunReader("select Emp_Name from Employee", "");
                if (tblCustmoer.Rows.Count >= 1)
                {
                    for (int i = 0; i <= tblCustmoer.Rows.Count - 1; i++)
                    {
                        if (txtEmpName.Text == tblCustmoer.Rows[0][i].ToString())
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
                string d = DtbReminder.Value.ToString("dd/MM/yyyy");
                db.RunNunQuary("insert into Employee values(" + txtID.Text + ",N'" + txtEmpName.Text + "' ,N'" + txtSalary.Text + "' ,'" + d + "' ,N'" + txtPhone.Text + "' ,N'" + txtIDNationalty.Text + "' ,N'" + txtAddress.Text + "')", "تم اضافه بيانات الموظف بنجاح");
                AutoNum();
            }
            catch (Exception)
            { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            try
            {
                tblCustmoer.Clear();
                tblCustmoer = db.RunReader("select Emp_Name from Employee", "");
                if (tblCustmoer.Rows.Count >= 1)
                {
                    for (int i = 0; i <= tblCustmoer.Rows.Count - 1; i++)
                    {
                        if (txtEmpName.Text == tblCustmoer.Rows[0][i].ToString())
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
                string d = DtbReminder.Value.ToString("dd/MM/yyyy");
                db.RunNunQuary("update Employee set Emp_Name=N'" + txtEmpName.Text + "' ,Emp_Salary=N'" + txtSalary.Text + "' ,Emp_Date='" + d + "' ,Emp_Phone=N'" + txtPhone.Text + "' ,Emp_Natio_ID=N'" + txtIDNationalty.Text + "' ,Emp_Address=N'" + txtAddress.Text + "' where Emp_ID=" + txtID.Text + "", "تم تعديل بيانات الموظف بنجاح");
                AutoNum();
            }
            catch (Exception)
            { }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AutoNum();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Employee where Emp_ID=" + txtID.Text + " ", "تم حذف بيانات الموظف بنجاح");
                AutoNum();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Employee  ", "تم حذف جميع بيانات الموظفين بنجاح");
                AutoNum();
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
                tblSearch = db.RunReader("select * from Employee where Emp_Name  Like N'%" + txtSearch.Text + "%' ", "");
                if ((tblSearch.Rows.Count <= 0))
                {
                    MessageBox.Show("لا يوجد اسم موظف مماثل لهذا", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtID.Text = tblSearch.Rows[0][0].ToString();
                    txtEmpName.Text = tblSearch.Rows[0][1].ToString();
                    txtSalary.Text = tblSearch.Rows[0][2].ToString();
                    try
                    {
                        this.Text = tblSearch.Rows[0][3].ToString();
                        DateTime dt = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                        DtbReminder.Value = dt;
                    }
                    catch (Exception) { }
                    txtPhone.Text = tblSearch.Rows[0][4].ToString();
                    txtIDNationalty.Text = tblSearch.Rows[0][5].ToString();
                    txtAddress.Text = tblSearch.Rows[0][6].ToString();
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDeleteAll.Enabled = true;
                }
            }
            }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (introw == 0)
            {
                tbl.Clear();
                tbl = db.RunReader("select * from Employee", "");
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
            tbl = db.RunReader("select * from Employee", "");

            if (introw == 0)
            {
                introw++;
                showData();

            }
            else if (introw == tbl.Rows.Count - 1)
            {
                introw = 0;
                showData();
            }
            else
            {
                introw += 1;
                showData();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            introw = 0;
            showData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Employee", "");
            introw = tbl.Rows.Count - 1;
            showData();
        }
    }
}
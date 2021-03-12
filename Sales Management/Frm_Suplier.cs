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
    public partial class Frm_Suplier : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Suplier()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        int introw = 0;

        public void AutoNum()
        {
            tbl.Clear();
            tbl = db.RunReader("Select Max(Sup_ID) from Suplier", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
                txtSupID.Text = "1";
            else
                txtSupID.Text = (Convert.ToInt32(tbl.Rows[0][0].ToString()) + 1).ToString();
            txtSupAddress.Clear();
            txtSupName.Clear();
            txtPhone1.Clear();
            txtSearch.Clear();
            txtSupCode.Clear();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            txtSearch.Enabled = true;
        }
        private void showData()
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Suplier", "");
            if ((tbl.Rows.Count <= 0))
            {
                MessageBox.Show("لا يوجد بيانات فى هذه الشاشة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try{
                txtSupID.Text = tbl.Rows[introw][0].ToString();
                txtSupName.Text = tbl.Rows[introw][1].ToString();
                txtSupAddress.Text = tbl.Rows[introw][2].ToString();
                txtPhone1.Text = tbl.Rows[introw][3].ToString();
                txtSupCode.Text = tbl.Rows[introw][4].ToString();
                }
                catch (Exception) { }
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
            }
        }
        private void Frm_Suplier_Load(object sender, EventArgs e)
        {
            AutoNum();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                DataTable tblSearch = new DataTable();
                tblSearch.Clear();
                tblSearch = db.RunReader("select * from Suplier where Sup_Name Like N'%" + txtSearch.Text + "%' ", "");
                if ((tblSearch.Rows.Count <= 0))
                {
                    MessageBox.Show("لا يوجد اسم مورد مماثل لهذا", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtSupID.Text = tblSearch.Rows[0][0].ToString();
                    txtSupName.Text = tblSearch.Rows[0][1].ToString();
                    txtSupAddress.Text = tblSearch.Rows[0][2].ToString();
                    txtPhone1.Text = tblSearch.Rows[0][3].ToString();
                    txtSupCode.Text = tblSearch.Rows[0][4].ToString();
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDeleteAll.Enabled = true;
                }
            }
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
                tbl = db.RunReader("select * from Suplier", "");
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
            tbl = db.RunReader("select * from Suplier", "");

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

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Suplier", "");
            introw = tbl.Rows.Count - 1;
            showData();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtSearch.Text != "")
                {
                    DataTable tblSearch = new DataTable();
                    tblSearch.Clear();
                    tblSearch = db.RunReader("select * from Suplier where Sup_Name Like N'%" + txtSearch.Text + "%' ", "");
                    if ((tblSearch.Rows.Count <= 0))
                    {
                        MessageBox.Show("لا يوجد اسم مورد مماثل لهذا", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtSupID.Text = tblSearch.Rows[0][0].ToString();
                        txtSupName.Text = tblSearch.Rows[0][1].ToString();
                        txtSupAddress.Text = tblSearch.Rows[0][2].ToString();
                        txtPhone1.Text = tblSearch.Rows[0][3].ToString();
                        btnAdd.Enabled = false;
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnDeleteAll.Enabled = true;
                    }
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSupName.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                db.RunNunQuary("insert into Suplier values(" + txtSupID.Text + ",N'" + txtSupName.Text + "',N'" + txtSupAddress.Text + "',N'" + txtPhone1.Text + "',N'" + txtSupCode.Text + "')", "تم اضافه بيانات المورد بنجاح");
                AutoNum();
            }
            catch (Exception)
            { }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            Frm_Suplier_Load(null, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSupName.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                db.RunNunQuary("update Suplier set Sup_Name=N'" + txtSupName.Text + "',Sup_Address=N'" + txtSupAddress.Text + "',Sup_Phone=N'" + txtPhone1.Text + "',Sup_Code=N'" + txtSupCode.Text + "'  where Sup_ID=" + txtSupID.Text + "", "تم حفظ بيانات المورد بنجاح");
                AutoNum();
            }
            catch (Exception)
            { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Suplier where Sup_ID=" + txtSupID.Text + " ", "تم حذف بيانات المورد بنجاح");
                AutoNum();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Suplier", "تم حذف بيانات الموردين بنجاح");
                AutoNum();
            }
        }

        private void Frm_Suplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {
                Frm_BuySuperMarket.GetMainForm.FillCustomer();
            
            }
            catch (Exception) { }
        }
    }
}
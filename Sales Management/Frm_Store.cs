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
    public partial class Frm_Store : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Store()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable();
        DataTable tblSearch = new DataTable();
        DB db = new DB();
        int introw = 0;
        public void AutoNum()
        {
            tbl.Clear();
            tbl = db.RunReader("Select Max(Store_ID) from Store", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
                txtItemID.Text = "1";
            else
                txtItemID.Text = (Convert.ToInt32(tbl.Rows[0][0].ToString()) + 1).ToString();
            txtItemName.Clear();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
        }
        private void ShowData()
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Store", "");
            if ((tbl.Rows.Count <= 0))
            {
                MessageBox.Show("لا يوجد بيانات فى هذه الشاشة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    txtItemID.Text = tbl.Rows[introw][0].ToString();
                    txtItemName.Text = tbl.Rows[introw][1].ToString();
                }
                catch (Exception) { }
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
            }
        }
        private void Frm_Store_Load(object sender, EventArgs e)
        {
            AutoNum();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AutoNum();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                db.RunNunQuary("insert into Store values(" + txtItemID.Text + ",N'" + txtItemName.Text + "')", "تم اضافه بيانات المخزن بنجاح");
                AutoNum();
            }
            catch (Exception)
            { }
        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                db.RunNunQuary("update Store set Store_Name=N'" + txtItemName.Text + "' where Store_ID=" + txtItemID.Text + "", "تم حفظ بيانات المخزن بنجاح");
                AutoNum();
            }
            catch (Exception)
            { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Store where Store_ID=" + txtItemID.Text + "", "تم حذف بيانات المخزن المحدد بنجاح");
                AutoNum();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Store", "تم حذف جميع البيانات بنجاح");
                AutoNum();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            introw = 0;
            ShowData();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (introw == 0)
            {
                tbl.Clear();
                tbl = db.RunReader("select * from store", "");
                introw = tbl.Rows.Count - 1;

                ShowData();

            }
            else
            {
                introw -= 1;
                ShowData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.RunReader("select * from store", "");

            if (introw == 0)
            {
                introw++;
                ShowData();

            }
            else if (introw == tbl.Rows.Count - 1)
            {
                introw = 0;
                ShowData();
            }
            else
            {
                introw += 1;
                ShowData();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Store", "");
            introw = tbl.Rows.Count - 1;
            ShowData();
        }

        private void Frm_Store_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {
               Frm_BuySuperMarket.GetMainForm.FillStore();
            }
            catch (Exception) { }
        }
    }
}
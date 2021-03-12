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
    public partial class Frm_Stock : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Stock()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        DB db = new DB();
        int introw = 0;

        public void AutoNum()
        {
            tbl.Clear();
            tbl = db.RunReader("Select Max(Stock_ID) from Stock_Data", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
                txtDesID.Text = "1";
            else
                txtDesID.Text = (Convert.ToInt32(tbl.Rows[0][0].ToString()) + 1).ToString();
            txtDesName.Clear();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
        }
        private void showData()
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Stock_Data", "");
            if ((tbl.Rows.Count <= 0))
            {
                MessageBox.Show("لا يوجد بيانات فى هذه الشاشة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try{
                txtDesID.Text = tbl.Rows[introw][0].ToString();
                txtDesName.Text = tbl.Rows[introw][1].ToString();
                }
                catch (Exception) { }
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
            }
        }

        private void Frm_Stock_Load(object sender, EventArgs e)
        {
            AutoNum();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDesName.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                db.RunNunQuary("insert into Stock_Data values(" + txtDesID.Text + ",'" + txtDesName.Text + "')", "تم اضافه بيانات الخزنه بنجاح");
                AutoNum();
            }
            catch (Exception)
            { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDesName.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                db.RunNunQuary("update Stock_Data set Stock_Name='" + txtDesName.Text + "' where Stock_ID=" + txtDesID.Text + " ", "تم حفظ بيانات الخزنه بنجاح");
                AutoNum();
            }
            catch (Exception)
            { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Stock_Data where Stock_ID=" + txtDesID.Text + " ", "تم حذف بيانات الخزنه بنجاح");
                AutoNum();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Stock_Data", "تم حذف جميع البيانات  بنجاح");
                AutoNum();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
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
                tbl = db.RunReader("select * from Stock_Data", "");
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
            tbl = db.RunReader("select * from Stock_Data", "");

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
            tbl = db.RunReader("select * from Stock_Data", "");
            introw = tbl.Rows.Count - 1;
            showData();
        }
    }
}
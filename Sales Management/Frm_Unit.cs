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
    public partial class Frm_Unit : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Unit()
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
            tbl = db.RunReader("Select Max(Unit_ID) from Unit", "");
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
            tbl = db.RunReader("select * from Unit", "");
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

        private void Frm_Unit_Load(object sender, EventArgs e)
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
                db.RunNunQuary("insert into Unit values(" + txtItemID.Text + ",N'" + txtItemName.Text + "')", "تم اضافه بيانات الوحدة بنجاح");
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
                db.RunNunQuary("update Unit set Unit_Name=N'" + txtItemName.Text + "' where Unit_ID=" + txtItemID.Text + "", "تم حفظ بيانات الوحدة بنجاح");
                AutoNum();
            }
            catch (Exception)
            { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Unit where Unit_ID=" + txtItemID.Text + "", "تم حذف بيانات الوحدة بنجاح");
                AutoNum();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Unit ", "تم حذف جميع البيانات بنجاح");
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
                tbl = db.RunReader("select * from unit", "");
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
            tbl = db.RunReader("select * from unit", "");

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
            tbl = db.RunReader("select * from Unit", "");
            introw = tbl.Rows.Count - 1;
            ShowData();
        }

        private void Frm_Unit_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Frm_Items.GetMainForm.cbxUnit.DataSource = db.RunReader("select * from Unit", "");
                Frm_Items.GetMainForm.cbxUnit.DisplayMember = "Unit_Name";
                Frm_Items.GetMainForm.cbxUnit.ValueMember = "Unit_ID";


                Frm_Items.GetMainForm.cbxUnitBuy.DataSource = db.RunReader("select * from Unit", "");
                Frm_Items.GetMainForm.cbxUnitBuy.DisplayMember = "Unit_Name";
                Frm_Items.GetMainForm.cbxUnitBuy.ValueMember = "Unit_ID";

                Frm_Items.GetMainForm.cbxUnitSales.DataSource = db.RunReader("select * from Unit", "");
                Frm_Items.GetMainForm.cbxUnitSales.DisplayMember = "Unit_Name";
                Frm_Items.GetMainForm.cbxUnitSales.ValueMember = "Unit_ID";

                Frm_Items.GetMainForm.cbxMainUnit.DataSource = db.RunReader("select * from Unit", "");
                Frm_Items.GetMainForm.cbxMainUnit.DisplayMember = "Unit_Name";
                Frm_Items.GetMainForm.cbxMainUnit.ValueMember = "Unit_ID";
            }
            catch (Exception) { }
        }
    }
}
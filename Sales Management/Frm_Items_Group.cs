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
    public partial class Frm_Items_Group : DevExpress.XtraEditors.XtraForm
    {
        private static Frm_Items_Group frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_Items_Group GetMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_Items_Group();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public Frm_Items_Group()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }


        DB db = new DB();
        DataTable tbl = new DataTable();

        DataTable tblItems = new DataTable();
        int introw = 0;
        public void AutoNum()
        {
            tbl.Clear();
            tbl = db.RunReader("Select Max(G_ID) from Items_Group", "");
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
            tbl = db.RunReader("select * from Items_Group", "");
            if ((tbl.Rows.Count <= 0))
            {
                MessageBox.Show("لا يوجد بيانات فى هذه الشاشة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try{
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


        private void Frm_Items_Group_Load(object sender, EventArgs e)
        {
            tblItems.Clear();
            tblItems = db.RunReader("select G_ID as 'الرقم' ,G_Name as 'اسم المجموعه' from Items_Group", "");
            DgvBuyDetalis.DataSource = tblItems;
            AutoNum();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Frm_Items_Group_Load(null, null);
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
                db.RunNunQuary("insert into Items_Group values(" + txtItemID.Text + ",N'" + txtItemName.Text + "')", "تم اضافه بيانات المجموعه بنجاح");
                Frm_Items_Group_Load(null, null);
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
                db.RunNunQuary("update  Items_Group set G_Name=N'" + txtItemName.Text + "' where G_ID=" + txtItemID.Text + "", "تم حفظ بيانات المجموعه بنجاح");
                Frm_Items_Group_Load(null, null);
            }
            catch (Exception)
            { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد سيتم جميع المنتجات المتعلقه بهذا التصنيف ؟؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Items_Group where G_ID=" + txtItemID.Text + "", "");
                db.RunNunQuary("delete  from Items where G_ID=" + txtItemID.Text + "", "تم حذف بيانات المجموعه المحدده بنجاح مع بيانات المنتجات المتعلقه بها");
                Frm_Items_Group_Load(null, null);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Items_Group ", "");

                db.RunNunQuary("delete  from Items ", "تم حذف بيانات جمبع المجموعات المحدده بنجاح مع بيانات المنتجات المتعلقه بها");
                Frm_Items_Group_Load(null, null);
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
                MessageBox.Show("هذا اول سجل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                introw -= 1;
                ShowData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (introw >= tbl.Rows.Count - 1)
                MessageBox.Show("هذا اخر سجل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                introw += 1;
                ShowData();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Items_Group", "");
            introw = tbl.Rows.Count - 1;
            ShowData();
        }

        private void Frm_Items_Group_FormClosing(object sender, FormClosingEventArgs e)
        {
           /* try
            {
                Frm_Items_View.GetMainForm.cbxGroup.DataSource = db.RunReader("select * from Items_Group", "");
                Frm_Items_View.GetMainForm.cbxGroup.DisplayMember = "G_Name";
                Frm_Items_View.GetMainForm.cbxGroup.ValueMember = "G_ID";
            }
            catch (Exception) { }*/
            try
            {
                Frm_Items.GetMainForm.FillGroups();
            }
            catch (Exception) { }
        }
    }
}
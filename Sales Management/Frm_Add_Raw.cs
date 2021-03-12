using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales_Management
{
    public partial class Frm_Add_Raw : Form
    {
        private static Frm_Add_Raw frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_Add_Raw GetMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_Add_Raw();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }


        public Frm_Add_Raw()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        int introw = 0;

        public void AutoNum()
        {
            tbl.Clear();
            tbl = db.RunReader("Select Max(Raw_ID) from Raw", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
                txtItemID.Text = "1";
            else
                txtItemID.Text = (Convert.ToInt32(tbl.Rows[0][0].ToString()) + 1).ToString();
            NudBuyPrice.Value = 1;
            NudCountInMainUnit.Value = 1;
            NudQty.Value = 1;
            NudSalePrice.Value =1;
            NudQty.Value = 1;
            txtItemName.Clear();
            try
            {
                cbxItems.SelectedIndex = 0;
                cbxMainUnit.SelectedIndex = 0;
                cbxUnitSmall.SelectedIndex = 0;
            }
            catch (Exception) { }
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;

        }
        public void FillRaw()
        {

            cbxItems.DataSource = db.RunReader("select * from Raw", "");
            cbxItems.DisplayMember = "Raw_Name";
            cbxItems.ValueMember = "Raw_ID";
        }
        public void FillUnit()
        {

            cbxMainUnit.DataSource = db.RunReader("select * from Unit", "");
            cbxMainUnit.DisplayMember = "Unit_Name";
            cbxMainUnit.ValueMember = "Unit_ID";

            cbxUnitSmall.DataSource = db.RunReader("select * from Unit", "");
            cbxUnitSmall.DisplayMember = "Unit_Name";
            cbxUnitSmall.ValueMember = "Unit_ID";
        }
        private void ShowData()
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Raw", "");
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
                    cbxMainUnit.Text = tbl.Rows[introw][2].ToString();
                    cbxUnitSmall.Text = tbl.Rows[introw][3].ToString();
                    NudCountInMainUnit.Value = Convert.ToDecimal(tbl.Rows[introw][4]);
                    NudBuyPrice.Value = Convert.ToDecimal(tbl.Rows[introw][5]);
                    NudSalePrice.Value = Convert.ToDecimal(tbl.Rows[introw][6]);
                    NudQty.Value = Convert.ToDecimal(tbl.Rows[introw][7]);
                }
                catch (Exception) { }
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
            }
        }
        private void Frm_Add_Raw_Load(object sender, EventArgs e)
        {
            try {
                AutoNum();
            }catch(Exception){}
            try
            {
                FillUnit();
            }
            catch (Exception) { }
            try
            {
                FillRaw();
            }
            catch (Exception) { }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            Frm_Unit frm = new Frm_Unit();
            frm.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Frm_Unit frm = new Frm_Unit();
            frm.ShowDialog();
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
                tbl = db.RunReader("select * from Raw", "");
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
            tbl = db.RunReader("select * from Raw", "");

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
            tbl = db.RunReader("select * from Raw", "");
            introw = tbl.Rows.Count - 1;
            ShowData();
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "" || cbxMainUnit.Items.Count <= 0 || NudCountInMainUnit.Value == 0)
            {
                MessageBox.Show("من فضلك اكمل البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (NudCountInMainUnit.Value <= 0)
            {
                MessageBox.Show("لا يمكن ان يكون عدد الوحدة الصغري داخل الوحده الكبرى اقل من 1", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                db.RunNunQuary("insert into Raw values(" + txtItemID.Text + ",N'" + txtItemName.Text + "',N'"+cbxMainUnit.Text+"' ,N'"+cbxUnitSmall.Text+"' ,"+NudCountInMainUnit.Value+" ,"+NudBuyPrice.Value+" ,"+NudSalePrice.Value+" , "+NudQty.Value+")", "تم اضافه بيانات الخامة بنجاح");
                FillRaw();
                AutoNum();
            }
            catch (Exception)
            { }
             
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Raw where Raw_ID="+cbxItems.SelectedValue+"", "");
            
                try
                {
                    txtItemID.Text = tbl.Rows[0][0].ToString();
                    txtItemName.Text = tbl.Rows[0][1].ToString();
                    cbxMainUnit.Text = tbl.Rows[0][2].ToString();
                    cbxUnitSmall.Text = tbl.Rows[0][3].ToString();
                    NudCountInMainUnit.Value = Convert.ToDecimal(tbl.Rows[0][4]);
                    NudBuyPrice.Value = Convert.ToDecimal(tbl.Rows[0][5]);
                    NudSalePrice.Value = Convert.ToDecimal(tbl.Rows[0][6]);
                    NudQty.Value = Convert.ToDecimal(tbl.Rows[0][7]);
                }
                catch (Exception) { }
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try {
                AutoNum();
            }
            catch (Exception) { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "" || cbxMainUnit.Items.Count <= 0 || NudCountInMainUnit.Value == 0)
            {
                MessageBox.Show("من فضلك اكمل البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                db.RunNunQuary("update Raw set Raw_Name=N'" + txtItemName.Text + "',Main_Unit=N'" + cbxMainUnit.Text + "' ,Small_Unit=N'" + cbxUnitSmall.Text + "' ,CountInMainUnit=" + NudCountInMainUnit.Value + " ,Price_Buy=" + NudBuyPrice.Value + " ,Price_Sale=" + NudSalePrice.Value + " , Qty=" + NudQty.Value + " where Raw_ID=" + txtItemID.Text + "", "تم حفظ بيانات الخامة بنجاح");
                FillRaw();
                AutoNum();
            }
            catch (Exception)
            { }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Raw where Raw_ID=" + txtItemID.Text + " ", "تم حذف بيانات الخامة بنجاح");
                AutoNum();
            }
        
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Raw ", "تم حذف جميع بيانات الخامات بنجاح");
                AutoNum();
            }
        }
    }
}

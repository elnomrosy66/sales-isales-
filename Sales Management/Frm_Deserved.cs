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
    public partial class Frm_Deserved : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Deserved()
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
            tbl = db.RunReader("Select Max(Des_ID) from Deserved", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
                txtDesID.Text = "1";
            else
                txtDesID.Text = (Convert.ToInt32(tbl.Rows[0][0].ToString()) + 1).ToString();
            if (cbxType.Items.Count >= 1)
                cbxType.SelectedIndex = 0;
            NudPrice.Value = 1;
            DtbDate.Text = DateTime.Now.ToShortDateString();
            txtNotes.Clear();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
        }
        private void ShowData()
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Deserved", "");
            if ((tbl.Rows.Count <= 0))
            {
                MessageBox.Show("لا يوجد بيانات فى هذه الشاشة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {  try {
                txtDesID.Text = tbl.Rows[introw][0].ToString();
                cbxType.SelectedValue = tbl.Rows[introw][1].ToString();
                this.Text = tbl.Rows[introw][2].ToString();
                DateTime dt = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                DtbDate.Value = dt;
                NudPrice.Value = Convert.ToDecimal(tbl.Rows[introw][3]);
                txtNotes.Text = tbl.Rows[introw][4].ToString();
                }
                catch (Exception) { }
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
            }
        }
        private void FillCustomer()
        {
            cbxType.DataSource = db.RunReader("select * from Deserved_Type", "");
            cbxType.DisplayMember = "Des_Type";
            cbxType.ValueMember = "Des_ID";
        }
        int stock_ID;
        private void Frm_Deserved_Load(object sender, EventArgs e)
        {
            FillCustomer();
            AutoNum();
            
            stock_ID =Convert.ToInt32(Properties.Settings.Default.UserStock);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AutoNum();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxType.Text == "")
            { MessageBox.Show("من فضلك ادخل انواع المصروفات اولا من شاشة انواع المصروفات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            DataTable tblCheck = new DataTable();
            tblCheck.Clear();
            try
            {
                tblCheck = db.RunReader("select * from Stock where Stock_ID="+stock_ID+"", "");
                decimal Money = Convert.ToDecimal(tblCheck.Rows[0][0]);
                decimal total = Convert.ToDecimal(NudPrice.Value);
                if (Money - total < 0)
                {
                    MessageBox.Show("لا يوجد رصيد كافى فى الخزنه لاتمام العملية", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string d = DtbDate.Value.ToString("dd/MM/yyyy");
                db.RunNunQuary("insert into Deserved values(" + txtDesID.Text + "," + cbxType.SelectedValue + ",'" + d + "'," + NudPrice.Value + ",N'" + txtNotes.Text + "')", "تم اضافه بيانات المصروف بنجاح");
                db.RunNunQuary("update Stock set Money=Money - " + NudPrice.Value + " where Stock_ID="+stock_ID+"", "");
                db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type,Stock_ID) Values(" + NudPrice.Value + " ,'" + d + "' ,N'مصروف' N,'مصروفات' , "+stock_ID+")", "");


                AutoNum();
            }
            catch (Exception)
            { }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string d = DtbDate.Value.ToString("dd/MM/yyyy");
                db.RunNunQuary("update  Deserved set Type=" + cbxType.SelectedValue + ",Date='" + d + "',Price=" + NudPrice.Value + " ,Notes=N'" + txtNotes.Text + "' where Des_ID=" + txtDesID.Text + "", "تم حفظ بيانات المصروف بنجاح");
                AutoNum();
            }
            catch (Exception)
            { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Deserved where Des_ID=" + txtDesID.Text + "", "تم حذف بيانات المصروف المحدد بنجاح");
                AutoNum();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Deserved ", "تم حذف بيانات جميع المصروفات المحدد بنجاح");
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
                tbl = db.RunReader("select * from Deserved", "");
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
            tbl = db.RunReader("select * from Deserved", "");

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
            tbl = db.RunReader("select * from Deserved", "");
            introw = tbl.Rows.Count - 1;
            ShowData();
        }
    }
}
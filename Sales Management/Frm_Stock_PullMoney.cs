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
    public partial class Frm_Stock_PullMoney : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Stock_PullMoney()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable();
        DB db = new DB();
        private void FillStock()
        {

            cbxType.DataSource = db.RunReader("select * from Stock_Data", "");
            cbxType.DisplayMember = "Stock_Name";
            cbxType.ValueMember = "Stock_ID";
        }
        private void Frm_Stock_PullMoney_Load(object sender, EventArgs e)
        {

            FillStock();
            tbl.Clear();
            tbl = db.RunReader("select * from Stock where Stock_ID=" + cbxType.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.RunNunQuary("insert into Stock Values (0," + cbxType.SelectedValue + ")", "");
                tbl.Clear();
                tbl = db.RunReader("select * from Stock where Stock_ID=" + cbxType.SelectedValue + "", "");
            }
            if (Convert.ToInt32(tbl.Rows[0][0]) <= 0)
            {
                lblCurrentMoney.Text = "0" + "";
            }
            else if (Convert.ToInt32(tbl.Rows[0][0]) >= 1)
            {
                lblCurrentMoney.Text = tbl.Rows[0][0] + "";
            }
            NudMoney.Value = 0;
            txtReason.Clear();
            txtItemName.Clear();
            DtbDate.Text = DateTime.Now.ToShortDateString();

        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbl.Clear();
            int id = 0;
            if (cbxType.SelectedIndex == 0) { id = 1; } else { id = Convert.ToInt32(cbxType.SelectedValue); }
            tbl = db.RunReader("select * from Stock where Stock_ID=" + id + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.RunNunQuary("insert into Stock Values (0," + id + ")", "");
                tbl.Clear();
                tbl = db.RunReader("select * from Stock where Stock_ID=" + id + "", "");
            }
            if (Convert.ToInt32(tbl.Rows[0][0]) <= 0)
            {
                lblCurrentMoney.Text = "0" + "";
            }
            else if (Convert.ToInt32(tbl.Rows[0][0]) >= 1)
            {
                lblCurrentMoney.Text = tbl.Rows[0][0] + "";
            }
            NudMoney.Value = 0;
            txtItemName.Clear();
            DtbDate.Text = DateTime.Now.ToShortDateString();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string d = DtbDate.Value.ToString("dd/MM/yyyy");
            if (txtItemName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الساحب", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable tblCheck = new DataTable();
            tblCheck.Clear();
            tblCheck = db.RunReader("select * from Stock where Stock_ID=" + cbxType.SelectedValue + "", "");
            decimal Money = Convert.ToDecimal(tblCheck.Rows[0][0]);
            decimal total = Convert.ToDecimal(NudMoney.Value);
            if (Money - total < 0)
            {
                MessageBox.Show("لا يوجد رصيد كافى فى الخزنه لاتمام العملية", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("هل انتا متاكد سيتم سحب هذا الرصيد من الخزنه", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("update Stock set Money=Money - " + NudMoney.Value + " where Stock_ID=" + cbxType.SelectedValue + "", "تم سحب الرصيد للخزنه بنجاح");
                db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type ,Reason,Stock_ID) Values(" + NudMoney.Value + " ,'" + d + "' ,N'" + txtItemName.Text + "' ,'سحب من الخزنة' ,N'" + txtReason.Text + "' ," + cbxType.SelectedValue + ")", "");

                Frm_Stock_PullMoney_Load(null, null);
            }
        }
    }
}
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
    public partial class Frm_Bank_PullMoney : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Bank_PullMoney()
        {
            InitializeComponent();
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
            tblCheck = db.RunReader("select * from Bank", "");
            decimal Money = Convert.ToDecimal(tblCheck.Rows[0][0]);
            decimal total = Convert.ToDecimal(NudMoney.Value);
            if (Money - total < 0)
            {
                MessageBox.Show("لا يوجد رصيد كافى فى البنك لاتمام العملية", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("هل انتا متاكد سيتم سحب هذا الرصيد من البنك", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("update Bank set Money=Money - " + NudMoney.Value + "", "تم سحب الرصيد من البنك بنجاح");
                db.RunNunQuary("insert into Bank_Pull  (Money ,Date,Name ,Type,Reason) Values(" + NudMoney.Value + " ,'" + d + "' ,N'" + txtItemName.Text + "' ,N'سحب من البنك' ,N'" + txtReason.Text + "')", "");

                Frm_Bank_PullMoney_Load(null, null);
            }

        }
        DataTable tbl = new DataTable();
        DB db = new DB();
        private void Frm_Bank_PullMoney_Load(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Bank", "");
            if (tbl.Rows.Count <= 0)
            {
                db.RunNunQuary("insert into Bank Values (0)", "");
                tbl.Clear();
                tbl = db.RunReader("select * from Bank", "");
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
            txtReason.Clear();
            DtbDate.Text = DateTime.Now.ToShortDateString();

        }
    }
}
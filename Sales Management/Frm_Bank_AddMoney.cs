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
    public partial class Frm_Bank_AddMoney : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Bank_AddMoney()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable();
        DB db = new DB();
        private void Frm_Bank_AddMoney_Load(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string d = DtbDate.Value.ToString("dd/MM/yyyy");
            if (txtItemName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المودع", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("هل انتا متاكد سيتم اضافة هذا الرصيد للبنك", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("update Bank set Money=Money + " + NudMoney.Value + "", "تم اضافة الرصيد للبنك بنجاح");
                db.RunNunQuary("insert into Bank_Insert  (Money ,Date,Name ,Type,Reason) Values(" + NudMoney.Value + " ,'" + d + "' ,N'" + txtItemName.Text + "' ,'رصيد اضافى',N'"+txtReason.Text+"')", "");

                Frm_Bank_AddMoney_Load(null, null);
            }
        }
    }
}
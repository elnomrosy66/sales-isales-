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
    public partial class Frm_Transfire_StockBank : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Transfire_StockBank()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable(); DataTable tblBank = new DataTable();
        DB db = new DB();
        private void FillStock()
        {

            cbxType.DataSource = db.RunReader("select * from Stock_Data", "");
            cbxType.DisplayMember = "Stock_Name";
            cbxType.ValueMember = "Stock_ID";
        }
        private void Frm_Transfire_StockBank_Load(object sender, EventArgs e)
        {
            try
            {
                FillStock();
                tbl.Clear();
                tbl = db.RunReader("select * from Stock where Stock_ID=" + cbxType.SelectedValue + "", "");
                if (tbl.Rows.Count <= 0)
                {
                    db.RunNunQuary("insert into Stock Values (0 ," + cbxType.SelectedValue + ")", "");
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
                txtItemName.Clear();
                DtbDate.Text = DateTime.Now.ToShortDateString();

            }
            catch (Exception) { }

            try
            {
                tblBank.Clear();
                tblBank = db.RunReader("select * from Bank", "");
                if (tblBank.Rows.Count <= 0)
                {
                    db.RunNunQuary("insert into Bank Values (0)", "");
                    tblBank.Clear();
                    tblBank = db.RunReader("select * from Bank", "");
                }
                if (Convert.ToInt32(tblBank.Rows[0][0]) <= 0)
                {
                    lblMoneyBank.Text = "0" + "";
                }
                else if (Convert.ToInt32(tblBank.Rows[0][0]) >= 1)
                {
                    lblMoneyBank.Text = tblBank.Rows[0][0] + "";
                }

            }
            catch (Exception) { }
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
            if (rbtnFromStockToBank.Checked == true)
            {

                TransfireFromStockToBank();
            }
            else if (rbtnFromBankToStock.Checked == true)
            {
                TransfireFromBankToStock();
            }
        }


        private void TransfireFromStockToBank()
        {
            if (NudMoney.Value <= 0 || txtItemName.Text == "") { MessageBox.Show("من فضلك اكمل البيانات اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            string d = DtbDate.Value.ToString("dd/MM/yyyy");
            DataTable tblCheck = new DataTable();
            tblCheck.Clear();
            tblCheck = db.RunReader("select * from Stock where Stock_ID="+cbxType.SelectedValue+"", "");
            decimal Money = Convert.ToDecimal(tblCheck.Rows[0][0]);
            decimal total = Convert.ToDecimal(NudMoney.Value);
            if (Money - total < 0)
            {
                MessageBox.Show("لا يوجد رصيد كافى فى الخزنه لاتمام العملية", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            db.RunNunQuary("update Stock set Money=Money - " + NudMoney.Value + " where Stock_ID=" + cbxType.SelectedValue + "", "");
            db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type ,Reason,Stock_ID) Values(" + NudMoney.Value + " ,'" + d + "' ,N'" + txtItemName.Text + "' ,'سحب من الخزنة' ,'تحويل للبنك'," + cbxType.SelectedValue + ")", "");

            db.RunNunQuary("update Bank set Money=Money + " + NudMoney.Value + "", "");
            db.RunNunQuary("insert into Bank_Insert  (Money ,Date,Name ,Type) Values(" + NudMoney.Value + " ,'" + d + "' ,N'" + txtItemName.Text + "' ,'تحويل من الخزنه الى البنك')", "");
            db.RunNunQuary("insert into Money_Transfire (Money ,Date,Name ,From_ ,To_,Stock_ID) Values(" + NudMoney.Value + " ,'" + d + "' ,N'" + txtItemName.Text + "' ,'Stock' ,'Bank' ," + cbxType.SelectedValue + ")", "تمت عملية التحويل من الخزنة للبنك بنجاح");
            Frm_Transfire_StockBank_Load(null, null);
        }
        private void TransfireFromBankToStock()
        {
            if (NudMoney.Value <= 0 || txtItemName.Text == "") { MessageBox.Show("من فضلك اكمل البيانات اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            string d = DtbDate.Value.ToString("dd/MM/yyyy");
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
            db.RunNunQuary("update Bank set Money=Money - " + NudMoney.Value + "", "");
            db.RunNunQuary("insert into Bank_Pull  (Money ,Date,Name ,Type) Values(" + NudMoney.Value + " ,'" + d + "' ,N'" + txtItemName.Text + "' ,'سحب من الخزنة')", "");

            db.RunNunQuary("update Stock set Money=Money + " + NudMoney.Value + " where Stock_ID=" + cbxType.SelectedValue + "", "");
            db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type,Reason,Stock_ID) Values(" + NudMoney.Value + " ,'" + d + "' ,N'" + txtItemName.Text + "' ,'تحويل من البنك الى الخزنه' ,'تحويل الى الخزنه'," + cbxType.SelectedValue + ")", "");
            db.RunNunQuary("insert into Money_Transfire (Money ,Date,Name ,From_ ,To_,Stock_ID) Values(" + NudMoney.Value + " ,'" + d + "' ,N'" + txtItemName.Text + "' ,'Bank' ,'Stock' ," + cbxType.SelectedValue + ")", "تمت عملية التحويل من البنك  الى الخزنه بنجاح");
            Frm_Transfire_StockBank_Load(null, null);
        }


    }
}
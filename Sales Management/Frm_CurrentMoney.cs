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
    public partial class Frm_CurrentMoney : DevExpress.XtraEditors.XtraForm
    {
        public Frm_CurrentMoney()
        {
            InitializeComponent();
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
        }
        DataTable tbl = new DataTable(); DataTable tblstock = new DataTable();
        DB db = new DB();
        private void FillStock()
        {

            cbxType.DataSource = db.RunReader("select * from Stock_Data", "");
            cbxType.DisplayMember = "Stock_Name";
            cbxType.ValueMember = "Stock_ID";
        }
        private void Frm_CurrentMoney_Load(object sender, EventArgs e)
        {
            FillStock();
            tbl.Clear();
            tbl = db.RunReader("select * from Bank", "");
            try
            {
                if (tbl.Rows.Count <= 0)
                {
                    db.RunNunQuary("insert into Bank Values (0)", "");
                    tbl.Clear();
                    tbl = db.RunReader("select * from Bank", "");
                }
                if (Convert.ToInt32(tbl.Rows[0][0]) <= 0)
                {
                    lblCurrentMoneybank.Text = "0" + "";
                }
                else if (Convert.ToInt32(tbl.Rows[0][0]) >= 1)
                {
                    lblCurrentMoneybank.Text = tbl.Rows[0][0] + "";
                }
            }
            catch (Exception) { }

            try
            {

                tblstock.Clear();
                tblstock = db.RunReader("select * from Stock where Stock_ID=" + cbxType.SelectedValue + "", "");
                if (tblstock.Rows.Count <= 0)
                {
                    db.RunNunQuary("insert into Stock Values (0," + cbxType.SelectedValue + ")", "");
                    tblstock.Clear();
                    tblstock = db.RunReader("select * from Stock where Stock_ID=" + cbxType.SelectedValue + "", "");
                }
                if (Convert.ToInt32(tblstock.Rows[0][0]) <= 0)
                {
                    lblCurrentMoney.Text = "0" + "";
                }
                else if (Convert.ToInt32(tblstock.Rows[0][0]) >= 1)
                {
                    lblCurrentMoney.Text = tblstock.Rows[0][0] + "";
                }
            }
            catch (Exception) { }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Frm_Stock_AddMoney frm = new Frm_Stock_AddMoney();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Bank_AddMoney frm = new Frm_Bank_AddMoney();
            frm.ShowDialog();
        }
    }
}
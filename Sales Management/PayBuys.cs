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
    public partial class PayBuys : DevExpress.XtraEditors.XtraForm
    {
        private static PayBuys frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static PayBuys GetMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new PayBuys();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public PayBuys()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        public decimal OrderID;
        public decimal OrderTotal, OrderMadfo3, OrderBaky;
        private void PayBuys_Load(object sender, EventArgs e)
        {
            OrderID = Properties.Settings.Default.OrderID;
            txtMatloub.Text = (Properties.Settings.Default.OrderTotal).ToString(); ;
            txtMadfou3.Text = (Properties.Settings.Default.OrderMadfo3).ToString(); ;
            textReminder.Text = (Properties.Settings.Default.OrderBaky).ToString();

            txtMadfou3.Focus();
        }

        private void PayBuys_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Properties.Settings.Default.OrderMadfo3 = Convert.ToDecimal(txtMadfou3.Text);
                Properties.Settings.Default.OrderBaky = Convert.ToDecimal(textReminder.Text);
                Properties.Settings.Default.Check = true;
                Properties.Settings.Default.Save();
                Close();
            }
            else if (e.KeyCode == Keys.F12)
            {
                Properties.Settings.Default.Check = false;
                Properties.Settings.Default.Save();
                Close();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Check = false;
            Properties.Settings.Default.Save();
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OrderMadfo3 = Convert.ToDecimal(txtMadfou3.Text);
            Properties.Settings.Default.OrderBaky = Convert.ToDecimal(textReminder.Text);
            Properties.Settings.Default.Check = true;
            Properties.Settings.Default.Save();
            Close();
        }

        private void txtMadfou3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal baky = Convert.ToDecimal(txtMatloub.Text) - Convert.ToDecimal(txtMadfou3.Text);
                textReminder.Text = Math.Round(baky, 2).ToString();
            }
            catch (Exception) { }
        }
    }
}
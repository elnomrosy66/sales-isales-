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
    public partial class Frm_PaySales : Form
    {
        private static Frm_PaySales frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_PaySales GetMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_PaySales();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public Frm_PaySales()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        public decimal OrderID;
        public decimal OrderTotal, OrderMadfo3, OrderBaky;
        private void Frm_PaySales_Load(object sender, EventArgs e)
        {
           OrderID= Properties.Settings.Default.OrderID ;
           txtMatloub.Text = (Properties.Settings.Default.OrderTotal).ToString(); ;
           txtMadfou3.Text= (Properties.Settings.Default.OrderMadfo3).ToString(); ;
           textReminder.Text= ( Properties.Settings.Default.OrderBaky).ToString();

            txtMadfou3.Focus();
        }

        private void Frm_PaySales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Properties.Settings.Default.OrderMadfo3 =Convert.ToDecimal( txtMadfou3.Text );
                Properties.Settings.Default.OrderBaky = Convert.ToDecimal(textReminder.Text);
                if (checkVisa.Checked == true)
                    Properties.Settings.Default.PayCridetCard = true;
                else
                    Properties.Settings.Default.PayCridetCard = false;
                Properties.Settings.Default.Check = true;
                Properties.Settings.Default.Save();
                Close();
            }
            else if (e.KeyCode == Keys.F12) { Close(); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OrderMadfo3 = Convert.ToDecimal(txtMadfou3.Text);
            Properties.Settings.Default.OrderBaky = Convert.ToDecimal(textReminder.Text);
            if (checkVisa.Checked == true)
                Properties.Settings.Default.PayCridetCard = true;
            else
                Properties.Settings.Default.PayCridetCard = false;
            Properties.Settings.Default.Check = true;
            Properties.Settings.Default.Save();
            Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Check = false;
            Properties.Settings.Default.Save();
            Close();
        }

        private void txtMadfou3_TextChanged(object sender, EventArgs e)
        {
            try {
                decimal baky =Convert.ToDecimal( txtMatloub.Text ) - Convert.ToDecimal(txtMadfou3.Text );
                textReminder.Text =Math.Round( baky,2).ToString();
            }
            catch (Exception) { }
        }
    }
}

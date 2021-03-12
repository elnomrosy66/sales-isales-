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
    public partial class Frm_EditRawQty : Form
    {
        public Frm_EditRawQty()
        {
            InitializeComponent();
        }

        private void Frm_EditRawQty_Load(object sender, EventArgs e)
        {
            txtQty.Text = Properties.Settings.Default.RawQty +"";
            txtDiscount.Text = Properties.Settings.Default.RawDiscount + "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RawQty = Convert.ToDecimal(txtQty.Text);
            Properties.Settings.Default.RawDiscount = Convert.ToDecimal(txtDiscount.Text);
            Properties.Settings.Default.Save();
            Close();
        }

        private void Frm_EditRawQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Properties.Settings.Default.RawQty = Convert.ToDecimal(txtQty.Text);
                Properties.Settings.Default.RawDiscount = Convert.ToDecimal(txtDiscount.Text);
                Properties.Settings.Default.Save();
                Close();
            }
        }
    }
}

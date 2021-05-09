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
    public partial class Frm_Qty : Form
    {
        private static Frm_Qty frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_Qty GetMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_Qty();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public Frm_Qty()
        {
            InitializeComponent();
            if (frm == null) 
                frm = this;
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        public string Item_ID, Item_qty, Item_Unit, Item_Discount, Item_Price;
        private void Frm_Qty_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SalesDiscountCkeck == false) 
            { txtDiscount.Enabled = false; }
           Item_ID= Properties.Settings.Default.Item_ID;
           Item_qty=Properties.Settings.Default.Item_qty;
           Item_Unit= Properties.Settings.Default.Item_Unit;
           Item_Discount = Properties.Settings.Default.Item_Discount;
           Item_Price= Properties.Settings.Default.Item_Price;

           txtQty.Text = Item_qty;
           txtDiscount.Text = Item_Discount;
           txtPrice.Text = Item_Price;

           cbxUnit.DataSource = db.RunReader("select * from Items_Unit where Item_ID="+Item_ID+" ", "");
           cbxUnit.DisplayMember = "Unit_Name";
           cbxUnit.ValueMember = "Unit_ID";
           cbxUnit.Text = Item_Unit;
            txtQty.Focus();
        }

        private void Frm_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                Properties.Settings.Default.Item_qty = txtQty.Text; 
                Properties.Settings.Default.Item_Unit = cbxUnit.Text;
                Properties.Settings.Default.Item_Discount = txtDiscount.Text;
                Properties.Settings.Default.Item_Price = txtPrice.Text;
                Properties.Settings.Default.Save();
                Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
             Properties.Settings.Default.Item_qty =txtQty.Text; 
             Properties.Settings.Default.Item_Unit = cbxUnit.Text;
            Properties.Settings.Default.Item_Discount= txtDiscount.Text;
            Properties.Settings.Default.Item_Price =txtPrice.Text;
            Properties.Settings.Default.Save();
            Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_Qty_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {

                int index = 0;
                    index = Frm_SalesSuperMarket.GetMainForm.DgvStoreQty.SelectedRows[0].Index;
                
                Frm_SalesSuperMarket.GetMainForm.DgvStoreQty.Rows[index].Cells[2].Value = Properties.Settings.Default.Item_Unit;
                Frm_SalesSuperMarket.GetMainForm.DgvStoreQty.Rows[index].Cells[3].Value = Properties.Settings.Default.Item_qty;
                Frm_SalesSuperMarket.GetMainForm.DgvStoreQty.Rows[index].Cells[4].Value = Properties.Settings.Default.Item_Price;
                Frm_SalesSuperMarket.GetMainForm.DgvStoreQty.Rows[index].Cells[5].Value = Properties.Settings.Default.Item_Discount;
                Properties.Settings.Default.Check = false;
                Properties.Settings.Default.Save();

            }
            catch (Exception) { }
        }

        private void Frm_Qty_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void cbxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tblUnit = new DataTable();
            tblUnit.Clear();
            int num;
            if (cbxUnit.Items.Count >= 1)
            {
                try
                {
                    tblUnit = db.RunReader("select * from Items_Unit where Item_ID=" + Item_ID + " and Unit_ID=" + cbxUnit.SelectedValue + " ", "");
                    num = Convert.ToInt32(tblUnit.Rows[0][3]);

                    txtPrice.Text = (Convert.ToDecimal(tblUnit.Rows[0][5]) / Convert.ToDecimal(num)).ToString();
                }
                catch (Exception) { }
            }
        }
        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            try
            {

            }
            catch (Exception) { };
        }


       
    }
}

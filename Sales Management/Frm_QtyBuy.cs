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
    public partial class Frm_QtyBuy : DevExpress.XtraEditors.XtraForm
    {
        private static Frm_QtyBuy frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_QtyBuy GetMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_QtyBuy();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public Frm_QtyBuy()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        DB db = new DB();
        DataTable tbl = new DataTable();
        public string Item_ID, Item_qty, Item_Unit, Item_Discount, Item_Price;
        private void Frm_QtyBuy_Load(object sender, EventArgs e)
        {
            Item_ID = Properties.Settings.Default.Item_ID;
            Item_qty = Properties.Settings.Default.Item_qty;
            Item_Unit = Properties.Settings.Default.Item_Unit;
            Item_Discount = Properties.Settings.Default.Item_Discount;
            Item_Price = Properties.Settings.Default.Item_Price;

            txtQty.Text = Item_qty;
            txtDiscount.Text = Item_Discount;
           

            cbxUnit.DataSource = db.RunReader("select * from Items_Unit where Item_ID=" + Item_ID + " ", "");
            cbxUnit.DisplayMember = "Unit_Name";
            cbxUnit.ValueMember = "Unit_ID";
            cbxUnit.Text = Item_Unit;
            txtPrice.Text = Item_Price;
            txtQty.Focus();
        }

        private void Frm_QtyBuy_KeyDown(object sender, KeyEventArgs e)
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
            Properties.Settings.Default.Item_qty = txtQty.Text;
            Properties.Settings.Default.Item_Unit = cbxUnit.Text;
            Properties.Settings.Default.Item_Discount = txtDiscount.Text;
            Properties.Settings.Default.Item_Price = txtPrice.Text;
            Properties.Settings.Default.Save();
            Close();
        }

        private void Frm_QtyBuy_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                int index = 0;
                index = Frm_SalesSuperMarket.GetMainForm.DgvStoreQty.SelectedRows[0].Index;

                Frm_BuySuperMarket.GetMainForm.DgvStoreQty.Rows[index].Cells[2].Value = Properties.Settings.Default.Item_Unit;
                Frm_BuySuperMarket.GetMainForm.DgvStoreQty.Rows[index].Cells[3].Value = Properties.Settings.Default.Item_qty;
                Frm_BuySuperMarket.GetMainForm.DgvStoreQty.Rows[index].Cells[4].Value = Properties.Settings.Default.Item_Price;
                Frm_BuySuperMarket.GetMainForm.DgvStoreQty.Rows[index].Cells[5].Value = Properties.Settings.Default.Item_Discount;
                Properties.Settings.Default.Check = false;
                Properties.Settings.Default.Save();

            }
            catch (Exception) { }
        }

        private void cbxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tblUnit = new DataTable();
            tblUnit.Clear(); DataTable tblQty = new DataTable();
            tblQty.Clear();
            int num=1;
            decimal QtyInUnit = 0;
            if (cbxUnit.Items.Count >= 1)
            {
                try
                {
                    try
                    {
                        num = Convert.ToInt32(db.RunReader("select count(Item_ID) from Items_Qty where Item_ID=" + Item_ID + " ", "").Rows[0][0]);
                    }
                    catch (Exception) { }

                    tblQty = db.RunReader("select * from Items_Qty where Item_ID=" + Item_ID + " ", "");

                    string Item_Price = tblQty.Rows[num - 1][4].ToString();

                    tblUnit = db.RunReader("select * from Items_Unit where Item_ID=" + Item_ID + " and Unit_ID=" + cbxUnit.SelectedValue + " ", "");
                    QtyInUnit = Convert.ToDecimal(tblUnit.Rows[0][3]);

                    txtPrice.Text = (Convert.ToDecimal(Item_Price) / Convert.ToDecimal(QtyInUnit)).ToString();
                }
                catch (Exception) { }
            }
        }
    }
}
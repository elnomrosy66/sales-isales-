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
    public partial class Frm_FavItems : Form
    {
        public Frm_FavItems()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        private void Frm_FavItems_Load(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.RunReader("select Item_ID as 'رقم المنتج', Item_Name as 'اسم المنتج' ,MainUnit_SaleName as 'وحدة البيع' ,MainUnit_BuyName as 'وحدة الشراء' from Items where Is_Fav=1", "");

            DgvBuyDetalis.DataSource = tbl;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                Frm_FavItems_Load(null, null);
            }
            else
            {
                tbl.Clear();
                tbl = db.RunReader("select Item_ID as 'رقم المنتج', Item_Name as 'اسم المنتج' ,MainUnit_SaleName as 'وحدة البيع' ,MainUnit_BuyName as 'وحدة الشراء' from Items where Is_Fav=1 and Item_Name like '%" + txtSearch.Text + "%'", "");

                DgvBuyDetalis.DataSource = tbl;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(DgvBuyDetalis.Rows.Count >= 1)
            {
                Properties.Settings.Default.Check = true;
                Properties.Settings.Default.QTY =Convert.ToInt32( NudQty.Value);
                Properties.Settings.Default.ItemID =Convert.ToInt32(DgvBuyDetalis.CurrentRow.Cells[0].Value);
                Properties.Settings.Default.Save();
                Close();
            } else
            {
                MessageBox.Show("اختر منتج اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Check = false;
            Properties.Settings.Default.QTY = 0;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}

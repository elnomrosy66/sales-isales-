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
    public partial class Frm_Store_Gard : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Store_Gard()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();

        private void FillStore()
        {

            cbxStorea.DataSource = db.RunReader("select * from Store", "");
            cbxStorea.DisplayMember = "Store_Name";
            cbxStorea.ValueMember = "Store_ID";

        }
        private void FillItems()
        {
            cbxItems.DataSource = db.RunReader("select * from Items", "");
            cbxItems.DisplayMember = "Item_Name";
            cbxItems.ValueMember = "Item_ID";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            gard();




        }
        void gard ()
        {
            decimal Sum, Sum2, rbh7;
            tbl.Clear();

            if (rbtnAllStore.Checked == true)
                tbl = db.RunReader("SELECT [Items_Qty].[Item_ID] as 'رقم المنتج',Items.Item_Name as 'اسم المنتج',[Store_Name] as 'اسم المخزن المتواجد فيه',[Qty] as 'الكمية',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع' FROM [Items_Qty],Items where [Items_Qty].Item_ID=Items.Item_ID", "");
            else if (rbtnOneStore.Checked == true)
                tbl = db.RunReader("SELECT [Items_Qty].[Item_ID] as 'رقم المنتج',Items.Item_Name as 'اسم المنتج',[Store_Name] as 'اسم المخزن المتواجد فيه',[Qty] as 'الكمية',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع' FROM [Items_Qty],Items where [Items_Qty].Item_ID=Items.Item_ID and Store_ID=" + cbxStorea.SelectedValue + "", "");


            Sum = 0; Sum2 = 0; rbh7 = 0;
            try
            {
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {

                    Sum += Convert.ToDecimal(tbl.Rows[i][3]) * Convert.ToDecimal(tbl.Rows[i][4]);
                    Sum2 += Convert.ToDecimal(tbl.Rows[i][3]) * Convert.ToDecimal(tbl.Rows[i][5]);
                }
            }
            catch (Exception) { }
            txtTotalBuy.Text = Math.Round(Sum, 2).ToString();
            txtTotalSale.Text = Math.Round(Sum2, 2).ToString();
            txtRbh7.Text = Math.Round(Sum2 - Sum, 2).ToString();
            DgvBuyDetalis.DataSource = tbl;
        }
        private void Frm_Store_Gard_Load(object sender, EventArgs e)
        {
            try
            {
                FillStore();
                FillItems();
            }
            catch (Exception) { }
        }
        DataTable tblPar = new DataTable();
        private void textParcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimal Sum, Sum2, rbh7;
            tblPar.Clear();
            if (e.KeyChar == 13)
            {
                tblPar = db.RunReader("select * from Items where barcode='" + textParcode.Text + "'", "");
                if (tblPar.Rows.Count >= 1)
                {
                    if (rbtnAllStore.Checked == true)
                        tbl = db.RunReader("SELECT [Items_Qty].[Item_ID] as 'رقم المنتج',Items.Item_Name as 'اسم المنتج',[Store_Name] as 'اسم المخزن المتواجد فيه',[Qty] as 'الكمية',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع' FROM [Items_Qty],Items where [Items_Qty].Item_ID=Items.Item_ID and barcode='" + textParcode.Text + "'", "");
                    else if (rbtnOneStore.Checked == true)
                        tbl = db.RunReader("SELECT [Items_Qty].[Item_ID] as 'رقم المنتج',Items.Item_Name as 'اسم المنتج',[Store_Name] as 'اسم المخزن المتواجد فيه',[Qty] as 'الكمية',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع' FROM [Items_Qty],Items where [Items_Qty].Item_ID=Items.Item_ID and Store_ID=" + cbxStorea.SelectedValue + " and barcode='" + textParcode.Text + "'", "");
                    Sum = 0; Sum2 = 0; rbh7 = 0;
                    try
                    {
                        for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                        {

                            Sum += Convert.ToDecimal(tbl.Rows[i][3]) * Convert.ToDecimal(tbl.Rows[i][4]);
                            Sum2 += Convert.ToDecimal(tbl.Rows[i][3]) * Convert.ToDecimal(tbl.Rows[i][5]);
                        }
                    }
                    catch (Exception) { }
                    txtTotalBuy.Text = Math.Round(Sum, 2).ToString();
                    txtTotalSale.Text = Math.Round(Sum2, 2).ToString();
                    txtRbh7.Text = Math.Round(Sum2 - Sum, 2).ToString();
                    DgvBuyDetalis.DataSource = tbl;
            
                    textParcode.Clear();
                    textParcode.Focus();
                }
                else
                {
                    textParcode.Clear();
                    textParcode.Focus();
                }
            }
        }

        private void cbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            gard2();


        }

        private void cbxItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gard2();
        }
        void gard2()
        {
            decimal Sum, Sum2, rbh7;
            tblPar.Clear();


            tblPar = db.RunReader("select * from Items where Item_ID='" + cbxItems.SelectedValue + "'", "");
            if (tblPar.Rows.Count >= 1)
            {
                if (rbtnAllStore.Checked == true)
                    tbl = db.RunReader("SELECT [Items_Qty].[Item_ID] as 'رقم المنتج',Items.Item_Name as 'اسم المنتج',[Store_Name] as 'اسم المخزن المتواجد فيه',[Qty] as 'الكمية',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع' FROM [Items_Qty],Items where [Items_Qty].Item_ID=Items.Item_ID and Items.Item_ID = " + cbxItems.SelectedValue + " ", "");
                else if (rbtnOneStore.Checked == true)
                    tbl = db.RunReader("SELECT [Items_Qty].[Item_ID] as 'رقم المنتج',Items.Item_Name as 'اسم المنتج',[Store_Name] as 'اسم المخزن المتواجد فيه',[Qty] as 'الكمية',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع' FROM [Items_Qty],Items where [Items_Qty].Item_ID=Items.Item_ID and Store_ID=" + cbxStorea.SelectedValue + " ", "");
                Sum = 0; Sum2 = 0; rbh7 = 0;
                try
                {
                    for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                    {

                        Sum += Convert.ToDecimal(tbl.Rows[i][3]) * Convert.ToDecimal(tbl.Rows[i][4]);
                        Sum2 += Convert.ToDecimal(tbl.Rows[i][3]) * Convert.ToDecimal(tbl.Rows[i][5]);
                    }
                }
                catch (Exception) { }
                txtTotalBuy.Text = Math.Round(Sum, 2).ToString();
                txtTotalSale.Text = Math.Round(Sum2, 2).ToString();
                txtRbh7.Text = Math.Round(Sum2 - Sum, 2).ToString();
                DgvBuyDetalis.DataSource = tbl;

                textParcode.Clear();
                textParcode.Focus();
            }
            else
            {
                MessageBox.Show("no items");
                textParcode.Clear();
                //textParcode.Focus();
            }
        }
    }
}
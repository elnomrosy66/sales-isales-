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
    public partial class Frm_ItemMovements : Form
    {
        public Frm_ItemMovements()
        {
            InitializeComponent();
            FillItems();
        }
        DB db = new DB();
        private void Frm_ItemMovements_Load(object sender, EventArgs e)
        {

        }
        private void FillItems()
        {
            cbxItems.DataSource = db.RunReader("select * from Items", "");
            cbxItems.DisplayMember = "Item_Name";
            cbxItems.ValueMember = "Item_ID";
        }
        DataTable tbl1 = new DataTable();
        DataTable tbl2 = new DataTable();
        DataTable tbl3 = new DataTable();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");
            tbl1 = db.RunReader("SELECT [Order_ID] as ' رقم الفاتورة',Items.Item_Name as ' المنتج',Unit as 'الوحدة',[Qty] as 'الكمية',Date as 'التاريخ ',(([Qty] * [Price])- ISNULL(Discount, 0) ) as  'الاجمالى' , type = 'مشتريات' FROM [Buy_Detalis],Items where Items.Item_ID=Buy_Detalis.Item_ID and Buy_Detalis.Item_ID = '"+ cbxItems.SelectedValue + "'   and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
            tbl2 = db.RunReader("SELECT [Order_ID] as ' رقم الفاتورة',Items.Item_Name as ' المنتج',Unit as 'الوحدة',[Qty] as 'الكمية',Date as 'التاريخ ',(([Sale_Detalis].[Price]  * [Qty]) - [Discount]) as 'الاجمالى', type = 'مبيعات' FROM [Sale_Detalis] , Items where  [Sale_Detalis].Item_ID=Items.Item_ID and Sale_Detalis.Item_ID = '" + cbxItems.SelectedValue + "' and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
            tbl3 = tbl1.Copy();
            tbl3.Merge(tbl2, true);
            DgvBuyDetalis.DataSource = tbl3;
            DgvBuyDetalis.Sort(DgvBuyDetalis.Columns[4], ListSortDirection.Ascending);
            decimal totalSales = 0;
            decimal totalBuy = 0;

            foreach (DataGridViewRow Myrow in DgvBuyDetalis.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Myrow.Cells[6].Value.ToString() == "مبيعات")// Or your condition 
                {
                    Myrow.DefaultCellStyle.BackColor = Color.LightGray;
                    totalSales += Convert.ToDecimal(Myrow.Cells[3].Value.ToString());
                }
                else
                {
                    Myrow.DefaultCellStyle.BackColor = Color.White;
                    totalBuy += Convert.ToDecimal(Myrow.Cells[3].Value.ToString());
                }
                TxtTotalB.Text = totalBuy.ToString();
                txtTotalٍS.Text = totalSales.ToString();
            }
        }
    }
}

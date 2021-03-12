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
    public partial class Frm_Items_SalesBuys : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Items_SalesBuys()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable();
        DB db = new DB();
        private void Frm_Items_SalesBuys_Load(object sender, EventArgs e)
        {
            DtbStart.Text = DateTime.Now.ToShortDateString();
            DtbEnd.Text = DateTime.Now.ToShortDateString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            decimal Total;
            tbl.Clear(); Total = 0;
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");

            if (rbtnItemsSaleDC.Checked == true)
            {
                tbl = db.RunReader("select Items.Item_Name as 'اسم الصنف' ,count(Sale_Detalis.Item_ID) as 'عدد مرات البيع فى هذه الفترة' from Items,Sale_Detalis where Items.Item_ID=Sale_Detalis.Item_ID and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'  group by Sale_Detalis.Item_ID,Items.Item_Name  order by count(Sale_Detalis.Item_ID) DESC", "");
            }
            else if (rbtnItemsSaleAC.Checked == true)
            {
                tbl = db.RunReader("select Items.Item_Name as 'اسم الصنف' ,count(Sale_Detalis.Item_ID) as 'عدد مرات البيع فى هذه الفترة' from Items,Sale_Detalis where Items.Item_ID=Sale_Detalis.Item_ID and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'  group by Sale_Detalis.Item_ID,Items.Item_Name  order by count(Sale_Detalis.Item_ID) ASC ", "");
            }
            else if (rbtnItemsBuyDC.Checked == true)
            {
                tbl = db.RunReader("select Items.Item_Name as 'اسم الصنف' ,count(Buy_Detalis.Item_ID) as 'عدد مرات الشراء فى هذه الفترة' from Items,Buy_Detalis where Items.Item_ID=Buy_Detalis.Item_ID and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'  group by Buy_Detalis.Item_ID,Items.Item_Name  order by count(Buy_Detalis.Item_ID) DESC", "");
            }
            else if (rbtnItemsBuyAC.Checked == true)
            {
                tbl = db.RunReader("select Items.Item_Name as 'اسم الصنف' ,count(Buy_Detalis.Item_ID) as 'عدد مرات الشراء فى هذه الفترة' from Items,Buy_Detalis where Items.Item_ID=Buy_Detalis.Item_ID and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'  group by Buy_Detalis.Item_ID,Items.Item_Name  order by count(Buy_Detalis.Item_ID) ASC", "");
            }
            if (tbl.Rows.Count >= 1)
            {
                DgvBuyDetalis.DataSource = tbl;

            }
            else
            {
                MessageBox.Show("لا يوجد عمليات فى هذه الفترة ", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
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
    public partial class Frm_ExpierdItems : Form
    {
        public Frm_ExpierdItems()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        private void Frm_ExpierdItems_Load(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.RunReader("select Item_ID as 'رقم الصنف' ,Store_Name as 'اسم المخزن' ,Qty as 'الكمية الموجودة' ,Price_Buy as 'سعر الشراء',Price_Sale as 'سعر البيع',DateExpierd as 'تاريخ انتهاء الصلاحية'  from Items_Qty where DateDiff(DAY, GetDate(),DateExpierd) <= 0", "");
            DgvSearchBuy.DataSource = tbl;


            txtTotalPhar.Text = tbl.Rows.Count + "";

        }
    }
}

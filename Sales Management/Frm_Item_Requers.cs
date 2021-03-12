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
    public partial class Frm_Item_Requers : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Item_Requers()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        private void Frm_Item_Requers_Load(object sender, EventArgs e)
        {
            DtbSaleDate.Text = DateTime.Now.ToShortDateString();
            string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
            DataTable tblMin = new DataTable();
            tblMin.Clear();
            tblMin = db.RunReader("select Item_ID as رقم_المنتج,Item_Name as اسم_المنتج ,Item_Qty الكمية_الموجوده_منه,Item_Min as الحد_الادنى from Items where Item_Min >=1 and  Item_Qty <= Item_Min ", "");
            int count = 0;
            try
            {
                count = Convert.ToInt32(tblMin.Rows[0][0]);
            }
            catch (Exception) { }
            if (tblMin.Rows.Count >= 1)
            {
                DgvSearchBuy.DataSource = tblMin;
            }
            else
            {
                lblYesOrNo.Text = "لا يوجد اصناف وصلت للحد الادنى";
            }

            decimal Total = 0;
            for (int i = 0; i <= tblMin.Rows.Count - 1; i++)
            {
                Total += 1;
            }
            lblCount.Text = " عدد الاصناف التى وصلت للحد الادنى" + Total.ToString();
      
        }
    }
}
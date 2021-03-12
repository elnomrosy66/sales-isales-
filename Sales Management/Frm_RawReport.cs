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
    public partial class Frm_RawReport : Form
    {
        public Frm_RawReport()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        decimal Total = 0;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tbl.Clear(); Total = 0;
            tbl = db.RunReader("SELECT [Raw_ID] as 'رقم الخامة',[Raw_Name] as 'اسم الخامة',[Qty]  as 'الكمية',[Price_Buy]  as 'سعر الشراء',[Price_Sale]  as 'سعر البيع',[Small_Unit]  as 'الوحدة الصغرى',[Main_Unit]  as 'الوحدى الكبرى',[CountInMainUnit]  as 'العدد داخل الوحدة الكبرى' FROM [Raw]", "");
            if (tbl.Rows.Count >= 1)
            {
                DgvSearchBuy.DataSource = tbl;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Total += Convert.ToDecimal(tbl.Rows[i][2]);
                }
                txtTotal.Text = Math.Round(Total, 2).ToString();
            }
            else
            {
                MessageBox.Show("لا يوجد خامات فى  المخزن ", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotal.Text = "0";
            }
        
        }
    }
}

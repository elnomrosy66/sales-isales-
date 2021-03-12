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
    public partial class Frm_RawProductionReport : Form
    {
        public Frm_RawProductionReport()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        decimal Total = 0;
        private void Frm_RawProductionReport_Load(object sender, EventArgs e)
        {
            DtbEnd.Text = DateTime.Now.ToShortDateString();
            DtbStart.Text = DateTime.Now.ToShortDateString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tbl.Clear(); Total = 0;
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");
            tbl = db.RunReader("SELECT [Raw_Pro_ID] as 'رقم العملية',[Date] as 'التاريخ',[Raw_Name] as 'اسم الخامة',[Unit_Raw] as 'وحدة الخامة',[Qty_Raw] as 'الكمية',Items.Item_Name as 'المنتج المصنع',[Unit_Items] as 'وحدة المنتج المصنع',[Qty_Items] as 'الكمية المصنعة' FROM [Raw_Production_Detalis],Items where Items.Item_ID= [Raw_Production_Detalis].Items_ID and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
            if (tbl.Rows.Count >= 1)
            {
                DgvSearchBuy.DataSource = tbl;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Total += Convert.ToDecimal(tbl.Rows[i][7]);
                }
                txtTotal.Text = Math.Round(Total, 2).ToString();
            }
            else
            {
                MessageBox.Show("لا يوجد مواد مصنعة فى هذه الفترة ", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotal.Text = "0";
            }
        
        }
    }
}

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
    public partial class Frm_Customer_Report : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Customer_Report()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        private void FillCustomer()
        {
            cbxCustomer.DataSource = db.RunReader("select * from Customer ", "");
            cbxCustomer.DisplayMember = "Cust_Name";
            cbxCustomer.ValueMember = "Cust_ID";
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (rbtnAllCustomer.Checked == true)
                tbl = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,[Cust_Name] as اسم_العميل,[Price] as المبلغ_المسدد,[Date] as تاريخ_تسديد_المبلغ  FROM [Customer_Report]", "");
            else
                tbl = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,[Cust_Name] as اسم_العميل,[Price] as المبلغ_المسدد,[Date] as تاريخ_تسديد_المبلغ  FROM [Customer_Report]  where Cust_Name=N'" + cbxCustomer.Text + "'", "");
            try
            {

                decimal Total = 0;
                DgvSearchBuy.DataSource = tbl;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Total += Convert.ToDecimal(tbl.Rows[i][2]);
                }
                txtTotalPhar.Text = Math.Round(Total, 2).ToString();
            }
            catch (Exception) { }
        }

        private void Frm_Customer_Report_Load(object sender, EventArgs e)
        {
            FillCustomer();
            tbl.Clear();
            if (Properties.Settings.Default.UserType == "مدير") { btnDelete.Enabled = true; } else { btnDelete.Enabled = false; }
            decimal Total = 0;
            tbl = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,[Cust_Name] as اسم_العميل,[Price] as المبلغ_المسدد,[Date] as تاريخ_تسديد_المبلغ  FROM [Customer_Report]", "");
            DgvSearchBuy.DataSource = tbl;
            for (int i = 0; i <= tbl.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(tbl.Rows[i][2]);
            }
            txtTotalPhar.Text = Math.Round(Total, 2).ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد ؟سيتم مسح جميع البيانات ", "تاكيد المسح", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (DgvSearchBuy.Rows.Count >= 1)
                {
                    db.RunNunQuary("delete from Customer_Report where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + "", "تم مسح البيانات المحددة");
                    Frm_Customer_Report_Load(null, null);
                }
            }
        }
    }
}
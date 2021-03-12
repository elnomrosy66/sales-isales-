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
    public partial class Frm_Suplier_Report : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Suplier_Report()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        private void FillCustomer()
        {
            cbxCustomer.DataSource = db.RunReader("select * from Suplier ", "");
            cbxCustomer.DisplayMember = "Sup_Name";
            cbxCustomer.ValueMember = "Sup_ID";
        }
        private void Frm_Suplier_Report_Load(object sender, EventArgs e)
        {
            FillCustomer();
            tbl.Clear();
            if (Properties.Settings.Default.UserType == "مدير") { btnDelete.Enabled = true; } else { btnDelete.Enabled = false; }
            decimal Total = 0;
            tbl = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,[Sup_Name] as اسم_المورد,[Price] as المبلغ_المسدد,[Date] as تاريخ_تسديد_المبلغ FROM [Sales_StandardV2].[dbo].[Suplier_Report]", "");
            DgvSearchBuy.DataSource = tbl;
            for (int i = 0; i <= tbl.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(tbl.Rows[i][2]);
            }
            txtTotalPhar.Text = Math.Round(Total, 2).ToString();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbtnAllCustomer.Checked == true)
                tbl = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,[Sup_Name] as اسم_المورد,[Price] as المبلغ_المسدد,[Date] as تاريخ_تسديد_المبلغ FROM [Sales_StandardV2].[dbo].[Suplier_Report]", "");
            else
                tbl = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,[Sup_Name] as اسم_المورد,[Price] as المبلغ_المسدد,[Date] as تاريخ_تسديد_المبلغ FROM [Sales_StandardV2].[dbo].[Suplier_Report]  where Sup_Name=N'" + cbxCustomer.Text + "'", "");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("تحذير سيتم مسح جميع البيانات فى هذه الفترة ", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete from Suplier_Report where Sup_Name='" + cbxCustomer.Text + "' ", "تم حذف جميع البيانات المحدده  بنجاح");
                tbl.Clear();
                DgvSearchBuy.DataSource = tbl;
                txtTotalPhar.Text = "0";
            }
        }
    }
}
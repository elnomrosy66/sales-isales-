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
    public partial class Frm_BuyRAWReport : Form
    {
        public Frm_BuyRAWReport()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        private void FillOwners()
        {
            cbxEmp.DataSource = db.RunReader("select * from Suplier", "");
            cbxEmp.DisplayMember = "Sup_Name";
            cbxEmp.ValueMember = "Sup_ID";
        }
        private void Frm_BuyRAWReport_Load(object sender, EventArgs e)
        {
            FillOwners();
            if (Properties.Settings.Default.UserType == "مدير") { btnDelete.Enabled = true; } else { btnDelete.Enabled = false; }
            DtbStart.Text = DateTime.Now.ToShortDateString();
            DtbEnd.Text = DateTime.Now.ToShortDateString();
        }

        private void btnSearchٍSupplier_Click(object sender, EventArgs e)
        {
            decimal Total;
            tbl.Clear(); Total = 0;
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");


            if (rbtnAll.Checked == true)
            {
                tbl = db.RunReader("SELECT [Order_ID] as 'رقم الفاتورة',Suplier.Sup_Name as 'المورد',Raw.Raw_Name as 'الخامة',[Unit] as 'الوحدة',[BuyRawDetalies].[Qty] as 'الكمية',[Price] as 'السعر',[Discount] as 'الخصم',[Total] as 'اجمالى الصنف',[Date] as 'التاريخ',[UserName] as 'اسم المستخدم' FROM [dbo].[BuyRawDetalies],Raw,Suplier where [BuyRawDetalies].Raw_ID=Raw.Raw_ID and Suplier.Sup_ID=[BuyRawDetalies].Sup_ID and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
            }
            else if (rbtnPart.Checked == true)
            {
                tbl = db.RunReader("SELECT [Order_ID] as 'رقم الفاتورة',Suplier.Sup_Name as 'المورد',Raw.Raw_Name as 'الخامة',[Unit] as 'الوحدة',[BuyRawDetalies].[Qty] as 'الكمية',[Price] as 'السعر',[Discount] as 'الخصم',[Total] as 'اجمالى الصنف',[Date] as 'التاريخ',[UserName] as 'اسم المستخدم' FROM [dbo].[BuyRawDetalies],Raw,Suplier where [BuyRawDetalies].Raw_ID=Raw.Raw_ID and Suplier.Sup_ID=[BuyRawDetalies].Sup_ID and [BuyRawDetalies].Sup_ID="+cbxEmp.SelectedValue+" and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");

            }
            decimal TotalTax = 0;

            if (tbl.Rows.Count >= 1)
            {
                DgvSearchBuy.DataSource = tbl;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Total += Convert.ToDecimal(tbl.Rows[i][7]);
                }
                txtTotalPhar.Text = Math.Round(Total, 2).ToString();
            }
            else
            {
                MessageBox.Show("لا يوجد مشتريات لاي خامات فى هذه الفترة ", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotalPhar.Text = "0";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("تحذير سيتم مسح جميع بيانات الفاتورة المحدده ", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete from BuyRaw where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + " ", "");
                db.RunNunQuary("delete from BuyRawDetalies where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + " ", "تم حذف بيانات الفاتورة المحدده  بنجاح");

                tbl.Clear();
                DgvSearchBuy.DataSource = tbl;
                txtTotalPhar.Text = "0";
            }
        }
    }
}

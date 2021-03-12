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
    public partial class Frm_Customer_Kest : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Customer_Kest()
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
        int stock_ID;
        private void Frm_Customer_Kest_Load(object sender, EventArgs e)
        {
            stock_ID = Convert.ToInt32(Properties.Settings.Default.UserStock);

            DtbSaleDate.Text = DateTime.Now.ToShortDateString();
            FillCustomer();
            tbl.Clear();
            decimal Total = 0;
            tbl = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Customer.Cust_Name as اسم_العميل,[Kest_Num] as رقم_القسط,[Kest_Value] as قيمه_القسط,[Kest_Date_Deserved] as تاريخ_استحقاق_القسط FROM [Kest] ,Customer   where Kest.Cust_ID=Customer.Cust_ID", "");
            DgvSearchBuy.DataSource = tbl;
            for (int i = 0; i <= tbl.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(tbl.Rows[i][3]);
            }
            txtTotalPhar.Text = Math.Round(Total, 2).ToString();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            decimal Total = 0;
            if (rbtnAllCustomer.Checked == true)
                tbl = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Customer.Cust_Name as اسم_العميل,[Kest_Num] as رقم_القسط,[Kest_Value] as قيمه_القسط,[Kest_Date_Deserved] as تاريخ_استحقاق_القسط FROM [Kest] ,Customer   where Kest.Cust_ID=Customer.Cust_ID", "");
            else if (rbtnOneCustomer.Checked == true)
                tbl = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Customer.Cust_Name as اسم_العميل,[Kest_Num] as رقم_القسط,[Kest_Value] as قيمه_القسط,[Kest_Date_Deserved] as تاريخ_استحقاق_القسط FROM [Kest] ,Customer   where Kest.Cust_ID=Customer.Cust_ID and Kest.Cust_ID=" + cbxCustomer.SelectedValue + "", "");
            DgvSearchBuy.DataSource = tbl;
            for (int i = 0; i <= tbl.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(tbl.Rows[i][3]);
            }
            txtTotalPhar.Text = Math.Round(Total, 2).ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
            if (MessageBox.Show("هل انتا متاكد؟ ", "تاكيد التسديد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (DgvSearchBuy.Rows.Count >= 1)
                {
                    decimal tot = Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[3].Value) - NudSale.Value;
                    if (rbtnAll.Checked == true)
                    {
                        db.RunNunQuary("delete from Kest where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + " and Kest_Value=" + DgvSearchBuy.CurrentRow.Cells[3].Value + "  and Kest_Date_Deserved='" + DgvSearchBuy.CurrentRow.Cells[4].Value + "'", "تم تسديد  باقى المبلغ للعميل بنجاح");
                        db.RunNunQuary("insert into Customer_Report Values(" + DgvSearchBuy.CurrentRow.Cells[0].Value + " ,N'" + DgvSearchBuy.CurrentRow.Cells[1].Value + "'," + DgvSearchBuy.CurrentRow.Cells[3].Value + ",N'" + d + "')", "");

                        //insert into stock
                        db.RunNunQuary("update Stock set Money=Money + " + DgvSearchBuy.CurrentRow.Cells[3].Value + "", "");
                        db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type) Values(" + DgvSearchBuy.CurrentRow.Cells[3].Value + " ,'" + d + "' ,N'عملاء'N,'اقساط مستحقه على العملاء')", "");
                    }
                    else
                    {

                        db.RunNunQuary("update Kest set Kest_Value=" + tot + "  where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + " and Kest_Value=" + DgvSearchBuy.CurrentRow.Cells[3].Value + "  and Kest_Date_Deserved='" + DgvSearchBuy.CurrentRow.Cells[4].Value + "'", "تم تسديد  باقى المبلغ للعميل بنجاح");
                        db.RunNunQuary("insert into Customer_Report Values(" + DgvSearchBuy.CurrentRow.Cells[0].Value + " ,N'" + DgvSearchBuy.CurrentRow.Cells[1].Value + "'," + NudSale.Value + ",N'" + d + "')", "");
                        //insert into stock
                        db.RunNunQuary("update Stock set Money=Money + " + NudSale.Value + "", "");
                        db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type) Values(" + NudSale.Value + " ,'" + d + "' ,N'عملاء'N ,'اقساط مستحقة على العملاء')", "");

                    }
                    Frm_Customer_Kest_Load(null, null);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
            if (MessageBox.Show("هل انتا متاكد؟ ", "تاكيد التسديد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (DgvSearchBuy.Rows.Count >= 1)
                {
                    decimal tot = Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[3].Value) - NudSale.Value;
                    if (rbtnAll.Checked == true)
                    {
                        db.RunNunQuary("delete from Kest where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + " and Kest_Value=" + DgvSearchBuy.CurrentRow.Cells[3].Value + "  and Kest_Date_Deserved='" + DgvSearchBuy.CurrentRow.Cells[4].Value + "'", "تم تسديد  باقى المبلغ للعميل بنجاح");
                        db.RunNunQuary("insert into Customer_Report Values(" + DgvSearchBuy.CurrentRow.Cells[0].Value + " ,N'" + DgvSearchBuy.CurrentRow.Cells[1].Value + "'," + DgvSearchBuy.CurrentRow.Cells[3].Value + ",N'" + d + "')", "");

                        //insert into stock
                        db.RunNunQuary("update Stock set Money=Money + " + DgvSearchBuy.CurrentRow.Cells[3].Value + " where Stock_ID="+stock_ID+"", "");
                        db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type,Stock_ID) Values(" + DgvSearchBuy.CurrentRow.Cells[3].Value + " ,'" + d + "' ,N'عملاء' ,'اقساط مستحقه على العملاء' ,"+stock_ID+")", "");
                    }
                    else
                    {

                        db.RunNunQuary("update Kest set Kest_Value=" + tot + "  where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + " and Kest_Value=" + DgvSearchBuy.CurrentRow.Cells[3].Value + "  and Kest_Date_Deserved='" + DgvSearchBuy.CurrentRow.Cells[4].Value + "'", "تم تسديد  باقى المبلغ للعميل بنجاح");
                        db.RunNunQuary("insert into Customer_Report Values(" + DgvSearchBuy.CurrentRow.Cells[0].Value + " ,N'" + DgvSearchBuy.CurrentRow.Cells[1].Value + "'," + NudSale.Value + ",N'" + d + "')", "");
                        //insert into stock
                        db.RunNunQuary("update Stock set Money=Money + " + NudSale.Value + "  where Stock_ID=" + stock_ID + "", "");
                        db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type ,Stock_ID) Values(" + NudSale.Value + " ,'" + d + "' ,N'عملاء' ,'اقساط مستحقة على العملاء' ,"+stock_ID+")", "");

                    }
                    Frm_Customer_Kest_Load(null, null);
                }
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {

                if (DgvSearchBuy.Rows.Count >= 1)
                {
                    DataTable tblRpt = new DataTable();
                    tblRpt.Clear();
                    tblRpt = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Kest_Value  as المبلغ_المتبقى,(select SUM(Kest_Value) from Kest where Customer.Cust_ID=Kest.Cust_ID) as الاجمالى,Customer.[Cust_Name]  as العميل,Customer.Cust_ID as رقم_العميل,Kest_Date_Deserved  as تاريخ_الفاتورة FROM Kest,Customer where Customer.Cust_ID=Kest.Cust_ID and Kest.Cust_ID=" + cbxCustomer.SelectedValue + "", "");
                    Frm_Printing frm = new Frm_Printing();
                    Copy_of_RptCustomerMoney rpt = new Copy_of_RptCustomerMoney();

                    frm.crystalReportViewer1.RefreshReport();
                    rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");
                    rpt.SetDataSource(tblRpt);
                    rpt.SetParameterValue("ID", cbxCustomer.SelectedValue);

                    frm.crystalReportViewer1.ReportSource = rpt;
                    //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    //rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                    //rpt.PrintToPrinter(1, true, 0, 0);
                    frm.ShowDialog();
                }
            }
            catch (Exception) { }
        
        
        }
    }
}
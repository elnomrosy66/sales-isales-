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
    public partial class Frm_CustomerMoney : DevExpress.XtraEditors.XtraForm
    {
        public Frm_CustomerMoney()
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
        private void Frm_CustomerMoney_Load(object sender, EventArgs e)
        {
            DtbSaleDate.Text = DateTime.Now.ToShortDateString();
            FillCustomer();
            tbl.Clear();
            decimal Total = 0;
            tbl = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,[Price]  as المبلغ_المتبقى,Customer.[Cust_Name]  as العميل,[Date]  as تاريخ_الفاتورة ,Date_Reminder as تاريخ_الاستحقاق,Type as 'النوع' FROM [Customer_Money],Customer where Customer.Cust_ID=Customer_Money.Cust_ID", "");
            DgvSearchBuy.DataSource = tbl;
            for (int i = 0; i <= tbl.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(tbl.Rows[i][1]);
            }
            txtTotalPhar.Text = Math.Round(Total, 2).ToString();
            stock_ID = Convert.ToInt32(Properties.Settings.Default.UserStock);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
            if (MessageBox.Show("هل انتا متاكد؟ ", "تاكيد التسديد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (DgvSearchBuy.Rows.Count >= 1)
                {
                    decimal tot = Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[1].Value) - NudSale.Value;
                    if (rbtnAll.Checked == true)
                    {
                        db.RunNunQuary("delete from Customer_Money where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + " and Price=" + DgvSearchBuy.CurrentRow.Cells[1].Value + "", "تم تسديد  باقى المبلغ للعميل بنجاح");
                        db.RunNunQuary("insert into Customer_Report Values(" + DgvSearchBuy.CurrentRow.Cells[0].Value + " ,N'" + DgvSearchBuy.CurrentRow.Cells[2].Value + "'," + DgvSearchBuy.CurrentRow.Cells[1].Value + ",N'" + d + "')", "");

                        //insert into stock
                        db.RunNunQuary("update Stock set Money=Money + " + DgvSearchBuy.CurrentRow.Cells[1].Value + "", "");
                        db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type) Values(" + DgvSearchBuy.CurrentRow.Cells[1].Value + " ,'" + d + "' ,N'عملاء' ,'مستجقات من العملاء')", "");


                    }
                    else
                    {
                        db.RunNunQuary("update Customer_Money set Price=" + tot + "  where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + "", "تم تسديد  باقى المبلغ للعميل بنجاح");
                        db.RunNunQuary("insert into Customer_Report Values(" + DgvSearchBuy.CurrentRow.Cells[0].Value + " ,N'" + DgvSearchBuy.CurrentRow.Cells[2].Value + "'," + NudSale.Value + ",N'" + d + "')", "");
                        //insert into stock
                        db.RunNunQuary("update Stock set Money=Money + " + NudSale.Value + "", "");
                        db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type) Values(" + NudSale.Value + " ,'" + d + "' ,N'عملاء' ,'مستجقات من العملاء')", "");

                    }
                    Frm_CustomerMoney_Load(null, null);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            tbl.Clear();
            decimal Total = 0;
            if (rbtnAllCustomer.Checked == true)
                tbl = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,[Price]  as المبلغ_المتبقى,Customer.[Cust_Name]  as العميل,[Date]  as تاريخ_الفاتورة ,Date_Reminder as تاريخ_الاستحقاق  ,Type as 'النوع' FROM  [Customer_Money],Customer where Customer.Cust_ID=Customer_Money.Cust_ID", "");
            else if (rbtnOneCustomer.Checked == true)
                tbl = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,[Price]  as المبلغ_المتبقى,Customer.[Cust_Name]  as العميل,[Date]  as تاريخ_الفاتورة ,Date_Reminder as تاريخ_الاستحقاق  ,Type as 'النوع' FROM [Customer_Money],Customer where Customer.Cust_ID=Customer_Money.Cust_ID and Customer_Money.Cust_ID=" + cbxCustomer.SelectedValue + "", "");
            DgvSearchBuy.DataSource = tbl;
            for (int i = 0; i <= tbl.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(tbl.Rows[i][1]);
            }
            txtTotalPhar.Text = Math.Round(Total, 2).ToString();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
            if (MessageBox.Show("هل انتا متاكد؟ ", "تاكيد التسديد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (DgvSearchBuy.Rows.Count >= 1)
                {
                    decimal tot = Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[1].Value) - NudSale.Value;
                    if (rbtnAll.Checked == true)
                    {
                        db.RunNunQuary("delete from Customer_Money where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + " and Price=" + DgvSearchBuy.CurrentRow.Cells[1].Value + "", "تم تسديد  باقى المبلغ للعميل بنجاح");
                        db.RunNunQuary("insert into Customer_Report Values(" + DgvSearchBuy.CurrentRow.Cells[0].Value + " ,N'" + DgvSearchBuy.CurrentRow.Cells[2].Value + "'," + DgvSearchBuy.CurrentRow.Cells[1].Value + ",N'" + d + "')", "");

                        //insert into stock
                        db.RunNunQuary("update Stock set Money=Money + " + DgvSearchBuy.CurrentRow.Cells[1].Value + " where Stock_ID="+stock_ID+" ", "");
                        db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type,Stock_ID) Values(" + DgvSearchBuy.CurrentRow.Cells[1].Value + " ,'" + d + "' ,N'عملاء' ,'مستجقات من العملاء' ,"+stock_ID+")", "");


                    }
                    else
                    {
                        db.RunNunQuary("update Customer_Money set Price=" + tot + "  where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + "", "تم تسديد  باقى المبلغ للعميل بنجاح");
                        db.RunNunQuary("insert into Customer_Report Values(" + DgvSearchBuy.CurrentRow.Cells[0].Value + " ,N'" + DgvSearchBuy.CurrentRow.Cells[2].Value + "'," + NudSale.Value + ",N'" + d + "')", "");
                        //insert into stock
                        db.RunNunQuary("update Stock set Money=Money + " + NudSale.Value + " where Stock_ID="+stock_ID+" ", "");
                        db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type ,Stock_ID) Values(" + NudSale.Value + " ,'" + d + "' ,N'عملاء' ,'مستجقات من العملاء',"+stock_ID+")", "");

                    }
                    btnSearch_Click(null, null);
                    //Frm_CustomerMoney_Load(null, null);
                }
            }
        }

        private void PrintWithOut()
        {
            try
            {
                try
                {
                    DataTable tblCheck = new DataTable();
                    tblCheck.Clear();
                    tblCheck = db.RunReader("select * from OrderPrintData", "");
                    if (tblCheck.Rows.Count <= 0)
                    {
                        MessageBox.Show("لكى تتم عملية الطباعة بنجاح من فضلك اذهب الى قائمه اعدادت وادخل بيانات الفاتورة لكى تتم العملية", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (Exception) { }

                DataTable tblRpt = new DataTable();
                tblRpt.Clear();
                tblRpt = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,[Price]  as المبلغ_المتبقى,(select SUM(Price) from [Customer_Money] where Customer.Cust_ID=Customer_Money.Cust_ID) as الاجمالى,Customer.[Cust_Name]  as العميل,Customer.Cust_ID as رقم_العميل,[Date]  as تاريخ_الفاتورة FROM [Customer_Money],Customer where Customer.Cust_ID=Customer_Money.Cust_ID  and Customer_Money.Cust_ID=" + cbxCustomer.SelectedValue + "", "");
                Frm_Printing frm = new Frm_Printing();
                RptCustomerMoney rpt = new RptCustomerMoney();

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
            catch (Exception) { }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (DgvSearchBuy.Rows.Count <= 0)
            {
                MessageBox.Show("لا يوجد بيانات حتى يتم طباعتها", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbtnOneCustomer.Checked != true)
            {
                MessageBox.Show("من فضلك اختار بيانات عميل محدد لكى يتم طباعته...", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintWithOut();
        }
    }
}
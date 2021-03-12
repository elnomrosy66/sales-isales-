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
    public partial class Frm_SuplierMoney : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SuplierMoney()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        int stock_ID;
        private void Frm_SuplierMoney_Load(object sender, EventArgs e)
        {
            stock_ID = Convert.ToInt32(Properties.Settings.Default.UserStock);
            DtbSaleDate.Text = DateTime.Now.ToShortDateString();
            cbxCustomer.DataSource = db.RunReader("select * from Suplier ", "");
            cbxCustomer.DisplayMember = "Sup_Name";
            cbxCustomer.ValueMember = "Sup_ID";

            tbl.Clear();
            decimal Total = 0;
            tbl = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,[Price]  as المبلغ_المتبقى,Suplier.[Sup_Name]  as المورد,[Date]  as تاريخ_الفاتورة ,Date_Reminder as 'تاريخ الاستحقاق' FROM [Suplier_Money],Suplier where Suplier.Sup_ID=Suplier_Money.Sup_ID", "");
            DgvSearchBuy.DataSource = tbl;
            for (int i = 0; i <= tbl.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(tbl.Rows[i][1]);
            }
            txtTotalPhar.Text = Math.Round(Total, 2).ToString();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            decimal Total = 0;
            if (rbtnAllCustomer.Checked == true)
                tbl = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,[Price]  as المبلغ_المتبقى,Suplier.[Sup_Name]  as المورد,[Date]  as تاريخ_الفاتورة ,Date_Reminder as 'تاريخ الاستحقاق' FROM [Suplier_Money],Suplier where Suplier.Sup_ID=Suplier_Money.Sup_ID", "");
            else if (rbtnOneCustomer.Checked == true)
                tbl = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,[Price]  as المبلغ_المتبقى,Suplier.[Sup_Name]  as المورد,[Date]  as تاريخ_الفاتورة ,Date_Reminder as 'تاريخ الاستحقاق' FROM [Suplier_Money],Suplier where Suplier.Sup_ID=Suplier_Money.Sup_ID and Suplier_Money.Sup_ID =" + cbxCustomer.SelectedValue + "", "");
            DgvSearchBuy.DataSource = tbl;
            for (int i = 0; i <= tbl.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(tbl.Rows[i][1]);
            }
            txtTotalPhar.Text = Math.Round(Total, 2).ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");

            if (DgvSearchBuy.Rows.Count >= 1)
            {

                if (rbtnAll.Checked == true)
                {
                    if (MessageBox.Show("هل انتا متاكد؟ ", "تاكيد التسديد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {


                        DataTable tblCheck = new DataTable();
                        tblCheck.Clear();
                        tblCheck = db.RunReader("select * from Stock where Stock_ID="+stock_ID+"", "");
                        decimal Money = Convert.ToDecimal(tblCheck.Rows[0][0]);
                        decimal total = Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[1].Value);
                        if (Money - total < 0)
                        {
                            MessageBox.Show("لا يوجد رصيد كافى فى الخزنه لاتمام العملية", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        db.RunNunQuary("delete from Suplier_Money where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + " and Price=" + DgvSearchBuy.CurrentRow.Cells[1].Value + "", "تم تسديد  باقى المبلغ للمورد بنجاح");
                        db.RunNunQuary("insert into Suplier_Report Values(" + DgvSearchBuy.CurrentRow.Cells[0].Value + " ,N'" + DgvSearchBuy.CurrentRow.Cells[2].Value + "'," + DgvSearchBuy.CurrentRow.Cells[1].Value + ",N'" + d + "')", "");
                        db.RunNunQuary("update Stock set Money=Money - " + DgvSearchBuy.CurrentRow.Cells[1].Value + " where Stock_ID="+stock_ID+"", "");
                        db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type ,Stock_ID) Values(" + DgvSearchBuy.CurrentRow.Cells[1].Value + " ,'" + d + "' ,N'مستحقات موردين' ,'موردين' ,"+stock_ID+")", "");

                        Frm_SuplierMoney_Load(null, null);
                    }
                }
                else
                {
                    if (MessageBox.Show("هل انتا متاكد؟ ", "تاكيد التسديد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        DataTable tblCheck = new DataTable();
                        tblCheck.Clear();
                        tblCheck = db.RunReader("select * from Stock", "");
                        decimal Money = Convert.ToDecimal(tblCheck.Rows[0][0]);
                        decimal total = Convert.ToDecimal(NudSale.Value);
                        if (Money - total < 0)
                        {
                            MessageBox.Show("لا يوجد رصيد كافى فى الخزنه لاتمام العملية", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        decimal tot = Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[1].Value) - NudSale.Value;
                        db.RunNunQuary("update Suplier_Money set Price=" + tot + " where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + " ", "تم تسديد جزء من المبلغ للمورد بنجاح");
                        db.RunNunQuary("insert into Suplier_Report Values(" + DgvSearchBuy.CurrentRow.Cells[0].Value + " ,N'" + DgvSearchBuy.CurrentRow.Cells[2].Value + "'," + NudSale.Value + ",N'" + d + "')", "");


                        db.RunNunQuary("update Stock set Money=Money - " + NudSale.Value + "", "");
                        db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type) Values(" + NudSale.Value + " ,'" + d + "' ,N'مستحقات موردين' ,'موردين')", "");

                        Frm_SuplierMoney_Load(null, null);
                    }
                }
            }
            else
                return;

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
                tblRpt = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Suplier.Sup_ID as رقم_المورد,(select SUM(Price) from Suplier_Money where Suplier.Sup_ID=Suplier_Money.Sup_ID) as الاجمالى,[Price]  as المبلغ_المتبقى,Suplier.[Sup_Name]  as المورد,[Date]  as تاريخ_الفاتورة FROM [Suplier_Money],Suplier where Suplier.Sup_ID=Suplier_Money.Sup_ID and Suplier_Money.Sup_ID=" + cbxCustomer.SelectedValue + "", "");
                Frm_Printing frm = new Frm_Printing();
                RptSuplierMoney rpt = new RptSuplierMoney();

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
                MessageBox.Show("من فضلك اختار بيانات مورد محدد لكى يتم طباعته...", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintWithOut();
        }
    }
}
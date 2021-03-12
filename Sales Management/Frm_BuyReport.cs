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
    public partial class Frm_BuyReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_BuyReport()
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
        private void Frm_BuyReport_Load(object sender, EventArgs e)
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
                if (checkBox1.Checked == true)
                    tbl = db.RunReader("SELECT [Buy_Detalis].[Sup_ID] , [Order_ID] as رقم_الفاتورة,Suplier.Sup_Name as اسم_المورد,Items.Item_Name as المنتج,Unit as 'الوحدة',[Qty]  as الكمية,Date as التاريخ,(([Price] ) - (Buy_Detalis.[Tax_Value] / Buy_Detalis.Qty)) as السعر, Buy_Detalis.[Tax_Value] as 'الضريبه المضافة' ,[Price] as 'السعر بعد الضريبة',Discount as الخصم,(([Qty] * [Price])- ISNULL(Discount, 0 ) ) as  الاجمالى_بعد_الخصم FROM [Buy_Detalis],Suplier,Items where Items.Item_ID=Buy_Detalis.Item_ID and Suplier.Sup_ID=Buy_Detalis.Sup_ID and Order_ID=" + textBox1.Text + " and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
                else
                    tbl = db.RunReader("SELECT [Buy_Detalis].[Sup_ID] , [Order_ID] as رقم_الفاتورة,Suplier.Sup_Name as اسم_المورد,Items.Item_Name as المنتج,Unit as 'الوحدة',[Qty]  as الكمية,Date as التاريخ,(([Price] ) - (Buy_Detalis.[Tax_Value] / Buy_Detalis.Qty)) as السعر, Buy_Detalis.[Tax_Value] as 'الضريبه المضافة' ,[Price] as 'السعر بعد الضريبة',Discount as الخصم,(([Qty] * [Price])- ISNULL(Discount, 0 ) ) as  الاجمالى_بعد_الخصم FROM [Buy_Detalis],Suplier,Items where Items.Item_ID=Buy_Detalis.Item_ID and Suplier.Sup_ID=Buy_Detalis.Sup_ID and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
            }
            else if (rbtnPart.Checked == true)
            {
                if (checkBox1.Checked == true)
                    tbl = db.RunReader("SELECT [Sup_ID] ,  [Order_ID] as رقم_الفاتورة,Suplier.Sup_Name as اسم_المورد,Items.Item_Name as المنتج,Unit as 'الوحدة',[Qty]  as الكمية,Date as التاريخ,(([Price] - (Buy_Detalis.[Tax_Value] / Buy_Detalis.Qty))) as السعر, Buy_Detalis.[Tax_Value] as 'الضريبه المضافة' ,[Price] as 'السعر بعد الضريبة',Discount as الخصم,(([Qty] * [Price])- ISNULL(Discount, 0 ) ) as  الاجمالى_بعد_الخصم FROM [Buy_Detalis],Suplier,Items where Items.Item_ID=Buy_Detalis.Item_ID and Suplier.Sup_ID=Buy_Detalis.Sup_ID and Order_ID=" + textBox1.Text + " and Buy_Detalis.Sup_ID=" + cbxEmp.SelectedValue + " and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
                else
                    tbl = db.RunReader("SELECT [Sup_ID] , [Order_ID] as رقم_الفاتورة,Suplier.Sup_Name as اسم_المورد,Items.Item_Name as المنتج,Unit as 'الوحدة',[Qty]  as الكمية,Date as التاريخ,(([Price] - (Buy_Detalis.[Tax_Value] / Buy_Detalis.Qty))) as السعر, Buy_Detalis.[Tax_Value] as 'الضريبه المضافة' ,[Price] as 'السعر بعد الضريبة',Discount as الخصم,(([Qty] * [Price])- ISNULL(Discount, 0 ) ) as  الاجمالى_بعد_الخصم FROM [Buy_Detalis],Suplier,Items where Items.Item_ID=Buy_Detalis.Item_ID and Suplier.Sup_ID=Buy_Detalis.Sup_ID  and Buy_Detalis.Sup_ID=" + cbxEmp.SelectedValue + " and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
            }
            decimal TotalTax = 0;

            if (tbl.Rows.Count >= 1)
            {
                DgvSearchBuy.DataSource = tbl;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Total += Convert.ToDecimal(tbl.Rows[i][10]);
                    TotalTax += Convert.ToDecimal(tbl.Rows[i][7]);
                }
                txtTotalPhar.Text = Math.Round(Total, 2).ToString();
                txtTotalTax.Text = Math.Round(TotalTax, 2).ToString();
                DgvSearchBuy.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("لا يوجد مشتريات فى هذه الفترة ", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotalPhar.Text = "0";
            }
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (DgvSearchBuy.Rows.Count >= 1)
            {
                Print();
            }
        }

        private void Print()
        {
            try
            {
                decimal num = Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[1].Value) ;
                decimal sup_id = Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[0].Value) ;
                DataTable tblRpt = new DataTable();
                tblRpt.Clear();
                int x = Convert.ToInt32(DgvSearchBuy.CurrentRow.Cells[0].Value) - 1;

                tblRpt = db.RunReader("SELECT [Sup_ID] , [Order_ID] as رقم_الفاتورة,Items.Item_Name as اسم_الصنف ,[Qty]  as الكمية,[Price]  as السعر,[Date]  as التاريخ,[Qty] * [Price] - Discount as الاجمالى,Unit as 'الوحدة',(Total) as  الاجمالى_العام,Suplier.Sup_Name as المورد,Discount as الخصم,UserName as 'اسم المستخدم',Madfo3 as 'المدفوع' FROM [Buy_Detalis],Items,Suplier  where Items.Item_ID=Buy_Detalis.Item_ID and Suplier.Sup_ID=Buy_Detalis.Sup_ID and Buy_Detalis.Order_ID=" + num + "", "");

                Frm_Printing frm = new Frm_Printing();
                RptPrintOrderBuyA4 rpt = new RptPrintOrderBuyA4();

                frm.crystalReportViewer1.RefreshReport();
                rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");
                rpt.SetDataSource(tblRpt);
                rpt.SetParameterValue("ID", num);
                rpt.SetParameterValue("@sup_id", sup_id);
                frm.crystalReportViewer1.ReportSource = rpt;
                //if (Properties.Settings.Default.PrinterName == "لم يتم تحديد طابعة") { MessageBox.Show("من فضلك حدد طابعة من شاشة اعدادات البرنامج", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                //rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                //rpt.PrintToPrinter(1, true, 0, 0);
                frm.ShowDialog();
            }
            catch (Exception) { }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DgvSearchBuy.Rows.Count >= 1)
            {

                db.RunNunQuary("update Buy_Detalis set QTY =" + DgvSearchBuy.CurrentRow.Cells[3].Value + " ,Price=" + DgvSearchBuy.CurrentRow.Cells[5].Value + " ,Discount=" + DgvSearchBuy.CurrentRow.Cells[8].Value + "  where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + " and Price=" + DgvSearchBuy.CurrentRow.Cells[5].Value + "", "تم تعديل الفاتورة بنجاح");
                btnSearchٍSupplier_Click(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");
            if (MessageBox.Show("تحذير سيتم مسح جميع بيانات الفاتورة المحدده ", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete from Buy where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + " ", "");
                db.RunNunQuary("delete from Buy_Detalis where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + " ", "تم حذف بيانات الفاتورة المحدده  بنجاح");

                tbl.Clear();
                DgvSearchBuy.DataSource = tbl;
                txtTotalPhar.Text = "0";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (DgvSearchBuy.Rows.Count >= 1)
            {
                PrintAll();
            }
            else
            {
                MessageBox.Show("لا يوجد عمليات بيع حتى تتم طباعتها", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void PrintAll()
        {
            try
            {
                string d = DtbStart.Value.ToString("yyyy-MM-dd");
                string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");
                DataTable tblRpt = new DataTable();
                tblRpt.Clear();

                if (rbtnAll.Checked == true)
                {
                    if (checkBox1.Checked == true)
                        tblRpt = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Suplier.Sup_Name as اسم_المورد,Items.Item_Name as المنتج,Unit as 'الوحدة',[Qty]  as الكمية,Date as التاريخ,(([Price] ) - (Buy_Detalis.[Tax_Value] / Buy_Detalis.Qty)) as السعر, Buy_Detalis.[Tax_Value] as 'الضريبه المضافة' ,[Price] as 'السعر بعد الضريبة',Discount as الخصم,(([Qty] * [Price])- ISNULL(Discount, 0 ) ) as  الاجمالى_بعد_الخصم FROM [Buy_Detalis],Suplier,Items where Items.Item_ID=Buy_Detalis.Item_ID and Suplier.Sup_ID=Buy_Detalis.Sup_ID and Order_ID=" + textBox1.Text + " and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
                    else
                        tblRpt = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Suplier.Sup_Name as اسم_المورد,Items.Item_Name as المنتج,Unit as 'الوحدة',[Qty]  as الكمية,Date as التاريخ,(([Price] ) - (Buy_Detalis.[Tax_Value] / Buy_Detalis.Qty)) as السعر, Buy_Detalis.[Tax_Value] as 'الضريبه المضافة' ,[Price] as 'السعر بعد الضريبة',Discount as الخصم,(([Qty] * [Price])- ISNULL(Discount, 0 ) ) as  الاجمالى_بعد_الخصم FROM [Buy_Detalis],Suplier,Items where Items.Item_ID=Buy_Detalis.Item_ID and Suplier.Sup_ID=Buy_Detalis.Sup_ID and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
                }
                else if (rbtnPart.Checked == true)
                {
                    if (checkBox1.Checked == true)
                        tblRpt = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Suplier.Sup_Name as اسم_المورد,Items.Item_Name as المنتج,Unit as 'الوحدة',[Qty]  as الكمية,Date as التاريخ,(([Price] - (Buy_Detalis.[Tax_Value] / Buy_Detalis.Qty))) as السعر, Buy_Detalis.[Tax_Value] as 'الضريبه المضافة' ,[Price] as 'السعر بعد الضريبة',Discount as الخصم,(([Qty] * [Price])- ISNULL(Discount, 0 ) ) as  الاجمالى_بعد_الخصم FROM [Buy_Detalis],Suplier,Items where Items.Item_ID=Buy_Detalis.Item_ID and Suplier.Sup_ID=Buy_Detalis.Sup_ID and Order_ID=" + textBox1.Text + " and Buy_Detalis.Sup_ID=" + cbxEmp.SelectedValue + " and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
                    else
                        tblRpt = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Suplier.Sup_Name as اسم_المورد,Items.Item_Name as المنتج,Unit as 'الوحدة',[Qty]  as الكمية,Date as التاريخ,(([Price] - (Buy_Detalis.[Tax_Value] / Buy_Detalis.Qty))) as السعر, Buy_Detalis.[Tax_Value] as 'الضريبه المضافة' ,[Price] as 'السعر بعد الضريبة',Discount as الخصم,(([Qty] * [Price])- ISNULL(Discount, 0 ) ) as  الاجمالى_بعد_الخصم FROM [Buy_Detalis],Suplier,Items where Items.Item_ID=Buy_Detalis.Item_ID and Suplier.Sup_ID=Buy_Detalis.Sup_ID  and Buy_Detalis.Sup_ID=" + cbxEmp.SelectedValue + " and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
                }
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
                Frm_Printing frm = new Frm_Printing();
                RptBuyReport rpt = new RptBuyReport();
                string dFrom = DtbStart.Value.ToString("dd/MM/yyyy");
                string dTo = DtbEnd.Value.ToString("dd/MM/yyyy");

                frm.crystalReportViewer1.RefreshReport();
                rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");
                rpt.SetDataSource(tblRpt);
                rpt.SetParameterValue("From", dFrom);
                rpt.SetParameterValue("To", dTo);
                frm.crystalReportViewer1.ReportSource = rpt;
                //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                //rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                //rpt.PrintToPrinter(1, true, 0, 0);
                frm.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


    }
}
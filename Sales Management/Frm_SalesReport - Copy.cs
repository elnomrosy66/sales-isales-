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
    public partial class Frm_SalesReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SalesReport()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        bool type = true;

        private void FillOwners()
        {
            cbxEmp.DataSource = db.RunReader("select * from Users", "");
            cbxEmp.DisplayMember = "UserName";
            cbxEmp.ValueMember = "ID";
        }
        private void Frm_SalesReport_Load(object sender, EventArgs e)
        {
            FillOwners();
            if (Properties.Settings.Default.UserType == "مدير")
            {
                btnDelete.Enabled = true;
                type = true;
            }
            else {
                type = false;
                btnDelete.Enabled = false;
            }
            DtbStart.Text = DateTime.Now.ToShortDateString();
            DtbEnd.Text = DateTime.Now.ToShortDateString();
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            decimal TotalWithTax ,Total ,TotalTax;
            tbl.Clear(); TotalWithTax = 0; Total = 0; TotalTax = 0;
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");

            
                if (rbtnAll.Checked == true)
                {
                        if (checkBox1.Checked == true)
                        {
                            tbl = db.RunReader("SELECT [Cust_ID], [Order_ID] as ' رقم الفاتورة',[Cust_Name] as 'العميل',Items.Item_Name as ' المنتج',[Unit] as 'الوحدة',[Qty] as 'الكمية',[Sale_Detalis].[Tax_Value] * Qty as 'ضريبة القيمه المضافة',[Discount] as 'الخصم',[Sale_Detalis].[Price] as 'السعر بعد الضريبة', Round(([Sale_Detalis].[Price]  * [Qty]) - [Discount],2) as 'الاجمالى',[Date] as 'التاريخ',[Time] as 'الوقت',[UserName] as 'اسم المستخدم' FROM [Sale_Detalis] , Items where  [Sale_Detalis].Item_ID=Items.Item_ID and [Order_ID]=" + textBox1.Text + " and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");   
                        }
                      else {
                          tbl = db.RunReader("SELECT [Cust_ID] ,[Order_ID] as ' رقم الفاتورة',[Cust_Name] as 'العميل',Items.Item_Name as ' المنتج',[Unit] as 'الوحدة',[Qty] as 'الكمية',[Sale_Detalis].[Tax_Value] * Qty as 'ضريبة القيمه المضافة',[Discount] as 'الخصم',[Sale_Detalis].[Price] as 'السعر بعد الضريبة', Round(([Sale_Detalis].[Price]  * [Qty]) - [Discount],2) as 'الاجمالى',[Date] as 'التاريخ',[Time] as 'الوقت',[UserName] as 'اسم المستخدم' FROM [Sale_Detalis] , Items where  [Sale_Detalis].Item_ID=Items.Item_ID and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
                          
                }
                        lbl.Text = "....";
                        txtRbh7.Text = "0"; 
            }
            else if (rbtnPart.Checked == true)
                {
                    DataTable tblDate = new DataTable();
                    tblDate.Clear();
                        if (checkBox1.Checked == true)
                        {
                            tbl = db.RunReader("SELECT [Cust_ID] , [Order_ID] as ' رقم الفاتورة',[Cust_Name] as 'العميل',Items.Item_Name as ' المنتج',[Unit] as 'الوحدة',[Qty] as 'الكمية',[Sale_Detalis].[Tax_Value] * Qty as 'ضريبة القيمه المضافة',[Discount] as 'الخصم',[Sale_Detalis].[Price] as 'السعر بعد الضريبة', Round(([Sale_Detalis].[Price]  * [Qty]) - [Discount],2) as 'الاجمالى',[Date] as 'التاريخ',[Time] as 'الوقت',[UserName] as 'اسم المستخدم' FROM [Sale_Detalis] , Items where  [Sale_Detalis].Item_ID=Items.Item_ID and [Order_ID]=" + textBox1.Text + " and UserName='" + cbxEmp.Text + "' and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
                    
                        }
                        else {
                            tbl = db.RunReader("SELECT [Cust_ID] , [Order_ID] as ' رقم الفاتورة',[Cust_Name] as 'العميل',Items.Item_Name as ' المنتج',[Unit] as 'الوحدة',[Qty] as 'الكمية',[Sale_Detalis].[Tax_Value] * Qty as 'ضريبة القيمه المضافة',[Discount] as 'الخصم',[Sale_Detalis].[Price] as 'السعر بعد الضريبة',Round(([Sale_Detalis].[Price]  * [Qty]) - [Discount],2) as 'الاجمالى',[Date] as 'التاريخ',[Time] as 'الوقت',[UserName] as 'اسم المستخدم' FROM [Sale_Detalis] , Items where  [Sale_Detalis].Item_ID=Items.Item_ID and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and UserName='" + cbxEmp.Text + "' ", "");
                            }
                        tblDate = db.RunReader("select * from Users where ID=" + cbxEmp.SelectedValue.ToString() + "", "");
                        decimal persent = 0;
                        persent = Convert.ToDecimal(tblDate.Rows[0][5].ToString());
                        decimal newPersent = persent / 100;
                decimal finalPersent = newPersent * 1; //Convert.ToDecimal(txtTotalWithTax.Text.ToString());
                        txtRbh7.Text = finalPersent.ToString();
                        lbl.Text = "نسبته المؤية تساوى" + persent +" " + "%";
            }
            


            if (tbl.Rows.Count >= 1)
            {
                DgvBuyDetalis.DataSource = tbl;
                DgvBuyDetalis.ReadOnly = false;
                for (int i = 0; i <= DgvBuyDetalis.Rows.Count - 1; i++)
                {
                    try
                    {
                        if (Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[9].Value) <= 0)
                        {
                            tbl.Columns[8].ReadOnly = false;
                            DgvBuyDetalis.Rows[i].Cells[9].Value = 0;

                        }
                    }
                    catch (Exception) { }
                    TotalWithTax += Convert.ToDecimal(tbl.Rows[i][9]);
                    TotalTax += Convert.ToDecimal(tbl.Rows[i][6]);
                  
                }
                Total = TotalWithTax - TotalTax;
                txtTotalWithTax.Text = Math.Round(TotalWithTax, 2).ToString();
                txtTotalTax.Text = Math.Round(TotalTax, 2).ToString();
                txtTotal.Text = Math.Round(Total, 2).ToString();
                DgvBuyDetalis.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("لا يوجد مبيعات فى هذه الفترة ", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotalWithTax.Text = "0";
                txtTotalTax.Text = "0";
                txtTotal.Text = "0";
            }
            textBox1.Focus();
        }

        private void Print()
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
                    {
                        tblRpt = db.RunReader("SELECT [Cust_ID] , [Order_ID] as ' رقم الفاتورة',[Cust_Name] as 'العميل',Items.Item_Name as ' المنتج',[Unit] as 'الوحدة',[Qty] as 'الكمية',[Sale_Detalis].[Tax_Value] * Qty as 'ضريبة القيمه المضافة',[Discount] as 'الخصم',[Sale_Detalis].[Price] as 'السعر بعد الضريبة', Round(([Sale_Detalis].[Price]  * [Qty]) - [Discount],2) as 'الاجمالى',[Date] as 'التاريخ',[Time] as 'الوقت',[UserName] as 'اسم المستخدم' FROM [Sale_Detalis] , Items where  [Sale_Detalis].Item_ID=Items.Item_ID and [Order_ID]=" + textBox1.Text + " and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
                    }
                    else
                    {
                        tblRpt = db.RunReader("SELECT [Cust_ID] , [Order_ID] as ' رقم الفاتورة',[Cust_Name] as 'العميل',Items.Item_Name as ' المنتج',[Unit] as 'الوحدة',[Qty] as 'الكمية',[Sale_Detalis].[Tax_Value] * Qty as 'ضريبة القيمه المضافة',[Discount] as 'الخصم',[Sale_Detalis].[Price] as 'السعر بعد الضريبة', Round(([Sale_Detalis].[Price]  * [Qty]) - [Discount],2) as 'الاجمالى',[Date] as 'التاريخ',[Time] as 'الوقت',[UserName] as 'اسم المستخدم' FROM [Sale_Detalis] , Items where  [Sale_Detalis].Item_ID=Items.Item_ID and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");

                    }
                }
                else if (rbtnPart.Checked == true)
                {
                    if (checkBox1.Checked == true)
                    {
                        tblRpt = db.RunReader("SELECT [Cust_ID] , [Order_ID] as ' رقم الفاتورة',[Cust_Name] as 'العميل',Items.Item_Name as ' المنتج',[Unit] as 'الوحدة',[Qty] as 'الكمية',[Sale_Detalis].[Tax_Value] * Qty as 'ضريبة القيمه المضافة',[Discount] as 'الخصم',[Sale_Detalis].[Price] as 'السعر بعد الضريبة', Round(([Sale_Detalis].[Price]  * [Qty]) - [Discount],2) as 'الاجمالى',[Date] as 'التاريخ',[Time] as 'الوقت',[UserName] as 'اسم المستخدم' FROM [Sale_Detalis] , Items where  [Sale_Detalis].Item_ID=Items.Item_ID and [Order_ID]=" + textBox1.Text + " and UserName='" + cbxEmp.Text + "' and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");

                    }
                    else
                    {
                        tblRpt = db.RunReader("SELECT [Cust_ID] , [Order_ID] as ' رقم الفاتورة',[Cust_Name] as 'العميل',Items.Item_Name as ' المنتج',[Unit] as 'الوحدة',[Qty] as 'الكمية',[Sale_Detalis].[Tax_Value] * Qty as 'ضريبة القيمه المضافة',[Discount] as 'الخصم',[Sale_Detalis].[Price] as 'السعر بعد الضريبة',Round(([Sale_Detalis].[Price]  * [Qty]) - [Discount],2) as 'الاجمالى',[Date] as 'التاريخ',[Time] as 'الوقت',[UserName] as 'اسم المستخدم' FROM [Sale_Detalis] , Items where  [Sale_Detalis].Item_ID=Items.Item_ID and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and UserName='" + cbxEmp.Text + "' and '" + d2 + "'", "");

                    }
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
                RptSalesReport2 rpt = new RptSalesReport2();
                string dFrom = DtbStart.Value.ToString("dd/M/yyyy");
                string dTo = DtbEnd.Value.ToString("dd/M/yyyy");

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (DgvBuyDetalis.Rows.Count >= 1)
            {
                Print();
            }
            else
            {
                MessageBox.Show("لا يوجد عمليات بيع حتى تتم طباعتها", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");
            if (MessageBox.Show("تحذير سيتم مسح جميع البيانات فى هذه الفترة ", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete from Sale where Convert(date,Date,105) between '" + d + "' and '" + d2 + "' ", "");
                db.RunNunQuary("delete from Sale_Detalis where Convert(date,Date,105) between '" + d + "' and '" + d2 + "' ", "تم حذف جميع البيانات فى هذه الفترة  بنجاح");

            }
        }
        private void PrintOne()
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
                if (Properties.Settings.Default.PrinterName == "لم يتم تحديد طابعة")
                {
                    MessageBox.Show("من فضلك حدد طابعة من شاشة اعدادات البرنامج", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                decimal num = Convert.ToDecimal(DgvBuyDetalis.CurrentRow.Cells[1].Value);
                decimal cust_id = Convert.ToDecimal(DgvBuyDetalis.CurrentRow.Cells[0].Value);
                DataTable tblRpt = new DataTable();
                tblRpt.Clear();
                int x = Convert.ToInt32(DgvBuyDetalis.CurrentRow.Cells[0].Value);

                tblRpt = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Items.Item_Name as المنتج ,[Qty]  as الكمية,[Price]  as السعر,[Date]  as التاريخ,Unit as 'الوحدة',([Qty] * [Price])- Discount as الاجمالى,(Total) as  الاجمالى_العام,Madfo3 as المدفوع,(Total) - (Madfo3)  as الباقى,Cust_Name as اسم_العميل,UserName as 'اسم المستخدم',Discount as 'خصم',[Sale_Detalis].Tax_Value * [Qty] as 'الضرائب' FROM [Sale_Detalis],Items  where Items.Item_ID=Sale_Detalis.Item_ID  and Sale_Detalis.Order_ID=" + num + "", "");

                Frm_Printing frm = new Frm_Printing();
                if (Properties.Settings.Default.PrinterA4 == false)
                {
                    RptPrintOrder rpt = new RptPrintOrder();
                    frm.crystalReportViewer1.RefreshReport();
                    rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");

                    //"", "", ".\\SQLExpress", "Sales_StandardV2"
                    rpt.SetDataSource(tblRpt);
                    rpt.SetParameterValue("ID", num);

                    frm.crystalReportViewer1.ReportSource = rpt;

                    try
                    {
                        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                        rpt.PrintToPrinter(1, true, 0, 0);
                    }
                    catch (Exception) { }
                }
                else
                {
                    RptPrintOrderA4 rpt = new RptPrintOrderA4();
                    frm.crystalReportViewer1.RefreshReport();
                    rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");

                    //"", "", ".\\SQLExpress", "Sales_StandardV2"
                    rpt.SetDataSource(tblRpt);
                    rpt.SetParameterValue("ID", num);
                    rpt.SetParameterValue("@cust_id", cust_id);
                    frm.crystalReportViewer1.ReportSource = rpt;
                    
                    try
                    {
                        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                        rpt.PrintToPrinter(1, true, 0, 0);
                    }
                    catch (Exception) { }
                }

                //frm.ShowDialog();
            }
            catch (Exception) { }
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (DgvBuyDetalis.Rows.Count >= 1)
            {
                PrintOne();
            }
            else { MessageBox.Show("لا يوجد بيانات حتى يتم طباعتها","تاكيد",MessageBoxButtons.OK ,MessageBoxIcon.Information); }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }
    }
}
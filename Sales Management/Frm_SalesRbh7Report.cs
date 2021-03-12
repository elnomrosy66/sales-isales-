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
    public partial class Frm_SalesRbh7Report : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SalesRbh7Report()
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
        private void Frm_SalesRbh7Report_Load(object sender, EventArgs e)
        {
            FillOwners();
            if (Properties.Settings.Default.UserType == "مدير")
            {
                btnDelete.Enabled = true;
                type = true;
            }
            else
            {
                type = false;
                btnDelete.Enabled = false;
            }
            DtbStart.Text = DateTime.Now.ToShortDateString();
            DtbEnd.Text = DateTime.Now.ToShortDateString();
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            decimal TotalWithTax, Totalrbh7;
            tbl.Clear(); TotalWithTax = 0; Totalrbh7 = 0;
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");


            if (rbtnAll.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    tbl = db.RunReader("SELECT [Order_ID] as 'رقم الفاتورة',Items.[Item_Name] as 'اسم المنتج',[Cust_Name] as 'العميل',Sale_Detalis_Rbh7.Unit as 'الوحدة' ,[Qty] as 'الكمية',[Buy_Price] as 'سعر الشراء',[Discount] as 'الخصم',[Sale_Price] as 'سعر البيع',Round(([Qty] * [Sale_Price] ) - [Discount],2) as 'الاجمالى',Round ((( [Sale_Price] -  [Buy_Price]) * ([Qty] )) - [Discount],2) as 'اجمالى الربح',[Date] as 'التاريخ',[Time] as 'الوقت',[User_Name] as 'اسم المستخدم'  FROM [Sale_Detalis_Rbh7],Items where [Sale_Detalis_Rbh7].Item_ID=Items.Item_ID and [Order_ID]=" + textBox1.Text + " and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
                }
                else
                {
                    tbl = db.RunReader("SELECT [Order_ID] as 'رقم الفاتورة',Items.[Item_Name] as 'اسم المنتج',[Cust_Name] as 'العميل',Sale_Detalis_Rbh7.Unit as 'الوحدة',[Qty] as 'الكمية',[Buy_Price] as 'سعر الشراء',[Discount] as 'الخصم',[Sale_Price] as 'سعر البيع',Round(([Qty] * [Sale_Price] ) - [Discount],2) as 'الاجمالى',Round ((( [Sale_Price] -  [Buy_Price]) * ([Qty] )) - [Discount],2) as 'اجمالى الربح',[Date] as 'التاريخ',[Time] as 'الوقت',[User_Name] as 'اسم المستخدم'  FROM [Sale_Detalis_Rbh7],Items where [Sale_Detalis_Rbh7].Item_ID=Items.Item_ID and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");

                }
            }
            else if (rbtnPart.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    tbl = db.RunReader("SELECT [Order_ID] as 'رقم الفاتورة',Items.[Item_Name] as 'اسم المنتج',[Cust_Name] as 'العميل',Sale_Detalis_Rbh7.Unit as 'الوحدة',[Qty] as 'الكمية',[Buy_Price] as 'سعر الشراء',[Discount] as 'الخصم',[Sale_Price] as 'سعر البيع',Round(([Qty] * [Sale_Price] ) - [Discount],2) as 'الاجمالى',Round ((( [Sale_Price] -  [Buy_Price]) * ([Qty] )) - [Discount],2) as 'اجمالى الربح',[Date] as 'التاريخ',[Time] as 'الوقت',[User_Name] as 'اسم المستخدم'  FROM [Sale_Detalis_Rbh7],Items where [Sale_Detalis_Rbh7].Item_ID=Items.Item_ID and [Order_ID]=" + textBox1.Text + " and UserName='" + cbxEmp.Text + "' and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");

                }
                else
                {
                    tbl = db.RunReader("SELECT [Order_ID] as 'رقم الفاتورة',Items.[Item_Name] as 'اسم المنتج',[Cust_Name] as 'العميل',Sale_Detalis_Rbh7.Unit as 'الوحدة',[Qty] as 'الكمية',[Buy_Price] as 'سعر الشراء',[Discount] as 'الخصم',[Sale_Price] as 'سعر البيع',Round(([Qty] * [Sale_Price] ) - [Discount],2) as 'الاجمالى',Round ((( [Sale_Price] -  [Buy_Price]) * ([Qty] )) - [Discount],2) as 'اجمالى الربح',[Date] as 'التاريخ',[Time] as 'الوقت',[User_Name] as 'اسم المستخدم'  FROM [Sale_Detalis_Rbh7],Items where [Sale_Detalis_Rbh7].Item_ID=Items.Item_ID and Convert(date,Date,105) Between '" + d + "' and UserName='" + cbxEmp.Text + "' and '" + d2 + "'", "");

                }
            }



            if (tbl.Rows.Count >= 1)
            {
                DgvBuyDetalis.DataSource = tbl;
                DgvBuyDetalis.ReadOnly = false;
                for (int i = 0; i <= DgvBuyDetalis.Rows.Count - 1; i++)
                {
                    TotalWithTax += Convert.ToDecimal(tbl.Rows[i][8]);
                    Totalrbh7 += Convert.ToDecimal(tbl.Rows[i][9]);
                }

                txtTotalWithTax.Text = Math.Round(TotalWithTax, 2).ToString();
                txtTotalRbh7.Text = Math.Round(Totalrbh7, 2).ToString();
            }
            else
            {
                MessageBox.Show("لا يوجد مبيعات فى هذه الفترة ", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotalWithTax.Text = "0";
                txtTotalRbh7.Text = "0";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");
            if (MessageBox.Show("تحذير سيتم مسح جميع البيانات فى هذه الفترة ", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete from Sale_Detalis_Rbh7 where Convert(date,Date,105) between '" + d + "' and '" + d2 + "' ", "تم حذف جميع البيانات فى هذه الفترة  بنجاح");

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (DgvBuyDetalis.Rows.Count >= 1)
            {
                Print();
            }
            else
            {
                MessageBox.Show("لا يوجد عمليات  حتى تتم طباعتها", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /***************************/
        private void Print()
        {
            
                string d = DtbStart.Value.ToString("yyyy-MM-dd");
                string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");
                DataTable tblRpt = new DataTable();
                tblRpt.Clear();


                if (rbtnAll.Checked == true)
                {
                    if (checkBox1.Checked == true)
                    {
                        tbl = db.RunReader("SELECT [Order_ID] as 'رقم الفاتورة',Items.[Item_Name] as 'اسم المنتج',[Cust_Name] as 'العميل',Sale_Detalis_Rbh7.Unit as 'الوحدة' ,[Qty] as 'الكمية',[Buy_Price] as 'سعر الشراء',[Discount] as 'الخصم',[Sale_Price] as 'سعر البيع',Round(([Qty] * [Sale_Price] ) - [Discount],2) as 'الاجمالى',Round ((( [Sale_Price] -  [Buy_Price]) * ([Qty] )) - [Discount],2) as 'اجمالى الربح',[Date] as 'التاريخ',[Time] as 'الوقت',[User_Name] as 'اسم المستخدم'  FROM [Sale_Detalis_Rbh7],Items where [Sale_Detalis_Rbh7].Item_ID=Items.Item_ID and [Order_ID]=" + textBox1.Text + " and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");
                    }
                    else
                    {
                        tbl = db.RunReader("SELECT [Order_ID] as 'رقم الفاتورة',Items.[Item_Name] as 'اسم المنتج',[Cust_Name] as 'العميل',Sale_Detalis_Rbh7.Unit as 'الوحدة',[Qty] as 'الكمية',[Buy_Price] as 'سعر الشراء',[Discount] as 'الخصم',[Sale_Price] as 'سعر البيع',Round(([Qty] * [Sale_Price] ) - [Discount],2) as 'الاجمالى',Round ((( [Sale_Price] -  [Buy_Price]) * ([Qty] )) - [Discount],2) as 'اجمالى الربح',[Date] as 'التاريخ',[Time] as 'الوقت',[User_Name] as 'اسم المستخدم'  FROM [Sale_Detalis_Rbh7],Items where [Sale_Detalis_Rbh7].Item_ID=Items.Item_ID and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");

                    }
                }
                else if (rbtnPart.Checked == true)
                {
                    if (checkBox1.Checked == true)
                    {
                        tbl = db.RunReader("SELECT [Order_ID] as 'رقم الفاتورة',Items.[Item_Name] as 'اسم المنتج',[Cust_Name] as 'العميل',Sale_Detalis_Rbh7.Unit as 'الوحدة',[Qty] as 'الكمية',[Buy_Price] as 'سعر الشراء',[Discount] as 'الخصم',[Sale_Price] as 'سعر البيع',Round(([Qty] * [Sale_Price] ) - [Discount],2) as 'الاجمالى',Round ((( [Sale_Price] -  [Buy_Price]) * ([Qty] )) - [Discount],2) as 'اجمالى الربح',[Date] as 'التاريخ',[Time] as 'الوقت',[User_Name] as 'اسم المستخدم'  FROM [Sale_Detalis_Rbh7],Items where [Sale_Detalis_Rbh7].Item_ID=Items.Item_ID and [Order_ID]=" + textBox1.Text + " and UserName='" + cbxEmp.Text + "' and Convert(date,Date,105) Between '" + d + "' and '" + d2 + "'", "");

                    }
                    else
                    {
                        tbl = db.RunReader("SELECT [Order_ID] as 'رقم الفاتورة',Items.[Item_Name] as 'اسم المنتج',[Cust_Name] as 'العميل',Sale_Detalis_Rbh7.Unit as 'الوحدة',[Qty] as 'الكمية',[Buy_Price] as 'سعر الشراء',[Discount] as 'الخصم',[Sale_Price] as 'سعر البيع',Round(([Qty] * [Sale_Price] ) - [Discount],2) as 'الاجمالى',Round ((( [Sale_Price] -  [Buy_Price]) * ([Qty] )) - [Discount],2) as 'اجمالى الربح',[Date] as 'التاريخ',[Time] as 'الوقت',[User_Name] as 'اسم المستخدم'  FROM [Sale_Detalis_Rbh7],Items where [Sale_Detalis_Rbh7].Item_ID=Items.Item_ID and Convert(date,Date,105) Between '" + d + "' and UserName='" + cbxEmp.Text + "' and '" + d2 + "'", "");

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
                try
                {
                    Frm_Printing frm = new Frm_Printing();
                    RptSalesReportRb7h rpt = new RptSalesReportRb7h();
                    string dFrom = DtbStart.Value.ToString("dd/MM/yyyy");
                    string dTo = DtbEnd.Value.ToString("dd/MM/yyyy");

                    frm.crystalReportViewer1.RefreshReport();
                    rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");
                    rpt.SetDataSource(tbl);
                    rpt.SetParameterValue("Start", dFrom);
                    rpt.SetParameterValue("End", dTo);
                    frm.crystalReportViewer1.ReportSource = rpt;
                    //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    //rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                    //rpt.PrintToPrinter(1, true, 0, 0);
                    frm.ShowDialog();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
        
       /*************************/

        
        
    }
}
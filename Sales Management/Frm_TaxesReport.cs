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
    public partial class Frm_TaxesReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_TaxesReport()
        {
            InitializeComponent();
        }

      
        DB db = new DB();
        DataTable tbl = new DataTable();
      

        private void Frm_TaxesReport_Load(object sender, EventArgs e)
        {
            DtbStart.Text = DateTime.Now.ToShortDateString();
            DtbEnd.Text = DateTime.Now.ToShortDateString();
       
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            decimal Total;
            tbl.Clear(); Total = 0;
            string d = DtbStart.Value.ToString("yyyy-MM-dd");
            string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");

            string sale = "فاتورة مبيعات", buy = "فاتورة شراء", returnSale = "مرتجعات بيع", returnBuy = "مرتجعات مشتريات";
            string STAT = "";

            if (checkBuy.Checked == true)
                tbl = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('"+buy+"') ", "");

             if (checkSale.Checked == true)
                 tbl = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + sale + "') ", "");

            if (checkReturnSale.Checked == true)
                 tbl = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + returnSale + "') ", "");

            if (checkReturnBuy.Checked == true)
                 tbl = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + returnBuy + "') ", "");
            
            if (checkSale.Checked == true && checkBuy.Checked == true )
                tbl = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + buy + "','" + sale +"')", "");

            if (checkReturnSale.Checked == true && checkReturnBuy.Checked == true)
                 tbl = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + returnBuy + "','" + returnSale + "')", "");

            if (checkReturnSale.Checked == true && checkSale.Checked == true)
                 tbl = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + sale + "','" + returnSale + "')", "");
             if (checkReturnSale.Checked == true && checkBuy.Checked == true)
                 tbl = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + buy + "','" + returnSale + "')", "");
             if (checkBuy.Checked == true && checkReturnBuy.Checked == true)
                 tbl = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + buy + "','" + returnBuy + "')", "");
           




             if (checkSale.Checked == true && checkBuy.Checked == true && checkReturnBuy.Checked == true)
                tbl = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + buy + "','" + returnBuy + "','" + sale + "' )", "");
             if (checkSale.Checked == true && checkReturnSale.Checked == true && checkReturnBuy.Checked == true)
                 tbl = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + sale + "','" + returnSale + "','" + returnBuy + "' )", "");
             

             if (checkBuy.Checked == true && checkReturnSale.Checked == true && checkReturnBuy.Checked == true)
                 tbl = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + buy + "','" + returnBuy + "','" + returnSale + "' )", "");
             if (checkSale.Checked == true && checkBuy.Checked == true && checkReturnSale.Checked == true )
                 tbl = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + buy + "','" + returnSale + "','" + sale + "' )", "");
             if (checkSale.Checked == true && checkBuy.Checked == true && checkReturnSale.Checked == true && checkReturnBuy.Checked == true)
                 tbl = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type  in ('" + buy + "','" + returnBuy + "','" + sale + "' ,'"+returnSale+"' )", "");
                
            decimal TotalTax = 0, TotalWithTax = 0;

            if (tbl.Rows.Count >= 1)
            {
                DgvSearchBuy.DataSource = tbl;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Total += Convert.ToDecimal(tbl.Rows[i][7]);
                    TotalTax += Convert.ToDecimal(tbl.Rows[i][8]);
                    TotalWithTax += Convert.ToDecimal(tbl.Rows[i][9]);
                }
                txtTotalPhar.Text = Math.Round(Total, 2).ToString();
                txtTotalTax.Text = Math.Round(TotalTax, 2).ToString();
                txtTotalWithTax.Text = Math.Round(TotalWithTax, 2).ToString();
            }
            else
            {
                MessageBox.Show("لا يوجد مشتريات فى هذه الفترة ", "تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotalPhar.Text = "0";
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (DgvSearchBuy.Rows.Count >= 1) {

                string d = DtbStart.Value.ToString("yyyy-MM-dd");
                string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");

            }
        }


        private void Print()
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
                string sale = "فاتورة مبيعات", buy = "فاتورة مشتريات", returnSale = "مرتجعات بيع", returnBuy = "مرتجعات مشتريات";
                string STAT = "";
                string d = DtbStart.Value.ToString("yyyy-MM-dd");
                string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");
                if (checkBuy.Checked == true)
                    tblRpt = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type='" + buy + "' ", "");

                if (checkBuy.Checked == true)
                    tblRpt = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + buy + "') ", "");

                if (checkSale.Checked == true)
                    tblRpt = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + sale + "') ", "");
                if (checkReturnSale.Checked == true)
                    tblRpt = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + returnSale + "') ", "");
                if (checkReturnBuy.Checked == true)
                    tblRpt = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + returnBuy + "') ", "");

                if (checkSale.Checked == true && checkBuy.Checked == true)
                    tblRpt = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + buy + "','" + sale + "')", "");
                if (checkReturnSale.Checked == true && checkReturnBuy.Checked == true)
                    tblRpt = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + returnBuy + "','" + returnSale + "')", "");
                if (checkReturnSale.Checked == true && checkSale.Checked == true)
                    tblRpt = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + sale + "','" + returnSale + "')", "");
                if (checkReturnSale.Checked == true && checkBuy.Checked == true)
                    tblRpt = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + buy + "','" + returnSale + "')", "");
                if (checkBuy.Checked == true && checkReturnBuy.Checked == true)
                    tblRpt = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + buy + "','" + returnBuy + "')", "");





                if (checkSale.Checked == true && checkBuy.Checked == true && checkReturnBuy.Checked == true)
                    tblRpt = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + buy + "','" + returnBuy + "','" + sale + "' )", "");
                if (checkSale.Checked == true && checkReturnSale.Checked == true && checkReturnBuy.Checked == true)
                    tblRpt = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + sale + "','" + returnSale + "','" + returnBuy + "' )", "");


                if (checkBuy.Checked == true && checkReturnSale.Checked == true && checkReturnBuy.Checked == true)
                    tblRpt = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + buy + "','" + returnBuy + "','" + returnSale + "' )", "");
                if (checkSale.Checked == true && checkBuy.Checked == true && checkReturnSale.Checked == true)
                    tblRpt = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',[Date] as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type in ('" + buy + "','" + returnSale + "','" + sale + "' )", "");
                if (checkSale.Checked == true && checkBuy.Checked == true && checkReturnSale.Checked == true && checkReturnBuy.Checked == true)
                    tblRpt = db.RunReader("SELECT [Order_ID] as 'مسلسل',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العميله',[Tax_Type] as 'نوع الضريبة',Convert(date,Date,105) as 'التاريخ',[Sup_Name] as 'اسم المورد او العميل',[Cust_Name] as 'اسم العميل',[Total_Price] as 'اجمالى الفاتورة',[Tax_Value] as 'اجمالى الضريبة',[Total_WithTax] as 'اجمالى الفاتورة بعد الضريبة' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' and Order_Type  in ('" + buy + "','" + returnBuy + "','" + sale + "' ,'" + returnSale + "' )", "");
                
                
                Frm_Printing frm = new Frm_Printing();

                RptPrintTaxesReport rpt = new RptPrintTaxesReport();
                string d1 = DtbStart.Value.ToString("dd/MM/yyyy");
                string d3 = DtbEnd.Value.ToString("dd/MM/yyyy");
                frm.crystalReportViewer1.RefreshReport();
                rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");
                rpt.SetDataSource(tblRpt);
                rpt.SetParameterValue("From", d1);
                rpt.SetParameterValue("To", d3);
                frm.crystalReportViewer1.ReportSource = rpt;
                //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                //rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                //rpt.PrintToPrinter(1, true, 0, 0);
                frm.ShowDialog();
            }
            catch (Exception) { }
        }


        private void PrintSummary()
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
                string sale = "فاتورة مبيعات", buy = "فاتورة شراء", returnSale = "مرتجعات بيع", returnBuy = "مرتجعات مشتريات";
                string STAT = "";
                string d = DtbStart.Value.ToString("yyyy-MM-dd");
                string d2 = DtbEnd.Value.ToString("yyyy-MM-dd");

                tblRpt = db.RunReader("SELECT SUM(Total_Price) as 'اجمالى فواتير مرتجعات المبيعات' ,SUM (Tax_Value) as 'اجمالى ضرائب مرتجعات المبيعات' ,SUM (Total_WithTax) as 'اجمالى فواتير مرتجعات المبيعات بعد الضرائب' FROM [Taxes_Report] where  Convert(date,Date,105) Between '" + d + "' and '" + d2 + "' ", "");


                Frm_Printing frm = new Frm_Printing();

                RptPrintTaxesReportSummary rpt = new RptPrintTaxesReportSummary();
                string d1 = DtbStart.Value.ToString("dd/MM/yyyy");
                string d3 = DtbEnd.Value.ToString("dd/MM/yyyy");
                frm.crystalReportViewer1.RefreshReport();
                rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");
                rpt.SetDataSource(tblRpt);

                rpt.SetParameterValue("@FromBuy", d);
                rpt.SetParameterValue("@ToBuy", d2);
                rpt.SetParameterValue("@FromBuyReturn", d);
                rpt.SetParameterValue("@ToBuyReturn", d2);
                rpt.SetParameterValue("@FromSaleReturn", d);
                rpt.SetParameterValue("@ToSaleReturn", d2);
                rpt.SetParameterValue("@FromSale", d);
                rpt.SetParameterValue("@ToSale", d2);
                frm.crystalReportViewer1.ReportSource = rpt;
                //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                //rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                //rpt.PrintToPrinter(1, true, 0, 0);
                frm.ShowDialog();
            }
            catch (Exception) { }
        }


        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (DgvSearchBuy.Rows.Count >= 1) {
                Print();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (DgvSearchBuy.Rows.Count >= 1)
            {
                PrintSummary();
            }
        }
    }
}
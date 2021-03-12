using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CrystalDecisions.Shared;

namespace Sales_Management
{
    public partial class Frm_SalesSuperMarket : DevExpress.XtraEditors.XtraForm
    {
        int flagOfQty = 111;
        private static Frm_SalesSuperMarket frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_SalesSuperMarket GetMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_SalesSuperMarket();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public Frm_SalesSuperMarket()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }
        DB db = new DB();
        private void Frm_SalesSuperMarket_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void FillItems()
        {
            cbxItems.DataSource = db.RunReader("select * from Items", "");
            cbxItems.DisplayMember = "Item_Name";
            cbxItems.ValueMember = "Item_ID";
        }
        public void FillCustomer()
        {
            cbxCustomer.DataSource = db.RunReader("select Cust_Name,Cust_ID from Customer order by Cust_ID DESC", "");
            cbxCustomer.DisplayMember = "Cust_Name";
            cbxCustomer.ValueMember = "Cust_ID";
        }
        int stock_ID;


        private void AutoNum()
        {
            DataTable tblautonum = new DataTable();

            tblautonum.Clear();
            tblautonum = db.RunReader("select max(Order_ID) from Sale", "");
            if (tblautonum.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtOrderID.Text = "1";
            }
            else
            {
                txtOrderID.Text = (Convert.ToInt32(tblautonum.Rows[0][0].ToString()) + 1).ToString();

            }
            try
            {
                try
                {
                    cbxItems.SelectedIndex = 0;
                    cbxCustomer.SelectedIndex = 0;
                }
                catch (Exception) { }
                DtbSaleDate.Text = DateTime.Now.ToShortDateString();
                DtbTime.Text = DateTime.Now.ToShortTimeString();
                DtbReminder.Text = DateTime.Now.ToShortDateString();
                txtTotal.Text = "0";
                lblCount.Text = "0";
                rbtnCustomerNakdy.Checked = true;
                DgvStoreQty.Rows.Clear();
                txtBarcode.Clear();
                cbxItems.Focus();
            }
            catch (Exception) { }
            cbxItems.Text = "اختر منتج";
        }

        private void Frm_SalesSuperMarket_Load(object sender, EventArgs e)
        {
            lblUser.Text = Properties.Settings.Default.UserName;
            stock_ID = Convert.ToInt32(Properties.Settings.Default.UserStock);
            cbxCustomer.Enabled = false;
            btnBrowse.Enabled = false;
            DtbReminder.Enabled = false;
            FillCustomer();
            FillItems();
            try
            {
                AutoNum();
            }
            catch (Exception) { }
            cbxItems.Focus();
            
            
        }

        private void Frm_SalesSuperMarket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1) {
                txtBarcode.Clear();
                cbxItems.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(null,null);
                
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnFavItems_Click(null, null);
            }
            else if (e.KeyCode == Keys.F11)
            {
                if (DgvStoreQty.Rows.Count >= 1)
                {
                  
                    UpdateQty();

                    Properties.Settings.Default.Check = true;
                    Properties.Settings.Default.Save();
                    if (Properties.Settings.Default.Check)
                    { UpdateData();
                   CheckQtyIntheStoreWithGridView();
                    }
                }
            }
            else if (e.KeyCode == Keys.F12)
            {
                if (DgvStoreQty.Rows.Count >= 1)
                {
                    FormPayOrder();
                    if (Properties.Settings.Default.Check) 
                    {

                        CheckQtyIntheStoreWithGridView();
                        if (flagOfQty == 111)
                        {
                            PrintRecit();
                            if (Properties.Settings.Default.SalesPrint == true)
                            {
                                for (int i = 0; i <= Properties.Settings.Default.SalesOrderNum - 1; i++)
                                {
                                    Print();
                                }
                            } 
                        }
                    }
                }
            }
            else if (e.KeyCode == Keys.Enter) { btnAdd_Click(null,null); }
            else if (e.KeyCode == Keys.Delete) { btnDelete_Click(null, null); }
        }

        //**************************************//
        private void Print()
        {
            try
            {
                
               
                decimal num = Convert.ToDecimal(txtOrderID.Text) - 1;
                DataTable tblRpt = new DataTable();
                tblRpt.Clear();
                int x = Convert.ToInt32(txtOrderID.Text) - 1;

                tblRpt = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Items.Item_Name as المنتج ,[Qty]  as الكمية,[Price]  as السعر,[Date]  as التاريخ,Unit as 'الوحدة',([Qty] * [Price])- Discount as الاجمالى,(Total) as  الاجمالى_العام,Madfo3 as المدفوع,(Total) - (Madfo3)  as الباقى,Cust_Name as اسم_العميل,UserName as 'اسم المستخدم',Discount as 'خصم',[Sale_Detalis].Tax_Value * [Qty] as 'الضرائب' FROM [Sale_Detalis],Items  where Items.Item_ID=Sale_Detalis.Item_ID  and Sale_Detalis.Order_ID=" + num + "", "");

                Frm_Printing frm = new Frm_Printing();
                if (Properties.Settings.Default.PrinterA4 == false)
                {
                    RptPrintOrder rpt = new RptPrintOrder();
                    frm.crystalReportViewer1.RefreshReport();
                    rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");

                    rpt.SetDataSource(tblRpt);
                    rpt.SetParameterValue("ID", num);
                    rpt.SetParameterValue("Cust_ID", Cust_ID);
                    //rpt.SetParameterValue("extra", 500);
                    frm.crystalReportViewer1.ReportSource = rpt;
                    
                    try
                    {
                        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                        rpt.PrintToPrinter(1, true, 0, 0);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                }
                else
                {
                    RptPrintOrderA4 rpt = new RptPrintOrderA4();
                    frm.crystalReportViewer1.RefreshReport();
                    rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");

                    //"", "", ".\\SQLExpress", "Sales_StandardV2"
                    rpt.SetDataSource(tblRpt);
                    rpt.SetParameterValue("ID", num);
                    rpt.SetParameterValue("@cust_id", Cust_ID);
                    //rpt.SetParameterValue("extra", 500);
                    frm.crystalReportViewer1.ReportSource = rpt;
                    if (Properties.Settings.Default.PrinterName == "لم يتم تحديد طابعة")
                    {
                        MessageBox.Show("من فضلك حدد طابعة من شاشة اعدادات البرنامج", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    try
                    {
                        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                        rpt.PrintOptions.PrinterDuplex = PrinterDuplex.Vertical;
                        rpt.PrintToPrinter(1, true, 0, 0);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                }
               
                //frm.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        //*******************************//

        string User;
        int Cust_ID;
        string Cust_Name;
        private void PrintRecit() {
            User = Properties.Settings.Default.UserName;
            string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
            string dReminder = DtbReminder.Value.ToString("dd/MM/yyyy");
            //take customer data if exiet or not
            if (rbtnCustomerNakdy.Checked == true)
            { Cust_ID = 0;

            if (txtCustomerNakdy.Text == "")
                Cust_Name = "عميل نقدى";
            else { 
                Cust_Name =txtCustomerNakdy.Text; 
                 }
            
            }
            else if (rbtnCustomerAagel.Checked == true) {
                if (cbxCustomer.Items.Count >= 1)
                {
                    Cust_ID = Convert.ToInt32(cbxCustomer.SelectedValue);
                    Cust_Name = cbxCustomer.Text;
                }
                else { MessageBox.Show("من فضلك اختر العميل اولا","تاكيد",MessageBoxButtons.OK ,MessageBoxIcon.Information); return; }
            }
            DataTable tblUser=new DataTable();
                tblUser = db.RunReader("select * from Stock_Data", "");
                if (tblUser.Rows.Count <= 0)
                { MessageBox.Show("من فضلك تاكد من اضافة بيانات الخزنة اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
          
            //*****************************
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
            
            //*****************************
                if (Properties.Settings.Default.PrinterName == "لم يتم تحديد طابعة")
                {
                    MessageBox.Show("من فضلك حدد طابعة من شاشة اعدادات البرنامج", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            //*****************************
            DataTable tblItems =new DataTable();
            tblItems.Clear();
            decimal taxValue=0 ,priceAfterTax =0 , taxCount=0;
            db.RunNunQuary("insert into Sale Values ("+txtOrderID.Text+" , N'"+d+"' ,"+Cust_ID+" ,N'"+Cust_Name+"')", "");
            for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                {
                   tblItems=db.RunReader("select * from Items where Item_ID="+DgvStoreQty.Rows[i].Cells[0].Value+"","");
                   priceAfterTax=Convert.ToDecimal(tblItems.Rows[0][11]) ;
                ///***/
                   decimal QtyInUnit = 0;
                   DataTable tblQty = new DataTable();
                   tblQty.Clear();
                   tblQty = db.RunReader("select * from Items_Unit where Item_ID=" + DgvStoreQty.Rows[i].Cells[0].Value + " and Unit_Name=N'" + Convert.ToString(DgvStoreQty.Rows[i].Cells[2].Value) + "'", "");
                   try
                   {
                       QtyInUnit = Convert.ToDecimal(tblQty.Rows[0][3]);
                   }
                   catch (Exception) { }
                   if (QtyInUnit >= 1)
                   {
                       taxValue = (Convert.ToDecimal(tblItems.Rows[0][11]) - Convert.ToDecimal(tblItems.Rows[0][5])) / QtyInUnit;
                   }
                   else
                   {
                       taxValue = Convert.ToDecimal(tblItems.Rows[0][11]) - Convert.ToDecimal(tblItems.Rows[0][5]);
                   }
                  //to count Order Tax value
                   taxCount += (taxValue) * Convert.ToDecimal( DgvStoreQty.Rows[i].Cells[3].Value );
                  
                   
                   db.RunNunQuary("insert into Sale_Detalis Values (" + txtOrderID.Text + " ," + DgvStoreQty.Rows[i].Cells[0].Value + "," + Cust_ID + " ,N'" + Cust_Name + "' ,N'" + DgvStoreQty.Rows[i].Cells[2].Value + "' ," + DgvStoreQty.Rows[i].Cells[3].Value + " ," + DgvStoreQty.Rows[i].Cells[4].Value + " ,N'" + d + "' ," + DgvStoreQty.Rows[i].Cells[5].Value + " ," + txtTotal.Text + " ," + Properties.Settings.Default.OrderMadfo3 + " ,'" + User + "' ,'" + DtbTime.Text + "' ," + taxValue + " ," + priceAfterTax + ")", "");
                  //update Qty in Store
                   UpdateQtyInStore(Convert.ToInt32(DgvStoreQty.Rows[i].Cells[0].Value), Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[3].Value), i, Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[4].Value));
                }

            //check if customer pay cash or Aagel
            decimal baky = 0 ;
            if (rbtnCustomerAagel.Checked == true)
            {
                baky = Properties.Settings.Default.OrderBaky;
                db.RunNunQuary("insert into Customer_Money Values (" + txtOrderID.Text + "," + baky + "," + cbxCustomer.SelectedValue + ",'" + d + "' ,'" + dReminder + "','مبيعات')", "");
            }
            if (Properties.Settings.Default.OrderMadfo3 >= 1)
            {
                db.RunNunQuary("insert into Customer_Report Values(" + txtOrderID.Text + " ,N'" + cbxCustomer.Text + "'," + Properties.Settings.Default.OrderMadfo3 + ",N'" + d + "')", "");
            }
            //insert the money into the stock or bank
            if (Properties.Settings.Default.PayCridetCard == false)
            {
                db.RunNunQuary("update Stock set Money=Money + " + Properties.Settings.Default.OrderMadfo3 + " where Stock_ID=" + Properties.Settings.Default.UserStock + "", "");
                db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type ,Stock_ID) Values(" + Properties.Settings.Default.OrderMadfo3 + " ,'" + d + "' ,'"+Cust_Name+"','عملية بيع'," + Properties.Settings.Default.UserStock + ")", "");
            }
            else if (Properties.Settings.Default.PayCridetCard == true)
            {
                db.RunNunQuary("update Bank set Money=Money + " + Properties.Settings.Default.OrderMadfo3 + "", "");
                db.RunNunQuary("insert into Bank_Insert  (Money ,Date,Name ,Type) Values(" + Properties.Settings.Default.OrderMadfo3 + " ,'" + d + "' ,'"+Cust_Name+"','عملية مبيعات')", "");

            }
            //insert Order in Taxes
            decimal totalWithoutTax = (Properties.Settings.Default.OrderTotal) - taxCount;
            db.RunNunQuary("insert into Taxes_Report (Order_Type,Tax_Type,Date,Sup_Name,Cust_Name,Total_Price,Tax_Value,Total_WithTax ,Order_Num) Values ('فاتورة مبيعات','قيمة مضافة','" + d + "' ,'لا يوجد' ,N'" + Cust_Name + "' ," + totalWithoutTax + " ," + taxCount + " ," + txtTotal.Text + "," + txtOrderID.Text + ")", "");
                   
            //*****************************
            AutoNum();
            //*****************************
        }
        decimal QtyInGrid = 0,ItemIDGrid=0;

        private void UpdateQtyInStore( int ID ,decimal qty,int i ,decimal salePrice) {

            ItemIDGrid = Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[0].Value);
            decimal QtyInUnit = 0,qtyFinal=0;
            DataTable tblQty = new DataTable();
            tblQty.Clear();
            tblQty = db.RunReader("select * from Items_Unit where Item_ID=" + ItemIDGrid + " and Unit_Name=N'" + Convert.ToString(DgvStoreQty.Rows[i].Cells[2].Value) + "'", "");
            try
            {
                QtyInUnit = Convert.ToDecimal(tblQty.Rows[0][3]);
            }
            catch (Exception) { }
            if (QtyInUnit >= 1)
            {
                qtyFinal = Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[3].Value) / QtyInUnit ;
            }
            else {
                qtyFinal = qty;
            }
            decimal pricebuy = PriceBuy(ID, qty, i, salePrice, qtyFinal);

            db.RunNunQuary("update Items set Item_Qty =Item_Qty -(" + qtyFinal + ") where Item_ID=" + (DgvStoreQty.Rows[i].Cells[0].Value) + "", "");
  
        }
        //********************************************

        private void InsertDataRbh7(decimal Buy, int i, decimal qty ,decimal salePrice ,string unit)
        {


            try
            {

                string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
                
                db.RunNunQuary("insert into Sale_Detalis_Rbh7 values(" + txtOrderID.Text + "," + DgvStoreQty.Rows[i].Cells[0].Value + ","+Cust_ID + " ,'"+Cust_Name+"'," + qty + ", " + Buy + "," + salePrice + ",'" + d + "'," + DgvStoreQty.Rows[i].Cells[5].Value + "," + txtTotal.Text + "," + Properties.Settings.Default.OrderMadfo3 + ",'" + DtbTime.Text + "'  ,'" + User + "' ,'"+unit+"' )", "");
                  

            }
            catch (Exception) { }
        }


        //*********************************************
        
        ///////////////////////////////////***

        private decimal PriceBuy(int row, decimal qty, int i ,decimal salePrice,decimal qtyPart)
        {
            DataTable tblPrice = new DataTable();
            tblPrice.Clear();
            DataTable tblQty = new DataTable(); DataTable tblUnit = new DataTable();
            tblQty.Clear(); tblUnit.Clear();
            decimal QrtImUnit = 1;
            db.RunNunQuary("delete from Items_Qty where Qty <=0", "");
            decimal buyPrice = 0;
            try
            {
                decimal qtyDef = 0;
                tblPrice = db.RunReader("select Top 1 * from Items_Qty where Item_ID=" + row + " and Qty >=1", "");
                tblUnit = db.RunReader("select * from Items_Unit where Item_ID="+row+" and Unit_Name=N'"+DgvStoreQty.Rows[i].Cells[2].Value+"'","");
                try
                {
                    QrtImUnit = Convert.ToDecimal(tblUnit.Rows[0][3]);
                }
                catch (Exception) { }
                try
                {
                    qtyDef = Convert.ToDecimal(tblPrice.Rows[0][3]) - qtyPart;
                }
                catch (Exception) { }
                if (qtyDef >= 1)
                {
                    db.RunNunQuary("update Items_Qty set Qty =Qty -(" + qtyPart + ") where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + "", "");
                    InsertDataRbh7(Convert.ToDecimal(tblPrice.Rows[0][4]) / QrtImUnit, i, qty, salePrice, Convert.ToString(DgvStoreQty.Rows[i].Cells[2].Value));
                    tblPrice = db.RunReader("select Top 1 * from Items_Qty where Item_ID=" + row + " and Qty >=1", "");
                    qtyDef = Convert.ToDecimal(db.RunReader("select Top 1 (Qty) from Items_Qty where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + "", "").Rows[0][0]);
                    if (qtyDef <= 0)
                    {
                        db.RunNunQuary("delete from Items_Qty where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + " ", "");
                    }
                }
                else
                {
                    decimal num = 0;
                    decimal def = 0;
                    def = Math.Abs(qtyPart + qtyDef);
                    decimal DEF = 0, QTYDEF = 0;
                    num = qtyPart;
                    DEF = def;
                    QTYDEF = qtyDef;
                    tblQty = db.RunReader("select * from Items_Qty where Item_ID=" + row + "", "");
                    for (int x = 0; x <= tblQty.Rows.Count - 1; x++)
                    {


                        tblPrice = db.RunReader("select Top 1 * from Items_Qty where Item_ID=" + row + " and Qty >=1", "");

                        qtyDef = Convert.ToDecimal(tblPrice.Rows[0][3]) - num;
                        if (qtyDef < 0)
                        {
                            Math.Abs(qtyDef);
                            def = Math.Abs(num + qtyDef);
                            QTYDEF = def;
                            db.RunNunQuary("update Items_Qty set Qty =Qty -(" + QTYDEF + ") where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + "", "");
                            InsertDataRbh7(Convert.ToDecimal(tblPrice.Rows[0][4]) / QrtImUnit, i, QTYDEF, salePrice, Convert.ToString(DgvStoreQty.Rows[i].Cells[2].Value));
                            num -= QTYDEF;
                        }
                        else
                        {

                            db.RunNunQuary("update Items_Qty set Qty =Qty -(" + DEF + ") where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + "", "");
                            InsertDataRbh7(Convert.ToDecimal(tblPrice.Rows[0][4]) / QrtImUnit, i, DEF, salePrice, Convert.ToString(DgvStoreQty.Rows[i].Cells[2].Value));
                            num -= DEF;
                        }

                        if (num <= 0)
                        {

                            buyPrice = Convert.ToDecimal(tblPrice.Rows[0][4]);
                            return buyPrice;
                        }
                        tblPrice = db.RunReader("select Top 1 * from Items_Qty where Item_ID=" + row + " and Qty <=0", "");
                        if (Convert.ToInt32(tblPrice.Rows[0][3]) <= 0)
                        {
                            db.RunNunQuary("delete from Items_Qty where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + " ", "");
                        }
                        tblPrice.Clear();
                        tblPrice = db.RunReader("select Top 1 * from Items_Qty where Item_ID=" + row + " and Qty >=1", "");


                        qtyDef = Convert.ToDecimal(tblPrice.Rows[0][3]) - num;
                        if (qtyDef < 0)
                        {
                            Math.Abs(qtyDef);
                            def = Math.Abs(num + qtyDef);
                            QTYDEF = def;
                            db.RunNunQuary("update Items_Qty set Qty =Qty -(" + QTYDEF + ") where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + "", "");
                            InsertDataRbh7(Convert.ToDecimal(tblPrice.Rows[0][4]) / QrtImUnit, i, QTYDEF, salePrice, Convert.ToString(DgvStoreQty.Rows[i].Cells[2].Value));
                            num -= QTYDEF;
                            db.RunNunQuary("delete from Items_Qty where Item_ID=" + row + " and Qty <=0  ", "");
                        }
                        else if (qtyDef == 0)
                        {
                            db.RunNunQuary("update Items_Qty set Qty =Qty -(" + num + ") where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + "", "");
                            InsertDataRbh7(Convert.ToDecimal(tblPrice.Rows[0][4]) / QrtImUnit, i, num, salePrice, Convert.ToString(DgvStoreQty.Rows[i].Cells[2].Value));
                            num = 0;
                            db.RunNunQuary("delete from Items_Qty where Item_ID=" + row + " and Qty <=0  ", "");
                        }
                        else if (qtyDef >= 1)
                        {
                            db.RunNunQuary("update Items_Qty set Qty =Qty -(" + num + ") where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + "", "");
                            InsertDataRbh7(Convert.ToDecimal(tblPrice.Rows[0][4]) / QrtImUnit, i, num, salePrice, Convert.ToString(DgvStoreQty.Rows[i].Cells[2].Value));
                            num -= num;
                        }
                        tblPrice = db.RunReader("select Top 1 * from Items_Qty where Item_ID=" + row + " and Qty <=0", "");
                        if (tblPrice.Rows.Count >=1)
                        {
                            db.RunNunQuary("delete from Items_Qty where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + " ", "");
                        }
                        if (num <= 0)
                        {
                            db.RunNunQuary("delete from Items_Qty where Item_ID=" + row + " and Qty <=0  ", "");
                    
                            buyPrice = Convert.ToDecimal(tblPrice.Rows[0][4]);
                            DEF = num;
                            return buyPrice;
                        }
                        else
                        { DEF = num; }

                    }
                }
            }
            catch (Exception) { }
            db.RunNunQuary("delete from Items_Qty where Item_ID=" + row + " and Qty <=0  ", "");
            try
            {
                buyPrice = Convert.ToDecimal(tblPrice.Rows[0][4]);
            }
            catch (Exception) { }

            return buyPrice;
        }


       //*************************************

        private void  UpdateData(){
            int index = 0;
            index = DgvStoreQty.SelectedRows[0].Index;

            DgvStoreQty.Rows[index].Cells[2].Value = Properties.Settings.Default.Item_Unit;
            DgvStoreQty.Rows[index].Cells[3].Value = Properties.Settings.Default.Item_qty;
            DgvStoreQty.Rows[index].Cells[4].Value = Properties.Settings.Default.Item_Price;
            DgvStoreQty.Rows[index].Cells[5].Value = Properties.Settings.Default.Item_Discount;
               
        }
        public string Item_ID,Item_qty,Item_Unit,Item_Discount,Item_Price;
        public void UpdateQty() {


                int index = 0;
                index =DgvStoreQty.SelectedRows[0].Index;
                Item_ID = Convert.ToString(DgvStoreQty.Rows[index].Cells[0].Value);
                Item_qty = Convert.ToString(DgvStoreQty.Rows[index].Cells[3].Value);
                Item_Unit = Convert.ToString(DgvStoreQty.Rows[index].Cells[2].Value);
                Item_Discount = Convert.ToString(DgvStoreQty.Rows[index].Cells[5].Value);
                Item_Price = Convert.ToString(DgvStoreQty.Rows[index].Cells[4].Value);

                Properties.Settings.Default.Item_ID = Item_ID;
                Properties.Settings.Default.Item_qty = Item_qty;
                Properties.Settings.Default.Item_Unit = Item_Unit;
                Properties.Settings.Default.Item_Discount = Item_Discount;
                Properties.Settings.Default.Item_Price = Item_Price;
            
            //Properties.Settings.Default.Check = false;
            Properties.Settings.Default.Save();
            
        

            Frm_Qty frm = new Frm_Qty();
            frm.ShowDialog(this);
            decimal unitRatio = Convert.ToDecimal(db.RunReader("select * from Items_Unit where Item_ID=" + Item_ID + " and Unit_Name=N'" + Item_Unit + "'", "").Rows[0][3]);
            decimal salePrice = Convert.ToDecimal(Properties.Settings.Default.Item_Price);
            decimal buyPrice = Convert.ToDecimal(db.RunReader("select Top 1 * from Items_Qty where Item_ID=" + Properties.Settings.Default.Item_ID.ToString() + " and Qty >=1", "").Rows[0][4]);
            if (salePrice < (buyPrice / unitRatio))
            {
                MessageBox.Show("سعر البيع لهذا المنتج اقل من سعر الشراء");
            }
        }

        public decimal  OrderID ;
        public decimal OrderTotal, OrderMadfo3, OrderBaky;
        public void FormPayOrder()
        {
            OrderID =Convert.ToDecimal( txtOrderID.Text );
            OrderTotal = Convert.ToDecimal(txtTotal.Text);
            OrderMadfo3 = 0; OrderBaky = 0;
            Properties.Settings.Default.OrderID = OrderID;
            Properties.Settings.Default.OrderTotal = OrderTotal;
            Properties.Settings.Default.OrderMadfo3 = OrderMadfo3;
            Properties.Settings.Default.OrderBaky = OrderBaky;
            Frm_PaySales frm = new Frm_PaySales();
            frm.ShowDialog(this);
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataTable tbl = new DataTable();
            DataTable tblUnit = new DataTable();
            tbl.Clear(); tblUnit.Clear();
            if (e.KeyChar == 13) {
                if (txtBarcode.Text == "") { return; }
                tbl = db.RunReader("select * from Items where [Barcode]='"+txtBarcode.Text+"'", "");
                if (tbl.Rows.Count >= 1)
                {
                    string Item_ID=tbl.Rows[0][0].ToString();
                    string Item_Name=tbl.Rows[0][1].ToString();
                    string Item_Unit=tbl.Rows[0][15].ToString();
                     string Item_Qty="1";
                     string Item_Price=tbl.Rows[0][11].ToString();
                     string Item_Discount="0.0";
                    DgvStoreQty.Rows.Add(1);
                    decimal tot;
                    int rowindex = DgvStoreQty.Rows.Count - 1;
                    DgvStoreQty.Rows[rowindex].Cells[0].Value = Item_ID;
                    DgvStoreQty.Rows[rowindex].Cells[1].Value = Item_Name;
                    DgvStoreQty.Rows[rowindex].Cells[2].Value = Item_Unit;
                    DgvStoreQty.Rows[rowindex].Cells[3].Value = Item_Qty;
                    tblUnit = db.RunReader("select * from Items_Unit where Item_ID=" + Item_ID + " and Unit_Name=N'" + Item_Unit + "'", "");
                    decimal price = 0;
                    try
                    {
                        price = Convert.ToDecimal(tblUnit.Rows[0][5]) / Convert.ToDecimal(tblUnit.Rows[0][3]);
                    }
                    catch (Exception) { }
                    DgvStoreQty.Rows[rowindex].Cells[4].Value = price;
                    DgvStoreQty.Rows[rowindex].Cells[5].Value = Item_Discount;
                    decimal Total = (Convert.ToDecimal(Item_Qty) * Convert.ToDecimal(Item_Price)) - Convert.ToDecimal(Item_Discount);
                    DgvStoreQty.Rows[rowindex].Cells[6].Value = Total;
                   tot = 0;
                    for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                    {
                        tot += Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[6].Value);
                     
                        DgvStoreQty.ClearSelection();
                        DgvStoreQty.FirstDisplayedScrollingRowIndex = DgvStoreQty.RowCount - 1;
                        DgvStoreQty.Rows[DgvStoreQty.RowCount - 1].Selected = true;


                    }
                    lblCount.Text = (DgvStoreQty.Rows.Count ).ToString();
                    txtTotal.Text =Math.Round( tot,2).ToString();
                    txtBarcode.Clear();
                    cbxItems.Focus();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable(); DataTable tblUnit = new DataTable();
            tbl.Clear(); tblUnit.Clear();
            if (cbxItems.Items.Count >= 1)
            {
                tbl = db.RunReader("select * from Items where Item_ID='" + cbxItems.SelectedValue + "'", "");
                if (tbl.Rows.Count >= 1)
                {
                    string Item_ID = tbl.Rows[0][0].ToString();
                    string Item_Name = tbl.Rows[0][1].ToString();
                    string Item_Unit = tbl.Rows[0][15].ToString();
                    string Item_Qty = "1";
                    string Item_Price = tbl.Rows[0][11].ToString(); // sale price
                    string Item_Discount = "0.0";
                    DgvStoreQty.Rows.Add(1);
                    decimal tot;
                    int rowindex = DgvStoreQty.Rows.Count - 1;
                    DgvStoreQty.Rows[rowindex].Cells[0].Value = Item_ID;
                    DgvStoreQty.Rows[rowindex].Cells[1].Value = Item_Name;
                    DgvStoreQty.Rows[rowindex].Cells[2].Value = Item_Unit;
                    DgvStoreQty.Rows[rowindex].Cells[3].Value = Item_Qty;
                    tblUnit = db.RunReader("select * from Items_Unit where Item_ID=" + Item_ID + " and Unit_Name=N'" + Item_Unit + "'", "");
                    decimal price = 0;
                    try
                    {
                        price = Convert.ToDecimal(tblUnit.Rows[0][5]) / Convert.ToDecimal(tblUnit.Rows[0][3]); //buy price
                    }
                    catch (Exception) { }
                    DgvStoreQty.Rows[rowindex].Cells[4].Value = price;
                    DgvStoreQty.Rows[rowindex].Cells[5].Value = Item_Discount;
                    decimal Total = (Convert.ToDecimal(Item_Qty) * Convert.ToDecimal(Item_Price)) - Convert.ToDecimal(Item_Discount);
                    DgvStoreQty.Rows[rowindex].Cells[6].Value = Total;
                    tot = 0;
                    DataTable min_qty = db.RunReader("select Item_Min from Items where Item_ID='" + Convert.ToDecimal(DgvStoreQty.Rows[rowindex].Cells[0].Value) + "'", "");
                    DataTable itemQty = db.RunReader("select Item_Qty  from Items where Item_ID=" + Convert.ToDecimal(DgvStoreQty.Rows[rowindex].Cells[0].Value) + "", "");
                    if (Convert.ToDecimal(itemQty.Rows[0][0]) <= Convert.ToDecimal(min_qty.Rows[0][0]))
                    {
                        DgvStoreQty.Rows[rowindex].DefaultCellStyle.BackColor = Color.Orange;
                        MessageBox.Show("هذا المنتج وصل إلي حد الطلب الرجاء شراء كمية جديدة الكمية المتاحة في المخزن  = "+ itemQty.Rows[0][0].ToString());
                        
                    }
                    for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                    {
                        tot += Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[6].Value);
                        DgvStoreQty.ClearSelection();
                        DgvStoreQty.FirstDisplayedScrollingRowIndex = DgvStoreQty.RowCount - 1;
                        DgvStoreQty.Rows[DgvStoreQty.RowCount - 1].Selected = true;
                    }
                    lblCount.Text = (DgvStoreQty.Rows.Count).ToString();
                    txtTotal.Text = Math.Round(tot, 2).ToString();
                    txtBarcode.Clear();
                    cbxItems.Focus();
                    if (DgvStoreQty.Rows.Count >= 1)
                    {
                        UpdateQty();                 
                        //decimal unitRatio =Convert.ToDecimal(db.RunReader("select * from Items_Unit where Item_ID=" + Item_ID + " and Unit_Name=N'" + Item_Unit + "'", "").Rows[0][3]);
                        //decimal salePrice = Convert.ToDecimal(Properties.Settings.Default.Item_Price);
                        //decimal buyPrice = Convert.ToDecimal(db.RunReader("select Top 1 * from Items_Qty where Item_ID=" + Properties.Settings.Default.Item_ID.ToString() + " and Qty >=1", "").Rows[0][4]);
                        //if (salePrice < (buyPrice/ unitRatio))
                        //{
                        //    MessageBox.Show("سعر البيع لهذا المنتج اقل من سعر الشراء");
                        //}
                        Properties.Settings.Default.Check = true;
                        Properties.Settings.Default.Save();
                        if (Properties.Settings.Default.Check)
                        {
                            UpdateData();

                            CheckQtyIntheStoreWithGridView();
                        }
                    }
                }
            }            
        }
        private void CheckQtyIntheStoreWithGridView() {
            decimal QtyGrid = 0;
            DataTable tblitem = new DataTable();
            tblitem.Clear();            
            try
            {
                int count = 0;
                decimal QtyInUnit = 0, qtyFinalI = 0, qtyFinalX=0;
                for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                {
                    try
                    {

                        DataTable tblQty = new DataTable();
                        tblQty.Clear();
                       
                        tblQty = db.RunReader("select * from Items_Unit where Item_ID=" + DgvStoreQty.Rows[i].Cells[0].Value + " and Unit_Name=N'" + Convert.ToString(DgvStoreQty.Rows[i].Cells[2].Value) + "'", "");
                        QtyInUnit = Convert.ToDecimal(tblQty.Rows[0][3]);
                        if (QtyInUnit >= 1)
                        {
                            qtyFinalI = Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[3].Value) / QtyInUnit;
                        }
                        else
                        {
                            qtyFinalI = Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[3].Value);
                        }
                    }
                    catch (Exception) { }

                    count = 0;
                    for (int x = i + 1; x <= DgvStoreQty.Rows.Count; x++)
                    {
                        qtyFinalX = 0;
                        try
                        {

                            DataTable tblQty = new DataTable();
                            tblQty.Clear();

                            tblQty = db.RunReader("select * from Items_Unit where Item_ID=" + DgvStoreQty.Rows[x].Cells[0].Value + " and Unit_Name=N'" + Convert.ToString(DgvStoreQty.Rows[i].Cells[x].Value) + "'", "");
                            QtyInUnit = Convert.ToDecimal(tblQty.Rows[0][3]);
                            if (QtyInUnit >= 1)
                            {
                                qtyFinalX = Convert.ToDecimal(DgvStoreQty.Rows[x].Cells[3].Value) / QtyInUnit;
                            }
                            else
                            {
                                qtyFinalX = Convert.ToDecimal(DgvStoreQty.Rows[x].Cells[3].Value);
                            }
                        }
                        catch (Exception) { }

                        try
                        {
                            if (Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[0].Value) == Convert.ToDecimal(DgvStoreQty.Rows[x].Cells[0].Value))
                            {
                                count++;
                                tblitem.Clear();
                                if (count == 1)
                                    QtyGrid += qtyFinalX + qtyFinalI;
                                else
                                    QtyGrid += qtyFinalX;
                                tblitem = db.RunReader("select Item_Qty - (" + QtyGrid + ") from Items where Item_ID=" + Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[0].Value) + "", "");
                                if (Convert.ToDecimal(tblitem.Rows[0][0]) < 0)
                                {
                                    MessageBox.Show("لا يوجد كمية كافيه فى المخزن من المنتج " + Convert.ToString(DgvStoreQty.Rows[x].Cells[1].Value),"تاكيد");
                                    flagOfQty = 0;
                                    return ;
                                }
                                else
                                {
                                    flagOfQty = 111;
                                }
                                
                            }
                        }
                        catch (Exception) { }
                    }
                    tblitem.Clear();
                    QtyGrid = 0;
                    QtyGrid = qtyFinalI;
                    tblitem = db.RunReader("select Item_Qty - (" + QtyGrid + ") from Items where Item_ID=" + Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[0].Value) + "", "");
                    //decimal existQty = Convert.ToDecimal(tblitem.Rows[0][0]);
                    if (Convert.ToDecimal(tblitem.Rows[0][0]) < 0)
                    {
                        MessageBox.Show("لا يوجد كمية كافيه فى المخزن من المنتج " + Convert.ToString(DgvStoreQty.Rows[i].Cells[1].Value),"تاكيد");
                        flagOfQty = 0;
                        return;
                    }
                    else
                    {
                        flagOfQty = 111;
                    }

                }
            }
            catch (Exception) { }
            cbxItems.Focus();

        }
        private void Frm_SalesSuperMarket_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void DgvStoreQty_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnFavItems_Click(object sender, EventArgs e)
        {
            try {
                DataTable tblFav = new DataTable();
                tblFav.Clear();
                tblFav = db.RunReader("select * from Items where Is_Fav=1", "");
                if(tblFav.Rows.Count >= 1)
                {
                    Frm_FavItems frm = new Frm_FavItems();
                    frm.ShowDialog();
                    if(Properties.Settings.Default.Check == true)
                    {
                        DataTable tbl = new DataTable(); DataTable tblUnit = new DataTable();
                        tbl.Clear(); tblUnit.Clear();
                        if (cbxItems.Items.Count >= 1)
                        {
                            tbl = db.RunReader("select * from Items where Item_ID='" + Properties.Settings.Default.ItemID + "'", "");
                            if (tbl.Rows.Count >= 1)
                            {
                                string Item_ID = tbl.Rows[0][0].ToString();
                                string Item_Name = tbl.Rows[0][1].ToString();
                                string Item_Unit = tbl.Rows[0][15].ToString();
                                string Item_Qty =Convert.ToString( Properties.Settings.Default.QTY);
                                string Item_Price = tbl.Rows[0][11].ToString();
                                string Item_Discount = "0.0";
                                DgvStoreQty.Rows.Add(1);
                                decimal tot;
                                int rowindex = DgvStoreQty.Rows.Count - 1;
                                DgvStoreQty.Rows[rowindex].Cells[0].Value = Item_ID;
                                DgvStoreQty.Rows[rowindex].Cells[1].Value = Item_Name;
                                DgvStoreQty.Rows[rowindex].Cells[2].Value = Item_Unit;
                                DgvStoreQty.Rows[rowindex].Cells[3].Value = Item_Qty;
                                tblUnit = db.RunReader("select * from Items_Unit where Item_ID=" + Item_ID + " and Unit_Name=N'" + Item_Unit + "'", "");
                                decimal price = 0;
                                try
                                {
                                    price = Convert.ToDecimal(tblUnit.Rows[0][5]) / Convert.ToDecimal(tblUnit.Rows[0][3]);
                                }
                                catch (Exception) { }
                                DgvStoreQty.Rows[rowindex].Cells[4].Value = price;
                                DgvStoreQty.Rows[rowindex].Cells[5].Value = Item_Discount;
                                decimal Total = (Convert.ToDecimal(Item_Qty) * Convert.ToDecimal(Item_Price)) - Convert.ToDecimal(Item_Discount);
                                DgvStoreQty.Rows[rowindex].Cells[6].Value = Total;
                                tot = 0;
                                for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                                {
                                    tot += Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[6].Value);

                                    DgvStoreQty.ClearSelection();
                                    DgvStoreQty.FirstDisplayedScrollingRowIndex = DgvStoreQty.RowCount - 1;
                                    DgvStoreQty.Rows[DgvStoreQty.RowCount - 1].Selected = true;


                                }
                                lblCount.Text = (DgvStoreQty.Rows.Count).ToString();
                                txtTotal.Text = Math.Round(tot, 2).ToString();
                                txtBarcode.Clear();
                                cbxItems.Focus();
                            }
                        }
                    }
                }else
                {
                    MessageBox.Show("لا يوجد منتجات مفضله حتى الان اذهب الى شاشه المنتجات اولا واختر منتجات مفضلة", "تاكبد" ,MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            } catch (Exception) { }
        }

        private void cbxCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ///// get customer past dept
            DataTable tbl = new DataTable();
            tbl.Clear();
            decimal Total = 0;
             if (rbtnCustomerAagel.Checked == true)
                tbl = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,[Price]  as المبلغ_المتبقى,Customer.[Cust_Name]  as العميل,[Date]  as تاريخ_الفاتورة ,Date_Reminder as تاريخ_الاستحقاق  ,Type as 'النوع' FROM [Customer_Money],Customer where Customer.Cust_ID=Customer_Money.Cust_ID and Customer_Money.Cust_ID=" + cbxCustomer.SelectedValue + "", "");
            //DgvSearchBuy.DataSource = tbl;
            for (int i = 0; i <= tbl.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(tbl.Rows[i][1]);
            }
            past.Text = Math.Round(Total, 2).ToString();

        }

        private void txtCustomerNakdy_TextChanged(object sender, EventArgs e)
        {

        }

        private void past_Click(object sender, EventArgs e)
        {

        }

        private void CheckDiscount(int id)
        {
            DataTable tblItem = new DataTable();
            try
            {
                decimal dis = 0;
                tblItem = db.RunReader("select Max_Discount from Items where Item_ID=" + id + "", "");
                dis = Convert.ToDecimal(tblItem.Rows[0][0]);
                decimal totDicount = 0;
                try
                {
                    totDicount = dis * Convert.ToDecimal(DgvStoreQty.CurrentRow.Cells[3].Value);
                }
                catch (Exception) { }
                //if (dis >= 1)
                //{
                //    if (Convert.ToDecimal(DgvStoreQty.CurrentRow.Cells[5].Value) > totDicount)
                //    {
                //        MessageBox.Show("اعلى نسبه خصم مسموح بها للقطعه الواحده من هذا الصنف هى  " + dis + " " + " ولاجمالى هذه القطع" + totDicount + " ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        DgvStoreQty.CurrentRow.Cells[5].Value = totDicount;
                //    }
                //}
                //else if (dis == 0)
                //{
                //    if (Convert.ToDecimal(DgvStoreQty.CurrentRow.Cells[5].Value) > 0)
                //    {
                //        MessageBox.Show("هذا الصنف غير مسموح بعمل خصم له", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        DgvStoreQty.CurrentRow.Cells[5].Value = 0;
                //    }
                //}
            }
            catch (Exception) { }
        }
        private void DgvStoreQty_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                try
                {
                    CheckDiscount(Convert.ToInt32(DgvStoreQty.CurrentRow.Cells[0].Value));
                }
                catch (Exception) { }
                int index = 0;
                if (DgvStoreQty.Rows.Count == 1)
                    index = 0;
                else if (DgvStoreQty.Rows.Count > 1)
                    index = DgvStoreQty.SelectedRows[0].Index;

                Item_ID = Convert.ToString(DgvStoreQty.Rows[index].Cells[0].Value);
                Item_qty = Convert.ToString(DgvStoreQty.Rows[index].Cells[3].Value);
                Item_Unit = Convert.ToString(DgvStoreQty.Rows[index].Cells[2].Value);
                Item_Discount = Convert.ToString(DgvStoreQty.Rows[index].Cells[5].Value);
                Item_Price = Convert.ToString(DgvStoreQty.Rows[index].Cells[4].Value);
               decimal tot =0;
               if (Properties.Settings.Default.ItemsDiscount == "Value")
               {
                   tot = (Convert.ToDecimal(Item_qty) * Convert.ToDecimal(Item_Price)) - Convert.ToDecimal(Item_Discount);
               }
               else {
                   decimal d = ((Convert.ToDecimal(Item_qty) * Convert.ToDecimal(Item_Price)) / 100) * (Convert.ToDecimal(Item_Discount));
                   tot = (Convert.ToDecimal(Item_qty) * Convert.ToDecimal(Item_Price)) - d;

               }
               decimal Sum = 0;
                   DgvStoreQty.Rows[index].Cells[6].Value = Math.Round(tot, 2);
                   for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                   {
                       Sum += Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[6].Value);
                   }
                   txtTotal.Text = Math.Round(Sum ,2).ToString();
            }
            catch (Exception) { }
            
        }

        private void cbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                decimal tot;
                if (DgvStoreQty.Rows.Count >=1)
                {
                    int index = DgvStoreQty.SelectedRows[0].Index;

                    DgvStoreQty.Rows.RemoveAt(index);
                    if (DgvStoreQty.Rows.Count <= 0) { txtTotal.Text = "0"; }
                    tot = 0;
                    for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                    {
                        tot += Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[6].Value);
                    }
                    DgvStoreQty.ClearSelection();
                    DgvStoreQty.FirstDisplayedScrollingRowIndex = DgvStoreQty.RowCount - 1;
                    DgvStoreQty.Rows[DgvStoreQty.RowCount - 1].Selected = true;
                  
                    txtTotal.Text = Math.Round(tot, 2).ToString() ;
                    if (DgvStoreQty.Rows.Count <= 0) { txtTotal.Text = "0"; }
                    lblCount.Text =Convert.ToString( DgvStoreQty.Rows.Count );
                }
            }
            catch (Exception)
            { }
            txtBarcode.Clear();
            cbxItems.Focus();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Frm_Customer frm = new Frm_Customer();
            frm.ShowDialog();
        }

        private void rbtnCustomerNakdy_CheckedChanged(object sender, EventArgs e)
        {
            cbxCustomer.Enabled = false;
            btnBrowse.Enabled = false;
            DtbReminder.Enabled = false;
        }

        private void rbtnCustomerAagel_CheckedChanged(object sender, EventArgs e)
        {
            cbxCustomer.Enabled = true;
            btnBrowse.Enabled = true;
            DtbReminder.Enabled = true;
            ///// get customer past dept
            DataTable tbl = new DataTable();
            tbl.Clear();
            decimal Total = 0;
            if (rbtnCustomerAagel.Checked == true)
                tbl = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,[Price]  as المبلغ_المتبقى,Customer.[Cust_Name]  as العميل,[Date]  as تاريخ_الفاتورة ,Date_Reminder as تاريخ_الاستحقاق  ,Type as 'النوع' FROM [Customer_Money],Customer where Customer.Cust_ID=Customer_Money.Cust_ID and Customer_Money.Cust_ID=" + cbxCustomer.SelectedValue + "", "");
            //DgvSearchBuy.DataSource = tbl;
            for (int i = 0; i <= tbl.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(tbl.Rows[i][1]);
            }
            past.Text = Math.Round(Total, 2).ToString();
        }

    }
}
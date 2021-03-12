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
    public partial class Frm_BuySuperMarket : DevExpress.XtraEditors.XtraForm
    {


        private static Frm_BuySuperMarket frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_BuySuperMarket GetMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_BuySuperMarket();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public Frm_BuySuperMarket()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }
        DB db = new DB();

        private void FillItems()
        {
            cbxItems.DataSource = db.RunReader("select * from Items", "");
            cbxItems.DisplayMember = "Item_Name";
            cbxItems.ValueMember = "Item_ID";
        }
        public void FillCustomer()
        {
            cbxSuplier.DataSource = db.RunReader("select * from Suplier Order By  Sup_ID desc", "");
            cbxSuplier.DisplayMember = "Sup_Name";
            cbxSuplier.ValueMember = "Sup_ID";
        }
        public void FillStore()
        {
            cbxStore.DataSource = db.RunReader("select * from Store Order By Store_ID desc ", "");
            cbxStore.DisplayMember = "Store_Name";
            cbxStore.ValueMember = "Store_ID";
        }
        int stock_ID;

        private void AutoNum()
        {
            DataTable tblautonum = new DataTable();

            tblautonum.Clear();
            tblautonum = db.RunReader("select max(Order_ID) from Buy", "");
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
                    cbxSuplier.SelectedIndex = 0;
                    cbxStore.SelectedIndex = 0;
                }
                catch (Exception) { }
                DtbSaleDate.Text = DateTime.Now.ToShortDateString();
                DtbTime.Text = DateTime.Now.ToShortTimeString();
                DtbReminder.Text = DateTime.Now.ToShortDateString();
                txtTotal.Text = "0";
                lblCount.Text = "0";
                DgvStoreQty.Rows.Clear();
                txtBarcode.Clear();
                cbxItems.Focus();
            }
            catch (Exception) { }
            cbxItems.Text = "اختر منتج";
        }

        private void Frm_BuySuperMarket_Load(object sender, EventArgs e)
        {
            lblUser.Text = Properties.Settings.Default.UserName;
            stock_ID = Convert.ToInt32(Properties.Settings.Default.UserStock);
         
            DtbReminder.Enabled = false;
            FillCustomer();
            FillItems();
            FillStore();
            try
            {
                AutoNum();
            }
            catch (Exception) { }
            cbxItems.Focus();
        }




        public string Item_ID, Item_qty, Item_Unit, Item_Discount, Item_Price;
        public void UpdateQty()
        {


            int index = 0;
            index = DgvStoreQty.SelectedRows[0].Index;


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
            Properties.Settings.Default.Save();



            Frm_QtyBuy frm = new Frm_QtyBuy();
            frm.ShowDialog(this);
        }


        private void UpdateData()
        {
            int index = 0;
            index = DgvStoreQty.SelectedRows[0].Index;

            DgvStoreQty.Rows[index].Cells[2].Value = Properties.Settings.Default.Item_Unit;
            DgvStoreQty.Rows[index].Cells[3].Value = Properties.Settings.Default.Item_qty;
            DgvStoreQty.Rows[index].Cells[4].Value = Properties.Settings.Default.Item_Price;
            DgvStoreQty.Rows[index].Cells[5].Value = Properties.Settings.Default.Item_Discount;

        }

        private void Frm_BuySuperMarket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtBarcode.Clear();
                cbxItems.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(null,null);
            }
            else if (e.KeyCode == Keys.F11)
            {
                if (DgvStoreQty.Rows.Count >= 1)
                {
                    UpdateQty();
                    Properties.Settings.Default.Check = true;
                    Properties.Settings.Default.Save();
                    if (Properties.Settings.Default.Check)
                    {
                        UpdateData();
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
                        if (Properties.Settings.Default.PrinterName == "لم يتم تحديد طابعة") { MessageBox.Show("من فضلك حدد طابعة من شاشة اعدادات البرنامج", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                        PrintRecit();
                        if (Properties.Settings.Default.BuyPrint == true)
            {
                for (int i = 0; i <= Properties.Settings.Default.BuyOrderNum - 1; i++ )
                {
                    Print();
                }
            } 
                    }
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {  }
            else if (e.KeyCode == Keys.Delete)
            { btnDelete_Click(null,null); }
        }

        //*******************************//
        private void Print()
        {
            try
            {
                try {
                    DataTable tblCheck = new DataTable();
                    tblCheck.Clear();
                    tblCheck = db.RunReader("select * from OrderPrintData", "");
                    if (tblCheck.Rows.Count <= 0) {
                        MessageBox.Show("لكى تتم عملية الطباعة بنجاح من فضلك اذهب الى قائمه اعدادت وادخل بيانات الفاتورة لكى تتم العملية","تاكيد",MessageBoxButtons.OK ,MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (Exception) { }
                decimal num = Convert.ToDecimal(txtOrderID.Text) - 1;
                DataTable tblRpt = new DataTable();
                tblRpt.Clear();
                int x = Convert.ToInt32(txtOrderID.Text) - 1;

                tblRpt = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Items.Item_Name as اسم_الصنف ,[Qty]  as الكمية,[Price]  as السعر,[Date]  as التاريخ,[Qty] * [Price] - Discount as الاجمالى,Unit as 'الوحدة',(Total) as  الاجمالى_العام,Suplier.Sup_Name as المورد,Discount as الخصم,UserName as 'اسم المستخدم',Madfo3 as 'المدفوع' ,[Buy_Detalis].Tax_Value   as 'الضرائب' FROM [Buy_Detalis],Items,Suplier  where Items.Item_ID=Buy_Detalis.Item_ID and Suplier.Sup_ID=Buy_Detalis.Sup_ID and Buy_Detalis.Order_ID=" + num + "", "");

                Frm_Printing frm = new Frm_Printing();


                if (Properties.Settings.Default.PrinterA4Buy == false)
                {
                    RptPrintOrderBuy rpt = new RptPrintOrderBuy();

                    frm.crystalReportViewer1.RefreshReport();
                    rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");
                    rpt.SetDataSource(tblRpt);
                    rpt.SetParameterValue("ID", num);

                    frm.crystalReportViewer1.ReportSource = rpt;
                    try
                    {
                        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                        rpt.PrintOptions.PrinterDuplex = PrinterDuplex.Vertical;
                        rpt.PrintToPrinter(1, true, 0, 0);
                    }
                    catch (Exception) { }
                }

                else if (Properties.Settings.Default.PrinterA4Buy == true)
                {
                    RptPrintOrderBuyA4 rpt = new RptPrintOrderBuyA4();

                    frm.crystalReportViewer1.RefreshReport();
                    rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");
                    rpt.SetDataSource(tblRpt);
                    rpt.SetParameterValue("ID", num);
                    rpt.SetParameterValue("@sup_id", Sup_ID);
                    frm.crystalReportViewer1.ReportSource = rpt;
                    try
                    {
                        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                        rpt.PrintToPrinter(1, true, 0, 0);
                    }
                    catch (Exception) { }
                }

            }
            catch (Exception) { }
        }
        //*******************************//



        public decimal OrderID;
        public decimal OrderTotal, OrderMadfo3, OrderBaky;
        public void FormPayOrder()
        {
            OrderID = Convert.ToDecimal(txtOrderID.Text);
            OrderTotal = Convert.ToDecimal(txtTotal.Text);
            OrderMadfo3 = 0; OrderBaky = 0;
            Properties.Settings.Default.OrderID = OrderID;
            Properties.Settings.Default.OrderTotal = OrderTotal;
            Properties.Settings.Default.OrderMadfo3 = OrderMadfo3;
            Properties.Settings.Default.OrderBaky = OrderBaky;
            Properties.Settings.Default.Save();
            PayBuys frm = new PayBuys();
            frm.ShowDialog(this);
        }


        string User;
        int Sup_ID;
        string Sup_Name;
        private void PrintRecit()
        {
            User = Properties.Settings.Default.UserName;
            string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
            string dReminder = DtbReminder.Value.ToString("dd/MM/yyyy");
                //take customer data if exiet or not
                Sup_ID = 0; Sup_Name = "مورد"; 
            
                if (cbxSuplier.Items.Count >= 1)
                {
                    Sup_ID = Convert.ToInt32(cbxSuplier.SelectedValue);
                    Sup_Name = cbxSuplier.Text;
                }
                else { MessageBox.Show("من فضلك اختر المورد اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            
            DataTable tblUser = new DataTable();
            tblUser = db.RunReader("select * from Stock_Data", "");
            if (tblUser.Rows.Count <= 0)
            { MessageBox.Show("من فضلك تاكد من اضافة بيانات الخزنة اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            //*****************************
            DataTable tblItems = new DataTable();
            tblItems.Clear();
            DataTable tblCheck = new DataTable();
            tblCheck.Clear();
            tblCheck = db.RunReader("select * from Stock where Stock_ID=" + stock_ID + "", "");

            if (cbxSuplier.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك ادخل اسم المورد اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal Money = 0;
            decimal total = 0;
            try
            {
                total = Convert.ToDecimal(Properties.Settings.Default.OrderMadfo3);
                Money = Convert.ToDecimal(tblCheck.Rows[0][0]);

            }
            catch (Exception)
            {
                db.RunNunQuary("insert into Stock Values(0,1)", "");
            }
                if (Money - total < 0)
                {
                    MessageBox.Show("لا يوجد رصيد كافى فى الخزنه لاتمام عملية الشراء !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable Itemcheck = new DataTable();
                Itemcheck.Clear();
            decimal taxValue = 0, priceAfterTax = 0, taxCount = 0;
            db.RunNunQuary("insert into Buy Values (" + txtOrderID.Text + " , N'" + d + "' ," + Sup_ID + " ," + cbxStore.SelectedValue + ")", "");
            for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
            {
                tblItems = db.RunReader("select * from Items where Item_ID=" + DgvStoreQty.Rows[i].Cells[0].Value + "", "");
                taxValue = ((Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[4].Value) / 100) * Convert.ToDecimal(tblItems.Rows[0][10])) * Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[3].Value) ;
                priceAfterTax =  Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[4].Value) ;
                //to count Order Tax value
                taxCount += (taxValue) * Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[3].Value);
                //*******************************
                //real qty
                decimal QtyInUnit = 0, qtyFinal = 0;
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
                    qtyFinal = Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[3].Value) / QtyInUnit;
                }
                //*******************************
                db.RunNunQuary("insert into Buy_Detalis Values (" + txtOrderID.Text + " ," + DgvStoreQty.Rows[i].Cells[0].Value + "," + Sup_ID + " ," + DgvStoreQty.Rows[i].Cells[3].Value + " ," + DgvStoreQty.Rows[i].Cells[4].Value + ",N'" + d + "'," + txtTotal.Text + ", " + DgvStoreQty.Rows[i].Cells[5].Value + "  ,N'" + DgvStoreQty.Rows[i].Cells[2].Value + "', N'" + User + "', " + taxValue + "," + DgvStoreQty.Rows[i].Cells[4].Value + "," + Properties.Settings.Default.OrderMadfo3 + ",'" + DtbTime.Text + "' )", "");
                db.RunNunQuary("update Items set Item_Qty =Item_Qty+ " + qtyFinal + " where Item_ID=" + DgvStoreQty.Rows[i].Cells[0].Value + "", "");
                Itemcheck = db.RunReader("select * from Items_Qty where Item_ID=" + DgvStoreQty.Rows[i].Cells[0].Value + " and Store_ID=" + cbxStore.SelectedValue + " and Store_Name=N'" + cbxStore.Text + "' and Price_Buy=" + DgvStoreQty.Rows[i].Cells[4].Value + "", "");
                if (Itemcheck.Rows.Count >= 1) {
                    db.RunNunQuary("update Items_Qty set Qty=Qty + " + qtyFinal + " where  Item_ID=" + DgvStoreQty.Rows[i].Cells[0].Value + " and Store_ID=" + cbxStore.SelectedValue + " and Store_Name=N'" + cbxStore.Text + "' and Price_Buy=" + DgvStoreQty.Rows[i].Cells[4].Value + "", "");
                } else {
                    decimal priceSale = 0;
                    try {
                        priceSale = Convert.ToDecimal(db.RunReader("select Price_Tax from Items where Item_ID=" + DgvStoreQty.Rows[i].Cells[0].Value + "", "").Rows[0][0]);
                    }
                    catch (Exception) { }
                    db.RunNunQuary("insert into Items_Qty Values (" + DgvStoreQty.Rows[i].Cells[0].Value + " ," + cbxStore.SelectedValue + " ,N'" + cbxStore.Text + "' ," + qtyFinal + " ," + DgvStoreQty.Rows[i].Cells[4].Value + " ," + priceSale + ",'') ", "");
                }
            }

            //check if customer pay cash or Aagel
            decimal baky = 0;
            if (rbtnAagel.Checked == true)
            {
                baky = Properties.Settings.Default.OrderBaky;
                db.RunNunQuary("insert into Suplier_Money Values (" + txtOrderID.Text + "," + baky + "," + cbxSuplier.SelectedValue + ",'" + d + "' ,'" + dReminder + "')", "");
            }
            if (Properties.Settings.Default.OrderMadfo3 >= 1)
            {
                db.RunNunQuary("insert into Suplier_Report Values(" + txtOrderID.Text + " ,N'" + cbxSuplier.Text + "'," + Properties.Settings.Default.OrderMadfo3 + ",N'" + d + "')", "");
            }
                //insert the money into the stock 
                db.RunNunQuary("update Stock set Money=Money - " + Properties.Settings.Default.OrderMadfo3 + " where Stock_ID=" + Properties.Settings.Default.UserStock + "", "");
                db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type ,Stock_ID) Values(" + Properties.Settings.Default.OrderMadfo3 + " ,'" + d + "' ,'" + cbxSuplier.Text + "','عملية شراء'," + Properties.Settings.Default.UserStock + ")", "");
            
            //insert Order in Taxes
            decimal totalWithoutTax = (Properties.Settings.Default.OrderTotal) - taxCount;
            db.RunNunQuary("insert into Taxes_Report (Order_Type,Tax_Type,Date,Sup_Name,Cust_Name,Total_Price,Tax_Value,Total_WithTax ,Order_Num) Values ('فاتورة شراء','قيمة مضافة','" + d + "' ,N'" + cbxSuplier.Text + "' ,'لا يوجد' ," + totalWithoutTax + " ," + taxCount + " ," + txtTotal.Text + "," + txtOrderID.Text + ")", "");

            //*************
            AutoNum();
            //*************
        }


        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataTable tbl = new DataTable();
            DataTable tblQty = new DataTable();
            tbl.Clear(); tblQty.Clear();
            if (e.KeyChar == 13)
            {
                if (txtBarcode.Text == "") { return; }
                tbl = db.RunReader("select * from Items where [Barcode]='" + txtBarcode.Text + "'", "");
                if (tbl.Rows.Count >= 1)
                {
                    int num = 0;
                    string Item_ID = tbl.Rows[0][0].ToString();
                    string Item_Name = tbl.Rows[0][1].ToString();
                    string Item_Unit = tbl.Rows[0][17].ToString();
                    string Item_Qty = "1";
                    try
                    {
                        num = Convert.ToInt32(db.RunReader("select count(Item_ID) from Items_Qty where Item_ID=" + Item_ID + " ", "").Rows[0][0]);
                    }
                    catch (Exception) { }

                    tblQty = db.RunReader("select * from Items_Qty where Item_ID=" + Item_ID + " ", "");
                    string Item_Price = "0";
                    try {
                     Item_Price = tblQty.Rows[num - 1][4].ToString();
                    }
                    catch (Exception) { }
                    string Item_Discount = "0.0";
                    DgvStoreQty.Rows.Add(1);
                    decimal tot;
                    int rowindex = DgvStoreQty.Rows.Count - 1;
                    DgvStoreQty.Rows[rowindex].Cells[0].Value = Item_ID;
                    DgvStoreQty.Rows[rowindex].Cells[1].Value = Item_Name;
                    DgvStoreQty.Rows[rowindex].Cells[2].Value = Item_Unit;
                    DgvStoreQty.Rows[rowindex].Cells[3].Value = Item_Qty;

                    decimal QtyInUnit = 1, unitPrice = 0;
                    tblQty.Clear();
                    tblQty = db.RunReader("select * from Items_Unit where Item_ID=" + DgvStoreQty.CurrentRow.Cells[0].Value + " and Unit_Name=N'" + Convert.ToString(DgvStoreQty.CurrentRow.Cells[2].Value) + "'", "");
                    try
                    {
                        QtyInUnit = Convert.ToDecimal(tblQty.Rows[0][3]);
                    }
                    catch (Exception) { }
                    unitPrice = Convert.ToDecimal(Item_Price) / QtyInUnit;

                    DgvStoreQty.Rows[rowindex].Cells[4].Value = unitPrice;
                    DgvStoreQty.Rows[rowindex].Cells[5].Value = Item_Discount;
                    decimal Total = (Convert.ToDecimal(Item_Qty) * Convert.ToDecimal(unitPrice)) - Convert.ToDecimal(Item_Discount);
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

        private void DgvStoreQty_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
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
                decimal tot = 0;
                if (Properties.Settings.Default.ItemsDiscount == "Value")
                {
                    tot = (Convert.ToDecimal(Item_qty) * Convert.ToDecimal(Item_Price)) - Convert.ToDecimal(Item_Discount);
                }
                else
                {
                    decimal d = ((Convert.ToDecimal(Item_qty) * Convert.ToDecimal(Item_Price)) / 100) * (Convert.ToDecimal(Item_Discount));
                    tot = (Convert.ToDecimal(Item_qty) * Convert.ToDecimal(Item_Price)) - d;

                }
                decimal Sum = 0;
                DgvStoreQty.Rows[index].Cells[6].Value = Math.Round(tot, 2);
                for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                {
                    Sum += Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[6].Value);
                }
                txtTotal.Text = Math.Round(Sum, 2).ToString();
            }
            catch (Exception) { }
     
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            DataTable tblQty = new DataTable();
            tbl.Clear(); tblQty.Clear();
            if (cbxItems.Text == "اختر منتج") {
                MessageBox.Show("من فضلك اختر منتج","تاكيد",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;

            }
            if (cbxItems.Items.Count >=1)
            {
                
                tbl = db.RunReader("select * from Items where [Item_ID]="+cbxItems.SelectedValue+"", "");
                if (tbl.Rows.Count >= 1)
                {
                    int num = 0;
                    string Item_ID = tbl.Rows[0][0].ToString();
                    string Item_Name = tbl.Rows[0][1].ToString();
                    string Item_Unit = tbl.Rows[0][17].ToString();
                    string Item_Qty = "1";
                    try
                    {
                        num = Convert.ToInt32(db.RunReader("select count(Item_ID) from Items_Qty where Item_ID=" + Item_ID + " ", "").Rows[0][0]);
                    }
                    catch (Exception) { }

                    tblQty = db.RunReader("select * from Items_Qty where Item_ID=" + Item_ID + " ", "");
                    string Item_Price = "0"; try
                    {
                     Item_Price = tblQty.Rows[num - 1][4].ToString();
                      }
                    catch (Exception) { }
                    string Item_Discount = "0.0";
                    DgvStoreQty.Rows.Add(1);
                    decimal tot;
                    int rowindex = DgvStoreQty.Rows.Count - 1;
                    DgvStoreQty.Rows[rowindex].Cells[0].Value = Item_ID;
                    DgvStoreQty.Rows[rowindex].Cells[1].Value = Item_Name;
                    DgvStoreQty.Rows[rowindex].Cells[2].Value = Item_Unit;
                    DgvStoreQty.Rows[rowindex].Cells[3].Value = Item_Qty;

                    decimal QtyInUnit = 0, unitPrice = 0;
                    tblQty.Clear();
                    tblQty = db.RunReader("select * from Items_Unit where Item_ID=" + DgvStoreQty.CurrentRow.Cells[0].Value + " and Unit_Name=N'" + Convert.ToString(DgvStoreQty.CurrentRow.Cells[2].Value) + "'", "");
                    try
                    {
                        QtyInUnit = Convert.ToDecimal(tblQty.Rows[0][3]);
                    }
                    catch (Exception) { }
                    unitPrice =Convert.ToDecimal( Item_Price ) / QtyInUnit;

                    DgvStoreQty.Rows[rowindex].Cells[4].Value = unitPrice;
                    DgvStoreQty.Rows[rowindex].Cells[5].Value = Item_Discount;
                    decimal Total = (Convert.ToDecimal(Item_Qty) * Convert.ToDecimal(unitPrice)) - Convert.ToDecimal(Item_Discount);
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
            txtBarcode.Clear();
            //cbxItems.Clear();
            cbxItems.Focus();
            

            if (DgvStoreQty.Rows.Count >= 1)
            {
                UpdateQty();
                Properties.Settings.Default.Check = true;
                Properties.Settings.Default.Save();
                if (Properties.Settings.Default.Check)
                {
                    UpdateData();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                decimal tot;
                if (DgvStoreQty.Rows.Count >= 1)
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

                    txtTotal.Text = Math.Round(tot, 2).ToString();
                    if (DgvStoreQty.Rows.Count <= 0) { txtTotal.Text = "0"; }
                    lblCount.Text = Convert.ToString(DgvStoreQty.Rows.Count);
                }
            }
            catch (Exception)
            { }
            txtBarcode.Clear();
            cbxItems.Focus();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Frm_Suplier frm = new Frm_Suplier();
            frm.ShowDialog();
        }

        private void btnBrowseStore_Click(object sender, EventArgs e)
        {
            Frm_Store frm = new Frm_Store();
            frm.ShowDialog();
        }

        private void cbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbtnAagel_CheckedChanged(object sender, EventArgs e)
        {
            DtbReminder.Enabled = true;
        }
    }
}
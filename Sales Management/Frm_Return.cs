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
    public partial class Frm_Return : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Return()
        {
            InitializeComponent();

        }
        DB db = new DB();
        Double Sum = 0;
        DataTable tbl = new DataTable();
        int stock_ID;
        private void Frm_Return_Load(object sender, EventArgs e)
        {
            try
            {
                FillStore();
                DtbSaleDate.Text = DateTime.Now.ToShortDateString();
                stock_ID = Convert.ToInt32(Properties.Settings.Default.UserStock);
                label3.Text = "اسم العميل :";
                label4.Text = "اسم العميل :";
                lblStore1.Text = "الى المخزن :";
                lblStore2.Text = "الى المخزن :";
            }
            catch (Exception) { }
        }

        public void textParcode_KeyPress(object sender, KeyPressEventArgs e)
        {
              //int invoice_id = Convert.ToInt32(textParcode.Text);
            decimal SumWithTax = 0; decimal price = 0;
            decimal SumTax = 0; decimal SumTotal = 0;
            DataTable tblsearch = new DataTable();
            DataTable tblAll = new DataTable();
            tblsearch.Clear();
            tblAll.Clear();
            
            if (e.KeyChar == 13)
            {
                if (textParcode.Text != "")
                {
                    string d = DtbSaleDate.Value.ToString("yyyy-MM-dd");
                    if (rbtnCustomer.Checked == true)
                    {
                        tblsearch = db.RunReader("SELECT Sale_Detalis.Order_ID as 'رقم الفاتورة', Items.Item_Name as 'الصنف',[Qty] as 'الكمية',Unit as 'الوحدة',[Price] as 'السعر شامل الضريبة',[Discount] as 'الخصم',[Sale_Detalis].[Tax_Value] * [Qty] as 'الضريبة المضافة',([Sale_Detalis].[Price] * [Qty] ) - (Discount) as 'الاجمالى بعد الضريبة',[Date] as 'تاريخ العملية' ,UserName as 'اسم المستخدم',Sale_Detalis.Item_ID as 'رقم الصنف'  FROM  [Sale_Detalis], Items where [Sale_Detalis].Item_ID = Items.Item_ID and Sale_Detalis.Order_ID=" + textParcode.Text + "", "");
                        tblAll = db.RunReader("select * from sale_Detalis where Order_ID=" + textParcode.Text + " ", "");
                        if (tblAll.Rows.Count >= 1)
                        {
                            txtReturnerName.Text = tblAll.Rows[0][3].ToString();
                            txtReturnerName2.Text = tblAll.Rows[0][3].ToString();
                        }
                    }
                    else if (rbtnSuplier.Checked == true)
                    {
                        tblsearch = db.RunReader("SELECT [Order_ID] as 'رقم الفاتورة', Items.[Item_Name] as 'الصنف',[Qty] as 'الكمية',Unit as 'الوحدة',[Price]  as 'السعر',[Discount] as 'الخصم',([Buy_Detalis].[Tax_Value] ) as 'الضريبة المضافة',[Buy_Detalis].[Price] * Qty as 'الاجمالى بعد الضريبة المضافة',[Date] as 'تاريخ العميلة',[UserName] as 'اسم المستخدم',Buy_Detalis.Item_ID as 'رقم الصنف' FROM [Buy_Detalis], Items where [Buy_Detalis].Item_ID = Items.Item_ID and Buy_Detalis.Order_ID=" + textParcode.Text + "", "");
                        tblAll = db.RunReader("select * from Buy_Detalis where Order_ID=" + textParcode.Text + " ", "");
                    }

                    if (tblsearch.Rows.Count >= 1)
                    {

                        DgvSearchBuy.DataSource = tblsearch;

                        for (int i = 0; i <= DgvSearchBuy.Rows.Count - 1; i++)
                        {
                            SumWithTax += Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[7].Value);
                            SumTax += Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[6].Value);
                            SumTotal += Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[7].Value) - Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[6].Value);
                        }
                        txtTotalWithtax.Text = (Math.Round(SumWithTax, 2)).ToString();
                        txtTotalTax.Text = (Math.Round(SumTax, 2)).ToString();
                        txtTotal.Text = (Math.Round(SumTotal, 2)).ToString();
                        decimal reminder = 0;
                        try
                        {
                            if (rbtnCustomer.Checked == true)
                            {
                                DataTable invoicePaied = db.RunReader("select sum(Price) from Customer_Report where Order_ID = " + textParcode.Text + " ", "");
                                NudMadfo3.Value = Convert.ToDecimal(invoicePaied.Rows[0][0]);
                                //NudMadfo3.Value = Convert.ToDecimal(tblAll.Rows[0][10]);
                                reminder = SumWithTax - Convert.ToDecimal(invoicePaied.Rows[0][0]);
                            }
                            else if (rbtnSuplier.Checked == true)
                            {
                                DataTable invoicePaied = db.RunReader("select sum(Price) from Suplier_Report where Order_ID = " + textParcode.Text + " ", "");
                                NudMadfo3.Value = Convert.ToDecimal(invoicePaied.Rows[0][0]);
                                //NudMadfo3.Value = Convert.ToDecimal(tblAll.Rows[0][12]);
                                reminder = SumWithTax - Convert.ToDecimal(invoicePaied.Rows[0][0]);
                            }
                        }
                        catch (Exception) { }
                        txtReport.Text = Math.Round(reminder, 2).ToString();
                    }
                    else {
                        MessageBox.Show("رقم الفاتورة الذى ادخلته غير صحيح !", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tblsearch.Clear();
                        DgvSearchBuy.DataSource = tblsearch;
                        NudMadfo3.Value = 0;
                        txtReport.Clear(); txtTotal.Clear(); txtTotalTax.Clear(); txtTotalWithtax.Clear();
                    }
                }
            }
        }


        private void CustSale()
        {
            if (DgvSearchBuy.Rows.Count >= 1)
            {
                if (txtReturnerName.Text == "")
                {
                    if (rbtnCustomer.Checked == true)
                        MessageBox.Show("من فضلك ادخل اسم العميل ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("من فضلك ادخل اسم المورد ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataTable tblCheck = new DataTable();
                tblCheck.Clear();
                tblCheck = db.RunReader("select * from Stock where Stock_ID=" + stock_ID + "", "");
                string User = Properties.Settings.Default.UserName;
                string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
                decimal Money = 0;
                decimal total = 0;
                try
                {
                    total = Convert.ToDecimal(txtTotalWithtax.Text);
                    Money = Convert.ToDecimal(tblCheck.Rows[0][0]);
                }
                catch (Exception)
                {
                    db.RunNunQuary("insert into Stock Values(0,1)", "");
                }

                if (Money - total < 0)
                {
                    if (rbtnCustomer.Checked == true)
                    {
                        MessageBox.Show("لا يوجد رصيد كافى فى الخزنه لاتمام عملية الاسترجاع !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                if (rbtnCustomer.Checked == true)
                    db.RunNunQuary("insert into Return_ (Date ,Type) values('" + d + "','مرتجات مبيعات')", "");
                else
                    db.RunNunQuary("insert into Return_ (Date ,Type) values('" + d + "','مرتجعات مشتريات')", "");
                int ID = 0;
                try
                {
                    ID = Convert.ToInt32(db.RunReader("SELECT TOP 1 * FROM Return_ ORDER BY Order_ID DESC", "").Rows[0][0]);
                }
                catch (Exception) { }
                for (int i = 0; i < DgvSearchBuy.Rows.Count; i++)
                {
                    decimal qty = Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[2].Value);

                   
                        if (rbtnCustomer.Checked == true)
                        {
                            db.RunNunQuary("insert Return_Detalis values (" + ID + " ,N'" + DgvSearchBuy.Rows[i].Cells[1].Value + "' ," + qty + " ," + Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[4].Value) + " ," + Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[6].Value) + "," + Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[4].Value) + " ,'" + Properties.Settings.Default.UserName + "','" + d + "' , 'مرتجعات بيع' ," + DgvSearchBuy.Rows[i].Cells[0].Value + ",N'" + txtReturnerName.Text + "','" + DgvSearchBuy.CurrentRow.Cells[3].Value + "')", "");
                        }
                        else
                        {
                            db.RunNunQuary("insert Return_Detalis values (" + ID + " ,N'" + DgvSearchBuy.Rows[i].Cells[1].Value + "' ," + qty + " ," + Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[4].Value) + " ," + Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[6].Value) + "," + Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[4].Value) + " ,'" + Properties.Settings.Default.UserName + "','" + d + "' , 'مرتجعات مشتريات' ," + DgvSearchBuy.Rows[i].Cells[0].Value + ",N'" + txtReturnerName.Text + "','" + DgvSearchBuy.CurrentRow.Cells[3].Value+ "')", "");
                        }

                    
                    try
                    {
                        decimal QtyInUnit = 1, qtyFinal = 1;
                        DataTable tblQty = new DataTable(); DataTable tblStore = new DataTable();
                        tblQty.Clear(); tblStore.Clear();
                        tblQty = db.RunReader("select * from Items_Unit where Item_ID=" + DgvSearchBuy.Rows[i].Cells[10].Value + " and Unit_Name=N'" + Convert.ToString(DgvSearchBuy.Rows[i].Cells[3].Value) + "'", "");
                        try
                        {
                            QtyInUnit = Convert.ToDecimal(tblQty.Rows[0][3]);
                        }
                        catch (Exception) { }
                        if (QtyInUnit >= 1)
                        {
                            qtyFinal = Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[2].Value) / QtyInUnit;
                        }

                        db.RunNunQuary("update Items set Item_Qty =Item_Qty +(" + qtyFinal + ") where Item_ID=" + DgvSearchBuy.Rows[i].Cells[10].Value + "", "");
                        tblStore = db.RunReader("select * from Items_Qty where Item_ID=" + DgvSearchBuy.Rows[i].Cells[10].Value + " and  Store_ID  =" + cbxStore.SelectedValue + " and Store_Name=N'" + cbxStore.Text + "' and Price_Buy=" + DgvSearchBuy.Rows[i].Cells[4].Value + " ", "");
                        if (tblStore.Rows.Count >= 1)
                        {
                            db.RunNunQuary("update Items_Qty set Qty =Qty +(" + qtyFinal + ") where Item_ID=" + DgvSearchBuy.Rows[i].Cells[10].Value + " and  Store_ID=" + cbxStore.SelectedValue + " and Store_Name=N'" + cbxStore.Text + "' and Price_Buy=" + DgvSearchBuy.Rows[i].Cells[4].Value + "", "");
                        }
                        else
                        {
                            decimal q = Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[4].Value) * QtyInUnit;
                            db.RunNunQuary("insert into Items_Qty Values (" + DgvSearchBuy.Rows[i].Cells[10].Value + " , " + cbxStore.SelectedValue + " , N'" + cbxStore.Text + "' ," + qtyFinal + " , " + DgvSearchBuy.Rows[i].Cells[4].Value + "," + q + " ,'' )", "");
                        }
                    }
                    catch (Exception) { }
                }
                returnMoney(Convert.ToInt32(textParcode.Text), NudMadfo3.Value, "all"); // ارجاع فاتورة مبيعات كاملة
                //db.RunNunQuary("update Stock set Money=Money - " + txtTotalWithtax.Text + " where Stock_ID=" + stock_ID + "", "");
                //db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type,Stock_ID) Values(" + txtTotalWithtax.Text + " ,'" + d + "' ,'مرتجعات مبيعات' ,'عملية مرتجعات مبيعات'," + stock_ID + ")", "");
                db.RunNunQuary("delete from Sale where Order_ID=" + textParcode.Text + "", "");
                db.RunNunQuary("delete from Sale_Detalis where Order_ID=" + textParcode.Text + "", "");
                db.RunNunQuary("delete from Sale_Detalis_Rbh7 where Order_ID=" + textParcode.Text + "", "");
                db.RunNunQuary("insert into Taxes_Report (Order_Type,Tax_Type,Date,Cust_Name,Total_Price,Tax_Value,Total_WithTax,Order_Num) Values ('مرتجعات بيع','ضريبة قيمه مضافة','" + d + "' ,N'" + txtReturnerName.Text+ "'  ," + txtTotal.Text + " ," + txtTotalTax.Text + " ," + txtTotalWithtax.Text + " ," +ID+ ")", "");
                MessageBox.Show("تمت ارجاع الفاتورة بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SupBuy()
        {
            if (DgvSearchBuy.Rows.Count >= 1)
            {

                if (txtReturnerName.Text == "")
                {
                    if (rbtnCustomer.Checked == true)
                        MessageBox.Show("من فضلك ادخل اسم العميل ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("من فضلك ادخل اسم المورد ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string User = Properties.Settings.Default.UserName;
                string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");           
                db.RunNunQuary("insert into Return_ (Date ,Type) values('" + d + "','مرتجعات مشتريات')", "");
                int ID = 0;
                try
                {
                    ID = Convert.ToInt32(db.RunReader("SELECT TOP 1 * FROM Return_ ORDER BY Order_ID DESC", "").Rows[0][0]);
                }
                catch (Exception) { }
                for (int i = 0; i < DgvSearchBuy.Rows.Count; i++)
                {
                    decimal qty = Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[2].Value);
                    decimal QtyInUnit = 1, qtyFinal = 1;
                    DataTable tblQty = new DataTable(); DataTable tblStore = new DataTable();
                    tblQty.Clear(); tblStore.Clear();
                    tblQty = db.RunReader("select * from Items_Unit where Item_ID=" + DgvSearchBuy.Rows[i].Cells[10].Value + " and Unit_Name=N'" + Convert.ToString(DgvSearchBuy.Rows[i].Cells[3].Value) + "'", "");
                    try
                    {
                        QtyInUnit = Convert.ToDecimal(tblQty.Rows[0][3]);
                    }
                    catch (Exception) { }
                    if (QtyInUnit >= 1)
                    {
                        qtyFinal = Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[2].Value) / QtyInUnit;
                    }

                    tblStore = db.RunReader("select Qty - " + qtyFinal + " from Items_Qty where Item_ID =" + DgvSearchBuy.Rows[i].Cells[10].Value + " and  Store_ID=" + cbxStore.SelectedValue + " and Store_Name=N'" + cbxStore.Text + "' ", "");

                    if (Convert.ToDecimal(tblStore.Rows[0][0]) >= 0)
                    {
                        db.RunNunQuary("update Items_Qty set Qty =Qty -(" + qtyFinal + ") where Item_ID =" + DgvSearchBuy.Rows[i].Cells[10].Value + " and  Store_ID=" + cbxStore.SelectedValue + " and Store_Name=N'" + cbxStore.Text + "' and Price_Buy=" + DgvSearchBuy.Rows[i].Cells[4].Value + " ", "");
                    }
                    else
                    {
                        MessageBox.Show("الكمية التى تريد ارجاعها غير موجودة فى المخزن", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    try
                    {
                        if (rbtnCustomer.Checked == true)
                        {
                            db.RunNunQuary("insert Return_Detalis values (" + ID + " ,N'" + DgvSearchBuy.Rows[i].Cells[1].Value + "' ," + qty + " ," + Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[4].Value) + " ," + Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[6].Value) + "," + Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[4].Value) + " ,'" + Properties.Settings.Default.UserName + "','" + d + "' , 'مرتجعات بيع' ," + DgvSearchBuy.Rows[i].Cells[0].Value + ",N'" + txtReturnerName.Text + "','" +DgvSearchBuy.CurrentRow.Cells[3].Value + "')", "");
                        }
                        else
                        {
                            db.RunNunQuary("insert Return_Detalis values (" + ID + " ,N'" + DgvSearchBuy.Rows[i].Cells[1].Value + "' ," + qty + " ," + Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[4].Value) + " ," + Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[6].Value) + "," + Convert.ToDecimal(DgvSearchBuy.Rows[i].Cells[4].Value) + " ,'" + Properties.Settings.Default.UserName + "','" + d + "' , 'مرتجعات مشتريات' ," + DgvSearchBuy.Rows[i].Cells[0].Value + ",N'" + txtReturnerName.Text + "','" + DgvSearchBuy.CurrentRow.Cells[3].Value + "')", "");
                        }
                    }
                    catch (Exception) { }
                    try
                    {
                        db.RunNunQuary("update Items set Item_Qty =Item_Qty - (" + qtyFinal + ") where Item_ID=" + DgvSearchBuy.Rows[i].Cells[10].Value + "", "");                            
                    }
                    catch (Exception) { }
                }
                //db.RunNunQuary("update Stock set Money=Money + " + txtTotalWithtax.Text + " where Stock_ID=" + stock_ID + "", "");
                //db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type,Stock_ID) Values(" + txtTotalWithtax.Text + " ,'" + d + "' ,'مرتجعات مشتريات' ,'عملية مرتجعات مشتريات'," + stock_ID + ")", "");
                returnSupMoney(Convert.ToInt32(textParcode.Text), NudMadfo3.Value, "all"); // ارجاع فاتورة مشتريات كاملة
                db.RunNunQuary("delete from Buy where Order_ID=" + textParcode.Text + "", "");
                db.RunNunQuary("delete from Buy_Detalis where Order_ID=" + textParcode.Text + "", "");
                db.RunNunQuary("insert into Taxes_Report (Order_Type,Tax_Type,Date,Sup_Name,Total_Price,Tax_Value,Total_WithTax,Order_Num) Values ('مرتجعات مشتريات','ضريبة قيمه مضافة','" + d + "' ,N'" + txtReturnerName2.Text + "' ," + txtTotal.Text + " ," + txtTotalTax.Text + " ," + txtTotalWithtax.Text + " ," + ID + ")", "");
                MessageBox.Show("تمت ارجاع الفاتورة بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnReturnAll_Click(object sender, EventArgs e)
        {
            db.RunNunQuary("delete from Items_Qty where Qty <= 0", "");
            if (rbtnCustomer.Checked == true)
            { CustSale(); }

            else { SupBuy(); }

                tbl.Clear();
                DgvSearchBuy.DataSource = tbl;
                NudMadfo3.Value = 0;
                txtReport.Clear(); txtTotal.Clear(); txtTotalTax.Clear(); txtTotalWithtax.Clear();
                
            
        }

        private void rbtnCustomer_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "اسم العميل :";
            label4.Text = "اسم العميل :";
            lblStore1.Text = "الى المخزن :";
            lblStore2.Text = "الى المخزن :";
        }
        public void FillStore()
        {
            cbxStore.DataSource = db.RunReader("select * from Store Order By Store_ID desc ", "");
            cbxStore.DisplayMember = "Store_Name";
            cbxStore.ValueMember = "Store_ID";
            cbxStore2.DataSource = db.RunReader("select * from Store Order By Store_ID desc ", "");
            cbxStore2.DisplayMember = "Store_Name";
            cbxStore2.ValueMember = "Store_ID";
        }
        private void rbtnSuplier_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "اسم المورد :";
            label4.Text = "اسم المورد :";
            lblStore1.Text = "من المخزن :";
            lblStore2.Text = "من المخزن :";
        }
        private void CustSaleReturnPart()
        {
            if (DgvSearchBuy.Rows.Count >= 1)
            {

                if (txtReturnerName2.Text == "")
                {
                    if (rbtnCustomer.Checked == true)
                        MessageBox.Show("من فضلك ادخل اسم العميل ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("من فضلك ادخل اسم المورد ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataTable tblCheck = new DataTable();
                tblCheck.Clear();
                tblCheck = db.RunReader("select * from Stock where Stock_ID=" + stock_ID + "", ""); // رصيد الخزنة
                string User = Properties.Settings.Default.UserName;
                string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
                decimal Money = 0;
                decimal total = 0;
                try
                {
                    total = Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[7].Value);
                    Money = Convert.ToDecimal(tblCheck.Rows[0][0]);
                }
                catch (Exception)
                {
                    db.RunNunQuary("insert into Stock Values(0,1)", "");
                }

                if (Money - total < 0)
                {
                    if (rbtnCustomer.Checked == true)
                    {
                        MessageBox.Show("لا يوجد رصيد كافى فى الخزنه لاتمام عملية الاسترجاع !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                decimal qty = Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[2].Value);
                decimal QtyInUnit = 1, qtyFinal = 1;
                DataTable tblQty = new DataTable(); DataTable tblStore = new DataTable();
                tblQty.Clear(); tblStore.Clear();
                tblQty = db.RunReader("select * from Items_Unit where Item_ID=" + DgvSearchBuy.CurrentRow.Cells[10].Value + " and Unit_Name=N'" + Convert.ToString(DgvSearchBuy.CurrentRow.Cells[3].Value) + "'", "");
                try
                {
                    QtyInUnit = Convert.ToDecimal(tblQty.Rows[0][3]);
                }
                catch (Exception) { }
                if (QtyInUnit >= 1)
                {
                    qtyFinal = Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[2].Value) / QtyInUnit;
                }
                if (rbtnSuplier.Checked == true)
                {
                    tblStore = db.RunReader("select Qty - " + qtyFinal + " from Items_Qty where Item_ID =" + DgvSearchBuy.CurrentRow.Cells[10].Value + " and  Store_ID=" + cbxStore2.SelectedValue + " and Store_Name=N'" + cbxStore2.Text + "' ", "");

                    if (Convert.ToDecimal(tblStore.Rows[0][0]) >= 0)
                    {
                        db.RunNunQuary("update Items_Qty set Qty =Qty -(" + qtyFinal + ") where Item_ID=" + DgvSearchBuy.CurrentRow.Cells[10].Value + " and  Store_ID=" + cbxStore2.SelectedValue + " and Store_Name=N'" + cbxStore2.Text + "' ", "");
                    }
                    else
                    {
                        MessageBox.Show("الكمية التى تريد ارجاعها غير موجودة فى المخزن", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                if (rbtnCustomer.Checked == true)
                    db.RunNunQuary("insert into Return_ (Date ,Type) values('" + d + "','مرتجات مبيعات')", "");
                else
                    db.RunNunQuary("insert into Return_ (Date ,Type) values('" + d + "','مرتجعات مشتريات')", "");
                int ID = 0;
                try
                {
                    ID = Convert.ToInt32(db.RunReader("SELECT TOP 1 * FROM Return_ ORDER BY Order_ID DESC", "").Rows[0][0]);
                }
                catch (Exception) { }
                
                    
                    try
                    {
                        if (rbtnCustomer.Checked == true)
                        {
                            db.RunNunQuary("insert Return_Detalis values (" + ID + " ,N'" + DgvSearchBuy.CurrentRow.Cells[1].Value + "' ," + qty + " ," + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) + " ," + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[6].Value) + "," + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) + " ,'" + Properties.Settings.Default.UserName + "','" + d + "' , 'مرتجعات بيع' ," + DgvSearchBuy.CurrentRow.Cells[0].Value + ",N'" + txtReturnerName.Text + "','" + DgvSearchBuy.CurrentRow.Cells[3].Value + "')", "");
                        }
                        else
                        {
                            db.RunNunQuary("insert Return_Detalis values (" + ID + " ,N'" + DgvSearchBuy.CurrentRow.Cells[1].Value + "' ," + qty + " ," + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) + " ," + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[6].Value) + "," + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) + " ,'" + Properties.Settings.Default.UserName + "','" + d + "' , 'مرتجعات مشتريات' ," + DgvSearchBuy.CurrentRow.Cells[0].Value + ",N'" + txtReturnerName.Text + "','" + DgvSearchBuy.CurrentRow.Cells[3].Value + "')", "");
                        }

                    }
                    catch (Exception) { }
                    try
                    {

                        tblStore.Clear();
                        if (rbtnCustomer.Checked == true)
                        {
                            db.RunNunQuary("update Items set Item_Qty =Item_Qty +(" + qtyFinal + ") where Item_ID=" + DgvSearchBuy.CurrentRow.Cells[10].Value + "", "");

                            tblStore = db.RunReader("select * from Items_Qty where Item_ID=" + DgvSearchBuy.CurrentRow.Cells[10].Value + " and  Store_ID=" + cbxStore2.SelectedValue + " and Store_Name=N'" + cbxStore2.Text + "' and Price_Buy=" + DgvSearchBuy.CurrentRow.Cells[4].Value + " ", "");
                            if (tblStore.Rows.Count >= 1)
                            {
                                db.RunNunQuary("update Items_Qty set Qty =Qty +(" + qtyFinal + ") where Item_ID=" + DgvSearchBuy.CurrentRow.Cells[10].Value + " and  Store_ID=" + cbxStore2.SelectedValue + " and Store_Name=N'" + cbxStore2.Text + "' and Price_Buy=" + DgvSearchBuy.CurrentRow.Cells[4].Value + "", "");
                            }
                            else
                            {
                                decimal q = Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) * QtyInUnit;
                                db.RunNunQuary("insert into Items_Qty Values (" + DgvSearchBuy.CurrentRow.Cells[10].Value + " , " + cbxStore2.SelectedValue + " , N'" + cbxStore2.Text + "' ," + qtyFinal + " , " + DgvSearchBuy.CurrentRow.Cells[4].Value + "," + q + "  ,'')", "");
                            }

                        }
                        else if (rbtnSuplier.Checked == true)
                        {
                            db.RunNunQuary("update Items set Item_Qty =Item_Qty  -(" + qtyFinal + ") where Item_ID=" + DgvSearchBuy.CurrentRow.Cells[10].Value + "", "");

                        }
                    }
                    catch (Exception) { }

                if (rbtnCustomer.Checked == true)
                {
                    //db.RunNunQuary("update Stock set Money=Money - " + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[7].Value) + " where Stock_ID=" + stock_ID + "", "");
                    //db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type,Stock_ID) Values(" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[7].Value) + " ,'" + d + "' ,'مرتجعات مبيعات' ,'عملية مرتجعات مبيعات'," + stock_ID + ")", "");
                    returnMoney( Convert.ToInt32(textParcode.Text), Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[7].Value), "part");
                    try
                    {
                        db.RunNunQuary("delete from Sale_Detalis_Rbh7  where Order_ID=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[0].Value) + "   and Qty=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[2].Value) + " and Sale_Price =" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) + " and Item_ID=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[10].Value) + "", "");

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    db.RunNunQuary("delete from Sale_Detalis  where Order_ID=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[0].Value) + "   and Qty=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[2].Value) + " and Price=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) + " and Item_ID=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[10].Value) + "", "");
                    decimal tot = (Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[2].Value) * Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value)) - Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[5].Value);
                    db.RunNunQuary("insert into Taxes_Report (Order_Type,Tax_Type,Date,Cust_Name,Total_Price,Tax_Value,Total_WithTax,Order_Num) Values ('مرتجعات بيع','ضريبة قيمه مضافة','" + d + "' ,N'" + txtReturnerName.Text + "' ,'' ," + tot + " ," + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[6].Value) + " ," + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[7].Value) + " ," + ID + ")", "");
                }
                else {
                    //db.RunNunQuary("update Stock set Money=Money + " + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[6].Value) + " where Stock_ID=" + stock_ID + "", "");
                    //db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type,Stock_ID) Values(" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[6].Value) + " ,'" + d + "' ,'مرتجعات مشتريات' ,'عملية مرتجعات مشتريات'," + stock_ID + ")", "");
                    returnSupMoney(Convert.ToInt32(textParcode.Text), Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[6].Value), "part");
                    db.RunNunQuary("delete from Buy_Detalis where Order_ID=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[0].Value) + "   and Qty=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[2].Value) + " and Price=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) + " and Item_ID=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[10].Value) + "", "");
                    decimal tot = (Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[2].Value) * Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value)) - Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[5].Value);
                    db.RunNunQuary("insert into Taxes_Report (Order_Type,Tax_Type,Date,Cust_Name,Total_Price,Tax_Value,Total_WithTax,Order_Num) Values ('مرتجعات مشتريات','ضريبة قيمه مضافة','" + d + "' ,N'" + txtReturnerName.Text + "' ,'' ," + tot + " ," + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[6].Value) + " ," + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[7].Value) + " ," + ID + ")", "");

                }
                MessageBox.Show("تم ارجاع الصنف المحدد بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }
        private void SupBuyReturnPart()
        {

            if (DgvSearchBuy.Rows.Count >= 1)
            {

                if (txtReturnerName2.Text == "")
                {
                    if (rbtnCustomer.Checked == true)
                        MessageBox.Show("من فضلك ادخل اسم العميل ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("من فضلك ادخل اسم المورد ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataTable tblCheck = new DataTable();
                tblCheck.Clear();
                tblCheck = db.RunReader("select * from Stock where Stock_ID=" + stock_ID + "", "");
                string User = Properties.Settings.Default.UserName;


                string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
                decimal Money = 0;
                decimal total = 0;
                try
                {
                    total = Convert.ToDecimal(txtTotalWithtax.Text);
                    Money = Convert.ToDecimal(tblCheck.Rows[0][0]);

                }
                catch (Exception)
                {
                    db.RunNunQuary("insert into Stock Values(0,1)", "");
                }

                if (Money - total < 0)
                {
                    if (rbtnCustomer.Checked == true)
                    {
                        MessageBox.Show("لا يوجد رصيد كافى فى الخزنه لاتمام عملية الاسترجاع !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                decimal qty = NudQtyReturn.Value ;
                decimal QtyInUnit = 1, qtyFinal = 1;
                DataTable tblQty = new DataTable(); DataTable tblStore = new DataTable();
                tblStore.Clear();
                tblQty.Clear();
                tblQty = db.RunReader("select * from Items_Unit where Item_ID=" + DgvSearchBuy.CurrentRow.Cells[10].Value + " and Unit_Name=N'" + Convert.ToString(DgvSearchBuy.CurrentRow.Cells[3].Value) + "'", "");
                try
                {
                    QtyInUnit = Convert.ToDecimal(tblQty.Rows[0][3]);
                }
                catch (Exception) { }
                if (QtyInUnit >= 1)
                {
                    qtyFinal = NudQtyReturn.Value / QtyInUnit;
                }

                
                if (qtyFinal - (Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[2].Value) / QtyInUnit) > 0)
                {
                    MessageBox.Show("الكمية التى تريد ارجاعها اكبر من الكمية التى تم بيعها", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (rbtnSuplier.Checked == true) {
                    DataTable tblQtyCheck = new DataTable();
                    tblQtyCheck.Clear();
                    tblQtyCheck = db.RunReader("select Qty - " + qtyFinal + " from Items_Qty where Item_ID=" + DgvSearchBuy.CurrentRow.Cells[10].Value + " and Store_ID=" + cbxStore2.SelectedValue + " and Store_Name=N'" + cbxStore2.Text + "' ", "");
                    if (tblQtyCheck.Rows.Count >= 1) {
                        if (Convert.ToDecimal(tblQtyCheck.Rows[0][0]) < 0)
                        {
                            MessageBox.Show("لا يوجد الكمية التى تريد ارجاعها فى المخزن المحدد من فضلك اختر مخزن اخر", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("المخزن المحدد لا يوجد فيه المنتج الذى تريد ترجعيه من فضلك تاكد من المخزن الذى قمت باختياره", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                if (rbtnSuplier.Checked == true)
                {
                    tblStore = db.RunReader("select Qty - " + qtyFinal + " from Items_Qty where Item_ID =" + DgvSearchBuy.CurrentRow.Cells[10].Value + " and  Store_ID=" + cbxStore2.SelectedValue + " and Store_Name=N'" + cbxStore2.Text + "' ", "");

                    if (Convert.ToDecimal(tblStore.Rows[0][0]) >= 0)
                    {
                        db.RunNunQuary("update Items_Qty set Qty =Qty -(" + qtyFinal + ") where Item_ID=" + DgvSearchBuy.CurrentRow.Cells[10].Value + " and  Store_ID=" + cbxStore2.SelectedValue + " and Store_Name=N'" + cbxStore2.Text + "' ", "");
                    }
                    else
                    {
                        MessageBox.Show("الكمية التى تريد ارجاعها غير موجودة فى المخزن", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                if (rbtnCustomer.Checked == true)
                    db.RunNunQuary("insert into Return_ (Date ,Type) values('" + d + "','مرتجات مبيعات')", "");
                else
                    db.RunNunQuary("insert into Return_ (Date ,Type) values('" + d + "','مرتجعات مشتريات')", "");
                int ID = 0;
                try
                {
                    ID = Convert.ToInt32(db.RunReader("SELECT TOP 1 * FROM Return_ ORDER BY Order_ID DESC", "").Rows[0][0]);
                }
                catch (Exception) { }

                
                try
                {
                    if (rbtnCustomer.Checked == true)
                    {
                        db.RunNunQuary("insert Return_Detalis values (" + ID + " ,N'" + DgvSearchBuy.CurrentRow.Cells[1].Value + "' ," + qty + " ," + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) + " ," + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[6].Value) + "," + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) + " ,'" + Properties.Settings.Default.UserName + "','" + d + "' , 'مرتجعات بيع' ," + DgvSearchBuy.CurrentRow.Cells[0].Value + ",N'" + txtReturnerName.Text + "','" + DgvSearchBuy.CurrentRow.Cells[3].Value + "')", "");
                    }
                    else
                    {
                        db.RunNunQuary("insert Return_Detalis values (" + ID + " ,N'" + DgvSearchBuy.CurrentRow.Cells[1].Value + "' ," + qty + " ," + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) + " ," + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[6].Value) + "," + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) + " ,'" + Properties.Settings.Default.UserName + "','" + d + "' , 'مرتجعات مشتريات' ," + DgvSearchBuy.CurrentRow.Cells[0].Value + ",N'" + txtReturnerName.Text + "','" + DgvSearchBuy.CurrentRow.Cells[3].Value + "')", "");
                    }

                }
                catch (Exception) { }
                try
                {

                    tblStore.Clear();
                    if (rbtnCustomer.Checked == true)
                    {
                        db.RunNunQuary("update Items set Item_Qty =Item_Qty  + (" + qtyFinal + ") where Item_ID=" + DgvSearchBuy.CurrentRow.Cells[10].Value + "", "");
                      
                        tblStore = db.RunReader("select * from Items_Qty where Item_ID=" + DgvSearchBuy.CurrentRow.Cells[10].Value + " and  Store_ID=" + cbxStore2.SelectedValue + " and Store_Name=N'" + cbxStore2.Text + "' and Price_Buy=" + DgvSearchBuy.CurrentRow.Cells[4].Value + " ", "");
                        if (tblStore.Rows.Count >= 1)
                            {
                                db.RunNunQuary("update Items_Qty set Qty =Qty +(" + qtyFinal + ") where Item_ID=" + DgvSearchBuy.CurrentRow.Cells[10].Value + " and  Store_ID=" + cbxStore2.SelectedValue + " and Store_Name=N'" + cbxStore2.Text + "' and Price_Buy=" + DgvSearchBuy.CurrentRow.Cells[4].Value + "", "");
                            }
                            else
                            {
                                decimal q = Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) * QtyInUnit;
                                db.RunNunQuary("insert into Items_Qty Values (" + DgvSearchBuy.CurrentRow.Cells[10].Value + " , " + cbxStore2.SelectedValue + " , N'" + cbxStore2.Text + "' ," + qtyFinal + " , " + DgvSearchBuy.CurrentRow.Cells[4].Value + "," + q + " ,'' )", "");
                            }
                    }
                    else if (rbtnSuplier.Checked == true)
                    {
                        db.RunNunQuary("update Items set Item_Qty =Item_Qty  - (" + qtyFinal + ") where Item_ID=" + DgvSearchBuy.CurrentRow.Cells[10].Value + "", "");
                    }

                    
                       
                   
                }
                catch (Exception) { }

                decimal price = 0,taxes=0,totalTax=0;
                taxes = Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[6].Value) / Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[2].Value);
                totalTax = taxes *( NudQtyReturn.Value / QtyInUnit);
                price = (((NudQtyReturn.Value / QtyInUnit) * Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value)) + totalTax) - Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[5].Value);
               
                if (rbtnCustomer.Checked == true)
                {
                    //db.RunNunQuary("update Stock set Money=Money - " + price+ " where Stock_ID=" + stock_ID + "", "");
                    //db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type,Stock_ID) Values(" + price+ " ,'" + d + "' ,'مرتجعات مبيعات' ,'عملية مرتجعات مبيعات'," + stock_ID + ")", "");
                    returnMoney(Convert.ToInt32(textParcode.Text), price, "part");
                    if ((NudQtyReturn.Value / QtyInUnit) -( Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[2].Value)/ QtyInUnit) == 0)

                        db.RunNunQuary("delete from Sale_Detalis where Order_ID=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[0].Value) + "   and Qty=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[2].Value) + " and Price=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) + " and Item_ID=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[10].Value) + "", "");

                    else
                    {
                        db.RunNunQuary("update  Sale_Detalis set  Qty=Qty - " + NudQtyReturn.Value + "   where Order_ID=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[0].Value) + "   and Qty=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[2].Value) + " and Price=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) + " and Item_ID=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[10].Value) + "", "");
                        db.RunNunQuary("update  Sale_Detalis_Rbh7 set  Qty=Qty - " + NudQtyReturn.Value + "   where Order_ID=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[0].Value) + "   and Qty=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[2].Value) + " and Sale_Price =" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) + " and Item_ID=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[10].Value) + "", "");
                    }

                    decimal tot = (Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) * (qtyFinal)) - Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[5].Value);
                    decimal totalWithtax = tot + totalTax;
                    db.RunNunQuary("insert into Taxes_Report (Order_Type,Tax_Type,Date,Sup_Name,Total_Price,Tax_Value,Total_WithTax,Order_Num) Values ('مرتجعات بيع','ضريبة قيمه مضافة','" + d + "' ,N'" + txtReturnerName2.Text + "' ,'' ," + tot + " ," + totalTax + " ," + totalWithtax + " ," + ID + ")", "");

                }
                else {
                    //db.RunNunQuary("update Stock set Money=Money + " + price + " where Stock_ID=" + stock_ID + "", "");
                    //db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type,Stock_ID) Values(" + price + " ,'" + d + "' ,'مرتجعات مشتريات' ,'عملية مرتجعات مشتريات'," + stock_ID + ")", "");
                    returnSupMoney(Convert.ToInt32(textParcode.Text), price, "part");
                    if (qtyFinal - (Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[2].Value) / QtyInUnit) == 0)

                        db.RunNunQuary("delete from Buy_Detalis where Order_ID=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[0].Value) + "   and Qty=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[2].Value) + " and Price=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) + " and Item_ID=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[10].Value) + "", "");

                    else
                        db.RunNunQuary("update Buy_Detalis set Qty=qty - " + NudQtyReturn.Value + "  where Order_ID=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[0].Value) + "   and Qty=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[2].Value) + " and Price=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) + " and Item_ID=" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[10].Value) + "", "");
                        
                    decimal tot = (Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[4].Value) * (Convert.ToDecimal(NudQtyReturn.Value)/ QtyInUnit)) - Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[5].Value);
                    decimal totalWithtax = tot + totalTax;
                    db.RunNunQuary("insert into Taxes_Report (Order_Type,Tax_Type,Date,Sup_Name,Total_Price,Tax_Value,Total_WithTax,Order_Num) Values ('مرتجعات مشتريات','ضريبة قيمه مضافة','" + d + "' ,N'" + txtReturnerName2.Text + "'  ," + tot + " ," + totalTax + " ," + totalWithtax + " ," + ID + ")", "");

                }
                MessageBox.Show("تمت ارجاع الصنف المحدد بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void btnReturnPart_Click(object sender, EventArgs e)
        {
            db.RunNunQuary("delete from Items_Qty where Qty <= 0", "");
            if (rbtnReturnAll.Checked == true) 
            { CustSaleReturnPart(); } 
            else if(rbtnReturnPart.Checked==true) {
                SupBuyReturnPart();
            }
            tbl.Clear();
            DgvSearchBuy.DataSource = tbl;
            NudMadfo3.Value = 0;
            txtReport.Clear(); txtTotal.Clear(); txtTotalTax.Clear(); txtTotalWithtax.Clear();
        }
        private void DgvSearchBuy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void NudMadfo3_ValueChanged(object sender, EventArgs e)
        {

        }
///
        void returnMoney(int invoiceId, decimal invoiceReturnMoney, string type)
        {          
            DataTable invDept  = db.RunReader("select  ISNULL(sum(price), 0) from Customer_Money where  Order_ID=" + invoiceId + "", "");
            string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
            decimal invoiceDept = Convert.ToDecimal(invDept.Rows[0][0]);
            if(type == "all")
            {
                db.RunNunQuary("delete from Customer_Money where Order_ID=" + invoiceId + "", "");
                db.RunNunQuary("delete from Customer_Report where Order_ID=" + invoiceId + "", "");
                db.RunNunQuary("update Stock set Money=Money - " + invoiceReturnMoney + " where Stock_ID=" + stock_ID + "", "");
                db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type,Stock_ID) Values(" + invoiceReturnMoney + " ,'" + d + "' ,'مرتجعات مبيعات' ,'عملية مرتجع مبيعات'," + stock_ID + ")", "");
            }
            if (type == "part")
            {
                if(invoiceReturnMoney <= invoiceDept)
                {
                    db.RunNunQuary("update Customer_Money set Price = Price - " + invoiceReturnMoney + " where Order_ID=" + invoiceId + "", "");
                    //dept = dept - paied
                }
                else
                {
                    decimal defference = invoiceReturnMoney - invoiceDept;
                    db.RunNunQuary("delete from Customer_Money where Order_ID=" + invoiceId + "", "");
                    db.RunNunQuary("update Customer_Report set Price = Price - " + defference + " where Order_ID=" + invoiceId + "", "");
                    db.RunNunQuary("update Stock set Money=Money - " + defference + " where Stock_ID=" + cbxStore2.SelectedValue + "", "");
                    db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type,Stock_ID) Values(" + defference + " ,'" + d + "' ,'مرتجعات مبيعات' ,'عملية مرتجع مبيعات'," + stock_ID + ")", "");

                    //delete dept
                    //n=money = m - defference
                    // safe = - defference
                }

            }
        }
        void returnSupMoney(int invoiceId, decimal invoiceReturnMoney, string type)
        {
            DataTable invDept = db.RunReader("select  ISNULL(sum(price), 0) from Suplier_Money where  Order_ID=" + invoiceId + "", "");
            string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
            decimal invoiceDept = Convert.ToDecimal(invDept.Rows[0][0]);
            if (type == "all")
            {
                db.RunNunQuary("delete from Suplier_Money where Order_ID=" + invoiceId + "", "");
                db.RunNunQuary("delete from Suplier_Report where Order_ID=" + invoiceId + "", "");
                db.RunNunQuary("update Stock set Money=Money + " + invoiceReturnMoney + " where Stock_ID=" + stock_ID + "", "");
                db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type,Stock_ID) Values(" + invoiceReturnMoney + " ,'" + d + "' ,'مرتجعات مبيعات' ,'عملية مرتجع مبيعات'," + stock_ID + ")", "");
            }
            if (type == "part")
            {
                if (invoiceReturnMoney <= invoiceDept)
                {
                    db.RunNunQuary("update Suplier_Money set Price = Price - " + invoiceReturnMoney + " where Order_ID=" + invoiceId + "", "");
                    //dept = dept - paied
                }
                else
                {
                    decimal defference = invoiceReturnMoney - invoiceDept;
                    db.RunNunQuary("delete from Suplier_Money where Order_ID=" + invoiceId + "", "");
                    db.RunNunQuary("update Suplier_Report set Price = Price - " + defference + " where Order_ID=" + invoiceId + "", "");
                    db.RunNunQuary("update Stock set Money=Money + " + defference + " where Stock_ID=" + cbxStore2.SelectedValue + "", "");
                    db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type,Stock_ID) Values(" + defference + " ,'" + d + "' ,'مرتجعات مبيعات' ,'عملية مرتجع مبيعات'," + stock_ID + ")", "");

                    //delete dept
                    //n=money = m - defference
                    // safe = - defference
                }

            }
        }
    }
}
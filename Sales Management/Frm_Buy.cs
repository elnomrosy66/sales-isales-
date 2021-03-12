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
    public partial class Frm_Buy : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Buy()
        {
            InitializeComponent();
        }


        DB db = new DB();
        Double Sum = 0;
        DataTable tbl = new DataTable();
        private void FillCustomer()
        {
            cbxSuplier.DataSource = db.RunReader("select * from Suplier", "");
            cbxSuplier.DisplayMember = "Sup_Name";
            cbxSuplier.ValueMember = "Sup_ID";
        }
        private void FillItems()
        {
            cbxItems.DataSource = db.RunReader("select * from Items", "");
            cbxItems.DisplayMember = "Item_Name";
            cbxItems.ValueMember = "Item_ID";
        }
        private void DataGrid()
        {
            tbl.Columns.Add("رقم الصنف");
            tbl.Columns.Add("الصنف");
            tbl.Columns.Add("الكمية");
            tbl.Columns.Add("السعر");
            tbl.Columns.Add("الخصم");
            tbl.Columns.Add("بونص");
            tbl.Columns.Add("الاجمالى");
            DgvBuyDetalis.DataSource = tbl;
        }
        void ResizeGrid()
        {
            this.DgvBuyDetalis.RowHeadersWidth = 4;
            this.DgvBuyDetalis.Columns[0].Width = 65;
            this.DgvBuyDetalis.Columns[1].Width = 240;
            this.DgvBuyDetalis.Columns[2].Width = 60;
            this.DgvBuyDetalis.Columns[3].Width = 75;
            this.DgvBuyDetalis.Columns[5].Width = 63;
            this.DgvBuyDetalis.Columns[6].Width = 133;
            this.DgvBuyDetalis.Columns[7].Width = 174;
        }
        private void AutoNum()
        {
            DataTable tblautonum = new DataTable();

            tblautonum.Clear();
            tblautonum = db.RunReader("select max(Order_ID) from Buy", "");
            if (tblautonum.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtBuyID.Text = "1";
            }
            else
            {
                txtBuyID.Text = (Convert.ToInt32(tblautonum.Rows[0][0].ToString()) + 1).ToString();

            }
            try
            {
                txtPrice.Clear();
                NudMadfo3.Value = 0;
               NudTax.Value = 0;
                txtReport.Clear();
                NudQty.Value = 1;
                try
                {
                    cbxItems.SelectedIndex = 0;
                }
                catch (Exception) { }
                DtbSaleDate.Text = DateTime.Now.ToShortDateString();
                DtbReminder.Text = DateTime.Now.ToShortDateString();
            }
            catch (Exception) { }
            cbxItems.Text = "اختر منتج";
            txtItemID.Text = "0";
        }
        int stock_ID;

        private void Frm_Buy_Load(object sender, EventArgs e)
        {
            try
            {
                DtbReminder.Enabled = false;
                NudMadfo3.Enabled = false;
                FillItems();
                FillCustomer();
                AutoNum();
                DataGrid();
                ResizeGrid();
            }
            catch (Exception) { }
            try
            {
                decimal qtyOne = 0;

                try
                {
                    qtyOne = Convert.ToDecimal(db.RunReader("select (Item_Price) from items where Item_ID=" + cbxItems.SelectedValue + "", "").Rows[0][0]);
                }
                catch (Exception) { }
                txtPrice.Text = Math.Round(qtyOne, 2).ToString();

            }
            catch (Exception) { }

            stock_ID =Convert.ToInt32( Properties.Settings.Default.UserStock );
            textParcode.Clear();
            textParcode.Focus();
            cbxItems.Text = "اختر منتج";
            txtItemID.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                decimal d = (NudDiscount.Value);

                DataRow Row = tbl.NewRow();
                Row[0] = txtItemID.Text;
                Row[1] = cbxItems.Text;
                Row[3] = txtPrice.Text;
                Row[2] = NudQty.Value;
                Row[4] = NudDiscount.Value;
                Row[5] = NudTax.Value;
                decimal tot = ((NudQty.Value * Convert.ToDecimal(txtPrice.Text) + NudTax.Value) - (d));
                Row[6] = Math.Round(tot, 2);

                tbl.Rows.Add(Row);
                DgvBuyDetalis.DataSource = tbl;


                lblItems.Text = " عدد الاصناف " + (Convert.ToDecimal(tbl.Rows.Count)).ToString();
            }
            catch (Exception) { }
            Sum = 0;
            double totWithoutTax = 0;
            double totTax = 0;
            for (int i = 0; i <= DgvBuyDetalis.Rows.Count - 1; i++)
            {
                Sum += Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[6].Value);
                totTax += Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[5].Value);
                totWithoutTax += (Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[2].Value) * Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[3].Value)) - Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[4].Value);
            }
            txtTotalWithtax.Text = Math.Round(Sum, 2).ToString();
            txtTotal.Text = Math.Round(totWithoutTax, 2).ToString();
            txtTotalTax.Text = Math.Round(totTax, 2).ToString();
            textParcode.Clear();
            textParcode.Focus();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i;
            if (tbl.Rows.Count >= 1)
            {
                tbl.Rows.RemoveAt(DgvBuyDetalis.CurrentCell.RowIndex);
                Sum = 0;
                for (i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Sum += Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[5].Value);
                }
            }
            else
            {
                Sum = 0;
                MessageBox.Show("لا يوجد بيانات لكى تتمكن من مسحها", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTotal.Text = Sum.ToString();
            lblItems.Text = " عدد الاصناف " + (Convert.ToDecimal(tbl.Rows.Count)).ToString();
            textParcode.Clear();
            textParcode.Focus();

        }
        decimal taxes;
        private void cbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            taxes = 0; decimal def = 0;
            try
            {
                DataTable tblitems = new DataTable();
                tblitems.Clear();
                if (cbxItems.SelectedIndex == 0)
                    tblitems = db.RunReader("select * from Items where Item_ID=1", "");
                else
                    tblitems = db.RunReader("select * from Items where Item_ID=" + cbxItems.SelectedValue + "", "");
                txtItemID.Text = tblitems.Rows[0][0].ToString();
                txtPrice.Text = tblitems.Rows[0][3].ToString();
                taxes = Convert.ToDecimal(tblitems.Rows[0][12]);
                def = (Convert.ToDecimal(txtPrice.Text) / 100) * taxes;
                NudTax.Value = def * NudQty.Value;

                try
                {
                    decimal d = (NudDiscount.Value);
                    decimal tot = (NudQty.Value * Convert.ToDecimal(txtPrice.Text) + (NudTax.Value)) - d;
                    txtTootal.Text = Math.Round(tot, 2).ToString();
                }
                catch (Exception) { }

            }
            catch (Exception) { }
            textParcode.Clear();
            textParcode.Focus();
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal qtyOne = 0;

                try
                {
                    qtyOne = Convert.ToDecimal(db.RunReader("select (Item_Qty ) from items where Item_ID=" + txtItemID.Text + "", "").Rows[0][0]);
                }
                catch (Exception) { }
             
            }
            catch (Exception) { }
            textParcode.Clear();
            textParcode.Focus();
        }

        private void NudQty_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                decimal taxes = 0; decimal def = 0;

                DataTable tblitems = new DataTable();
                tblitems.Clear();
                if (cbxItems.SelectedIndex == 0)
                    tblitems = db.RunReader("select * from Items where Item_ID=1", "");
                else
                    tblitems = db.RunReader("select * from Items where Item_ID=" + cbxItems.SelectedValue + "", "");

                txtPrice.Text = tblitems.Rows[0][3].ToString();
                taxes = Convert.ToDecimal(tblitems.Rows[0][12]);
                def = (Convert.ToDecimal(txtPrice.Text) / 100) * taxes;
                NudTax.Value = def * NudQty.Value;
            }
            catch (Exception) { }

            try
            {
                decimal d = (NudDiscount.Value);
                decimal tot = (NudQty.Value * Convert.ToDecimal(txtPrice.Text) + (NudTax.Value)) - d;
                txtTootal.Text = Math.Round(tot, 2).ToString();
            }
            catch (Exception) { }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal d = (NudDiscount.Value);
                decimal tot = (NudQty.Value * Convert.ToDecimal(txtPrice.Text) + (NudTax.Value)) - d;
                txtTootal.Text = Math.Round(tot, 2).ToString();
            }
            catch (Exception) { }
        }

        private void NudDiscount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal d = (NudDiscount.Value);
                decimal tot = (NudQty.Value * Convert.ToDecimal(txtPrice.Text) + (NudTax.Value)) - d;
                txtTootal.Text = Math.Round(tot, 2).ToString();
            }
            catch (Exception) { }
        }

        private void rbtnPayCash_CheckedChanged(object sender, EventArgs e)
        {
            DtbReminder.Enabled = false;
            NudMadfo3.Enabled = false;
        }

        private void rbtnPayPart_CheckedChanged(object sender, EventArgs e)
        {
            DtbReminder.Enabled = true;
            NudMadfo3.Enabled = true;
        }

        private void NudMadfo3_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (NudMadfo3.Value - Convert.ToDecimal(txtTotal.Text) == 0)
                    txtReport.Text = "الملبغ الباقى هو صفر...";
                else if (Convert.ToDecimal(txtTotal.Text) - NudMadfo3.Value > 0)
                    txtReport.Text = "الملبغ المتبقى للمورد هو " + (Convert.ToDecimal(txtTotal.Text) - NudMadfo3.Value).ToString();
                else
                    txtReport.Text = "الملبغ على المورد هو " + Math.Abs(Convert.ToDecimal(txtTotal.Text) - NudMadfo3.Value).ToString();
            }
            catch (Exception) { }
        }

        private void DgvBuyDetalis_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal SUM;

            if (DgvBuyDetalis.Rows.Count >= 1)
            {


                try
                {

                    decimal taxes = 0; decimal def = 0;

                    DataTable tblitems = new DataTable();
                    tblitems.Clear();

                    tblitems = db.RunReader("select * from Items where Item_ID=" + DgvBuyDetalis.CurrentRow.Cells[0].Value + "", "");

                    taxes = Convert.ToDecimal(tblitems.Rows[0][12]);
                    def = ((Convert.ToDecimal(DgvBuyDetalis.CurrentRow.Cells[3].Value) / 100) * taxes) * Convert.ToDecimal(DgvBuyDetalis.CurrentRow.Cells[2].Value);
                    DgvBuyDetalis.CurrentRow.Cells[5].Value = def * NudQty.Value;
                }
                catch (Exception) { }





                SUM = 0;
                double totWithoutTax = 0;
                double totTax = 0;
                try
                {
                    decimal d = Convert.ToDecimal(DgvBuyDetalis.CurrentRow.Cells[4].Value);
                    DgvBuyDetalis.CurrentRow.Cells[6].Value = (Convert.ToDecimal(DgvBuyDetalis.CurrentRow.Cells[2].Value) * Convert.ToDecimal(DgvBuyDetalis.CurrentRow.Cells[3].Value) + Convert.ToDecimal(DgvBuyDetalis.CurrentRow.Cells[5].Value)) - d;
                }
                catch (Exception) { }

                for (int i = 0; i <= DgvBuyDetalis.Rows.Count - 1; i++)
                {
                    SUM += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[6].Value);
                    totTax += Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[5].Value);
                    totWithoutTax += (Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[2].Value) * Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[3].Value)) - Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[4].Value);

                }
                txtTotalWithtax.Text = Math.Round(SUM).ToString();
                txtTotal.Text = Math.Round(totWithoutTax, 2).ToString();
                txtTotalTax.Text = Math.Round(totTax, 2).ToString();


            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataTable tblCheck = new DataTable();
            tblCheck.Clear();
            tblCheck = db.RunReader("select * from Stock where Stock_ID="+stock_ID+"", "");
            string User = Properties.Settings.Default.UserName;
            if (DgvBuyDetalis.Rows.Count >= 1)
            {
                string d2 = DtbReminder.Value.ToString("dd/MM/yyyy");
                if (cbxSuplier.Items.Count <= 0)
                {
                    MessageBox.Show("من فضلك ادخل اسم المورد اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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
                if (rbtnPayCash.Checked == true)
                {
                    if (Money - total < 0)
                    {
                        MessageBox.Show("لا يوجد رصيد كافى فى الخزنه لاتمام عملية الشراء !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else if (rbtnPayPart.Checked == true)
                {
                    if (Money - NudMadfo3.Value < 0)
                    {
                        MessageBox.Show("لا يوجد رصيد كافى فى الخزنه لاتمام عملية الشراء !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                db.RunNunQuary("insert into Buy values(" + txtBuyID.Text + ",'" + d + "'," + cbxSuplier.SelectedValue + ")", "");
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    decimal qty = Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[2].Value);
                    decimal priceTax = Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[3].Value) + Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[5].Value);
                    try
                    {
                        if (rbtnPayCash.Checked == true) 
                            db.RunNunQuary("insert into Buy_Detalis values(" + txtBuyID.Text + "," + DgvBuyDetalis.Rows[i].Cells[0].Value + "," + cbxSuplier.SelectedValue + "," + qty + "," + DgvBuyDetalis.Rows[i].Cells[3].Value + ",'" + d + "'," + txtTotal.Text + "," + DgvBuyDetalis.Rows[i].Cells[4].Value + " ,'" + User + "' ," + DgvBuyDetalis.Rows[i].Cells[5].Value + " ," + DgvBuyDetalis.Rows[i].Cells[6].Value + ","+txtTotalWithtax.Text+")", "");
                        else if (rbtnPayPart.Checked==true)
                            db.RunNunQuary("insert into Buy_Detalis values(" + txtBuyID.Text + "," + DgvBuyDetalis.Rows[i].Cells[0].Value + "," + cbxSuplier.SelectedValue + "," + qty + "," + DgvBuyDetalis.Rows[i].Cells[3].Value + ",'" + d + "'," + txtTotal.Text + "," + DgvBuyDetalis.Rows[i].Cells[4].Value + " ,'" + User + "' ," + DgvBuyDetalis.Rows[i].Cells[5].Value + " ," + DgvBuyDetalis.Rows[i].Cells[6].Value + "," +NudMadfo3.Value + ")", "");

                        db.RunNunQuary("update Items set Item_Qty =Item_Qty +(" + qty + ") where Item_ID=" + DgvBuyDetalis.Rows[i].Cells[0].Value + "", "");
                    }
                    catch (Exception) { }
                }
                decimal num = 0;
                num = Convert.ToDecimal(txtTotalWithtax.Text) - NudMadfo3.Value;
                if (rbtnPayPart.Checked == true)
                {
                    db.RunReader("insert into Suplier_Money Values (" + txtBuyID.Text + "," + num + "," + cbxSuplier.SelectedValue + ",'" + d + "' ,'" + d2 + "')", "");
                    db.RunNunQuary("update Stock set Money=Money - " + NudMadfo3.Value + " where Stock_ID=" + stock_ID + "", "");
                    db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type,Stock_ID) Values(" + NudMadfo3.Value + " ,'" + d + "' ,'شراء' ,'عملية شراء',"+stock_ID+")", "");

                }
                if (rbtnPayCash.Checked)
                {
                    db.RunNunQuary("insert into Suplier_Report Values(" + txtBuyID.Text + " ,N'" + cbxSuplier.Text + "'," + txtTotalWithtax.Text + ",N'" + d + "')", "");
                     
                    db.RunNunQuary("update Stock set Money=Money - " + txtTotalWithtax.Text + " where Stock_ID=" + stock_ID + "", "");
                    db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type,Stock_ID) Values(" + txtTotalWithtax.Text + " ,'" + d + "' ,'شراء' ,'عملية شراء',"+stock_ID+")", "");

                }
                db.RunNunQuary("insert into Taxes_Report (Order_Type,Tax_Type,Date,Sup_Name,Cust_Name,Total_Price,Tax_Value,Total_WithTax,Order_Num) Values ('فاتورة مشتريات','ضريبة قيمه مضافة','" + d + "' ,N'" + cbxSuplier.Text + "' ,'' ," + txtTotal.Text + " ," + txtTotalTax.Text + " ," + txtTotalWithtax.Text + " ," + txtBuyID.Text + ")", "");
                tbl.Clear();
                DgvBuyDetalis.DataSource = tbl;
                AutoNum();
                 Print();
            }

            textParcode.Clear();
            textParcode.Focus();
        }
        private void Print()
        {
            try
            {
                decimal num = Convert.ToDecimal(txtBuyID.Text) - 1;
                DataTable tblRpt = new DataTable();
                tblRpt.Clear();
                int x = Convert.ToInt32(txtBuyID.Text) - 1;
                tblRpt = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Items.Item_Name as اسم_الصنف  ,[Qty]  as الكمية,[Price]  as السعر,[Date]  as التاريخ,[Qty] * [Price] as الاجمالى,(Total) as  الاجمالى_العام,Suplier.Sup_Name as المورد ,Discount as الخصم,UserName as 'اسم المستخدم' FROM [Buy_Detalis],Items,Suplier  where Items.Item_ID=Buy_Detalis.Item_ID and Suplier.Sup_ID=Buy_Detalis.Sup_ID and Buy_Detalis.Order_ID=" + num + "", "");
                Frm_Printing frm = new Frm_Printing();
                RptPrintOrderBuy rpt = new RptPrintOrderBuy();

                frm.crystalReportViewer1.RefreshReport();
                rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");
                rpt.SetDataSource(tblRpt);
                rpt.SetParameterValue("ID", num);

                frm.crystalReportViewer1.ReportSource = rpt;
                //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                //rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                //rpt.PrintToPrinter(1, true, 0, 0);
                frm.ShowDialog();
            }
            catch (Exception) { }
        }
        private void PrintDir()
        {
            try
            {
                decimal num = Convert.ToDecimal(txtBuyID.Text) - 1;
                DataTable tblRpt = new DataTable();
                tblRpt.Clear();
                int x = Convert.ToInt32(txtBuyID.Text) - 1;
                tblRpt = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Items.Item_Name as اسم_الصنف  ,[Qty]  as الكمية,[Price]  as السعر,[Date]  as التاريخ,[Qty] * [Price] as الاجمالى,(Total) as  الاجمالى_العام,Suplier.Sup_Name as المورد ,Discount as الخصم,UserName as 'اسم المستخدم' FROM [Buy_Detalis],Items,Suplier  where Items.Item_ID=Buy_Detalis.Item_ID and Suplier.Sup_ID=Buy_Detalis.Sup_ID and Buy_Detalis.Order_ID=" + num + "", "");
                Frm_Printing frm = new Frm_Printing();
                RptPrintOrderBuy rpt = new RptPrintOrderBuy();

                frm.crystalReportViewer1.RefreshReport();
                rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");
                rpt.SetDataSource(tblRpt);
                rpt.SetParameterValue("ID", num);

                frm.crystalReportViewer1.ReportSource = rpt;
                System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                rpt.PrintToPrinter(1, true, 0, 0);
                //frm.ShowDialog();
            }
            catch (Exception) { }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tblCheck = new DataTable();
            tblCheck.Clear();
            tblCheck = db.RunReader("select * from Stock where Stock_ID=" + stock_ID + "", "");
            string User = Properties.Settings.Default.UserName;
            if (DgvBuyDetalis.Rows.Count >= 1)
            {
                string d2 = DtbReminder.Value.ToString("dd/MM/yyyy");
                if (cbxSuplier.Items.Count <= 0)
                {
                    MessageBox.Show("من فضلك ادخل اسم المورد اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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
                if (rbtnPayCash.Checked == true)
                {
                    if (Money - total < 0)
                    {
                        MessageBox.Show("لا يوجد رصيد كافى فى الخزنه لاتمام عملية الشراء !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else if (rbtnPayPart.Checked == true)
                {
                    if (Money - NudMadfo3.Value < 0)
                    {
                        MessageBox.Show("لا يوجد رصيد كافى فى الخزنه لاتمام عملية الشراء !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                db.RunNunQuary("insert into Buy values(" + txtBuyID.Text + ",'" + d + "'," + cbxSuplier.SelectedValue + ")", "");
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    decimal qty = Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[2].Value);
                    decimal priceTax = Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[3].Value) + Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[5].Value);
                    try
                    {
                        if (rbtnPayCash.Checked == true)
                            db.RunNunQuary("insert into Buy_Detalis values(" + txtBuyID.Text + "," + DgvBuyDetalis.Rows[i].Cells[0].Value + "," + cbxSuplier.SelectedValue + "," + qty + "," + DgvBuyDetalis.Rows[i].Cells[3].Value + ",'" + d + "'," + txtTotal.Text + "," + DgvBuyDetalis.Rows[i].Cells[4].Value + " ,'" + User + "' ," + DgvBuyDetalis.Rows[i].Cells[5].Value + " ," + DgvBuyDetalis.Rows[i].Cells[6].Value + "," + txtTotalWithtax.Text + ")", "");
                        else if (rbtnPayPart.Checked == true)
                            db.RunNunQuary("insert into Buy_Detalis values(" + txtBuyID.Text + "," + DgvBuyDetalis.Rows[i].Cells[0].Value + "," + cbxSuplier.SelectedValue + "," + qty + "," + DgvBuyDetalis.Rows[i].Cells[3].Value + ",'" + d + "'," + txtTotal.Text + "," + DgvBuyDetalis.Rows[i].Cells[4].Value + " ,'" + User + "' ," + DgvBuyDetalis.Rows[i].Cells[5].Value + " ," + DgvBuyDetalis.Rows[i].Cells[6].Value + "," + NudMadfo3.Value + ")", "");

                        db.RunNunQuary("update Items set Item_Qty =Item_Qty +(" + qty + ") where Item_ID=" + DgvBuyDetalis.Rows[i].Cells[0].Value + "", "");
                    }
                    catch (Exception) { }
                }
                decimal num = 0;
                num = Convert.ToDecimal(txtTotalWithtax.Text) - NudMadfo3.Value;
                if (rbtnPayPart.Checked == true)
                {
                    db.RunReader("insert into Suplier_Money Values (" + txtBuyID.Text + "," + num + "," + cbxSuplier.SelectedValue + ",'" + d + "' ,'" + d2 + "')", "");
                    db.RunNunQuary("update Stock set Money=Money - " + NudMadfo3.Value + " where Stock_ID=" + stock_ID + "", "");
                    db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type,Stock_ID) Values(" + NudMadfo3.Value + " ,'" + d + "' ,'شراء' ,'عملية شراء'," + stock_ID + ")", "");

                }
                if (rbtnPayCash.Checked)
                {
                    db.RunNunQuary("insert into Suplier_Report Values(" + txtBuyID.Text + " ,N'" + cbxSuplier.Text + "'," + txtTotalWithtax.Text + ",N'" + d + "')", "");

                    db.RunNunQuary("update Stock set Money=Money - " + txtTotalWithtax.Text + " where Stock_ID=" + stock_ID + "", "");
                    db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type,Stock_ID) Values(" + txtTotalWithtax.Text + " ,'" + d + "' ,'شراء' ,'عملية شراء'," + stock_ID + ")", "");

                }
                db.RunNunQuary("insert into Taxes_Report (Order_Type,Tax_Type,Date,Sup_Name,Cust_Name,Total_Price,Tax_Value,Total_WithTax,Order_Num) Values ('فاتورة مشتريات','ضريبة قيمه مضافة','" + d + "' ,N'" + cbxSuplier.Text + "' ,'' ," + txtTotal.Text + " ," + txtTotalTax.Text + " ," + txtTotalWithtax.Text + " ," + txtBuyID.Text + ")", "");
                tbl.Clear();
                DgvBuyDetalis.DataSource = tbl;
                AutoNum();
                PrintDir();
            }

            textParcode.Clear();
            textParcode.Focus();
        }

        private void DgvBuyDetalis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
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
    public partial class Frm_Sales : DevExpress.XtraEditors.XtraForm
    {
        private static Frm_Sales frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_Sales GetMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_Sales();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public Frm_Sales()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        DB db = new DB();

        DataTable tbl = new DataTable();
        private void DataGrid()
        {
            tbl.Columns.Add("رقم الصنف");
            tbl.Columns.Add("الصنف");
            tbl.Columns.Add("الكمية");
            tbl.Columns.Add("السعر");
            tbl.Columns.Add("الخصم");
            tbl.Columns.Add("الضريبة المضافة");
            tbl.Columns.Add("الاجمالى");
            DgvBuyDetalis.DataSource = tbl;
        }
        public void FillCustomer()
        {
            cbxCustname.DataSource = db.RunReader("select Cust_Name,Cust_ID from Customer order by Cust_ID DESC", "");
            cbxCustname.DisplayMember = "Cust_Name";
            cbxCustname.ValueMember = "Cust_ID";
        }
        private void FillItems()
        {
            cbxItems.DataSource = db.RunReader("select * from Items", "");
            cbxItems.DisplayMember = "Item_Name";
            cbxItems.ValueMember = "Item_ID";
        }
        void ResizeGrid()
        {
            this.DgvBuyDetalis.RowHeadersWidth = 4;
            this.DgvBuyDetalis.Columns[0].Width = 70;
            this.DgvBuyDetalis.Columns[1].Width = 260;
            this.DgvBuyDetalis.Columns[2].Width = 72;
            this.DgvBuyDetalis.Columns[3].Width = 95;
            this.DgvBuyDetalis.Columns[4].Width = 76;
            this.DgvBuyDetalis.Columns[5].Width = 133;
            this.DgvBuyDetalis.Columns[6].Width = 140;
        }
        private void AutoNum()
        {
            DataTable tblautonum = new DataTable();

            tblautonum.Clear();
            tblautonum = db.RunReader("select max(Order_ID) from Sale", "");
            if (tblautonum.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtSaleID.Text = "1";
            }
            else
            {
                txtSaleID.Text = (Convert.ToInt32(tblautonum.Rows[0][0].ToString()) + 1).ToString();

            }
            try
            {
                txtPrice.Clear();
                NudMadfo3.Value = 0;
                txtReport.Clear();
                NudQty.Value = 1;
                txtKestNumber.Text = "1";
                try
                {
                    cbxItems.SelectedIndex = 0;

                }
                catch (Exception) { }
                cbxSaleType.SelectedIndex = 0;
                DtbSaleDate.Text = DateTime.Now.ToShortDateString();
                DtbReminder.Text = DateTime.Now.ToShortDateString();
                DtbFirstKest.Text = DateTime.Now.ToShortDateString();
                DtbTime.Text = DateTime.Now.ToShortTimeString();
            }
            catch (Exception) { }
            cbxItems.Text = "اختر منتج";
            txtItemID.Text = "0";
            checkVisa.Checked = false;
        }
        int stock_ID;
        private void Frm_Sales_Load(object sender, EventArgs e)
        {

            try
            {
                stock_ID =Convert.ToInt32( Properties.Settings.Default.UserStock );
                NudMadfo3.Enabled = false;
                cbxCustname.Enabled = false;
                cbxSaleType.SelectedIndex = 0;
                button1.Enabled = false;
                DtbReminder.Enabled = false;
                FillItems();
                FillCustomer();
                AutoNum();
                DataGrid();
                rbtnAll_CheckedChanged(null, null);
                ResizeGrid();


            }
            catch (Exception) { }
            decimal buyOne = 0;
            cbxSaleType.SelectedIndex = 0;
            try
            {
                cbxItems.Text = "اختر منتج";
                txtItemID.Text = "0";
                buyOne = Convert.ToDecimal(db.RunReader("select (Item_Price_Sale_Part) from items where Item_ID=" + txtItemID.Text + "", "").Rows[0][0]);
            }
            catch (Exception) { }
            txtPrice.Text = "0";
            textParcode.Clear();
            textParcode.Focus();
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DgvBuyDetalis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void NudQty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void NudDiscount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtTootal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal Sum = 0;
            if (DgvBuyDetalis.Rows.Count <= 0)
            {
                decimal count = 1;
                try
                {
                    count = Convert.ToDecimal(db.RunReader("select Item_Qty - " + NudQty.Value + " from Items where Item_ID=" + txtItemID.Text + "", "").Rows[0][0]);
                }
                catch (Exception) { }
                if (count < 0)
                { MessageBox.Show("من فضلك راجع كميه المنتج الموجوده", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }



            }
            else
            {
                if (Convert.ToDecimal(txtPrice.Text) == 0)
                {
                    MessageBox.Show("السعر المحدد هو صفر ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                decimal num = 0;
                for (int i = 0; i <= DgvBuyDetalis.Rows.Count - 1; i++)
                {
                    if (Convert.ToString(DgvBuyDetalis.Rows[i].Cells[0].Value) == txtItemID.Text)
                        num += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[2].Value);
                }
                decimal count = 0;
                try
                {
                    count = Convert.ToDecimal(db.RunReader("select Item_Qty - (" + num + " + " + NudQty.Value + ") from Items where Item_ID=" + txtItemID.Text + "", "").Rows[0][0]);
                }
                catch (Exception) { }
                if (count < 0)
                {
                    MessageBox.Show("هذا المنتج لايوجد منه كميه كافيه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }

            }
            try
            {

                DataRow Row = tbl.NewRow();
                decimal d = NudDiscount.Value;
                Row[0] = txtItemID.Text;
                string Name = "";
                try
                {
                    Name = Convert.ToString(db.RunReader("select Item_Name from Items where Item_ID=" + txtItemID.Text + "", "").Rows[0][0]);
                }
                catch (Exception) { }
                if (cbxItems.Text == "اختر منتج")
                    Row[1] = Name;
                else
                    Row[1] = cbxItems.Text;

                Row[3] = txtPrice.Text;
                Row[2] = NudQty.Value;
                Row[4] = NudDiscount.Value;
                Row[5] = NudTax.Value;
                decimal tot = ((NudQty.Value * Convert.ToDecimal(txtPrice.Text) + NudTax.Value) - (d));
                Row[6] = Math.Round(tot, 2);

                tbl.Rows.Add(Row);
                DgvBuyDetalis.DataSource = tbl;
                }
            catch (Exception) { }
            double totWithoutTax = 0;
            double totTax = 0;
            double Sum2 = 0;
            for (int i = 0; i <= DgvBuyDetalis.Rows.Count - 1; i++)
            {
                Sum2 += Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[6].Value);
                totTax += Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[5].Value);
                totWithoutTax += (Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[2].Value) * Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[3].Value)) - Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[4].Value);
            }
            txtTotalWithtax.Text = Math.Round(Sum2, 2).ToString();
            txtTotal.Text = Math.Round(totWithoutTax, 2).ToString();
            txtTotalTax.Text = Math.Round(totTax, 2).ToString();
            NudQty.Value = 1;
            NudDiscount.Value = 0;
            textParcode.Clear();
            textParcode.Focus();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            decimal Sum = 0;
            int i;
            if (tbl.Rows.Count >= 1)
            {
                tbl.Rows.RemoveAt(DgvBuyDetalis.CurrentCell.RowIndex);
                Sum = 0;
                for (i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Sum += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[5].Value);
                }
            }
            else
            {
                Sum = 0;
                MessageBox.Show("لا يوجد بيانات لكى تتمكن من مسحها", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTotal.Text = Sum.ToString();
            textParcode.Clear();
            textParcode.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Customer frm = new Frm_Customer();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FillCustomer();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                decimal qtyOne = 0;

                try
                {
                    if (radioButton1.Checked == true)
                        qtyOne = Convert.ToDecimal(db.RunReader("select (Item_Price_Sale_Part) from items where Item_ID=" + txtItemID.Text + "", "").Rows[0][0]);
                    else if (radioButton2.Checked == true)
                        qtyOne = Convert.ToDecimal(db.RunReader("select (Item_Price_Sale) from items where Item_ID=" + txtItemID.Text + "", "").Rows[0][0]);

                }
                catch (Exception) { }
                txtPrice.Text = Math.Round(qtyOne, 2).ToString();

            }
            catch (Exception) { }
            textParcode.Clear();
            textParcode.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                decimal qtyOne = 0;

                try
                {
                    if (radioButton1.Checked == true)
                        qtyOne = Convert.ToDecimal(db.RunReader("select (Item_Price_Sale_Part) from items where Item_ID=" + txtItemID.Text + "", "").Rows[0][0]);
                    else if (radioButton2.Checked == true)
                        qtyOne = Convert.ToDecimal(db.RunReader("select (Item_Price_Sale) from items where Item_ID=" + txtItemID.Text + "", "").Rows[0][0]);

                }
                catch (Exception) { }
                txtPrice.Text = Math.Round(qtyOne, 2).ToString();

            }
            catch (Exception) { }
            textParcode.Clear();
            textParcode.Focus();

        }

        private void txtItemID_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                decimal qtyOne = 0;
                string type = "";
                try
                {
                    qtyOne = Convert.ToDecimal(db.RunReader("select (Item_Qty ) from items where Item_ID=" + txtItemID.Text + "", "").Rows[0][0]);
                    type = Convert.ToString(db.RunReader("select Item_Qty_Kelo from items where Item_ID=" + txtItemID.Text + "", "").Rows[0][0]);
                }
                catch (Exception) { }
              
            }
            catch (Exception) { }
            try
            {
                decimal buyOne = 0;

                try
                {
                    if (radioButton1.Checked == true)
                    {
                        buyOne = Convert.ToDecimal(db.RunReader("select (Item_Price_Sale_Part) from items where Item_ID=" + txtItemID.Text + "", "").Rows[0][0]);
                    }
                    else
                    {
                        buyOne = Convert.ToDecimal(db.RunReader("select (Item_Price_Sale) from items where Item_ID=" + txtItemID.Text + "", "").Rows[0][0]);
                    }
                }
                catch (Exception) { }
                txtPrice.Text = buyOne.ToString();

            }
            catch (Exception) { }
            textParcode.Clear();
            textParcode.Focus();

        }
        decimal taxes;
        private void cbxItems_SelectedIndexChanged_1(object sender, EventArgs e)
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
                txtPrice.Text = tblitems.Rows[0][6].ToString();
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

        private void NudQty_ValueChanged_1(object sender, EventArgs e)
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

                txtPrice.Text = tblitems.Rows[0][6].ToString();
                taxes = Convert.ToDecimal(tblitems.Rows[0][12]);
                def = (Convert.ToDecimal(txtPrice.Text) / 100) * taxes;
                NudTax.Value = def * NudQty.Value;
            }
            catch (Exception) { }




            try
            {
                if (NudQty.Value >= 100000)
                {
                    MessageBox.Show("من فضلك ادخل الباركود فى خانه الباركود", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NudQty.Value = 1;
                    return;
                }
            }
            catch (Exception) { }
            try
            {
                decimal d = NudDiscount.Value;
                decimal tot = (NudQty.Value * Convert.ToDecimal(txtPrice.Text) + (NudTax.Value)) - d;
                txtTootal.Text = Math.Round(tot, 2).ToString();
            }
            catch (Exception) { }
        }

        private void txtPrice_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtPrice.Text) >= 100000)
                {
                    MessageBox.Show("من فضلك ادخل الباركود فى خانه الباركود", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrice.Text = " 1";
                    return;
                }
            }
            catch (Exception) { }
            try
            {
                decimal d = NudDiscount.Value;
                decimal tot = (NudQty.Value * Convert.ToDecimal(txtPrice.Text) + (NudTax.Value)) - d;
                txtTootal.Text = Math.Round(tot, 2).ToString();
            }
            catch (Exception) { }
        }

        private void NudDiscount_ValueChanged_1(object sender, EventArgs e)
        {

            try
            {
                if (NudDiscount.Value >= 100000)
                {
                    MessageBox.Show("من فضلك ادخل الباركود فى خانه الباركود", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NudDiscount.Value = 0;
                    return;
                }
            }
            catch (Exception) { }


            try
            {
                decimal d = NudDiscount.Value;
                decimal tot = (NudQty.Value * Convert.ToDecimal(txtPrice.Text) + (NudTax.Value)) - d;
                txtTootal.Text = Math.Round(tot, 2).ToString();
            }
            catch (Exception) { }

            DataTable tblItem = new DataTable();
            try
            {
                decimal dis = 0;
                tblItem = db.RunReader("select Max_Discount from Items where Item_ID=" + cbxItems.SelectedValue + "", "");
                dis = Convert.ToDecimal(tblItem.Rows[0][0]);
                if (dis >= 1)
                {
                    if (Convert.ToDecimal(NudDiscount.Value) > dis)
                    {
                        MessageBox.Show("اعلى نسبه خصم مسموح بها لهذا الصنف هى  " + dis + "  جنيه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        NudDiscount.Value = dis;
                    }
                }
                else if (dis == 0)
                {
                    if (Convert.ToDecimal(NudDiscount.Value) > 0)
                    {
                        MessageBox.Show("هذا الصنف غير مسموح بعمل خصم له", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        NudDiscount.Value = 0;
                    }
                }
            }
            catch (Exception) { }
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            cbxCustname.Enabled = false;
            button1.Enabled = false;
            NudMadfo3.Enabled = false;

            textParcode.Clear();
            textParcode.Focus();
            DtbReminder.Enabled = false;
            rbtnPayPart.Enabled = false;
            rbtnPayKest.Enabled = false;
            NudIncreasing.Enabled = false;
            txtKestNumber.Enabled = false;
            groupBox5.Enabled = false;
        }

        private void rbtnPart_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Enabled = true;
            cbxCustname.Enabled = true;
            button1.Enabled = true;
            DtbReminder.Enabled = true;
            NudMadfo3.Enabled = true;
            textParcode.Clear();
            textParcode.Focus();
            rbtnPayPart.Enabled = true;
            rbtnPayKest.Enabled = true;
            NudIncreasing.Enabled = true;
            txtKestNumber.Enabled = true;
        }

        private void NudMadfo3_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (NudMadfo3.Value - Convert.ToDecimal(txtTotalWithtax.Text) == 0)
                    txtReport.Text = "الملبغ الباقى هو صفر...";
                else if (Convert.ToDecimal(txtTotalWithtax.Text) - NudMadfo3.Value > 0)
                    txtReport.Text = "الملبغ المتبقى علية هو " + (Convert.ToDecimal(txtTotalWithtax.Text) - NudMadfo3.Value).ToString();
                else
                    txtReport.Text = "الملبغ المتبقى له هو " + Math.Abs(Convert.ToDecimal(txtTotalWithtax.Text) - NudMadfo3.Value).ToString();
            }
            catch (Exception) { }
        }
        DataTable tblPar = new DataTable();
        private void textParcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tblPar.Clear();
                tblPar = db.RunReader("select * from Items where barcode='" + textParcode.Text + "'", "");
                if (tblPar.Rows.Count >= 1)
                {
                    try
                    {
                        cbxItems.SelectedValue = tblPar.Rows[0][0].ToString();
                        txtItemID.Text = (cbxItems.SelectedValue).ToString();
                    }
                    catch (Exception) { }
                    btnAdd_Click(null, null);
                    textParcode.Clear();
                    textParcode.Focus();
                }
                else
                {
                    textParcode.Clear();
                    textParcode.Focus();
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (DgvBuyDetalis.Rows.Count >= 1)
            {

                int stock_ID = Convert.ToInt32(Properties.Settings.Default.UserStock);
                string User = Properties.Settings.Default.UserName;
                string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
                string d2 = DtbReminder.Value.ToString("dd/MM/yyyy");
                if (rbtnPart.Checked == true)
                    db.RunNunQuary("insert into Sale values(" + txtSaleID.Text + ",'" + d + "'," + cbxCustname.SelectedValue + ",0)", "");
                else
                    db.RunNunQuary("insert into Sale values(" + txtSaleID.Text + ",'" + d + "',0,0)", "");

                for (int i = 0; i <= DgvBuyDetalis.Rows.Count - 1; i++)
                {
                    try
                    {
                        if (checkVisa.Checked == true)
                        {
                            if (rbtnPart.Checked == true)
                            {
                                db.RunNunQuary("insert into Sale_Detalis values(" + txtSaleID.Text + "," + DgvBuyDetalis.Rows[i].Cells[0].Value + "," + cbxCustname.SelectedValue + "," + DgvBuyDetalis.Rows[i].Cells[2].Value + "," + DgvBuyDetalis.Rows[i].Cells[3].Value + ",'" + d + "'," + DgvBuyDetalis.Rows[i].Cells[4].Value + "," + txtTotalWithtax.Text + "," + NudMadfo3.Value + "," + NudDiscountMoney.Value + ",0 ,N'" + User + "' ,'تم بيعه بالفيزا' ,'" + DtbTime.Text + "' , " + DgvBuyDetalis.Rows[i].Cells[5].Value + " ," + DgvBuyDetalis.Rows[i].Cells[6].Value + " , N'" + cbxSaleType.Text + "')", "");
                            }
                            else if (rbtnAll.Checked == true)
                            {
                                db.RunNunQuary("insert into Sale_Detalis values(" + txtSaleID.Text + "," + DgvBuyDetalis.Rows[i].Cells[0].Value + ",0," + DgvBuyDetalis.Rows[i].Cells[2].Value + "," + DgvBuyDetalis.Rows[i].Cells[3].Value + ",'" + d + "'," + DgvBuyDetalis.Rows[i].Cells[4].Value + "," + txtTotalWithtax.Text + "," + txtTotalWithtax.Text + "," + NudDiscountMoney.Value + ",0,N'" + User + "' ,'تم بيعه بالفيزا' ,'" + DtbTime.Text + "' , " + DgvBuyDetalis.Rows[i].Cells[5].Value + " ," + DgvBuyDetalis.Rows[i].Cells[6].Value + " , N'" + cbxSaleType.Text + "')", "");
                            }
                        }
                        else if (checkVisa.Checked == false)
                        {
                            if (rbtnPart.Checked == true)
                            {
                                db.RunNunQuary("insert into Sale_Detalis values(" + txtSaleID.Text + "," + DgvBuyDetalis.Rows[i].Cells[0].Value + "," + cbxCustname.SelectedValue + "," + DgvBuyDetalis.Rows[i].Cells[2].Value + "," + DgvBuyDetalis.Rows[i].Cells[3].Value + ",'" + d + "'," + DgvBuyDetalis.Rows[i].Cells[4].Value + "," + txtTotalWithtax.Text + "," + NudMadfo3.Value + "," + NudDiscountMoney.Value + ",0 ,N'" + User + "' ,'تم بيعه' ,'" + DtbTime.Text + "'  , " + DgvBuyDetalis.Rows[i].Cells[5].Value + " ," + DgvBuyDetalis.Rows[i].Cells[6].Value + " , N'" + cbxSaleType.Text + "')", "");
                            }
                            else if (rbtnAll.Checked == true)
                            {
                                db.RunNunQuary("insert into Sale_Detalis values(" + txtSaleID.Text + "," + DgvBuyDetalis.Rows[i].Cells[0].Value + ",0," + DgvBuyDetalis.Rows[i].Cells[2].Value + "," + DgvBuyDetalis.Rows[i].Cells[3].Value + ",'" + d + "'," + DgvBuyDetalis.Rows[i].Cells[4].Value + "," + txtTotalWithtax.Text + "," + txtTotalWithtax.Text + "," + NudDiscountMoney.Value + ",0,N'" + User + "' ,'تم بيعه' ,'" + DtbTime.Text + "'  , " + DgvBuyDetalis.Rows[i].Cells[5].Value + " ," + DgvBuyDetalis.Rows[i].Cells[6].Value + " , N'" + cbxSaleType.Text + "')", "");
                            }
                        }
                        db.RunNunQuary("update Items set Item_Qty =Item_Qty -(" + DgvBuyDetalis.Rows[i].Cells[2].Value + ") where Item_ID=" + DgvBuyDetalis.Rows[i].Cells[0].Value + "", "");
                    }
                    catch (Exception) { }
                }
                decimal num = 0;
                num = Convert.ToDecimal(txtTotal.Text) - NudMadfo3.Value;
                string dn = DtbReminder.Value.ToString("dd/MM/yyyy");
                if (rbtnPart.Checked == true)
                {

                    if (rbtnPayKest.Checked == true)
                    {
                        kestGood();
                    }
                    else if (rbtnPayPart.Checked == true)
                    {
                        if (Convert.ToDecimal(txtTotalWithtax.Text) - NudMadfo3.Value != 0)
                            db.RunNunQuary("insert into Customer_Money Values (" + txtSaleID.Text + "," + num + "," + cbxCustname.SelectedValue + ",'" + d + "' ,'" + d2 + "','مبيعات')", "");
                    }
                    if (NudMadfo3.Value >= 1)
                        db.RunNunQuary("insert into Customer_Report Values(" + txtSaleID.Text + " ,N'" + cbxCustname.Text + "'," + NudMadfo3.Value + ",N'" + d + "')", "");
                    if (checkVisa.Checked == false)
                    {
                        db.RunNunQuary("update Stock set Money=Money + " + NudMadfo3.Value + " where Stock_ID=" + Properties.Settings.Default.UserStock + "", "");
                        db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type ,Stock_ID) Values(" + NudMadfo3.Value + " ,'" + d + "' ,'بيع' ,'عملية بيع' ," + Properties.Settings.Default.UserStock + ")", "");
                    }
                    else if (checkVisa.Checked == true)
                    {
                        db.RunNunQuary("update Bank set Money=Money + " + NudMadfo3.Value + "", "");
                        db.RunNunQuary("insert into Bank_Insert  (Money ,Date,Name ,Type) Values(" + NudMadfo3.Value + " ,'" + d + "' ,'بيع' ,'عملية بيع')", "");

                    }
                    db.RunNunQuary("insert into Taxes_Report (Order_Type,Tax_Type,Date,Sup_Name,Cust_Name,Total_Price,Tax_Value,Total_WithTax ,Order_Num) Values ('فاتورة مبيعات','ضريبة قيمه مضافة','" + d + "' ,'' ,N'" + cbxCustname.Text + "' ," + txtTotal.Text + " ," + txtTotalTax.Text + " ," + txtTotalWithtax.Text + "," + txtSaleID.Text + ")", "");
                    tbl.Clear();
                    DgvBuyDetalis.DataSource = tbl;

                    AutoNum();
                    PrintDir();
                }
                else if (rbtnAll.Checked == true)
                {
                    db.RunNunQuary("insert into Customer_Report Values(" + txtSaleID.Text + " ,N'عميل مؤقت'," + txtTotalWithtax.Text + ",N'" + d + "')", "");
                    if (checkVisa.Checked == false)
                    {
                        db.RunNunQuary("update Stock set Money=Money + " + txtTotalWithtax.Text + " where Stock_ID=" + Properties.Settings.Default.UserStock + "", "");
                        db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type ,Stock_ID) Values(" + txtTotalWithtax.Text + " ,'" + d + "' ,'بيع' ,'عملية بيع' ," + Properties.Settings.Default.UserStock + ")", "");
                    }
                    else if (checkVisa.Checked == true)
                    {
                        db.RunNunQuary("update Bank set Money=Money + " + txtTotalWithtax.Text + "", "");
                        db.RunNunQuary("insert into Bank_Insert  (Money ,Date,Name ,Type) Values(" + txtTotalWithtax.Text + " ,'" + d + "' ,'بيع' ,'عملية بيع')", "");
                    }
                    db.RunNunQuary("insert into Taxes_Report (Order_Type,Tax_Type,Date,Sup_Name,Cust_Name,Total_Price,Tax_Value,Total_WithTax ,Order_Num) Values ('فاتورة مبيعات','ضريبة قيمه مضافة','" + d + "' ,'' ,'عميل نقدى' ," + txtTotal.Text + " ," + txtTotalTax.Text + " ," + txtTotalWithtax.Text + "," + txtSaleID.Text + ")", "");

                    tbl.Clear();
                    DgvBuyDetalis.DataSource = tbl;
                    AutoNum();
                    PrintWithOutDir();
                }


                textParcode.Clear();
                textParcode.Focus();
            }
            else
                MessageBox.Show("لا يوجد بيانات لكى تتمكن من حفظها", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtPrice.Text = "0";

        }

        private void kestGood()
        {

            string day = DtbFirstKest.Value.ToString("dd/MM/yyyy");
            DateTime olddate = DateTime.Parse(day);
            DateTime d;
            for (int i = 1; i <= Convert.ToDecimal(txtKestNumber.Text); i += 1)
            {
                d = Convert.ToDateTime(day).AddMonths(i);
                string s = d.ToShortDateString();
                string kestvalue = "";
                decimal baky = 0; decimal mony; decimal inc;
                baky = 0;
                if (NudIncreasing.Value == 0)
                {
                    baky = Convert.ToDecimal(txtTotalWithtax.Text) - NudMadfo3.Value;
                }
                else
                {
                    mony = Convert.ToDecimal(txtTotalWithtax.Text) - NudMadfo3.Value;
                    inc = (mony / 100) * (NudIncreasing.Value);

                    baky = inc + mony;
                }
                kestvalue = Math.Round((baky / Convert.ToDecimal(txtKestNumber.Text)), 1).ToString();

                db.RunNunQuary("insert into kest values(" + txtSaleID.Text + "," + cbxCustname.SelectedValue + ",N'قسط رقم  " + i + "'," + kestvalue + ",'" + s + "')", "");
            }
        }

        private void PrintDir()
        {
            try
            {
                decimal num = Convert.ToDecimal(txtSaleID.Text) - 1;
                DataTable tblRpt = new DataTable();
                tblRpt.Clear();
                int x = Convert.ToInt32(txtSaleID.Text) - 1;

                tblRpt = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Items.Item_Name as اسم_الصنف  ,[Qty]  as الكمية,[Price]  as السعر,[Date]  as التاريخ,[Qty] * [Price] as الاجمالى,(Total) as  الاجمالى_العام,Madfo3 as المدفوع,(Total) - (Madfo3)  as الباقى,Customer.Cust_Name as اسم_العميل,Discount_Total as  الخصم_العام,UserName as 'اسم المستخدم',Discount as 'خصم'  FROM [Sale_Detalis],Items,Customer  where Items.Item_ID=Sale_Detalis.Item_ID and Customer.Cust_ID=Sale_Detalis.Cust_ID and Sale_Detalis.Order_ID=" + num + "", "");

                Frm_Printing frm = new Frm_Printing();
                RptPrintOrder rpt = new RptPrintOrder();

                frm.crystalReportViewer1.RefreshReport();
                rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2"); rpt.SetDataSource(tblRpt);
                rpt.SetParameterValue("ID", num);
                rpt.SetParameterValue("Order", num);

                frm.crystalReportViewer1.ReportSource = rpt;
                System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                rpt.PrintToPrinter(1, true, 0, 0);
                //frm.ShowDialog();
            }
            catch (Exception) { }
        }
        private void Print()
        {
            try
            {
                decimal num = Convert.ToDecimal(txtSaleID.Text) - 1;
                DataTable tblRpt = new DataTable();
                tblRpt.Clear();
                int x = Convert.ToInt32(txtSaleID.Text) - 1;

                tblRpt = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Items.Item_Name as اسم_الصنف  ,[Qty]  as الكمية,[Price]  as السعر,[Date]  as التاريخ,[Qty] * [Price] as الاجمالى,(Total) as  الاجمالى_العام,Madfo3 as المدفوع,(Total) - (Madfo3)  as الباقى,Customer.Cust_Name as اسم_العميل,Discount_Total as  الخصم_العام ,UserName as 'اسم المستخدم',Discount as 'خصم' FROM [Sale_Detalis],Items,Customer  where Items.Item_ID=Sale_Detalis.Item_ID and Customer.Cust_ID=Sale_Detalis.Cust_ID and Sale_Detalis.Order_ID=" + num + "", "");

                Frm_Printing frm = new Frm_Printing();
                RptPrintOrder rpt = new RptPrintOrder();

                frm.crystalReportViewer1.RefreshReport();
                rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");
                rpt.SetDataSource(tblRpt);
                rpt.SetParameterValue("ID", num);
                rpt.SetParameterValue("Order", num);

                frm.crystalReportViewer1.ReportSource = rpt;
                //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                //rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                //rpt.PrintToPrinter(1, true, 0, 0);
                frm.ShowDialog();
            }
            catch (Exception) { }
        }
        private void PrintWithOutDir()
        {
            try
            {
                decimal num = Convert.ToDecimal(txtSaleID.Text) - 1;
                DataTable tblRpt = new DataTable();
                tblRpt.Clear();
                int x = Convert.ToInt32(txtSaleID.Text) - 1;
                tblRpt = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Items.Item_Name as اسم_الصنف,[Qty]  as الكمية,[Price]  as السعر,[Date]  as التاريخ,[Qty] * [Price] as الاجمالى,(Total) as  الاجمالى_العام ,Madfo3 as المدفوع,(Total) - (Madfo3)  as الباقى,Discount_Total as  الخصم_العام,UserName as 'اسم المستخدم',Discount as 'خصم' FROM [Sale_Detalis],Items  where Items.Item_ID=Sale_Detalis.Item_ID  and Sale_Detalis.Order_ID=" + num + "", "");
                Frm_Printing frm = new Frm_Printing();
                RptPrintOrderWithOutClient rpt = new RptPrintOrderWithOutClient();

                frm.crystalReportViewer1.RefreshReport();
                rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2"); rpt.SetDataSource(tblRpt);
                rpt.SetParameterValue("ID", num);
                // rpt.SetParameterValue("Order", num);

                frm.crystalReportViewer1.ReportSource = rpt;
                System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                rpt.PrintToPrinter(1, true, 0, 0);
                //frm.ShowDialog();
            }
            catch (Exception) { }
        }
        private void PrintWithOut()
        {
            try
            {
                decimal num = Convert.ToDecimal(txtSaleID.Text) - 1;
                DataTable tblRpt = new DataTable();
                tblRpt.Clear();
                int x = Convert.ToInt32(txtSaleID.Text) - 1;
                tblRpt = db.RunReader("SELECT [Order_ID] as رقم_الفاتورة,Items.Item_Name as اسم_الصنف,[Qty]  as الكمية,[Price]  as السعر,[Date]  as التاريخ,[Qty] * [Price] as الاجمالى,(Total) as  الاجمالى_العام ,Madfo3 as المدفوع,(Total) - (Madfo3)  as الباقى ,Discount_Total as  الخصم_العام,UserName as 'اسم المستخدم',Discount as 'خصم' FROM [Sale_Detalis],Items  where Items.Item_ID=Sale_Detalis.Item_ID  and Sale_Detalis.Order_ID=" + num + "", "");
                Frm_Printing frm = new Frm_Printing();
                RptPrintOrderWithOutClient rpt = new RptPrintOrderWithOutClient();

                frm.crystalReportViewer1.RefreshReport();
                rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");
                rpt.SetDataSource(tblRpt);
                rpt.SetParameterValue("ID", num);
                // rpt.SetParameterValue("Order", num);

                frm.crystalReportViewer1.ReportSource = rpt;
                //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                //rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                //rpt.PrintToPrinter(1, true, 0, 0);
                frm.ShowDialog();
            }
            catch (Exception) { }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (DgvBuyDetalis.Rows.Count >= 1)
            {

                int stock_ID =Convert.ToInt32( Properties.Settings.Default.UserStock );
                string User = Properties.Settings.Default.UserName;
                string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
                string d2 = DtbReminder.Value.ToString("dd/MM/yyyy");
                if (rbtnPart.Checked == true)
                    db.RunNunQuary("insert into Sale values(" + txtSaleID.Text + ",'" + d + "'," + cbxCustname.SelectedValue + ",0)", "");
                else
                    db.RunNunQuary("insert into Sale values(" + txtSaleID.Text + ",'" + d + "',0,0)", "");

                for (int i = 0; i <= DgvBuyDetalis.Rows.Count - 1; i++)
                {
                    try
                    {
                        if (checkVisa.Checked == true)
                        {
                            if (rbtnPart.Checked == true)
                            {
                                db.RunNunQuary("insert into Sale_Detalis values(" + txtSaleID.Text + "," + DgvBuyDetalis.Rows[i].Cells[0].Value + "," + cbxCustname.SelectedValue + "," + DgvBuyDetalis.Rows[i].Cells[2].Value + "," + DgvBuyDetalis.Rows[i].Cells[3].Value + ",'" + d + "'," + DgvBuyDetalis.Rows[i].Cells[4].Value + "," + txtTotalWithtax.Text + "," + NudMadfo3.Value + "," + NudDiscountMoney.Value + ",0 ,N'" + User + "' ,'تم بيعه بالفيزا' ,'" + DtbTime.Text + "' , " + DgvBuyDetalis.Rows[i].Cells[5].Value + " ," + DgvBuyDetalis.Rows[i].Cells[6].Value + " , N'" + cbxSaleType.Text + "')", "");
                            }
                            else if (rbtnAll.Checked == true)
                            {
                                db.RunNunQuary("insert into Sale_Detalis values(" + txtSaleID.Text + "," + DgvBuyDetalis.Rows[i].Cells[0].Value + ",0," + DgvBuyDetalis.Rows[i].Cells[2].Value + "," + DgvBuyDetalis.Rows[i].Cells[3].Value + ",'" + d + "'," + DgvBuyDetalis.Rows[i].Cells[4].Value + "," + txtTotalWithtax.Text + ","+ txtTotalWithtax .Text+ "," + NudDiscountMoney.Value + ",0,N'" + User + "' ,'تم بيعه بالفيزا' ,'" + DtbTime.Text + "' , " + DgvBuyDetalis.Rows[i].Cells[5].Value + " ," + DgvBuyDetalis.Rows[i].Cells[6].Value + " , N'" + cbxSaleType.Text + "')", "");
                            }
                        }
                        else if (checkVisa.Checked == false)
                        {
                            if (rbtnPart.Checked == true)
                            {
                                db.RunNunQuary("insert into Sale_Detalis values(" + txtSaleID.Text + "," + DgvBuyDetalis.Rows[i].Cells[0].Value + "," + cbxCustname.SelectedValue + "," + DgvBuyDetalis.Rows[i].Cells[2].Value + "," + DgvBuyDetalis.Rows[i].Cells[3].Value + ",'" + d + "'," + DgvBuyDetalis.Rows[i].Cells[4].Value + "," + txtTotalWithtax.Text + "," + NudMadfo3.Value + "," + NudDiscountMoney.Value + ",0 ,N'" + User + "' ,'تم بيعه' ,'" + DtbTime.Text + "'  , " + DgvBuyDetalis.Rows[i].Cells[5].Value + " ," + DgvBuyDetalis.Rows[i].Cells[6].Value + " , N'" + cbxSaleType.Text + "')", "");
                            }
                            else if (rbtnAll.Checked == true)
                            {
                                db.RunNunQuary("insert into Sale_Detalis values(" + txtSaleID.Text + "," + DgvBuyDetalis.Rows[i].Cells[0].Value + ",0," + DgvBuyDetalis.Rows[i].Cells[2].Value + "," + DgvBuyDetalis.Rows[i].Cells[3].Value + ",'" + d + "'," + DgvBuyDetalis.Rows[i].Cells[4].Value + "," + txtTotalWithtax.Text + "," + txtTotalWithtax.Text + "," + NudDiscountMoney.Value + ",0,N'" + User + "' ,'تم بيعه' ,'" + DtbTime.Text + "'  , " + DgvBuyDetalis.Rows[i].Cells[5].Value + " ," + DgvBuyDetalis.Rows[i].Cells[6].Value + " , N'" + cbxSaleType.Text + "')", "");
                            }
                        }
                        db.RunNunQuary("update Items set Item_Qty =Item_Qty -(" + DgvBuyDetalis.Rows[i].Cells[2].Value + ") where Item_ID=" + DgvBuyDetalis.Rows[i].Cells[0].Value + "", "");
                    }
                    catch (Exception) { }
                }
                decimal num = 0;
                num = Convert.ToDecimal(txtTotal.Text) - NudMadfo3.Value;
                string dn = DtbReminder.Value.ToString("dd/MM/yyyy");
                if (rbtnPart.Checked == true)
                {

                    if (rbtnPayKest.Checked == true)
                    {
                        kestGood();
                    }
                    else if (rbtnPayPart.Checked == true)
                    {
                        if (Convert.ToDecimal(txtTotalWithtax.Text) - NudMadfo3.Value != 0)
                            db.RunNunQuary("insert into Customer_Money Values (" + txtSaleID.Text + "," + num + "," + cbxCustname.SelectedValue + ",'" + d + "' ,'" + d2 + "','مبيعات')", "");
                    }
                    if (NudMadfo3.Value >= 1)
                        db.RunNunQuary("insert into Customer_Report Values(" + txtSaleID.Text + " ,N'" + cbxCustname.Text + "'," + NudMadfo3.Value + ",N'" + d + "')", "");
                    if (checkVisa.Checked == false)
                    {
                        db.RunNunQuary("update Stock set Money=Money + " + NudMadfo3.Value + " where Stock_ID=" + Properties.Settings.Default.UserStock + "", "");
                        db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type ,Stock_ID) Values(" + NudMadfo3.Value + " ,'" + d + "' ,'بيع' ,'عملية بيع' ," + Properties.Settings.Default.UserStock + ")", "");
                    }
                    else if (checkVisa.Checked == true)
                    {
                        db.RunNunQuary("update Bank set Money=Money + " + NudMadfo3.Value + "", "");
                        db.RunNunQuary("insert into Bank_Insert  (Money ,Date,Name ,Type) Values(" + NudMadfo3.Value + " ,'" + d + "' ,'بيع' ,'عملية بيع')", "");

                    }
                    db.RunNunQuary("insert into Taxes_Report (Order_Type,Tax_Type,Date,Sup_Name,Cust_Name,Total_Price,Tax_Value,Total_WithTax ,Order_Num) Values ('فاتورة مبيعات','ضريبة قيمه مضافة','" + d + "' ,'' ,N'" + cbxCustname.Text + "' ," + txtTotal.Text + " ," + txtTotalTax.Text + " ," + txtTotalWithtax.Text + "," + txtSaleID.Text + ")", "");
                    tbl.Clear();
                    DgvBuyDetalis.DataSource = tbl;

                    AutoNum();
                    Print();
                }
                else if (rbtnAll.Checked == true)
                {
                    db.RunNunQuary("insert into Customer_Report Values(" + txtSaleID.Text + " ,N'عميل مؤقت'," + txtTotalWithtax.Text + ",N'" + d + "')", "");
                    if (checkVisa.Checked == false)
                    {
                        db.RunNunQuary("update Stock set Money=Money + " + txtTotalWithtax.Text + " where Stock_ID=" + Properties.Settings.Default.UserStock + "", "");
                        db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type ,Stock_ID) Values(" + txtTotalWithtax.Text + " ,'" + d + "' ,'بيع' ,'عملية بيع' ," + Properties.Settings.Default.UserStock + ")", "");
                    }
                    else if (checkVisa.Checked == true)
                    {
                        db.RunNunQuary("update Bank set Money=Money + " + txtTotalWithtax.Text + "", "");
                        db.RunNunQuary("insert into Bank_Insert  (Money ,Date,Name ,Type) Values(" + txtTotalWithtax.Text + " ,'" + d + "' ,'بيع' ,'عملية بيع')", "");
                    }
                    db.RunNunQuary("insert into Taxes_Report (Order_Type,Tax_Type,Date,Sup_Name,Cust_Name,Total_Price,Tax_Value,Total_WithTax ,Order_Num) Values ('فاتورة مبيعات','ضريبة قيمه مضافة','" + d + "' ,'' ,'عميل نقدى' ," + txtTotal.Text + " ," + txtTotalTax.Text + " ," + txtTotalWithtax.Text + "," + txtSaleID.Text + ")", "");

                    tbl.Clear();
                    DgvBuyDetalis.DataSource = tbl;
                    AutoNum();
                     PrintWithOut();
                }


                textParcode.Clear();
                textParcode.Focus();
            }
            else
                MessageBox.Show("لا يوجد بيانات لكى تتمكن من حفظها", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtPrice.Text = "0";

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
                    totDicount = dis * Convert.ToDecimal(DgvBuyDetalis.CurrentRow.Cells[2].Value);
                }
                catch (Exception) { }
                if (dis >= 1)
                {
                    if (Convert.ToDecimal(DgvBuyDetalis.CurrentRow.Cells[4].Value) > totDicount)
                    {
                        MessageBox.Show("اعلى نسبه خصم مسموح بها للقطعه الواحده من هذا الصنف هى  " + dis + "  جنيه" + " ولاجمالى هذه القطع" + totDicount + " جنيه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DgvBuyDetalis.CurrentRow.Cells[4].Value = totDicount;
                    }
                }
                else if (dis == 0)
                {
                    if (Convert.ToDecimal(DgvBuyDetalis.CurrentRow.Cells[4].Value) > 0)
                    {
                        MessageBox.Show("هذا الصنف غير مسموح بعمل خصم له", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DgvBuyDetalis.CurrentRow.Cells[4].Value = 0;
                    }
                }
            }
            catch (Exception) { }
        }
        private void DgvBuyDetalis_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal Sum = 0;
            if (DgvBuyDetalis.Rows.Count >= 1)
            {
                CheckDiscount(Convert.ToInt32(DgvBuyDetalis.CurrentRow.Cells[0].Value));


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

                try
                {
                    decimal d = Convert.ToDecimal(DgvBuyDetalis.CurrentRow.Cells[4].Value);
                    DgvBuyDetalis.CurrentRow.Cells[6].Value = (Convert.ToDecimal(DgvBuyDetalis.CurrentRow.Cells[2].Value) * Convert.ToDecimal(DgvBuyDetalis.CurrentRow.Cells[3].Value) + Convert.ToDecimal(DgvBuyDetalis.CurrentRow.Cells[5].Value)) - d;
                }
                catch (Exception) { }
                decimal SUM2 = 0; double totTax = 0, totWithoutTax = 0;
                for (int i = 0; i <= DgvBuyDetalis.Rows.Count - 1; i++)
                {
                    SUM2 += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[6].Value);
                    totTax += Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[5].Value);
                    totWithoutTax += (Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[2].Value) * Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[3].Value)) - Convert.ToDouble(DgvBuyDetalis.Rows[i].Cells[4].Value);

                }
                txtTotalWithtax.Text = Math.Round(SUM2).ToString();
                txtTotal.Text = Math.Round(totWithoutTax, 2).ToString();
                txtTotalTax.Text = Math.Round(totTax, 2).ToString();


                decimal price = Price(Convert.ToInt32(DgvBuyDetalis.CurrentRow.Cells[0].Value));
                if (Convert.ToDecimal(DgvBuyDetalis.CurrentRow.Cells[3].Value) < price)
                {
                    MessageBox.Show("السعر المحدد اقل من سعر الشراء لهذا المنتج :)", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }


                textParcode.Clear();
                textParcode.Focus();


            }
        }

        private decimal Price(int ID)
        {
            decimal pricenow = 0; try
            {
                pricenow = Convert.ToDecimal(db.RunReader("select Item_Price from Items where Item_ID=" + ID + "", "").Rows[0][0]);
            }
            catch (Exception) { }
            return pricenow;
        }
    }
}
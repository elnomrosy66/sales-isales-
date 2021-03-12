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
    public partial class Frm_Items : DevExpress.XtraEditors.XtraForm
    {
        private static Frm_Items frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_Items GetMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_Items();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public Frm_Items()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        int introw = 0;
        public void AutoNum()
        {
            tbl.Clear();
            tbl = db.RunReader("Select Max(Item_ID) from Items", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
                txtItemID.Text = "1";
            else
                txtItemID.Text = (Convert.ToInt32(tbl.Rows[0][0].ToString()) + 1).ToString();
           
            NudQty.Value = 0;
            NudSale.Value = 1;
            NudPricePart.Value = 1;
            NudMin.Value = 0;
            NudMaxDisount.Value = 0;
            txtItemName.Clear();
            txtPriceTaxes.Text = "0";
            NudTaxes.Value = 5;
            cbxUnitBuy.SelectedIndex = 0;
            cbxUnitSales.SelectedIndex = 0;
            chekFavorate.Checked = false;
            chekExperid.Checked = false;
            if (Properties.Settings.Default.CkeckTaxes == true) { checkTax.Checked = true; } else { checkTax.Checked = false; }
            txtBarcode.Clear();
            DgvStoreQty.Rows.Clear();
            DgvUnit.Rows.Clear();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
        }
        private void showData()
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Items", "");
            if ((tbl.Rows.Count <= 0))
            {
                MessageBox.Show("لا يوجد بيانات فى هذه الشاشة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    txtItemID.Text = tbl.Rows[introw][0].ToString();
                    txtItemName.Text = tbl.Rows[introw][1].ToString();
                }
                catch (Exception) { }
                try
                {
                    NudQty.Value = Convert.ToDecimal(tbl.Rows[introw][2]);
                    NudSale.Value = Convert.ToDecimal(tbl.Rows[introw][3]);
                    NudPricePart.Value = Convert.ToDecimal(tbl.Rows[introw][5]);
                    NudMin.Value = Convert.ToDecimal(tbl.Rows[introw][6]);
                   
                }
                catch (Exception) { }
                try{
                txtBarcode.Text = tbl.Rows[introw][4].ToString();
                NudMaxDisount.Value = Convert.ToDecimal(tbl.Rows[introw][7]);
                cbxGroups.SelectedValue = Convert.ToInt16(tbl.Rows[introw][8]);
                }
                catch (Exception) { }
                string IS_Tax ="";
                int FAV = 0;
                try{
                IS_Tax = Convert.ToString(tbl.Rows[introw][9]);
                }
                catch (Exception) { }
                try
                {
                    FAV = Convert.ToInt32(tbl.Rows[introw][18]);
                } catch (Exception) { }
                if (FAV == 1)
                {
                    chekFavorate.Checked = true;
                }
                else
                {
                    chekFavorate.Checked = false;
                }
               int experid = 0;
                try
                {
                    experid = Convert.ToInt32(tbl.Rows[introw][19]);
                }
                catch (Exception) { }
                if (experid == 1)
                {
                    chekExperid.Checked = true;
                }
                else
                {
                    chekExperid.Checked = false;
                }
                if (IS_Tax == "خاضع للضريبة")
                {
                    checkTax.Checked = true;
                    NudTaxes.Value = Convert.ToDecimal(tbl.Rows[introw][10]);
                }
                else
                {
                    checkTax.Checked = false;
                    NudTaxes.Value = 0;
                }
                try{
                txtPriceTaxes.Text = tbl.Rows[introw][11].ToString();
                cbxMainUnit.SelectedValue =Convert.ToDecimal( tbl.Rows[introw][13] );
                cbxUnitSales.SelectedValue = Convert.ToDecimal(tbl.Rows[introw][14]);
                cbxUnitBuy.SelectedValue = Convert.ToDecimal(tbl.Rows[introw][16]);
                }
                catch (Exception) { }
                DataTable tblDates = new DataTable();
                tblDates.Clear();
                DgvStoreQty.Rows.Clear();
             
                tblDates = db.RunReader("select * from Items_Qty where Item_ID=" + txtItemID.Text + "", "");
                foreach (DataRow Row in tblDates.Rows)
                {
                    DgvStoreQty.Rows.Add(1);
                    int rowindex = DgvStoreQty.Rows.Count - 1;
                    try
                    {
                        DgvStoreQty.Rows[rowindex].Cells[0].Value = Row[2];
                        DgvStoreQty.Rows[rowindex].Cells[1].Value = Row[3];
                        DgvStoreQty.Rows[rowindex].Cells[2].Value = Row[4];
                        DgvStoreQty.Rows[rowindex].Cells[3].Value = Row[6];
                    }
                    catch (Exception) { }
                }

                DataTable tblUint = new DataTable();
                tblUint.Clear();
                DgvUnit.Rows.Clear();
                tblUint = db.RunReader("select * from Items_Unit where Item_ID=" + txtItemID.Text + "", "");
                foreach (DataRow Row in tblUint.Rows)
                {
                    DgvUnit.Rows.Add(1);
                    int rowindex = DgvUnit.Rows.Count - 1;
                    try
                    {
                        DgvUnit.Rows[rowindex].Cells[0].Value = Row[2];
                        DgvUnit.Rows[rowindex].Cells[1].Value = Row[3];
                        DgvUnit.Rows[rowindex].Cells[2].Value = Row[4];
                    }
                    catch (Exception) { }
                }

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
            }
        }
        public void FillGroups() {
            cbxGroups.DataSource = db.RunReader("select * from Items_Group", "");
            cbxGroups.DisplayMember = "G_Name";
            cbxGroups.ValueMember = "G_ID";
        }
        public void FillUnit() {

            cbxMainUnit.DataSource = db.RunReader("select * from Unit", "");
            cbxMainUnit.DisplayMember = "Unit_Name";
            cbxMainUnit.ValueMember = "Unit_ID";
        }
        public void FillSale()
        {

            cbxUnitSales.DataSource = db.RunReader("select * from Unit", "");
            cbxUnitSales.DisplayMember = "Unit_Name";
            cbxUnitSales.ValueMember = "Unit_ID";
        }
        public void FillBuy()
        {

            cbxUnitBuy.DataSource = db.RunReader("select * from Unit", "");
            cbxUnitBuy.DisplayMember = "Unit_Name";
            cbxUnitBuy.ValueMember = "Unit_ID";
        }
        private void Frm_Items_Load(object sender, EventArgs e)
        {
            try
            {




                comboBox1.DataSource = db.RunReader("select * from Items", "");
                comboBox1.ValueMember = "Item_ID";
                comboBox1.DisplayMember = "Item_Name";


                
                cbxStore.DataSource = db.RunReader("select * from Store", "");
                cbxStore.DisplayMember = "Store_Name";
                cbxStore.ValueMember = "Store_ID";

                cbxUnit.DataSource = db.RunReader("select * from Unit", "");
                cbxUnit.DisplayMember = "Unit_Name";
                cbxUnit.ValueMember = "Unit_ID";
                
                FillGroups();
                FillUnit();

                FillSale();
                FillBuy();
                AutoNum();
                if (Properties.Settings.Default.ItemID != 0)
                {
                    search(Properties.Settings.Default.ItemID);
                }
            }
            catch (Exception) { }
            if (Properties.Settings.Default.CkeckTaxes == true) { checkTax.Checked = true; } else { checkTax.Checked = false; }
        }


        private void search(int num)
        {
            DataTable tblSearch = new DataTable();
            tblSearch.Clear();

            tblSearch = db.RunReader("select * from Items where Item_ID=" + num + " ", "");

            if ((tblSearch.Rows.Count <= 0))
                {
                }
                else
                {


                    txtItemID.Text = tblSearch.Rows[0][0].ToString();
                    txtItemName.Text = tblSearch.Rows[0][1].ToString();
                    try
                    {
                        NudQty.Value = Convert.ToDecimal(tblSearch.Rows[0][2]);
                        NudSale.Value = Convert.ToDecimal(tblSearch.Rows[0][3]);
                        NudPricePart.Value = Convert.ToDecimal(tblSearch.Rows[0][5]);
                        NudMin.Value = Convert.ToDecimal(tblSearch.Rows[0][6]);

                    }
                    catch (Exception) { }

                    txtBarcode.Text = tblSearch.Rows[0][4].ToString();
                    NudMaxDisount.Value = Convert.ToDecimal(tblSearch.Rows[0][7]);
                    cbxGroups.SelectedValue = Convert.ToInt16(tblSearch.Rows[0][8]);
                    string IS_Tax = Convert.ToString(tblSearch.Rows[0][9]);
                    if (IS_Tax == "خاضع للضريبة")
                    {
                        checkTax.Checked = true;
                        NudTaxes.Value = Convert.ToDecimal(tblSearch.Rows[0][10]);
                    }
                    else
                    {
                        checkTax.Checked = false;
                        NudTaxes.Value = 0;
                    }
                    txtPriceTaxes.Text = tblSearch.Rows[0][11].ToString();
                    cbxMainUnit.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][13]);

                    cbxUnitSales.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][14]);
                    cbxUnitBuy.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][16]);
                    DataTable tblDates = new DataTable();
                    tblDates.Clear();
                    DgvStoreQty.Rows.Clear();

                    tblDates = db.RunReader("select * from Items_Qty where Item_ID=" + txtItemID.Text + "", "");
                    foreach (DataRow Row in tblDates.Rows)
                    {
                        DgvStoreQty.Rows.Add(1);
                        int rowindex = DgvStoreQty.Rows.Count - 1;
                        DgvStoreQty.Rows[rowindex].Cells[0].Value = Row[2];
                        DgvStoreQty.Rows[rowindex].Cells[1].Value = Row[3];
                        DgvStoreQty.Rows[rowindex].Cells[2].Value = Row[4];
                    }

                    DataTable tblUint = new DataTable();
                    tblUint.Clear();
                    DgvUnit.Rows.Clear();
                    tblUint = db.RunReader("select * from Items_Unit where Item_ID=" + txtItemID.Text + "", "");
                    foreach (DataRow Row in tblUint.Rows)
                    {
                        DgvUnit.Rows.Add(1);
                        int rowindex = DgvUnit.Rows.Count - 1;
                        DgvUnit.Rows[rowindex].Cells[0].Value = Row[2];
                        DgvUnit.Rows[rowindex].Cells[1].Value = Row[3];
                        DgvUnit.Rows[rowindex].Cells[2].Value = Row[4];
                    }

                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDeleteAll.Enabled = true;

                
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Print_Barcode frm = new Print_Barcode();

            tbl.Clear();
            tbl = db.RunReader("select * from TestData", "");

            if (tbl.Rows.Count <= 0)
            {
                db.RunNunQuary("INSERT INTO [TestData] VALUES('kkkkkk','5562','52562',1)", "");

            }
            if (txtItemName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المنتج", "");
                return;
            }
            db.RunNunQuary("update TestData set Name=N'" + txtItemName.Text + "' ,barcode=N'" + txtBarcode.Text + "',price=N'" + txtPriceTaxes.Text + "',ID=" + txtItemID.Text + "", "");

            frm.ShowDialog();
        }

        private void NudTaxes_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal taxVal = 0;
                taxVal = NudTaxes.Value;
                decimal saleValu = 0;
                saleValu = NudPricePart.Value;
                decimal tax = 0;
                tax = (saleValu / 100) * taxVal;
                if (checkTax.Checked == true)
                {

                    txtPriceTaxes.Text = (saleValu + tax).ToString();
                }
                else
                {
                    txtPriceTaxes.Text = (saleValu ).ToString();
                }

            }
            catch (Exception) { }
        }

        private void checkTax_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTax.Checked == true)
            {
                NudTaxes.Value = 5;
            }
            else { NudTaxes.Value = 0; }
        }

        private void NudPricePart_ValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (NudSale.Value > NudPricePart.Value)
            //    {
            //        MessageBox.Show("لا يمكن ان يكون سعر الجمله اكبر من سعر التجزئه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }
            //}
            //catch (Exception) { }
            try
            {
                decimal taxVal = 0;
                taxVal = NudTaxes.Value;
                decimal saleValu = 0;
                saleValu = NudPricePart.Value;
                decimal tax = 0;
                tax = (saleValu / 100) * taxVal;
                if (checkTax.Checked == true)
                {

                    txtPriceTaxes.Text = (saleValu + tax).ToString();
                    NudSale.Value = NudPricePart.Value;
                }
                else {
                    txtPriceTaxes.Text = (saleValu ).ToString();
                    NudSale.Value = NudPricePart.Value;
                }
                

            }
            catch (Exception) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Items_Group frm = new Frm_Items_Group();
            frm.ShowDialog();
        }

        private void Frm_Items_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                tbl = db.RunReader("SELECT [Item_ID] as ' مسلسل',[Item_Name] as 'اسم المنتج',[Item_Qty] as 'الكمية',[Main_Unit] as 'الوحدة',[Item_Price_Sale] as 'سعر بيع الجمله',[Item_Price_Sale_Part] as 'سعر بيع التجزئه',[Tax_Value] as 'قيمة الضريبة المضافه',[Price_Tax] as 'سعر التجزئه بعد الضريبة',[Barcode] as 'الباركود',[Item_Min] as 'حد الطلب',Items_Group .G_Name as 'التصنيف',[IS_Tax] as 'خاضع للضريبة ام لا',[Max_Discount] as 'اقصى خصم مسموح' FROM [Items] ,Items_Group where Items_Group.G_ID=Items.G_ID", "");
                Frm_Items_View.GetMainForm.DgvBuyDetalis.DataSource = tbl;
                Frm_Items_View.GetMainForm.FillGroups();
                Properties.Settings.Default.ItemID = 0;
                Properties.Settings.Default.Save();
                Frm_Items_View.GetMainForm.Frm_Items_View_Load(null,null);
            }
            catch (Exception) { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count >= 1)
            {
                DataTable tblSearch = new DataTable();
                tblSearch.Clear();
                if (comboBox1.SelectedIndex == 0)
                    tblSearch = db.RunReader("select * from Items where Item_ID=" + comboBox1.SelectedValue + " ", "");
                else
                    tblSearch = db.RunReader("select * from Items where Item_ID=" + comboBox1.SelectedValue + " ", "");

                if ((tblSearch.Rows.Count <= 0))
                {
                }
                else
                {
                    
                        
                           txtItemID.Text = tblSearch.Rows[0][0].ToString();
                txtItemName.Text = tblSearch.Rows[0][1].ToString();
                try
                {
                    NudQty.Value = Convert.ToDecimal(tblSearch.Rows[0][2]);
                    NudSale.Value = Convert.ToDecimal(tblSearch.Rows[0][3]);
                    NudPricePart.Value = Convert.ToDecimal(tblSearch.Rows[0][5]);
                    NudMin.Value = Convert.ToDecimal(tblSearch.Rows[0][6]);
                   
                }
                catch (Exception) { }

                txtBarcode.Text = tblSearch.Rows[0][4].ToString();
                NudMaxDisount.Value = Convert.ToDecimal(tblSearch.Rows[0][7]);
                cbxGroups.SelectedValue = Convert.ToInt16(tblSearch.Rows[0][8]);
                string IS_Tax = Convert.ToString(tblSearch.Rows[0][9]);
                if (IS_Tax == "خاضع للضريبة")
                {
                    checkTax.Checked = true;
                    NudTaxes.Value = Convert.ToDecimal(tblSearch.Rows[0][10]);
                }
                else
                {
                    checkTax.Checked = false;
                    NudTaxes.Value = 0;
                }

                    int FAV = 0;
                    try
                    {
                        FAV = Convert.ToInt32(tblSearch.Rows[0][18]);
                    }
                    catch (Exception) { }
                    if (FAV == 1)
                    {
                        chekFavorate.Checked = true;
                    }
                    else
                    {
                        chekFavorate.Checked = false;
                    }

                    int experid = 0;
                    try
                    {
                        experid = Convert.ToInt32(tblSearch.Rows[0][19]);
                    }
                    catch (Exception) { }
                    if (experid == 1)
                    {
                        chekExperid.Checked = true;
                    }
                    else
                    {
                        chekExperid.Checked = false;
                    }
                    txtPriceTaxes.Text = tblSearch.Rows[0][11].ToString();
                cbxMainUnit.SelectedValue =Convert.ToDecimal( tblSearch.Rows[0][13] );

                cbxUnitSales.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][14]);
                cbxUnitBuy.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][16]);
                    DataTable tblDates = new DataTable();
                    tblDates.Clear();
                    DgvStoreQty.Rows.Clear();

                    tblDates = db.RunReader("select * from Items_Qty where Item_ID=" + txtItemID.Text + "", "");
                    foreach (DataRow Row in tblDates.Rows)
                    {
                        DgvStoreQty.Rows.Add(1);
                        int rowindex = DgvStoreQty.Rows.Count - 1;
                        DgvStoreQty.Rows[rowindex].Cells[0].Value = Row[2];
                        DgvStoreQty.Rows[rowindex].Cells[1].Value = Row[3];
                        DgvStoreQty.Rows[rowindex].Cells[2].Value = Row[4];
                        DgvStoreQty.Rows[rowindex].Cells[3].Value = Row[6];
                    }

                    DataTable tblUint = new DataTable();
                    tblUint.Clear();
                    DgvUnit.Rows.Clear();
                    tblUint = db.RunReader("select * from Items_Unit where Item_ID=" + txtItemID.Text + "", "");
                    foreach (DataRow Row in tblUint.Rows)
                    {
                        DgvUnit.Rows.Add(1);
                        int rowindex = DgvUnit.Rows.Count - 1;
                        DgvUnit.Rows[rowindex].Cells[0].Value = Row[2];
                        DgvUnit.Rows[rowindex].Cells[1].Value = Row[3];
                        DgvUnit.Rows[rowindex].Cells[2].Value = Row[4];
                    }

                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDeleteAll.Enabled = true;
               
            }
        }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                DataTable tblSearch = new DataTable();
                tblSearch.Clear();

                tblSearch = db.RunReader("select * from Items where Item_Name Like N'%" + txtSearch.Text + "%' ", "");

                if ((tblSearch.Rows.Count <= 0))
                {
                    MessageBox.Show("لا يوجد منتج بهذا الاسم","تاكيد",MessageBoxButtons.OK ,MessageBoxIcon.Information);
                    return;
                }
                else
                {


                    txtItemID.Text = tblSearch.Rows[0][0].ToString();
                    txtItemName.Text = tblSearch.Rows[0][1].ToString();
                    try
                    {
                        NudQty.Value = Convert.ToDecimal(tblSearch.Rows[0][2]);
                        NudSale.Value = Convert.ToDecimal(tblSearch.Rows[0][3]);
                        NudPricePart.Value = Convert.ToDecimal(tblSearch.Rows[0][5]);
                        NudMin.Value = Convert.ToDecimal(tblSearch.Rows[0][6]);

                    }
                    catch (Exception) { }

                    txtBarcode.Text = tblSearch.Rows[0][4].ToString();
                    NudMaxDisount.Value = Convert.ToDecimal(tblSearch.Rows[0][7]);
                    cbxGroups.SelectedValue = Convert.ToInt16(tblSearch.Rows[0][8]);
                    string IS_Tax = Convert.ToString(tblSearch.Rows[0][9]);
                    int FAV = 0;
                    try
                    {
                        FAV = Convert.ToInt32(tblSearch.Rows[0][18]);
                    }
                    catch (Exception) { }
                    if (FAV == 1)
                    {
                        chekFavorate.Checked = true;
                    }
                    else
                    {
                        chekFavorate.Checked = false;
                    }
                    int experid = 0;
                    try
                    {
                        experid = Convert.ToInt32(tblSearch.Rows[0][19]);
                    }
                    catch (Exception) { }
                    if (experid == 1)
                    {
                        chekExperid.Checked = true;
                    }
                    else
                    {
                        chekExperid.Checked = false;
                    }

                    if (IS_Tax == "خاضع للضريبة")
                    {
                        checkTax.Checked = true;
                        NudTaxes.Value = Convert.ToDecimal(tblSearch.Rows[0][10]);
                    }
                    else
                    {
                        checkTax.Checked = false;
                        NudTaxes.Value = 0;
                    }
                    txtPriceTaxes.Text = tblSearch.Rows[0][11].ToString();
                    cbxMainUnit.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][13]);

                    cbxUnitSales.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][14]);
                    cbxUnitBuy.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][16]);
                    DataTable tblDates = new DataTable();
                    tblDates.Clear();
                    DgvStoreQty.Rows.Clear();

                    tblDates = db.RunReader("select * from Items_Qty where Item_ID=" + txtItemID.Text + "", "");
                    foreach (DataRow Row in tblDates.Rows)
                    {
                        DgvStoreQty.Rows.Add(1);
                        int rowindex = DgvStoreQty.Rows.Count - 1;
                        DgvStoreQty.Rows[rowindex].Cells[0].Value = Row[2];
                        DgvStoreQty.Rows[rowindex].Cells[1].Value = Row[3];
                        DgvStoreQty.Rows[rowindex].Cells[2].Value = Row[4];
                        DgvStoreQty.Rows[rowindex].Cells[3].Value = Row[6];
                    }

                    DataTable tblUint = new DataTable();
                    tblUint.Clear();
                    DgvUnit.Rows.Clear();
                    tblUint = db.RunReader("select * from Items_Unit where Item_ID=" + txtItemID.Text + "", "");
                    foreach (DataRow Row in tblUint.Rows)
                    {
                        DgvUnit.Rows.Add(1);
                        int rowindex = DgvUnit.Rows.Count - 1;
                        DgvUnit.Rows[rowindex].Cells[0].Value = Row[2];
                        DgvUnit.Rows[rowindex].Cells[1].Value = Row[3];
                        DgvUnit.Rows[rowindex].Cells[2].Value = Row[4];
                    }

                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDeleteAll.Enabled = true;

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Frm_Items_Load(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (NudMaxDisount.Value > NudPricePart.Value)
            {
                MessageBox.Show("سعر اعلى خصم مسموح بيه اكبر من سعر بيع التجزئه للمنتج !!!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (cbxGroups.Items.Count <= 0)
                {
                    MessageBox.Show("من فضلك قم باضافه مجموعات الاصناف اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cbxMainUnit.Items.Count <= 0)
                {
                    MessageBox.Show("من فضلك قم باضافه الوحدات اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string tax = "";
                decimal taxVal = 0; int fav = 0; int expeird = 0;
                if (checkTax.Checked == true)
                {
                    tax = "خاضع للضريبة";
                    taxVal = NudTaxes.Value;
                }
                else
                {
                    tax = "غير خاضع للضريبة";
                    taxVal = 0;
                }
                if (chekFavorate.Checked == true)
                {
                    fav = 1;
                }
                else
                {
                    fav = 0;
                }
                if (chekExperid.Checked == true)
                {
                    expeird = 1;
                }
                else
                {
                    expeird = 0;
                }
                if (NudSale.Value <= 1 || NudPricePart.Value <= 1) {
                    MessageBox.Show("من فضلك ادخل سعر بيع المنتج جمله وتجزئه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if (DgvStoreQty.Rows.Count <= 0)
                {
                    MessageBox.Show("لا يمكن اضافه المنتج بدون اضافه كميه له فى المخزن", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                try
                {
                    if (NudSale.Value > NudPricePart.Value)
                    {
                        MessageBox.Show("لا يمكن ان يكون سعر الجمله اكبر من سعر التجزئه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (Exception) { }

                for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                {
                    if (Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[2].Value) > Convert.ToDecimal(txtPriceTaxes.Text ))
                    {
                        MessageBox.Show("لا يمكن ان يكون سعر الشراء اكبر من سعر بيع المنتج","تاكيد",MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                        return;
                    }  
                }
                try
                {
                if (Convert.ToInt32(cbxUnitSales.SelectedValue) !=Convert.ToInt32( cbxMainUnit.SelectedValue) )
                {

                    int count = 0;
                    for (int i = 0; i <= DgvUnit.Rows.Count - 1; i++)
                    {
                        if (cbxUnitSales.Text ==Convert.ToString( DgvUnit.Rows[i].Cells[0].Value))
                        {
                            count++;
                            
                        }
                        
                    }

                        if (count <= 0)
                        {
                            MessageBox.Show("لا يمكن ان تكون الوحده الاكثر استخداما فى البيع غير موجوده فى وحدات المنتج \n" + " من فضلك اعد اختيار وحدات المنتج والوحده الاكثر استخداما", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                 }
                catch (Exception) { }
                try
                {
                    if (Convert.ToInt32(cbxUnitBuy.SelectedValue )!= Convert.ToInt32(cbxMainUnit.SelectedValue))
                    {

                        int count = 0;
                        for (int i = 0; i <= DgvUnit.Rows.Count - 1; i++)
                        {
                            if (cbxUnitBuy.Text ==Convert.ToString(  DgvUnit.Rows[i].Cells[0].Value) )
                            {
                                count++;

                            }
                            if (count <= 0)
                            {
                                MessageBox.Show("لا يمكن ان تكون الوحده الاكثر استخداما فى الشراء غير موجوده فى وحدات المنتج \n" + " من فضلك اعد اختيار وحدات المنتج والوحده الاكثر استخداما", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }
                catch (Exception) { }
                 db.RunNunQuary("insert into Items values(" + txtItemID.Text + ",N'" + txtItemName.Text + "'," + NudQty.Value + "," + NudSale.Value + ",N'" + txtBarcode.Text + "'," + NudPricePart.Value + " ," + NudMin.Value + "  ," + NudMaxDisount.Value + " ," + cbxGroups.SelectedValue + " ,N'" + tax + "' ," + taxVal + "," + txtPriceTaxes.Text + " ,N'"+cbxMainUnit.Text+"' ,"+cbxMainUnit.SelectedValue+","+cbxUnitSales.SelectedValue+",N'"+cbxUnitSales.Text+"' , "+cbxUnitBuy.SelectedValue+",N'"+cbxUnitBuy.Text+"' ,"+fav+" , "+expeird+")", "");

                 DataTable tbl = new DataTable();
                 int ID = 0;
                
                for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                {
                    if(DgvStoreQty.Rows[i].Cells[0].Value != null){
                        tbl = db.RunReader("select Store_ID from Store where Store_Name=N'" + DgvStoreQty.Rows[i].Cells[0].Value + "'", "");
                        ID=Convert.ToInt32(tbl.Rows[0][0]);
                        db.RunNunQuary("insert into Items_Qty Values (" + txtItemID.Text + " , " + ID + " ,N'" + DgvStoreQty.Rows[i].Cells[0].Value + "' , " + DgvStoreQty.Rows[i].Cells[1].Value + " , " + DgvStoreQty.Rows[i].Cells[2].Value + " , "+txtPriceTaxes.Text+ " , '" + DgvStoreQty.Rows[i].Cells[3].Value + "') ", "");
                    }
                }

                for (int i = 0; i <= DgvUnit.Rows.Count - 1; i++)
                {
                    if (DgvUnit.Rows[i].Cells[0].Value != null)
                    {
                        tbl.Clear();
                        tbl = db.RunReader("select Unit_ID from Unit where Unit_Name=N'" + DgvUnit.Rows[i].Cells[0].Value + "'", "");
                        ID = Convert.ToInt32(tbl.Rows[0][0]);
                        db.RunNunQuary("insert into Items_Unit Values (" + txtItemID.Text + " , " + ID + " ,N'" + DgvUnit.Rows[i].Cells[0].Value + "' , " + DgvUnit.Rows[i].Cells[1].Value + " , " + DgvUnit.Rows[i].Cells[2].Value + " , " + txtPriceTaxes.Text + ") ", "");
                    }
                }
                db.RunNunQuary("insert into Items_Unit Values (" + txtItemID.Text + " , " + cbxMainUnit.SelectedValue + " ,N'" + cbxMainUnit.Text + "' , 1 , " + txtPriceTaxes.Text + " , " + txtPriceTaxes.Text + ") ", "");

                MessageBox.Show("تمت اضافة بيانات المنتج بنجاح","تاكيد",MessageBoxButtons.OK ,MessageBoxIcon.Information);
                AutoNum();
            }
            catch (Exception)
            { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (NudMaxDisount.Value > NudPricePart.Value)
            {
                MessageBox.Show("سعر اعلى خصم مسموح بيه اكبر من سعر بيع التجزئه للمنتج !!!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (cbxGroups.Items.Count <= 0)
                {
                    MessageBox.Show("من فضلك قم باضافه مجموعات الاصناف اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cbxMainUnit.Items.Count <= 0)
                {
                    MessageBox.Show("من فضلك قم باضافه الوحدات اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string tax = "";
                decimal taxVal = 0;
                if (checkTax.Checked == true)
                {
                    tax = "خاضع للضريبة";
                    taxVal = NudTaxes.Value;
                }
                else
                {
                    tax = "غير خاضع للضريبة";
                    taxVal = 0;
                }
                if (NudSale.Value <= 1 || NudPricePart.Value <= 1)
                {
                    MessageBox.Show("من فضلك ادخل سعر بيع المنتج جمله وتجزئه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                int fav = 0;int expeird = 0;
                if (chekFavorate.Checked == true)
                {
                    fav = 1;
                }
                else
                {
                    fav = 0;
                }
                if (chekExperid.Checked == true)
                {
                    expeird = 1;
                }
                else
                {
                    expeird = 0;
                }
                if (DgvStoreQty.Rows.Count <= 0)
                {
                    MessageBox.Show("لا يمكن اضافه المنتج بدون اضافه كميه له فى المخزن", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                {
                    if (Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[2].Value) > Convert.ToDecimal(txtPriceTaxes.Text))
                    {
                        MessageBox.Show("لا يمكن ان يكون سعر الشراء اكبر من سعر بيع المنتج", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                try
                {
                    if (Convert.ToInt32(cbxUnitSales.SelectedValue) != Convert.ToInt32(cbxMainUnit.SelectedValue))
                    {

                        int count = 0;
                        for (int i = 0; i <= DgvUnit.Rows.Count - 1; i++)
                        {
                            if (cbxUnitSales.Text == Convert.ToString(DgvUnit.Rows[i].Cells[0].Value))
                            {
                                count++;

                            }
                           
                        }
                        if (count <= 0)
                        {
                            MessageBox.Show("لا يمكن ان تكون الوحده الاكثر استخداما فى البيع غير موجوده فى وحدات المنتج \n" + " من فضلك اعد اختيار وحدات المنتج والوحده الاكثر استخداما", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                catch (Exception) { }
                try
                {
                    if (Convert.ToInt32(cbxUnitBuy.SelectedValue) != Convert.ToInt32(cbxMainUnit.SelectedValue))
                    {

                        int count = 0;
                        for (int i = 0; i <= DgvUnit.Rows.Count - 1; i++)
                        {
                            if (cbxUnitBuy.Text == Convert.ToString(DgvUnit.Rows[i].Cells[0].Value))
                            {
                                count++;

                            }
                            if (count <= 0)
                            {
                                MessageBox.Show("لا يمكن ان تكون الوحده الاكثر استخداما فى الشراء غير موجوده فى وحدات المنتج \n" + " من فضلك اعد اختيار وحدات المنتج والوحده الاكثر استخداما", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }
                catch (Exception) { }
                db.RunNunQuary("update Items set Item_Name=N'" + txtItemName.Text + "',Barcode=N'" + txtBarcode.Text + "',Item_Qty=" + NudQty.Value + ",Item_Price_Sale=" + NudSale.Value + ",Item_Price_Sale_Part=" + NudPricePart.Value + " ,Item_Min=" + NudMin.Value + " ,Max_Discount=" + NudMaxDisount.Value + " ,G_ID=" + cbxGroups.SelectedValue + " ,IS_Tax=N'" + tax + "' ,Tax_Value=" + taxVal + "  ,Price_Tax=" + txtPriceTaxes.Text + " ,Main_Unit='" + cbxMainUnit.Text + "' ,Unit_ID=" + cbxMainUnit.SelectedValue + " ,MainUnit_SaleID=" + cbxUnitSales.SelectedValue + ",MainUnit_SaleName=N'" + cbxUnitSales.Text + "', MainUnit_BuyID="+cbxUnitBuy.SelectedValue+",MainUnit_BuyName=N'" + cbxUnitBuy.Text + "' ,Is_Fav ="+fav+ ",Is_Expeird="+expeird+"  where Item_ID=" + txtItemID.Text + "", "");
                db.RunNunQuary("delete from Items_Qty where Item_ID="+txtItemID.Text+"", "");
                db.RunNunQuary("delete from Items_Unit where Item_ID=" + txtItemID.Text + "", "");
                DataTable tbl = new DataTable();
                int ID = 0;

                for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                {
                    if (DgvStoreQty.Rows[i].Cells[0].Value != null)
                    {
                        tbl = db.RunReader("select Store_ID from Store where Store_Name=N'" + DgvStoreQty.Rows[i].Cells[0].Value + "'", "");
                        ID = Convert.ToInt32(tbl.Rows[0][0]);
                        db.RunNunQuary("insert into Items_Qty Values (" + txtItemID.Text + " , " + ID + " ,N'" + DgvStoreQty.Rows[i].Cells[0].Value + "' , " + DgvStoreQty.Rows[i].Cells[1].Value + " , " + DgvStoreQty.Rows[i].Cells[2].Value + " , " + txtPriceTaxes.Text + " ,'"+ DgvStoreQty.Rows[i].Cells[3].Value + "') ", "");
                    }
                }
                DataTable tblUnit = new DataTable();
                tblUnit.Clear();
                for (int i = 0; i <= DgvUnit.Rows.Count - 1; i++)
                {
                    
                        tbl.Clear();
                        tbl = db.RunReader("select Unit_ID from Unit where Unit_Name=N'" + DgvUnit.Rows[i].Cells[0].Value + "'", "");
                        ID = Convert.ToInt32(tbl.Rows[0][0]);
                        db.RunNunQuary("insert into Items_Unit Values (" + txtItemID.Text + " , " + ID + " ,N'" + DgvUnit.Rows[i].Cells[0].Value + "' , " + DgvUnit.Rows[i].Cells[1].Value + " , " + DgvUnit.Rows[i].Cells[2].Value + " , " + txtPriceTaxes.Text + ") ", "");
                 
                }
                tblUnit = db.RunReader("select * from Items_Unit where Item_ID=" + txtItemID.Text + " ", "");
                bool check = false;
                for (int i = 0; i <= tblUnit.Rows.Count - 1; i++)
                {
                    if (Convert.ToInt32(tblUnit.Rows[i][1]) == Convert.ToInt32(cbxMainUnit.SelectedValue) && Convert.ToString(tblUnit.Rows[i][2]) == Convert.ToString(DgvUnit.Rows[i].Cells[0].Value) && Convert.ToString(tblUnit.Rows[i][3]) == Convert.ToString(DgvUnit.Rows[i].Cells[1].Value) && Convert.ToDecimal(tblUnit.Rows[i][5]) == Convert.ToDecimal(txtPriceTaxes.Text))
                    {
                        check = true;
                    }
                }
                if(check==false)
                db.RunNunQuary("insert into Items_Unit Values (" + txtItemID.Text + " , " + cbxMainUnit.SelectedValue + " ,N'" + cbxMainUnit.Text + "' , 1 , " + txtPriceTaxes.Text + " , " + txtPriceTaxes.Text + ") ", "");

                MessageBox.Show("تمت تعديل بيانات المنتج بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AutoNum();
            }
            catch (Exception )
            {}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Items where Item_ID=" + txtItemID.Text + " ", "");
                db.RunNunQuary("delete  from Items_Qty where Item_ID=" + txtItemID.Text + " ", "تم حذف بيانات المنتج بنجاح");
                db.RunNunQuary("delete  from Items_Unit where Item_ID=" + txtItemID.Text + " ", "");
      
                AutoNum();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Items ", "تم حذف جميع بيانات المنتجات بنجاح");
                db.RunNunQuary("delete  from Items_Qty", "");
                db.RunNunQuary("delete  from Items_Unit ", "");
                AutoNum();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            introw = 0;
            showData();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (introw == 0)
            {
                tbl.Clear();
                tbl = db.RunReader("select * from Items", "");
                introw = tbl.Rows.Count - 1;

                showData();

            }
            else
            {
                introw -= 1;
                showData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Items", "");

            if (introw == 0)
            {
                introw++;
                showData();

            }
            else if (introw == tbl.Rows.Count - 1)
            {
                introw = 0;
                showData();
            }
            else
            {
                introw += 1;
                showData();
            }
        
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Items", "");
            introw = tbl.Rows.Count - 1;
            showData();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxStore.Items.Count >= 1)
                {
                    DgvStoreQty.Rows.Add(1);
                    decimal tot;
                    int rowindex = DgvStoreQty.Rows.Count - 1;
                    DgvStoreQty.Rows[rowindex].Cells[0].Value = cbxStore.Text;
                    DgvStoreQty.Rows[rowindex].Cells[1].Value = NudQtyStore.Value;
                    DgvStoreQty.Rows[rowindex].Cells[2].Value = NudBuyPrice.Value;
                    DgvStoreQty.Rows[rowindex].Cells[3].Value = DtpExpierd.Text;
                    tot = 0;
                    for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                    {
                        tot += Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[1].Value);
                    }
                    NudQty.Value = Convert.ToDecimal(tot);
                }
                else { MessageBox.Show("من فضلك ادخل بيانات المخازن اولا","تاكيد",MessageBoxButtons.OK,MessageBoxIcon.Information); return; }
            }
            catch (Exception)
            { }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                decimal tot;
                if (DgvStoreQty.Rows[0].Cells[0].Value != null)
                {
                    DgvStoreQty.Rows.RemoveAt(DgvStoreQty.CurrentCell.RowIndex);
                    tot = 0;
                    for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                    {
                        tot += Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[1].Value);
                    }
                    NudQty.Value = Convert.ToInt32(tot);
                }
            }
            catch (Exception)
            { }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

            try
            {

                for (int i = 0; i <= DgvUnit.Rows.Count - 1; i++)
                {
                    if (DgvUnit.Rows[i].Cells[0].Value == cbxUnit.Text)
                    {
                        MessageBox.Show("لا يمكن ادخال نفس الوحده مره اخرى", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                if (Convert.ToInt32(cbxUnit.SelectedValue) == Convert.ToInt32(cbxMainUnit.SelectedValue))
                {
                    try
                    {
                        if (cbxUnit.Items.Count >= 1)
                        {

                           

                            DgvUnit.Rows.Add(1);
                            int rowindex = DgvUnit.Rows.Count - 1;
                            DgvUnit.Rows[rowindex].Cells[0].Value = cbxUnit.Text;
                            DgvUnit.Rows[rowindex].Cells[1].Value = 1;
                            DgvUnit.Rows[rowindex].Cells[2].Value = txtPriceTaxes.Text;

                        }
                        else 
                        { MessageBox.Show("من فضلك ادخل بيانات الوحدات اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                    }
                    catch (Exception)
                    { }
                }
                else
                {
                    NudQtyUnit.Enabled = true;
                    NudUnitPrice.Enabled = true;

                    try
                    {
                        if (cbxUnit.Items.Count >= 1)
                        {
                            DgvUnit.Rows.Add(1);
                            int rowindex = DgvUnit.Rows.Count - 1;
                            DgvUnit.Rows[rowindex].Cells[0].Value = cbxUnit.Text;
                            DgvUnit.Rows[rowindex].Cells[1].Value = NudQtyUnit.Value;
                            DgvUnit.Rows[rowindex].Cells[2].Value = NudUnitPrice.Value;

                        }
                        else { MessageBox.Show("من فضلك ادخل بيانات الوحدات اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                    }
                    catch (Exception)
                    { }
                }
            }
            catch (Exception) { }


         
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvUnit.Rows[0].Cells[0].Value != null)
                {
                    DgvUnit.Rows.RemoveAt(DgvUnit.CurrentCell.RowIndex);
                 
                }
            }
            catch (Exception)
            { }
        }

        private void NudQtyUnit_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                NudUnitPrice.Value = Convert.ToDecimal(txtPriceTaxes.Text) / NudQtyUnit.Value;
            }
            catch (Exception) { }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Frm_Items_Group frm = new Frm_Items_Group();
            frm.ShowDialog();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            Frm_Unit frm = new Frm_Unit();
            frm.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                if (textBox1.Text != "")
                {

                    DataTable tblSearch = new DataTable();
                    tblSearch.Clear();

                    tblSearch = db.RunReader("select * from Items where Barcode=N'" + textBox1.Text + "' ", "");

                    if ((tblSearch.Rows.Count <= 0))
                    {
                        MessageBox.Show("لا يوجد منتج بهذا الباركود", "تاكيد");
                    }
                    else
                    {
                        txtItemID.Text = tblSearch.Rows[0][0].ToString();
                        txtItemName.Text = tblSearch.Rows[0][1].ToString();
                        try
                        {
                            NudQty.Value = Convert.ToDecimal(tblSearch.Rows[0][2]);
                            NudSale.Value = Convert.ToDecimal(tblSearch.Rows[0][3]);
                            NudPricePart.Value = Convert.ToDecimal(tblSearch.Rows[0][5]);
                            NudMin.Value = Convert.ToDecimal(tblSearch.Rows[0][6]);

                        }
                        catch (Exception) { }

                        txtBarcode.Text = tblSearch.Rows[0][4].ToString();
                        NudMaxDisount.Value = Convert.ToDecimal(tblSearch.Rows[0][7]);
                        cbxGroups.SelectedValue = Convert.ToInt16(tblSearch.Rows[0][8]);
                        string IS_Tax = Convert.ToString(tblSearch.Rows[0][9]);
                        if (IS_Tax == "خاضع للضريبة")
                        {
                            checkTax.Checked = true;
                            NudTaxes.Value = Convert.ToDecimal(tblSearch.Rows[0][10]);
                        }
                        else
                        {
                            checkTax.Checked = false;
                            NudTaxes.Value = 0;
                        }
                        int FAV = 0;
                        try
                        {
                            FAV = Convert.ToInt32(tblSearch.Rows[0][18]);
                        }
                        catch (Exception) { }
                        if (FAV == 1)
                        {
                            chekFavorate.Checked = true;
                        }
                        else
                        {
                            chekFavorate.Checked = false;
                        }
                        int experid = 0;
                        try
                        {
                            experid = Convert.ToInt32(tblSearch.Rows[0][19]);
                        }
                        catch (Exception) { }
                        if (experid == 1)
                        {
                            chekExperid.Checked = true;
                        }
                        else
                        {
                            chekExperid.Checked = false;
                        }
                        txtPriceTaxes.Text = tblSearch.Rows[0][11].ToString();
                        cbxMainUnit.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][13]);

                        cbxUnitSales.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][14]);
                        cbxUnitBuy.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][16]);
                        DataTable tblDates = new DataTable();
                        tblDates.Clear();
                        DgvStoreQty.Rows.Clear();

                        tblDates = db.RunReader("select * from Items_Qty where Item_ID=" + txtItemID.Text + "", "");
                        foreach (DataRow Row in tblDates.Rows)
                        {
                            DgvStoreQty.Rows.Add(1);
                            int rowindex = DgvStoreQty.Rows.Count - 1;
                            DgvStoreQty.Rows[rowindex].Cells[0].Value = Row[2];
                            DgvStoreQty.Rows[rowindex].Cells[1].Value = Row[3];
                            DgvStoreQty.Rows[rowindex].Cells[2].Value = Row[4];
                            DgvStoreQty.Rows[rowindex].Cells[3].Value = Row[6];
                        }

                        DataTable tblUint = new DataTable();
                        tblUint.Clear();
                        DgvUnit.Rows.Clear();
                        tblUint = db.RunReader("select * from Items_Unit where Item_ID=" + txtItemID.Text + "", "");
                        foreach (DataRow Row in tblUint.Rows)
                        {
                            DgvUnit.Rows.Add(1);
                            int rowindex = DgvUnit.Rows.Count - 1;
                            DgvUnit.Rows[rowindex].Cells[0].Value = Row[2];
                            DgvUnit.Rows[rowindex].Cells[1].Value = Row[3];
                            DgvUnit.Rows[rowindex].Cells[2].Value = Row[4];
                        }


                        btnAdd.Enabled = false;
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnDeleteAll.Enabled = true;

                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                if (Convert.ToInt32(cbxUnit.SelectedValue) == Convert.ToInt32(cbxMainUnit.SelectedValue))
                {
                    NudQtyUnit.Enabled = false;
                    NudUnitPrice.Enabled = false;
                }
                else 
                {
                    NudQtyUnit.Enabled = true;
                    NudUnitPrice.Enabled = true;
                }
            }
            catch (Exception) { }
        }

        private void NudSale_ValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (NudSale.Value > NudPricePart.Value)
            //    {
            //        MessageBox.Show("لا يمكن ان يكون سعر الجمله اكبر من سعر التجزئه","تاكيد",MessageBoxButtons.OK ,MessageBoxIcon.Information);
            //        return; 
            //    }
            //}
            //catch (Exception) { }
        }

        private void cbxMainUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cbxUnit.SelectedValue) == Convert.ToInt32(cbxMainUnit.SelectedValue))
                {
                    NudQtyUnit.Enabled = false;
                    NudUnitPrice.Enabled = false;
                }
                else
                {
                    NudQtyUnit.Enabled = true;
                    NudUnitPrice.Enabled = true;
                }
            }
            catch (Exception) { }
        }

        private void NudQty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NudMaxDisount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NudMin_ValueChanged(object sender, EventArgs e)
        {

        }
        
     }
    
}
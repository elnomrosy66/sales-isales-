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
    public partial class Frm_Items_View : DevExpress.XtraEditors.XtraForm
    {
        private static Frm_Items_View frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_Items_View GetMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_Items_View();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }


        public Frm_Items_View()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        DataTable tblSearch = new DataTable();

        public void FillGroups()
        {
            cbxGroup.DataSource = db.RunReader("select * from Items_Group", "");
            cbxGroup.DisplayMember = "G_Name";
            cbxGroup.ValueMember = "G_ID";
        }
        decimal qtyTotal = 0, buyTotal = 0, saleTotal = 0, salePartTotal = 0, salesTaxes;

        private void txtParcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtParcode.Text != "")
                {
                    tblSearch.Clear();
                    tblSearch = db.RunReader("SELECT [Item_ID] as ' مسلسل',[Item_Name] as 'اسم المنتج',[Item_Qty] as 'الكمية',[Main_Unit] as 'الوحدة',[Item_Price_Sale] as 'سعر بيع الجمله',[Item_Price_Sale_Part] as 'سعر بيع التجزئه',[Tax_Value] as 'قيمة الضريبة المضافه',[Price_Tax] as 'سعر التجزئه بعد الضريبة',[Barcode] as 'الباركود',[Item_Min] as 'حد الطلب',Items_Group .G_Name as 'التصنيف',[IS_Tax] as 'خاضع للضريبة ام لا',[Max_Discount] as 'اقصى خصم مسموح' FROM [Items] ,Items_Group where Items_Group.G_ID=Items.G_ID and [Barcode] =" + txtParcode.Text + "", "");
                    DgvBuyDetalis.DataSource = tblSearch;

                    try
                    {
                        qtyTotal = 0; buyTotal = 0; saleTotal = 0; salePartTotal = 0; salesTaxes = 0;
                        for (int i = 0; i <= DgvBuyDetalis.Rows.Count - 1; i++)
                        {
                            qtyTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[2].Value);
                            saleTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[4].Value);
                            salePartTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[5].Value);
                            salesTaxes += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[7].Value);
                        }
                        txtQty.Text = Math.Round(qtyTotal, 2).ToString();
                        txtSalePartTotal.Text = Math.Round(salePartTotal, 2).ToString();
                        txtTaxSales.Text = Math.Round(salesTaxes, 2).ToString();
                    }
                    catch (Exception) { }
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Frm_Items frm = new Frm_Items();
            frm.ShowDialog();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (DgvBuyDetalis.Rows.Count >= 1)
            {
                try
                {
                    num = Convert.ToInt32(DgvBuyDetalis.CurrentRow.Cells[0].Value);
                    Properties.Settings.Default.ItemID = num;
                    Properties.Settings.Default.Save();
                    Frm_Items frm = new Frm_Items();
                    frm.ShowDialog();
                }
                catch (Exception) { }
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (DgvBuyDetalis.Rows.Count >= 1)
            {
                if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.RunNunQuary("delete  from Items where Item_ID=" + DgvBuyDetalis.CurrentRow.Cells[0].Value + " ", "تم حذف بيانات المنتج المحدد بنجاح");
                    db.RunNunQuary("delete  from Items_Qty where Item_ID=" + DgvBuyDetalis.CurrentRow.Cells[0].Value + " ", "");
                    db.RunNunQuary("delete  from Items_Unit where Item_ID=" + DgvBuyDetalis.CurrentRow.Cells[0].Value + " ", "");
                    Frm_Items_View_Load(null, null);
                }
            }
        }

        private void btnDeleteProductAll_Click(object sender, EventArgs e)
        {
            if (DgvBuyDetalis.Rows.Count >= 1)
            {
                if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.RunNunQuary("delete from Items ", "تم حذف جميع المنتجات  بنجاح");
                    db.RunNunQuary("delete  from Items_Qty ", "");
                    db.RunNunQuary("delete  from Items_Unit ", "");
                    Frm_Items_View_Load(null, null);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_Items_Group frm = new Frm_Items_Group();
            frm.ShowDialog();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtName.Text != "")
            {
                tblSearch.Clear();
                tblSearch = db.RunReader("SELECT [Item_ID] as ' مسلسل',[Item_Name] as 'اسم المنتج',[Item_Qty] as 'الكمية',[Main_Unit] as 'الوحدة',[Item_Price_Sale] as 'سعر بيع الجمله',[Item_Price_Sale_Part] as 'سعر بيع التجزئه',[Tax_Value] as 'قيمة الضريبة المضافه',[Price_Tax] as 'سعر التجزئه بعد الضريبة',[Barcode] as 'الباركود',[Item_Min] as 'حد الطلب',Items_Group .G_Name as 'التصنيف',[IS_Tax] as 'خاضع للضريبة ام لا',[Max_Discount] as 'اقصى خصم مسموح' FROM [Items] ,Items_Group where Items_Group.G_ID=Items.G_ID and [Item_Name] Like '%" + txtName.Text + "%' ", "");
                DgvBuyDetalis.DataSource = tblSearch;

                try
                {
                    qtyTotal = 0; buyTotal = 0; saleTotal = 0; salePartTotal = 0; salesTaxes = 0;
                    for (int i = 0; i <= DgvBuyDetalis.Rows.Count - 1; i++)
                    {
                        qtyTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[2].Value);
                        saleTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[4].Value);
                        salePartTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[5].Value);
                        salesTaxes += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[7].Value);
                    }
                    txtQty.Text = Math.Round(qtyTotal, 2).ToString();
                    txtSaleTotal.Text = Math.Round(saleTotal, 2).ToString();
                    txtSalePartTotal.Text = Math.Round(salePartTotal, 2).ToString();
                    txtTaxSales.Text = Math.Round(salesTaxes, 2).ToString();
                }
                catch (Exception) { }
            }

        }

        private void btnSearchParcode_Click(object sender, EventArgs e)
        {
            if (txtParcode.Text != "")
            {
                tblSearch.Clear();
                tblSearch = db.RunReader("SELECT [Item_ID] as ' مسلسل',[Item_Name] as 'اسم المنتج',[Item_Qty] as 'الكمية',[Main_Unit] as 'الوحدة',[Item_Price_Sale] as 'سعر بيع الجمله',[Item_Price_Sale_Part] as 'سعر بيع التجزئه',[Tax_Value] as 'قيمة الضريبة المضافه',[Price_Tax] as 'سعر التجزئه بعد الضريبة',[Barcode] as 'الباركود',[Item_Min] as 'حد الطلب',Items_Group .G_Name as 'التصنيف',[IS_Tax] as 'خاضع للضريبة ام لا',[Max_Discount] as 'اقصى خصم مسموح' FROM [Items] ,Items_Group where Items_Group.G_ID=Items.G_ID and [Barcode] =" + txtParcode.Text + "", "");
                DgvBuyDetalis.DataSource = tblSearch;

                try
                {
                    qtyTotal = 0; buyTotal = 0; saleTotal = 0; salePartTotal = 0; salesTaxes = 0;
                    for (int i = 0; i <= DgvBuyDetalis.Rows.Count - 1; i++)
                    {
                        qtyTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[2].Value);
                        saleTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[4].Value);
                        salePartTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[5].Value);
                        salesTaxes += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[7].Value);
                    }
                    txtQty.Text = Math.Round(qtyTotal, 2).ToString();
                    txtSaleTotal.Text = Math.Round(saleTotal, 2).ToString();
                    txtSalePartTotal.Text = Math.Round(salePartTotal, 2).ToString();
                    txtTaxSales.Text = Math.Round(salesTaxes, 2).ToString();
                }
                catch (Exception) { }
            }
            else { MessageBox.Show("من فضلك ادخل الباركود!!", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }


        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            try
            {
                tbl = db.RunReader("SELECT [Item_ID] as ' مسلسل',[Item_Name] as 'اسم المنتج',[Item_Qty] as 'الكمية',[Main_Unit] as 'الوحدة',[Item_Price_Sale] as 'سعر بيع الجمله',[Item_Price_Sale_Part] as 'سعر بيع التجزئه',[Tax_Value] as 'قيمة الضريبة المضافه',[Price_Tax] as 'سعر التجزئه بعد الضريبة',[Barcode] as 'الباركود',[Item_Min] as 'حد الطلب',Items_Group .G_Name as 'التصنيف',[IS_Tax] as 'خاضع للضريبة ام لا',[Max_Discount] as 'اقصى خصم مسموح' FROM [Items] ,Items_Group where Items_Group.G_ID=Items.G_ID", "");

                if (tbl.Rows.Count >= 1)
                {
                    DgvBuyDetalis.DataSource = tbl;
                }
                else { DgvBuyDetalis.DataSource = tbl;
                MessageBox.Show("لا يوجد منتجات حتى الان","تاكيد",MessageBoxButtons.OK ,MessageBoxIcon.Information);
                }

                FillGroups();
            }
            catch (Exception) { }

            try
            {
                qtyTotal = 0; buyTotal = 0; saleTotal = 0; salePartTotal = 0; salesTaxes = 0;
                for (int i = 0; i <= DgvBuyDetalis.Rows.Count - 1; i++)
                {
                    qtyTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[2].Value);
                    saleTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[4].Value) * Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[2].Value);
                    salePartTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[5].Value) * Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[2].Value); ;
                    salesTaxes += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[7].Value) * Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[2].Value); ;
                }
                txtQty.Text = Math.Round(qtyTotal, 2).ToString();
                txtSaleTotal.Text = Math.Round(saleTotal, 2).ToString();
                txtSalePartTotal.Text = Math.Round(salePartTotal, 2).ToString();
                txtTaxSales.Text = Math.Round(salesTaxes, 2).ToString();
            }
            catch (Exception) { }
        }

        private void btnSearchGroup_Click(object sender, EventArgs e)
        {
            if (cbxGroup.Items.Count >= 1)
            {
                tblSearch.Clear();
                tblSearch = db.RunReader("SELECT [Item_ID] as ' مسلسل',[Item_Name] as 'اسم المنتج',[Item_Qty] as 'الكمية',[Main_Unit] as 'الوحدة',[Item_Price_Sale] as 'سعر بيع الجمله',[Item_Price_Sale_Part] as 'سعر بيع التجزئه',[Tax_Value] as 'قيمة الضريبة المضافه',[Price_Tax] as 'سعر التجزئه بعد الضريبة',[Barcode] as 'الباركود',[Item_Min] as 'حد الطلب',Items_Group .G_Name as 'التصنيف',[IS_Tax] as 'خاضع للضريبة ام لا',[Max_Discount] as 'اقصى خصم مسموح' FROM [Items] ,Items_Group where Items_Group.G_ID=Items.G_ID and Items.G_ID=" + cbxGroup.SelectedValue + "", "");
                DgvBuyDetalis.DataSource = tblSearch;


                try
                {
                    qtyTotal = 0; buyTotal = 0; saleTotal = 0; salePartTotal = 0; salesTaxes = 0;
                    for (int i = 0; i <= DgvBuyDetalis.Rows.Count - 1; i++)
                    {
                        qtyTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[2].Value);
                        saleTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[4].Value);
                        salePartTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[5].Value);
                        salesTaxes += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[7].Value);
                    }
                    txtQty.Text = Math.Round(qtyTotal, 2).ToString();
                    txtSaleTotal.Text = Math.Round(saleTotal, 2).ToString();
                    txtSalePartTotal.Text = Math.Round(salePartTotal, 2).ToString();
                    txtTaxSales.Text = Math.Round(salesTaxes, 2).ToString();
                }
                catch (Exception) { }
            }
            else { MessageBox.Show("من فضلك تاكد من وجود مجموعات اولا", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

        }

        public void Frm_Items_View_Load(object sender, EventArgs e)
        {
            try
            {
                tbl = db.RunReader("SELECT [Item_ID] as ' مسلسل',[Item_Name] as 'اسم المنتج',[Item_Qty] as 'الكمية',[Main_Unit] as 'الوحدة',[Item_Price_Sale] as 'سعر بيع الجمله',[Item_Price_Sale_Part] as 'سعر بيع التجزئه',[Tax_Value] as 'قيمة الضريبة المضافه',[Price_Tax] as 'سعر التجزئه بعد الضريبة',[Barcode] as 'الباركود',[Item_Min] as 'حد الطلب',Items_Group .G_Name as 'التصنيف',[IS_Tax] as 'خاضع للضريبة ام لا',[Max_Discount] as 'اقصى خصم مسموح' FROM [Items] ,Items_Group where Items_Group.G_ID=Items.G_ID", "");
                DgvBuyDetalis.DataSource = tbl;

                FillGroups();
            }
            catch (Exception) { }

            try
            {
                qtyTotal = 0; buyTotal = 0; saleTotal = 0; salePartTotal = 0; salesTaxes = 0;
                for (int i = 0; i <= DgvBuyDetalis.Rows.Count - 1; i++)
                {
                    qtyTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[2].Value); 
                    saleTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[4].Value) * Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[2].Value);
                    salePartTotal += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[5].Value) * Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[2].Value); ;
                    salesTaxes += Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[7].Value) * Convert.ToDecimal(DgvBuyDetalis.Rows[i].Cells[2].Value); ;
                }
                txtQty.Text = Math.Round(qtyTotal, 2).ToString();
                txtSaleTotal.Text = Math.Round(saleTotal, 2).ToString();
                txtSalePartTotal.Text = Math.Round(salePartTotal, 2).ToString();
                txtTaxSales.Text = Math.Round(salesTaxes, 2).ToString();
            }
            catch (Exception) { }
        }
    }
}
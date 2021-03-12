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
    public partial class Frm_ItemReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ItemReport()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();

        private void FillItem()
        {

            cbxDesName.DataSource = db.RunReader("select * from Items", "");
            cbxDesName.DisplayMember = "Item_Name";
            cbxDesName.ValueMember = "Item_ID";

        }
        private void FillStore()
        {

            cbxStorea.DataSource = db.RunReader("select * from Store", "");
            cbxStorea.DisplayMember = "Store_Name";
            cbxStorea.ValueMember = "Store_ID";

        }
        private void Frm_ItemReport_Load(object sender, EventArgs e)
        {
            try
            {
                FillItem();
                FillStore();
            }
            catch (Exception) { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gard();
        }
        void gard()
        {
            decimal Sum, Sum2, rbh7;
            tbl.Clear();
            if (rbtnAll.Checked == true)
            {
                if (rbtnAllStore.Checked == true)
                    tbl = db.RunReader("SELECT [Items_Qty].[Item_ID] as 'رقم المنتج',Items.Item_Name as 'اسم المنتج',[Store_Name] as 'اسم المخزن المتواجد فيه',[Qty] as 'الكمية',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع' FROM [Items_Qty],Items where [Items_Qty].Item_ID=Items.Item_ID", "");
                else if (rbtnOneStore.Checked == true)
                    tbl = db.RunReader("SELECT [Items_Qty].[Item_ID] as 'رقم المنتج',Items.Item_Name as 'اسم المنتج',[Store_Name] as 'اسم المخزن المتواجد فيه',[Qty] as 'الكمية',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع' FROM [Items_Qty],Items where [Items_Qty].Item_ID=Items.Item_ID and Store_ID=" + cbxStorea.SelectedValue + "", "");

            }
            else if (rbtnOne.Checked == true)
            {
                if (rbtnAllStore.Checked == true)
                    tbl = db.RunReader("SELECT [Items_Qty].[Item_ID] as 'رقم المنتج',Items.Item_Name as 'اسم المنتج',[Store_Name] as 'اسم المخزن المتواجد فيه',[Qty] as 'الكمية',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع' FROM [Items_Qty],Items where [Items_Qty].Item_ID=Items.Item_ID and Items_Qty.Item_ID=" + cbxDesName.SelectedValue + "", "");
                else if (rbtnOneStore.Checked == true)
                    tbl = db.RunReader("SELECT [Items_Qty].[Item_ID] as 'رقم المنتج',Items.Item_Name as 'اسم المنتج',[Store_Name] as 'اسم المخزن المتواجد فيه',[Qty] as 'الكمية',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع' FROM [Items_Qty],Items where [Items_Qty].Item_ID=Items.Item_ID and  Items_Qty.Item_ID=" + cbxDesName.SelectedValue + " and Store_ID=" + cbxStorea.SelectedValue + "", "");

            }
            Sum = 0; Sum2 = 0; rbh7 = 0;
            try
            {
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {

                    Sum += Convert.ToDecimal(tbl.Rows[i][3]) * Convert.ToDecimal(tbl.Rows[i][4]);
                    Sum2 += Convert.ToDecimal(tbl.Rows[i][3]) * Convert.ToDecimal(tbl.Rows[i][5]);
                }
            }
            catch (Exception) { }
            txtTotalBuy.Text = Math.Round(Sum, 2).ToString();
            txtTotalSale.Text = Math.Round(Sum2, 2).ToString();
            txtRbh7.Text = Math.Round(Sum2 - Sum, 2).ToString();
            DgvBuyDetalis.DataSource = tbl;
        }
        private void btnToRent_Click(object sender, EventArgs e)
        {
            DataTable tblCheck = new DataTable(); DataTable tblCheckItem = new DataTable();
            if (DgvBuyDetalis.Rows.Count >= 1)
            { }
                
        }

        private void btnToSale_Click(object sender, EventArgs e)
        {
            
        }

        private void DgvBuyDetalis_MouseClick(object sender, MouseEventArgs e)
        {
            int QtySale = 0, QtyRent = 0;
            if (DgvBuyDetalis.Rows.Count >= 1)
            {
                ////DgvBuyDetalis.Rows[i].Cells[0].Value
                //try
                //{
                //    QtySale = Convert.ToInt32(db.RunReader("select Item_Qty from Items where Item_ID=" + DgvBuyDetalis.CurrentRow.Cells[0].Value + "", "").Rows[0][0]);
                //}
                //catch (Exception) { }
                //try
                //{
                //    QtyRent = Convert.ToInt32(db.RunReader("select Qty from Items_Rent where Item_ID=" + DgvBuyDetalis.CurrentRow.Cells[0].Value + "", "").Rows[0][0]);
                //}
                //catch (Exception) { }

              
            }
        }
        DataTable tblPar = new DataTable();
        private void textParcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            tblPar.Clear();
            if (e.KeyChar == 13)
            {
                tblPar = db.RunReader("select * from Items where barcode='" + textParcode.Text + "'", "");
                if (tblPar.Rows.Count >= 1)
                {
                    rbtnOne.Checked = true;
                    cbxDesName.SelectedValue = tblPar.Rows[0][0].ToString();
                    btnSearch_Click(null, null);
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

        private void textParcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (DgvBuyDetalis.Rows.Count >= 1)
            {
                PrintAll();
            }
            else
            {
                MessageBox.Show("لا يوجد عمليات بيع حتى تتم طباعتها", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void PrintAll()
        {
            try
            {
                DataTable tblRpt = new DataTable();
                tblRpt.Clear();

                if (rbtnAll.Checked == true)
                {
                    if (rbtnAllStore.Checked == true)
                        tblRpt = db.RunReader("SELECT [Items_Qty].[Item_ID] as 'رقم المنتج',Items.Item_Name as 'اسم المنتج',[Store_Name] as 'اسم المخزن المتواجد فيه',[Qty] as 'الكمية',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع' FROM [Items_Qty],Items where [Items_Qty].Item_ID=Items.Item_ID", "");
                    else if (rbtnOneStore.Checked == true)
                        tblRpt = db.RunReader("SELECT [Items_Qty].[Item_ID] as 'رقم المنتج',Items.Item_Name as 'اسم المنتج',[Store_Name] as 'اسم المخزن المتواجد فيه',[Qty] as 'الكمية',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع' FROM [Items_Qty],Items where [Items_Qty].Item_ID=Items.Item_ID and Store_ID=" + cbxStorea.SelectedValue + "", "");

                }
                else if (rbtnOne.Checked == true)
                {
                    if (rbtnAllStore.Checked == true)
                        tblRpt = db.RunReader("SELECT [Items_Qty].[Item_ID] as 'رقم المنتج',Items.Item_Name as 'اسم المنتج',[Store_Name] as 'اسم المخزن المتواجد فيه',[Qty] as 'الكمية',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع' FROM [Items_Qty],Items where [Items_Qty].Item_ID=Items.Item_ID and Items_Qty.Item_ID=" + cbxDesName.SelectedValue + "", "");
                    else if (rbtnOneStore.Checked == true)
                        tblRpt = db.RunReader("SELECT [Items_Qty].[Item_ID] as 'رقم المنتج',Items.Item_Name as 'اسم المنتج',[Store_Name] as 'اسم المخزن المتواجد فيه',[Qty] as 'الكمية',[Price_Buy] as 'سعر الشراء',[Price_Sale] as 'سعر البيع' FROM [Items_Qty],Items where [Items_Qty].Item_ID=Items.Item_ID and  Items_Qty.Item_ID=" + cbxDesName.SelectedValue + " and Store_ID=" + cbxStorea.SelectedValue + "", "");

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
                RptItemsReport rpt = new RptItemsReport();

                frm.crystalReportViewer1.RefreshReport();
                rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");
                rpt.SetDataSource(tblRpt);
                frm.crystalReportViewer1.ReportSource = rpt;
                //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                //rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                //rpt.PrintToPrinter(1, true, 0, 0);
                frm.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cbxDesName_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void cbxDesName_SelectedIndexChanged(object sender, EventArgs e)
        {
            gard();
        }
    }
}
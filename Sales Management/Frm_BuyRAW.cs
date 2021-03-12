using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales_Management
{
    public partial class Frm_BuyRAW : Form
    {
        public Frm_BuyRAW()
        {
            InitializeComponent();
        }
        DB db = new DB();

        private void FillItems()
        {
            cbxItems.DataSource = db.RunReader("select * from Raw", "");
            cbxItems.DisplayMember = "Raw_Name";
            cbxItems.ValueMember = "Raw_ID";
        }
        public void FillCustomer()
        {
            cbxSuplier.DataSource = db.RunReader("select * from Suplier Order By  Sup_ID desc", "");
            cbxSuplier.DisplayMember = "Sup_Name";
            cbxSuplier.ValueMember = "Sup_ID";
        }

        public void FillUnit()
        {
            cbxRawUnit.DataSource = db.RunReader("select * from Unit", "");
            cbxRawUnit.DisplayMember = "Unit_Name";
            cbxRawUnit.ValueMember = "Unit_ID";
        }
        int stock_ID;

        private void AutoNum()
        {
            DataTable tblautonum = new DataTable();

            tblautonum.Clear();
            tblautonum = db.RunReader("select max(Order_ID) from BuyRaw", "");
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
                }
                catch (Exception) { }
                DtbSaleDate.Text = DateTime.Now.ToShortDateString();
                DgvStoreQty.Rows.Clear();
            }
            catch (Exception) { }
            cbxItems.Text = "اختر خامة";
            txtTotal.Text = "0";
        }
        private void Frm_BuyRAW_Load(object sender, EventArgs e)
        {
            stock_ID = Convert.ToInt32(Properties.Settings.Default.UserStock);
            
            FillCustomer();
            FillItems();
            FillUnit();
            try
            {
                AutoNum();
            }
            catch (Exception) { }
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
                }
            }
            catch (Exception)
            { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            DataTable tblQty = new DataTable();
            tbl.Clear(); tblQty.Clear();
            if (cbxItems.Text == "اختر خامة")
            {
                MessageBox.Show("من فضلك اختر خامة اولا لشرائها", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (cbxRawUnit.Items.Count <=0 || cbxRawUnit.Text =="" )
            {
                MessageBox.Show("من فضلك اختر وحدة للخامة اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (cbxItems.Items.Count >= 1)
            {

                tbl = db.RunReader("select * from Raw where [Raw_ID]=" + cbxItems.SelectedValue + "", "");
                if (tbl.Rows.Count >= 1)
                {
                    int num = 0;
                    string Item_ID = tbl.Rows[0][0].ToString();
                    string Item_Name = tbl.Rows[0][1].ToString();
                    string Item_Unit = cbxRawUnit.Text;
                    string Item_Qty = "1";
                    string Item_Price = tbl.Rows[0][5].ToString(); 
                  
                    string Item_Discount = "0.0";
                    DgvStoreQty.Rows.Add(1);
                    decimal tot;
                    int rowindex = DgvStoreQty.Rows.Count - 1;
                    DgvStoreQty.Rows[rowindex].Cells[0].Value = Item_ID;
                    DgvStoreQty.Rows[rowindex].Cells[1].Value = Item_Name;
                    DgvStoreQty.Rows[rowindex].Cells[2].Value = Item_Unit;
                    DgvStoreQty.Rows[rowindex].Cells[3].Value = Item_Qty;

                    decimal QtyInUnit = 0, unitPrice = 0;
                    try
                    {
                        QtyInUnit =Convert.ToDecimal( tbl.Rows[0][4].ToString());
                    }
                    catch (Exception) { }
                    
                    if(tbl.Rows[0][3].ToString() == Convert.ToString( DgvStoreQty.Rows[rowindex].Cells[2].Value))
                    {
                        unitPrice = Convert.ToDecimal(Item_Price) / QtyInUnit;
                    }else
                    {
                        unitPrice = Convert.ToDecimal(Item_Price) ;
                    }
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
                    txtTotal.Text = Math.Round(tot, 2).ToString();
                    
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(DgvStoreQty.Rows.Count >= 1)
            {
                int index = 0;
                index = DgvStoreQty.SelectedRows[0].Index;

                Properties.Settings.Default.RawQty =Convert.ToDecimal( DgvStoreQty.Rows[index].Cells[3].Value);
                Properties.Settings.Default.RawDiscount = Convert.ToDecimal(DgvStoreQty.Rows[index].Cells[5].Value);
                Properties.Settings.Default.Save();
                Frm_EditRawQty frm = new Frm_EditRawQty();
                 frm.ShowDialog();
                DgvStoreQty.Rows[index].Cells[3].Value = Properties.Settings.Default.RawQty;
                DgvStoreQty.Rows[index].Cells[5].Value = Properties.Settings.Default.RawDiscount;

                DgvStoreQty.Rows[index].Cells[6].Value = (Convert.ToDecimal(DgvStoreQty.Rows[index].Cells[3].Value) * Convert.ToDecimal(DgvStoreQty.Rows[index].Cells[4].Value)) - (Convert.ToDecimal(DgvStoreQty.Rows[index].Cells[5].Value));
                decimal tot = 0;
                for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                {
                    tot += Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[6].Value);

                    DgvStoreQty.ClearSelection();
                    DgvStoreQty.FirstDisplayedScrollingRowIndex = DgvStoreQty.RowCount - 1;
                    DgvStoreQty.Rows[DgvStoreQty.RowCount - 1].Selected = true;


                }
                txtTotal.Text = Math.Round(tot, 2).ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(cbxSuplier.Items.Count <= 0 || cbxSuplier.Text =="")
            {
                MessageBox.Show("من فضلك اختر المورد اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string d = DtbSaleDate.Value.ToString("dd/MM/yyyy"); string dREminder = DtbReminder.Value.ToString("dd/MM/yyyy");
            db.RunNunQuary("insert into BuyRaw Values (" + txtOrderID.Text + " , N'" + d + "' ," + cbxSuplier.SelectedValue + " )", "");

            for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
            {
                decimal QtyInUnit = 0, qtyFinal = 0;
                DataTable tblQty = new DataTable();
                tblQty.Clear();
                tblQty = db.RunReader("select * from Raw where Raw_ID=" + DgvStoreQty.Rows[i].Cells[0].Value + "", "");
                try
                {
                    QtyInUnit = Convert.ToDecimal(tblQty.Rows[0][4]);
                }
                catch (Exception) { }

                tblQty.Clear();
                tblQty = db.RunReader("select * from Raw where Raw_ID=" + DgvStoreQty.Rows[i].Cells[0].Value + " and Main_Unit=N'"+ Convert.ToString(DgvStoreQty.Rows[i].Cells[2].Value) + "'", "");
                if (tblQty.Rows.Count >= 1)
                {
                    qtyFinal = Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[3].Value);
                }
                else
                {
                    qtyFinal = Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[3].Value) / QtyInUnit;
                }


                db.RunNunQuary("insert into BuyRawDetalies Values (" + txtOrderID.Text + " ," + DgvStoreQty.Rows[i].Cells[0].Value + "," + cbxSuplier.SelectedValue + " ," + qtyFinal + " ," + DgvStoreQty.Rows[i].Cells[4].Value + ",N'" + d + "'," + DgvStoreQty.Rows[i].Cells[6].Value + ", " + DgvStoreQty.Rows[i].Cells[5].Value + "  ,N'" + DgvStoreQty.Rows[i].Cells[2].Value + "', N'" + Properties.Settings.Default.UserName + "')", "");
                db.RunNunQuary("update Raw set Qty =Qty+ " + qtyFinal + " where Raw_ID=" + DgvStoreQty.Rows[i].Cells[0].Value + "", "");


            }

            //check if customer pay cash or Aagel
            decimal baky = 0; decimal madfou3 = 0;
            if (rbtnAagel.Checked == true)
            {
                madfou3 = Nud.Value;
                baky =Convert.ToDecimal( txtTotal.Text ) - Nud.Value;
                db.RunNunQuary("insert into Suplier_Money Values (" + txtOrderID.Text + "," + baky + "," + cbxSuplier.SelectedValue + ",'" + d + "' ,'" + dREminder + "')", "");
            }
            else
            {
                madfou3 = Convert.ToDecimal(txtTotal.Text);
            }
                db.RunNunQuary("insert into Suplier_Report Values(" + txtOrderID.Text + " ,N'" + cbxSuplier.Text + "'," +madfou3  + ",N'" + d + "')", "");
            
            //insert the money into the stock 
        
            AutoNum();
        }
    }
}

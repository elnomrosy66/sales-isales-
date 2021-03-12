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
    public partial class Frm_Store_Transfire : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Store_Transfire()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        int introw = 0;
        public void FillUnit()
        {

            cbxUnit.DataSource = db.RunReader("select * from Items_Unit where Item_ID="+cbxItems.SelectedValue+"", "");
            cbxUnit.DisplayMember = "Unit_Name";
            cbxUnit.ValueMember = "Unit_ID";
        }
        private void FillItems() {
            cbxItems.DataSource = db.RunReader("select * from Items", "");
            cbxItems.ValueMember = "Item_ID";
            cbxItems.DisplayMember = "Item_Name";



            cbxStoreFrom.DataSource = db.RunReader("select * from Store", "");
            cbxStoreFrom.DisplayMember = "Store_Name";
            cbxStoreFrom.ValueMember = "Store_ID";

            cbxStoreTo.DataSource = db.RunReader("select * from Store", "");
            cbxStoreTo.DisplayMember = "Store_Name";
            cbxStoreTo.ValueMember = "Store_ID";
        }
        private void AutoNum() {

            txtBarcode.Clear();
            txtName.Clear();
            txtReason.Clear();
            DtbSaleDate.Text = DateTime.Now.ToShortDateString();
            try
            {
                cbxItems.SelectedIndex = 0;
                cbxStoreFrom.SelectedIndex = 0;
                NudBuyPrice.Value = 0;
                NudSalePrice.Value = 0;
                cbxStoreTo.SelectedIndex = 0;
                cbxUnit.SelectedIndex = 0;
            }
            catch (Exception) { }
            NudQty.Value = 0;
        }
        private void Frm_Store_Transfire_Load(object sender, EventArgs e)
        {
            try
            {
                FillItems();
                FillUnit();
                AutoNum();
            }
            catch (Exception) { }
        }

        private void cbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                cbxUnit.DataSource = db.RunReader("select * from Items_Unit where Item_ID=" + cbxItems.SelectedValue + "", "");
                cbxUnit.DisplayMember = "Unit_Name";
                cbxUnit.ValueMember = "Unit_ID";
            }
            catch (Exception) { }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                
                if (txtBarcode.Text != "") {

                    tbl.Clear();
                    tbl=db.RunReader("select * from Items where barcode='"+txtBarcode.Text+"'","") ;
                    if (tbl.Rows.Count >= 1)
                    {
                        try
                        {
                            cbxItems.SelectedValue = Convert.ToInt32(tbl.Rows[0][0]);
                        }
                        catch (Exception) { }
                    }
                    else { MessageBox.Show("لا يوجد منتج مماثل لهذا الباركود","تاكيد",MessageBoxButtons.OK ,MessageBoxIcon.Information);AutoNum(); }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable(); DataTable tblQty = new DataTable(); DataTable tblStore = new DataTable();
            tbl.Clear(); tblQty.Clear(); tblStore.Clear();
            decimal QtyInUnit = 1; decimal qtyFinal = 1;decimal def=1;
            if (cbxItems.Items.Count >= 1) 
            { 
              if(cbxStoreFrom.Items.Count >=1 )
              {
                  if (cbxUnit.Items.Count >= 1)
                  {
                      if (NudBuyPrice.Value <= 0) { MessageBox.Show("من فضلك ادخل شراء المنتج","تاكيد",MessageBoxButtons.OK,MessageBoxIcon.Information); return; }
                      if (NudSalePrice.Value <= 0) { MessageBox.Show("من فضلك ادخل بيع المنتج", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                      if (Convert.ToInt32(cbxStoreFrom.SelectedValue ) == Convert.ToInt32(cbxStoreTo.SelectedValue)) { MessageBox.Show("لا يمكن التحويل الى نفس المخزن من فضلك حدد مخزن اخر", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                      tblQty = db.RunReader("select * from Items_Unit where Item_ID=" + cbxItems.SelectedValue + " and Unit_Name=N'" + cbxUnit.Text + "'", "");
                      try
                      {
                          QtyInUnit = Convert.ToDecimal(tblQty.Rows[0][3]);
                      }
                      catch (Exception) { }
                      if (QtyInUnit >= 1)
                      {
                          qtyFinal = Convert.ToDecimal(NudQty.Value) / QtyInUnit;
                      }
                      try
                      {
                          tblStore = db.RunReader("select sum( Qty )  from Items_Qty where Item_ID=" + cbxItems.SelectedValue + " and Store_ID=" + cbxStoreFrom.SelectedValue + "  ", "");
                          if ((tblStore.Rows[0][0].ToString() == DBNull.Value.ToString())) 
                          { def = 0 - qtyFinal;
                          MessageBox.Show("المخزن المحدد لا يوجد فيه الكمية التى تريد تحوليها من فضلك راجع كميات المخزن", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          return;
                          }
                          else {
                              def = Convert.ToDecimal(tblStore.Rows[0][0]) - qtyFinal;
                          }
                      }
                      catch (Exception) { }
                      if (def < 0)
                      {
                          MessageBox.Show("المخزن المحدد لا يوجد فيه الكمية التى تريد تحوليها من فضلك راجع كميات المخزن", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          return;
                      }

                      try
                      {
                          UpdateQtyFromStore(Convert.ToInt32(cbxItems.SelectedValue), NudQty.Value, 0, qtyFinal);
                      }
                      catch (Exception) { }
                       string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
                      db.RunNunQuary("delete from  Items_Qty where  Qty <= 0", "");
                      db.RunNunQuary("insert into Items_Qty Values ("+cbxItems.SelectedValue+" , "+cbxStoreTo.SelectedValue+" ,N'"+cbxStoreTo.Text+"' , "+qtyFinal+" , "+NudBuyPrice.Value+" , "+NudSalePrice.Value+" ,'')", "");
                      db.RunNunQuary("insert into Items_Transfire (Item_ID,Item_Name ,Store_From ,Store_To,Qty,Unit,Price_Buy,Price_Sale,Date,TranFire_Name,Reason) Values ("+cbxItems.SelectedValue+" ,N'"+cbxItems.Text+"' ,N'"+cbxStoreFrom.Text+"' ,N'"+cbxStoreTo.Text+"' ,"+NudQty.Value+" ,N'"+cbxUnit.Text+"' ,"+NudBuyPrice.Value+" , "+NudSalePrice.Value+",'"+d+"' ,'"+txtName.Text+"' , '"+txtReason.Text+"')", "تم تحويل الكمية من مخزن  "+cbxStoreFrom.Text+" الى مخزن"+cbxStoreTo.Text);
                      AutoNum();
                  }
              }
            }
        }


       






        private void UpdateQtyFromStore(int row, decimal qty, int i, decimal qtyPart)
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
                tblPrice = db.RunReader("select Top 1 * from Items_Qty where Item_ID=" + row + " and Qty >=1 and Store_ID="+cbxStoreFrom.SelectedValue+"", "");
                tblUnit = db.RunReader("select * from Items_Unit where Item_ID=" + row + " and Unit_Name=N'" + cbxUnit.Text + "'", "");
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
                    db.RunNunQuary("update Items_Qty set Qty =Qty -(" + qtyPart + ") where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + " and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");
                    tblPrice = db.RunReader("select Top 1 * from Items_Qty where Item_ID=" + row + " and Qty >=1 and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");
                    qtyDef = Convert.ToDecimal(db.RunReader("select Top 1 (Qty) from Items_Qty where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + " and Store_ID=" + cbxStoreFrom.SelectedValue + "", "").Rows[0][0]);
                    if (qtyDef <= 0)
                    {
                        db.RunNunQuary("delete from Items_Qty where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + " and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");
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
                    tblQty = db.RunReader("select * from Items_Qty where Item_ID=" + row + " and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");
                    for (int x = 0; x <= tblQty.Rows.Count - 1; x++)
                    {


                        tblPrice = db.RunReader("select Top 1 * from Items_Qty where Item_ID=" + row + " and Qty >=1 and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");

                        qtyDef = Convert.ToDecimal(tblPrice.Rows[0][3]) - num;
                        if (qtyDef < 0)
                        {
                            Math.Abs(qtyDef);
                            def = Math.Abs(num + qtyDef);
                            QTYDEF = def;
                            db.RunNunQuary("update Items_Qty set Qty =Qty -(" + QTYDEF + ") where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + " and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");
                            num -= QTYDEF;
                        }
                        else
                        {

                            db.RunNunQuary("update Items_Qty set Qty =Qty -(" + DEF + ") where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + " and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");
                            num -= DEF;
                        }

                        tblPrice = db.RunReader("select Top 1 * from Items_Qty where Item_ID=" + row + " and Qty <=0 and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");
                        if (Convert.ToInt32(tblPrice.Rows[0][3]) <= 0)
                        {
                            db.RunNunQuary("delete from Items_Qty where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + " and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");
                        }
                        tblPrice.Clear();
                        tblPrice = db.RunReader("select Top 1 * from Items_Qty where Item_ID=" + row + " and Qty >=1 and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");


                        qtyDef = Convert.ToDecimal(tblPrice.Rows[0][3]) - num;
                        if (qtyDef < 0)
                        {
                            Math.Abs(qtyDef);
                            def = Math.Abs(num + qtyDef);
                            QTYDEF = def;
                            db.RunNunQuary("update Items_Qty set Qty =Qty -(" + QTYDEF + ") where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + " and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");
                            num -= QTYDEF;
                            db.RunNunQuary("delete from Items_Qty where Item_ID=" + row + " and Qty <=0 and Store_ID=" + cbxStoreFrom.SelectedValue + " ", "");
                        }
                        else if (qtyDef == 0)
                        {
                            db.RunNunQuary("update Items_Qty set Qty =Qty -(" + num + ") where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + " and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");
                            num = 0;
                            db.RunNunQuary("delete from Items_Qty where Item_ID=" + row + " and Qty <=0  and Store_ID=" + cbxStoreFrom.SelectedValue + " ", "");
                        }
                        else if (qtyDef >= 1)
                        {
                            db.RunNunQuary("update Items_Qty set Qty =Qty -(" + num + ") where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + " and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");
                            num -= num;
                        }
                        tblPrice = db.RunReader("select Top 1 * from Items_Qty where Item_ID=" + row + " and Qty <=0 and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");
                        if (tblPrice.Rows.Count >= 1)
                        {
                            db.RunNunQuary("delete from Items_Qty where Item_ID=" + row + " and Qty=" + tblPrice.Rows[0][3] + " and Price_Buy=" + tblPrice.Rows[0][4] + " and Store_ID=" + cbxStoreFrom.SelectedValue + " ", "");
                        }
                        if (num <= 0)
                        {
                            db.RunNunQuary("delete from Items_Qty where Item_ID=" + row + " and Qty <=0 and Store_ID=" + cbxStoreFrom.SelectedValue + " ", "");

                            DEF = num;
                        }
                        else
                        { DEF = num; }

                    }
                }
            }
            catch (Exception) { }
            db.RunNunQuary("delete from Items_Qty where Item_ID=" + row + " and Qty <=0 and Store_ID=" + cbxStoreFrom.SelectedValue + " ", "");
         

        }


    }
}
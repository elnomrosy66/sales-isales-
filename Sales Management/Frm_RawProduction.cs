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
    public partial class Frm_RawProduction : Form
    {


        private static Frm_RawProduction frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_RawProduction GetMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_RawProduction();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public Frm_RawProduction()
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
        private void FillRaw()
        {
            cbxRaw.DataSource = db.RunReader("select * from Raw", "");
            cbxRaw.DisplayMember = "Raw_Name";
            cbxRaw.ValueMember = "Raw_ID";
        }
        private void FillStore()
        {
            cbxStore.DataSource = db.RunReader("select * from Store", "");
            cbxStore.DisplayMember = "Store_Name";
            cbxStore.ValueMember = "Store_ID";
        }
        private void FillUnit()
        {
            cbxUnitItems.DataSource = db.RunReader("select * from Items_Unit where Item_ID = " + cbxItems.SelectedValue.ToString() + "", "");
            cbxUnitItems.DisplayMember = "Unit_Name";
            cbxUnitItems.ValueMember = "Unit_ID";
            cbxUnitRaw.DataSource = db.RunReader("select * from Unit", "");
            cbxUnitRaw.DisplayMember = "Unit_Name";
            cbxUnitRaw.ValueMember = "Unit_ID";
        }

        private void AutoNum()
        {
            DataTable tblautonum = new DataTable();

            tblautonum.Clear();
            tblautonum = db.RunReader("select max(Raw_Pro_ID) from Raw_Production", "");
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
                    cbxStore.SelectedIndex = 0;
                    cbxUnitRaw.SelectedIndex = 0;
                    cbxUnitItems.SelectedIndex = 0;
                    cbxRaw.SelectedIndex = 0;
                    
                }
                catch (Exception) { }
                DtbSaleDate.Text = DateTime.Now.ToShortDateString();
                DtpExpired.Text = DateTime.Now.ToShortDateString();
                txtTotal.Text = "0";
                DgvStoreQty.Rows.Clear();
                NudBuyPrice.Value = 1;
                NudQtyItems.Value = 1;
                NudQtyRaw.Value = 1;
                NudSalePrice.Value = 1;
            }
            catch (Exception) { }
        }


        private void Frm_RawProduction_Load(object sender, EventArgs e)
        {
            try {
                FillItems();
                FillRaw();
                FillStore();
                FillUnit();
                
            }
            catch (Exception) { }
            try { AutoNum(); }
            catch (Exception) { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            DataTable tblQty = new DataTable();
            tbl.Clear(); tblQty.Clear();
            if (cbxRaw.Items.Count >= 1 && cbxUnitRaw.Items.Count >=1)
            {

                tbl = db.RunReader("select * from Raw where [Raw_ID]=" + cbxRaw.SelectedValue + "", "");
                if (tbl.Rows[0][2].ToString() != cbxUnitRaw.Text && tbl.Rows[0][3].ToString() != cbxUnitRaw.Text)
                {
                  MessageBox.Show("الوحدة التي تم اختيارها غير معرفة علي هذه الخامة الرجاء اختيار وحدة معرفة للخامة المحددة");
                  return;
                }
                if (tbl.Rows.Count >= 1)
                {
                    int num = 0;
                    string Raw_ID = tbl.Rows[0][0].ToString();
                    string Raw_Name = tbl.Rows[0][1].ToString();
                    string Item_Unit = cbxUnitRaw.Text;
                    string Item_Qty = NudQtyRaw.Value.ToString();
                    string Item_Price = tbl.Rows[0][5].ToString();
                    DgvStoreQty.Rows.Add(1);
                    decimal tot;
                    int rowindex = DgvStoreQty.Rows.Count - 1;
                    DgvStoreQty.Rows[rowindex].Cells[0].Value = Raw_ID;
                    DgvStoreQty.Rows[rowindex].Cells[1].Value = Raw_Name;
                    DgvStoreQty.Rows[rowindex].Cells[2].Value = cbxUnitRaw.Text;
                    DgvStoreQty.Rows[rowindex].Cells[3].Value = NudQtyRaw.Value;

                    decimal QtyInUnit = 0, unitPrice = 0;
                    try
                    {
                        QtyInUnit = Convert.ToDecimal(tbl.Rows[0][4].ToString());
                    }
                    catch (Exception) { }

                    if (tbl.Rows[0][3].ToString() == Convert.ToString(DgvStoreQty.Rows[rowindex].Cells[2].Value))
                    {
                        unitPrice = Convert.ToDecimal(Item_Price) / QtyInUnit;
                    }
                    else
                    {
                        unitPrice = Convert.ToDecimal(Item_Price);
                    }
                    DgvStoreQty.Rows[rowindex].Cells[4].Value = unitPrice;
                    decimal Total = (Convert.ToDecimal(Item_Qty) * Convert.ToDecimal(unitPrice));
                    DgvStoreQty.Rows[rowindex].Cells[4].Value = Total;
                    tot = 0;
                    for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                    {
                        tot += Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[4].Value);

                        DgvStoreQty.ClearSelection();
                        DgvStoreQty.FirstDisplayedScrollingRowIndex = DgvStoreQty.RowCount - 1;
                        DgvStoreQty.Rows[DgvStoreQty.RowCount - 1].Selected = true;
                    }
                    NudBuyPrice.Value = Math.Round(tot, 2) / NudQtyItems.Value;
                }
            }
        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (DgvStoreQty.Rows.Count >= 1)
                {
                    int index = DgvStoreQty.SelectedRows[0].Index;
                    DgvStoreQty.Rows.RemoveAt(index);
                    decimal tot = 0;
                    for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                    {
                        tot += Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[4].Value);

                        DgvStoreQty.ClearSelection();
                        DgvStoreQty.FirstDisplayedScrollingRowIndex = DgvStoreQty.RowCount - 1;
                        DgvStoreQty.Rows[DgvStoreQty.RowCount - 1].Selected = true;
                    }
                    NudBuyPrice.Value = Math.Round(tot, 2);
                }
            }
            catch (Exception)
            { }
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                string d = DtbSaleDate.Value.ToString("yyyy-MM-dd");
                if (cbxStore.Items.Count <= 0) { MessageBox.Show("من فضلك اختر المخزن الذى سيتم تخزين فيه المنتج بعد تصنيعه","تاكيد",MessageBoxButtons.OK,MessageBoxIcon.Information) ; return; }
                if (cbxItems.Items.Count <= 0) { MessageBox.Show("من فضلك اختر اسم المنتج الذى تريد تصنيعه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                if (NudQtyRaw.Value <= 0) { MessageBox.Show("ادخل الكمية التى تريد تصنيعها من الماده الخام", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                if (NudBuyPrice.Value <= 0) { MessageBox.Show("من فضلك ادخل سعر الشراء للمنتج المصنع", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                if (NudSalePrice.Value <= 0) { MessageBox.Show("من فضلك ادخل سعر البيع للمنتج المصنع", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                if (NudQtyItems.Value <= 0) { MessageBox.Show("من فضلك ادخل كمية المنتج الذى تريد انتاجه بعد الانتاج", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                if (DgvStoreQty.Rows.Count <= 0) { MessageBox.Show("لا يوجد عمليات حتى يتم حفظها", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                DataTable tblRaw = new DataTable();
                for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                {

                    tblRaw.Clear();
                    tblRaw = db.RunReader("select * from Raw where Raw_ID=" + DgvStoreQty.Rows[i].Cells[0].Value + "", "");
                    decimal QtyinRaw = 0;
                    decimal qty = 0;
                    QtyinRaw = Convert.ToDecimal(tblRaw.Rows[0][4]);

                    if (Convert.ToString(DgvStoreQty.Rows[i].Cells[2].Value) == Convert.ToString(tblRaw.Rows[0][3]))
                    {
                        qty = Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[3].Value) / QtyinRaw;
                    }
                    else
                    {
                        qty = Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[3].Value);
                    }

                    if (Convert.ToDecimal(tblRaw.Rows[0][7]) - qty < 0)
                    {
                        MessageBox.Show("الكمية الموجوده فى المخزن من الخامة " + DgvStoreQty.Rows[i].Cells[1].Value + " غير كافية للتصنيع راجع الكميات فى المخزن", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                
                
                db.RunNunQuary("insert into Raw_Production values (" + txtOrderID.Text + " , N'" + d + "')", "");

                for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                {
                    decimal total_qty = Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[3].Value.ToString()) * Convert.ToDecimal(NudQtyItems.Value);
                    db.RunNunQuary("insert into Raw_Production_Detalis Values (" + txtOrderID.Text + " , '" + d + "' ," + DgvStoreQty.Rows[i].Cells[0].Value + " ,'" + DgvStoreQty.Rows[i].Cells[1].Value + "','" + DgvStoreQty.Rows[i].Cells[2].Value + "' ," + total_qty + ","+cbxItems.SelectedValue+" ,'"+cbxUnitItems.Text+"',"+NudQtyItems.Value+ "  )", "");
                }
                decimal qtyItem = QtyInItems(Convert.ToInt32(cbxItems.SelectedValue));
                decimal QtyItemMain = 0;
                try
                {
                  QtyItemMain = NudQtyItems.Value / qtyItem;
                }
                catch (Exception) { }
                string dEx = DtpExpired.Value.ToString("dd/MM/yyyy");
                db.RunNunQuary("insert into Items_Qty Values (" + cbxItems.SelectedValue + " , " + cbxStore.SelectedValue + " , '" + cbxStore.Text + "' , " + QtyItemMain + " , " + NudBuyPrice.Value + " ," + NudSalePrice.Value + " ,'"+ dEx + "')", "");
                db.RunNunQuary("update Items set Item_Qty=Item_Qty + (" + QtyItemMain + ") where Item_ID="+cbxItems.SelectedValue+"", "");
                DataTable tblTest = new DataTable();
                for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                {
                    tblTest.Clear();
                    tblTest = db.RunReader("select * from Raw where Raw_ID=" + DgvStoreQty.Rows[i].Cells[0].Value + "", "");
                    decimal QtyinRaw = 0;
                    decimal qty = 0;
                    QtyinRaw = Convert.ToDecimal(tblTest.Rows[0][4]);
                    
                    if (Convert.ToString(DgvStoreQty.Rows[i].Cells[2].Value) == Convert.ToString(tblTest.Rows[0][3]))
                    {
                        qty = Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[3].Value) / QtyinRaw;
                    }else
                    {
                        qty = Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[3].Value) ;
                    }
                    
                    db.RunNunQuary("update Raw set Qty=Qty - (" + qty + ") where Raw_ID=" + DgvStoreQty.Rows[i].Cells[0].Value + "", "");
                }
                AutoNum();
                MessageBox.Show("تمت العملية بنجاح","تاكيد",MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }
            catch (Exception) { }
        }


        private decimal QtyInItems(int num) {

            DataTable tblQty = new DataTable();
            tblQty.Clear();
            tblQty = db.RunReader("select * from Items_Unit where Item_ID="+num+" and Unit_Name='"+cbxUnitItems.Text+"'","");
            decimal n = 0;
            n =  Convert.ToDecimal(tblQty.Rows[0][3]);
            return n;
        }

        private void cbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                cbxUnitItems.DataSource = db.RunReader("select * from Items_Unit where Item_ID=" + cbxItems.SelectedValue + " and Qty_In_Main = 1 ", "");
                cbxUnitItems.DisplayMember = "Unit_Name";
                cbxUnitItems.ValueMember = "Unit_ID";
                


            }
            catch (Exception ex) {  }
        }

        private void cbxItems_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int Item_ID = Convert.ToInt32(cbxItems.SelectedValue);
            int Item_Unit = Convert.ToInt32(cbxUnitItems.SelectedValue);
            DataTable tblPrice = new DataTable();
            tblPrice = db.RunReader("select * from Items_Unit where Item_ID=" + Item_ID + " and Unit_Name=N'" + cbxUnitItems.Text + "'", "");
            decimal price = 0;
            price = Convert.ToDecimal(tblPrice.Rows[0][5]) / Convert.ToDecimal(tblPrice.Rows[0][3]);
            NudSalePrice.Value = price;
        }

        private void cbxUnitItems_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int Item_ID = Convert.ToInt32(cbxItems.SelectedValue);
            int Item_Unit = Convert.ToInt32(cbxUnitItems.SelectedValue);
            DataTable tblPrice = new DataTable();
            tblPrice = db.RunReader("select * from Items_Unit where Item_ID=" + Item_ID + " and Unit_Name=N'" + cbxUnitItems.Text + "'", "");
            decimal price = 0;
            price = Convert.ToDecimal(tblPrice.Rows[0][5]) / Convert.ToDecimal(tblPrice.Rows[0][3]);
            NudSalePrice.Value = price;
        }

        private void NudSalePrice_ValueChanged(object sender, EventArgs e)
        {
        }

        private void NudQtyItems_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal tot = 0;
                for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                {
                    tot += Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[4].Value);

                    DgvStoreQty.ClearSelection();
                    DgvStoreQty.FirstDisplayedScrollingRowIndex = DgvStoreQty.RowCount - 1;
                    DgvStoreQty.Rows[DgvStoreQty.RowCount - 1].Selected = true;
                }
                NudBuyPrice.Value = Math.Round(tot, 3) / 1;
            }
            catch (Exception ex) { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int Item_ID = Convert.ToInt32(cbxItems.SelectedValue);
            DataTable row_data = new DataTable();
            row_data.Clear();
            DgvStoreQty.DataSource = row_data;
            DgvStoreQty.DataSource = null;
            //maxdate = db.RunReader("select MAX(Date) from Raw_Production_Detalis where items_id=" + Item_ID + " and Unit_Items=N'" + cbxUnitItems.Text + "' ", "");
            //MessageBox.Show(maxdate.Rows[0][0].ToString());
            //DataTable maxid = new DataTable();
            //maxid = db.RunReader("select MAX(Raw_Pro_ID) from Raw_Production_Detalis where items_id=" + Item_ID + " and Unit_Items=N'" + cbxUnitItems.Text + "' and Date = '" + maxdate.Rows[0][0] + "' ", "");
            //MessageBox.Show(maxid.Rows[0][0].ToString());
            //DataTable rows = new DataTable();
            //rows = db.RunReader("select * from Raw_Production_Detalis where items_id=" + Item_ID + " and Unit_Items=N'" + cbxUnitItems.Text + "' and Date = '" + maxdate.Rows[0][0] + "' and Raw_Pro_ID = '" + maxid.Rows[0][0] + "' ", "");
            ////DgvStoreQty.DataSource = rows;
            row_data = db.RunReader("select Raw_ID as 'رقم الخامة' , Raw_Name as 'اسم الخامة',Unit_Raw as 'الوحدة',Qty_Raw as 'الكمية' from prod_data where Items_ID=" + cbxItems.SelectedValue.ToString() + " ", "");
            if(row_data.Rows.Count < 1)
            {
                MessageBox.Show("لا يوجد بيانات تصنيع مسجلة لهذا الصنف");
            }
            foreach (DataRow r in row_data.Rows)
            {
                //MessageBox.Show(r[1].ToString());
                DataTable tbl = new DataTable();
                DataTable tblQty = new DataTable();
                tbl.Clear(); tblQty.Clear();
                if (cbxRaw.Items.Count >= 1 && cbxUnitRaw.Items.Count >= 1)
                {

                    tbl = db.RunReader("select * from Raw where [Raw_ID]=" + r[0] + "", "");
                    //if (tbl.Rows[0][2].ToString() != cbxUnitRaw.Text && tbl.Rows[0][3].ToString() != cbxUnitRaw.Text)
                    //{
                    //    MessageBox.Show("الوحدة التي تم اختيارها غير معرفة علي هذه الخامة الرجاء اختيار وحدة معرفة للخامة المحددة");
                    //    return;
                    //}
                    if (tbl.Rows.Count >= 1)
                    {
                        int num = 0;
                        string Raw_ID = tbl.Rows[0][0].ToString();
                        string Raw_Name = tbl.Rows[0][1].ToString();
                        string Item_Unit = cbxUnitRaw.Text;
                        string Item_Qty = r[3].ToString();
                        string Item_Price = tbl.Rows[0][5].ToString(); // row price
                        DgvStoreQty.Rows.Add(1);
                        decimal tot;
                        int rowindex = DgvStoreQty.Rows.Count - 1;
                        DgvStoreQty.Rows[rowindex].Cells[0].Value = Raw_ID;
                        DgvStoreQty.Rows[rowindex].Cells[1].Value = r[1];
                        DgvStoreQty.Rows[rowindex].Cells[2].Value = r[2];
                        DgvStoreQty.Rows[rowindex].Cells[3].Value = (Convert.ToDecimal(r[3])).ToString();

                        decimal QtyInUnit = 0, unitPrice = 0;
                        try
                        {
                            QtyInUnit = Convert.ToDecimal(tbl.Rows[0][4].ToString());
                        }
                        catch (Exception) { }

                        if (tbl.Rows[0][3].ToString() == Convert.ToString(DgvStoreQty.Rows[rowindex].Cells[2].Value))
                        {
                            unitPrice = Convert.ToDecimal(Item_Price) / QtyInUnit;
                        }
                        else
                        {
                            unitPrice = Convert.ToDecimal(Item_Price);
                        }
                        DgvStoreQty.Rows[rowindex].Cells[4].Value = unitPrice;
                        decimal Total = (Convert.ToDecimal(Item_Qty) * Convert.ToDecimal(unitPrice));
                        DgvStoreQty.Rows[rowindex].Cells[4].Value = Total;
                        tot = 0;
                        for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                        {
                            tot += Convert.ToDecimal(DgvStoreQty.Rows[i].Cells[4].Value);

                            DgvStoreQty.ClearSelection();
                            DgvStoreQty.FirstDisplayedScrollingRowIndex = DgvStoreQty.RowCount - 1;
                            DgvStoreQty.Rows[DgvStoreQty.RowCount - 1].Selected = true;
                        }
                        NudBuyPrice.Value = Math.Round(tot, 2) / NudQtyItems.Value;
                    }
                }


            
            }





            
        }
    }
}

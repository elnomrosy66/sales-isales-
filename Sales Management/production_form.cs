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

    public partial class production_form : Form
    {
        DataTable tbl = new DataTable();
        public production_form()
        {
            InitializeComponent();
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

        private void FillUnit()
        {

            cbxUnitRaw.Items.Clear();
            DataTable rowunits = new DataTable();
            rowunits = db.RunReader("select * from Raw where Raw_ID = "+cbxRaw.SelectedValue.ToString()+" ", "");
            cbxUnitRaw.Items.Add(rowunits.Rows[0][2]);
            cbxUnitRaw.Items.Add(rowunits.Rows[0][3]);
            cbxUnitRaw.SelectedIndex = 0;
        }


        private void production_form_Load(object sender, EventArgs e)
        {
            try
            {
                FillItems();
                FillRaw();
                cbxRaw.SelectedIndex = 0;
                get_prod_data();
               FillUnit();
            }
            catch (Exception) { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            DgvStoreQty.DataSource = null;
            DataTable tblQty = new DataTable();
            tbl.Clear(); tblQty.Clear();
            if (cbxRaw.Items.Count >= 1 && cbxUnitRaw.Items.Count >= 1)
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
                    //NudBuyPrice.Value = Math.Round(tot, 2) / NudQtyItems.Value;
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
                    //NudBuyPrice.Value = Math.Round(tot, 2);
                }
            }
            catch (Exception)
            { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxItems.Items.Count <= 0) { MessageBox.Show("من فضلك اختر اسم المنتج الذى تريد تصنيعه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                if (NudQtyRaw.Value <= 0) { MessageBox.Show("ادخل الكمية التى تريد تصنيعها من الماده الخام", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
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
                }


                //db.RunNunQuary("insert into production (title , item_id) values (" + cbxItems.SelectedText.ToString() + " , " + cbxItems.SelectedValue.ToString() + "')", "");
                db.RunNunQuary("delete from prod_data where Items_ID = " + cbxItems.SelectedValue.ToString() + "", "");

                for (int i = 0; i <= DgvStoreQty.Rows.Count - 1; i++)
                {
                    //MessageBox.Show(DgvStoreQty.Rows.Count.ToString());
                    db.RunNunQuary("insert into prod_data Values (" + DgvStoreQty.Rows[i].Cells[0].Value + " ,'" + DgvStoreQty.Rows[i].Cells[1].Value + "','" + DgvStoreQty.Rows[i].Cells[2].Value + "' ," + DgvStoreQty.Rows[i].Cells[3].Value + "," + cbxItems.SelectedValue + "  )", "");
                }
                DataTable tbl2 = new DataTable();
                DgvStoreQty.DataSource = tbl2;
                DgvStoreQty.DataSource = null;
                MessageBox.Show("تم الحفظ بنجاح");
                get_prod_data();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_prod_data();
            //FillRaw();
            //FillUnit();
        }

        private void get_prod_data()
        {
            DataTable tbl2 = new DataTable();
            DgvStoreQty.DataSource = tbl2;
            DgvStoreQty.DataSource = null;
            //tblRaw.Clear();
            tbl.Clear();
            tbl = db.RunReader("select Raw_ID as 'رقم الخامة' , Raw_Name as 'اسم الخامة',Unit_Raw as 'الوحدة',Qty_Raw as 'الكمية' from prod_data where Items_ID=" + cbxItems.SelectedValue.ToString() + " ", "");
            if(tbl.Rows.Count<1)
            {
                MessageBox.Show("لا يوجد بيانات تصنيع مسجلة لهذا الصنف");
                return;
            }
           
            foreach (DataRow r in tbl.Rows)
            {
                DgvStoreQty.Rows.Add(1);
                int rowindex = DgvStoreQty.Rows.Count - 1;
                DgvStoreQty.Rows[rowindex].Cells[0].Value = r[0];
                DgvStoreQty.Rows[rowindex].Cells[1].Value = r[1];
                DgvStoreQty.Rows[rowindex].Cells[2].Value = r[2];
                DgvStoreQty.Rows[rowindex].Cells[3].Value = r[3];
            }
        }

        private void cbxRaw_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillUnit();
        }
    }
}

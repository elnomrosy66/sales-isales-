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
    public partial class Frm_StockTransfire : Form
    {
        public Frm_StockTransfire()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable();
        DB db = new DB();
        public void FillStock()
        {
            cbxStock.DataSource = db.RunReader("select * from Stock_Data", "");
            cbxStock.DisplayMember = "Stock_Name";
            cbxStock.ValueMember = "Stock_ID";

            comboBox1.DataSource = db.RunReader("select * from Stock_Data", "");
            comboBox1.DisplayMember = "Stock_Name";
            comboBox1.ValueMember = "Stock_ID";
        }
        private void Frm_StockTransfire_Load(object sender, EventArgs e)
        {
            FillStock();
            NudMoney.Value = 0;
            txtItemName.Clear();
            txtReason.Clear();
            cbxStock.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            DtbDate.Text = DateTime.Now.ToShortDateString();
        }

        private void cbxStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal Money = 0;
            tbl.Clear();
            try
            {
                tbl = db.RunReader("select Money from Stock where Stock_ID=" + cbxStock.SelectedValue + "", "");
                if (tbl.Rows.Count >= 1)
                    Money = Convert.ToDecimal(tbl.Rows[0][0]);
                else
                    Money = 0;
                lblCurrentMoney.Text = Money.ToString();



            }
            catch (Exception) { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal Money = 0;
            tbl.Clear();
            try
            {
                tbl = db.RunReader("select Money from Stock where Stock_ID=" + comboBox1.SelectedValue + "", "");
                if (tbl.Rows.Count >= 1)
                    Money = Convert.ToDecimal(tbl.Rows[0][0]);
                else
                    Money = 0;
                label6.Text = Money.ToString();



            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxStock.Items.Count >= 1)
            {
                if (txtItemName.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم المسؤل عن عمليه التحويل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (NudMoney.Value <= 0)
                {
                    MessageBox.Show("لا يمكن تحويل مبلغ صفر", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (lblCurrentMoney.Text == "...")
                { MessageBox.Show("من فضلك حدد خزنه لكى تستطيع تحويل الرصيد منها", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                if (Convert.ToInt32(cbxStock.SelectedValue) == Convert.ToInt32(comboBox1.SelectedValue))
                { MessageBox.Show("لا يمكن تحويل رصيد الى نفس الخزنه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                if (NudMoney.Value > Convert.ToDecimal(lblCurrentMoney.Text))
                { MessageBox.Show("الرصيد الذى تحاول تحويله اكبر من الرصيد الحالى للخزنه المحدده  " + cbxStock.Text, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                string d = DtbDate.Value.ToString("dd/MM/yyyy");

                DataTable tblCheck = new DataTable();
                tblCheck.Clear();
                tblCheck = db.RunReader("select * from Stock where Stock_ID=" + cbxStock.SelectedValue + "", "");
                int count = 0;
                for (int i = 0; i <= tblCheck.Rows.Count - 1; i++)
                {

                    if (Convert.ToInt32(tblCheck.Rows[i][0]) == Convert.ToInt32(comboBox1.SelectedValue))
                    {
                        count++;
                    }
                }
                if (count >= 1)
                {
                    db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type ,Reason,Stock_ID) Values(" + NudMoney.Value + " ,'" + d + "' ,N'" + txtItemName.Text + "' ,'سحب من الخزنة' ,'تحويل الى خزنه اخرى' ," + cbxStock.SelectedValue + ")", "");
                    db.RunNunQuary(" insert into Money_Transfire (Money ,Date,Name ,From_ ,To_ ,Reason) Values (" + NudMoney.Value + " ,'" + d + "' ,N'" + txtItemName.Text + "' ," + cbxStock.SelectedValue + " ," + comboBox1.SelectedValue + " ,N'" + txtReason.Text + "')", "");
                    db.RunNunQuary("update Stock set Money=Money-" + NudMoney.Value + " where Stock_ID=" + cbxStock.SelectedValue + "", "");
                    db.RunNunQuary("update Stock set Money=Money+" + NudMoney.Value + " where Stock_ID=" + comboBox1.SelectedValue + "", "");
                }
                else {
                    db.RunNunQuary("insert into stock values (" + comboBox1.SelectedValue + " , 0)", "");
                    db.RunNunQuary("insert into Stock_Pull  (Money ,Date,Name ,Type ,Reason,Stock_ID) Values(" + NudMoney.Value + " ,'" + d + "' ,N'" + txtItemName.Text + "' ,'سحب من الخزنة' ,'تحويل الى خزنه اخرى' ," + cbxStock.SelectedValue + ")", "");
                    db.RunNunQuary("insert into Money_Transfire (Money ,Date,Name ,From_ ,To_ ,Reason) Values (" + NudMoney.Value + " ,'" + d + "' ,N'" + txtItemName.Text + "' ," + cbxStock.SelectedValue + " ," + comboBox1.SelectedValue + " ,N'" + txtReason.Text + "')", "");
                    db.RunNunQuary("update Stock set Money=Money-" + NudMoney.Value + " where Stock_ID=" + cbxStock.SelectedValue + "", "");
                    db.RunNunQuary("update Stock set Money=Money+" + NudMoney.Value + " where Stock_ID=" + comboBox1.SelectedValue + "", "");

                }
                MessageBox.Show("تمت عمليه التحويل بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Frm_StockTransfire_Load(null, null);
            }
            else { MessageBox.Show("لا يوجد اى خزنه لكى تقوم بعمليه التحويل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }
    }
}

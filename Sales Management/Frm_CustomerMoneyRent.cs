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
    public partial class Frm_CustomerMoneyRent : DevExpress.XtraEditors.XtraForm
    {
        public Frm_CustomerMoneyRent()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable();
        DB db = new DB();
        private void FillCustomer()
        {
            cbxCustomer.DataSource = db.RunReader("select * from Customer ", "");
            cbxCustomer.DisplayMember = "Cust_Name";
            cbxCustomer.ValueMember = "Cust_ID";
        }
        private void Frm_CustomerMoneyRent_Load(object sender, EventArgs e)
        {

            DtbSaleDate.Text = DateTime.Now.ToShortDateString();
            FillCustomer();
            tbl.Clear();
            decimal Total = 0;
            tbl = db.RunReader("select Order_ID as 'رقم العملية' ,Customer.Cust_Name as 'اسم المكترى',Items.Item_Name as 'اسم الصنف',Qty as 'الكمية',Date as 'تاريخ الاكتراء',Date_Reminder as 'تاريخ الاسترداد',Total_Price as 'مبلغ الاكتراء' ,Price_Reminder as 'المبلغ الباقى' from Customer_Rent_Report,Customer,Items where Items.Item_ID=Customer_Rent_Report.Item_ID and Customer_Rent_Report.Cust_ID=Customer.Cust_ID", "");
            DgvSearchBuy.DataSource = tbl;
            for (int i = 0; i <= tbl.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(tbl.Rows[i][6]);
            }
            txtTotalPhar.Text = Math.Round(Total, 2).ToString();
            txtTotalAll.Text = "";
            NudQtyAll.Value = 1;
            NudAllPrice.Value = 1;
            txtTotalAll.Text = "1";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            decimal Total = 0;
            if (rbtnAllCustomer.Checked == true)
                tbl = db.RunReader("select Order_ID as 'رقم العملية' ,Customer.Cust_Name as 'اسم المكترى',Items.Item_Name as 'اسم الصنف',Qty as 'الكمية',Date as 'تاريخ الاكتراء',Date_Reminder as 'تاريخ الاسترداد',Total_Price as 'مبلغ الاكتراء',Price_Reminder as 'المبلغ الباقى' from Customer_Rent_Report,Customer,Items where Items.Item_ID=Customer_Rent_Report.Item_ID and Customer_Rent_Report.Cust_ID=Customer.Cust_ID", "");
            else
                tbl = db.RunReader("select Order_ID as 'رقم العملية' ,Customer.Cust_Name as 'اسم المكترى',Items.Item_Name as 'اسم الصنف',Qty as 'الكمية',Date as 'تاريخ الاكتراء',Date_Reminder as 'تاريخ الاسترداد',Total_Price as 'مبلغ الاكتراء',Price_Reminder as 'المبلغ الباقى' from Customer_Rent_Report,Customer,Items where Items.Item_ID=Customer_Rent_Report.Item_ID and Customer_Rent_Report.Cust_ID=Customer.Cust_ID and Customer_Rent_Report.Cust_ID=" + cbxCustomer.SelectedValue + "", "");
            if (tbl.Rows.Count >= 1)
            {
                DgvSearchBuy.DataSource = tbl;
            }
            else {
                txtTotalPhar.Text = "";
                MessageBox.Show("لا يوجد عمليات فى هذه الفترة", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i <= tbl.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(tbl.Rows[i][6]);
            }
            txtTotalPhar.Text = Math.Round(Total, 2).ToString();

        }

        private void btnPayOrder_Click(object sender, EventArgs e)
        {
            string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
            if (rbtnAllCustomer.Checked == true)
            {
                MessageBox.Show("من فضلك اختر اسم عميل محدد", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbxCustomer.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك ادخل بيانات العملاء اولا ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            db.RunNunQuary("insert into Items_RentDameg (Cust_ID,Cust_Name,Total,Item_Name,Date,Qty) Values(" + cbxCustomer.SelectedValue + ",N'" + cbxCustomer.Text + "' ," + txtTotalAll.Text + " ,N'" + DgvSearchBuy.CurrentRow.Cells[2].Value + "' ,N'" + d + "'," + NudQtyAll.Value + ") ", "");

            db.RunNunQuary("update Customer_Rent_Report set Qty=Qty - " + NudQtyAll.Value + "  where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + "", "");
            db.RunNunQuary("update Items_Rent set Qty =Qty -" + NudQtyAll.Value + " where Item_Name ='" + DgvSearchBuy.CurrentRow.Cells[2].Value + "' ", "");


            db.RunNunQuary("insert into Stock_Insert (Money ,Date,Name ,Type) Values(" + txtTotalAll.Text + " ,'" + d + "' ,N'كراء' ,'تعويض عن تلف منتج اثناء الكراء')", "");
            db.RunNunQuary("update Stock set Money=Money + " + txtTotalAll.Text + "", "تمت عملية الدفع بنجاح واضافة الرصيد للخزنة");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
            if (MessageBox.Show("هل انتا متاكد؟ ", "تاكيد الاسترداد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                decimal totQty = Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[3].Value) - NudQty.Value;

                if (DgvSearchBuy.Rows.Count >= 1)
                {
                    if (rbtnAll.Checked == true)
                    {
                        db.RunNunQuary("delete from Customer_Rent_Report where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + " ", "");
                        db.RunNunQuary("update Items_Rent set Qty =Qty +" + Convert.ToDecimal(DgvSearchBuy.CurrentRow.Cells[3].Value) + " where Item_Name ='" + DgvSearchBuy.CurrentRow.Cells[2].Value + "' ", "");
                    }
                    else if (rbtnPart.Checked == true)
                    {
                        if (Convert.ToInt32(DgvSearchBuy.CurrentRow.Cells[3].Value) >= NudQty.Value)
                        {
                            db.RunNunQuary("update Customer_Rent_Report set Qty=Qty - " + NudQty.Value + "  where Order_ID=" + DgvSearchBuy.CurrentRow.Cells[0].Value + "", "");
                            db.RunNunQuary("update Items_Rent set Qty =Qty +" + NudQty.Value + " where Item_Name ='" + DgvSearchBuy.CurrentRow.Cells[2].Value + "' ", "");

                        }
                        else {
                            MessageBox.Show("لا يمكن استرداد هذه الكمية لانها اكبر من الكمية التى اكتراها العميل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    Frm_CustomerMoneyRent_Load(null, null);
                }
            }
        }

        private void btnProblemPay_Click(object sender, EventArgs e)
        {
            string d = DtbSaleDate.Value.ToString("dd/MM/yyyy");
            if (rbtnAllCustomer.Checked == true)
            {
                MessageBox.Show("من فضلك اختر اسم عميل محدد", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbxCustomer.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك ادخل بيانات العملاء اولا ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            db.RunNunQuary("insert into Items_ProblemPay (Cust_ID,Cust_Name,Pay_Price,Item_Name,Date) Values(" + cbxCustomer.SelectedValue + ",N'" + cbxCustomer.Text + "' ," + NudProblemPay.Value + " ,N'" + DgvSearchBuy.CurrentRow.Cells[2].Value + "' ,N'" + d + "') ", "");


            db.RunNunQuary("insert into Stock_Insert (Money ,Date,Name ,Type) Values(" + NudProblemPay.Value + " ,'" + d + "' ,N'كراء' ,'مبلغ تعويض عن ضرر او تاخير اثناء عملية كراء')", "");
            db.RunNunQuary("update Stock set Money=Money + " + NudProblemPay.Value + "", "تمت عملية الدفع بنجاح واضافة الرصيد للخزنة");

        }

        private void NudAllPrice_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalAll.Text = (NudQtyAll.Value * NudAllPrice.Value).ToString();
            }
            catch (Exception) { }
        }

        private void NudQtyAll_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalAll.Text = (NudQtyAll.Value * NudAllPrice.Value).ToString();
            }
            catch (Exception) { }
        }
    }
}
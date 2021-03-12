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
    public partial class cust_dept : Form
    {
        public cust_dept()
        {
            InitializeComponent();
        }
        DB db = new DB();
        private void cust_dept_Load(object sender, EventArgs e)
        {
            FillCustomer();
        }
        public void FillCustomer()
        {
            cbxSuplier.DataSource = db.RunReader("select * from Customer Order By  Cust_ID desc", "");
            cbxSuplier.DisplayMember = "Cust_Name";
            cbxSuplier.ValueMember = "Cust_ID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.RunNunQuary("insert into Customer_Money (price , Type , Cust_ID , Order_ID) values (" + money.Value + " , 'افتتاحي' , " + cbxSuplier.SelectedValue.ToString() + " , 0)", "");
            MessageBox.Show("تم الحفظ");
            money.Value = 0;
        }
    }
}

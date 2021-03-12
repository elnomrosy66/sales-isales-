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
    public partial class sup_dept : Form
    {
        public sup_dept()
        {
            InitializeComponent();
        }
        DB db = new DB();

        private void sup_dept_Load(object sender, EventArgs e)
        {
            FillCustomer();
        }
        public void FillCustomer()
        {
            cbxSuplier.DataSource = db.RunReader("select * from Suplier Order By  Sup_ID desc", "");
            cbxSuplier.DisplayMember = "Sup_Name";
            cbxSuplier.ValueMember = "Sup_ID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.RunNunQuary("insert into Suplier_Money (price  , Sup_ID , Order_ID) values (" + money.Value + "  , " + cbxSuplier.SelectedValue.ToString() + " , 0)", "");
            MessageBox.Show("تم الحفظ");
            money.Value = 0;
        }
    }
}

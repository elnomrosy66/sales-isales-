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
    public partial class Frm_NewPass : DevExpress.XtraEditors.XtraForm
    {
        public Frm_NewPass()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable(); DataTable tblAuto = new DataTable(); DataTable tbldata = new DataTable();
        int introw = 0;
     
        private void Autonum()
        {
            tbldata.Clear();
            tbldata = db.RunReader("select UserName as 'اسم المستخدم',type as نوعه from Users", "");
            Dgv.DataSource = tbldata;
            tblAuto.Clear();
            tblAuto = db.RunReader("select max(ID) from Users", "");
            if ((tblAuto.Rows[0][0].ToString() == DBNull.Value.ToString()))
                txtID.Text = "1";
            else
                txtID.Text = (Convert.ToInt32(tblAuto.Rows[0][0].ToString()) + 1).ToString();

            cbxType.SelectedIndex = 0;
            
            btnAdd.Enabled = true;
            NudRbh7.Value = 1;
            txtPass.Clear();
            txtUserName.Clear();
            cbxStock.SelectedIndex = 0;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void ShowData()
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Users", "");
            if (tbl.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد بيانات فى هذه الشاشة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                txtID.Text = tbl.Rows[introw][0].ToString();
                txtPass.Text = tbl.Rows[introw][1].ToString();
                cbxType.Text = tbl.Rows[introw][3].ToString();
                txtUserName.Text = tbl.Rows[introw][2].ToString();
                cbxStock.SelectedValue = tbl.Rows[introw][4].ToString();
                NudRbh7.Value = Convert.ToDecimal(tbl.Rows[introw][5]);
            }
            catch (Exception) { }
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }
        private void FillEmp()
        {
            cbxUsers1.DataSource = db.RunReader("select * from Users","");
            cbxUsers1.DisplayMember = "UserName";
            cbxUsers1.ValueMember = "ID";

            cbxUsers2.DataSource = db.RunReader("select * from Users", "");
            cbxUsers2.DisplayMember = "UserName";
            cbxUsers2.ValueMember = "ID";

            cbxUsers3.DataSource = db.RunReader("select * from Users", "");
            cbxUsers3.DisplayMember = "UserName";
            cbxUsers3.ValueMember = "ID";

            cbxUsers4.DataSource = db.RunReader("select * from Users", "");
            cbxUsers4.DisplayMember = "UserName";
            cbxUsers4.ValueMember = "ID";

            cbxUsers5.DataSource = db.RunReader("select * from Users", "");
            cbxUsers5.DisplayMember = "UserName";
            cbxUsers5.ValueMember = "ID";

            cbxUsers6.DataSource = db.RunReader("select * from Users", "");
            cbxUsers6.DisplayMember = "UserName";
            cbxUsers6.ValueMember = "ID";

            cbxUsers7.DataSource = db.RunReader("select * from Users", "");
            cbxUsers7.DisplayMember = "UserName";
            cbxUsers7.ValueMember = "ID";

            cbxUsers8.DataSource = db.RunReader("select * from Users", "");
            cbxUsers8.DisplayMember = "UserName";
            cbxUsers8.ValueMember = "ID";

            cbxUsers9.DataSource = db.RunReader("select * from Users", "");
            cbxUsers9.DisplayMember = "UserName";
            cbxUsers9.ValueMember = "ID";

            cbxUsers10.DataSource = db.RunReader("select * from Users", "");
            cbxUsers10.DisplayMember = "UserName";
            cbxUsers10.ValueMember = "ID";
        }
        private void FillStock()
        {

            cbxStock.DataSource = db.RunReader("select * from Stock_Data", "");
            cbxStock.DisplayMember = "Stock_Name";
            cbxStock.ValueMember = "Stock_ID";
        }
        private void Frm_NewPass_Load(object sender, EventArgs e)
        {
            FillStock();
            FillEmp();
            Autonum();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Autonum();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxStock.Items.Count <= 0) { MessageBox.Show("من فضلك قم باضافة الخزنه اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            int rent, rentReport, users, items, customer, CustomerReport, Repir, RepirReport, Suplier, SuplierReport, Sales, SalesReport, Buy, BuyReport, Return_, ReturnReport, Deserved, DeservedReport, BackUp, Employee, StockBank;
           

            if (txtUserName.Text=="")
            {
                MessageBox.Show("من فضلك ادخل اسم المستخدم ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable tblCheck = new DataTable();
            tblCheck.Clear();
            tblCheck = db.RunReader("select UserName from Users", "");
            for (int i = 0; i <= tblCheck.Rows.Count - 1; i++)
            {

                if (tblCheck.Rows[i][0].ToString() == txtUserName.Text)
                {
                    MessageBox.Show("هذا المستخدم مسجل من قبل !!!", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            db.RunNunQuary("insert into Users_Setting Values ("+txtID.Text+" ,0,0,0,0,0,0,0,0,0,0,0)", "");
            db.RunNunQuary("insert into Users_Suplier Values (" + txtID.Text + " ,0,0,0)", "");
            db.RunNunQuary("insert into Users_Customer Values (" + txtID.Text + " ,0,0,0)", "");
            db.RunNunQuary("insert into Users_Buy Values (" + txtID.Text + " ,0,0)", "");
            db.RunNunQuary("insert into Users_Sale Values (" + txtID.Text + " ,0,0,0,0)", "");
            db.RunNunQuary("insert into Users_Return Values (" + txtID.Text + " ,0,0)", "");
            db.RunNunQuary("insert into Users_Deserved Values (" + txtID.Text + " ,0,0,0,0,0,0,0)", "");
            db.RunNunQuary("insert into Users_Emplyee Values (" + txtID.Text + " ,0,0,0,0,0,0,0)", "");
            db.RunNunQuary("insert into Users_StockBank Values (" + txtID.Text + " ,0,0,0,0,0,0,0,0,0)", "");
            db.RunNunQuary("insert into Users_BackUp Values (" + txtID.Text + " ,0,0)", "");
           
            
            
            db.RunNunQuary("insert into Users Values(" + txtID.Text + ",N'" + txtPass.Text + "',N'" + txtUserName.Text + "', '"+cbxType.Text+"'," + cbxStock.SelectedValue + " ,"+NudRbh7.Value+")", "تمت اضافة بيانات المستخدم بنجاح");
            FillEmp();
            Autonum();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rent, rentReport, Employee, StockBank, users, items, customer, Repir, RepirReport, CustomerReport, Suplier, SuplierReport, Sales, SalesReport, Buy, BuyReport, Return_, ReturnReport, Deserved, DeservedReport, Report, BackUp;
            

            db.RunNunQuary("update Users set Password=N'" + txtPass.Text + "',Type=N'" + cbxType.Text + "',UserName=N'" + txtUserName.Text + "' ,Stock_ID=" + cbxStock.SelectedValue + ",Rbh7="+NudRbh7.Value+" where ID=" + txtID.Text + "", "تمت حفظ بيانات المستخدم بنجاح");
            Autonum();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد من مسح هذا المستخدم ", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (txtPass.Text != "")
                {
                    


                    db.RunNunQuary("delete Users_Setting where User_ID= " + txtID.Text + "", "");
                    db.RunNunQuary("delete Users_Suplier where User_ID= " + txtID.Text + "", "");
                    db.RunNunQuary("delete Users_Customer where User_ID= " + txtID.Text + "", "");
                    db.RunNunQuary("delete Users_Buy where User_ID= " + txtID.Text + "", "");
                    db.RunNunQuary("delete Users_Sale where User_ID= " + txtID.Text + "", "");
                    db.RunNunQuary("delete Users_Return where User_ID= " + txtID.Text + "", "");
                    db.RunNunQuary("delete Users_Deserved where User_ID= " + txtID.Text + "", "");
                    db.RunNunQuary("delete Users_Emplyee where User_ID= " + txtID.Text + "", "");
                    db.RunNunQuary("delete Users_StockBank where User_ID= " + txtID.Text + "", "");
                    db.RunNunQuary("delete Users_BackUp where User_ID= " + txtID.Text + "", ""); 
                  
                    db.RunNunQuary("delete  from Users where ID='" + txtID.Text + "'", "تم الحذف");
                }

                DataTable tblt = new DataTable();
                tblt.Clear();
                tblt = db.RunReader("select * from Users where Type='مدير'", "");

                if (tblt.Rows.Count <= 0)
                {
                    db.RunNunQuary("INSERT INTO [Users] ([ID],[Password],[UserName],[Type],[Stock_ID] ,[Rbh7]) VALUES(1,'123','123','مدير',1,5)", "");
                    db.RunNunQuary("insert into Users_Setting Values (1,1,1,1,1,1,1,1,1,1,1,1)", "");
                    db.RunNunQuary("insert into Users_Suplier Values (1 ,1,1,1)", "");
                    db.RunNunQuary("insert into Users_Customer Values (1 ,1,1,1)", "");
                    db.RunNunQuary("insert into Users_Buy Values (1,1,1)", "");
                    db.RunNunQuary("insert into Users_Sale Values (1,1,1,1,1)", "");
                    db.RunNunQuary("insert into Users_Return Values (1 ,1,1)", "");
                    db.RunNunQuary("insert into Users_Deserved Values (1,1,1,1,1,1,1,1)", "");
                    db.RunNunQuary("insert into Users_Emplyee Values (1 ,1,1,1,1,1,1,1)", "");
                    db.RunNunQuary("insert into Users_StockBank Values (1 ,1,1,1,1,1,1,1,1,1)", "");
                    db.RunNunQuary("insert into Users_BackUp Values (1 ,1,1)", "");
                    MessageBox.Show("لا يمكن ان تمسح جميع المستخدمين لابد من وجود مدير واحد على الاقل حتى تتمكن من استخدام البرنامج" + "\n"+"قام البرنامج بانشاء مستخدم بصلاحيات مدير باسم 123 وكلمه سر 123", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                Autonum();
            }

            
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            introw = 0;
            ShowData();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (introw == 0)
            {
                tbl.Clear();
                tbl = db.RunReader("select * from Users", "");
                introw = tbl.Rows.Count - 1;

                ShowData();

            }
            else
            {
                introw -= 1;
                ShowData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Users", "");

            if (introw == 0)
            {
                introw++;
                ShowData();

            }
            else if (introw == tbl.Rows.Count - 1)
            {
                introw = 0;
                ShowData();
            }
            else
            {
                introw += 1;
                ShowData();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl = db.RunReader("select * from Users", "");
            introw = tbl.Rows.Count - 1;
            ShowData();
        }

        private void cbxUsers1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                DataTable tblData = new DataTable();
                tbldata.Clear();
                tbldata = db.RunReader("select * from Users_Setting where User_ID="+cbxUsers1.SelectedValue+"", "");
                if (Convert.ToInt32(tbldata.Rows[0][1]) == 1) {
                    chekProgramSetting.Checked = true;
                }
                else { chekProgramSetting.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][2]) == 1)
                {
                    chekUnit.Checked = true;
                }
                else { chekUnit.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][3]) == 1)
                {
                    chekAddStore.Checked = true;
                }
                else { chekAddStore.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][4]) == 1)
                {
                    chekStoreGard.Checked = true;
                }
                else { chekStoreGard.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][5]) == 1)
                {
                    chekItemsTransfire.Checked = true;
                }
                else { chekItemsTransfire.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][6]) == 1)
                {
                    chekItemsTransfireReport.Checked = true;
                }
                else { chekItemsTransfireReport.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][7]) == 1)
                {
                    chekUserPermisson.Checked = true;
                }
                else { chekUserPermisson.Checked = false; }

                if (Convert.ToInt32(tbldata.Rows[0][8]) == 1)
                {
                    chekItemsOutStore.Checked = true;
                }
                else { chekItemsOutStore.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][9]) == 1)
                {
                    chekItemsOutStoreReport.Checked = true;
                }
                else { chekItemsOutStoreReport.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][10]) == 1)
                {
                    chekItemsGroup.Checked = true;
                }
                else { chekItemsGroup.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][11]) == 1)
                {
                    chekItemsView.Checked = true;
                }
                else { chekItemsView.Checked = false; }
            }
            catch (Exception) { }
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxUsers1.Items.Count >= 1)
                {
                    int setting, unit, addStore, gardStore, itemsTransfire, itemsTransfireReport, userPermisson, itemsOutStore, itemsOutStoreReport, itemsGroup, ItemsView;
                    if (chekProgramSetting.Checked == true)
                    {
                        setting = 1;
                    }
                    else { setting = 0; }
                    if (chekUnit.Checked == true)
                    {
                        unit=1;
                    }
                    else { unit = 0; }
                    if (chekAddStore.Checked == true)
                    {
                        addStore = 1;
                    }
                    else { addStore = 0; }
                    if (chekStoreGard.Checked == true)
                    {
                        gardStore = 1;
                    }
                    else { gardStore = 0; }
                    if (chekItemsTransfire.Checked == true)
                    {
                        itemsTransfire = 1;
                    }
                    else { itemsTransfire = 0; }
                    if (chekItemsTransfireReport.Checked == true)
                    {
                        itemsTransfireReport = 1;
                    }
                    else { itemsTransfireReport = 0; }
                    if (chekUserPermisson.Checked == true)
                    {
                        userPermisson = 1;
                    }
                    else { userPermisson = 0; }

                    if ( chekItemsOutStore.Checked == true)
                    {
                        itemsOutStore = 1;
                    }
                    else { itemsOutStore = 0; }
                    if (chekItemsOutStoreReport.Checked == true)
                    {
                        itemsOutStoreReport = 1;
                    }
                    else { itemsOutStoreReport = 0; }
                    if ( chekItemsGroup.Checked == true)
                    {
                        itemsGroup = 1;
                    }
                    else { itemsGroup = 0; }
                    if (chekItemsView.Checked == true)
                    {
                        ItemsView = 1;
                    }
                    else { ItemsView = 0; }
                    if (chekUserPermisson.Checked == true) {


                        if (MessageBox.Show("اذا اعطيت المستخدم الحق فى التعديل فى شاشه صلاحيات المستخدمين" + "\n"+"سيحق له ان يعدل ويغير فى صلاحياته", "هل انتا متاكد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            db.RunNunQuary("update Users_Setting set Program_Setting=" + setting + ",Units=" + unit + " ,GardStore =" + gardStore + " ,ItemsTransfire=" + itemsTransfire + ",ItemsTransfire_Report=" + itemsTransfireReport + ",UserPermisson=" + userPermisson + ",ItemsOutStore=" + itemsOutStore + ",ItemsOutStore_Report=" + itemsOutStoreReport + ",ItemsGroup=" + itemsGroup + ",ItemsView=" + ItemsView + " where User_ID=" + cbxUsers1.SelectedValue + "", "تم تعديل صلاحيات المستخدم المحدد بنجاح");
               
                        }
                    }
                }
                else 
                {
                    MessageBox.Show("من فضلك ادخل اسماء المستخدمين اولا","تاكيد",MessageBoxButtons.OK ,MessageBoxIcon.Information);
                }
            }
            catch (Exception) { }
        }

        private void cbxUsers2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tblData = new DataTable();
                tbldata.Clear();
                tbldata = db.RunReader("select * from Users_Suplier where User_ID=" + cbxUsers2.SelectedValue + "", "");
                if (Convert.ToInt32(tbldata.Rows[0][1]) == 1)
                {
                    chekSuplier.Checked = true;
                }
                else { chekSuplier.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][2]) == 1)
                {
                    chekSuplierMoney.Checked = true;
                }
                else { chekSuplierMoney.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][3]) == 1)
                {
                    chekSuplierReport.Checked = true;
                }
                else { chekSuplierReport.Checked = false; }
            }
            catch (Exception) { }
       
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxUsers2.Items.Count >= 1)
                {
                    int suplier, suplierMoney, suplierMoneyReport;
                    if (chekSuplier.Checked == true)
                    {
                        suplier = 1;
                    }
                    else { suplier = 0; }
                    if (chekSuplierMoney.Checked == true)
                    {
                        suplierMoney = 1;
                    }
                    else { suplierMoney = 0; }

                    if (chekSuplierReport.Checked == true)
                    {
                        suplierMoneyReport = 1;
                    }
                    else { suplierMoneyReport = 0; }

                    db.RunNunQuary("update Users_Suplier set Suplier=" + suplier + ",Suplier_Money=" + suplierMoney + " ,Supliey_MoneyReport =" + suplierMoneyReport + "  where User_ID=" + cbxUsers2.SelectedValue + "", "تم تعديل صلاحيات المستخدم المحدد بنجاح");
                }
                else
                {
                    MessageBox.Show("من فضلك ادخل اسماء المستخدمين اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { }
        
        }

        private void cbxUsers3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tblData = new DataTable();
                tbldata.Clear();
                tbldata = db.RunReader("select * from Users_Customer where User_ID=" + cbxUsers3.SelectedValue + "", "");
                if (Convert.ToInt32(tbldata.Rows[0][1]) == 1)
                {
                    chekCustomer.Checked = true;
                }
                else { chekCustomer.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][2]) == 1)
                {
                    chekCustomerMoney.Checked = true;
                }
                else { chekCustomerMoney.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][3]) == 1)
                {
                    chekCustomerMoneyReport.Checked = true;
                }
                else { chekCustomerMoneyReport.Checked = false; }
            }
            catch (Exception) { }
       
        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxUsers3.Items.Count >= 1)
                {
                    int customer, customerMoney, customerMoneyReport;
                    if (chekCustomer.Checked == true)
                    {
                        customer = 1;
                    }
                    else { customer = 0; }
                    if (chekCustomerMoney.Checked == true)
                    {
                        customerMoney = 1;
                    }
                    else { customerMoney = 0; }

                    if (chekCustomerMoneyReport.Checked == true)
                    {
                        customerMoneyReport = 1;
                    }
                    else { customerMoneyReport = 0; }

                    db.RunNunQuary("update Users_Customer set Customer=" + customer + ",Customer_Money=" + customerMoney + " ,Customer_MoneyReport =" + customerMoneyReport + "  where User_ID=" + cbxUsers3.SelectedValue + "", "تم تعديل صلاحيات المستخدم المحدد بنجاح");
                }
                else
                {
                    MessageBox.Show("من فضلك ادخل اسماء المستخدمين اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { }
        
        }

        private void cbxUsers4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tblData = new DataTable();
                tbldata.Clear();
                tbldata = db.RunReader("select * from Users_Buy where User_ID=" + cbxUsers4.SelectedValue + "", "");
                if (Convert.ToInt32(tbldata.Rows[0][1]) == 1)
                {
                    chekBuy.Checked = true;
                }
                else { chekBuy.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][2]) == 1)
                {
                    chekBuyReport.Checked = true;
                }
                else { chekBuyReport.Checked = false; }
            }
            catch (Exception) { }
       
        }

        private void btnSave4_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxUsers4.Items.Count >= 1)
                {
                    int buy, buyReport;
                    if (chekBuy.Checked == true)
                    {
                        buy = 1;
                    }
                    else { buy = 0; }
                    if (chekBuyReport.Checked == true)
                    {
                        buyReport = 1;
                    }
                    else { buyReport = 0; }

                    db.RunNunQuary("update Users_Buy set Buy=" + buy + ",Buy_Report=" + buyReport + "  where User_ID=" + cbxUsers4.SelectedValue + "", "تم تعديل صلاحيات المستخدم المحدد بنجاح");
                }
                else
                {
                    MessageBox.Show("من فضلك ادخل اسماء المستخدمين اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { }
        
        }

        private void cbxUsers5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tblData = new DataTable();
                tbldata.Clear();
                tbldata = db.RunReader("select * from Users_Sale where User_ID=" + cbxUsers5.SelectedValue + "", "");
                if (Convert.ToInt32(tbldata.Rows[0][1]) == 1)
                {
                    chekSale.Checked = true;
                }
                else { chekSale.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][2]) == 1)
                {
                    chekSaleReport.Checked = true;
                }
                else { chekSaleReport.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][3]) == 1)
                {
                    chekSaleReportRp7h.Checked = true;
                }
                else { chekSaleReportRp7h.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][4]) == 1)
                {
                    chekItemsGard.Checked = true;
                }
                else { chekItemsGard.Checked = false; }
            }
            catch (Exception) { }
       
        }

        private void btnSave5_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxUsers5.Items.Count >= 1)
                {
                    int sale, saleReport,saleReportRp7h ,itemsGard;
                    if (chekSale.Checked == true)
                    {
                        sale = 1;
                    }
                    else { sale = 0; }
                    if (chekSaleReport.Checked == true)
                    {
                        saleReport = 1;
                    }
                    else { saleReport = 0; }
                    if (chekSaleReportRp7h.Checked == true)
                    {
                        saleReportRp7h = 1;
                    }
                    else { saleReportRp7h = 0; }
                    if (chekItemsGard.Checked == true)
                    {
                        itemsGard = 1;
                    }
                    else { itemsGard = 0; }

                    db.RunNunQuary("update Users_Sale set Sale=" + sale + ",Sale_Report=" + saleReport + ",Sale_ReportRp7h="+saleReportRp7h+",Items_Gard="+itemsGard+"  where User_ID=" + cbxUsers5.SelectedValue + "", "تم تعديل صلاحيات المستخدم المحدد بنجاح");
                }
                else
                {
                    MessageBox.Show("من فضلك ادخل اسماء المستخدمين اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { }
        
        }

        private void cbxUsers6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tblData = new DataTable();
                tbldata.Clear();
                tbldata = db.RunReader("select * from Users_Return where User_ID=" + cbxUsers6.SelectedValue + "", "");
                if (Convert.ToInt32(tbldata.Rows[0][1]) == 1)
                {
                    chekReturn.Checked = true;
                }
                else { chekReturn.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][2]) == 1)
                {
                    chekReturnReport.Checked = true;
                }
                else { chekReturnReport.Checked = false; }
            }
            catch (Exception) { }
       
        }

        private void btnSave6_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxUsers6.Items.Count >= 1)
                {
                    int return_, returnReport;
                    if (chekReturn.Checked == true)
                    {
                        return_ = 1;
                    }
                    else { return_ = 0; }
                    if (chekReturnReport.Checked == true)
                    {
                        returnReport = 1;
                    }
                    else { returnReport = 0; }

                    db.RunNunQuary("update Users_Return set Return_=" + return_ + ",Return_Report=" + returnReport + "  where User_ID=" + cbxUsers6.SelectedValue + "", "تم تعديل صلاحيات المستخدم المحدد بنجاح");
                }
                else
                {
                    MessageBox.Show("من فضلك ادخل اسماء المستخدمين اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { }
        
        }

        private void cbxUsers7_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tblData = new DataTable();
                tbldata.Clear();
                tbldata = db.RunReader("select * from Users_Deserved where User_ID=" + cbxUsers7.SelectedValue + "", "");
                if (Convert.ToInt32(tbldata.Rows[0][1]) == 1)
                {
                    chekDeservedType.Checked = true;
                }
                else { chekDeservedType.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][2]) == 1)
                {
                    chekDeserved.Checked = true;
                }
                else { chekDeserved.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][3]) == 1)
                {
                    chekDeservedReport.Checked = true;
                }
                else { chekDeservedReport.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][4]) == 1)
                {
                    chekSanadKabd.Checked = true;
                }
                else { chekSanadKabd.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][5]) == 1)
                {
                    chekSanadSarf.Checked = true;
                }
                else { chekSanadSarf.Checked = false; }

                if (Convert.ToInt32(tbldata.Rows[0][6]) == 1)
                {
                    chekSanadReport.Checked = true;
                }
                else { chekSanadReport.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][7]) == 1)
                {
                    chekTaxesReport.Checked = true;
                }
                else { chekTaxesReport.Checked = false; }
            }
            catch (Exception) { }
       
        }

        private void btnSave7_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxUsers7.Items.Count >= 1)
                {
                    int deservedType, deserved, deservedReport,sanadKabd,sandSarf ,sanadReport,taxesReport;
                    if (chekDeservedType.Checked == true)
                    {
                        deservedType = 1;
                    }
                    else { deservedType = 0; }
                    if (chekDeserved.Checked == true)
                    {
                        deserved = 1;
                    }
                    else { deserved = 0; }
                    if (chekDeservedReport.Checked == true)
                    {
                        deservedReport = 1;
                    }
                    else { deservedReport = 0; }
                    if (chekSanadKabd.Checked == true)
                    {
                        sanadKabd = 1;
                    }
                    else { sanadKabd = 0; }

                    if (chekSanadSarf.Checked == true)
                    {
                        sandSarf = 1;
                    }
                    else { sandSarf = 0; }
                    if (chekSanadReport.Checked == true)
                    {
                        sanadReport = 1;
                    }
                    else { sanadReport = 0; }
                    if (chekTaxesReport.Checked == true)
                    {
                        taxesReport = 1;
                    }
                    else { taxesReport = 0; }

                    db.RunNunQuary("update Users_Deserved set Deserved_Type=" + deservedType + ",Deserved=" + deserved + " ,Deserved_Report=" + deservedReport + ", Sanad_Kabd=" + sanadKabd + " ,Sanad_Sarf=" + sandSarf + ",Sanad_Report=" + sanadReport + " ,Taxes_Report="+taxesReport+"  where User_ID=" + cbxUsers7.SelectedValue + "", "تم تعديل صلاحيات المستخدم المحدد بنجاح");
                }
                else
                {
                    MessageBox.Show("من فضلك ادخل اسماء المستخدمين اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { }
        
        }

        private void cbxUsers8_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tblData = new DataTable();
                tbldata.Clear();
                tbldata = db.RunReader("select * from Users_Emplyee where User_ID=" + cbxUsers8.SelectedValue + "", "");
                if (Convert.ToInt32(tbldata.Rows[0][1]) == 1)
                {
                    chekEmplyeeAdd.Checked = true;
                }
                else { chekEmplyeeAdd.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][2]) == 1)
                {
                    chekBorrow.Checked = true;
                }
                else { chekBorrow.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][3]) == 1)
                {
                    chekBorrowMoney.Checked = true;
                }
                else { chekBorrowMoney.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][4]) == 1)
                {
                    chekEmplyeeSalary.Checked = true;
                }
                else { chekEmplyeeSalary.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][5]) == 1)
                {
                    chekEmplyeeSalaryReport.Checked = true;
                }
                else { chekEmplyeeSalaryReport.Checked = false; }

                if (Convert.ToInt32(tbldata.Rows[0][6]) == 1)
                {
                    chekBorrowMonenyReport.Checked = true;
                }
                else { chekBorrowMonenyReport.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][7]) == 1)
                {
                    chekBorrowReport.Checked = true;
                }
                else { chekBorrowReport.Checked = false; }
            }
            catch (Exception) { }
       
        }

        private void btnSave8_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxUsers8.Items.Count >= 1)
                {
                    int emplyeeAdd, emplyeeBorrow, emplyeeBorrowMoney, emplyeeSalary, emplyeeSalaryReport, emplyeeBorrowMoneyReport, emplyeeBorrowReport;
                    if (chekEmplyeeAdd.Checked == true)
                    {
                        emplyeeAdd = 1;
                    }
                    else { emplyeeAdd = 0; }
                    if (chekBorrow.Checked == true)
                    {
                        emplyeeBorrow = 1;
                    }
                    else { emplyeeBorrow = 0; }
                    if (chekBorrowMoney.Checked == true)
                    {
                        emplyeeBorrowMoney = 1;
                    }
                    else { emplyeeBorrowMoney = 0; }
                    if (chekEmplyeeSalary.Checked == true)
                    {
                        emplyeeSalary = 1;
                    }
                    else { emplyeeSalary = 0; }
                    if (chekEmplyeeSalaryReport.Checked == true)
                    {
                        emplyeeSalaryReport = 1;
                    }
                    else { emplyeeSalaryReport = 0; }

                    if (chekBorrowReport.Checked == true)
                    {
                        emplyeeBorrowReport = 1;
                    }
                    else { emplyeeBorrowReport = 0; }
                    if (chekBorrowMonenyReport.Checked == true)
                    {
                        emplyeeBorrowMoneyReport = 1;
                    }
                    else { emplyeeBorrowMoneyReport = 0; }

                    db.RunNunQuary("update Users_Emplyee set Emplyee_Add=" + emplyeeAdd + ",Emplyee_Borrow=" + emplyeeBorrow + " ,Emplyee_BorrowMoney=" + emplyeeBorrowMoney + ", Emplyee_Salary=" + emplyeeSalary + " ,Emplyee_SalaryReport=" + emplyeeSalaryReport + ",Emplyee_BorrowMoneyReport=" + emplyeeBorrowMoneyReport + " ,Emplyee_BorrowReport=" + emplyeeBorrowReport + "  where User_ID=" + cbxUsers8.SelectedValue + "", "تم تعديل صلاحيات المستخدم المحدد بنجاح");
                }
                else
                {
                    MessageBox.Show("من فضلك ادخل اسماء المستخدمين اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { }
        
        }

        private void cbxUsers9_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tblData = new DataTable();
                tbldata.Clear();
                tbldata = db.RunReader("select * from Users_StockBank where User_ID=" + cbxUsers9.SelectedValue + "", "");
                if (Convert.ToInt32(tbldata.Rows[0][1]) == 1)
                {
                    chekAddStock.Checked = true;
                }
                else { chekAddStock.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][2]) == 1)
                {
                    chekStockInsertMoney.Checked = true;
                }
                else { chekStockInsertMoney.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][3]) == 1)
                {
                    chekBankInsert.Checked = true;
                }
                else { chekBankInsert.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][4]) == 1)
                {
                    chekStockPull.Checked = true;
                }
                else { chekStockPull.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][5]) == 1)
                {
                    chekBankPull.Checked = true;
                }
                else { chekBankPull.Checked = false; }

                if (Convert.ToInt32(tbldata.Rows[0][6]) == 1)
                {
                    chekMoneyTransfire.Checked = true;
                }
                else { chekMoneyTransfire.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][7]) == 1)
                {
                    chekBankStockTransfire.Checked = true;
                }
                else { chekBankStockTransfire.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][8]) == 1)
                {
                    chekCurrentMoney.Checked = true;
                }
                else { chekCurrentMoney.Checked = false; }

                if (Convert.ToInt32(tbldata.Rows[0][9]) == 1)
                {
                    chekBankStockReports.Checked = true;
                }
                else { chekBankStockReports.Checked = false; }
            }
            catch (Exception) { }
       
        }

        private void btnSave9_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxUsers9.Items.Count >= 1)
                {
                    int stockAdd, stockInsert, bankInsert, stockPull, bankPull, moneyTransfire, stockBankTransfire,currentMonay,reports;
                    if (chekAddStock.Checked == true)
                    {
                        stockAdd = 1;
                    }
                    else { stockAdd = 0; }
                    if (chekStockInsertMoney.Checked == true)
                    {
                        stockInsert = 1;
                    }
                    else { stockInsert = 0; }
                    if (chekBankInsert.Checked == true)
                    {
                        bankInsert = 1;
                    }
                    else { bankInsert = 0; }
                    if (chekStockPull.Checked == true)
                    {
                        stockPull = 1;
                    }
                    else { stockPull = 0; }
                    if (chekBankPull.Checked == true)
                    {
                        bankPull = 1;
                    }
                    else { bankPull = 0; }

                    if (chekMoneyTransfire.Checked == true)
                    {
                        moneyTransfire = 1;
                    }
                    else { moneyTransfire = 0; }
                    if (chekBankStockTransfire.Checked == true)
                    {
                        stockBankTransfire = 1;
                    }
                    else { stockBankTransfire = 0; }
                    if (chekCurrentMoney.Checked == true)
                    {
                        currentMonay = 1;
                    }
                    else { currentMonay = 0; }
                    if (chekBankStockReports.Checked == true)
                    {
                        reports = 1;
                    }
                    else { reports = 0; }

                    db.RunNunQuary("update Users_StockBank set Stock_Add=" + stockAdd + ",Stock_Insert=" + stockInsert + " ,Bank_Insert=" + bankInsert + ", Stock_Pull=" + stockPull + " ,Bank_Pull=" + bankPull + ",Stock_Transfire=" + moneyTransfire + " ,Stock_BankTransfire=" + stockBankTransfire + ",CurrentMoney=" + currentMonay + " ,Reports="+reports+"  where User_ID=" + cbxUsers9.SelectedValue + "", "تم تعديل صلاحيات المستخدم المحدد بنجاح");
                }
                else
                {
                    MessageBox.Show("من فضلك ادخل اسماء المستخدمين اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { }
        
        }

        private void cbxUsers10_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tblData = new DataTable();
                tbldata.Clear();
                tbldata = db.RunReader("select * from Users_BackUp where User_ID=" + cbxUsers10.SelectedValue + "", "");
                if (Convert.ToInt32(tbldata.Rows[0][1]) == 1)
                {
                    chekTakeBackup.Checked = true;
                }
                else { chekTakeBackup.Checked = false; }
                if (Convert.ToInt32(tbldata.Rows[0][2]) == 1)
                {
                    chekRestoreBackup.Checked = true;
                }
                else { chekRestoreBackup.Checked = false; }
            }
            catch (Exception) { }
       
        }

        private void btnSave10_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxUsers10.Items.Count >= 1)
                {
                    int take, restore;
                    if (chekTakeBackup.Checked == true)
                    {
                        take = 1;
                    }
                    else { take = 0; }
                    if (chekRestoreBackup.Checked == true)
                    {
                        restore = 1;
                    }
                    else { restore = 0; }

                    db.RunNunQuary("update Users_BackUp set Take_Backup=" + take + ",Restore_BackUp=" + restore + "  where User_ID=" + cbxUsers10.SelectedValue + "", "تم تعديل صلاحيات المستخدم المحدد بنجاح");
                }
                else
                {
                    MessageBox.Show("من فضلك ادخل اسماء المستخدمين اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { }
        
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
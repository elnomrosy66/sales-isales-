using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing.Printing;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;

namespace Sales_Management
{
    public partial class Frm_PrinterSetting : DevExpress.XtraEditors.XtraForm
    {
        public Frm_PrinterSetting()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        string pkInstalledPrinters = "";
        private void ShowDataOrder() {
          tbl.Clear();
            tbl = db.RunReader("select * from OrderPrintData", "");
            if (tbl.Rows.Count >= 1)
            {
                txtAddress.Text = tbl.Rows[0][1].ToString();
                txtDescription.Text = tbl.Rows[0][2].ToString();
                txtPhone1.Text = tbl.Rows[0][3].ToString();
                txtPhone2.Text = tbl.Rows[0][4].ToString();
                txtName.Text = tbl.Rows[0][5].ToString();
            }

            pictureBoxDoctorPhoto.BackgroundImageLayout = ImageLayout.Stretch;

            String strConn = @"server=.\SQLExpress;Initial Catalog=Sales_StandardV2;Integrated Security=True;";
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                //Retrieve BLOB from database into DataSet.
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM OrderPrintData", conn);
                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                sqlDA.Fill(ds, "OrderPrintData");
                int c = ds.Tables["OrderPrintData"].Rows.Count;

                if (c > 0)
                {
                    Byte[] byteBranchData = new Byte[0];

                    if (ds.Tables["OrderPrintData"].Rows[0][0].ToString() != "")
                    {
                        byteBranchData = (Byte[])(ds.Tables["OrderPrintData"].Rows[0][0]);
                        MemoryStream stmBranchData = new MemoryStream(byteBranchData);
                        pictureBoxDoctorPhoto.BackgroundImage = Image.FromStream(stmBranchData);
                    }
                    else
                    {
                        pictureBoxDoctorPhoto.BackgroundImage = null;
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            { }

        }
        private void Frm_PrinterSetting_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                cbxPrinters.Items.Add(pkInstalledPrinters);
            }
            cbxPrinters.Text = Properties.Settings.Default.PrinterName;
            if (Convert.ToString(Properties.Settings.Default.ItemsDiscount)== "Value")
            {
                rbtnValue.Checked = true;
            }
            else
            {
                rbtnPersent.Checked = true;
            }
            if (Properties.Settings.Default.CkeckTaxes == true)
            {
                checkBoxTaxes.Checked = true;
            }
            else
            {
                checkBoxTaxes.Checked = false;
            }
            if (Properties.Settings.Default.PrinterA4 == true)
            {
                rbtnA4.Checked = true;
                rbtn8Cm.Checked = false ;
            }
            else
            {
                rbtn8Cm.Checked = true;
                rbtnA4.Checked = false;
            }

            if (Properties.Settings.Default.PrinterA4Buy == true)
            {
                rbnA4Buy.Checked = true;
                rbtn8cmBuy.Checked = false;
            }
            else
            {
                rbtn8cmBuy.Checked = true;
                rbnA4Buy.Checked = false;
            }

            if (Properties.Settings.Default.SalesDiscountCkeck == true)
            {
                checkBockSaleDiscount.Checked = true;
            }
            else
            {
                checkBockSaleDiscount.Checked = false;
            }
            if (Properties.Settings.Default.SalesPrint == true)
            {
                checsalesPrint.Checked = true;
            }
            else
            {
                checsalesPrint.Checked = false;
            }
            if (Properties.Settings.Default.BuyPrint == true)
            {
                checkbuyPrint.Checked = true;
            }
            else
            {
                checkbuyPrint.Checked = false;
            }
            NudOrderSalesNum.Value = Properties.Settings.Default.SalesOrderNum;
            NudOrderBuyNum.Value = Properties.Settings.Default.BuyOrderNum;
            ShowDataOrder();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbxPrinters.Text == "")
            {
                MessageBox.Show("من فضلك اختر طابعه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Properties.Settings.Default.PrinterName = cbxPrinters.Text;
            if (rbtnValue.Checked == true) 
            { 
                Properties.Settings.Default.ItemsDiscount ="Value"; 
            }
            else
            {
                Properties.Settings.Default.ItemsDiscount = "Persent"; 
            }
            Properties.Settings.Default.Save();
            MessageBox.Show("تم حفظ البيانات بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
        }
        string imgDocLoc = "";

        private void btnAddDoctorImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                imgDocLoc = dlg.FileName.ToString();
                if (pictureBoxDoctorPhoto.BackgroundImage == null)
                {
                    pictureBoxDoctorPhoto.Image = null;
                    pictureBoxDoctorPhoto.ImageLocation = imgDocLoc;
                }
                else
                {
                    pictureBoxDoctorPhoto.BackgroundImage = null;
                    pictureBoxDoctorPhoto.Image = null;
                    pictureBoxDoctorPhoto.ImageLocation = imgDocLoc;
                }

            }
        }

        private void btnDeleteDoctorImage_Click(object sender, EventArgs e)
        {
            pictureBoxDoctorPhoto.BackgroundImage = null;
            pictureBoxDoctorPhoto.Image = null;
            imgDocLoc = "";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        public string ImageToBase64(Image image,
          System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

       
        private void btnSave2_Click(object sender, EventArgs e)
        {



            if (txtAddress.Text == "")
            {
                MessageBox.Show("من فضلك ادخل عنوان المحل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPhone1.Text == "")
            {
                MessageBox.Show("من فضلك ادخل رقم التليفون", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPhone2.Text == "")
            {
                MessageBox.Show("من فضلك ادخل رقم التليفون الثانى", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المحل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pictureBoxDoctorPhoto.BackgroundImage == null && pictureBoxDoctorPhoto.Image == null)
            {
                MessageBox.Show("من فضلك اختر لوجو للمحل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int parsedValue;
            if (int.TryParse(txtAddress.Text, out parsedValue))
            {
                MessageBox.Show("لا يمكن ان يكون العنوان ارقام فقط", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int parsedValue2;
            if (int.TryParse(txtDescription.Text, out parsedValue2))
            {
                MessageBox.Show("لا يمكن ان يكون الجمله التى فى اسفل ارقام فقط", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable tbl = new DataTable();
            tbl.Clear();
            tbl = db.RunReader("select * from OrderPrintData", "");
            if (tbl.Rows.Count >= 1)
            {
                if (imgDocLoc == "")
                {
                    db.RunNunQuary("update OrderPrintData set Address=N'" + txtAddress.Text + "',Description=N'" + txtDescription.Text + "' ,Phone1='" + txtPhone1.Text + "' ,Phone2='" + txtPhone2.Text + "' ,Name='" + txtName.Text + "'", "");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(@"server=.\SQLExpress;Initial Catalog=Sales_StandardV2;Integrated Security=True");
                    SqlCommand sqlCmd = new SqlCommand("update OrderPrintData set Logo=@Logo,Address=N'" + txtAddress.Text + "',Description=N'" + txtDescription.Text + "' ,Phone1='" + txtPhone1.Text + "' ,Phone2='" + txtPhone2.Text + "' ,Name='" + txtName.Text + "' ", conn);
                    try
                    {
                        // covert Doctor image into file stream then convert to Byte Array
                        FileStream BranchStream = new FileStream(imgDocLoc, FileMode.Open, FileAccess.Read);
                        Byte[] BranchByte = new Byte[BranchStream.Length];
                        BranchStream.Read(BranchByte, 0, BranchByte.Length);
                        BranchStream.Close();

                        //Create parameter for insert command and add to SqlCommand object.
                        SqlParameter Branch_prm = new SqlParameter("@Logo", SqlDbType.VarBinary, BranchByte.Length, ParameterDirection.Input, false,
                                    0, 0, null, DataRowVersion.Current, BranchByte);
                        sqlCmd.Parameters.Add(Branch_prm);

                        //Open connection, execute query, and close connection.
                        conn.Open();
                        sqlCmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception) { }
                }
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"server=.\SQLExpress;Initial Catalog=Sales_StandardV2;Integrated Security=True");
                SqlCommand sqlCmd = new SqlCommand("insert into OrderPrintData values (@Logo,N'" + txtAddress.Text + "',N'" + txtDescription.Text + "' ,'" + txtPhone1.Text + "' , '" + txtPhone2.Text + "' ,'" + txtName.Text + "')", conn);
                try
                {
                    // covert Doctor image into file stream then convert to Byte Array
                    FileStream BranchStream = new FileStream(imgDocLoc, FileMode.Open, FileAccess.Read);
                    Byte[] BranchByte = new Byte[BranchStream.Length];
                    BranchStream.Read(BranchByte, 0, BranchByte.Length);
                    BranchStream.Close();

                    //Create parameter for insert command and add to SqlCommand object.
                    SqlParameter Branch_prm = new SqlParameter("@Logo", SqlDbType.VarBinary, BranchByte.Length, ParameterDirection.Input, false,
                                0, 0, null, DataRowVersion.Current, BranchByte);
                    sqlCmd.Parameters.Add(Branch_prm);

                    //Open connection, execute query, and close connection.
                    conn.Open();
                    sqlCmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception) { }
            }
            MessageBox.Show("تم حفظ البيانات بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void btnSave3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrinterName = cbxPrinters.Text;
            if (NudOrderBuyNum.Value <= 0 || NudOrderSalesNum.Value <= 0) 
            { MessageBox.Show(" لا يمكن ان يقل عدد نسخ طباعة الفواتير عن 1","تاكيد",MessageBoxButtons.OK ,MessageBoxIcon.Information); return; }
            if (rbtnValue.Checked == true)
            {
                Properties.Settings.Default.ItemsDiscount = "Value";
            }
            else
            {
                Properties.Settings.Default.ItemsDiscount = "Persent";
            }
            if (checkBockSaleDiscount.Checked == true)
            {
                Properties.Settings.Default.SalesDiscountCkeck = true;
            }
            else
            {
                Properties.Settings.Default.SalesDiscountCkeck = false;
            }
            if (checkBoxTaxes.Checked == true)
            {
                Properties.Settings.Default.CkeckTaxes = true;
            }
            else
            {
                Properties.Settings.Default.CkeckTaxes = false;
            }

            if (checsalesPrint.Checked == true)
            {
                Properties.Settings.Default.SalesPrint = true;
            }
            else
            {
                Properties.Settings.Default.SalesPrint = false;
            }
            if (rbtnA4.Checked == true)
            {
                Properties.Settings.Default.PrinterA4 = true;
            }
            else if (rbtn8Cm.Checked == true)
            {
                Properties.Settings.Default.PrinterA4= false;
            }
            if (rbnA4Buy.Checked == true)
            {
                Properties.Settings.Default.PrinterA4Buy = true;
            }
            else if (rbtn8cmBuy.Checked == true)
            {
                Properties.Settings.Default.PrinterA4Buy = false;
            }


            if (checkbuyPrint.Checked == true)
            {
                Properties.Settings.Default.BuyPrint = true;
            }
            else
            {
                Properties.Settings.Default.BuyPrint = false;
            }
                Properties.Settings.Default.SalesOrderNum =Convert.ToInt32(NudOrderSalesNum.Value);
          
                Properties.Settings.Default.BuyOrderNum =Convert.ToInt32(NudOrderBuyNum.Value);
            
            Properties.Settings.Default.Save();
            MessageBox.Show("تم حفظ البيانات بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
        }

        private void txtPhone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try {
                if(txtQuery.Text != "")
                {
                    db.RunNunQuary(txtQuery.Text, "تم التفيذ");
                }
            } catch(Exception) { }
        }
    }
}
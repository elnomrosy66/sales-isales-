using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CrystalDecisions.Shared;

namespace Sales_Management
{
    public partial class Print_Barcode : DevExpress.XtraEditors.XtraForm
    {
        BarcodeLib.Barcode b = new BarcodeLib.Barcode();
        private static Print_Barcode frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Print_Barcode GetMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Print_Barcode();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public Print_Barcode()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }
        DB db = new DB();
        DataTable tbl = new DataTable(); DataTable tblID = new DataTable();
        bool stat = false;
        public void AutoNum()
        {
            tbl.Clear();
            tbl = db.RunReader("Select Max(RanBarcode) from RandomBarcode", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                TextBox2.Text = "10000000";
                db.RunNunQuary("insert into RandomBarcode values(10000000)", "");
            }
            else
                TextBox2.Text = (Convert.ToDouble(tbl.Rows[0][0].ToString()) + 1).ToString();
        }
        int ID = 0;
        private void ShowDatt()
        {
            tbl.Clear();
            tbl = db.RunReader("select * from TestData", "");



            try
            {
                TextBox1.Text = tbl.Rows[0][0].ToString();
                TextBox2.Text = tbl.Rows[0][1].ToString();
                TextBox3.Text = tbl.Rows[0][2].ToString();
                ID = Convert.ToInt32(tbl.Rows[0][3]);
            }
            catch (Exception) { }

        }
        private void Print_Barcode_Load(object sender, EventArgs e)
        {
            cbxType.DataSource = db.RunReader("select * from Items", "");
            cbxType.ValueMember = "Item_ID";
            cbxType.DisplayMember = "Item_Name";

            ShowDatt();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "")
            { MessageBox.Show("من فضلك ادخل البيانات اولا", "تاكيد"); return; }
            CrystalReport1 Repo = new CrystalReport1();
            DataSet1 DS = new DataSet1();
            DS.Clear();
            db.RunNunQuary("update barcode set barcode=N'" + TextBox2.Text + "'", "");
            if (stat)
                db.RunNunQuary("update RandomBarcode set RanBarcode=N'" + TextBox2.Text + "'", "");


            tblID.Clear();
            tblID = db.RunReader("select * from items where item_ID=" + ID + "", "");
            if (tblID.Rows.Count >= 1)
            {
                db.RunNunQuary("update items set barcode=N'" + TextBox2.Text + "' where item_ID=" + ID + "", "");
            }

            //DS.Tables[0].Rows.Add(TextBox1.Text, "*" + TextBox2.Text.Trim() + "*", TextBox2.Text, String.Format("{0:N2}", TextBox3.Text));
            DS.Tables[0].Rows.Add(TextBox1.Text, "*" + TextBox2.Text.Trim() + "*", TextBox2.Text, TextBox3.Text);
            Repo.SetDataSource(DS);

            Frm_Printing frm = new Frm_Printing();
            frm.crystalReportViewer1.ReportSource = Repo;
            frm.crystalReportViewer1.Refresh();

            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutoNum();
            stat = true;
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxType.Items.Count >= 1)
            {
                tbl.Clear();
                tbl = db.RunReader("select * from items where Item_ID=" + cbxType.SelectedValue + "", "");
                try
                {
                    TextBox1.Text = tbl.Rows[0][1].ToString();
                    TextBox2.Text = tbl.Rows[0][5].ToString();
                    TextBox3.Text = tbl.Rows[0][4].ToString();
                }
                catch (Exception) { }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "")
            { MessageBox.Show("من فضلك ادخل البيانات اولا", "تاكيد"); return; }
            CrystalReport1 Repo = new CrystalReport1();
            DataSet1 DS = new DataSet1();
            db.RunNunQuary("update barcode set barcode='" + TextBox2.Text + "'", "");
            DS.Tables[0].Rows.Add(TextBox1.Text, "*" + TextBox2.Text.Trim() + "*", TextBox2.Text, String.Format("{0:N2}", TextBox3.Text));

            Repo.SetDataSource(DS);
            if (stat)
                db.RunNunQuary("update RandomBarcode set RanBarcode=N'" + TextBox2.Text + "'", "");

            tblID.Clear();
            tblID = db.RunReader("select * from items where item_ID=" + ID + "", "");
            if (tblID.Rows.Count >= 1)
            {
                db.RunNunQuary("update items set barcode=N'" + TextBox2.Text + "' where item_ID=" + ID + "", "");
            }
            Frm_Printing frm = new Frm_Printing();
            try
            {
                frm.crystalReportViewer1.ReportSource = Repo;
                frm.crystalReportViewer1.Refresh();
                System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                Repo.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;


                System.Windows.Forms.PrintDialog printPrompt = new System.Windows.Forms.PrintDialog();
                printPrompt.PrinterSettings = new System.Drawing.Printing.PrinterSettings();

                PageMargins margins = new PageMargins();
                margins = Repo.PrintOptions.PageMargins;
                margins.bottomMargin = 0;
                margins.leftMargin = 0;
                margins.rightMargin = 0;
                margins.topMargin = 0;
                Repo.PrintOptions.ApplyPageMargins(margins);

                CrystalDecisions.Shared.PrintLayoutSettings PrintLayout = new CrystalDecisions.Shared.PrintLayoutSettings();


                PrintLayout.Scaling = PrintLayoutSettings.PrintScaling.Scale;


                Repo.PrintToPrinter(printPrompt.PrinterSettings, printPrompt.PrinterSettings.DefaultPageSettings, false, PrintLayout);
                  Repo.PrintToPrinter(1, true, 0, 0);
            }
            catch (Exception) { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            DataTable tblcheck = new DataTable();

            tblcheck.Clear();
            tblcheck = db.RunReader("Select Max(RanBarcode) from RandomBarcode", "");
            if ((tblcheck.Rows.Count <= 0))
            {
                db.RunNunQuary("insert into RandomBarcode values('" + TextBox2.Text + "')", "تم حفظ تعداد الباركود");
            }
            else
                db.RunNunQuary("update RandomBarcode set  RanBarcode='" + TextBox2.Text + "' ", "تم حفظ تعداد الباركود");

        }

        private void Print_Barcode_FormClosing(object sender, FormClosingEventArgs e)
        {
            tbl.Clear();
            try
            {
                tbl = db.RunReader("select * from barcode ", "");
                if (tbl.Rows.Count <= 0) { db.RunNunQuary("insert into barcode Values(1000000)", ""); }
                db.RunNunQuary("update barcode set barcode =N'" + TextBox2.Text + "'", "");
                // tbl=  db.RunReader("select * from barcode","");

                Frm_Items.GetMainForm.txtBarcode.Text = TextBox2.Text;
                

            }
            catch (Exception) { }
        
        }
    }
}
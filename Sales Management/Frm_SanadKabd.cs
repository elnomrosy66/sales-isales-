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
    public partial class Frm_SanadKabd : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SanadKabd()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable();
        DataTable tblSearch = new DataTable();
        DB db = new DB();
        int introw = 0;

        public void AutoNum()
        {
            tbl.Clear();
            tbl = db.RunReader("Select Max(Order_ID) from Sanad_Kabd", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
                txtDesID.Text = "1";
            else
                txtDesID.Text = (Convert.ToInt32(tbl.Rows[0][0].ToString()) + 1).ToString();
            
            NudPrice.Value = 1;
            DtbDate.Text = DateTime.Now.ToShortDateString();
            txtNotes.Clear();
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
        }
        private void ShowData()
        {
            tbl.Clear();
            tbl = db.RunReader("select * from Sanad_Kabd", "");
            if ((tbl.Rows.Count <= 0))
            {
                MessageBox.Show("لا يوجد بيانات فى هذه الشاشة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try {
                txtDesID.Text = tbl.Rows[introw][0].ToString();
                txtName.Text = tbl.Rows[introw][1].ToString();
                txtFrom.Text = tbl.Rows[introw][3].ToString();
                this.Text = tbl.Rows[introw][4].ToString();
                DateTime dt = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                DtbDate.Value = dt;
                NudPrice.Value = Convert.ToDecimal(tbl.Rows[introw][2]);
                txtNotes.Text = tbl.Rows[introw][5].ToString();
                }
                catch (Exception) { }
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
            }
        }
        int stock_ID;
        private void Frm_SanadKabd_Load(object sender, EventArgs e)
        {
            AutoNum();

            stock_ID = Convert.ToInt32(Properties.Settings.Default.UserStock);

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
                tbl = db.RunReader("select * from Sanad_Kabd", "");
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
            tbl = db.RunReader("select * from Sanad_Kabd", "");

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
            tbl.Clear();
            tbl = db.RunReader("select * from Sanad_Kabd", "");
            introw = tbl.Rows.Count - 1;
            ShowData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AutoNum();
        }
        private void Print()
        {
            try
            {
                decimal num = Convert.ToDecimal(txtDesID.Text) - 1;
                DataTable tblRpt = new DataTable();
                tblRpt.Clear();
                int x = Convert.ToInt32(txtDesID.Text) - 1;

                tblRpt = db.RunReader("SELECT [Order_ID] as 'رقم السند' ,[Sanad_Name] as 'المسؤل عن القبض',[Sanad_Price] as 'المبلغ',[Sanad_From] as 'القبض من',[Sanad_Date] as 'التاريخ',[Notes] as 'ملاحظات' FROM [Sanad_Kabd] where [Order_ID]=" + num + "", "");

                Frm_Printing frm = new Frm_Printing();
                RptSanadKabdPrint rpt = new RptSanadKabdPrint();

                frm.crystalReportViewer1.RefreshReport();
                rpt.SetDatabaseLogon("", "", ".\\SQLExpress", "Sales_StandardV2");
                rpt.SetDataSource(tblRpt);
                rpt.SetParameterValue("ID", num);

                frm.crystalReportViewer1.ReportSource = rpt;
                //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                //rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                //rpt.PrintToPrinter(1, true, 0, 0);
                frm.ShowDialog();
            }
            catch (Exception) { }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            { MessageBox.Show("من فضلك ادخل اسم المسؤل عن سند القبض", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            DataTable tblCheck = new DataTable();
            tblCheck.Clear();
            try
            {
                string d = DtbDate.Value.ToString("dd/MM/yyyy");
                db.RunNunQuary("insert into Sanad_Kabd values(" + txtDesID.Text + ",N'"+txtName.Text+"',"+NudPrice.Value+",N'"+txtFrom.Text+"','" + d + "',N'" + txtNotes.Text + "')", "تم قبض السند بنجاح");
                db.RunNunQuary("update Stock set Money=Money + " + NudPrice.Value + " where Stock_ID=" + stock_ID + "", "");
                db.RunNunQuary("insert into Stock_Insert  (Money ,Date,Name ,Type,Stock_ID) Values(" + NudPrice.Value + " ,'" + d + "' ,N'سند' ,'سند قبض' , " + stock_ID + ")", "");


                AutoNum();
                Print();
            }
            catch (Exception)
            { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Sanad_Kabd where Order_ID=" + txtDesID.Text + "", "تم حذف بيانات السند المحدد بنجاح");
                AutoNum();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RunNunQuary("delete  from Sanad_Kabd ", "تم حذف بيانات جميع البيانات المحدده بنجاح");
                AutoNum();
            }
        }
    }
}
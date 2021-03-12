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
    public partial class Frm_Serial : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Serial()
        {
            InitializeComponent();
        }

        private string identifier(string wmiClass, string wmiProperty)
        //Return a hardware identifier
        {
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                //Only get the first one
                if (result == "")
                {
                    try
                    {
                        result = mo[wmiProperty].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
            }
            return result;
        }
        decimal x = 0;

        private void Frm_Serial_Load(object sender, EventArgs e)
        {
            string manufatureID = identifier("Win32_DiskDrive", "SerialNumber");


            string signature = identifier("Win32_DiskDrive", "Signature");
            label1.Text = manufatureID;
            x = Convert.ToDecimal(signature) * (173);
            x = x - 123;
            label2.Text = (signature).ToString();
             

        }
        string x2;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("من فضلك ادخل كود التفعيل");
            }
            if( textBox1.Text == (x).ToString())
            {
                Properties.Settings.Default.ProductKey = "YES";
                Properties.Settings.Default.Save();
                Hide();
            }
            else
                MessageBox.Show("كود تفعيل البرنامج خطأ");
        }
    }
}
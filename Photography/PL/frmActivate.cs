using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net.NetworkInformation;

namespace iPhotography_MS.PL
{
    public partial class frmActivate : DevExpress.XtraEditors.XtraForm
    {
        public static string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    //IPInterfaceProperties properties = adapter.GetIPProperties(); Line is not required
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            } return sMacAddress;
        }
        
        static int CalculateHash(string serial)
        {
            int hashedValue = 0;
            for (int i = 0; i < serial.Length; i++)
            {
                hashedValue += (int)Convert.ToChar(serial[i]);
                hashedValue *= 4;
            }
            return hashedValue;
        }
        string calc()
        {
            return CalculateHash(txtSerial.Text).ToString();
        }

        public frmActivate()
        {
            InitializeComponent();
            txtSerial.Text = GetMACAddress();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                string check = calc();
                if (Convert.ToInt32(txtCode.Text) == Convert.ToInt32(check))
                {
                    Properties.Settings.Default.isPaid = true;
                    Properties.Settings.Default.Save();
                    XtraMessageBox.Show("تم التفعيل بنجاح", "التفعيل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    XtraMessageBox.Show("من فضلك أدخل رقم سيريال صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCode.Text = "";
                }
            }
            catch
            {
                XtraMessageBox.Show("من فضلك أدخل رقم سيريال صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}

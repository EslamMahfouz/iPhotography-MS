using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Security.AccessControl;

namespace iPhotography_MS.PL
{
    public partial class frmBackupFolder : DevExpress.XtraEditors.XtraForm
    {
        public frmBackupFolder()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtBackup.Text = folderBrowserDialog1.SelectedPath;
                    Properties.Settings.Default.BackupFolder = txtBackup.Text;
                    Properties.Settings.Default.Save();
                    File.SetAttributes(Properties.Settings.Default.BackupFolder, File.GetAttributes(Properties.Settings.Default.BackupFolder) & ~FileAttributes.ReadOnly);
                    DirectoryInfo dInfo = new DirectoryInfo(Properties.Settings.Default.BackupFolder);
                    DirectorySecurity dSecurity = dInfo.GetAccessControl();
                    dSecurity.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));
                    dInfo.SetAccessControl(dSecurity);
                }
            }
            catch
            {
                XtraMessageBox.Show("برجاء إختيار فولدر أخر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }
    }
}
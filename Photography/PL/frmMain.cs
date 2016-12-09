using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraTabbedMdi;
using System.Data.SqlClient;
using System.IO;

namespace iPhotography_MS.PL
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public void AddForm(Form son)
        {
            bool NotExist = true;
            try
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.Text == son.Text)
                    {
                        NotExist = false;
                        break;
                    }
                }
                if (NotExist == true)
                {
                    son.MdiParent = this;
                    son.Show();
                }
            }
            catch
            {
                return;
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddCategory frm = new frmAddCategory();
            AddForm(frm);
        }

        private void btnShowCategories_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmShowCategories frm = new frmShowCategories();
            AddForm(frm);
        }

        private void btnEditCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEditCategory frm = new frmEditCategory();
            AddForm(frm);
        }

        private void btnBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBooking frm = new frmBooking();
            AddForm(frm);
        }

        private void btnShowOrders_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmShowOrders frm = new frmShowOrders();
            AddForm(frm);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isPaid == false)
            {
                this.WindowState = FormWindowState.Maximized;
                frmActivate _frm = new frmActivate();
                _frm.ShowDialog();
                frmBackupFolder frmb = new frmBackupFolder();
                frmb.ShowDialog();
            }
            frmLoad frm = new frmLoad();
            AddForm(frm);
        }

        private void btnSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBackupFolder frmb = new frmBackupFolder();
            frmb.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(@"Server=.\SQLEXPRESS; Database=master; Integrated Security=true");
                SqlCommand cmd;

                string combined = Path.Combine(Properties.Settings.Default.BackupFolder, "PhotographyPackup.bak");
                File.Delete(combined);
                string query = "Backup Database Photography to Disk='" + combined + "'";
                cmd = new SqlCommand(query, sqlconnection);
                sqlconnection.Open();
                cmd.ExecuteNonQuery();
                sqlconnection.Close();
            }
            catch
            {
                return;
            }

        }
    }
}
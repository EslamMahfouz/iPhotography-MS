using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace iPhotography_MS.PL
{
    public partial class frmAddCategory : XtraForm
    {
        EDM.PhotographyEntities1 db = new EDM.PhotographyEntities1();

        public frmAddCategory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!valName.Validate())
            { return; }
            if(!valPrice.Validate())
            { return; }

            try
            {
                EDM.Category c = new EDM.Category()
                {
                    CategoryName = txtName.Text,
                    Price = txtPrice.Text,
                    Type = radioGroup1.Text,
                };
                    
                db.Categories.Add(c);
                db.SaveChanges();
                XtraMessageBox.Show("تم إضافة العرض", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Text = "";
                txtPrice.Text = "";
                txtName.Focus();
            }
            catch
            {
                return;
            }
        }
    }
}
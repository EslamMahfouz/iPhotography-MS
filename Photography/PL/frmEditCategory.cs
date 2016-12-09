using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace iPhotography_MS.PL
{
    public partial class frmEditCategory : XtraForm
    {
        EDM.PhotographyEntities1 db = new EDM.PhotographyEntities1();
        int categoryID;

        public frmEditCategory()
        {
            InitializeComponent();
        }

        private void frmEditCategory_Load(object sender, EventArgs e)
        {
            var query = from c in db.Categories
                        select new { م = c.CategoryID, العرض = c.CategoryName, السعر = c.Price, النوع = c.Type };
            cmbCategories.Properties.DataSource = query.ToList();
            cmbCategories.Properties.DisplayMember = "العرض";
            cmbCategories.Properties.ValueMember = "م";
            cmbCategories.Properties.PopulateViewColumns();
            cmbCategories.Properties.View.Columns["م"].Visible = false;
        }

        private void cmbCategories_EditValueChanged(object sender, EventArgs e)
        {
            categoryID = Convert.ToInt32(cmbCategories.EditValue);
            var category = db.Categories.Find(categoryID);
            txtName.Text = category.CategoryName;
            txtPrice.Text = category.Price;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!valName.Validate())
            { return; }
            if (!valPrice.Validate())
            { return; }

            var category = db.Categories.Find(categoryID);
            category.CategoryName = txtName.Text;
            category.Price = txtPrice.Text;
            db.SaveChanges();

            XtraMessageBox.Show("تم التعديل", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmEditCategory_Load(sender, e);
        }

        private void frmEditCategory_Enter(object sender, EventArgs e)
        {
            frmEditCategory_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var c = db.Categories.Find(categoryID);
                db.Categories.Remove(c);
                db.SaveChanges();
                XtraMessageBox.Show("تم الحذف", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmEditCategory_Load(sender, e);
                txtName.Text = "";
                txtPrice.Text = "";
            }
            catch
            {
                return;
            }
        }
    }
}
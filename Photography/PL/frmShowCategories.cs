using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;

namespace iPhotography_MS.PL
{
    public partial class frmShowCategories : DevExpress.XtraEditors.XtraForm
    {
        EDM.PhotographyEntities1 db = new EDM.PhotographyEntities1();

        public frmShowCategories()
        {
            InitializeComponent();
        }

        private void frmShowCategories_Load(object sender, EventArgs e)
        {
            var query = from c in db.Categories
                        select new { م = c.CategoryID, العرض = c.CategoryName, السعر = c.Price, النوع = c.Type };
            gridCategories.DataSource = query.ToList();
            gridView1.Columns["م"].Visible = false;
            gridView1.Columns["العرض"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["العرض"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["السعر"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["السعر"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["العرض"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["السعر"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["العرض"].OptionsColumn.ReadOnly = false;
        }

        private void frmShowCategories_Enter(object sender, EventArgs e)
        {
            frmShowCategories_Load(sender, e);
        }
    }
}
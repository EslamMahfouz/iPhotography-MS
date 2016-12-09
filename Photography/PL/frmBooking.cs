using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace iPhotography_MS.PL
{
    public partial class frmBooking : DevExpress.XtraEditors.XtraForm
    {
        EDM.PhotographyEntities1 db = new EDM.PhotographyEntities1();
        public Boolean isEdit = false;
        public int orderID;
        double price;
        public string type;

        public frmBooking()
        {
            InitializeComponent();
            timeEdit1.EditValue = DateTime.Now.TimeOfDay;
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            radioGroup1_SelectedIndexChanged(sender, e);

            var categories = from c in db.Categories
                        select new { م = c.CategoryID, العرض = c.CategoryName, السعر = c.Price, النوع = c.Type };
            cmbCategories.Properties.DataSource = categories.ToList();
            cmbCategories.Properties.DisplayMember = "العرض";
            cmbCategories.Properties.ValueMember = "م";
            cmbCategories.Properties.PopulateViewColumns();
            cmbCategories.Properties.View.Columns["م"].Visible = false;            
            
            if (isEdit)
            {
                if (type == "عادي")
                {
                    radioGroup1.SelectedIndex = 0;
                    radioGroup1.Enabled = false;
                }
                else
                {
                    radioGroup1.SelectedIndex = 1;
                    radioGroup1.Enabled = false;
                }
                var order = db.Orders.Find(orderID);
                txtName.Text = order.Name;

                var category = from x in db.Categories
                               where x.CategoryName == order.CategoryName
                               select x;

                int categoryID = 0;
                foreach (var item in category)
                {
                    categoryID = item.CategoryID;
                }
                cmbCategories.EditValue = categoryID;
                txtAddress.Text = order.Address;
                txtPhone.Text = order.Phone;
                txtGroomName.Text = order.GroomName;
                txtBrideName.Text = order.BrideName;
                dtRegisterDate.EditValue = order.RegisterDate;
                dtWeddingDate.EditValue = order.WeddingDate;
                dtReceiptDate.EditValue = order.ReceiptDate;
                txtTotal.Text = order.Total;
                txtDiscount.Text = order.Discount;
                txtPrice.Text = order.Price;
                txtPaid.Text = order.Paid;
                txtCarry.Text = order.Carry;
                chkDelivered.EditValue = order.Delivered;
                timeEdit1.EditValue = order.Time;
                btnAdd.Text = "حفظ";
            }
        }

        private void cmbCategories_EditValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbCategories.EditValue);
            var category = db.Categories.Find(id);

            price = Convert.ToDouble(category.Price);
            txtTotal.Text = category.Price;
            txtPrice.Text = category.Price;
            txtDiscount_EditValueChanged(sender, e);
            txtPaid_EditValueChanged(sender, e);
        }
            
        
        private void txtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDiscount.Text == "")
                {
                    txtDiscount.Text = 0.ToString();
                }
                txtPrice.Text = (Convert.ToDouble(txtTotal.Text) - (Convert.ToDouble(txtTotal.Text) * (Convert.ToDouble(txtDiscount.Text) / 100))).ToString();
                txtPaid_EditValueChanged(sender, e);
            }
            catch
            { 
                return;
            }
        }

        private void txtPaid_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtCarry.Text = (Convert.ToDouble(txtPrice.Text) - Convert.ToDouble(txtPaid.Text)).ToString();
            }
            catch
            {
                return;
            }
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            if (txtDiscount.Text == "")
                txtPrice.Text = txtTotal.Text;
            txtPaid_EditValueChanged(sender, e);
        }

        private void txtPaid_Leave(object sender, EventArgs e)
        {
            if (txtPaid.Text == "")
                txtCarry.Text = txtPrice.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!valName.Validate())
            { return; }
            if (!valCategory.Validate())
            { return; }
            if (!valPhone.Validate())
            { return; }
            if (!valRegisterDate.Validate())
            { return; }
            if (!valWeddingDate.Validate())
            { return; }
            if (!valReceiptDate.Validate())
            { return; }

            try
            {
                if (isEdit)
                {
                    var order = db.Orders.Find(orderID);
                    order.Name = txtName.Text;
                    order.CategoryName = cmbCategories.Text;
                    order.Address = txtAddress.Text;
                    order.Phone = txtPhone.Text;
                    order.GroomName = txtGroomName.Text;
                    order.BrideName = txtBrideName.Text;
                    order.RegisterDate = Convert.ToDateTime(dtRegisterDate.EditValue);
                    order.WeddingDate = Convert.ToDateTime(dtWeddingDate.EditValue);
                    order.ReceiptDate = Convert.ToDateTime(dtReceiptDate.EditValue);
                    order.Total = txtTotal.Text;
                    order.Discount = txtDiscount.Text;
                    order.Price = txtPrice.Text;
                    order.Paid = txtPaid.Text;
                    order.Carry = txtCarry.Text;
                    order.Time = timeEdit1.Text;
                    order.Delivered = Convert.ToBoolean(chkDelivered.EditValue);

                    db.SaveChanges();
                    XtraMessageBox.Show("تم التعديل", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isEdit = false;
                }
                else
                {
                    EDM.Order o = new EDM.Order()
                    {
                        CategoryName = cmbCategories.Text,
                        Name = txtName.Text,
                        Phone = txtPhone.Text,
                        Address = txtAddress.Text,
                        GroomName = txtGroomName.Text,
                        BrideName = txtBrideName.Text,
                        RegisterDate = Convert.ToDateTime(dtRegisterDate.EditValue),
                        WeddingDate = Convert.ToDateTime(dtWeddingDate.EditValue),
                        ReceiptDate = Convert.ToDateTime(dtReceiptDate.EditValue),
                        Total = txtTotal.Text,
                        Discount = txtDiscount.Text,
                        Price = txtPrice.Text,
                        Paid = txtPaid.Text,
                        Carry = txtCarry.Text,
                        Type = radioGroup1.Text,
                        Delivered = Convert.ToBoolean(chkDelivered.EditValue),
                        Time = timeEdit1.Text,
                    };
                    db.Orders.Add(o);
                    db.SaveChanges();
                    XtraMessageBox.Show("تم إضافة الحجز", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch
            {
                return;
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                grp.Visible = false;
                dtRegisterDate.EditValue = DateTime.Now;
                dtWeddingDate.EditValue = DateTime.Now;
                lblNumber.Visible = true;
                txtNumber.Visible = true;
            }
            else
            {
                grp.Visible = true;
                dtRegisterDate.EditValue = DateTime.Now;
                dtWeddingDate.Text = "";
                lblNumber.Visible = false;
                txtNumber.Visible = false;
                txtNumber.Text = "1";
                txtDiscount_EditValueChanged(sender, e);
                txtPaid_EditValueChanged(sender, e);
            }
        }

        private void txtNumber_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNumber.Text == "" && txtNumber.Text == "0")
                {
                    txtNumber.Text = 1.ToString();
                }
                txtTotal.Text = (price * Convert.ToInt32(txtNumber.Text)).ToString();
                txtDiscount_EditValueChanged(sender, e);
            }
            catch
            {
                return;
            }
        }
        
    }
}
using System;
using System.Collections.Generic;using System.Linq;

namespace iPhotography_MS.PL
{
    public partial class frmShowOrders : DevExpress.XtraEditors.XtraForm
    {
        EDM.PhotographyEntities1 db = new EDM.PhotographyEntities1();

        public frmShowOrders()
        {
            InitializeComponent();
        }

        private void calendarControl1_DateTimeChanged(object sender, EventArgs e)
        {
             DateTime dtFrom = Convert.ToDateTime(dtDates.EditValue);

            gridOrders.DataSource = null;
            var orders = from o in db.Orders
                         where (o.WeddingDate == dtFrom || o.ReceiptDate == dtFrom)
                         select new { م = o.OrderID, الإسم = o.Name, التليفون = o.Phone, العنوان = o.Address, التصوير = o.WeddingDate, المعاد= o.Time, التسليم = o.ReceiptDate, النوع = o.Type }; 
            gridOrders.DataSource = orders.ToList();
            gridView1.Columns["م"].Visible = false;
        }


        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                return;
            }
            frmBooking frm = new frmBooking();
            frm.isEdit = true;
            frm.type = gridView1.GetFocusedRowCellValue("النوع").ToString();
            frm.orderID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("م"));
            frm.Text = "بيانات الحجز";
            frm.ShowDialog();
            calendarControl1_DateTimeChanged(sender, e);
        }

        private void frmShowOrders_Load(object sender, EventArgs e)
        {
            var orders = from x in db.Orders
                         select new { م = x.OrderID, الإسم = x.Name, العرض = x.CategoryName, تاريخ_التصوير = x.WeddingDate, المعاد = x.Time, تاريخ_التسليم = x.ReceiptDate, النوع = x.Type };
            cmbOrders.Properties.DataSource = orders.ToList();
            cmbOrders.Properties.PopulateViewColumns();
            cmbOrders.Properties.DisplayMember = "الإسم";
            cmbOrders.Properties.ValueMember = "م";
            cmbOrders.Properties.View.Columns["م"].Visible = false;
        }

        private void cmbOrders_EditValueChanged(object sender, EventArgs e)
        {
            int orderID = Convert.ToInt32(cmbOrders.EditValue);
            var order = db.Orders.Find(orderID);

            frmBooking frm = new frmBooking();
            frm.isEdit = true;
            frm.type = order.Type;
            frm.orderID = orderID;
            frm.Text = "بيانات الحجز";
            frm.ShowDialog();
        }
            

                         

             
             
    }
}
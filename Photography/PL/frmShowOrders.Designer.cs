namespace iPhotography_MS.PL
{
    partial class frmShowOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtDates = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.gridOrders = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbOrders = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtDates.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrders.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDates
            // 
            this.dtDates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDates.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDates.Location = new System.Drawing.Point(691, 45);
            this.dtDates.Name = "dtDates";
            this.dtDates.Size = new System.Drawing.Size(279, 258);
            this.dtDates.TabIndex = 0;
            this.dtDates.DateTimeChanged += new System.EventHandler(this.calendarControl1_DateTimeChanged);
            // 
            // gridOrders
            // 
            this.gridOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gridOrders.Location = new System.Drawing.Point(11, 45);
            this.gridOrders.MainView = this.gridView1;
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridOrders.Size = new System.Drawing.Size(649, 268);
            this.gridOrders.TabIndex = 1;
            this.gridOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridOrders;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // cmbOrders
            // 
            this.cmbOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOrders.Location = new System.Drawing.Point(585, 11);
            this.cmbOrders.Name = "cmbOrders";
            this.cmbOrders.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbOrders.Properties.Appearance.Options.UseFont = true;
            this.cmbOrders.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.cmbOrders.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOrders.Properties.NullText = "حجز بإسم";
            this.cmbOrders.Properties.View = this.searchLookUpEdit1View;
            this.cmbOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbOrders.Size = new System.Drawing.Size(385, 28);
            this.cmbOrders.TabIndex = 4;
            this.cmbOrders.EditValueChanged += new System.EventHandler(this.cmbOrders_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // frmShowOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 326);
            this.Controls.Add(this.gridOrders);
            this.Controls.Add(this.dtDates);
            this.Controls.Add(this.cmbOrders);
            this.Name = "frmShowOrders";
            this.Text = "عرض الحجوزات";
            this.Load += new System.EventHandler(this.frmShowOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDates.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrders.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Controls.CalendarControl dtDates;
        private DevExpress.XtraGrid.GridControl gridOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    }
}
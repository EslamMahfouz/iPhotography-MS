namespace iPhotography_MS.PL
{
    partial class frmShowCategories
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
            this.gridCategories = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCategories
            // 
            this.gridCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCategories.Location = new System.Drawing.Point(0, 0);
            this.gridCategories.MainView = this.gridView1;
            this.gridCategories.Name = "gridCategories";
            this.gridCategories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridCategories.Size = new System.Drawing.Size(607, 253);
            this.gridCategories.TabIndex = 0;
            this.gridCategories.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridCategories;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            
            // 
            // frmShowCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 253);
            this.Controls.Add(this.gridCategories);
            this.Name = "frmShowCategories";
            this.Text = "عرض وتعديل العروض";
            this.Load += new System.EventHandler(this.frmShowCategories_Load);
            this.Enter += new System.EventHandler(this.frmShowCategories_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCategories;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
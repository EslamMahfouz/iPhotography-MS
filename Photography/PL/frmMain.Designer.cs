namespace iPhotography_MS.PL
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.btnAddCategory = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditCategory = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowCategories = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.btnBook = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowOrders = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.btnAddWanted = new DevExpress.XtraBars.BarButtonItem();
            this.btnWanted = new DevExpress.XtraBars.BarButtonItem();
            this.frmShowDailyCategories = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.btnAddDaily = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowDaily = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem6 = new DevExpress.XtraBars.BarSubItem();
            this.btnAddUser = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.btnSettings = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.RightToLeftLayout = DevExpress.Utils.DefaultBoolean.True;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1,
            this.barSubItem1,
            this.barSubItem2,
            this.btnAddCategory,
            this.btnShowCategories,
            this.btnEditCategory,
            this.barSubItem3,
            this.btnBook,
            this.btnShowOrders,
            this.btnBackup,
            this.btnRestore,
            this.barSubItem4,
            this.btnAddWanted,
            this.btnWanted,
            this.frmShowDailyCategories,
            this.barCheckItem1,
            this.barSubItem5,
            this.btnAddDaily,
            this.btnShowDaily,
            this.barSubItem6,
            this.btnAddUser,
            this.btnChangePassword,
            this.btnSettings});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 23;
            this.barManager1.RightToLeft = DevExpress.Utils.DefaultBoolean.True;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSettings)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.barSubItem2.Caption = "العروض";
            this.barSubItem2.Id = 2;
            this.barSubItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.barSubItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddCategory),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditCategory),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnShowCategories)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Caption = "إضافة عرض";
            this.btnAddCategory.Id = 3;
            this.btnAddCategory.ImageUri.Uri = "Add";
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddCategory_ItemClick);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Caption = "تعديل عرض";
            this.btnEditCategory.Id = 5;
            this.btnEditCategory.ImageUri.Uri = "CustomizeGrid";
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditCategory_ItemClick);
            // 
            // btnShowCategories
            // 
            this.btnShowCategories.Caption = "عرض جميع العروض";
            this.btnShowCategories.Id = 4;
            this.btnShowCategories.ImageUri.Uri = "AlignCenter";
            this.btnShowCategories.Name = "btnShowCategories";
            this.btnShowCategories.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowCategories_ItemClick);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.barSubItem3.Caption = "الحجوزات";
            this.barSubItem3.Id = 6;
            this.barSubItem3.ImageUri.Uri = "Stretch";
            this.barSubItem3.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.barSubItem3.ItemAppearance.Normal.Options.UseFont = true;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBook),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnShowOrders)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // btnBook
            // 
            this.btnBook.Caption = "حجز جديد";
            this.btnBook.Id = 7;
            this.btnBook.ImageUri.Uri = "Add";
            this.btnBook.Name = "btnBook";
            this.btnBook.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBook_ItemClick);
            // 
            // btnShowOrders
            // 
            this.btnShowOrders.Caption = "عرض الحجوزات";
            this.btnShowOrders.Id = 8;
            this.btnShowOrders.ImageUri.Uri = "ListNumbers";
            this.btnShowOrders.Name = "btnShowOrders";
            this.btnShowOrders.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowOrders_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Themes";
            this.skinBarSubItem1.Id = 0;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(977, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 687);
            this.barDockControlBottom.Size = new System.Drawing.Size(977, 34);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 657);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(977, 30);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 657);
            // 
            // barSubItem1
            // 
            this.barSubItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.barSubItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.barSubItem1.Caption = "ملف";
            this.barSubItem1.Id = 1;
            this.barSubItem1.ImageUri.Uri = "Open";
            this.barSubItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.barSubItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBackup),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRestore)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "إنشاء نسخة إحتياطية";
            this.btnBackup.Id = 9;
            this.btnBackup.ImageUri.Uri = "AddNewDataSource";
            this.btnBackup.Name = "btnBackup";
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "إسترجاع نسخة إحتياطية";
            this.btnRestore.Id = 10;
            this.btnRestore.ImageUri.Uri = "EditDataSource";
            this.btnRestore.Name = "btnRestore";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "المطلوب";
            this.barSubItem4.Id = 11;
            this.barSubItem4.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.barSubItem4.ItemAppearance.Normal.Options.UseFont = true;
            this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddWanted),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnWanted),
            new DevExpress.XtraBars.LinkPersistInfo(this.frmShowDailyCategories)});
            this.barSubItem4.Name = "barSubItem4";
            // 
            // btnAddWanted
            // 
            this.btnAddWanted.Caption = "إضافة";
            this.btnAddWanted.Id = 12;
            this.btnAddWanted.Name = "btnAddWanted";
            // 
            // btnWanted
            // 
            this.btnWanted.Caption = "تعديل";
            this.btnWanted.Id = 13;
            this.btnWanted.Name = "btnWanted";
            // 
            // frmShowDailyCategories
            // 
            this.frmShowDailyCategories.Caption = "عرض الجميع";
            this.frmShowDailyCategories.Id = 14;
            this.frmShowDailyCategories.Name = "frmShowDailyCategories";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 15;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = "اليومية";
            this.barSubItem5.Id = 16;
            this.barSubItem5.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.barSubItem5.ItemAppearance.Normal.Options.UseFont = true;
            this.barSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddDaily),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnShowDaily)});
            this.barSubItem5.Name = "barSubItem5";
            // 
            // btnAddDaily
            // 
            this.btnAddDaily.Caption = "إضافة";
            this.btnAddDaily.Id = 17;
            this.btnAddDaily.Name = "btnAddDaily";
            // 
            // btnShowDaily
            // 
            this.btnShowDaily.Caption = "عرض الحجوزات";
            this.btnShowDaily.Id = 18;
            this.btnShowDaily.Name = "btnShowDaily";
            // 
            // barSubItem6
            // 
            this.barSubItem6.Caption = "المستخدمين";
            this.barSubItem6.Id = 19;
            this.barSubItem6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddUser),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChangePassword)});
            this.barSubItem6.Name = "barSubItem6";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Caption = "إضافة مستخدم";
            this.btnAddUser.Id = 20;
            this.btnAddUser.Name = "btnAddUser";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "تغيير كلمة السر";
            this.btnChangePassword.Id = 21;
            this.btnChangePassword.Name = "btnChangePassword";
            // 
            // btnSettings
            // 
            this.btnSettings.Caption = "إعدادات النسخة الإحتياطية";
            this.btnSettings.Id = 22;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSettings_ItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 721);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.LookAndFeel.SkinName = "Metropolis Dark";
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iPhotography MS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem btnAddCategory;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnShowCategories;
        private DevExpress.XtraBars.BarButtonItem btnEditCategory;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem btnBook;
        private DevExpress.XtraBars.BarButtonItem btnShowOrders;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarButtonItem btnAddWanted;
        private DevExpress.XtraBars.BarButtonItem btnWanted;
        private DevExpress.XtraBars.BarButtonItem frmShowDailyCategories;
        private DevExpress.XtraBars.BarSubItem barSubItem5;
        private DevExpress.XtraBars.BarButtonItem btnAddDaily;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarButtonItem btnShowDaily;
        private DevExpress.XtraBars.BarSubItem barSubItem6;
        private DevExpress.XtraBars.BarButtonItem btnAddUser;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
        private DevExpress.XtraBars.BarButtonItem btnSettings;
    }
}
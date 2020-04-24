using System;
namespace FormLogin
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.dS = new FormLogin.DS();
            this.bdsDatabases = new System.Windows.Forms.BindingSource(this.components);
            this.tbAdapterDatabases = new FormLogin.DSTableAdapters.databasesTableAdapter();
            this.tableAdapterManager = new FormLogin.DSTableAdapters.TableAdapterManager();
            this.tbAdapterSttBackup = new FormLogin.DSTableAdapters.SP_STT_BACKUPTableAdapter();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.databasesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatabase_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnSaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.cbThamSoTheoTg = new DevExpress.XtraBars.BarCheckItem();
            this.btnTaoDeviceSaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnGhiBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnThamSoThoiGian = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDSBD = new DevExpress.XtraBars.BarButtonItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lbSoBanSaoLuu = new System.Windows.Forms.Label();
            this.sP_STT_BACKUPGridControl = new DevExpress.XtraGrid.GridControl();
            this.ctxMenuBackup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnXoaBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsSPSttBackup = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbTenDatabase = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.gcDatetime = new DevExpress.XtraEditors.GroupControl();
            this.timeStop = new DevExpress.XtraEditors.TimeEdit();
            this.dateStop = new DevExpress.XtraEditors.DateEdit();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDelAll = new System.Windows.Forms.CheckBox();
            this.bdsBackupDevice = new System.Windows.Forms.BindingSource(this.components);
            this.tbAdapterBackupDevice = new FormLogin.DSTableAdapters.backup_devicesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatabases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_STT_BACKUPGridControl)).BeginInit();
            this.ctxMenuBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSPSttBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatetime)).BeginInit();
            this.gcDatetime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeStop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBackupDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDatabases
            // 
            this.bdsDatabases.DataMember = "databases";
            this.bdsDatabases.DataSource = this.dS;
            // 
            // tbAdapterDatabases
            // 
            this.tbAdapterDatabases.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = FormLogin.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbAdapterSttBackup
            // 
            this.tbAdapterSttBackup.ClearBeforeFill = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.databasesGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 96);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(463, 1630);
            this.groupControl2.TabIndex = 21;
            this.groupControl2.Text = "Cơ sở dữ liệu";
            // 
            // databasesGridControl
            // 
            this.databasesGridControl.DataSource = this.bdsDatabases;
            this.databasesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databasesGridControl.Location = new System.Drawing.Point(3, 48);
            this.databasesGridControl.MainView = this.gridView1;
            this.databasesGridControl.MenuManager = this.barManager1;
            this.databasesGridControl.Name = "databasesGridControl";
            this.databasesGridControl.Size = new System.Drawing.Size(457, 1579);
            this.databasesGridControl.TabIndex = 0;
            this.databasesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.databasesGridControl.Click += new System.EventHandler(this.databasesGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname1,
            this.coldatabase_id});
            this.gridView1.GridControl = this.databasesGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colname1
            // 
            this.colname1.Caption = "Tên database";
            this.colname1.FieldName = "name";
            this.colname1.MinWidth = 50;
            this.colname1.Name = "colname1";
            this.colname1.OptionsColumn.AllowEdit = false;
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 0;
            this.colname1.Width = 187;
            // 
            // coldatabase_id
            // 
            this.coldatabase_id.FieldName = "database_id";
            this.coldatabase_id.MinWidth = 50;
            this.coldatabase_id.Name = "coldatabase_id";
            this.coldatabase_id.Width = 187;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSaoLuu,
            this.btnGhiBD,
            this.btnXoaBD,
            this.btnSuaBD,
            this.btnPhucHoi,
            this.btnThamSoThoiGian,
            this.btnInDSBD,
            this.btnThoat,
            this.btnTaoDeviceSaoLuu,
            this.barToggleSwitchItem1,
            this.barCheckItem1,
            this.barCheckItem2,
            this.barButtonItem1,
            this.cbThamSoTheoTg,
            this.btnDangXuat});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 18;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSaoLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cbThamSoTheoTg, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaoDeviceSaoLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDangXuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Caption = "Sao lưu";
            this.btnSaoLuu.Id = 0;
            this.btnSaoLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.Image")));
            this.btnSaoLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.LargeImage")));
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaoLuu_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // cbThamSoTheoTg
            // 
            this.cbThamSoTheoTg.Caption = "Tham số theo thời gian";
            this.cbThamSoTheoTg.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.cbThamSoTheoTg.Id = 16;
            this.cbThamSoTheoTg.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cbThamSoTheoTg.ImageOptions.Image")));
            this.cbThamSoTheoTg.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cbThamSoTheoTg.ImageOptions.LargeImage")));
            this.cbThamSoTheoTg.Name = "cbThamSoTheoTg";
            this.cbThamSoTheoTg.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.cbThamSoTheoTg_CheckedChanged);
            // 
            // btnTaoDeviceSaoLuu
            // 
            this.btnTaoDeviceSaoLuu.Caption = "Tạo device sao lưu";
            this.btnTaoDeviceSaoLuu.Id = 8;
            this.btnTaoDeviceSaoLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoDeviceSaoLuu.ImageOptions.Image")));
            this.btnTaoDeviceSaoLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoDeviceSaoLuu.ImageOptions.LargeImage")));
            this.btnTaoDeviceSaoLuu.Name = "btnTaoDeviceSaoLuu";
            this.btnTaoDeviceSaoLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoDeviceSaoLuu_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 17;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(2235, 96);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1726);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(2235, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 96);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1630);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2235, 96);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1630);
            // 
            // btnGhiBD
            // 
            this.btnGhiBD.Caption = "Ghi";
            this.btnGhiBD.Id = 1;
            this.btnGhiBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiBD.ImageOptions.Image")));
            this.btnGhiBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhiBD.ImageOptions.LargeImage")));
            this.btnGhiBD.Name = "btnGhiBD";
            // 
            // btnXoaBD
            // 
            this.btnXoaBD.Caption = "Xóa";
            this.btnXoaBD.Id = 2;
            this.btnXoaBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaBD.ImageOptions.Image")));
            this.btnXoaBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaBD.ImageOptions.LargeImage")));
            this.btnXoaBD.Name = "btnXoaBD";
            // 
            // btnSuaBD
            // 
            this.btnSuaBD.Caption = "Sửa";
            this.btnSuaBD.Id = 3;
            this.btnSuaBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaBD.ImageOptions.Image")));
            this.btnSuaBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaBD.ImageOptions.LargeImage")));
            this.btnSuaBD.Name = "btnSuaBD";
            // 
            // btnThamSoThoiGian
            // 
            this.btnThamSoThoiGian.Caption = "Tham số theo thời gian";
            this.btnThamSoThoiGian.Id = 5;
            this.btnThamSoThoiGian.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThamSoThoiGian.ImageOptions.Image")));
            this.btnThamSoThoiGian.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThamSoThoiGian.ImageOptions.LargeImage")));
            this.btnThamSoThoiGian.Name = "btnThamSoThoiGian";
            // 
            // btnInDSBD
            // 
            this.btnInDSBD.Caption = "In danh sách";
            this.btnInDSBD.Id = 6;
            this.btnInDSBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInDSBD.ImageOptions.Image")));
            this.btnInDSBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInDSBD.ImageOptions.LargeImage")));
            this.btnInDSBD.Name = "btnInDSBD";
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "cb";
            this.barToggleSwitchItem1.Id = 11;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "cb";
            this.barCheckItem1.Id = 12;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // barCheckItem2
            // 
            this.barCheckItem2.Caption = "barCheckItem2";
            this.barCheckItem2.Id = 13;
            this.barCheckItem2.Name = "barCheckItem2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 15;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lbSoBanSaoLuu);
            this.groupControl3.Controls.Add(this.sP_STT_BACKUPGridControl);
            this.groupControl3.Controls.Add(this.lbTenDatabase);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(463, 96);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1772, 870);
            this.groupControl3.TabIndex = 22;
            this.groupControl3.Text = "Tên cơ sở dữ liệu";
            // 
            // lbSoBanSaoLuu
            // 
            this.lbSoBanSaoLuu.AutoSize = true;
            this.lbSoBanSaoLuu.Location = new System.Drawing.Point(739, 6);
            this.lbSoBanSaoLuu.Name = "lbSoBanSaoLuu";
            this.lbSoBanSaoLuu.Size = new System.Drawing.Size(0, 34);
            this.lbSoBanSaoLuu.TabIndex = 2;
            // 
            // sP_STT_BACKUPGridControl
            // 
            this.sP_STT_BACKUPGridControl.ContextMenuStrip = this.ctxMenuBackup;
            this.sP_STT_BACKUPGridControl.DataSource = this.bdsSPSttBackup;
            this.sP_STT_BACKUPGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_STT_BACKUPGridControl.Location = new System.Drawing.Point(3, 48);
            this.sP_STT_BACKUPGridControl.MainView = this.gridView2;
            this.sP_STT_BACKUPGridControl.MenuManager = this.barManager1;
            this.sP_STT_BACKUPGridControl.Name = "sP_STT_BACKUPGridControl";
            this.sP_STT_BACKUPGridControl.Size = new System.Drawing.Size(1766, 819);
            this.sP_STT_BACKUPGridControl.TabIndex = 1;
            this.sP_STT_BACKUPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.sP_STT_BACKUPGridControl.Click += new System.EventHandler(this.sP_STT_BACKUPGridControl_Click);
            // 
            // ctxMenuBackup
            // 
            this.ctxMenuBackup.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctxMenuBackup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXoaBackup});
            this.ctxMenuBackup.Name = "ctxMenuBackup";
            this.ctxMenuBackup.Size = new System.Drawing.Size(148, 50);
            // 
            // btnXoaBackup
            // 
            this.btnXoaBackup.Name = "btnXoaBackup";
            this.btnXoaBackup.Size = new System.Drawing.Size(147, 46);
            this.btnXoaBackup.Text = "Xóa";
            this.btnXoaBackup.Click += new System.EventHandler(this.btnXoaBackup_Click);
            // 
            // bdsSPSttBackup
            // 
            this.bdsSPSttBackup.DataMember = "SP_STT_BACKUP";
            this.bdsSPSttBackup.DataSource = this.dS;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colposition,
            this.colname,
            this.colbackup_start_date,
            this.coluser_name});
            this.gridView2.GridControl = this.sP_STT_BACKUPGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colposition
            // 
            this.colposition.Caption = "Bản sao thứ #";
            this.colposition.FieldName = "position";
            this.colposition.MinWidth = 50;
            this.colposition.Name = "colposition";
            this.colposition.OptionsColumn.AllowEdit = false;
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 0;
            this.colposition.Width = 187;
            // 
            // colname
            // 
            this.colname.Caption = "Diễn giải";
            this.colname.FieldName = "name";
            this.colname.MinWidth = 50;
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 187;
            // 
            // colbackup_start_date
            // 
            this.colbackup_start_date.Caption = "Ngày giờ sao lưu";
            this.colbackup_start_date.DisplayFormat.FormatString = "g";
            this.colbackup_start_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbackup_start_date.FieldName = "backup_start_date";
            this.colbackup_start_date.GroupFormat.FormatString = "d";
            this.colbackup_start_date.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbackup_start_date.MinWidth = 50;
            this.colbackup_start_date.Name = "colbackup_start_date";
            this.colbackup_start_date.OptionsColumn.AllowEdit = false;
            this.colbackup_start_date.Visible = true;
            this.colbackup_start_date.VisibleIndex = 2;
            this.colbackup_start_date.Width = 187;
            // 
            // coluser_name
            // 
            this.coluser_name.Caption = "User sao lưu";
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.MinWidth = 50;
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.OptionsColumn.AllowEdit = false;
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 3;
            this.coluser_name.Width = 187;
            // 
            // lbTenDatabase
            // 
            this.lbTenDatabase.AutoSize = true;
            this.lbTenDatabase.Location = new System.Drawing.Point(323, 3);
            this.lbTenDatabase.Name = "lbTenDatabase";
            this.lbTenDatabase.Size = new System.Drawing.Size(0, 34);
            this.lbTenDatabase.TabIndex = 1;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(710, 1175);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(1003, 44);
            this.progress.TabIndex = 23;
            // 
            // gcDatetime
            // 
            this.gcDatetime.Controls.Add(this.timeStop);
            this.gcDatetime.Controls.Add(this.dateStop);
            this.gcDatetime.Controls.Add(this.richTextBox1);
            this.gcDatetime.Controls.Add(this.label2);
            this.gcDatetime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcDatetime.Location = new System.Drawing.Point(463, 1252);
            this.gcDatetime.Name = "gcDatetime";
            this.gcDatetime.Size = new System.Drawing.Size(1772, 474);
            this.gcDatetime.TabIndex = 24;
            // 
            // timeStop
            // 
            this.timeStop.EditValue = new System.DateTime(2020, 4, 23, 0, 0, 0, 0);
            this.timeStop.Location = new System.Drawing.Point(1116, 76);
            this.timeStop.MenuManager = this.barManager1;
            this.timeStop.Name = "timeStop";
            this.timeStop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeStop.Size = new System.Drawing.Size(250, 50);
            this.timeStop.TabIndex = 11;
            // 
            // dateStop
            // 
            this.dateStop.EditValue = null;
            this.dateStop.Location = new System.Drawing.Point(689, 76);
            this.dateStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateStop.MenuManager = this.barManager1;
            this.dateStop.Name = "dateStop";
            this.dateStop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStop.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStop.Size = new System.Drawing.Size(350, 50);
            this.dateStop.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(181, 163);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1185, 122);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày giờ để phục hồi tới thời điểm đó";
            // 
            // cbDelAll
            // 
            this.cbDelAll.AutoSize = true;
            this.cbDelAll.Location = new System.Drawing.Point(710, 1113);
            this.cbDelAll.Name = "cbDelAll";
            this.cbDelAll.Size = new System.Drawing.Size(781, 38);
            this.cbDelAll.TabIndex = 7;
            this.cbDelAll.Text = "Xóa tất cả bản sao lưu trong file trước khi sao lưu bản mới";
            this.cbDelAll.UseVisualStyleBackColor = true;
            // 
            // bdsBackupDevice
            // 
            this.bdsBackupDevice.DataMember = "backup_devices";
            this.bdsBackupDevice.DataSource = this.dS;
            // 
            // tbAdapterBackupDevice
            // 
            this.tbAdapterBackupDevice.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2235, 1726);
            this.Controls.Add(this.cbDelAll);
            this.Controls.Add(this.gcDatetime);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormMain";
            this.Text = "FormMain1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatabases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_STT_BACKUPGridControl)).EndInit();
            this.ctxMenuBackup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsSPSttBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatetime)).EndInit();
            this.gcDatetime.ResumeLayout(false);
            this.gcDatetime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeStop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBackupDevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.BindingSource bdsDatabases;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl databasesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraGrid.Columns.GridColumn coldatabase_id;
        private System.Windows.Forms.Label lbTenDatabase;
        private System.Windows.Forms.ProgressBar progress;
        private DevExpress.XtraEditors.GroupControl gcDatetime;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private DS dS;
        private DSTableAdapters.databasesTableAdapter tbAdapterDatabases;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.SP_STT_BACKUPTableAdapter tbAdapterSttBackup;
        private System.Windows.Forms.BindingSource bdsSPSttBackup;
        private System.Windows.Forms.CheckBox cbDelAll;
        private System.Windows.Forms.ContextMenuStrip ctxMenuBackup;
        private System.Windows.Forms.ToolStripMenuItem btnXoaBackup;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnSaoLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarCheckItem cbThamSoTheoTg;
        private DevExpress.XtraBars.BarButtonItem btnTaoDeviceSaoLuu;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnGhiBD;
        private DevExpress.XtraBars.BarButtonItem btnXoaBD;
        private DevExpress.XtraBars.BarButtonItem btnSuaBD;
        private DevExpress.XtraBars.BarButtonItem btnThamSoThoiGian;
        private DevExpress.XtraBars.BarButtonItem btnInDSBD;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.DateEdit dateStop;
        private DevExpress.XtraEditors.TimeEdit timeStop;
        private System.Windows.Forms.BindingSource bdsBackupDevice;
        private DSTableAdapters.backup_devicesTableAdapter tbAdapterBackupDevice;
        private DevExpress.XtraGrid.GridControl sP_STT_BACKUPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private System.Windows.Forms.Label lbSoBanSaoLuu;
    }
}
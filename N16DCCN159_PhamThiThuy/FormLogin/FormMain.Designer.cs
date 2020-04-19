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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThemBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLaiBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatBD = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnInDSBD = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
            this.btnThemBD,
            this.btnGhiBD,
            this.btnXoaBD,
            this.btnSuaBD,
            this.btnPhucHoiBD,
            this.btnTaiLaiBD,
            this.btnInDSBD,
            this.btnThoatBD,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 9;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemBD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoiBD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaiLaiBD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatBD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btnThemBD
            // 
            this.btnThemBD.Caption = "Sao lưu";
            this.btnThemBD.Id = 0;
            this.btnThemBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemBD.ImageOptions.Image")));
            this.btnThemBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemBD.ImageOptions.LargeImage")));
            this.btnThemBD.Name = "btnThemBD";
            // 
            // btnSuaBD
            // 
            this.btnSuaBD.Caption = "Sửa";
            this.btnSuaBD.Id = 3;
            this.btnSuaBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaBD.ImageOptions.Image")));
            this.btnSuaBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaBD.ImageOptions.LargeImage")));
            this.btnSuaBD.Name = "btnSuaBD";
            // 
            // btnXoaBD
            // 
            this.btnXoaBD.Caption = "Xóa";
            this.btnXoaBD.Id = 2;
            this.btnXoaBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaBD.ImageOptions.Image")));
            this.btnXoaBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaBD.ImageOptions.LargeImage")));
            this.btnXoaBD.Name = "btnXoaBD";
            // 
            // btnGhiBD
            // 
            this.btnGhiBD.Caption = "Ghi";
            this.btnGhiBD.Id = 1;
            this.btnGhiBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiBD.ImageOptions.Image")));
            this.btnGhiBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhiBD.ImageOptions.LargeImage")));
            this.btnGhiBD.Name = "btnGhiBD";
            // 
            // btnPhucHoiBD
            // 
            this.btnPhucHoiBD.Caption = "Phục hồi";
            this.btnPhucHoiBD.Id = 4;
            this.btnPhucHoiBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiBD.ImageOptions.Image")));
            this.btnPhucHoiBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiBD.ImageOptions.LargeImage")));
            this.btnPhucHoiBD.Name = "btnPhucHoiBD";
            // 
            // btnTaiLaiBD
            // 
            this.btnTaiLaiBD.Caption = "Tham số theo thời gian";
            this.btnTaiLaiBD.Id = 5;
            this.btnTaiLaiBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLaiBD.ImageOptions.Image")));
            this.btnTaiLaiBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaiLaiBD.ImageOptions.LargeImage")));
            this.btnTaiLaiBD.Name = "btnTaiLaiBD";
            // 
            // btnThoatBD
            // 
            this.btnThoatBD.Caption = "Thoát";
            this.btnThoatBD.Id = 7;
            this.btnThoatBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatBD.ImageOptions.Image")));
            this.btnThoatBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoatBD.ImageOptions.LargeImage")));
            this.btnThoatBD.Name = "btnThoatBD";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(2257, 96);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1403);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(2257, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 96);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1307);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2257, 96);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1307);
            // 
            // btnInDSBD
            // 
            this.btnInDSBD.Caption = "In danh sách";
            this.btnInDSBD.Id = 6;
            this.btnInDSBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInDSBD.ImageOptions.Image")));
            this.btnInDSBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInDSBD.ImageOptions.LargeImage")));
            this.btnInDSBD.Name = "btnInDSBD";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Tạo device sao lưu";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2257, 1403);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormMain";
            this.Text = "FormMain1";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThemBD;
        private DevExpress.XtraBars.BarButtonItem btnSuaBD;
        private DevExpress.XtraBars.BarButtonItem btnXoaBD;
        private DevExpress.XtraBars.BarButtonItem btnGhiBD;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiBD;
        private DevExpress.XtraBars.BarButtonItem btnTaiLaiBD;
        private DevExpress.XtraBars.BarButtonItem btnThoatBD;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnInDSBD;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}
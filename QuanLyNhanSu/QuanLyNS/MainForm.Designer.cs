namespace QuanLyNS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDanToc = new DevExpress.XtraBars.BarButtonItem();
            this.btnTonGiao = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrinhDo = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhongBan = new DevExpress.XtraBars.BarButtonItem();
            this.btnHopDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnKTKL = new DevExpress.XtraBars.BarButtonItem();
            this.btnDieuChuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoiViec = new DevExpress.XtraBars.BarButtonItem();
            this.btnTangCa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhuCap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTang_ca = new DevExpress.XtraBars.BarButtonItem();
            this.btnUngLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMk = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPhucHoiDB = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnCongTy = new DevExpress.XtraBars.BarButtonItem();
            this.btnBoPhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnChucVu = new DevExpress.XtraBars.BarButtonItem();
            this.HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.NhanSu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ChamCong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BieuMau = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(34, 30, 34, 30);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnDanToc,
            this.btnTonGiao,
            this.btnTrinhDo,
            this.btnNhanVien,
            this.barButtonItem5,
            this.barButtonItem6,
            this.btnPhongBan,
            this.btnHopDong,
            this.btnKTKL,
            this.btnDieuChuyen,
            this.btnThoiViec,
            this.btnTangCa,
            this.btnLoaiCong,
            this.btnPhuCap,
            this.btnTang_ca,
            this.btnUngLuong,
            this.btnBangCong,
            this.btnBangLuong,
            this.btnDoiMk,
            this.btnSaoLuu,
            this.BtnPhucHoiDB,
            this.btnThoat,
            this.btnCongTy,
            this.btnBoPhan,
            this.btnChucVu});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 26;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 377;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HeThong,
            this.NhanSu,
            this.ChamCong,
            this.BieuMau});
            this.ribbon.Size = new System.Drawing.Size(1177, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnDanToc
            // 
            this.btnDanToc.Caption = "Dân tộc";
            this.btnDanToc.Id = 1;
            this.btnDanToc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDanToc.ImageOptions.LargeImage")));
            this.btnDanToc.Name = "btnDanToc";
            this.btnDanToc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDanToc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanToc_ItemClick);
            // 
            // btnTonGiao
            // 
            this.btnTonGiao.Caption = "Tôn giáo";
            this.btnTonGiao.Id = 2;
            this.btnTonGiao.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTonGiao.ImageOptions.LargeImage")));
            this.btnTonGiao.Name = "btnTonGiao";
            this.btnTonGiao.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTonGiao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTonGiao_ItemClick);
            // 
            // btnTrinhDo
            // 
            this.btnTrinhDo.Caption = "Trình độ";
            this.btnTrinhDo.Id = 3;
            this.btnTrinhDo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTrinhDo.ImageOptions.LargeImage")));
            this.btnTrinhDo.Name = "btnTrinhDo";
            this.btnTrinhDo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTrinhDo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrinhDo_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.Id = 4;
            this.btnNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.LargeImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Caption = "Phòng ban";
            this.btnPhongBan.Id = 7;
            this.btnPhongBan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhongBan.ImageOptions.LargeImage")));
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhongBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhongBan_ItemClick);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Caption = "Hợp đồng";
            this.btnHopDong.Id = 8;
            this.btnHopDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHopDong.ImageOptions.LargeImage")));
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnKTKL
            // 
            this.btnKTKL.Caption = "Khen thưởng - kỉ luật";
            this.btnKTKL.Id = 9;
            this.btnKTKL.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKTKL.ImageOptions.LargeImage")));
            this.btnKTKL.Name = "btnKTKL";
            this.btnKTKL.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnDieuChuyen
            // 
            this.btnDieuChuyen.Caption = "Điều chuyển";
            this.btnDieuChuyen.Id = 10;
            this.btnDieuChuyen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDieuChuyen.ImageOptions.LargeImage")));
            this.btnDieuChuyen.Name = "btnDieuChuyen";
            this.btnDieuChuyen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnThoiViec
            // 
            this.btnThoiViec.Caption = "Thôi việc";
            this.btnThoiViec.Id = 11;
            this.btnThoiViec.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoiViec.ImageOptions.LargeImage")));
            this.btnThoiViec.Name = "btnThoiViec";
            this.btnThoiViec.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnTangCa
            // 
            this.btnTangCa.Caption = "Tăng ca";
            this.btnTangCa.Id = 12;
            this.btnTangCa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTangCa.ImageOptions.LargeImage")));
            this.btnTangCa.Name = "btnTangCa";
            this.btnTangCa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnLoaiCong
            // 
            this.btnLoaiCong.Caption = "Loại công";
            this.btnLoaiCong.Id = 13;
            this.btnLoaiCong.Name = "btnLoaiCong";
            this.btnLoaiCong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnPhuCap
            // 
            this.btnPhuCap.Caption = "Phụ cấp";
            this.btnPhuCap.Id = 14;
            this.btnPhuCap.Name = "btnPhuCap";
            this.btnPhuCap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnTang_ca
            // 
            this.btnTang_ca.Caption = "Loại ca";
            this.btnTang_ca.Id = 15;
            this.btnTang_ca.Name = "btnTang_ca";
            this.btnTang_ca.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnUngLuong
            // 
            this.btnUngLuong.Caption = "Ứng lương";
            this.btnUngLuong.Id = 16;
            this.btnUngLuong.Name = "btnUngLuong";
            this.btnUngLuong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnBangCong
            // 
            this.btnBangCong.Caption = "Bảng công";
            this.btnBangCong.Id = 17;
            this.btnBangCong.Name = "btnBangCong";
            this.btnBangCong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnBangLuong
            // 
            this.btnBangLuong.Caption = "Bảng lương";
            this.btnBangLuong.Id = 18;
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnDoiMk
            // 
            this.btnDoiMk.Caption = "Đổi mật khẩu";
            this.btnDoiMk.Id = 19;
            this.btnDoiMk.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMk.ImageOptions.LargeImage")));
            this.btnDoiMk.Name = "btnDoiMk";
            this.btnDoiMk.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Caption = "Sao lưu dữ liệu";
            this.btnSaoLuu.Id = 20;
            this.btnSaoLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.LargeImage")));
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // BtnPhucHoiDB
            // 
            this.BtnPhucHoiDB.Caption = "Khôi phục dữ liệu";
            this.BtnPhucHoiDB.Id = 21;
            this.BtnPhucHoiDB.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPhucHoiDB.ImageOptions.LargeImage")));
            this.BtnPhucHoiDB.Name = "BtnPhucHoiDB";
            this.BtnPhucHoiDB.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 22;
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnCongTy
            // 
            this.btnCongTy.Caption = "Công ty";
            this.btnCongTy.Id = 23;
            this.btnCongTy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCongTy.ImageOptions.LargeImage")));
            this.btnCongTy.Name = "btnCongTy";
            this.btnCongTy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCongTy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCongTy_ItemClick);
            // 
            // btnBoPhan
            // 
            this.btnBoPhan.Caption = "Bộ phận";
            this.btnBoPhan.Id = 24;
            this.btnBoPhan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBoPhan.ImageOptions.LargeImage")));
            this.btnBoPhan.Name = "btnBoPhan";
            this.btnBoPhan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBoPhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBoPhan_ItemClick);
            // 
            // btnChucVu
            // 
            this.btnChucVu.Caption = "Chức vụ";
            this.btnChucVu.Id = 25;
            this.btnChucVu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChucVu.ImageOptions.LargeImage")));
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChucVu_ItemClick);
            // 
            // HeThong
            // 
            this.HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.HeThong.Name = "HeThong";
            this.HeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoiMk);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSaoLuu);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnPhucHoiDB);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // NhanSu
            // 
            this.NhanSu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup5});
            this.NhanSu.Name = "NhanSu";
            this.NhanSu.Text = "Nhân sự";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDanToc);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTonGiao);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTrinhDo);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPhongBan);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCongTy);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBoPhan);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnChucVu);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh mục  dùng chung";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnHopDong);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnKTKL);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDieuChuyen);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnThoiViec);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Nghiệp vụ";
            // 
            // ChamCong
            // 
            this.ChamCong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ChamCong.Name = "ChamCong";
            this.ChamCong.Text = "Chấm công";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTangCa);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLoaiCong);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPhuCap);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTang_ca);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnUngLuong);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBangCong);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBangLuong);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lý công";
            // 
            // BieuMau
            // 
            this.BieuMau.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.BieuMau.Name = "BieuMau";
            this.BieuMau.Text = "Biểu Mẫu";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 446);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1177, 30);
            // 
            // MainForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 476);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Phần mềm quản lý nhân sự";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage NhanSu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ChamCong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage BieuMau;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnDanToc;
        private DevExpress.XtraBars.BarButtonItem btnTonGiao;
        private DevExpress.XtraBars.BarButtonItem btnTrinhDo;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnPhongBan;
        private DevExpress.XtraBars.BarButtonItem btnHopDong;
        private DevExpress.XtraBars.BarButtonItem btnKTKL;
        private DevExpress.XtraBars.BarButtonItem btnDieuChuyen;
        private DevExpress.XtraBars.BarButtonItem btnThoiViec;
        private DevExpress.XtraBars.BarButtonItem btnTangCa;
        private DevExpress.XtraBars.BarButtonItem btnLoaiCong;
        private DevExpress.XtraBars.BarButtonItem btnPhuCap;
        private DevExpress.XtraBars.BarButtonItem btnTang_ca;
        private DevExpress.XtraBars.BarButtonItem btnUngLuong;
        private DevExpress.XtraBars.BarButtonItem btnBangCong;
        private DevExpress.XtraBars.BarButtonItem btnBangLuong;
        private DevExpress.XtraBars.BarButtonItem btnDoiMk;
        private DevExpress.XtraBars.BarButtonItem btnSaoLuu;
        private DevExpress.XtraBars.BarButtonItem BtnPhucHoiDB;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnCongTy;
        private DevExpress.XtraBars.BarButtonItem btnBoPhan;
        private DevExpress.XtraBars.BarButtonItem btnChucVu;
    }
}
using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyNS
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        NHANVIEN _NHANVIEN;
        PHONGBAN _phongban;
        BOPHAN _bophan;
        DANTOC _dantoc;
        TONGIAO _tongiao;
        TRINHDO _trinhdo;
        CHUCVU _chucvu;
        bool _them;
        int _id;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnDong.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnIn.Enabled = kt;
            txtFullName.Enabled = !kt;
            txtCCCD.Enabled = !kt;
            txtFullName.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            txtDienThoai.Enabled = !kt;
            cbGT.Enabled = !kt;
            frmHinhAnh.Enabled = !kt;
            cbBoPhan.Enabled = !kt;
            cbPhongBan.Enabled = !kt;
            cbTrinhDo.Enabled = !kt;
            cbDanToc.Enabled = !kt;
            cbTonGiao.Enabled = !kt;
            cbChucVu.Enabled = !kt;
            btnHinhAnh.Enabled = !kt;
            dtNgaySinh.Enabled = !kt;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reset();
            _them = true;
            _showHide(false);
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá nhân viên này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                _NHANVIEN.Delete(_id);
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            LoadData();
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(true);
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmNHANVIEN_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            LoadData();
            LoadCombo();
        }

        void LoadCombo()
        {
            cbBoPhan.DataSource = _bophan.getList();
            cbBoPhan.DisplayMember = "TENBP";
            cbBoPhan.ValueMember = "IDBP";

            cbPhongBan.DataSource = _phongban.getList();
            cbPhongBan.DisplayMember = "TENPB";
            cbPhongBan.ValueMember = "IDPB";

            cbChucVu.DataSource = _chucvu.getList();
            cbChucVu.DisplayMember = "TENCV";
            cbChucVu.ValueMember = "IDCV";

            cbDanToc.DataSource = _dantoc.getList();
            cbDanToc.DisplayMember = "TENDT";
            cbDanToc.ValueMember = "IDDT";

            cbTonGiao.DataSource = _tongiao.getList();
            cbTonGiao.DisplayMember = "TENTG";
            cbTonGiao.ValueMember = "IDTG";

            cbTrinhDo.DataSource = _trinhdo.getList();
            cbTrinhDo.DisplayMember = "TENTD";
            cbTrinhDo.ValueMember = "IDTD";
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _NHANVIEN.getFullList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void SaveData()
        {
            if (_them)
            {
                tb_NHANVIEN dt = new tb_NHANVIEN();
                dt.HOTEN = txtFullName.Text;
                dt.NGAYSINH = dtNgaySinh.Value;
                dt.GIOITINH = cbGT.Checked;
                dt.CCCD = txtCCCD.Text;
                dt.DIENTHOAI = txtDienThoai.Text;
                dt.DIACHI = txtDiaChi.Text;
                dt.HINHANH = ImageToBase64(frmHinhAnh.Image, frmHinhAnh.Image.RawFormat);
                dt.IDBP = int.Parse(cbBoPhan.SelectedValue.ToString());
                dt.IDCT = 0; 
                dt.IDPB = int.Parse(cbPhongBan.SelectedValue.ToString());
                dt.IDCV = int.Parse(cbChucVu.SelectedValue.ToString());
                dt.IDDT = int.Parse(cbDanToc.SelectedValue.ToString());
                dt.IDTG = int.Parse(cbTonGiao.SelectedValue.ToString());
                dt.IDTD = int.Parse(cbTrinhDo.SelectedValue.ToString());
                _NHANVIEN.Add(dt);
            }
            else
            {
                var dt = _NHANVIEN.getItem(_id);
                dt.HOTEN = txtFullName.Text;
                dt.GIOITINH = cbGT.Checked;
                dt.NGAYSINH = dtNgaySinh.Value;
                dt.CCCD = txtCCCD.Text;
                dt.DIENTHOAI = txtDienThoai.Text;
                dt.DIACHI = txtDiaChi.Text;
                dt.HINHANH = ImageToBase64(frmHinhAnh.Image, frmHinhAnh.Image.RawFormat);
                dt.IDBP = int.Parse(cbBoPhan.SelectedValue.ToString());
                dt.IDCT = 0;
                dt.IDPB = int.Parse(cbPhongBan.SelectedValue.ToString());
                dt.IDCV = int.Parse(cbChucVu.SelectedValue.ToString());
                dt.IDDT = int.Parse(cbDanToc.SelectedValue.ToString());
                dt.IDTG = int.Parse(cbTonGiao.SelectedValue.ToString());
                dt.IDTD = int.Parse(cbTrinhDo.SelectedValue.ToString());
                _NHANVIEN.Edit(dt);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
           if(gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MANV").ToString());
                var nv = _NHANVIEN.getItem(_id);
                txtFullName.Text = nv.HOTEN;
                cbGT.Checked = nv.GIOITINH;
                dtNgaySinh.Value = nv.NGAYSINH;
                txtDienThoai.Text = nv.DIENTHOAI;
                txtDiaChi.Text = nv.DIACHI;
                txtCCCD.Text = nv.CCCD;
                frmHinhAnh.Image = Base64ToImage(nv.HINHANH);
                cbBoPhan.SelectedValue = nv.IDBP;
                cbPhongBan.SelectedValue = nv.IDBP;
                cbTrinhDo.SelectedValue = nv.IDTD;
                cbDanToc.SelectedValue = nv.IDDT;
                cbTonGiao.SelectedValue = nv.IDTG;
                cbChucVu.SelectedValue = nv.IDCV;
                //nv.IDCT = 0;
            }
        }

        void reset()
        {
            txtCCCD.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            cbGT.Checked = false;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            _them = false;
            _NHANVIEN = new NHANVIEN();
            _bophan = new BOPHAN();
            _chucvu = new CHUCVU();
            _tongiao = new TONGIAO();
            _dantoc = new DANTOC();
            _trinhdo = new TRINHDO();
            _phongban = new PHONGBAN();
            _showHide(true);
            LoadData();
            splitContainer1.Panel1Collapsed = true;
            LoadCombo();
        }

        public byte[] ImageToBase64(Image image , System.Drawing.Imaging.ImageFormat format)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] img = ms.ToArray();

                return img;
            }
        }

        public Image Base64ToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data , 0 , data.Length);
            ms.Write(data, 0, data.Length);
            Image img = Image.FromStream(ms , true);
            return img;
        }

        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Picture file(.png , .jgp)| *.png; *.jgp";  
            ofd.Title = "Chọn hình ảnh";  
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                frmHinhAnh.Image = Image.FromFile(ofd.FileName);
                frmHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
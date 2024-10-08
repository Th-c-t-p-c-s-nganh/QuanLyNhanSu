using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNS
{
    public partial class frmCongTy : DevExpress.XtraEditors.XtraForm
    {
        CONGTY _CONGTY;
        bool _them;
        int _id;
        public frmCongTy()
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
            txtCongTy.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            txtDienThoai.Enabled = !kt;
            txtEmail.Enabled = !kt;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtCongTy.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            _them = true;
            _showHide(false);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá công ty này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                _CONGTY.Delete(_id);
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            LoadData();
            _them = false;
            _showHide(true);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(true);
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmCongTy_Load(object sender, EventArgs e)
        {
            _them = false;
            _CONGTY = new CONGTY();
            _showHide(true);
            LoadData();
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _CONGTY.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void SaveData()
        {
            if (_them)
            {
                tb_CONGTY dt = new tb_CONGTY();
                dt.TENCTY = txtCongTy.Text;
                dt.DIACHI = txtDiaChi.Text;
                dt.DIENTHOAI = txtDienThoai.Text;
                dt.EMAIL = txtEmail.Text;
                _CONGTY.Add(dt);
            }
            else
            {
                var dt = _CONGTY.getItem(_id);
                dt.TENCTY = txtCongTy.Text;
                dt.DIACHI = txtDiaChi.Text;
                dt.DIENTHOAI = txtDienThoai.Text;
                dt.EMAIL = txtEmail.Text;
                _CONGTY.Edit(dt);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDCT").ToString());
            txtCongTy.Text = gvDanhSach.GetFocusedRowCellValue("TENCTY").ToString();
            txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
            txtDienThoai.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
            txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
        }
    }
}
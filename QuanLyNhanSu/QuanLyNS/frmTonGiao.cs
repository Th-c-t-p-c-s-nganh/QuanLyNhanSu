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
    public partial class frmTonGiao : DevExpress.XtraEditors.XtraForm
    {
        TONGIAO _TONGIAO;
        bool _them;
        int _id;
        public frmTonGiao()
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
            txtName.Enabled = !kt;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtName.Text = string.Empty;
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
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá dân tộc này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                _TONGIAO.Delete(_id);
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

        private void frmTONGIAO_Load(object sender, EventArgs e)
        {
            _them = false;
            _TONGIAO = new TONGIAO();
            _showHide(true);
            LoadData();
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _TONGIAO.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void SaveData()
        {
            if (_them)
            {
                tb_TONGIAO dt = new tb_TONGIAO();
                dt.TENTG = txtName.Text;
                _TONGIAO.Add(dt);
            }
            else
            {
                var dt = _TONGIAO.getItem(_id);
                dt.TENTG = txtName.Text;
                _TONGIAO.Edit(dt);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDTG").ToString());
            txtName.Text = gvDanhSach.GetFocusedRowCellValue("TENTG").ToString();
        }

        private void frmTonGiao_Load_1(object sender, EventArgs e)
        {
            _them = false;
            _TONGIAO = new TONGIAO();
            _showHide(true);
            LoadData();
        }
    }
}
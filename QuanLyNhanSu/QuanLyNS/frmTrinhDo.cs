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
using System.Xml.Linq;

namespace QuanLyNS
{
    public partial class frmTrinhDo : DevExpress.XtraEditors.XtraForm
    {
        TRINHDO _TRINHDO;
        bool _them;
        int _id;
        public frmTrinhDo()
        {
            InitializeComponent();
        }
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            bntHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnDong.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnIn.Enabled = kt;
            txtTD.Enabled = !kt;
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTD.Text = string.Empty;
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
                _TRINHDO.Delete(_id);
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

        private void bntHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void frmTrinhDo_Load(object sender, EventArgs e)
        {
            _them = false;
            _TRINHDO = new TRINHDO();
            _showHide(true);
            LoadData();
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _TRINHDO.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void SaveData()
        {
            if (_them)
            {
                tb_TRINHDO dt = new tb_TRINHDO();
                dt.TENTD = txtTD.Text;
                _TRINHDO.Add(dt);
            }
            else
            {
                var dt = _TRINHDO.getItem(_id);
                dt.TENTD = txtTD.Text;
                _TRINHDO.Edit(dt);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDTD").ToString());
            txtTD.Text = gvDanhSach.GetFocusedRowCellValue("TENTD").ToString();
        }
    }
}
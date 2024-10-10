using DevExpress.XtraBars;
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
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        void loadForm(Type typeForm)
        {
            foreach (var frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            //f.MdiParent = this;
            f.Show();
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void btnDanToc_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadForm(typeof(frmDanToc));
        }


        private void btnTonGiao_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadForm(typeof(frmTonGiao));
        }

        private void btnTrinhDo_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadForm(typeof(frmTrinhDo));
        }

        private void btnPhongBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadForm(typeof(frmPhongBan));
        }

        private void btnCongTy_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadForm(typeof(frmCongTy));
        }

        private void btnBoPhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadForm(typeof(frmBoPhan));
        }

        private void btnChucVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadForm(typeof(frmChucVu));
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadForm(typeof(frmNhanVien));
        }
    }
}   
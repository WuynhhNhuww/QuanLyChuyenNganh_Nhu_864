using OpenLibrary.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        CtrTrangchu ctr = new CtrTrangchu();
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (LoginInfo.MaNV == -1)
            {
                frmDangnhap f = new frmDangnhap();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            else
            {
                ctr.logout();
                xuLyLogin();
            }
        }
        public void xuLyLogin()
        {
            this.Text = (LoginInfo.HoTenNV != "") ? "OpenLibrary" : "Open Library – Xin Chao " + LoginInfo.HoTenNV;
            barButtonItem1.Caption = LoginInfo.MaNV == -1 ? "DangNhap" : "DangXuat";
            barButtonItem1.ImageOptions.LargeImage = (LoginInfo.MaNV != -1) ? Properties.Resources.prev_32x32 : Properties.Resources.next_32x32;
            barButtonItem2.Enabled = LoginInfo.MaNV == 1;
            barButtonItem3.Enabled = LoginInfo.MaNV == 1;
            rpgQLTN.Visible = LoginInfo.MaLoaiNV == 1;
            rpgPQHT.Visible = LoginInfo.MaLoaiNV == 1;
            rpgQLMTS.Visible = LoginInfo.MaLoaiNV == 1;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChuyenNganh f = (frmChuyenNganh)this.MdiChildren.FirstOrDefault(k => k is frmChuyenNganh);
            if (f == null)
            {
                f = new frmChuyenNganh();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xuLyLogin();
        }
    }
}

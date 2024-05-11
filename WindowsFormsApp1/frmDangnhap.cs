using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OpenLibrary.Bussiness.CtrLogin;

namespace WindowsFormsApp1
{
    public partial class frmDangnhap : Form
    {
        CtrDangNhap ctrDangNhap = new CtrDangNhap();
        public frmDangnhap()
        {
            InitializeComponent();
        }
        private bool validateData()
        {
            errorProvider1.SetError(txtUsername, (txtUsername.Text == "") ? "Please enter username  " : "");
            errorProvider2.SetError(txtMK, (txtMK.Text == "") ? "Please enter Password  " : "");
            return (txtUsername.Text != "" && txtMK.Text != "");
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!validateData())
                return;
            bool isAutherticated = ctrDangNhap.login(txtUsername.Text, txtMK.Text);
            if (isAutherticated)
            {
                var f = (frmMain)this.ParentForm;
                f.xuLyLogin();
                this.Close();
            }

            else
                MessageBox.Show("Wrong username and password", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}

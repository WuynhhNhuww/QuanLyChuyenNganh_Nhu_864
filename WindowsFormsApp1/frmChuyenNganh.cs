using OpenLibrary.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmChuyenNganh : Form
    {
        CtrChuyenNganh Ctr = new CtrChuyenNganh();
        public frmChuyenNganh()
        {
            InitializeComponent();
        }

        private void frmChuyenNganh_Load(object sender, EventArgs e)
        {
            dgvCN.DataSource = Ctr.laydschuyennganh();
            this.cHUYENNGANHTableAdapter.Fill(this.oPENLIBRARYDataSet.CHUYENNGANH);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String s = dgvCN.CurrentRow.Cells[0].Value.ToString();
            if (s != null && s != "")
            {
                txtChuyenNganh.Text = s;
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi có mã là " + s + " hay không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (txtChuyenNganh.Text == "") errorProvider1.SetError(txtChuyenNganh, "Hãy nhập tên chuyên ngành ");
                    else
                    {
                        if (!Ctr.XoaChuyenNganh(txtChuyenNganh.Text = dgvCN.CurrentRow.Cells[0].Value.ToString())) MessageBox.Show("Xóa thất bại!");

                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtChuyenNganh.Text == "")
                errorProvider1.SetError(txtChuyenNganh, "Hãy nhập tên chuyên ngành ");
            else
            {
                if (Ctr.ThemtenchuyenNganh(txtChuyenNganh.Text) == false)
                    MessageBox.Show("Thêm thất bại");

            }
        }

        private void dgvCN_SelectionChanged(object sender, EventArgs e)
        {
            String s = dgvCN.CurrentRow.Cells[1].Value.ToString();
            if (s != null && s != "") txtChuyenNganh.Text = s;
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            if (txtChuyenNganh.Text == "")
                errorProvider1.SetError(txtChuyenNganh, "Hãy nhập tên cần sửa chuyên ngành!");
            else
            {
                String s = dgvCN.CurrentRow.Cells[0].Value.ToString();
                if (Ctr.SuachuyenNganh(txtChuyenNganh.Text, s) == false)
                    MessageBox.Show("Sửa thất bại");

            }
        }
    }
}

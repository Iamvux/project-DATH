using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanquanliXe
{
    public partial class FDangNhap : Form
    {
        string tentaikhoan = "admin";
        string matkhau = "admin";
        public FDangNhap()
        {
            InitializeComponent();

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (kiemtraDN(txtTK.Text, txtMK.Text))
            {
                this.Hide();
                FMenu mn = new FMenu();
                mn.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu !!!");
                txtTK.Focus();
            }
        }
        bool kiemtraDN(string tentaikhoan, string matkhau)
        {
            if (tentaikhoan == this.tentaikhoan && matkhau == this.matkhau)
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

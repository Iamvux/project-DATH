using DoanquanliXe.DAO;
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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenchildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTTNCC_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FThongTinNCC());
            label1.Text = btnTTNCC.Text;
        }

        private void btnXe_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FThongTinXe());
            label1.Text = btnXe.Text;
        }

      

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label1.Text = "TRANG CHỦ";
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn ĐỌC dữ liệu không?", "Đọc file", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (TruyCapThongTin.docFile("danhsach.out"))
                    MessageBox.Show("Đọc dữ liệu thành công!");
                else
                    MessageBox.Show("Đọc dữ liệu thất bại!");
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn ghi dữ liệu không?", "Ghi file", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (TruyCapThongTin.ghiFile("danhsach.out"))
                    MessageBox.Show("Ghi dữ liệu thành công!");
                else
                    MessageBox.Show("Ghi dữ liệu thất bại!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

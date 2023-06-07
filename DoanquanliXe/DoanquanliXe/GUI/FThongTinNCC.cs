using DoanquanliXe.BUS;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanquanliXe
{
    public partial class FThongTinNCC : Form
    {
        private thonngtinNccBUS nccbus;
        public FThongTinNCC()
        {
            InitializeComponent();
            nccbus = new thonngtinNccBUS();
        }
        private void Clear()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";           
            dgvTTNCC.ClearSelection();
        }
        private void HienThiDSNCC(List<CThongtinNCC> dsncc)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsncc;
            dgvTTNCC.DataSource = bs;
            Clear();

        }
        private CThongtinNCC taoNhaCungCap()
        {
            return new CThongtinNCC(txtMaNCC.Text, txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text);
        }
        private void FThongTinNCC_Load(object sender, EventArgs e)
        {
            HienThiDSNCC(nccbus.DsNhaCungCap);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (nccbus.tim(txtMaNCC.Text) != null)
            {
                MessageBox.Show("Mã đã tồn tại");
                txtMaNCC.Focus();
            }
            else if (check() == true)
            {
                nccbus.them(taoNhaCungCap());
                HienThiDSNCC(nccbus.DsNhaCungCap);
            }
        }
        private int getRow()
        {
            if (dgvTTNCC.SelectedRows.Count > 0)
                return dgvTTNCC.SelectedRows[0].Index;
            return -1;
        }

        private void dgvTTNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTTNCC.CurrentRow.Selected = true;
            txtMaNCC.Text = dgvTTNCC.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenNCC.Text = dgvTTNCC.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSDT.Text = dgvTTNCC.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvTTNCC.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        public bool check()
        {
            if (string.IsNullOrWhiteSpace(txtMaNCC.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhà cung cấp ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNCC.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenNCC.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNCC.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại nhà cung cấp ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return false;
            }
            if (txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải gồm 10 số và không có chữ");
                txtSDT.Focus();
                return false;
            }
            if (txtSDT.Text != "")
            {
                try
                {
                    double a = double.Parse(txtSDT.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Không đc nhập chữ ");
                    txtSDT.Text = "";
                    txtSDT.Focus();
                    return false;
                }
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ nhà cung cấp ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return false;
            }
            return true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            int x = getRow();
            if (x == -1)
                return;
            else
            {
                nccbus.xoa(dgvTTNCC.Rows[x].Cells[0].Value.ToString());
                HienThiDSNCC(nccbus.DsNhaCungCap);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int x = getRow();
            if (x == -1)
                return;
            else
            {
                CThongtinNCC ncc = taoNhaCungCap();
                string mancc = dgvTTNCC.Rows[x].Cells[0].Value.ToString();
                ncc.MaNhaCungCap = mancc;
                nccbus.sua(ncc);
                HienThiDSNCC(nccbus.DsNhaCungCap);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            List<CThongtinNCC> tmp = new List<CThongtinNCC>();
            string value = txtTimKiem.Text;
            if (cbbTimKiem.Text == "Mã")
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    for (int i = 0; i < nccbus.DsNhaCungCap.Count; i++)
                    {


                        if (nccbus.DsNhaCungCap[i].MaNhaCungCap.Contains(value) == true)
                        {
                            tmp.Add(nccbus.DsNhaCungCap[i]);
                            HienThiDSNCC(tmp);
                        }
                        else
                        {
                            HienThiDSNCC(tmp);
                        }
                    }
                }
            }
            else if (cbbTimKiem.Text == "Tên")
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    for (int i = 0; i < nccbus.DsNhaCungCap.Count; i++)
                    {


                        if (nccbus.DsNhaCungCap[i].TenNhaCungCap.Contains(value) == true)
                        {
                            tmp.Add(nccbus.DsNhaCungCap[i]);
                            HienThiDSNCC(tmp);
                        }
                        else
                        {
                            HienThiDSNCC(tmp);
                        }
                    }
                }
            }
            else if (cbbTimKiem.Text == "SĐT")
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    for (int i = 0; i < nccbus.DsNhaCungCap.Count; i++)
                    {


                        if (nccbus.DsNhaCungCap[i].SoDienThoai.Contains(value) == true)
                        {
                            tmp.Add(nccbus.DsNhaCungCap[i]);
                            HienThiDSNCC(tmp);
                        }
                        else
                        {
                            HienThiDSNCC(tmp);
                        }
                    }
                }
            }
            else if (cbbTimKiem.Text == "Địa Chỉ")
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    for (int i = 0; i < nccbus.DsNhaCungCap.Count; i++)
                    {


                        if (nccbus.DsNhaCungCap[i].DiaChi.Contains(value) == true)
                        {
                            tmp.Add(nccbus.DsNhaCungCap[i]);
                            HienThiDSNCC(tmp);
                        }
                        else
                        {
                            HienThiDSNCC(tmp);
                        }
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HienThiDSNCC(nccbus.DsNhaCungCap);
        }

        private void cbbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTBao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Số lượg nhà cung cấp là:" + nccbus.soLuongNCC());

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTang.Checked == true)
            {
                if (comboBox1.Text == "Mã")
                {
                    nccbus.sapXepTangDanTheoMa(nccbus.DsNhaCungCap);
                    HienThiDSNCC(nccbus.DsNhaCungCap);
                }
                else if (comboBox1.Text == "Tên")
                {
                    nccbus.sapXepTangDanTheoTen(nccbus.DsNhaCungCap);
                    HienThiDSNCC(nccbus.DsNhaCungCap);
                }
                

            }
            else if (radGiam.Checked == true)
            {
                if (comboBox1.Text == "Mã")
                {
                    nccbus.sapXepGiamDanTheoMa(nccbus.DsNhaCungCap);
                    HienThiDSNCC(nccbus.DsNhaCungCap);
                }
                else if (comboBox1.Text == "Tên")
                {
                    nccbus.sapXepTangDanTheoTen(nccbus.DsNhaCungCap);
                    HienThiDSNCC(nccbus.DsNhaCungCap);
                }
                

            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}

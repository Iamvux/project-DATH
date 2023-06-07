using DoanquanliXe.BUS;
using DoanquanliXe.DTO;
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
    public partial class FThongTinXe : Form
    {
        private thongtinxeBUS xebus;
        public FThongTinXe()
        {
            InitializeComponent();
            xebus = new thongtinxeBUS();
        }
        private void HienThiXe(List<CThongTinXe> dsxe)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsxe;
            dgvTTX.DataSource = bs;
            dgvTTX.ClearSelection();
        }
        private void HienThiNhaCungCap(List<CThongtinNCC> dsncc)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsncc;
            cbbNCC.DataSource = bs;
        }
        public int getRow()
        {
            if (dgvTTX.SelectedRows.Count > 0)
                return dgvTTX.SelectedRows[0].Index;
            return -1;
        }
        private void dgvTTX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTTX.CurrentRow.Selected = true;
            txtMa.Text = dgvTTX.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTen.Text = dgvTTX.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLoai.Text = dgvTTX.Rows[e.RowIndex].Cells[2].Value.ToString();           
            txtGia.Text = dgvTTX.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbbNCC.Text =dgvTTX.Rows[e.RowIndex].Cells[4].Value.ToString();

        }
        private CThongTinXe taoXe()
        {
            return new CThongTinXe(txtMa.Text, txtTen.Text, txtLoai.Text, double.Parse(txtGia.Text), xebus.DsNhaCungCap[cbbNCC.SelectedIndex]);

        }
        public void Clear()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtLoai.Text = "";          
            txtGia.Text = "";
            cbbNCC.SelectedIndex = 0;
        }
        public bool check()
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã xe ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên xe ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLoai.Text))
            {
                MessageBox.Show("Bạn chưa nhập loai xe", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtLoai.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGia.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá xe ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGia.Focus();
                return false;
            }
            if (txtGia.Text != "")
            {
                try
                {
                    double a = double.Parse(txtGia.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Không đc nhập chữ vào giá");
                    txtGia.Text = "";
                    txtGia.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xebus.them(taoXe());
            HienThiXe(xebus.DsXe);
            //{
            //    if (xebus.tim(txtMa.Text) != null)
            //    {
            //        MessageBox.Show("Mã đã tồn tại");
            //        txtMa.Focus();
            //    }
            //    else if (check() == true)
            //    {
            //      xebus.them(taoXe());
            //       HienThiXe(xebus.DsXe);
            //    }
            //}
        }

        private void FThongTinXe_Load(object sender, EventArgs e)
        {
            HienThiNhaCungCap(xebus.DsNhaCungCap);
            HienThiXe(xebus.DsXe);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int x = getRow();
            if (x == -1)
                return;
            else
            {
                string maxe = dgvTTX.Rows[x].Cells[0].Value.ToString();
                xebus.xoa(maxe);
                HienThiXe(xebus.DsXe);
                Clear();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int x = getRow();
            if (x == -1)
                return;
            else
            {
                CThongTinXe xe = taoXe();
                string maxe = dgvTTX.Rows[x].Cells[0].Value.ToString();
                xe.MaXe = maxe;
                xebus.sua(xe);
                HienThiXe(xebus.DsXe);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            List<CThongTinXe> tmp = new List<CThongTinXe>();
            string value = txtTim.Text;
            if (cbbTim.Text == "Mã")
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    for (int i = 0; i < xebus.DsXe.Count; i++)
                    {
                        if (xebus.DsXe[i].MaXe.Contains(value) == true)
                        {
                            tmp.Add(xebus.DsXe[i]);
                            HienThiXe(tmp);
                        }
                        else
                        {
                            HienThiXe(tmp);
                        }
                    }
                }
            }
            else if (cbbTim.Text == "Tên")
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    for (int i = 0; i < xebus.DsXe.Count; i++)
                    {
                        if (xebus.DsXe[i].TenXe.Contains(value) == true)
                        {
                            tmp.Add(xebus.DsXe[i]);
                            HienThiXe(tmp);
                        }
                        else
                        {
                            HienThiXe(tmp);
                        }
                    }
                }
            }
            else if (cbbTim.Text == "Loại Xe")
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    for (int i = 0; i < xebus.DsXe.Count; i++)
                    {
                        if (xebus.DsXe[i].LoaiXe.Contains(value) == true)
                        {
                            tmp.Add(xebus.DsXe[i]);
                            HienThiXe(tmp);
                        }
                        else
                        {
                            HienThiXe(tmp);
                        }
                    }
                }
            }
            else if (cbbTim.Text == "Giá")
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    for (int i = 0; i < xebus.DsXe.Count; i++)
                    {

                        if (xebus.DsXe[i].DonGia.ToString().Contains(value) == true)
                        {
                            tmp.Add(xebus.DsXe[i]);
                            HienThiXe(tmp);
                        }
                        else
                        {
                            HienThiXe(tmp);
                        }
                    }
                }
            }

            else if (cbbTim.Text == "Nhà Cung Cấp")
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    for (int i = 0; i < xebus.DsXe.Count; i++)
                    {
                        if (xebus.DsXe[i].NhaCungCap.MaNhaCungCap.Contains(value) == true)
                        {
                            tmp.Add(xebus.DsXe[i]);
                            HienThiXe(tmp);
                        }
                        else
                        {
                            HienThiXe(tmp);
                        }
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HienThiXe(xebus.DsXe);
        }

        private void btnTBao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Số lượg xe là:" + xebus.soLuongxe());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                if (radTang.Checked == true)
                {
                    if (comboBox1.Text == "Mã")
                    {
                        xebus.sapXepTangDanTheoMa(xebus.DsXe);
                       HienThiXe(xebus.DsXe);
                    }
                    else if (comboBox1.Text == "Tên")
                    {
                        xebus.sapXepTangDanTheoTen(xebus.DsXe);
                        HienThiXe(xebus.DsXe);
                    }
                    else if (comboBox1.Text == "Giá")
                    {
                        xebus.sapXepTangDanTheoGia(xebus.DsXe);
                        HienThiXe(xebus.DsXe);
                    }

                }
                else if (radGiam.Checked == true)
                {
                    if (comboBox1.Text == "Mã")
                    {
                        xebus.sapXepGiamDanTheoMa(xebus.DsXe);
                        HienThiXe(xebus.DsXe);
                    }
                    else if (comboBox1.Text == "Tên")
                    {
                        xebus.sapXepGiamDanTheoTen(xebus.DsXe);
                        HienThiXe(xebus.DsXe);
                    }
                    else if (comboBox1.Text == "Giá")
                    {
                        xebus.sapXepGiamDanTheoGia(xebus.DsXe);
                        HienThiXe(xebus.DsXe);
                    }

                }
            
        }
    }
}

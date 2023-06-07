using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanquanliXe
{
    [Serializable]
    internal class CThongtinNCC
    {
        private string m_maNhaCungCap;
        private string m_tenNhaCungCap;
        private string m_soDienThoai;
        private string m_diaChi;

        public string MaNhaCungCap { get => m_maNhaCungCap; set => m_maNhaCungCap = value; }
        public string TenNhaCungCap { get => m_tenNhaCungCap; set => m_tenNhaCungCap = value; }
        public string SoDienThoai { get => m_soDienThoai; set => m_soDienThoai = value; }
        public string DiaChi { get => m_diaChi; set => m_diaChi = value; }

        public CThongtinNCC(string manhacungcap, string tennhacungcap, string sodienthoai, string diachi)
        {
            m_maNhaCungCap = manhacungcap;
            m_tenNhaCungCap = tennhacungcap;
            m_soDienThoai = sodienthoai;
            m_diaChi = diachi;
        }
        public CThongtinNCC() : this(null, null, null, null)
        {
        }

        public override string ToString()
        {
            return MaNhaCungCap;
        }
    }
}

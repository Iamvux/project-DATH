using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanquanliXe.DTO
{
    [Serializable]
    internal class CThongTinXe
    {
        private string m_maXe;
        private string m_tenXe;
        private string m_loaiXe;     
        private double m_donGia;
        private CThongtinNCC m_nhaCungCap;

        public string MaXe { get => m_maXe; set => m_maXe = value; }
        public string TenXe { get => m_tenXe; set => m_tenXe = value; }
        public string LoaiXe { get => m_loaiXe; set => m_loaiXe = value; }
       
        public CThongtinNCC NhaCungCap { get => m_nhaCungCap; set => m_nhaCungCap = value; }
        public double DonGia { get => m_donGia; set => m_donGia = value; }

        public CThongTinXe(string ma, string ten, string loai, double dongia, CThongtinNCC nhacungcap)
        {
            m_maXe = ma;
            m_tenXe = ten;
            m_loaiXe = loai;
            DonGia = dongia;
            m_nhaCungCap = nhacungcap;

        }
        public CThongTinXe() : this(null, null, null,0, null)
        {
        }
        public override string ToString()
        {
            return MaXe;
        }
    }
}

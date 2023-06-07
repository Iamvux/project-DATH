using DoanquanliXe.DAO;
using DoanquanliXe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DoanquanliXe.BUS
{
    internal class thongtinxeBUS
    {
        private List<CThongTinXe> dsXe;
        private List<CThongtinNCC> dsNhaCungCap;

        internal List<CThongTinXe> DsXe { get => dsXe; set => dsXe = value; }
        internal List<CThongtinNCC> DsNhaCungCap { get => dsNhaCungCap; set => dsNhaCungCap = value; }

        public thongtinxeBUS()
        {
            DsXe = TruyCapThongTin.KhoiTao().DsXe;
            DsNhaCungCap = TruyCapThongTin.KhoiTao().DsNhaCungCap;
        }
        public void them(CThongTinXe xe)
        {
            dsXe.Add(xe);
        }

        public CThongTinXe tim(string maxe)
        {
            foreach (CThongTinXe xe in DsXe)
                if (xe.MaXe.Equals(maxe))
                    return xe;
            return null;
        }
        public void xoa(string maxe)
        {
            CThongTinXe xe = tim(maxe);
            if (xe != null)
                DsXe.Remove(xe);
        }

        public void sua(CThongTinXe xe)
        {
            CThongTinXe ttXe = tim(xe.MaXe);
            if (ttXe != null)
            {
                ttXe.TenXe = xe.TenXe;
                ttXe.LoaiXe = xe.LoaiXe;
                ttXe.DonGia = xe.DonGia;
                ttXe.NhaCungCap = xe.NhaCungCap;
            }
        }
        public int soLuongxe()
        {
            return this.dsXe.Count;
        }
        public void sapXepTangDanTheoMa(List<CThongTinXe> dsxe)
        {
            dsxe.Sort((a, b) => a.MaXe.CompareTo(b.MaXe));
        }
        public void sapXepGiamDanTheoMa(List<CThongTinXe> dsxe)
        {
            dsxe.Sort((a, b) => b.MaXe.CompareTo(a.MaXe));
        }


        public void sapXepTangDanTheoTen(List<CThongTinXe> dsxe)
        {
            dsxe.Sort((a, b) => a.TenXe.CompareTo(b.TenXe));
        }
        public void sapXepGiamDanTheoTen(List<CThongTinXe> dsxe)
        {
            dsxe.Sort((a, b) => b.TenXe.CompareTo(a.TenXe));
        }

        public void sapXepTangDanTheoGia(List<CThongTinXe> dsxe)
        {
            dsxe.Sort((a, b) => a.DonGia.CompareTo(b.DonGia));
        }
        public void sapXepGiamDanTheoGia(List<CThongTinXe> dsxe)
        {
            dsxe.Sort((a, b) => b.DonGia.CompareTo(a.DonGia));
        }
    }
}

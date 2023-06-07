using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoanquanliXe.DAO;


namespace DoanquanliXe.BUS
{
    internal class thonngtinNccBUS
      
    {
        private List<CThongtinNCC> dsNhaCungCap;


        public thonngtinNccBUS()
        {
           dsNhaCungCap = TruyCapThongTin.KhoiTao().DsNhaCungCap;
        }
        internal List<CThongtinNCC> DsNhaCungCap { get => dsNhaCungCap; set => dsNhaCungCap = value; }

        public void them(CThongtinNCC nhacungcap)
        {
            DsNhaCungCap.Add(nhacungcap);
        }

        public CThongtinNCC tim(string manhacungcap)
        {
            foreach (CThongtinNCC nhacungcap in DsNhaCungCap)
                if (nhacungcap.MaNhaCungCap.Equals(manhacungcap))
                    return nhacungcap;
            return null;
        }

        public void xoa(string manhacungcap)
        {
          CThongtinNCC nhacungcap = tim(manhacungcap);
            if (nhacungcap != null)
                DsNhaCungCap.Remove(nhacungcap);
        }

        public void sua(CThongtinNCC nhacungcap)
        {
           CThongtinNCC ncungcap = tim(nhacungcap.MaNhaCungCap);
            if (ncungcap != null)
            {
                ncungcap.TenNhaCungCap = nhacungcap.TenNhaCungCap;
                ncungcap.SoDienThoai = nhacungcap.SoDienThoai;
                ncungcap.DiaChi = nhacungcap.DiaChi;
            }
        }
        public int soLuongNCC()
        {
            return this.dsNhaCungCap.Count;
        }
        public void sapXepTangDanTheoMa(List<CThongtinNCC> dsncc)
        {
            dsncc.Sort((a, b) => a.MaNhaCungCap.CompareTo(b.MaNhaCungCap));
        }
        public void sapXepGiamDanTheoMa(List<CThongtinNCC> dsncc)
        {
            dsncc.Sort((a, b) => b.MaNhaCungCap.CompareTo(a.MaNhaCungCap));
        }


        public void sapXepTangDanTheoTen(List<CThongtinNCC>dsncc)
        {
            dsncc.Sort((a, b) => a.TenNhaCungCap.CompareTo(b.TenNhaCungCap));
        }
        public void sapXepGiamDanTheoTen(List<CThongtinNCC> dsNCC)
        {
            dsNCC.Sort((a, b) => b.TenNhaCungCap.CompareTo(a.TenNhaCungCap));
        }




    }
  
}

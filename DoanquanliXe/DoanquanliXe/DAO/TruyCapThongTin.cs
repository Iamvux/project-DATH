using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using DoanquanliXe.DTO;

namespace DoanquanliXe.DAO
{
    [Serializable]
    internal class TruyCapThongTin
    {
        private static TruyCapThongTin instance = null;
        private List<CThongTinXe> dsXe;

        private List<CThongtinNCC> dsNhaCungCap;


        private TruyCapThongTin()
        {
            dsXe = new List<CThongTinXe>();

            dsNhaCungCap = new List<CThongtinNCC>();

        }
        public List<CThongtinNCC> DsNhaCungCap { get => dsNhaCungCap; }
        internal List<CThongTinXe> DsXe { get => dsXe;  }

        public static TruyCapThongTin KhoiTao()
        {
            if (instance == null)
                instance = new TruyCapThongTin();
            return instance;
        }
        public static bool ghiFile(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, KhoiTao());
                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return false;
            }
        }

        public static bool docFile(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                instance = (TruyCapThongTin)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return false;
            }
        }
    }
   
}

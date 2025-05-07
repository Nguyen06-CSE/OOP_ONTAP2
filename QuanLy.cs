using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ThucHanh1
{
    public class QuanLy : INguoi, INhanVien
    {
        public string Ho { get ; set ; }
        public string Ten { get; set; }
        public int NhanVienID { get; set; }
        public string Phong { get; set; }

        public QuanLy(string ho, int nhanVienID, string phong, string ten )
        {
            Ho = ho;
            NhanVienID = nhanVienID;
            Phong = phong;
            Ten = ten;
        }

        public QuanLy() { }

        public string LayTenDayDu()
        {
            return $"{Ho} {Ten}";
        }

        public string LayThongTinChiTiet()
        {
            return $"ID: {NhanVienID}, Phòng: {Phong}, Họ tên: {LayTenDayDu()}";
        }

        public override string ToString()
        {
            return $"ID: {NhanVienID}, Phòng: {Phong}, Họ: {Ho}, Tên: {Ten}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ThucHanh1
{
    public class QuanLy : INguoi, INhanVien, IKhaNangQuanLy, IBaoCao, IQuanLyLuong
    {
        public string Ho { get ; set ; }
        public string Ten { get; set; }
        public int NhanVienID { get; set; }
        public string Phong { get; set; }
        public string NhiemVu { get; set; }
        public double Luong {  get; set; }

        public QuanLy(string ho, int nhanVienID, string phong, string ten, string nhiemVu, double luong )
        {
            Ho = ho;
            NhanVienID = nhanVienID;
            Phong = phong;
            Ten = ten;
            NhiemVu = nhiemVu;
            Luong = luong;
        }

        public QuanLy() { }

        public string LayTenDayDu()
        {
            return $"{Ho} {Ten}";
        }

        public string LayThongTinChiTiet()
        {
            return $"ID: {NhanVienID}, Phòng: {Phong}, Họ tên: {LayTenDayDu()}, Nhiem vu {NhiemVu}, luong {Luong}";
        }

        public void GanNhiemVu(string nhiemVu)
        {
            NhiemVu = nhiemVu;
            Console.WriteLine($"gan nhiem vu '{nhiemVu}' cho {LayTenDayDu()}");
        }

        public string TaoBaoCao()
        {
            return $"[BAO CAO NHAN VIEN]\n" +
                   $"Ho ten      : {LayTenDayDu()}\n" +
                   $"ID          : {NhanVienID}\n" +
                   $"Phong       : {Phong}\n" +
                   $"Nhiem vu    : {NhiemVu}\n" +
                   $"-------------------------";
        }

        public void GanLuong(double luong)
        {
            Luong = luong;
            Console.WriteLine($"ganluong '{luong}' cho {LayTenDayDu()}");
        }

        public double TangLuong(double phanTram)
        {
            return Luong = (Luong * phanTram) / 100;
        }

        public void HienThiLuong()
        {
            Console.WriteLine($"luong cua nhan vien {LayTenDayDu()} la: {Luong}");
        }

        public override string ToString()
        {
            return $"ID: {NhanVienID}, Phong: {Phong}, Ho: {Ho}, Ten: {Ten}, Nhiem vu {NhiemVu}, luong {Luong}";
        }
    }
}

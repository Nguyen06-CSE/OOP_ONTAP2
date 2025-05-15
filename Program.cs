using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    internal class Program
    {
        public enum ThucDon
        {
            NhapThongTin1NhanVienThucCong = 1,
            DocThongTinTuFile,
            HienThiDanhSach,
            XuatRaFile,
            TimNhanVienTheoMaID,
            TimNhanVienTheoTen,
            TimNhanVienTheoHo,
            TimNhanVienTheoPhong,
            XoaNhanVienTheoID,
            XoaNhanVienTheoTen,
            XoaNhanVienTheoHo,
            XoaNhanVienTheoPhong,
            SapXepTheoMaID,
            SapXepTheoTen,
            SapXepTheoPhong,
            SuaTenNhanVien,
            SuaHoNhanVien,
            SuaPhongNhanVien,
            TimKiemTheoTenChuaTuKhoa,
            TinhTongLuongCuaNhanVien, 
            Thoat
        }
        static void Main(string[] args)
        {

            DanhSachNhanVien ds = new DanhSachNhanVien();

            string tenFileInput = "C:\\Users\\nguyen.cao\\Desktop\\codec++\\oop\\baiTapTrenLMS\\OOP_ONTAP2\\ThucHanh1\\bin\\Debug\\input.txt";
            string tenFileOutput = "C:\\Users\\nguyen.cao\\Desktop\\codec++\\oop\\baiTapTrenLMS\\OOP_ONTAP2\\ThucHanh1\\bin\\Debug\\output.txt";

            ds.DocTuFile(tenFileInput);
            ds.HienThiDanhSach();
            ds.XuatRaFile(tenFileOutput);

            //while (true)
            //{
            //    DanhSachNhanVien ds = new DanhSachNhanVien();
                
            //    Console.Clear();
            //    Console.WriteLine("Chon chuc nang:");
            //    foreach (var i in Enum.GetValues(typeof(ThucDon)))
            //    {
            //        Console.WriteLine($"{(int)i}. {i}");
            //    }

            //    Console.Write("Nhap lua chon: ");
            //    ThucDon chon = (ThucDon)int.Parse(Console.ReadLine());

            //    switch (chon)
            //    {
            //        case ThucDon.NhapThongTin1NhanVienThucCong:
            //            INhanVien nv = ds.NhapThongTinNhanVien();
            //            ds.ThemNhanVien(nv);
            //            break;

            //        case ThucDon.DocThongTinTuFile:
                        
            //            ds.DocTuFile(tenFileInput);
            //            break;

            //        case ThucDon.HienThiDanhSach:
            //            ds.HienThiDanhSach();
            //            break;

            //        case ThucDon.XuatRaFile:
                        
            //            ds.XuatRaFile(tenFileOutput);
            //            break;

            //        case ThucDon.TimNhanVienTheoMaID:
            //            Console.Write("Nhap ID nhan vien: ");
            //            int id = int.Parse(Console.ReadLine());
            //            INhanVien nvID = ds.TimNhanVienTheoMaID(id);
            //            if (nvID != null)
            //                Console.WriteLine(nvID.ToString());
            //            else
            //                Console.WriteLine("Khong tim thay nhan vien");
            //            break;

            //        case ThucDon.TimNhanVienTheoTen:
            //            Console.Write("Nhap ten nhan vien: ");
            //            string ten = Console.ReadLine();
            //            DanhSachNhanVien dsTen = ds.TimNhanVienTheoTen(ten);
            //            dsTen.HienThiDanhSach();
            //            break;

            //        case ThucDon.TimNhanVienTheoHo:
            //            Console.Write("Nhap ho nhan vien: ");
            //            string ho = Console.ReadLine();
            //            DanhSachNhanVien dsHo = ds.TimNhanVienTheoHo(ho);
            //            dsHo.HienThiDanhSach();
            //            break;

            //        case ThucDon.TimNhanVienTheoPhong:
            //            Console.Write("Nhap phong ban: ");
            //            string phong = Console.ReadLine();
            //            DanhSachNhanVien dsPhong = ds.TimNhanVienTheoPhong(phong);
            //            dsPhong.HienThiDanhSach();
            //            break;

            //        case ThucDon.XoaNhanVienTheoID:
            //            Console.Write("Nhap ID nhan vien can xoa: ");
            //            int idXoa = int.Parse(Console.ReadLine());
            //            ds.XoaNhanVienTheoID(idXoa);
            //            break;

            //        case ThucDon.XoaNhanVienTheoTen:
            //            Console.Write("Nhap ten nhan vien can xoa: ");
            //            string tenXoa = Console.ReadLine();
            //            ds.XoaNhanVienTheoTen(tenXoa);
            //            break;

            //        case ThucDon.XoaNhanVienTheoHo:
            //            Console.Write("Nhap ho nhan vien can xoa: ");
            //            string hoXoa = Console.ReadLine();
            //            ds.XoaNhanVienTheoHo(hoXoa);
            //            break;

            //        case ThucDon.XoaNhanVienTheoPhong:
            //            Console.Write("Nhap phong ban can xoa: ");
            //            string phongXoa = Console.ReadLine();
            //            ds.XoaNhanVienTheoPhong(phongXoa);
            //            break;

            //        case ThucDon.SapXepTheoMaID:
            //            ds.SapXepTheoMaID();
            //            Console.WriteLine("Da sap xep theo ID");
            //            break;

            //        case ThucDon.SapXepTheoTen:
            //            ds.SapXepTheoTen();
            //            Console.WriteLine("Da sap xep theo ten");
            //            break;

            //        case ThucDon.SapXepTheoPhong:
            //            ds.SapXepTheoPhong();
            //            Console.WriteLine("Da sap xep theo phong");
            //            break;

            //        case ThucDon.SuaTenNhanVien:
            //            Console.Write("Nhap ID nhan vien can sua: ");
            //            int idSuaTen = int.Parse(Console.ReadLine());
            //            Console.Write("Nhap ten moi: ");
            //            string tenMoi = Console.ReadLine();
            //            ds.SuaTenNhanVien(tenMoi, idSuaTen);
            //            break;

            //        case ThucDon.SuaHoNhanVien:
            //            Console.Write("Nhap ID nhan vien can sua: ");
            //            int idSuaHo = int.Parse(Console.ReadLine());
            //            Console.Write("Nhap ho moi: ");
            //            string hoMoi = Console.ReadLine();
            //            ds.SuaHoNhanVien(hoMoi, idSuaHo);
            //            break;

            //        case ThucDon.SuaPhongNhanVien:
            //            Console.Write("Nhap ID nhan vien can sua: ");
            //            int idSuaPhong = int.Parse(Console.ReadLine());
            //            Console.Write("Nhap phong moi: ");
            //            string phongMoi = Console.ReadLine();
            //            ds.SuaPhongNhanVien(phongMoi, idSuaPhong);
            //            break;

            //        case ThucDon.TimKiemTheoTenChuaTuKhoa:
            //            Console.Write("Nhap tu khoa tim kiem: ");
            //            string tuKhoa = Console.ReadLine();
            //            ds.TimKiemTheoTenChuaTuKhoa(tuKhoa);
            //            break;

            //        case ThucDon.TinhTongLuongCuaNhanVien:
            //            double tongLuong = ds.TinhTongLuongCuaNhanVien();
            //            Console.WriteLine($"Tong luong cua tat ca nhan vien: {tongLuong}");
            //            break;

            //        case ThucDon.Thoat:
            //            Console.WriteLine("Ket thuc chuong trinh");
            //            Environment.Exit(0);
            //            break;

            //        default:
            //            Console.WriteLine("Lua chon khong hop le");
            //            break;
            //    }
            //    Console.WriteLine("Nhan Enter de tiep tuc...");
            //    Console.ReadLine();
            //}
        }
    }
}

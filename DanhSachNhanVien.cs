using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    public class DanhSachNhanVien
    {
        List<INhanVien> collection;

        public DanhSachNhanVien()
        {
            collection = new List<INhanVien>();
        }

        public void ThemNhanVien(INhanVien nv)
        {
            collection.Add(nv);
        }

        public INhanVien NhapThongTinNhanVien()
        {
            Console.WriteLine("=== NHAP THONG TIN NHAN VIEN ===");

            Console.Write("nhap ID nhan vien: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nhap phong: ");
            string phong = Console.ReadLine();

            Console.Write("nhap ho: ");
            string ho = Console.ReadLine();

            Console.Write("nhap ten: ");
            string ten = Console.ReadLine();

            Console.WriteLine("nhap nhiem vu: ");
            string nhiemVu = Console.ReadLine();

            Console.WriteLine("nhap luong: ");
            double luong = double.Parse(Console.ReadLine());

            INhanVien nhanVien = new QuanLy(ho, id, phong, ten, nhiemVu, luong);
            return nhanVien;
        }

        public DanhSachNhanVien NhapThuCongDanhSachNhanVien(int n)
        {
            DanhSachNhanVien res = new DanhSachNhanVien();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"nhap nhan vien thu {i + 1}: ");
                var tmp = NhapThongTinNhanVien();
                res.ThemNhanVien(tmp);
            }
            return res;
        }

        public void DocTuFile(string tenFle)
        {
            if (!File.Exists(tenFle))
            {
                Console.WriteLine("file ko ton tai");
                return;
            }

            StreamReader sr = new StreamReader(tenFle);
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                var part = s.Split(',');

                string ho = part[0];
                int nhanVienID = int.Parse(part[1]);
                string phong = part[2];
                string ten = part[3];
                string nhienVu = part[4];
                double luong = double.Parse(part[5]);

                INhanVien nv = new QuanLy(ho, nhanVienID, phong, ten, nhienVu,luong);
                collection.Add(nv);
            }
        }

        public void HienThiDanhSach()
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public void XuatRaFile(string tenFile)
        {
            StreamWriter sw = new StreamWriter(tenFile);
            
                foreach (var item in collection)
                {
                    
                        sw.WriteLine(item);
                    
                }
            

            Console.WriteLine("da ghi du lieu ra file thanh cong");
        }

        public int TimNhanVienTheoMaID(int id)
        {
            for(int i = 0; i < collection.Count; i++)
            {
                if (collection[i].NhanVienID == i)
                {
                    return i;
                }
            }
            return -1;
        }

        public DanhSachNhanVien TimNhanVienTheoTen(string Ten)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();
            foreach(var item in collection)
            {
                if(item is INguoi nguoi && nguoi.Ten == Ten)
                {
                    ds.ThemNhanVien(item);
                }
            }
            return ds;
        }

        public DanhSachNhanVien TimNhanVienTheoHo(string ho)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();
            foreach (var item in collection)
            {
                if (item is INguoi nguoi && nguoi.Ho == ho)
                {
                    ds.ThemNhanVien(item);
                }
            }
            return ds;
        }

        public DanhSachNhanVien TimNhanVienTheoPhong(string phong)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();
            foreach (var item in collection)
            {
                if (item is INhanVien nv && nv.Phong == phong)
                {
                    ds.ThemNhanVien(item);
                }
            }
            return ds;
        }

        public void XoaMotNhanVien(INhanVien item)
        {
            collection.Remove(item);
        }

        public void XoaNhanVienTheoID(int id)
        {
            var nv = TimNhanVienTheoMaID(id);
            if(nv == -1)
            {
                Console.WriteLine("nhan vien nay ko co trong danh sach");
            }
            else
            {
                collection.RemoveAt(nv);
            }
        }

        public void XoaNhanVienTheoTen(string ten)
        {
            var danhSachDaLay = TimNhanVienTheoTen(ten);

            var itemsToRemove = new List<INhanVien>(danhSachDaLay.collection);

            foreach (var item in itemsToRemove)
            {
                collection.Remove(item);
            }

        }

        public void XoaNhanVienTheoHo(string ho)
        {
            var danhSachDaLay = TimNhanVienTheoHo(ho);

            var itemsToRemove = new List<INhanVien>(danhSachDaLay.collection);

            foreach (var item in itemsToRemove)
            {
                collection.Remove(item);
            }
        }
        public void XoaNhanVienTheoPhong(string phong)
        {
            var danhSachDaLay = TimNhanVienTheoPhong(phong);

            var itemsToRemove = new List<INhanVien>(danhSachDaLay.collection);

            foreach (var item in itemsToRemove)
            {
                collection.Remove(item);
            }
        }

        public void Swap(int i, int j, List<INhanVien> list)
        {
            var tmp = list[i];
            list[i] = list[j];
            list[j] = tmp;
        }

        public void SapXepTheoMaID()
        {
            for(int i = 0; i < collection.Count-1; i++)
            {
                for(int j = i + 1; j < collection.Count; j++)
                {
                    if(collection[i].NhanVienID > collection[j].NhanVienID)
                    {
                        Swap(i, j, collection);
                    }
                }
            }
        }

        public void SapXepTheoTen()
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[i] is INguoi nguoi1 && collection[j] is INguoi nguoi2 &&
                        string.Compare(nguoi1.Ten, nguoi2.Ten) > 0)
                    {
                        Swap(i, j, collection);
                    }
                }
            }
        }
        public void SapXepTheoPhong()
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[i] is INhanVien nv1 && collection[j] is INhanVien nv2 &&
                        string.Compare(nv1.Phong, nv2.Phong) > 0)
                    {
                        Swap(i, j, collection);
                    }
                }
            }
        }

        public void SapXepTheoTenNeuTrungSapTheoHo()
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[i] is INguoi nguoi1 && collection[j] is INguoi nguoi2)
                    {
                        if (string.Compare(nguoi1.Ten, nguoi2.Ten) > 0 ||
                            (string.Compare(nguoi1.Ten, nguoi2.Ten) == 0 && string.Compare(nguoi1.Ho, nguoi2.Ho) > 0))
                        {
                            Swap(i, j, collection);
                        }
                    }
                }
            }
        }


        public void SuaThongTinNhanVien(int id, string ho ="", string ten ="",string phong ="" )
        {
            var location = TimNhanVienTheoMaID(id);

            if (location == -1)
            {
                Console.WriteLine($"Không tìm thấy nhân viên với ID: {id}");
                return;
            }

            if(ho != null || ho != "" )
            {
                if (collection[location] is INguoi nguoi)
                {
                    nguoi.Ho = ho;
                }
            }


            if (ten != null || ten != "")
            {
                if (collection[location] is INguoi nguoi)
                {
                    nguoi.Ten = ten;
                }
            }


            if (phong != null || phong != "")
            {
                if (collection[location] is INhanVien nv)
                {
                    nv.Phong = phong;
                }
            }

            Console.WriteLine("Đã cập nhật thông tin nhân viên.");
        }

        public void SuaHoNhanVien(string newHo, int id)
        {
            var location = TimNhanVienTheoMaID(id);

            if (location == -1)
            {
                Console.WriteLine($"Không tìm thấy nhân viên với ID: {id}");
                return;
            }

            else
            {
                if (collection[location] is INguoi nguoi)
                {
                    nguoi.Ho = newHo;
                }
            }

            Console.WriteLine("Đã cập nhật thông tin nhân viên.");
        }

        public void SuaPhongNhanVien(string newPhong, int id)
        {
            var location = TimNhanVienTheoMaID(id);

            if (location == -1)
            {
                Console.WriteLine($"Không tìm thấy nhân viên với ID: {id}");
                return;
            }

            else
            {
                if (collection[location] is INhanVien nv)
                {
                   nv.Phong = newPhong;
                }
            }

            Console.WriteLine("Đã cập nhật thông tin nhân viên.");
        }

        //public void SuaThongTinNhanVien(int id, string newHo, string newTen, string newPhong)
        //{
        //    Console.WriteLine("nhap thong tin ban muon sua:(1)Ten, (2)Ho, (3)Phong");
        //    int n = int.Parse(Console.ReadLine());
        //    string ten, ho, phong;
        //    int idTim;
        //    Console.WriteLine("nhap id cua nhan vien ban muon sua thong tin: ");
        //    idTim = int.Parse(Console.ReadLine());
        //    switch (n)
        //    {
        //        case 1:

        //            Console.WriteLine("nhap ten moi ban muon doi: ");
        //            ten = Console.ReadLine();

        //            SuaTenNhanVien(ten, idTim);
        //        break;
        //        case 2:

        //            Console.WriteLine("nhap ho moi ban muon doi: ");
        //            ho = Console.ReadLine();

        //            SuaHoNhanVien(ho, idTim);
        //            break;
        //        case 3:

        //            Console.WriteLine("nhap phong moi ban muon doi: ");
        //            phong = Console.ReadLine();

        //            SuaPhongNhanVien(phong, idTim);
        //            break;
        //    }
        //}

        public void TimKiemTheoTenChuaTuKhoa(string tuKhoa)
        {
            bool timThay = false;
            Console.WriteLine($"Danh sách nhân viên có tên chứa từ khóa '{tuKhoa}':");

            foreach (var nv in collection)
            {
                if ( nv is INguoi nguoi && nguoi.Ten.ToLower().Contains(tuKhoa.ToLower()))
                {
                    Console.WriteLine(nv.LayThongTinChiTiet());
                    timThay = true;
                }
            }

            if (!timThay)
            {
                Console.WriteLine("ko tim thay nhan vien co ten thich hop voi tu khoa: " + tuKhoa);
            }
        }

        public double TinhTongLuongCuaNhanVien()
        {
            double result = 0;
            foreach(var nv in collection)
            {
                result += nv.Luong;
            }
            return result;
        }

        public void TangLuongChoNhanVien(int id, double phanTramTang)
        {
            foreach(var item in collection)
            {
                if(item.NhanVienID == id && item is QuanLy ql)
                {
                    item.Luong = ql.TangLuong(phanTramTang);
                    break;
                }
            }
        }

        public void HienThiLuongCuaTatCaNhanVien()
        {
            foreach(var item in collection)
            {
                var tmp = (QuanLy)item;
                tmp.HienThiLuong();
            }
        }


    }
}

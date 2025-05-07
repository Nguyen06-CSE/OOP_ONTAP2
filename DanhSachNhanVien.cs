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

        public void NhapThongTinNhanVien()
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

            INhanVien nhanVien = new QuanLy(ho, id, phong, ten);
            ThemNhanVien(nhanVien);

            Console.WriteLine("thanh cong!\n");
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

                INhanVien nv = new QuanLy(ho, nhanVienID, phong, ten);
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
            
                foreach (INhanVien nv in collection)
                {
                    if (nv is INguoi nguoi)
                    {
                        string line = $"{nguoi.Ho},{nv.NhanVienID},{nv.Phong},{nguoi.Ten}";
                        sw.WriteLine(line);
                    }
                }
            

            Console.WriteLine("Đã ghi dữ liệu ra file thành công.");
        }

        public INhanVien TimNhanVienTheoMaID(int id)
        {
            foreach(var item in collection)
            {
                if(item is INhanVien nv && nv.NhanVienID == id)
                {
                    return nv;
                }
            }
            return null;
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
            if(nv == null)
            {
                Console.WriteLine("nhan vien nay ko co trong danh sach");
            }
            else
            {
                collection.Remove(nv);
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

        public void SuaThongTinNhanVien(int id, string newHo, string newTen, string newPhong)
        {
            INhanVien nv = TimNhanVienTheoMaID(id);

            if (nv == null)
            {
                Console.WriteLine($"Không tìm thấy nhân viên với ID: {id}");
                return;
            }

            if (nv is INguoi nguoi)
            {
                nguoi.Ho = newHo;
                nguoi.Ten = newTen;
            }

            nv.Phong = newPhong;

            Console.WriteLine("Đã cập nhật thông tin nhân viên.");
        }

    }
}

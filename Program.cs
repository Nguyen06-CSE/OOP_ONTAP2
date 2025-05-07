using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();

            string tenFileInput = "C:\\Users\\nguyen.cao\\Desktop\\codec++\\oop\\baiTapTrenLMS\\OOP_ONTAP2\\ThucHanh1\\bin\\Debug\\input.txt";
            string tenFileOutput = "C:\\Users\\nguyen.cao\\Desktop\\codec++\\oop\\baiTapTrenLMS\\OOP_ONTAP2\\ThucHanh1\\bin\\Debug\\output.txt";

            ds.DocTuFile(tenFileInput);
            ds.SapXepTheoPhong();
            ds.HienThiDanhSach();
        }
    }
}

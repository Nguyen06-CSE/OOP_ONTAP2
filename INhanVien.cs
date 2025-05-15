using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    public interface INhanVien
    {
        int NhanVienID { get; set; }
        string Phong {  get; set; }
        double Luong {  get; set; }
        void GanNhiemVu(string nhiemVu);
        string LayThongTinChiTiet();
    }
}

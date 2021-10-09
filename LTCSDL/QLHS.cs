using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTCSDL
{
    public class QLHS
    {
        public List<HocSinh> dshs = new List<HocSinh>();
        public void ThemMoi(int mahs, string tenHS, string diachi, DateTime ngaysinh, string dienthoai)// hành vi hay gọi là hàm, function
        {
            HocSinh objhs = new HocSinh(); // khởi tạo đối tượng hoc sinh
            objhs.MaHs = mahs; // gán gia tri cho thuoc tinh MaHS. Ham Set
            objhs.TenHS = tenHS;
            objhs.DiaChi = diachi;
            objhs.NgaySinh = ngaysinh;  //->  10/02/2021
            objhs.DienThoai = dienthoai;



            dshs.Add(objhs);



            //int mahs = objhs.MaHs; // lấy giá trị ra từ thuộc tính MaHS. Hàm Get
        }
    }
}

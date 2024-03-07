using System;

namespace _2001223947_HoDucHoangQuan_LTHDT_Buoi3
{
    class BT3_ThiSinh
    {
        public class ThiSinh
        {
            private string hoTen;
            private string soBaoDanh;
            private int namSinh;
            private int diemLT;
            private int diemTH;

            // Phương thức get/set
            public string HoTen
            {
                get { return hoTen; }
                set { hoTen = value; }
            }
            public string SBD
            {
                get { return soBaoDanh; }
                set { soBaoDanh = value; }
            }
            public int NamSinh
            {
                get { return namSinh; }
                set { namSinh = value; }
            }
            public int diemLyThuyet
            {
                get { return diemLT; }
                set { diemLT = value; }
            }
            public int diemThucHanh
            {
                get { return diemTH; }
                set { diemTH = value; }
            }

            // Khởi tạo mặc định
            public ThiSinh()
            {
                hoTen = "...";
                soBaoDanh = "...";
                namSinh = 0;
                diemLT = 0;
                diemTH = 0;

            }
            // Khởi tạo có tham số
            public ThiSinh(string hoten, string sobaodanh, int namsinh, int diemlt, int diemth)
            {
                hoTen = hoten;
                soBaoDanh = sobaodanh;
                namSinh = namsinh;
                diemLT = diemlt;
                diemTH = diemth;
            }
            // Khởi tạo sao chép
            public ThiSinh(ThiSinh thsinh)
            {
                hoTen = thsinh.hoTen;
                soBaoDanh = thsinh.soBaoDanh;
                namSinh = thsinh.namSinh;
                diemLT = thsinh.diemLT;
                diemTH = thsinh.diemTH;
            }

            // Phương thức xét kết quả đậu hay rớt
            public string tinhKetQua()
            {
                if (((diemLyThuyet + diemThucHanh) > 10) && (diemLyThuyet >= 2 && diemThucHanh >= 2))
                    return "Dau";
                else
                    return "Rot";
            }
        }
    }
}

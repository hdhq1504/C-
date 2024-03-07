using System;

namespace _2001223947_HoDucHoangQuan_LTHDT_Buoi3
{
    class VD1_HinhTron
    {
        public class HinhTron
        {
            private double banKinh;
            // Khởi tạo mặc định
            public HinhTron()
            {
                banKinh = 0;
            }
            // Khởi tạo có tham số
            public HinhTron(double r)
            {
                banKinh = r;
            }
            // Khởi tạo có sao chép
            public HinhTron(HinhTron ht)
            {
                banKinh = ht.banKinh;
            }

            // Phương thức get/set
            public double R
            {
                get { return banKinh; }
                set { banKinh = value; }
            }

            // Phương thức tính chu vi, diện tích
            public double tinhChuVi()
            {
                return R * 2 * Math.PI;
            }
            public double tinhDienTich()
            {
                return Math.PI * Math.Pow(R, 2);
            }
        }
    }
}
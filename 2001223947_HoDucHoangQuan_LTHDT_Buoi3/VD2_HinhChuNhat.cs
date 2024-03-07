using System;

namespace _2001223947_HoDucHoangQuan_LTHDT_Buoi3
{
    class VD2_HinhChuNhat
    {
        public class HinhChuNhat
        {
            private double chieuDai, chieuRong;
            // Phương thức get/set
            public double ChieuDai
            {
                get { return chieuDai; }
                set { chieuDai = value; }
            }
            public double ChieuRong
            {
                get { return chieuRong; }
                set { chieuRong = value; }
            }

            // Khởi tạo mặc định
            public HinhChuNhat()
            {
                chieuDai = chieuRong = 0;
            }
            // Khởi tạo có tham số
            public HinhChuNhat(double CD, double CR)
            {
                chieuDai = CD;
                chieuRong = CR;
            }
            // Khởi tạo sao chép
            public HinhChuNhat(HinhChuNhat hcn)
            {
                chieuDai = hcn.chieuDai;
                chieuRong = hcn.chieuRong;
            }

            // Phương thức tính chu vi, diện tích
            public double tinhChuVi()
            {
                return (ChieuDai + ChieuRong) * 2;
            }
            public double tinhDienTich()
            {
                return ChieuDai * ChieuRong;
            }
        }
    }
}

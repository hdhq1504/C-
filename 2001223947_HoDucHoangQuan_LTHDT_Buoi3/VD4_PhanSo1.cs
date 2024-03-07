using System;

namespace _2001223947_HoDucHoangQuan_LTHDT_Buoi3
{
    class VD4_PhanSo
    {
        public class PhanSo
        {
            private int tu1, mau1;
            private int tu2, mau2;
            // Phương thức get/set
            public int TU1
            {
                get { return tu1; }
                set { tu1 = value; }
            }
            public int MAU1
            {
                get { return mau1; }
                set { mau1 = value; }
            }
            public int TU2
            {
                get { return tu2; }
                set { tu2 = value; }
            }
            public int MAU2
            {
                get { return mau2; }
                set { mau2 = value; }
            }

            // Khởi tạo mặc định
            public PhanSo()
            {
                tu1 = mau1 = tu2 = mau2 = 0;
            }
            // Khởi tạo có tham số
            public PhanSo(int Tu1, int Mau1, int Tu2, int Mau2)
            {
                tu1 = Tu1;
                mau1 = Mau1;
                tu2 = Tu2;
                mau2 = Mau2;
            }
            // Khởi tạo sao chép
            public PhanSo(PhanSo ps)
            {
                tu1 = ps.tu1;
                mau1 = ps.mau1;
                tu2 = ps.tu2;
                mau2 = ps.mau2;
            }

            // Phương thức tính tổng 2 phân số
            public double tinhTong2PS()
            {
                double tu = (tu1 * mau2) + (tu2 * mau1);
                double mau = mau1 * mau2;
                return tu / mau;
            }
        }
    }
}
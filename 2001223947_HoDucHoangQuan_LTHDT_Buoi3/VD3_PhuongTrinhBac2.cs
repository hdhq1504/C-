using System;

namespace _2001223947_HoDucHoangQuan_LTHDT_Buoi3
{
    class VD3_PhuongTrinhBac2
    {
        public class PhuongTrinhBac2
        {
            private int a, b, c;
            // Phương thức get/set
            public int A
            {
                get { return a; }
                set { a = value; }
            }
            public int B
            {
                get { return b; }
                set { b = value; }
            }
            public int C
            {
                get { return c; }
                set { c = value; }
            }

            // Khởi tạo mặc định
            public PhuongTrinhBac2()
            {
                a = b = c = 0;
            }
            // Khởi tạo có tham số
            public PhuongTrinhBac2(int A, int B, int C)
            {
                a = A;
                b = B;
                c = C;
            }
            // Khởi tạo sao chép
            public PhuongTrinhBac2(PhuongTrinhBac2 pt)
            {
                a = pt.a;
                b = pt.b;
                c = pt.c;
            }

            // Phương thức nhập, đếm số nghiệm của phương trình bậc 2
            public int demSoNghiemPT()
            {
                int delta = b * b - 4 * a * c;
                if (delta > 0)
                    return 2;
                else if (delta == 0)
                    return 1;
                else
                    return 0;
            }
        }
    }
}
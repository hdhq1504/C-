using System;

namespace _2001223947_HoDucHoangQuan_LTHDT_Buoi3
{
    class BT1_Oxy
    {
        public class Diem2D
        {
            private int x;
            private int y;
            // Phương thức get/set
            public int X
            {
                get { return x; }
                set { x = value; }
            }
            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            // Khởi tạo mặc định
            public Diem2D()
            {
                x = y = 0;
            }
            // Khởi tạo có tham số
            public Diem2D(int hoanhDo, int tungDo)
            {
                x = hoanhDo;
                y = tungDo;
            }
            // Khởi tạo sao chép
            public Diem2D(Diem2D diem)
            {
                x = diem.x;
                y = diem.y;
            }

            // Phương thức tính khoảng cách từ góc tọa độ
            public double tinhKhoangCach()
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }
    }
}

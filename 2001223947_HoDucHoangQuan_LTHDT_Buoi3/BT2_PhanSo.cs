using System;

namespace _2001223947_HoDucHoangQuan_LTHDT_Buoi3
{
    class BT2_PhanSo
    {
        public class PhanSo
        {
            private int tu, mau;
            // Phương thức get/set
            public int Tu
            {
                get { return tu; }
                set { tu = value; }
            }
            public int Mau
            {
                get { return mau; }
                set
                {
                    if (value != 0)
                        mau = value;
                    else
                        Console.WriteLine("Mau phai khac 0!");
                }
            }

            // Khởi tạo mặc định
            public PhanSo()
            {
                tu = 0;
                mau = 1;
            }
            // Khởi tạo có tham số
            public PhanSo(int TU, int MAU)
            {
                tu = TU;
                mau = MAU;
            }
            // Khởi tạo sao chép
            public PhanSo(PhanSo ps)
            {
                tu = ps.tu;
                mau = ps.mau;
            }

            // Phương thức nhập, xuất, rút gọn phân số
            public void nhap()
            {
                Console.Write("Nhap tu so: ");
                Tu = int.Parse(Console.ReadLine());
                Console.Write("Nhap mau so: ");
                Mau = int.Parse(Console.ReadLine());
            }
            public void xuat()
            {
                Console.Write("Phan so vua nhap la: {0}/{1}", Tu, Mau);
            }
            public int GCD(int a, int b)
            {
                while (a != b)
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }
                return a;
            }
            public void rutGonPhanSo()
            {
                int gcd = GCD(Tu, Mau);
                if (Tu == Mau)
                    Console.WriteLine("Phan so sau khi rut gon: {0}", Tu / Mau);
                else if (Tu > Mau)
                    Console.WriteLine("Phan so sau khi rut gon: {0}", Tu / Mau);
                else
                {
                    Tu /= gcd;
                    Mau /= gcd;
                    Console.WriteLine("Phan so sau khi rut gon: {0}/{1}", Tu / Mau);
                }
            }
        }
    }
}

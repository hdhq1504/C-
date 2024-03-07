using System;

namespace _2001223947_HoDucHoangQuan_LTHDT_Buoi3
{
    class VD5_Nguoi
    {
        public class Nguoi
        {
            private string hoTen;
            private string cccd;
            private int namSinh;
            // Phương thức get/set
            public string HoTen
            {
                get { return hoTen; }
                set { hoTen = value; }
            }
            public string CCCD
            {
                get { return cccd; }
                set
                {
                    if (cccd.Length > 12)
                        Console.WriteLine("CCCD khong hop le!");
                    else
                        cccd = value;
                }
            }
            public int NamSinh
            {
                get { return namSinh; }
                set { namSinh = value; }
            }

            // Khởi tạo mặc định
            public Nguoi()
            {
                hoTen = "...";
                cccd = "012345678912";
                namSinh = 2024;
            }
            // Khởi tạo có tham số
            public Nguoi(string hoVaTen, string CCCD, int NamSinh)
            {
                hoTen = hoVaTen;
                cccd = CCCD;
                namSinh = NamSinh;
            }
            // Khởi tạo sao chép
            public Nguoi(Nguoi person)
            {
                hoTen = person.hoTen;
                cccd = person.cccd;
                namSinh = person.namSinh;
            }

            // Phương thức tính tuổi
            public int tinhTuoi()
            {
                int tuoi = 2024 - NamSinh;
                return tuoi;
            }
        }
    }
}
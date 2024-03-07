//using System;

//namespace _2001223947_HoDucHoangQuan_LTHDT_Buoi3
//{
//    class VD6_TKNH
//    {
//        public class TKNH
//        {
//            private string maTK;
//            private string tenTK;
//            private int soDu;
//            // Phương thức get/set
//            public string MaTK
//            {
//                get { return maTK; }
//                set { maTK = value; }
//            }
//            public string TenTK
//            {
//                get { return tenTK; }
//                set { tenTK = value; }
//            }
//            public int SoDu
//            {
//                get { return soDu; }
//            }

//            // Khởi tạo mặc định
//            public TKNH()
//            {
//                maTK = "01234567989";
//                tenTK = "A";
//                soDu = 0;
//            }
//            // Khởi tạo có tham số
//            public TKNH(string MaTKhoan, string TenTKhoan, int SDu)
//            {
//                maTK = MaTKhoan;
//                tenTK = TenTKhoan;
//                soDu = SDu;
//            }
//            // Khởi tạo sao chép
//            public TKNH(TKNH tk)
//            {
//                maTK = tk.maTK;
//                tenTK = tk.tenTK;
//                soDu = tk.soDu;
//            }

//            // Phương thức nạp tiền, rút tiền
//            public void napTien()
//            {
//                Console.Write("Nhap so tien muon nap: ");
//                int soTienNap = int.Parse(Console.ReadLine());
//                soDu += soTienNap;
//                Console.Write("So du sau khi nap {0} la: {1} VND", soTienNap, soDu);
//            }
//            public void rutTien()
//            {
//                Console.Write("Nhap so tien muon rut: ");
//                int soTienRut = int.Parse(Console.ReadLine());
//                soDu -= soTienRut;
//                if (soDu == 0)
//                    Console.WriteLine("Khong the rut tien!");
//                else
//                    Console.Write("So du sau khi rut {0} la: {1} VND", soTienRut, soDu);
//            }
//            public void nhap()
//            {
//                Console.Write("Nhap ma tai khoan: ");
//                MaTK = Console.ReadLine();
//                Console.Write("Nhap ten tai khoan: ");
//                TenTK = Console.ReadLine();
//            }
//        }

//        static void Main(string[] args)
//        {
//            TKNH tk1 = new TKNH();
//            tk1.nhap();
//            Console.WriteLine("Ma tai khoan: {0}", tk1.MaTK);
//            Console.WriteLine("Ten tai khoan: {0}", tk1.TenTK);
//            Console.WriteLine("So du: {0}", tk1.SoDu);
//            tk1.napTien();
//            Console.ReadLine();
//        }
//    }
//}

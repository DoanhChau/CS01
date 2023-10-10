using System;
using System.Security.Cryptography.X509Certificates;

namespace CS09
{
    class Program
    {
        /*
         <Access Mofifiers> <return type> <name_method> (<parameters>)
        {
           // Cac cau lenh trong phuong thuc
        }
         */


        //Khai bap phuong thuc tich
        public static int tich(int a, int b)
        {
            int result;
            result = a * b;
            return result;
        }
        public static void ketqua(string[] args)
        {
            int ketqua;
            xinchao(); //goi toi phuong thuc xinchao
            //hoac xinchao();
            ketqua = tich(3, 4);
            Console.WriteLine(ketqua);
        }
        static void xinchao()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Xin chao cac ban");
        }




        //Goi phuong thuc Tong o Tinhtoan.cs
        public static Main(string[] args)
        {
           var result = CS09.Tinhtoan.Tong(123, 456);
            Console.WriteLine(result);

            //Cach 2:
            //int x = 234;
            //int y = 456;
            //var result = CS09.Tinhtoan.Tong(x, y);
            //Console.WriteLine(result);





            //Truyen tham so vs ten
            public static void Main(string[] args)
            {
                xinchao("A", "Nguyen");
                //hoac
                //xinchao(ho: "Pham Van", ten: B");
                
            }
            static void xinchao(string ten, string ho)
            {
                string fullname;
                fullname = ho + " " + ten;
                Console.WriteLine($"Xin chao {fullname}");
            }






            //Tham tri
            public static void Main(string[] args)
            {
                int a = 5;
                binhphuong(a);
                Console.WriteLine(a);
            }

            static void binhphuong(int x)
            {
                x = x * x;
                Console.WriteLine(x);
            }




            //Tham chieu
            public static void Main(string[] args)
            {
                int a;
                binhphuong(4, out a);
                Console.WriteLine(a);
            }

            static void binhphuong(int x, out int k)
            {
                kq = x * x;
            }
        }
    }
}

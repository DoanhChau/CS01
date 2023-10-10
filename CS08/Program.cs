using System;
using System.Linq; //mo rong mot so phuong thuc cho mang
namespace CS08
{
    class Program
    {
        static void Main(string[] args)
        {
            //In danh sach sinh vien
            string sinhvien1 = "Nguyen Van A";
            string sinhvien2 = "Nguyen Van B";
            string sinhvien3 = "Nguyen Van C";
            Console.WriteLine(sinhvien1);
            Console.WriteLine(sinhvien2);
            Console.WriteLine(sinhvien3);


            //Cú pháp mảng: kieu_du_lieu[] + ten bien;


            //In danh sach sinh vien bằng mảng
            string[] dsach;
            dsach = new string[3];
            dsach[0] = "Nguyen Van A";
            dsach[1] = "Nguyen Van B";
            dsach[2] = "Nguyen Van C";

            Console.Write(dsach[0]);
            Console.WriteLine(dsach[1]);
            Console.WriteLine(dsach[2]);
            //hoac dung vong lap for
            //for (int i = 0; i <= 2, i++)
            //{
            //Console.Writeline(dsach[i]);
            //}



            //In mang so nguyen
            int[] mangsonguyen;
            string[] mang1 = new string[2] {"dien thoai", "may tinh"}; //mang1 chua 2 phan tu co gia tri mac dinh
            double[] mang2 = {5, 6, 7, 8}; //mac dinh hieu mang2 chua 4 phan tu
            mangsonguyen = new int[3]; //mangsonguyen chua 3 phan tu co gia tri mac dinh
            mangsonguyen[0] = 1;
            mangsonguyen[1] = 2;
            mangsonguyen[2] = 3;
            //hoac gop khai bao chi tiet cac phan tu: mangsonguyen = new int[3] {1, 2, 3};




            //Duyet qua cac phan tu de doc ndung, gan ndung
            int[] numbers = {1, 4, 7, 4, 3, 7, 34, 7};
            int sophantu = numbers.Length;

            //dung vong lap for
            for (int chiso = 0; chiso < sophantu; chiso++) 
                //chiso chay theo chieu thuan: int chiso = 0; chiso < sophantu; chiso++
                //chiso chay nguoc chieu: int chiso = sophantu - 1; chiso >= 0; chiso--

            {
                Console.WriteLine(numbers[chiso]);
            }

            //dung foreach
            foreach(var abc in numbers)
            {
                Console.WriteLine(abc);
            }



            //Mot so phuong thuc khac cua mang
            int[] numbers = { 1, 4, 7, 4, 3, 7, 34, 7 };
            Console.WriteLine($"So phan tu: {numbers.Length}");
            Console.WriteLine($"Chieu: {numbers.Rank}");
            Console.WriteLine($"Min: {numbers.Min()}");
            Console.WriteLine($"Max: {numbers.Max()}");
            Console.WriteLine($"Max: {numbers.Sum()}");



            //Sap xep mang 1 chieu tang dan
            int[] numbers = { 1, 4, 7, 4, 3, 7, 34, 7 };
            Array.Sort(numbers);
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
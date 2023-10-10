using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;

namespace CS11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string loichao; //mac dinh gia tri null
            string ten = "DoanhChau";
            loichao = "Xinchao";

            string thongbao = loichao + " " + ten;
            thongbao += "!";
            Console.WriteLine(thongbao);
            */



            //chen dau cach: \t
            //chen ky tu xuong dòng: \n
            //xuong dau dong: \r
            //bieu thi chuoi: $"..." 
            //chuoi duoc viet tren nhieu dong: @"..."
            string thongbao;
            string name = "DoanhChau";
            int year = 2000;
            string gioitinh = "Nu";
            thongbao =
                $@"
                 Ho ten: {name,10}
                 Nam sinh: {year,10}
                 Gioi tinh: {gioitinh,10}
                 ";





            //Phep toan thuc hien tren chuoi
            string thongbao = "DoanhChau, xin chao!";
            int dodai = thongbao.Length;
            //cach 1: dung char (kieu du lieu ky tu)
            /*char c = thongbao[10];*/
            Console.WriteLine(thongbao);
            Console.WriteLine(dodai);


            //Cach 2
            //dung for de tung ky tu tron mang
            /*
            for(int i = 0; i < dodai; i++)
            {
                char c = thongbao[i];
                Console.WriteLine($"Chi so {i} la ky tu: {c, 3}");
            }
            */


            //cach 3
            //dung foreach
            /*
             foreach (var kytu in thongbao)
             {
                Console.WriteLine(kytu);
             }
             */



            //Phuong thuc cat bo khoang trang
            string thongbao = "     DoanhChau, xin chao!     ";
            thongbao = thongbao.Trim();
            //TrimStar(): cat di khoang trang dau
            //TrimEnd(): cat di khoang trang cuoi
            Console.WriteLine(thongbao);



            //Tra ve chuoi in hoa
            string thongbao = "DoanhChau, xin chao!";
            Console.WriteLine(thongbao.ToUpper());


            //Tra ve chuoi in thuong
            string thongbao = "DoanhChau, xin chao!";
            Console.WriteLine(thongbao.ToLower());


            //Phuong thuc tim kiem, thay the
            string thongbao = "DoanhChau, xin chao!";
            thongbao = thongbao.Replace("xin chao", "chao mung");
            Console.WriteLine(thongbao);


            //Phuong thuc chen
            string thongbao = "DoanhChau, xin chao!";
            thongbao = thongbao.Insert(10, " 2020");
            Console.WriteLine(thongbao);


            //Phuong thuc lay chuoi con trong chuoi ban dau
            string thongbao = "DoanhChau, xin chao!";
            thongbao = thongbao.Substring(12);
            //HOAC thong bao = thongbao.Substring(12); de lay ra ky tu thu 3
            Console.WriteLine(thongbao);



            //Phuong thuc xoa chuoi con trong chuoi ban dau
            string thongbao = "DoanhChau, xin chao!";
            thongbao = thongbao.Remove(10); //chi lay cac chi so truoc ky tu 10
            //HOAC thong bao = thongbao.Remve(10, 5); //xoa 5 ky tu tu ky tu thu 10
            Console.WriteLine(thongbao);

    }
}

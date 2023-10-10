using System;
using System.Reflection.Metadata.Ecma335;

namespace CS10
{
    /*
    <Access Modifier> class Class_name
    {
        //Khai bao cac thanh vien du lieu (thuoc tinh, bien truong, ...)
        //Khai bao cac thanh vien ham (phuong thuc)
    }
    */

    class Vukhi
    {
        //Du lieu
        public string name = "Ten vu khi";
        int dosatthuong = 0;



        //Thuoc tinh
        public int Satthuong
        {
            //phep gan
            set
            {
                //Cac lenh...
                //Console.WriteLine("SET");
                dosatthuong = value;
            }

            //truy cap...
            get
            {
                return dosatthuong;
            }

            //cach 2
            //public string Noisanxuat { set; get; }
        }





        //Phuong thuc khoi tao
        public Vukhi()
        {
            //Console.WriteLine("Khoi tao");
            dosatthuong = 1;
        }

        public Vukhi (string name, int _dosatthuong)
        {
            dosatthuong = _dosatthuong;
            this.name = name;
        }



        //Phuong thuc
        public void ThietlapSatthuong(int dosatthuong)
        {
            this.dosatthuong = dosatthuong;

            //this - tham chieu den doi tuong lop hien tai

            //Vukhi abc;
            //abc = this;
        }
        public void Tancong()
        {
            Console.Write(name + ":\t");

            //dung vong lap for de neu ten vu khi, do sat thuong
            for (int i = 0; i < dosatthuong; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}

using System;
using System.Net.Http.Headers;

namespace CS10
{
    class Program
    {
        static void Main(string[] args )
        {
            Vukhi sungluc; //gia tri mac dinh: NULL
            sungluc = new Vukhi();
            sungluc.name = "Sung luc";
            sungluc.ThietlapSatthuong(5);
            //sungluc.Satthuong = 10;
            Console.WriteLine(sungluc.Satthuong);

            //cach 2
            //sungluc.Noisanxuat = "My";
            //Console.WriteLine(sungluc.Noisanxuat);


            Vukhi sungmay = new Vukhi("Sung may", 15);
            sungluc.Tancong();
            sungmay.Tancong();
        }
    }





    //Phuong thuc huy de giai phong bo nho
    //1 lop chi duoc khai bao 1 phuong thuc huy va duoc thuc thi khi doi tuong bi huy, bi thu hoi boi .NET
    class Student : IDisposable //de quan ly qua trinh thu hoi
    {
        public string name;
        public Student(string name)
        {
            this.name = name;
            Console.WriteLine("Khoi tao" + name);
        }
        ~Student() //phuong thuc huy
        {
            Console.WriteLine("Huy" + name);
        }
        static void Main(string[] args)
        {
            Student student;

            //dung for de tao ra 1000 doi tuong sinh vien
            for(int i = 0; i < 1000; i++)
            {
                student = new Student("Sinh vien" + i);
                student = null;
            }
            student = new Student("Sinh vien 1");
            student = null; //k con tham chieu den doi tuong dong 44

            GC.Collect(); /*phuong thuc huy cua .NET Framework*/
        }






        //Cach su dung IDisposable
        //static void Main(string[] args)
        //{
        //    using Student a = new Student("AAA");
        //    using (Student s = new Student("Ten sinh vien"))
        //    {
        //        // ...
        //    }
        //}
        public void Dispose()
        {
            Console.WriteLine("Huy (boi dispose)" + name);
        }
    }
}

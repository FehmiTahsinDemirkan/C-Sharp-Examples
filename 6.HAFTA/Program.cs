using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.HAFTA
{
    class Ogrenci
    {
        public String Adi { get; set; }
        public int Yas { get; set; }
        public  void Yaz()
        {
            Console.WriteLine(Yas);
        }
        public void YasBelirle(int Yas)
        {
            if (Yas<=0)
            {
                while (Yas<=0)
                {
                    Console.WriteLine("Yaşınızı girin");
                    Yas = Convert.ToInt32(Console.ReadLine());
                }
                this.Yas = Yas;
            }
            else
            {
                this.Yas = Yas;      
            }
        }
    }
    class Akademik
    {
        public int Yas { get; set; }
        public int mYas {
            get {
               return  Yas;

            }
            set {
                if (value<=0)
                {
                    Yas = 1;
                }
                else
                {
                    Yas = value;
                }
               
            }
        }public void Yaz()
        {
            Console.WriteLine(Yas);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //***
            //Ogrenci ogrenci = new Ogrenci();
            //ogrenci.Adi = "fehmi";

            //ogrenci.YasBelirle(-5);
            //ogrenci.Yaz();
            //Console.ReadLine();
            //***
            Akademik akademik = new Akademik();
            akademik.mYas = -16;
            Console.WriteLine(akademik.mYas);
           
           // akademik.Yaz();
            Console.ReadLine();
        }
    }
}

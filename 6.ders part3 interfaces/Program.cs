using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ders_part3_interfaces
{
    internal class Program
    {
        enum Cinsiyet
        {
            Erkek
        }
        interface IKisi
        {
            public string Adi { get; set; }
            int Yas { get; set; }
            void Yaz();
            
        }
        class Canli
        {
            public int Cinsiyet cinsiyeti { get; set; }
        }
    class Ogrenci:Ikisi
    {

    }
    public void Yaz()
    {

    }
    class Akademik:
    {

    }
        static void Main(string[] args)
        {

        }
    }
}

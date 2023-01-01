using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.hafta_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            Araba araba = new Araba() { Adi = "Volvo", Fiyat = 300 };
        }
    }
    class Araba
    {
        public string Adi { get; set; }
        public int Fiyat { get; set; }
    }

}
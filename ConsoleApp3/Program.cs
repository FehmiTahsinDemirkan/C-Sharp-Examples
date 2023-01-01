using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //1. Doğrusal Arama (Lineer Search) Algoritması
   /*
      Listedeki tüm elemanlar sırasıyla taranır.
    Aranan eleman bulunduğunda algoritma sonlanır.
    Eleman sayısı fazla olan listelerde bu algoritmayı kullanmak performans açısından verimsizdir
     Listedeki tüm elemanlara sırasıyla bakıldığından listenin sıralı olması gerekli değildir. 
      
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] liste = { 9, 7, 1, 3, 6, 2 };
            int aranan = 3;
            int indis = dogrusalArama(liste, aranan);
            if (indis == -1)
                Console.Write("Eleman bulunamadı!");
            else
                Console.Write("Elemanın indisi: " + indis);
            Console.ReadKey();
        }
        public static int dogrusalArama(int[] dizi, int aranan)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == aranan)
                    return i;
            }
            return -1;
        }
    }
}


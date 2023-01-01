using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeTekrarpart4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //******KABUK SIRALAMA(SHELL SORT)******
            /*Bu algoritmada karşılaştırma işlemi belirlenmiş olan atlama sırasına göre daha uzaktaki elemanların 
                karşılaştırılması esasına dayanır.
            *Başlangıçta atlama sayısı eleman sayısının yarısı alınarak hesaplanır.
Atlama sayısı her çevrimde (her geçişte) bir önceki atlama sayısının yarısı olacak şekilde hesaplanır.
Son geçişte atlama sayısı daima 1’dir. Çok sık kullanılan bir algoritmadır.
             
             */
            int[] sayilar = { 6, 9, 5, 7, 3, 4, 2, 1, 8 };
            diziYaz(sayilar);
            kabukSiralama(sayilar);
            diziYaz(sayilar);
            Console.ReadKey ();
        }
        public static void kabukSiralama(int[] dizi)
        {
            int  j, atlama, gecici;
            atlama = dizi.Length / 2;
            while (atlama>0)
            {
                for (int i = 0; i < dizi.Length; i++)
                {
                    j = i;
                    gecici = dizi[i];
                    while (j >= atlama && dizi[j-atlama]>gecici)
                    
                    {
                        dizi[j] = gecici;
                    }
                    if (atlama / 2 != 0)
                        atlama = 0;
                    else if (atlama == 1)
                        atlama = 0;
                    else
                        atlama = 1;
                }
            }
        }
        public static void diziYaz(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]+"");
                Console.WriteLine();
            }
        }
    }
}

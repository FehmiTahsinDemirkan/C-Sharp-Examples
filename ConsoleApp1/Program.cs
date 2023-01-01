using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace VizeTekrarPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) Seçmeli Sıralama (Selection Sort) Algoritması
            //Seçmeli sıralama algoritması listeden sırasıyla en küçük elemanın seçilerek yerine koyulması esasına dayanır.
            //Bu algoritma başlangıçta listenin ilk elemanını en küçük değer olarak kabul ede
            int[] sayilar = { 10, 8, 3, 5, 7 };
            diziYaz(sayilar);
            SecmeliSirala(sayilar);
            diziYaz(sayilar);
            Console.ReadKey();
            

        }
        public static void SecmeliSirala(int[] dizi)
        {
            int gecici, kucukIndex  ;
            for (int i = 0; i < dizi.Length; i++)
            {
                kucukIndex = i;
                for (int j = i; j < dizi.Length; j++)
                {
                    if (dizi[j] < dizi[kucukIndex])
                    {
                        kucukIndex = j;
                    }
                    gecici = dizi[i];
                    dizi[i] = dizi[kucukIndex];
                    dizi[kucukIndex] = gecici;
                }
            }

        } 
                public static void diziYaz(int[] dizi)
                 {
            Console.WriteLine("*********");
            foreach (var item in dizi)
            {
                Console.WriteLine(item);

            }
                     }
            }
        }
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeTekrar_part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //***********RANDOM SAYI ÜRETME******** 
            ////1) Next metodu aşağıdaki gibi kullanılırsa negatif olmayan rastgele sayılar üretir.
            //Random RasgeleSayi = new Random();
            //Console.WriteLine(RasgeleSayi.Next());
            ////2) Parantez içerisindeki sayı üst sınır olmak üzere (üst sınır hariç) negatif olmayan sayı üretir
            //Console.WriteLine(RasgeleSayi.Next(30));
            ////3) Parantez içerisinde alt ve üst sınır parametre olarak girilir.Alt sınır dahil, üst sınır hariç olacak şekilde negatif olmayan sayılar üretir.
            //Console.WriteLine(RasgeleSayi.Next(5,15));

            //********* KABARCIK SIRALAMA ***********

     

                int[] dizi = { 6, 12, 24, 3, 8, 4 };
                kabarcikSirala(dizi);
                diziYazdir(dizi);
            }

            public static void kabarcikSirala(int[] siralanacakDizi)
            {

                int i = 1, j, deger;
                int diziAdet = siralanacakDizi.Length;
                while (i < diziAdet)
                {
                    j = diziAdet - 1;
                    while (j >= 1)
                    {
                        if (siralanacakDizi[j - 1] > siralanacakDizi[j])
                        {
                            deger = siralanacakDizi[j];
                            siralanacakDizi[j] = siralanacakDizi[j - 1];
                            siralanacakDizi[j - 1] = deger;
                        }
                        j--;
                    }
                    i++;
                }
            }

            public static void diziYazdir(int[] dizi)
            {

                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.WriteLine(dizi[i]);
                }
                Console.ReadKey();
            }
        }
    }
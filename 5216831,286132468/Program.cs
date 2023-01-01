using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3. Ara Değer Arama (Interpolation Search) Algoritması 
//Sıralı listelerde arama yapan bir algoritmadır. İkili arama algoritması ile aynı mantıkta çalışır. Tek farkı orta eleman değerinin aşağıdaki formüle göre hesaplanmasıdır.
/*
 * orta = ilkIndex +
((aranan − dizi[ilkIndex]) * (sonIndex − ilkIndex))
(dizi[sonIndex] − dizi[ilkIndex])
Örnek: Liste = {2, 3, 5, 8, 11, 15, 18, 22, 25, 30} listesi ve aranan değerimiz 22 olsu
 * */

namespace _5216831_286132468
{
    class Program
    {
        public static int aradaDegerArama(int[] dizi, int aranan)
        {
            int ilkIndex = 0;
            int sonIndex = dizi.Length - 1;
            int orta;
            while (ilkIndex <= sonIndex)
            {
                orta = ilkIndex + ((aranan - dizi[ilkIndex]) * (sonIndex - ilkIndex)) /
               (dizi[sonIndex] - dizi[ilkIndex]);
                if (orta >= dizi.Length || orta < 0)
                    return -1;
                else if (dizi[orta] > aranan)
                    sonIndex = orta - 1;
                else if (dizi[orta] < aranan)
                    ilkIndex = orta + 1;
                else
                    return orta;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] liste = { 2, 3, 5, 8, 11, 15, 18, 22, 25, 30 };
            int aranan = 22;
            int index = aradaDegerArama(liste, aranan);
            if (index == -1)
                Console.WriteLine("Aranan değer bulunamadı!");
            else
                Console.WriteLine("Aranan elemanın index değeri: " + index);
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//İKİLİ ARAMA(BİNARY SEARH) ALGORİTMASI
/*İkili arama algoritması sıralı listeler üzerinde çalışmaktadır. Aranan eleman dizinin ortasındaki 
eleman ile karşılaştırılır.Ortadaki eleman ile aranan eleman eşitse algoritma sonlandırılır.*/
/*
 * A.Aranan eleman, ortadaki elemandan küçükse listenin sol tarafı dikkate alınır.
 * B. Aranan eleman, ortadaki elemandan büyükse listenin sağ tarafı dikkate alınır.

 */
namespace ConsoleApp4asfasf
{
    class Program
    {
        public static int ikiliArama(int[] dizi, int aranan)
        {
            int ilkIndex = 0;
            int sonIndex = dizi.Length - 1;
            int orta;
            while (ilkIndex <= sonIndex)
            {
                orta = (ilkIndex + sonIndex) / 2;
                if (dizi[orta] > aranan)
                    sonIndex = orta - 1;
                else if (dizi[orta] < aranan)
                    ilkIndex = orta + 1;
                else
                    return orta;
            }
            return -5;
        }
        static void Main(string[] args)
        {
            int[] liste = { 2, 5, 6, 8, 10, 15, 17, 18, 20, 25, 30 };
            int aranan = 25;
            int index = ikiliArama(liste, aranan);
            if (index == -5)
                Console.WriteLine("Aranan değer bulunamadı!");
            else
                Console.WriteLine("Aranan elemanın index değeri: " + index);
            Console.ReadKey();
        }
    }

}

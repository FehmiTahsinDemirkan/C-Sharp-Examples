using System;


/*1. Doğrusal Arama (Lineer Search) Algoritması 
Listedeki tüm elemanlar sırasıyla taranır. Aranan eleman bulunduğunda algoritma sonlanır. Eleman 
sayısı fazla olan listelerde bu algoritmayı kullanmak performans açısından verimsizdir. Listedeki tüm 
elemanlara sırasıyla bakıldığından listenin sıralı olması gerekli değildir*/
namespace LineerSearch_Vize1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[] {5,5,7,1,3,7,6,2 };
            int aranan = 3;
            int indis = linearSearch(dizi, aranan);
            Console.WriteLine(indis);
            Console.ReadLine();
        }
        public static int linearSearch(int[]dizi,int aranan)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i]==aranan)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

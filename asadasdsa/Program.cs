using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeTekrar_part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              3) Eklemeli Sıralama (Insertion Sort) Algoritması 
 Basit bir algoritma mantığı olan eklemeli sıralama algoritması verimsiz bir sıralama yöntemidir. 
Çalışma mantığı olarak listenin ikinci elemanı ile ilk elemanı birinci adımda karşılaştırılır. Gerekli ise 
yer değişikliği yapılır. Bir sonraki adımda ise listenin üçüncü elemanı ile kendinden önceki elemanlar 
tek tek karşılaştırılır ve gerekli ise yer değişikliği yapılır. Bu işlem son elemana kadar aynen tekrar 
edilir. Eklemeli sıralama algoritması büyük veritabanlarında tercih edilen bir yaklaşım değildir.

             */
            int[] sayilar = { 2, 5, 5, 8, 10, 7, 4, 12, 9 };
            diziYaz(sayilar);
            eklemeliSiralama(sayilar);
            diziYaz(sayilar);
            Console.ReadKey();
        }
        public static void eklemeliSiralama(int[] dizi)
        {
            int  j, ilkDeger;
            for (int i = 1; i < dizi.Length; i++)
            {
                ilkDeger = dizi[i];
                j = i;
                while (j>0 && dizi[j-1]>ilkDeger)
                {
                    dizi[j] = dizi[j - 1];
                    j--;
                }
                dizi[j] = ilkDeger;
            }
        }
        public static void diziYaz(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]+"");
                
            }
        }
    }
}

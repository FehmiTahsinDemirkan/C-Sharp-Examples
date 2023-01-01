using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
//********* KABARCIK SIRALAMA ***********
/*Her defasında listenin iki elemanını karşılaştırarak gerekliyse yer değişikliği yapılır. Bu işlem hiçbir 
yer değişikliği yapılmadığı ana kadar devam eder. Her geçişte en büyük sayı listenin en sağına 
aktarılmış olur. Kabarcık sıralaması algoritmasında yapılan işlem listeyi küçükten büyüğe doğru 
sıralamaktır*/
namespace YazOkuluVize2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 45, 7, 78, 99, 22, 11 };
            dizi = DiziSirala(dizi);
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
        public static int[] DiziSirala(int[] dizi)
        {
            int tmp;
            bool sirali;
            for (int i = 1; i < dizi.Length; i++)
            {
                sirali = true;
                for (int j = 0; j < dizi.Length-i; j++)
                {
                    if (dizi[j] < dizi[j+1])
                    {
                        sirali = false;
                        tmp = dizi[j];
                        dizi[j] = dizi[j+1];
                        dizi[j + 1] = tmp;
                    }
                }
                if (sirali)
                {
                    break;
                }
            }
            return dizi;
        }

    }
}

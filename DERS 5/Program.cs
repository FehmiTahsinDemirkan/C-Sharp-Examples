using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            Random rand = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rand.Next(0, 100);
            }
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
             
            }
            for (int j = 1; j < dizi.Length; j++)
            {
                bool sirali = true;
                int tmp = 0;
                for (int k = 0; k < dizi.Length - j; k++)
                {
                    if (dizi[k] > dizi[k + 1])
                    {
                        tmp = dizi[k];
                        dizi[k] = dizi[k + 1];
                        dizi[k + 1] = tmp;
                        sirali = false;
                    }

                }
                if (sirali)
                {
                    break;
                }
            }
                Console.WriteLine("********");
                foreach (var item in dizi)
                {
                    Console.WriteLine(item);
                    
                }
                Console.ReadLine();
            }   
        }


}



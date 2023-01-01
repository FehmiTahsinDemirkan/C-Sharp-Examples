using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iki_boyutlu_dizi_Vize_4
{
     class Program
    {
        static void Main(string[] args)
        {
            Random rasgele = new Random();
            int[,] cokboyutluDizi = new int[4, 4];
            for (int i = 0; i <= cokboyutluDizi.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= cokboyutluDizi.GetUpperBound(1); j++)
                {
                    cokboyutluDizi[i, j] = rasgele.Next(0, 100);
                    Console.Write(cokboyutluDizi[i,j] + " ");

                }
                Console.WriteLine();
                
            }
            Console.ReadLine();
        }
    }
}

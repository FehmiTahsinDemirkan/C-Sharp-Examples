using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders9_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dizi     {2,5,6,8,10,15,17,18,20,25,30} sıralı
            //İndisleri{0,1,2,3, 4, 5, 6, 7, 8, 9,10}
            //Dizi     {17,18,20,25,30}
            //İndisleri{0 ,1,  2, 3, 4}
            int xx = 9;
            Console.WriteLine(xx / 2);
            int[] dizi = new int[100];

            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                if (i == 50)
                {
                    dizi[i] = 150;
                    continue;
                }
                dizi[i] = random.Next(1, 1000);

            }

            int[] siralidizi = DiziSirala(dizi);
            int yy = 0;
            foreach (var item in siralidizi)
            {
                Console.WriteLine(yy + ":" + item);
                yy++;

            }

            int indis = ArananSayiIndex(siralidizi, 150);
            Console.WriteLine(indis);

            Console.ReadLine();
        }

        static int ArananSayiIndex(int[] siralidizi, int aranandeger)
        {
            int ilkindex = 0;
            int sonindex = siralidizi.Length - 1;
            int ortaindex;
            while (ilkindex <= sonindex)
            {
                ortaindex = (ilkindex + sonindex) / 2;

                if (siralidizi[ortaindex] > aranandeger)
                {
                    sonindex = ortaindex - 1;
                }
                else if (siralidizi[ortaindex] < aranandeger)
                {
                    ilkindex = ortaindex + 1;

                }
                else
                {
                    return ortaindex;

                }


            }
            return -1;


        }



        static int[] DiziSirala(int[] dizi)
        {
            //kabarcık sıralama
            int tmp;
            Console.WriteLine("*****");
            int dongusayisi = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                for (int xx = i; xx < dizi.Length; xx++)
                {
                    if (dizi[i] > dizi[xx])
                    {
                        tmp = dizi[i];
                        dizi[i] = dizi[xx];
                        dizi[xx] = tmp;
                    }
                    dongusayisi++;

                }

            }
            return dizi;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DİZİ TANIMLAMA TÜRLERİ
            //1. YOL (5 elemanlı dizi tanımı)
            int[] dizi1;
            dizi1 = new int[5];
            //2. YOL (5 elemanlı dizi tanımı)
            int[] dizi2= new int[5];
            //3. YOL (5 elemanlı dizi tanımı)
            int[] dizi3 = {1,2,3,4,5};
            Console.WriteLine(dizi1.Length);
            Console.WriteLine(dizi2[0]);
            Console.WriteLine(dizi3[1]);
            Console.WriteLine("*******");
            int j=0;
            for (int i = 10; i < 5; i--)
            {
                dizi1[j] = i;
                j++;
            }
            float[] dizi4 = new float[5];
            float[] dizi5 = { 1f, 2f, 3f };
            string[] dizi6 = { "fehmi", "melih", "vahid" };
            char[] dizi7 = { 'A', 'B' };
            Console.WriteLine(dizi5[1]);
            Console.WriteLine(dizi6[1]);
            Console.WriteLine(dizi7[0]);
            Console.WriteLine("*******");
            //RASGELE ÜRETİLEN SAYI İLE DİZİ 
            Random rnd = new Random();
            Console.WriteLine("Rasgele üretilen bir sayı: ");
            Console.WriteLine(rnd.Next(1,100));
            int[] sinif = {1,2,3,4,5 };
            for (int i = 0; i < 5; i++)
            {
                sinif[i] = rnd.Next(1, 10);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i+".Sınıf");
                for (int x = 0; x < sinif[i]; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //ÇOK BOYUTLU DİZİ OLUŞTURMA
            Console.WriteLine("x**********x");
            //1.YOL (2 boyutlu dizi)
            int[,] dizi8;
            dizi8 = new int[5, 8];
            //2.YOL (3 boyutlu dizi)
            int[,,] dizi9 = new int[1, 5, 7];
            //3.YOL (2 boyutlu dizi)
            int[,] dizi10 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Console.WriteLine(dizi8[1,1]);
            Console.WriteLine(dizi9);
            Console.WriteLine(dizi10[1,1]);

            //DÜZENSİZ DİZİLER
            int[][]dizi11=new int[3][];
            dizi11[0] = new int[3];
            dizi11[1] = new int[2];
            dizi11[2] = new int[1];
            dizi11[0][0] = 0;
            dizi11[0][1] = 1;
            dizi11[0][2] = 2;

            dizi11[1][0] = 3;
            dizi11[1][1] = 4;

            dizi11[2][0] = 5;
            Console.WriteLine(dizi11);
            Console.WriteLine("*****");
            //jagged array 2.yol

            int[][] dizi12 = new int[3][];
            dizi12[0] = new int[] { 1, 2, 3, 4 };
            dizi12[1] = new int[] { 1, 2 };
            dizi12[2] = new int[] { 3, 66, 77 };
           
            Console.WriteLine(dizi12.GetLength(0));//3
            Console.WriteLine(dizi12.GetUpperBound(0));//2
            Console.WriteLine(dizi12[0].GetLength(0));//4
            Console.WriteLine(dizi12[1].GetLength(0));//2
            Console.WriteLine("**********");
            for (int yy = 0; yy < dizi12.GetLength(0); yy++)
            {
                for (int xx = 0; xx <= dizi12[yy].GetUpperBound(0) ; xx++)
                {
                    Console.WriteLine(dizi12[yy][xx]+";");
                }
                Console.WriteLine();

            }
            Console.WriteLine("*****");
            int[] dizi14 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                dizi14[i] = rnd.Next(1, 100);
            }
            foreach (var item in dizi14) {
                Console.WriteLine(item);

            }  
            Console.WriteLine("*****");
            //kabarcık sıralama
            int tmp;
         
            int dongusayisi = 0;
            for (int i = 0; i < dizi14.Length; i++)
            {
                for (int xx = i; xx < dizi14.Length; xx++)
                {
                    if (dizi14[i] > dizi14[xx])
                    {
                        tmp = dizi14[i];
                        dizi14[i] = dizi14[xx];
                        dizi14[xx] = tmp;
                    }
                    dongusayisi++;

                }

            }
            Console.WriteLine("Dongu sayisi" + dongusayisi);
            Array.Sort(dizi14);
            Console.WriteLine("xxxxxxxxxxxxxxx");
            foreach (var item in dizi14)
            {
                Console.WriteLine(item);
            }
            var deger = 15;
            deger = 'A';

            var deger2 = "serdar";
            Type tip = deger2.GetType();
            Console.WriteLine(tip);


            Array dizi15 = Array.CreateInstance(typeof(int), 4);
            foreach (var item in dizi15)
            {
                Console.WriteLine(item);

            }

            Array dizi16 = Array.CreateInstance(typeof(int), 2, 3, 4);

            //Copy(dizi1,dizi2,uzunluk) setvalue indextesi degeri set eder
            //getvalue
            Console.WriteLine("xXxXxXxX");
            int indeks = Array.BinarySearch(dizi3, 4);

            Console.WriteLine(indeks);


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3_Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //aritmetik operatorler + - * /
            //işlem önceliği parantez içleri,üstler, ç, b,t,ç

            float sonuc = 3 * 5 / 2f + 1 - 2;
            Console.WriteLine(sonuc);
            //karşılaştırma

            //karşılaştırma operatörleri
            //==,=!,<,>,>=,<=

            Console.WriteLine(1 == 4);

            //mantıksal operatörler
            // || veya , && ve oeratörü !

            Console.WriteLine(!(1 == 1) && ("a" == "a"));
            Console.WriteLine(!(1 == 4) || ("s" == "a"));

            //mod % artırma++ eksiltme --

            int x = 1;
            x = x + 1;
            x++;//x = x + 1

            Console.WriteLine("x+1: " + (x + 1));//atama yok sadece bir fazlasını yazdık
            Console.WriteLine("x++: " + x++);
            Console.WriteLine("x: " + x);
            Console.WriteLine("{1} {0}", ++x, "++x:");
            //as operatörü uygun türler arası dönüşüm yapar
            Console.WriteLine("*********");
            object i = "serdar", j = 5;
            object xxx = new object();
            Console.WriteLine("objenin türü: " + xxx.GetType());
            Console.WriteLine(i.GetType());
            Console.WriteLine(j.GetType());

            j = (int)j + 5; //UnBoxing

            Console.WriteLine(j.GetType());
            string metin = i as string;
            string metin2 = (string)i;
            string metin3 = Convert.ToString(i);
            string metin4 = i.ToString();

            Console.WriteLine(metin);
            Console.WriteLine(metin2);
            Console.WriteLine(metin3);
            Console.WriteLine(metin4);
            //is operatörü dönüşümün durumunu bool verir
            string s1 = "serdar";

            bool sonuc1 = s1 is int;
            Console.WriteLine("s1 dönüştürülemez mi?:" + sonuc1);

            //bitsel operatörler
            //& lojik and | lojik or ~  lojik not << sola kaydırma

            int sayi2 =3;
            sayi2 = sayi2 << 1;
            Console.WriteLine(sayi2);


            sbyte sb1 = -6;
            sb1 = (sbyte)(sb1 << 1);
            Console.WriteLine(sb1);
            // ternary operatörü

            int kalemsayisi;
            Console.WriteLine("kalem sayisini girin");
            kalemsayisi = Convert.ToInt32(Console.ReadLine());
            string str = "kalem";
            str = str + (kalemsayisi == 1 ? " " : "ler");
            Console.WriteLine(str);

            Type tip1 = typeof(Program);
            Program deneme = new Program();
            Type tip2 = deneme.GetType();

            Type tip3 = typeof(string);
            Console.WriteLine(tip3.ToString());

            string xyz = "serdar";

            Type xyznintipi = xyz.GetType();
            Console.WriteLine(xyznintipi);
            Console.WriteLine(xyz.GetType());


            Console.WriteLine(tip1.ToString());
            Console.WriteLine(tip2.ToString());


            Console.ReadLine();




        }
    }
}

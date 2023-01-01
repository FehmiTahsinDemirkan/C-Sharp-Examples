using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_5_soru_2
{
    enum hesapturu
    {
        TL, Euro, Dolar, Pound
    }
    class Program
    {
        static void Main(string[] args)
        {
            //1.yol
            KrediHesabı krediHesabi = new KrediHesabı();
            krediHesabi.HesapNo = 1;
            krediHesabi.Hesapturu = hesapturu.TL;
            krediHesabi.KartSahibi = "fehmi";

            krediHesabi.Gercekkisi = new GercekKisi();
            krediHesabi.Gercekkisi.Adi = "fehmi";
            krediHesabi.Gercekkisi.Soyadi = "Demirkan";
            krediHesabi.Gercekkisi.Yas = 19;
        }
        //2.yol
        //KrediHesabı krediHesabı2 = new KrediHesabı();
        //KrediHesabı2.HesapNo=2;
        class GercekKisi
        {
            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public int Yas { get; set; }
        }
    }
}
    


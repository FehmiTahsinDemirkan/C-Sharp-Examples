using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_5_soru_2
{
     class KrediHesabı
    {
        //field
        public ulong HesapNo;
        public double Limit;
        public string KartSahibi;
        public GercekKisi Gercekkisi;

        //property
        public int MyProperty { get; set; }
        public hesapturu Hesapturu { get; set; }
    }
}

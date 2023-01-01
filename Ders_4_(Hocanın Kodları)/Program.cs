using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders4_Kosullar
{
    class Program
    {
        enum CalisanTuru
        {
            Isci, Müdür, Aşcı, Hademe
        }

        static void Main(string[] args)
        {
            //İF ELSE ELSEİF SWİTCH CASE KULLANIMI
            int x = 8;

            if (x==8)
            {
                x++;
                Console.WriteLine("x 8 e eşittir !!!");
                
               
            }
            Console.WriteLine(x); //X in yeni değeri
            Console.WriteLine("-----------");
            x++;
            
            if (x==9)
            {
                Console.WriteLine(x);
                x++;
               
            }
            else if (x==10)
            {
                Console.WriteLine("x 10 a eşittir");
            }
            else
            {
                Console.WriteLine("Babayı Gördünmü");
            }
            Console.WriteLine("---------------");
            Console.WriteLine("Gün ismi girin");
            int gun = 1;
            string gunbasharfi;
            gunbasharfi = Console.ReadLine();
            
            switch (gunbasharfi)
            {
                case "pazartesi":
                    Console.WriteLine("Pazartesi");
                    Console.WriteLine("1");
                
                    break;
                case "salı":
                    Console.WriteLine("Salı");
                    Console.WriteLine("2");
                    break;
                case "çarşamba":
                    Console.WriteLine("çarşamba");
                    Console.WriteLine("3");
                    break;
                case "perşembe":
                    Console.WriteLine("perşembe");
                    Console.WriteLine("4");
                    break;
                case "cuma":
                    Console.WriteLine("cuma");
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("default geldi");
                    break ;
                    
            }
            CalisanTuru calisan = CalisanTuru.Aşcı;
            Console.WriteLine(calisan);
            switch (calisan)
            {
                case CalisanTuru.Aşcı:
                    Console.WriteLine("aşcı geldi");
                    break;
                case CalisanTuru.Müdür:
                    Console.WriteLine("aşcı müdür");
                    break;
                case CalisanTuru.Isci:
                    Console.WriteLine("işci geldi");
                    break;
                    default :
                    Console.WriteLine("kimse gelmedi");
                    break;

            }
            Console.ReadLine();
        }

        
    }
    
}
    
                
     
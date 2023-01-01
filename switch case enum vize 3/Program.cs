using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_enum_vize_3
{
    internal class Program
    {
        enum Gunler
        {
            Pazartesi,Sali,Carsamba,Persembe,Cuma,Cumartesi,Pazar
        }
        static void Main(string[] args)
        {
            Gunler gunler = Gunler.Pazar;
            switch (gunler)
            {
                case Gunler.Pazartesi:
                    Console.WriteLine("Bugün günlerden Pazartesi");
                    break;
                case Gunler.Sali:
                    Console.WriteLine("Bugün günlerden sali");
                    break;
                case Gunler.Carsamba:
                    Console.WriteLine("Bugün günlerden carsamba");
                    break;
                case Gunler.Persembe:
                    Console.WriteLine("Bugün günlerden perşembe");
                    break;
                case Gunler.Cuma:
                    Console.WriteLine("Bugün günlerden cuma");
                    break;
                case Gunler.Cumartesi:
                    Console.WriteLine("Bugün günlerden cumartesi");
                    break;
               default:
                    Console.WriteLine("Bugün günlerden pazar");
                    break;
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_5__Hocanın_Kodları_
{
     class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i <= 20; i+=1)
            {
                if (i==7)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("********");
            for (int i = 0; i <= 20; i+=2)
            {
                Console.WriteLine(i);
                
            }
            Console.WriteLine("***");
            int k;
            for ( k = 1; k < 20; k=k+2)
            {
                Console.WriteLine("Next Number: ");
                Console.WriteLine(k);
                if (k==15)
                {
                    break;

                }
                
            }
            Console.WriteLine("Loop End + " + k);
            Console.WriteLine("---------");
            int y = 11;
            while (y>0)
            {
                y -= 1;
                if (y == 5)
                {
                    continue;
                }
                if(y==3)
                {
                    break;
                }
                Console.WriteLine(y);
            }
            //SONSUZ DÖNGÜ
            string supra = "SUPRA AAA";
            do
            {
                Console.WriteLine(supra);
            } while (supra.Length<10);
               

            Console.ReadLine();
        }
        
    }
    
}

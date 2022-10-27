using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(String[] args)
        {
            string[,] regions = new string[5, 3]
            {
                {"istanbul","izmit","balıkesir" },
                {"ankara","konya","kırıkkale" },
                {"rize","trabzon","samsun" },
                {"izmir","antalya","niğde" },
                {"adana","zonguldak","muğla" }
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("***********");
            }
        }
    }
}
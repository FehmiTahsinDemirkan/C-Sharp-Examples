using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Programn 
    {
        static void Main(String[] args)
        {

            //int number = 100;
            //while (number>=0)
            //{
            //    Console.WriteLine(number);
            //}
            //string[] students = new string[3] { "fehmi", "melih", "oktay" };
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //int number = 31;
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //while (number>0);
            if (IsPrimeNumber(10))
            {
                Console.WriteLine("This is a prime number");

            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

                Console.ReadLine();
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(i);
               
            //}
            //Console.WriteLine("Finished !!!");
             
        }
        private static bool IsPrimeNumber(int number)
            {
                bool result = true;
                for (int i = 2; i < number-1; i++)
                {
                if (number % i == 0)
                    
                    {
                        result = false;
                        i = number;
                    }
                }
            return result;
            }
       
    }
}
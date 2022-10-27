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
            String city = "Rize";
            // Console.WriteLine(city[0]);
            foreach (var item in city)
                
            {
                Console.WriteLine(item);
            }
            string city2 = "istanbul";
            //string result = city + city2;
            //Console.WriteLine(result);
            Console.WriteLine(string.Format("{0} {1}",city2,city));

            string sentence = "my name is fehmi";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "my name is tahsin";
            bool result3=sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("my name");
            var result5 = sentence.IndexOf("name");
            var result6 = sentence.LastIndexOf("");
            var result7 = sentence.Insert(0,"hello ");
            var result8=sentence.Substring(3,4);
            var result9 = sentence.ToUpper();
            var result13 = sentence.Remove(2);
        
            //var result10 = sentence.Replace("", "");
            
           
           Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
             Console.WriteLine(result5);
            Console.WriteLine("******");
            Console.WriteLine( result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result13);
           // Console.WriteLine(result10);
            Console.ReadLine();
        }
    }
}
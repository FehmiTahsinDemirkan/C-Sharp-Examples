using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constracture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count = 34;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items ", _count);
        }
        public CustomerManager(){
            }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }
}

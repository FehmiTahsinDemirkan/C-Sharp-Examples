using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager();
            customerManager.Logger=new SmsLogger();
            customerManager.Add();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {

            Logger.Log();
            Console.WriteLine("Customer Added ! ");
        }
    }
    class DataBaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to DataBase ! ");
        }
    }
    class FileLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Loggod to File");
        }

      
    }
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Loggod to SmS");
        }


    }
    interface ILogger
    {
        void Log();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Iworker[] workers = new Iworker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()

            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            
        }
    }
    interface Iworker
    {
        void Work();

    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : Iworker, ISalary, IEat
    {
        public void Eat()
        {

        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }

        class Worker : Iworker, ISalary, IEat
        {
            public void Eat()
            {

            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }

            class Robot : Iworker
            {
                public void Work()
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}

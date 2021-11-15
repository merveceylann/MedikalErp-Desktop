using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // solid prensiplerinin 4.olan interface segregation prensibidir.
            // Single Responsiblity : Siniflarimizin iyi tanimlanmis tek bir sorumlulugu olmali.
            // Open / Closed : Siniflarimiz degisiklige kapali ancak yeni davranislarin eklenmesine acik olmalidir.
            // Liskov Substitution : Kodunuzda herhangi bir degisiklik yapmaya gerek kalmadan turetilmis siniflari (sub class) turedikleri ata sinifinin (base class) yerine kullanabilmaliyiz.
            // Interface Segregation : Genel kullanim amacli tek bir kontrat yerine daha ozellesmis birden cok kontrat olusturmayi tercih etmeliyiz. 
            // Dependency Inversion : Katmanli mimarilerde ust seviye moduller alt seviyedeki modullere dogrudan bagimli olmamalidir.

            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
        }
    }

    interface IWorker
    {
        void Work();
        void Eat();
        void GetSalary();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}

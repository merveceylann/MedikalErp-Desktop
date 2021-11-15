using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMethod();

            //Polymorphism ornegi
            
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new UseMsSqlServer(),
                new UseOracleServer()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            //yukaridaki ile ayni islem ve daha kisa yol. Fakat newlemeyi unutma.
            CustomerManager cm = new CustomerManager();
            cm.Add(new UseMsSqlServer());
            cm.Add(new UseOracleServer());

            Console.ReadLine();

           

        }

        private static void NewMethod()
        {
            //IPerson person = new IPerson(); //newlenemez cunku havada kalan bir sanal yapi ramde yer tutamiyor.
            //interfaceler new keywordu ile instantname olusturamazlar

            //Customer customer = new Customer { Name = "Merve" };
            //Student student = new Student { Name = "Ceylan" };

            IPerson person = new Customer { Name = "Merve" };
            IPerson person1 = new Student { Name = "Ceylan" };

            //PersonManager pm = new PersonManager();
            //pm.Add(customer);
            //pm.Add(student);

            PersonManager pm = new PersonManager();
            pm.Add(person);
            pm.Add(person1);
        }
    }

    interface IPerson //Soyut nesne
    {
        //public int Id { get; set; } 
        //soyut bir nesne oldugu icin access modifier kullanamayiz.

        int Id { get; set; }
        string Name { get; set; }
        string SurName { get; set; }
    }

    class Customer : IPerson //Somut nesne
    { //somut bir nesneye donusturduk
        public int Id { get ; set ; }
        public string Name { get ; set ; }
        public string SurName { get ; set ; }

        public string Adress { get; set; }
    }
    //implemente ediyoruz. Kolay ve zevkli kismi o :)
    class Student : IPerson
    {
        public int Id { get ; set ; }
        public string Name { get ; set ; }
        public string SurName { get ; set ; }

        public string StudentNo { get ; set ; }
    }

    class PersonManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name);
        }

        public void Add(Student student)
        {
            Console.WriteLine(student.Name);
        }
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Name);
        }
        //ilk ikisini kapatsak da calisir.
    }
}

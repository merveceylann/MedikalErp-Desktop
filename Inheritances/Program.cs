using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances
{
    class Program
    {
        static void Main(string[] args)
        {
            //Miras alınan class da dahil butun classlar kullanilabilir.
            //Her bir class 1 kez miras alabilir.
            //Ayni seyleri tekrar tekrar tanimlamaktansa daha derli toplu oluyor.
            //Ayni ozellikleri bilip onlara gore miras aliyoruz.
            //diger sayfadan da intenal oldugundan miras alabiliriz.
            //private > protected > internal > public

            Player player = new Player();
            //player.Position;
            Coach coach = new Coach
            {
                Id = 1,
                Name = "Merve",
                Surname = "Ceylan",
                CoachPosition = "Head Coach"
            };

            Person person = new Person();
            person.Name = "Busra";

            Console.WriteLine(coach);
            Console.WriteLine(coach.CoachPosition);
            Console.WriteLine(person.Name);
            Console.ReadKey();
        }
    }
    class Person //Base Class
    {
        public int Id { get; set; } //prob tab
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    class Person1
    {
        //iki defa miras kullanılmaz,
        //class Player:Person:Person1
    }
    class Player:Person //Sub Class
    {
        public string Position { get; set; }
    }
    class Coach:Person //Sub Class
    {
        public string CoachPosition { get; set; }
    }
}

using MyNotes.DesignPatterns.Creational.Prototype.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.Prototype
{
    public class Client
    {
        public Client()
        {
            Person martin = new Person();
            martin.Age = 40;
            martin.Name = "Martin";
            martin.Sons = new List<Person>() { new Person { Age = 12, Name = "Santi" } };

            Person martinClone = (Person)martin.Clone();

            Console.WriteLine("Martin Clone: Name: {0}, Age: {1}, Son: {2}", martinClone.Name, martinClone.Age, martinClone.Sons.First().Name);

            Console.WriteLine("Martin is equals to Martin Clone {0}", martin == martinClone);

        }
    }
}

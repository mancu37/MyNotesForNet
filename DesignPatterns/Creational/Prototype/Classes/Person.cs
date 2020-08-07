using MyNotes.DesignPatterns.Creational.Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.Prototype.Classes
{
    public class Person : IPerson
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public IEnumerable<Person> Sons { get; set; }

        public object Clone()
        {
            Person p = (Person) MemberwiseClone();
            p.Sons = new List<Person>();
            p.Sons = Sons;
            return p;
        }

        public object ShallowCopy()
        {
            return MemberwiseClone();
        }


    }
}

using MyNotes.DesignPatterns.Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.AbstractFactory.Classes
{
    public class MonsterEnemy : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Monster Attack!");
        }

        public void GetTypeOfEnemy()
        {
            Console.WriteLine("I'm an Enemy Monster");
        }
    }
}

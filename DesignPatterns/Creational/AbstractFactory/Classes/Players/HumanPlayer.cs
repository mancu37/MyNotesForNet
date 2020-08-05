using MyNotes.DesignPatterns.Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.AbstractFactory.Classes.Players
{
    public class HumanPlayer : IPlayer
    {
        public void Attack()
        {
            Console.WriteLine("Human Player Attack!");
        }

        public void GetTypeOfPlayer()
        {
            Console.WriteLine("I'm a Human Player");
        }
    }
}

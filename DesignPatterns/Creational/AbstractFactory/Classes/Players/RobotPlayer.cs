using MyNotes.DesignPatterns.Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.AbstractFactory.Classes.Players
{
    public class RobotPlayer : IPlayer
    {
        public void Attack()
        {
            Console.WriteLine("Robot Player Attack!");
        }

        public void GetTypeOfPlayer()
        {
            Console.WriteLine("I'm a Robot Player");
        }
    }
}

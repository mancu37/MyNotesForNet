﻿using MyNotes.DesignPatterns.Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.AbstractFactory.Classes
{
    public class RobotEnemy : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Robot Attack!");
        }

        public void GetTypeOfEnemy()
        {
            Console.WriteLine("I'm an Enemy Robot");
        }
    }
}

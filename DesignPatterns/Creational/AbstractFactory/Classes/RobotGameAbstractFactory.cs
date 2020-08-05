using MyNotes.DesignPatterns.Creational.AbstractFactory.Classes.Players;
using MyNotes.DesignPatterns.Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.AbstractFactory.Classes
{
    class RobotGameAbstractFactory : GameAbstractFactory
    {
        public IEnemy CreateEnemy()
        {
            return new RobotEnemy();
        }

        public IPlayer CreatePlayer()
        {
            return new RobotPlayer();
        }
    }
}

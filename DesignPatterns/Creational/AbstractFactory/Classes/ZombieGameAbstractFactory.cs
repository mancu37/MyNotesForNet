using MyNotes.DesignPatterns.Creational.AbstractFactory.Classes.Players;
using MyNotes.DesignPatterns.Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.AbstractFactory.Classes
{
    class ZombieGameAbstractFactory : GameAbstractFactory
    {
        public IEnemy CreateEnemy()
        {
            return new ZombieEnemy();
        }

        public IPlayer CreatePlayer()
        {
            return new HumanPlayer();
        }
    }
}

using MyNotes.DesignPatterns.Creational.AbstractFactory.Classes.Players;
using MyNotes.DesignPatterns.Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.AbstractFactory.Classes
{
    public class RpgGameAbstractFactory : GameAbstractFactory
    {
        public IEnemy CreateEnemy()
        {
            return new MonsterEnemy();
        }

        public IPlayer CreatePlayer()
        {
            return new WizardPlayer();
        }
    }
}

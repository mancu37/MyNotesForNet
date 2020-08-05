using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.AbstractFactory.Interfaces
{
    public interface GameAbstractFactory
    {
        IPlayer CreatePlayer();
        IEnemy CreateEnemy();
    }
}

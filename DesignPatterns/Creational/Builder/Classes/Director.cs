using MyNotes.DesignPatterns.Creational.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.Builder.Classes
{
    public class Director
    {
        IHouseBuilder _builder;

        public Director(IHouseBuilder builder)
        {
            _builder = builder;
        }

        public void CreateHouse()
        {
            _builder.CreateFloor();
            _builder.CreateWall();
            _builder.CreateRoof();
            _builder.CreateDoor();
            _builder.CreateWindow();
            _builder.CreateGarage();
        }

        public void CreateHouseWithoutGarage()
        {
            _builder.CreateFloor();
            _builder.CreateWall();
            _builder.CreateRoof();
            _builder.CreateDoor();
            _builder.CreateWindow();
        }

    }
}

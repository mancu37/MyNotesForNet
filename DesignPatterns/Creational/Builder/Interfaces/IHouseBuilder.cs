using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.Builder.Interfaces
{
    public interface IHouseBuilder
    {
        void CreateWindow();
        void CreateDoor();        
        void CreateRoof();
        void CreateFloor();
        void CreateWall();
        void CreateGarage();
    }

}

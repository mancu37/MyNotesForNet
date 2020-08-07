using MyNotes.DesignPatterns.Creational.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.Builder.Classes
{
    class HouseBuilder : IHouseBuilder
    {
        private House _house;

        public HouseBuilder()
        {
            Console.WriteLine("Starting house building...");
            _house = new House();
        }

        public House GetResult()
        {
            Console.WriteLine("House is ready.");
            return _house;
        }

        public void CreateDoor()
        {
            Console.WriteLine("Creating door...");
        }

        public void CreateFloor()
        {
            Console.WriteLine("Creating floor...");
        }

        public void CreateGarage()
        {
            Console.WriteLine("Creating garage...");
        }

        public void CreateRoof()
        {
            Console.WriteLine("Creating roof...");
        }

        public void CreateWall()
        {
            Console.WriteLine("Creating walls...");
        }

        public void CreateWindow()
        {
            Console.WriteLine("Creating windows...");
        }
    }
}

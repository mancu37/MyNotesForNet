using MyNotes.DesignPatterns.Creational.Builder.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.Builder
{
    class Client
    {
        public Client()
        {
            Console.WriteLine("_-_ Builder _-_");
            Console.WriteLine(" Press 1 to create House");
            Console.WriteLine(" Press 2 to create House with Garage");
            Console.WriteLine(" Press 3 to End");

            while (true)
            {
                string command = Console.ReadLine();
                HouseBuilder builder = new HouseBuilder();

                Director director = new Director(builder);

                House house = null;

                switch (command)
                {

                    case "1":
                        director.CreateHouse();
                        house = builder.GetResult();
                        break;
                    case "2":
                        director.CreateHouseWithoutGarage();
                        house = builder.GetResult();
                        break;
                }

                if (house != null)
                    house.Ready();

                if (command == "3")
                    break;
            }
        }
    }
}

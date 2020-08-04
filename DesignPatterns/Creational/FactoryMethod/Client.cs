using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.FactoryMethod
{
    public class Client
    {
        public Client()
        {
            Console.WriteLine("_-_Factory Method _-_");
            Console.WriteLine(" Press 1 to create Trucks");
            Console.WriteLine(" Press 2 to create Ships");
            Console.WriteLine(" Press 3 to End");

            string command = string.Empty;

            while(true)
            {
                command = Console.ReadLine();

                ITransport transport = null;

                switch (command)
                {

                    case "1":
                        transport = new TruckCreator().CreateTransport();
                        break;
                    case "2":
                        transport = new ShipCreator().CreateTransport();
                        break;
                }

                if(transport != null)
                    Console.WriteLine("{0} created.", transport.GetName());


                if (command == "3")
                    break;
            }

        }
    }
}

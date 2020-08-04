using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.FactoryMethod
{
    public class TruckCreator : ICreatorFactory
    {

        public ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}

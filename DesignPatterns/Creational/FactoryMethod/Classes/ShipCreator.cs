using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.FactoryMethod
{
    public class ShipCreator : ICreatorFactory
    {

        public ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}

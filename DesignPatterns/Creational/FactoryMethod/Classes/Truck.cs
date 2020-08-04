using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.FactoryMethod
{
    public class Truck : ITransport
    {

        public string GetName()
        {
            return "Truck";
        }
    }
}

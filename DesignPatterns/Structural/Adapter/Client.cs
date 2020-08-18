using MyNotes.DesignPatterns.Structural.Adapter.Classes;
using MyNotes.DesignPatterns.Structural.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Structural.Adapter
{
    public class Client
    {
        public Client()
        {
            ITarget adapter = new Adapter.Classes.Adapter(new XmlProvider());
            Console.WriteLine($"{adapter.GetData()}");
        }
    }
}

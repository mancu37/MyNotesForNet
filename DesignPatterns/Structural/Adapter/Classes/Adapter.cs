using MyNotes.DesignPatterns.Structural.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Structural.Adapter.Classes
{
    public class Adapter : ITarget
    {
        private readonly XmlProvider xmlProvider;

        public Adapter(XmlProvider xmlProvider)
        {
            this.xmlProvider = xmlProvider;
        }

        public string GetData()
        {
            string xml = xmlProvider.GetData();

            //Logic to transform XML data source into JSON data source

            return "Json Data";
        }
    }
}

using MyNotes.DesignPatterns.Structural.Bridge.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Structural.Bridge
{
    public class Client
    {
        public Client()
        {
            var abstraction = new Abstraction(new ImplementationInWindows());
            abstraction.Implementation();
            abstraction.OpenFile();
            abstraction.CloseFile();

            var abstractionLinux = new Abstraction(new ImplementationInLinux());
            abstractionLinux.Implementation();
            abstractionLinux.OpenFile();
            abstractionLinux.CloseFile();
        }
    }
}

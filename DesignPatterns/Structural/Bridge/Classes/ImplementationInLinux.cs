using MyNotes.DesignPatterns.Structural.Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Structural.Bridge.Classes
{
    public class ImplementationInLinux : IImplementation
    {
        public void CloseFile()
        {
            Console.WriteLine("Close file in Linux");
        }

        public void Implementation()
        {
            Console.WriteLine("Implementation in Linux");
        }

        public void OpenFile()
        {
            Console.WriteLine("Open file in Linux");
        }
    }
}

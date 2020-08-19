using MyNotes.DesignPatterns.Structural.Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Structural.Bridge.Classes
{
    public class ImplementationInWindows : IImplementation
    {
        public void CloseFile()
        {
            Console.WriteLine("Close file in Windows");
        }

        public void Implementation()
        {
            Console.WriteLine("Implementation in Windows");
        }

        public void OpenFile()
        {
            Console.WriteLine("Open file in Windows");
        }
    }
}

using MyNotes.SOLID_Principles.Liskov.Example1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.SOLID_Principles.Liskov.Example1.Classes
{
    public class Turtle : IWalk
    {
        public void Walk()
        {
            Console.WriteLine("Turtle - Walk");
        }
    }
}

using MyNotes.SOLID_Principles.Liskov.Example1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.SOLID_Principles.Liskov.Example1.Classes
{
    public class Wolf : IRun, IWalk, IHunt
    {
        public void Hunt()
        {
            Console.WriteLine("Wolk - Hunt");
        }

        public void Run()
        {
            Console.WriteLine("Wolk - Run");
        }

        public void Walk()
        {
            Console.WriteLine("Wolk - Walk");
        }
    }
}

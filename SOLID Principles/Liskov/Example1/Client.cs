using MyNotes.SOLID_Principles.Liskov.Example1.Classes;
using MyNotes.SOLID_Principles.Liskov.Example1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.SOLID_Principles.Liskov.Example1
{
    public class Client
    {
        public Client()
        {
            List<IHunt> hunters = new List<IHunt>();
            List<IWalk> walkers = new List<IWalk>();

            Wolf wolf = new Wolf();
            Turtle turtle = new Turtle();

            hunters.Add(wolf);
            walkers.Add(wolf);
            walkers.Add(turtle);

            GoHunt(hunters);
            GoWalk(walkers);
        }

        private void GoHunt(List<IHunt> hunters)
        {
            foreach (var hunter in hunters)
            {
                hunter.Hunt();
            }
        }

        private void GoWalk(List<IWalk> walkers)
        {
            foreach (var walker in walkers)
            {
                walker.Walk();
            }
        }
    }
}

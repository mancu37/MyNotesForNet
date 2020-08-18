using MyNotes.POO.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.POO
{
    public class Client
    {
        public Client()
        {
            Human human = new Human("Martin");
            Console.WriteLine(human.Name);


        }
    }
}

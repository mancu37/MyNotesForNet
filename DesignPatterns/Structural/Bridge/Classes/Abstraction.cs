using MyNotes.DesignPatterns.Structural.Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Structural.Bridge.Classes
{
    public class Abstraction
    {
        IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            _implementation = implementation;
        }

        public IImplementation IImplementation
        {
            get => default;
            set
            {
            }
        }

        public void Implementation()
        {
            _implementation.Implementation();
        }

        public void OpenFile()
        {
            _implementation.OpenFile();
        }

        public void CloseFile()
        {
            _implementation.CloseFile();
        }
    }
}

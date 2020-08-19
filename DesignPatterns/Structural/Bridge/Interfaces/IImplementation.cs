using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Structural.Bridge.Interfaces
{
    public interface IImplementation
    {
        void Implementation();
        void OpenFile();
        void CloseFile();
    }
}

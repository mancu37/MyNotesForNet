using MyNotes.SOLID_Principles.Dependency_Inversion.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.SOLID_Principles.Dependency_Inversion.Classes
{
    public class GoogleEmailService : IEmailService
    {
        public void Send()
        {
            //This code works with Google client library
        }
    }
}

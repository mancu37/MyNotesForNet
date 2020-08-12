using MyNotes.SOLID_Principles.Dependency_Inversion.Classes;
using MyNotes.SOLID_Principles.Dependency_Inversion.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.SOLID_Principles.Dependency_Inversion
{
    public class Client
    {
        public Client()
        {
        }

        public void SendEmail(IEmailService emailService)
        {
            emailService.Send();
        }
    }
}

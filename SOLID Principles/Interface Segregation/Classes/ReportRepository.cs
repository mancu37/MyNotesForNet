using MyNotes.SOLID_Principles.Interface_Segregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.SOLID_Principles.Interface_Segregation.Classes
{
    public class ReportRepository : IReadable<Report>
    {
        public IEnumerable<Report> GetAll()
        {
            var view = new List<Report>();
            //Code to retrieve all
            return view;
        }

        public Report GetById(int id)
        {
            //Code to get a specific user
            return new Report();
        }
    }
}

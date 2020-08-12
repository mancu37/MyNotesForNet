using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.SOLID_Principles.Interface_Segregation.Interfaces
{
    public interface IReadable<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}

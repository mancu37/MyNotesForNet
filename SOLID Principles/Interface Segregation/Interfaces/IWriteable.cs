using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.SOLID_Principles.Interface_Segregation.Interfaces
{
    public interface IWriteable<T>
    {
        void Add(T entity);
        void Update(T entity);
    }
}

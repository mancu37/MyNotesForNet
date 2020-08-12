using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.SOLID_Principles.Interface_Segregation.Interfaces
{
    public interface IRemovable<T>
    {
        void Delete(int id);
    }
}

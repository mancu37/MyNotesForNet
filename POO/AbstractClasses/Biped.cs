using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MyNotes.POO.AbstractClasses
{
    /// <summary>
    /// En las clases abstractas definimos caracteristicas de un tipo de objeto, especificando como es el objeto.
    /// La palabra clave abstract permite crear clases y miembros class que están incompletos y se deben implementar en una clase derivada.
    /// 
    /// </summary>
    public abstract class Biped
    {
        public string Name { get; private set; }

        public Biped(string name)
        {
            this.Name = name;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2_Camilla
{
    internal class Pizza
    {
        #region Properties of a Pizza
        public string Number { get; } //Number is a string, as some pizzarias have a number 22a or so forth.
        public string Name { get; }
        public int Size { get; }
        public int Bottom { get; }
        public string Ingredients { get; }
        #endregion

        #region Constructor for the Pizza
        public Pizza(string number, string name, int size, int bottom, string ingredients)
        {
            Number = number;
            Name = name;
            Size = size;
            Bottom = bottom;
            Ingredients = ingredients;  
        }
        #endregion
    }
}

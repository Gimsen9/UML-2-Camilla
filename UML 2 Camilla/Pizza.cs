using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2_Camilla
{
    public class Pizza
    {
        #region Properties of a Pizza
        public string Number { get; } //Number is a string, as some pizzarias have a number 22a or so forth.
        public string Name { get; }
        public int Size { get; } //This is a placeholder for now.
        public int Bottom { get; }//This is also a placeholder for now.
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

        public override string ToString()
        {
            return $"{Number} {Name} \t {Size} \t{Bottom} \t {Ingredients}";
        }
    }
}

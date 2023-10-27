using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2_Camilla
{
    public class PizzaListe
    {

        #region Instance fields
        private Dictionary<string, Pizza> _pizza;
        #endregion

        #region Constructor
        public PizzaListe()
        {
            _pizza = new Dictionary<string, Pizza>();
        }
        #endregion

        #region Properties for the menu
        public int Count
        {
            get { return _pizza.Count; }
        }
        #endregion

        #region Methods
     
        public void AddPizza(Pizza aPizza)
        {
            _pizza.Add(aPizza.Number, aPizza);
        }

     
        public Pizza? LookupPizza(string number)
        {
            return _pizza.ContainsKey(number) ? _pizza[number] : null;
        }

        
        public void DeletePizza(string number)
        {
            _pizza.Remove(number);
        }

        public void UpdatePizza(string number, Pizza aPizza)
        {

            _pizza[number] = aPizza;


        }
        public void PrintPizza()
        {

            foreach(var pizza in _pizza)
            {
                Console.WriteLine(pizza.Value.ToString());

            }



        }
        #endregion
    }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2_Camilla
{
    public class CustomerListe
    {

        #region Instance fields
        private Dictionary<string, Customer> _customer;
        #endregion

        #region Constructor
        public CustomerListe()
        {
            _customer = new Dictionary<string, Customer>();
        }
        #endregion

        #region Properties for the menu
        public int Count
        {
            get { return _customer.Count; }
        }
        #endregion

        #region Methods
     
        public void AddCustomer(Customer aCustomer)
        {
            _customer.Add(aCustomer.Name, aCustomer);
        }

     
        public Customer? LookupCustomer(string name)
        {
            return _customer.ContainsKey(name) ? _customer[name] : null;
        }

        
        public void DeleteCustomer(string name)
        {
            _customer.Remove(name);
        }

        public void UpdateCustomer(string number, Customer aCustomer)
        {

            _customer[number] = aCustomer;


        }
        public void PrintCustomer()
        {

            foreach (var customer in _customer)
            {
                Console.WriteLine(customer.Value.ToString());

            }



        }
        #endregion
    }
}

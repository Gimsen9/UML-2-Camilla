using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UML;

namespace UML_2_Camilla
{
    internal class Customer
    {
        #region Properties of a Customer
        public int Phone { get; }
        public string Name { get; }
        public string Email { get; }
        public bool MemberStatus { get; }
        public string Address { get; }
        #endregion




        #region Constructor for the Customer
        public Customer(int phone, string name, string email, bool memberStatus, string address)
        {
            Phone = phone;
            Name = name;
            Email = email;
            MemberStatus = memberStatus;
            Address = address;
        }
        #endregion
    }
}


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UML_2_Camilla;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UML_2_Camilla
{
    public class Customer
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

        public override string ToString()
        {
            return $"{Phone} {Name} \t {Email} \t{MemberStatus} \t {Address}";
        }
    }
}


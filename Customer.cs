using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    class Customer
    {

        //Vi får oprettet objekter i vores i vores Customer klasse
        private string _customerName;
        private string _customerAdress;
        private int _customerNumber;
        private string _customerEmail;
        //Vi sætter properties på for at kunne genkende vores objekter
        public Customer(string customerName, string customerAdress, int customerNumber, string customerEmail)
        {
            _customerName = customerName;
            _customerAdress = customerAdress;
            _customerNumber = customerNumber;
            _customerEmail = customerEmail;
        }
        //oprettelse af constructor
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }
        public string CustomerAdress
        {
            get { return _customerAdress; }
            set { _customerAdress = value; }
        }
        public int CustomerNumber
        {
            get { return _customerNumber; }
            set { _customerNumber = value; }
        }
        public string CustomerEmail
        {
            get { return _customerEmail; }
            set { _customerEmail = value; }
        }
        // Oprettelse af tostring metode
            public override string ToString()
        {
            return "Name: " + _customerName +  "\n" + "Adress: " + _customerAdress + "\n" + "Housenumber: " + _customerNumber + "\n" + "Email: " + _customerEmail; 
        }


    }
    }

    


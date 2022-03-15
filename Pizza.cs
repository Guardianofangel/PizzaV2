using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    class Pizza
    {
        // oprettelse af objekter
        private string _name;
        private string _topping;
        private double price;

        //oprettelse af properties
        public Pizza(string name, string topping, double price)


        {
            _name = name;
            _topping = topping;
            this.price = price;

        }
        //oprettelse af constructor
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Topping
        {
            get { return _topping; }
            set { _topping = value; }
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }
        public double GetPrice()
        {
            return price;
        }

        // oprettelse af tostring metode
        public override string ToString()
        {
            return "\n" + "Order: " + _name + "with " + _topping + "\n" + "Price: " + this.price + "DKK";
        }

    }
}    

     

    

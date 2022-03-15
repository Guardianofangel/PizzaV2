using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Pizza
{
    class Order


    {


        private string _orderID;
        private string _orderPayment;
        private bool _orderDeliver;

        private double totalPrice;
        //vi indhenter Pizza klasses til vores Order klassen
        private Pizza pizza;
        private Customer customer;

        // oprettelse af properties
        public Order(string orderID, string orderPayment, bool orderDeliver, Pizza pizza, Customer customer)
        {
            _orderID = orderID;
            _orderPayment = orderPayment;
            _orderDeliver = orderDeliver;
            this.pizza = pizza;
            this.customer = customer;
            TotalPrice(this.pizza.GetPrice());
        }
        //Oprettelse ad constructor
        public string orderID
        {
            get { return _orderID; }
            set { orderID = value; }
        }
        public string orderPayment
        {
            get { return _orderPayment; }
            set { _orderPayment = value; }
        }
        public bool orderDeliver
        {
            get { return _orderDeliver; }
            set { _orderDeliver = value; }
        }

        // totalprice metode
        public void TotalPrice(double price)
        {
            double tax = 0.10 * price;
            double totalPrice = price + 40;
            this.totalPrice = totalPrice + tax;
        }
        public double GetTotalPrice()
        {
            return this.totalPrice;
        }
        public Customer GetCustomer()
        {
            return this.customer;
        }
        // oprettelse af tostring metode
        public override string ToString()
        {
            return this.customer + "\n" + this.pizza + "\n" + "\n" + "OrderID:" + _orderID + "\n" + "CardType:" + _orderPayment + "\n" + this.totalPrice + " DKK" + "\n" + _orderDeliver + "\n" + "Print receipt"  ;
        }        
          
    }
    }

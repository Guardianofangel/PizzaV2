using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    class Store
    {

        public void MyCode()
        {


              
                 // Vi opretter 3 nye objekter gennem vores klasse 
                 Pizza p1 = new Pizza("Margharita ", "onions", 50 ) ;
                 Pizza p2 = new Pizza("Punjab ", "meatballs", 60);
                 Pizza p3 = new Pizza("Mario ", "potato", 75);
                 // Vi opretter 3 nye Customers gennem vores klasse
                 Customer c1 = new Customer("Henrik Andersen", "henrikvej ", 25 , "henrikersej@hotmail.com ");
                 Customer c2 = new Customer("Flemming Jensen ", "Mikkelsensvej ", 37, "Fmik@outlook.com ");
                 Customer c3 = new Customer("Brian Hansen ", "kundevevej", 56, "HB@gmail.com");
                
                 // Vi opretter 3 nye Order og sammensætter dem med vores Klasse Pizza og Customer
                 Order o1 = new Order("001 ", " Visa Electron", true, p1 , c1);
                 Order o2 = new Order("002 ", " Master Card", true , p2 , c2);
                 Order o3 = new Order("003 ", " Lunar Card", true, p3, c3);

            // Her udskrives de
            Console.WriteLine("Total Price With Delivery: " + o1.ToString());
            Console.WriteLine("\n" + "Press Enter for next costumer");
            Console.ReadLine();
            Console.WriteLine("Total Price With Delivery: " + o2.ToString());
            Console.WriteLine("\n" + "Press Enter for next costumer");
            Console.ReadLine();
            Console.WriteLine("Total Price With Delivery: " + o3.ToString());
            Console.WriteLine("Afslut med Enter");
           

                   
        }
    }
}

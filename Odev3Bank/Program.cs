using System;
using System.Collections.Generic;

namespace Odev3Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            // Adding customers
            Customer customer1 = new Customer(1, "Zeynep", "DURNA");
            Customer customer2 = new Customer(2, "Dodo", "ISLER");

            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);

            // Listing customers
            customerManager.ListCustomers();

            // Deleting a customer
            customerManager.DeleteCustomer(1);

            // Updated customer list
            customerManager.ListCustomers();

            Console.ReadLine();
        }
    }
}

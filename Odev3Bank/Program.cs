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
            Customer customer1 = new Customer(1, "John", "Doe");
            Customer customer2 = new Customer(2, "Jane", "Smith");

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

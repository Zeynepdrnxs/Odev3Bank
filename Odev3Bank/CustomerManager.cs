using System;
using System.Collections.Generic;

namespace Odev3Bank
{
    class CustomerManager
    {
        private List<Customer> customers = new List<Customer>();

        // Method to add a new customer
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        // Method to list all customers
        public void ListCustomers()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine($"ID: {customer.Id}, First Name: {customer.FirstName}, Last Name: {customer.LastName}");
            }
        }

        // Method to delete a specific customer
        public void DeleteCustomer(int customerId)
        {
            Customer customerToRemove = customers.Find(x => x.Id == customerId);

            if (customerToRemove != null)
            {
                customers.Remove(customerToRemove);
                Console.WriteLine("Customer successfully deleted.");
            }
            else
            {
                Console.WriteLine("Customer with the specified ID not found.");
            }
        }

    }
}

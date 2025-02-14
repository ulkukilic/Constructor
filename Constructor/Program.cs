using System;
using System.Collections.Generic;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating and displaying a customer manager instance with 5 customers
            CustomerManager customerManager = new CustomerManager(5);
            customerManager.List();

            // Adding some customers
            customerManager.Add(new Customer(1, "ULKU KILIC"));
            customerManager.Add(new Customer(2, "NILUFER BEYZA"));
            customerManager.List();

            // Creating and displaying product information
            Product product = new Product(2, "Computer", 1500, "Electronics");
            product.DisplayDetails();

            Console.ReadLine();
        }
    }

    // Customer class to represent customer details
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // Constructor to initialize customer with ID and Name
        public Customer(int id, string name)
        {
            ID = id;
            Name = name;
        }

        // Method to display customer details
        public void DisplayCustomerDetails()
        {
            Console.WriteLine($"Customer ID: {ID}, Name: {Name}");
        }
    }

    // CustomerManager class to manage a list of customers
    class CustomerManager
    {
        private List<Customer> customers;  // List to store customers

        public CustomerManager(int initialCount)
        {
            customers = new List<Customer>(initialCount);  // Initialize the list with initial capacity
            Console.WriteLine($"Customer Manager initialized with capacity for {initialCount} customers.");
        }

        // Method to list all customers
        public void List()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No customers to list.");
            }
            else
            {
                Console.WriteLine("Listing all customers:");
                foreach (var customer in customers)
                {
                    customer.DisplayCustomerDetails();
                }
            }
        }

        // Method to add a customer to the list
        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine($"Customer {customer.Name} added.");
        }
    }

    // Product class to represent product details
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        // Constructor that takes parameters for ID, Name, Price, and Category
        public Product(int id, string name, decimal price, string category)
        {
            ID = id;
            Name = name;
            Price = price;
            Category = category;
            Console.WriteLine($"Product created: ID = {id}, Name = {name}, Price = {price}, Category = {category}");
        }

        // Method to display product details
        public void DisplayDetails()
        {
            Console.WriteLine($"Product ID: {ID}, Name: {Name}, Price: {Price}, Category: {Category}");
        }
    }
}

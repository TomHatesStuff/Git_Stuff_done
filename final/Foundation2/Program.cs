using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create products
        Product product1 = new Product("Laptop", "P001", 800.00, 2);
        Product product2 = new Product("Mouse", "P002", 20.00, 5);

        // Create addresses
        Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
        Address address2 = new Address("456 Oak St", "Townsville", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "P003", 300.00, 1));

        // Display results
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine("\nTotal Price: $" + order.GetTotalPrice());
        Console.WriteLine("------------------------------");
    }
}

class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in products)
        {
            totalPrice += product.Price * product.Quantity;
        }

        // Add shipping cost based on customer's location
        if (customer.IsInUSA())
        {
            totalPrice += 5.00;
        }
        else
        {
            totalPrice += 35.00;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in products)
        {
            packingLabel += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{customer.Name}\n{customer.Address.GetFormattedAddress()}";
    }
}

class Product
{
    public string Name { get; private set; }
    public string ProductId { get; private set; }
    public double Price { get; private set; }
    public int Quantity { get; private set; }

    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }
}

class Customer
{
    public string Name { get; private set; }
    public Address Address { get; private set; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }
}

class Address
{
    private string StreetAddress;
    private string City;
    private string StateProvince;
    private string Country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.ToUpper() == "USA";
    }

    public string GetFormattedAddress()
    {
        return $"{StreetAddress}, {City}, {StateProvince}, {Country}";
    }
}

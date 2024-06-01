using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("174 North", "Provo", "Utah 84606", "USA");
        Customer customer1 = new Customer("Alexis Francisco Araya", address1);
        List<Product> productsList1 = new List<Product>();

        Product productA1 = new Product("524Z", "Eraser", 5.99, 1);
        Product productA2 = new Product("852E", "paper", 6.50, 1);
        Product productA3 = new Product("324A","Pencil", 1.99, 12);

        productsList1.Add(productA1);
        productsList1.Add(productA2);
        productsList1.Add(productA3);

        Order order1 = new Order(productsList1, customer1);

    
        Console.WriteLine("Order Number: 1");
        Console.WriteLine("==========================");
        order1.DisplayResults();
        Console.WriteLine();

        // Order 2
        Address address2 = new Address("777 East 15th St", "Edmond", "OK 73013", "USA");
        Customer customer2 = new Customer("Blake A. Larsen", address2);
        List<Product> productsList2 = new List<Product>();

        Product productB1 = new Product("P678", "Pen", 4.09, 6);
        Product productB2 = new Product("N980", "Notebook", 1.75, 3);
        Product productB3 = new Product("C678", "Colors", 10.50, 1);

        productsList2.Add(productB1);
        productsList2.Add(productB2);
        productsList2.Add(productB3);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        Console.WriteLine("==========================");
        order2.DisplayResults();
        Console.WriteLine();

        // Order 3
        Address address3 = new Address("Calle el Calvario", "El Hatillo", "Miranda 8109", "Venezuela");
        Customer customer3 = new Customer("Iria Pinero", address3);
        List<Product> productsList3 = new List<Product>();

        Product productC1 = new Product("P234", "Pencils", 5.10, 1);
        Product productC2 = new Product("M221", "Markers", 4.99, 2);
        Product productC3 = new Product("B344","backpack", 25.09,1);

        productsList3.Add(productC1);
        productsList3.Add(productC2);
        productsList3.Add(productC3);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        Console.WriteLine("==========================");
        order3.DisplayResults();
        Console.WriteLine();
    }
}
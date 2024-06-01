using System;

public class Product 
{
    private string _productID;
    private string _name;
    private double _price;
    private int _quantity;

    public  Product(string productID, string name, double price, int quantity)
    {
        _productID = productID;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public double CalculatePrice()
    {
        return _price * _quantity;
    }
    
    public string GetProductID()
   {
        return _productID;
   }
    public string GetName()
    {
        return _name;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}
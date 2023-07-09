using System;

class Shirt
{
    public string Type { get; set; }
    public string Size { get; set; }
    public double Price { get; set; }

    public Shirt(string type, string size, double price)
    {
        Type = type;
        Size = size;
        Price = price;
    }

    public void DisplayOrderSummary()
    {
        Console.WriteLine("\nOrder Summary:");
        Console.WriteLine("---------------");
        Console.WriteLine($"Shirt Type: {Type}");
        Console.WriteLine($"Size: {Size}");
        Console.WriteLine($"Price: ${Price}");
    }
}

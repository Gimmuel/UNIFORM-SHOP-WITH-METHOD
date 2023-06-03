using System;
using System.Collections.Generic;

class Program
{
    static List<string> shirtTypes = new List<string> { "T-Shirt", "Polo Shirt", "Button-down Shirt" };
    static List<string> sizes = new List<string> { "Small", "Medium", "Large", "XL" };

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Uniform Shop!");

        bool continueShopping = true;

        while (continueShopping)
        {
            DisplayShirtTypes();
            DisplaySizes();

            int shirtTypeIndex = GetSelectedIndex("Enter the number corresponding to the shirt type: ", shirtTypes.Count);
            int sizeIndex = GetSelectedIndex("Enter the number corresponding to the size: ", sizes.Count);

            if (shirtTypeIndex == -1 || sizeIndex == -1)
            {
                Console.WriteLine("Invalid selection. Please try again.");
                continue;
            }

            string selectedShirtType = shirtTypes[shirtTypeIndex];
            string selectedSize = sizes[sizeIndex];
            double price = 20.00;

            DisplayOrderSummary(selectedShirtType, selectedSize, price);

            Console.WriteLine("\nPayment Options:");
            Console.WriteLine("Cash");

            double cashAmount = GetCashAmount("Enter the amount in cash: ");

            if (cashAmount < price)
            {
                Console.WriteLine("Insufficient cash amount. Please try again.");
                continue;
            }

            double change = cashAmount - price;

            Console.WriteLine($"Payment successful! Change: ${change:F2}. Your order has been placed.");

            Console.WriteLine("\nDo you want to place another order? (yes/no)");
            string answer = Console.ReadLine().ToLower();

            if (answer != "yes")
                continueShopping = false;
        }

        Console.WriteLine("\nThank you for shopping with us!");
    }

    static void DisplayShirtTypes()
    {
        Console.WriteLine("\nAvailable Shirt Types:");
        for (int i = 0; i < shirtTypes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {shirtTypes[i]}");
        }
    }

    static void DisplaySizes()
    {
        Console.WriteLine("Available Sizes:");
        for (int i = 0; i < sizes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {sizes[i]}");
        }
    }

    static int GetSelectedIndex(string prompt, int maxIndex)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out int selectedIndex) && selectedIndex >= 1 && selectedIndex <= maxIndex)
        {
            return selectedIndex - 1;
        }
        return -1;
    }

    static void DisplayOrderSummary(string selectedShirtType, string selectedSize, double price)
    {
        Console.WriteLine("\nOrder Summary:");
        Console.WriteLine("---------------");
        Console.WriteLine($"Shirt Type: {selectedShirtType}");
        Console.WriteLine($"Size: {selectedSize}");
        Console.WriteLine($"Price: ${price}");
    }

    static double GetCashAmount(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double cashAmount) && cashAmount >= 0)
            {
                return cashAmount;
            }
            Console.WriteLine("Invalid amount. Please try again.");
        }
    }
}
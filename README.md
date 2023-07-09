# using System;
using System.Collections.Generic;

class UniformShop
{
    private List<string> shirtTypes;
    private List<string> sizes;

    public UniformShop()
    {
        shirtTypes = new List<string> { "T-Shirt", "Polo Shirt", "Button-down Shirt" };
        sizes = new List<string> { "Small", "Medium", "Large", "XL" };
    }

    public void Run()
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

            Shirt shirt = new Shirt(selectedShirtType, selectedSize, price);

            shirt.DisplayOrderSummary();

            Console.WriteLine("\nDo you want to place another order? (yes/no)");
            string answer = Console.ReadLine().ToLower();

            if (answer != "yes")
                continueShopping = false;
        }

        Console.WriteLine("\nThank you for shopping with us!");
    }

    private void DisplayShirtTypes()
    {
        Console.WriteLine("\nAvailable Shirt Types:");
        for (int i = 0; i < shirtTypes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {shirtTypes[i]}");
        }
    }

    private void DisplaySizes()
    {
        Console.WriteLine("Available Sizes:");
        for (int i = 0; i < sizes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {sizes[i]}");
        }
    }

    private int GetSelectedIndex(string prompt, int maxIndex)
    {  
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out int selectedIndex) && selectedIndex >= 1 && selectedIndex <= maxIndex)
        {
            return selectedIndex - 1;
        }
        return -1;
    }
}

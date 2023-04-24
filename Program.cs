using System;

class ItemBagSystem
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of items in your bag:");
        int numItems = Convert.ToInt32(Console.ReadLine());

        string[] itemNames = new string[numItems];
        string[] itemTypes = new string[numItems];

        for (int i = 0; i < numItems; i++)
        {
            Console.WriteLine("Enter the details for item " + (i+1) + ":");
            Console.WriteLine("Item name:"); itemNames[i] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Item type:"); itemTypes[i] = Console.ReadLine();
            Console.WriteLine();
        }

        while (true)
        {
            Console.WriteLine("Enter item search mode ('ShowAll' or an item type, or 'Any word' to exit):");
            string searchMode = Console.ReadLine();

            if (searchMode == "ShowAll")
            {
                for (int i = 0; i < numItems; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine(itemNames[i] + " - " + itemTypes[i]);
                    Console.WriteLine();
                    
                }
            }
            else if (Array.IndexOf(itemTypes, searchMode) != -1)
            {
                for (int i = 0; i < numItems; i++)
                {
                    if (itemTypes[i] == searchMode)
                    {
                        Console.WriteLine(itemNames[i]);
                    }
                }
            }

            else
            {
                Console.WriteLine("End");
                break;
            }

            Console.WriteLine();
        }
    }
}
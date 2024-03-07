public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // TODO: Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // TODO: Update the item's price with the new price.
        Price = newPrice;
        Console.WriteLine($"Price of {ItemName} has been updated as: {Price:C}\n");
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
        Console.WriteLine($"{additionalQuantity} quantity of {ItemName}(s) added to stock. The new stock quantity is: {QuantityInStock}\n");
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        if (quantitySold <= QuantityInStock)
        {
            QuantityInStock -= quantitySold;
            Console.WriteLine($"Sold {quantitySold} {ItemName}(s). Remaining quantity of stock is: {QuantityInStock}");
        }
        else
        {
            Console.WriteLine($"{quantitySold} of {ItemName}(s) are not valid\n");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        if (QuantityInStock >= 0)
        {
            Console.WriteLine($"Item : {ItemName}, ID: {ItemId}, Price: {Price:C}, stock quantity: {QuantityInStock}");
        }
        else
        {
            Console.WriteLine($"Error: Invalid quantity of stock for {ItemName}. Please check stock records.");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        Console.WriteLine("Initial Item Details:\n");
        item1.PrintDetails();
        item2.PrintDetails();

        // 2. Sell some items and then print the updated details.
        Console.WriteLine("\nSelling some Items:");
        item1.SellItem(10);
        item2.SellItem(12);
        Console.WriteLine("\nUpdated Details of the item after selling:");
        item1.PrintDetails();
        item2.PrintDetails();

        // 3. Restock an item and print the updated details.
        Console.WriteLine("\nRestocking the Items:");
        item1.RestockItem(0);
        item2.RestockItem(5);
        Console.WriteLine("\nUpdated Details of items after restocking:");
        item1.PrintDetails();
        item2.PrintDetails();

        // 4. Check if an item is in stock and print a message accordingly.
        Console.WriteLine("\nChecking if an item is in Stock:");
        //Console.WriteLine($"Is {item1.ItemName} in stock? {item1.IsInStock()}");
        //Console.WriteLine($"Is {item2.ItemName} in stock? {item2.IsInStock()}");
        if (item1.IsInStock())
        {
            Console.WriteLine($"{item1.ItemName} is in stock.");
        }
        else
        {
            Console.WriteLine($"{item1.ItemName} is out of stock.");
        }

        if (item2.IsInStock())
        {
            Console.WriteLine($"{item2.ItemName} is in stock.");
        }
        else
        {
            Console.WriteLine($"{item2.ItemName} is out of stock.");
        }
    }
}
using BeargrassThunderPlants;
using System.Text.Json;
using System.Text.Json.Serialization;

var plantLogic = new PlantLogic();

Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Press 2 to view a flower product");
Console.WriteLine("Press 3 to view in stock products");
Console.WriteLine("Type 'exit' to quit");

string userInput = Console.ReadLine();

while (userInput.ToLower() != "exit")

{
    if (userInput == "1")
    {
        var flower = new Flowers();

        Console.WriteLine("Creating a flower...");

        Console.Write("Enter the name of the flower: ");
        flower.Name = Console.ReadLine();

        Console.Write("Enter the height in inches: ");
        flower.Height = int.Parse(Console.ReadLine());

        Console.Write("Enter the color of the flower bloom: ");
        flower.Color = Console.ReadLine();

        Console.Write("Give the product a short description: ");
        flower.Description = Console.ReadLine();

        Console.Write("Give the product a price: ");
        flower.Price = decimal.Parse(Console.ReadLine());

        Console.Write("How many products do you have on hand? ");
        flower.Quantity = int.Parse(Console.ReadLine());

        plantLogic.AddPlant(flower);
        Console.WriteLine("Added a flower");
    }
    if (userInput == "2")
    {
    Console.Write("What is the name of the flower you would like to view? ");
    var flowerName = Console.ReadLine();
    var flower = plantLogic.GetFlowersByName(flowerName);
    Console.WriteLine(JsonSerializer.Serialize(flower));
    Console.WriteLine();
    }
    if (userInput == "3")
    {
        Console.WriteLine("The following products are in stock: ");
        var inStock = plantLogic.GetOnlyInStockProducts();
        foreach (var item in inStock)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }

    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Press 2 to view a Flower Product");
    Console.WriteLine("Press 3 to view in stock products");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();
}
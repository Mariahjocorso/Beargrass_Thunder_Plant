using BeargrassThunderPlants;
using System.Text.Json;
using System.Text.Json.Serialization;


Console.WriteLine("Press 1 to add a product");
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

        Console.WriteLine(JsonSerializer.Serialize(flower));
    }

    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();
}

